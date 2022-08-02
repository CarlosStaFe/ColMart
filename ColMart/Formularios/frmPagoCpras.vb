Imports Microsoft.Reporting.WinForms

Public Class frmPagoCpras
    Dim ImpLetras, auxiliar, flag As String
    Dim longitud, cantidad, contador As Integer
    Dim ceros, tiponro, comprobante, dd, mm, yyyy As String
    Dim fecha, id, periodo, pagado As String
    Dim saldobol, pagadobol, importe, saldoant, efectivo, tarjeta, transferencia As Double
    Dim observacion, cuit As String
    Dim parametros As ReportParameter() = New ReportParameter(52) {}

    Private Sub frmPagoCpras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        senial = ""
        'ControlarCaja()

        If flag = "NO" Then
            Limpiar()
            txtProveedor.Enabled = False
            txtObs.Enabled = False
            txtEfectivo.Enabled = False
            txtTransferencia.Enabled = False
            txtTarjeta.Enabled = False
            btnSalir.Focus()
        Else
            CtacteproTableAdapter.Fill(dbcolmartDataSet.ctactepro)
            Limpiar()
            txtProveedor.Focus()
            'ReportViewer1.RefreshReport()
            txtFecha.Text = Format(Now, "dd/MM/yyyy")
        End If

        'ReportViewer1.RefreshReport()

    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmProv3 As New frmConsProveedores
            AddOwnedForm(frmProv3)
            frmProv3.ShowDialog()
            txtProveedor.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            LeerProveedores()
            CargarCtasCtes()
        End If

    End Sub

    Private Sub LeerProveedores()

        comando = New MySqlCommand("SELECT * FROM proveedores WHERE NroProv = '" & txtProveedor.Text & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                txtNombre.Text = dr(2).ToString
                flag = "S"
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub CargarCtasCtes()

        comando.CommandText = "SELECT * FROM ctactepro WHERE NroCCPro = " & txtProveedor.Text & " AND EstadoCCPro = 'PENDIENTE' ORDER BY FechaCCPro"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        txtSaldo.Text = "0"
        contador = 0

        dgvCtasCtes.DataSource = dt
        'dgvCtasCtes.Columns(7).ReadOnly = False

        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                txtSaldo.Text = txtSaldo.Text - Fila.Cells(8).Value + Fila.Cells(9).Value
            Next
            txtSaldo.Text = Format(CDec(txtSaldo.Text), "########0.00")
            txtApagar.Text = Format(CDec(txtApagar.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
            dgvCtasCtes.Refresh()
            btnLimpiar.Visible = True
            dgvCtasCtes.Focus()
        Else
            detmsg = "No posee deudas pendientes...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            Limpiar()
            txtProveedor.Focus()
        End If

    End Sub

    Private Sub txtEfectivo_LostFocus(sender As Object, e As EventArgs) Handles txtEfectivo.LostFocus

        If txtEfectivo.Text > 0 Then
            txtDiferencia.Text = txtApagar.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
            txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
            txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        End If

        If txtSaldo.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtTransferencia_LostFocus(sender As Object, e As EventArgs) Handles txtTransferencia.LostFocus

        If txtTransferencia.Text > 0 Then
            txtDiferencia.Text = txtApagar.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
            txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
            txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        End If

        If txtSaldo.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtTarjeta_LostFocus(sender As Object, e As EventArgs) Handles txtTarjeta.LostFocus

        If txtTarjeta.Text > 0 Then
            txtDiferencia.Text = txtApagar.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
            txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
            txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        End If

        If txtSaldo.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtObs_LostFocus(sender As Object, e As EventArgs) Handles txtObs.LostFocus

        If dgvCtasCtes.Rows.Count > 0 Then
            If txtDiferencia.Text = txtSaldo.Text Then
                detmsg = "DEBE CARGAR ALGÚN PAGO...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
                txtEfectivo.Focus()
            Else
                btnImprimir.Visible = True
                btnImprimir.Focus()
            End If
        Else
            detmsg = "DEBE MARCAR ALGÚN RENGLÓN...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub Limpiar()

        txtProveedor.Text = ""
        txtNombre.Text = ""
        txtApagar.Text = "0"
        txtDiferencia.Text = "0"
        txtEfectivo.Text = "0"
        txtTransferencia.Text = "0"
        txtTarjeta.Text = "0"
        txtSaldo.Text = "0"
        txtEfectivo.Text = "0"
        txtTransferencia.Text = "0"
        txtTarjeta.Text = "0"
        txtApagar.Text = "0"
        txtDiferencia.Text = "0"
        pagado = "0"
        txtObs.Text = ""
        cuit = ""
        contador = 0
        txtSaldo.Text = Format(CDec(txtSaldo.Text), "########0.00")
        txtApagar.Text = Format(CDec(txtApagar.Text), "########0.00")
        txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
        txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
        txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")

        dgvCtasCtes.DataSource = Nothing

        btnSalir.Visible = True
        btnLimpiar.Visible = False
        btnImprimir.Visible = False
        'rdbNotaCredito.Checked = False

        txtProveedor.Focus()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

    End Sub

    Private Sub dgvCtasCtes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCtasCtes.CellDoubleClick

        If dgvCtasCtes.CurrentRow.Cells(13).Value = "" Then
            dgvCtasCtes.CurrentRow.Cells(13).Value = "X"
            dgvCtasCtes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
            txtApagar.Text = txtApagar.Text + dgvCtasCtes.CurrentRow.Cells(13).Value
            txtDiferencia.Text = txtDiferencia.Text + dgvCtasCtes.CurrentRow.Cells(13).Value
            contador = contador + 1
        Else
            dgvCtasCtes.CurrentRow.Cells(13).Value = ""
            dgvCtasCtes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            txtApagar.Text = txtApagar.Text - dgvCtasCtes.CurrentRow.Cells(13).Value
            txtDiferencia.Text = txtDiferencia.Text - dgvCtasCtes.CurrentRow.Cells(13).Value
            contador = contador - 1
        End If
        txtApagar.Text = Format(CDec(txtApagar.Text), "########0.00")
        txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        If contador = 8 Then
            detmsg = "Ya completó la cantidad de renglones...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        If txtDiferencia.Text = txtApagar.Text Then
            detmsg = "DEBE INGRESAR UN IMPORTE DE PAGO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtEfectivo.Focus()
        Else

            ImpLetras = Letras(pagado)
            'CalcularSaldoBoleta()

            '*** LIMPIAMOS EL DataSource DEL INFORME ********
            'ReportViewer1.LocalReport.DataSources.Clear()

            longitud = Len(txtProveedor.Text)
            If longitud < 5 Then
                cantidad = 5 - longitud
                ceros = ""
                For j = 1 To cantidad
                    ceros = ceros & "0"
                Next j
                txtProveedor.Text = ceros & txtProveedor.Text
            End If

            comando.CommandText = "SELECT * FROM comprobte WHERE TipoCpbte = 'CIP'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                comprobante = CStr(row("NroCpbte"))
                comprobante = comprobante + 1
            End If

            '---Actualizo Comprobante---
            comando = New MySqlCommand("UPDATE comprobte SET NroCpbte = '" & comprobante & "' WHERE TipoCpbte = 'CIP'", conexion)
            comando.ExecuteNonQuery()

            longitud = Len(comprobante)
            If longitud < 8 Then
                cantidad = 8 - longitud
                ceros = ""
                For j = 1 To cantidad
                    ceros = ceros & "0"
                Next j
                comprobante = ceros & comprobante
            End If

            fecha = CDate(Date.Now)
            parametros(0) = New ReportParameter("prmComprobante", comprobante)
            parametros(1) = New ReportParameter("prmTipoNro", tiponro)
            'parametros(2) = New ReportParameter("prmMatSoc", txtMatSoc.Text)
            parametros(3) = New ReportParameter("prmNombre", txtNombre.Text)
            parametros(4) = New ReportParameter("prmImpLetras", ImpLetras)
            parametros(45) = New ReportParameter("prmTotal", pagado)
            parametros(46) = New ReportParameter("prmObs", txtObs.Text)
            parametros(47) = New ReportParameter("prmFecha", txtFecha.Text)
            parametros(48) = New ReportParameter("prmCuit", cuit)
            parametros(49) = New ReportParameter("prmEfectivo", txtEfectivo.Text)
            parametros(50) = New ReportParameter("prmTransferencia", txtTransferencia.Text)
            parametros(51) = New ReportParameter("prmTarjeta", txtTarjeta.Text)
            parametros(52) = New ReportParameter("prmTipoComprobante", "COMPROBANTE INTERNO DE PAGO")

            contador = 1
            If dgvCtasCtes.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                    If Not Fila Is Nothing Then
                        If Fila.Cells(15).Value = "X" Then
                            If contador = 1 Then
                                parametros(5) = New ReportParameter("prmFecVto1", CStr(Fila.Cells(2).Value))
                                parametros(6) = New ReportParameter("prmDetalle1", CStr(Fila.Cells(6).Value))
                                parametros(7) = New ReportParameter("prmPeriodo1", CStr(Fila.Cells(7).Value))
                                parametros(8) = New ReportParameter("prmSaldo1", CStr(Fila.Cells(13).Value))
                                parametros(9) = New ReportParameter("prmImporte1", CStr(Fila.Cells(12).Value))
                            End If
                            If contador = 2 Then
                                parametros(10) = New ReportParameter("prmFecVto2", CStr(Fila.Cells(2).Value))
                                parametros(11) = New ReportParameter("prmDetalle2", CStr(Fila.Cells(6).Value))
                                parametros(12) = New ReportParameter("prmPeriodo2", CStr(Fila.Cells(7).Value))
                                parametros(13) = New ReportParameter("prmSaldo2", CStr(Fila.Cells(13).Value))
                                parametros(14) = New ReportParameter("prmImporte2", CStr(Fila.Cells(12).Value))
                            End If
                            If contador = 3 Then
                                parametros(15) = New ReportParameter("prmFecVto3", CStr(Fila.Cells(2).Value))
                                parametros(16) = New ReportParameter("prmDetalle3", CStr(Fila.Cells(6).Value))
                                parametros(17) = New ReportParameter("prmPeriodo3", CStr(Fila.Cells(7).Value))
                                parametros(18) = New ReportParameter("prmSaldo3", CStr(Fila.Cells(13).Value))
                                parametros(19) = New ReportParameter("prmImporte3", CStr(Fila.Cells(12).Value))
                            End If
                            If contador = 4 Then
                                parametros(20) = New ReportParameter("prmFecVto4", CStr(Fila.Cells(2).Value))
                                parametros(21) = New ReportParameter("prmDetalle4", CStr(Fila.Cells(6).Value))
                                parametros(22) = New ReportParameter("prmPeriodo4", CStr(Fila.Cells(7).Value))
                                parametros(23) = New ReportParameter("prmSaldo4", CStr(Fila.Cells(13).Value))
                                parametros(24) = New ReportParameter("prmImporte4", CStr(Fila.Cells(12).Value))
                            End If
                            If contador = 5 Then
                                parametros(25) = New ReportParameter("prmFecVto5", CStr(Fila.Cells(2).Value))
                                parametros(26) = New ReportParameter("prmDetalle5", CStr(Fila.Cells(6).Value))
                                parametros(27) = New ReportParameter("prmPeriodo5", CStr(Fila.Cells(7).Value))
                                parametros(28) = New ReportParameter("prmSaldo5", CStr(Fila.Cells(13).Value))
                                parametros(29) = New ReportParameter("prmImporte5", CStr(Fila.Cells(12).Value))
                            End If
                            If contador = 6 Then
                                parametros(30) = New ReportParameter("prmFecVto6", CStr(Fila.Cells(2).Value))
                                parametros(31) = New ReportParameter("prmDetalle6", CStr(Fila.Cells(6).Value))
                                parametros(32) = New ReportParameter("prmPeriodo6", CStr(Fila.Cells(7).Value))
                                parametros(33) = New ReportParameter("prmSaldo6", CStr(Fila.Cells(13).Value))
                                parametros(34) = New ReportParameter("prmImporte6", CStr(Fila.Cells(12).Value))
                            End If
                            If contador = 7 Then
                                parametros(35) = New ReportParameter("prmFecVto7", CStr(Fila.Cells(2).Value))
                                parametros(36) = New ReportParameter("prmDetalle7", CStr(Fila.Cells(6).Value))
                                parametros(37) = New ReportParameter("prmPeriodo7", CStr(Fila.Cells(7).Value))
                                parametros(38) = New ReportParameter("prmSaldo7", CStr(Fila.Cells(13).Value))
                                parametros(39) = New ReportParameter("prmImporte7", CStr(Fila.Cells(12).Value))
                            End If
                            If contador = 8 Then
                                parametros(40) = New ReportParameter("prmFecVto8", CStr(Fila.Cells(2).Value))
                                parametros(41) = New ReportParameter("prmDetalle8", CStr(Fila.Cells(6).Value))
                                parametros(42) = New ReportParameter("prmPeriodo8", CStr(Fila.Cells(7).Value))
                                parametros(43) = New ReportParameter("prmSaldo8", CStr(Fila.Cells(13).Value))
                                parametros(44) = New ReportParameter("prmImporte8", CStr(Fila.Cells(12).Value))
                            End If
                            contador = contador + 1
                            If contador > 8 Then
                                GoTo Finalizar
                            End If
                        End If
                    End If
                Next
                If contador <= 8 Then
                    For i = contador To 8
                        If i = 1 Then
                            parametros(5) = New ReportParameter("prmFecVto1", "")
                            parametros(6) = New ReportParameter("prmDetalle1", "")
                            parametros(7) = New ReportParameter("prmPeriodo1", "")
                            parametros(8) = New ReportParameter("prmSaldo1", "0")
                            parametros(9) = New ReportParameter("prmImporte1", "0")
                        End If
                        If i = 2 Then
                            parametros(10) = New ReportParameter("prmFecVto2", "")
                            parametros(11) = New ReportParameter("prmDetalle2", "")
                            parametros(12) = New ReportParameter("prmPeriodo2", "")
                            parametros(13) = New ReportParameter("prmSaldo2", "0")
                            parametros(14) = New ReportParameter("prmImporte2", "0")
                        End If
                        If i = 3 Then
                            parametros(15) = New ReportParameter("prmFecVto3", "")
                            parametros(16) = New ReportParameter("prmDetalle3", "")
                            parametros(17) = New ReportParameter("prmPeriodo3", "")
                            parametros(18) = New ReportParameter("prmSaldo3", "0")
                            parametros(19) = New ReportParameter("prmImporte3", "0")
                        End If
                        If i = 4 Then
                            parametros(20) = New ReportParameter("prmFecVto4", "")
                            parametros(21) = New ReportParameter("prmDetalle4", "")
                            parametros(22) = New ReportParameter("prmPeriodo4", "")
                            parametros(23) = New ReportParameter("prmSaldo4", "0")
                            parametros(24) = New ReportParameter("prmImporte4", "0")
                        End If
                        If i = 5 Then
                            parametros(25) = New ReportParameter("prmFecVto5", "")
                            parametros(26) = New ReportParameter("prmDetalle5", "")
                            parametros(27) = New ReportParameter("prmPeriodo5", "")
                            parametros(28) = New ReportParameter("prmSaldo5", "0")
                            parametros(29) = New ReportParameter("prmImporte5", "0")
                        End If
                        If i = 6 Then
                            parametros(30) = New ReportParameter("prmFecVto6", "")
                            parametros(31) = New ReportParameter("prmDetalle6", "")
                            parametros(32) = New ReportParameter("prmPeriodo6", "")
                            parametros(33) = New ReportParameter("prmSaldo6", "0")
                            parametros(34) = New ReportParameter("prmImporte6", "0")
                        End If
                        If i = 7 Then
                            parametros(35) = New ReportParameter("prmFecVto7", "")
                            parametros(36) = New ReportParameter("prmDetalle7", "")
                            parametros(37) = New ReportParameter("prmPeriodo7", "")
                            parametros(38) = New ReportParameter("prmSaldo7", "0")
                            parametros(39) = New ReportParameter("prmImporte7", "0")
                        End If
                        If i = 8 Then
                            parametros(40) = New ReportParameter("prmFecVto8", "")
                            parametros(41) = New ReportParameter("prmDetalle8", "")
                            parametros(42) = New ReportParameter("prmPeriodo8", "")
                            parametros(43) = New ReportParameter("prmSaldo8", "0")
                            parametros(44) = New ReportParameter("prmImporte8", "0")
                        End If
                    Next
                End If
            End If
Finalizar:

            'ReportViewer1.LocalReport.SetParameters(parametros)
            'ReportViewer1.RefreshReport()

        End If

        'Clase del Proyecto
        'Dim printer As ReportPrinter = New ReportPrinter()
        'printer.Print(ReportViewer1.LocalReport)

        'ActualizarTablas()


        Limpiar()

    End Sub

End Class