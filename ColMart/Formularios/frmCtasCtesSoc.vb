'*******************************************************************************
'* CONSULTA DE CUENTAS CORRIENTES DE SOCIEDADES DE REMATES                     *
'*******************************************************************************
Public Class frmCtasCtesSoc
    Dim debe, haber, saldo, saldoant, pagado, resto As Decimal
    Dim detalle, comprobante, estado, id, obs, fecpago, fechaaux As String

    Private Sub frmCtasCtesMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CtasctesTableAdapter.Fill(DbcolmartDataSet.ctasctes)
        dgvCtasCtes.DataSource = Nothing
        txtSociedad.Focus()

        If nivel < "4" Then
            btnActualizar.Enabled = True
        End If

    End Sub

    Private Sub CalcularCtaCte()

        comando.CommandText = "SELECT * FROM ctasctes WHERE NroCC = " & txtSociedad.Text & " ORDER BY FechaCC, ItemCC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCtasCtes.DataSource = dt

        dgvCtasCtes.Sort(dgvCtasCtes.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        debe = 0
        haber = 0
        saldo = 0
        saldoant = 0

        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                If Not Fila Is Nothing Then
                    debe = Fila.Cells(8).Value
                    haber = Fila.Cells(9).Value
                    saldo = saldoant + debe - haber
                    Fila.Cells(10).Value = saldo
                    saldoant = saldo
                    detalle = Fila.Cells(6).Value
                    comando.CommandText = "UPDATE ctasctes SET SaldoCC = '" & saldo & "' WHERE DetalleCC = '" & detalle & "' AND NroCC = '" & txtSociedad.Text & "' "
                    comando.ExecuteNonQuery()
                    If Fila.Cells(11).Value = "PENDIENTE" Or Fila.Cells(11).Value = "LIQUIDADA" Then
                        Fila.DefaultCellStyle.ForeColor = Color.Orange
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
            dgvCtasCtes.FirstDisplayedScrollingRowIndex = dgvCtasCtes.RowCount - 1
            dgvCtasCtes.Rows(dgvCtasCtes.RowCount - 1).Selected = True
        Else
            detmsg = "No posee movimientos en la Cuenta Corriente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        txtSaldo.Text = saldo
        FormatoMoneda(txtSaldo)
        dgvCtasCtes.Refresh()

    End Sub

    Private Sub txtSociedad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSociedad.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 4
            Dim frmSoc4 As New frmConsSociedad
            AddOwnedForm(frmSoc4)
            frmSoc4.ShowDialog()
            senial = 0
        End If

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerSociedades()
        End If

    End Sub

    Private Sub txtSociedad_MouseHover(sender As Object, e As EventArgs) Handles txtSociedad.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Sociedad."
        ToolTipMsg.SetToolTip(txtSociedad, "Presione F1 para buscar la sociedad deseada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerSociedades()

        comando.CommandText = "SELECT * FROM sociedades WHERE NroSociedad = " & txtSociedad.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtNombSociedad.Text = CStr(row("NombSociedad"))
        Else
            txtNombSociedad.Text = ""
        End If

        CalcularCtaCte()

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

        txtSociedad.Text = ""
        txtNombSociedad.Text = ""
        txtSaldo.Text = ""
        dgvCtasCtes.DataSource = Nothing

        txtSociedad.Focus()

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        For i As Integer = 0 To dgvCtasCtes.Rows.Count - 1

            id = dgvCtasCtes.Rows(i).Cells(0).Value()
            debe = dgvCtasCtes.Rows(i).Cells(8).Value()
            haber = dgvCtasCtes.Rows(i).Cells(9).Value()
            saldo = dgvCtasCtes.Rows(i).Cells(10).Value()
            estado = dgvCtasCtes.Rows(i).Cells(11).Value()
            pagado = dgvCtasCtes.Rows(i).Cells(12).Value()
            If estado = "PENDIENTE" Then
                fecpago = "1900-01-01"
            Else
                fecpago = dgvCtasCtes.Rows(i).Cells(13).Value()
                fechajob = fecpago
                ProcesarFecha()
                fecpago = fechadb
            End If
            resto = dgvCtasCtes.Rows(i).Cells(14).Value()
            obs = dgvCtasCtes.Rows(i).Cells(15).Value()

            comando.CommandText = "UPDATE ctasctes SET DebeCC = '" & debe & "', HaberCC = '" & haber & "', SaldoCC = '" & saldo & "', EstadoCC = '" & estado & "'," _
                                  & " PagadoCC = '" & pagado & "', FecPagoCC = '" & fecpago & "', RestoCC = '" & resto & "', ObsCC = '" & obs & "'" _
                                  & " WHERE id_CC = '" & id & "' AND NroCC = '" & txtSociedad.Text & "' "
            comando.ExecuteNonQuery()

        Next

        txtSociedad.Text = ""
        txtNombSociedad.Text = ""
        txtSaldo.Text = ""
        dgvCtasCtes.DataSource = Nothing
        txtSociedad.Focus()

    End Sub

End Class