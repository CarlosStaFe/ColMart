Public Class frmListaSaldoPago
    Dim matricula, apelnomb, estado, detalle, fechades, fechahas, dd, mm, yyyy, titulo, ceros As String
    Dim pos1, pos2, longitud, cantidad As Integer
    Dim debe, haber, saldo As Double
    Private da As New MySqlDataAdapter

    Private Sub frmListaSaldoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        rbtnSaldos.Checked = True
        cmbEstado.SelectedIndex = 0
        cmbOrden.SelectedIndex = 0
        CargarCombo()
        cmbConcepto.SelectedIndex = 0

    End Sub

    Private Sub rbtnSaldos_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbtnSaldos.CheckedChanged

        If rbtnSaldos.Checked = True Then
            dtpDesde.Enabled = False
        Else
            dtpDesde.Enabled = True
        End If

        cmbEstado.Enabled = True
        cmbOrden.Enabled = True

        txtNroMatri.Text = ""
        txtNombreMatri.Text = ""
        txtNroMatri.Focus()

    End Sub

    Private Sub btnFiltrar_Click_1(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        titulo = "Listado de Matriculados - "

        comando = New MySqlCommand("DELETE FROM debehaber ", conexion)
        dr = comando.ExecuteReader
        dr.Close()

        If rbtnPagos.Checked Then
            fechajob = dtpDesde.Text
            ProcesarFecha()
            fechades = fechadb
        Else
            fechades = "2021-06-30"
        End If

        fechajob = dtpHasta.Text
        ProcesarFecha()

        fechahas = fechadb

        If rbtnSaldos.Checked Then
            If txtNroMatri.Text = "" Then

                comando.CommandText = "SELECT * FROM ctasctes INNER JOIN matriculados ON ctasctes.NroCC = matriculados.NroMatri " _
                                    & "WHERE ctasctes.EstadoCC = 'PENDIENTE' "
                titulo = titulo & "SALDOS * "

                If cmbConcepto.Text <> "TODOS" Then
                    comando.CommandText = comando.CommandText & " AND ctasctes.DetalleCC = '" & cmbConcepto.Text & "' "
                Else
                    titulo = titulo & "Concepto: TODOS * "
                End If

                If cmbEstado.Text <> "TODOS" Then
                    comando.CommandText = comando.CommandText & " AND matriculados.EstadoMatri = '" & cmbEstado.Text & "' "
                    titulo = titulo & "Estado " & cmbEstado.Text & " * "
                Else
                    titulo = titulo & "Estado: TODOS * "
                End If

                comando.CommandText = comando.CommandText & " AND ctasctes.FechaCC <= '" & fechahas & "' AND ctasctes.RestoCC > 0 "
                titulo = titulo & "Hasta: " & dtpHasta.Text & " * "

                If cmbOrden.Text = "MATRICULA" Then
                    comando.CommandText = comando.CommandText & " ORDER BY ctasctes.NroCC "
                    titulo = titulo & "Orden: MATRÍCULA * "
                Else
                    comando.CommandText = comando.CommandText & " ORDER BY matriculados.ApelNombMatri"
                    titulo = titulo & "Orden: APELLIDO * "
                End If

            Else
                comando.CommandText = "SELECT * FROM ctasctes INNER JOIN matriculados ON ctasctes.NroCC = matriculados.NroMatri " _
                                    & "WHERE ctasctes.EstadoCC = 'PENDIENTE' AND matriculados.NroMatri = '" & txtNroMatri.Text & "'"
                titulo = titulo & "SALDOS * " & "Hasta: " & dtpHasta.Text & " * "
            End If
        End If

        If rbtnPagos.Checked Then

            If txtNroMatri.Text = "" Then

                comando.CommandText = "SELECT * FROM ctasctes INNER JOIN matriculados ON ctasctes.NroCC = matriculados.NroMatri " _
                                            & "WHERE ctasctes.EstadoCC <> 'PENDIENTE' "
                titulo = titulo & "PAGOS * "

                If cmbConcepto.Text <> "TODOS" Then
                    comando.CommandText = comando.CommandText & " AND ctasctes.DetalleCC = '" & cmbConcepto.Text & "' "
                Else
                    titulo = titulo & "Concepto: TODOS * "
                End If

                If cmbEstado.Text <> "TODOS" Then
                    comando.CommandText = comando.CommandText & " AND matriculados.EstadoMatri = '" & cmbEstado.Text & "' "
                    titulo = titulo & "Estado " & cmbEstado.Text & " * "
                Else
                    titulo = titulo & "Estado: TODOS * "
                End If

                comando.CommandText = comando.CommandText & "AND ctasctes.FecPagoCC >= '" & fechades & "' AND ctasctes.FecPagoCC <= '" & fechahas & "' "
                titulo = titulo & "Desde: " & dtpDesde.Text & " * " & "Hasta: " & dtpHasta.Text & " * "

                comando.CommandText = comando.CommandText & " AND ctasctes.PagadoCC > '0' "

                If cmbOrden.Text = "MATRICULA" Then
                    comando.CommandText = comando.CommandText & " ORDER BY ctasctes.NroCC "
                    titulo = titulo & "Orden: MATRÍCULA * "
                Else
                    comando.CommandText = comando.CommandText & " ORDER BY matriculados.ApelNombMatri "
                    titulo = titulo & "Orden: APELLIDO * "
                End If
            Else
                comando.CommandText = "SELECT * FROM ctasctes INNER JOIN matriculados ON ctasctes.NroCC = matriculados.NroMatri " _
                                            & "WHERE ctasctes.EstadoCC <> 'PENDIENTE' AND ctasctes.HaberCC > '0'  AND matriculados.NroMatri = '" & txtNroMatri.Text & "' " _
                                            & "AND ctasctes.FecPagoCC >= '" & fechades & "' AND ctasctes.FecPagoCC <= '" & fechahas & "' "
                titulo = titulo & "PAGOS * " & "Desde: " & dtpDesde.Text & " * " & "Hasta: " & dtpHasta.Text & " * "
            End If
        End If


        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows
                comando = New MySqlCommand("INSERT INTO debehaber VALUES(@matricula, @apelnomb, @telefono, @estado, @detalle, @periodo, @debe, @haber, @saldo, @total)", conexion)
                comando.Parameters.AddWithValue("@matricula", CStr(row("NroMatri")))
                comando.Parameters.AddWithValue("@apelnomb", CStr(row("ApelNombMatri")))
                comando.Parameters.AddWithValue("@telefono", CStr(row("CeluRealMatri")))
                comando.Parameters.AddWithValue("@estado", CStr(row("EstadoMatri")))
                comando.Parameters.AddWithValue("@detalle", CStr(row("DetalleCC")))
                comando.Parameters.AddWithValue("@periodo", CStr(row("PeriodoCC")))
                If rbtnSaldos.Checked Then
                    comando.Parameters.AddWithValue("@debe", row("RestoCC"))
                Else
                    comando.Parameters.AddWithValue("@haber", 0)
                End If
                If rbtnPagos.Checked Then
                    comando.Parameters.AddWithValue("@debe", row("HaberCC"))
                Else
                    comando.Parameters.AddWithValue("@haber", 0)
                End If
                comando.Parameters.AddWithValue("@saldo", 0)
                comando.Parameters.AddWithValue("@total", 0)
                comando.ExecuteNonQuery()
            Next

            Dim frm As New frmInforme
            frm.txtDetalle.Text = titulo
            frm.txtUser.Text = user
            frm.ShowDialog()

        Else
            detmsg = "No tiene movimientos pendientes...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub btnFiltrar_MouseHover(sender As Object, e As EventArgs) Handles btnFiltrar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Filtrar."
        ToolTipMsg.SetToolTip(btnFiltrar, "Presione para imprimir el listado deseado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT DISTINCT DetalleCodDeb FROM CodDebito ORDER BY DetalleCodDeb ASC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            cmbConcepto.Items.Add("TODOS")
            While dr.Read
                cmbConcepto.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()

    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtNroMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroMatri.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 11
            Dim frmMat11 As New frmConsMatri
            AddOwnedForm(frmMat11)
            frmMat11.ShowDialog()
            senial = 0
            cmbEstado.Enabled = False
            cmbOrden.Enabled = False
            If rbtnSaldos.Checked Then
                dtpDesde.Enabled = False
                dtpHasta.Focus()
            End If
        End If

        'Busco matriculado por Nro de matrícula
        If e.KeyCode = Keys.Enter Then
            cmbEstado.Enabled = False
            cmbOrden.Enabled = False
            dtpDesde.Focus()
            LeerMatriculado()
        End If

    End Sub


    Private Sub LeerMatriculado()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = " & txtNroMatri.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtNombreMatri.Text = CStr(row("ApelNombMatri"))
        Else
            cmbEstado.Enabled = True
            cmbOrden.Enabled = True
            detmsg = "Matrícula no Existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub txtNroMatri_MouseHover(sender As Object, e As EventArgs) Handles txtNroMatri.MouseHover

        ToolTipMsg.ToolTipTitle = "Ingreso de Matrícula."
        ToolTipMsg.SetToolTip(txtNroMatri, "Presione F1 para consultar los matriculados o ingrese el legajo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub
End Class