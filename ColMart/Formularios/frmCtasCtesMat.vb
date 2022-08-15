Public Class frmCtasCtesMat
    Dim debe, haber, saldo, saldoant, pagado, resto As Decimal
    Dim detalle, comprobante, estado, id, obs, fecpago, fechaaux As String
    Dim pos1, pos2, longitud, cantidad As Integer
    Dim yyyy, mm, dd, ceros, estadomatri As String

    Private Sub frmCtasCtesMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CtasctesTableAdapter.Fill(DbcolmartDataSet.ctasctes)
        dgvCtasctes.DataSource = Nothing
        txtMatricula.Focus()
        lblEstado.Text = ""

        If nivel > "3" Then
            btnActualizar.Enabled = False
        End If

    End Sub

    Private Sub txtMatricula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 7
            Dim frmMat7 As New frmConsMatri
            AddOwnedForm(frmMat7)
            frmMat7.ShowDialog()
            senial = 0
            LeerMatriculado()
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerMatriculado()
        End If

    End Sub

    Private Sub txtMatricula_MouseHover(sender As Object, e As EventArgs) Handles txtMatricula.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Matrícula."
        ToolTipMsg.SetToolTip(txtMatricula, "Presione F1 para buscar la matrícula deseada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerMatriculado()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = " & txtMatricula.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelyNomb.Text = CStr(row("ApelNombMatri"))
            lblEstado.Text = CStr(row("EstadoMatri"))
            estadomatri = CStr(row("EstadoMatri"))
        Else
            txtApelyNomb.Text = ""
        End If

        SaldoCtaCte()

    End Sub

    Private Sub SaldoCtaCte()

        comando.CommandText = "SELECT * FROM ctasctes WHERE NroCC = " & txtMatricula.Text & " ORDER BY FechaCC, NrocbteCC, ItemCC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCtasctes.DataSource = dt

        dgvCtasctes.Sort(dgvCtasctes.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        debe = 0
        haber = 0
        saldo = 0
        saldoant = 0
        comprobante = ""

        If dgvCtasctes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasctes.Rows
                If Not Fila Is Nothing Then
                    debe = Fila.Cells(8).Value
                    haber = Fila.Cells(9).Value
                    saldo = saldoant + debe - haber
                    Fila.Cells(10).Value = saldo
                    saldoant = saldo
                    detalle = Fila.Cells(6).Value
                    comando.CommandText = "UPDATE ctasctes SET SaldoCC = '" & saldo & "' WHERE DetalleCC = '" & detalle & "' AND NroCC = '" & txtMatricula.Text & "' "
                    comando.ExecuteNonQuery()
                    If Fila.Cells(11).Value = "PENDIENTE" Or Fila.Cells(11).Value = "LIQUIDADA" Then
                        Fila.DefaultCellStyle.ForeColor = Color.Orange
                        'Fila.Cells(11).Style.ForeColor = Color.Red
                        'Fila.Cells(11).Style.ForeColor = Color.Orange
                    End If
                    If Fila.Cells(5).Value > 1 Then
                        Fila.Cells(2).Value = DBNull.Value
                        Fila.Cells(3).Value = ""
                        Fila.Cells(4).Value = DBNull.Value
                        Fila.Cells(7).Value = DBNull.Value
                    End If
                    If Fila.Cells(13).Value = "1900-01-01" Then
                        Fila.Cells(13).Value = DBNull.Value
                    End If
                End If
            Next
            dgvCtasctes.FirstDisplayedScrollingRowIndex = dgvCtasctes.RowCount - 1
            dgvCtasctes.Rows(dgvCtasctes.RowCount - 1).Selected = True
        Else
            detmsg = "No posee movimientos en la Cuenta Corriente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        txtSaldo.Text = saldo
        FormatoMoneda(txtSaldo)
        dgvCtasctes.Refresh()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        For i As Integer = 0 To dgvCtasctes.Rows.Count - 1

            id = dgvCtasctes.Rows(i).Cells(0).Value()
            debe = dgvCtasctes.Rows(i).Cells(8).Value()
            haber = dgvCtasctes.Rows(i).Cells(9).Value()
            saldo = dgvCtasctes.Rows(i).Cells(10).Value()
            estado = dgvCtasctes.Rows(i).Cells(11).Value()
            pagado = dgvCtasctes.Rows(i).Cells(12).Value()
            If estado = "PENDIENTE" Then
                fecpago = "1900-01-01"
            Else
                If IsDBNull(dgvCtasctes.Rows(i).Cells(13).Value()) Then
                    fecpago = "1900-01-01"
                Else
                    fechajob = dgvCtasctes.Rows(i).Cells(13).Value()
                    ProcesarFecha()
                    fecpago = fechadb
                End If
            End If
            resto = dgvCtasctes.Rows(i).Cells(14).Value()
            obs = dgvCtasctes.Rows(i).Cells(15).Value()

            comando.CommandText = "UPDATE ctasctes SET DebeCC = '" & debe & "', HaberCC = '" & haber & "', SaldoCC = '" & saldo & "', EstadoCC = '" & estado & "'," _
                                  & " PagadoCC = '" & pagado & "', FecPagoCC = '" & fecpago & "', RestoCC = '" & resto & "', ObsCC = '" & obs & "'" _
                                  & " WHERE id_CC = '" & id & "' AND NroCC = '" & txtMatricula.Text & "' "
            comando.ExecuteNonQuery()

        Next

        txtMatricula.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtMatricula.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        comando = New MySqlCommand("DELETE FROM impctacte", conexion)
        dr = comando.ExecuteReader
        dr.Close()

        Procesar()

        Dim frm As New frmImpCtaCte
        frm.txtUser.Text = user
        frm.txtDetalle.Text = "Listado de Cuenta Corriente del Matriculado * " + txtMatricula.Text + " * " + txtApelyNomb.Text + " * ESTADO: " + estadomatri + " *"
        frm.ShowDialog()

    End Sub

    Private Sub Procesar()

        comando.CommandText = "SELECT * FROM ctasctes WHERE NroCC = " & txtMatricula.Text & " ORDER BY FechaCC, NroCbteCC, ItemCC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)

        For Each row In dt.Rows

            comando = New MySqlCommand("INSERT INTO impctacte VALUES(@id, @matri, @fecha, @tipo, @numero, @item, @detalle, @periodo, @debe, @haber,@saldo, @estado, @pagado, " _
                                       & "@fecpago, @resto, @obs)", conexion)
            comando.Parameters.AddWithValue("@id", CStr(row("id_CC")))
            comando.Parameters.AddWithValue("@matri", CStr(row("NroCC")))

            fechajob = CStr(row("FechaCC"))
            ProcesarFecha()
            comando.Parameters.AddWithValue("@fecha", fechadb)
            comando.Parameters.AddWithValue("@tipo", CStr(row("TipoCbteCC")))
            comando.Parameters.AddWithValue("@numero", CStr(row("NroCbteCC")))
            comando.Parameters.AddWithValue("@item", CStr(row("ItemCC")))
            comando.Parameters.AddWithValue("@detalle", CStr(row("DetalleCC")))
            comando.Parameters.AddWithValue("@periodo", CStr(row("PeriodoCC")))
            comando.Parameters.AddWithValue("@debe", CStr(row("DebeCC")))
            comando.Parameters.AddWithValue("@haber", CStr(row("HaberCC")))
            comando.Parameters.AddWithValue("@saldo", CStr(row("SaldoCC")))
            comando.Parameters.AddWithValue("@estado", CStr(row("EstadoCC")))
            comando.Parameters.AddWithValue("@pagado", CStr(row("PagadoCC")))

            fechajob = CStr(row("FecPagoCC"))
            ProcesarFecha()
            comando.Parameters.AddWithValue("@fecpago", fechadb)
            comando.Parameters.AddWithValue("@resto", CStr(row("RestoCC")))
            comando.Parameters.AddWithValue("@obs", CStr(row("ObsCC")))
            comando.ExecuteNonQuery()
        Next

        comando.CommandText = "SELECT * FROM impctacte WHERE NroCC = " & txtMatricula.Text & " ORDER BY FechaCC "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

    End Sub

    Private Sub btnImprimir_MouseHover(sender As Object, e As EventArgs) Handles btnImprimir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Imprimir."
        ToolTipMsg.SetToolTip(btnImprimir, "Presione para imprimir la cuenta corriente.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub
End Class