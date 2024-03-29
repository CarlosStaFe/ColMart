﻿Imports System.ComponentModel
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReciboPago
    Dim ImpLetras, auxiliar, flag As String
    Dim longitud, cantidad, contador As Integer
    Dim ceros, tiponro, comprobante, newcompro, dd, mm, yyyy As String
    Dim fecha, periodo, id As String
    Dim saldobol, pagadobol, importe, saldoant As Double
    Dim observacion, obsparcial, cuit As String
    Dim parametros As ReportParameter() = New ReportParameter(49) {}

    Private Sub frmReciboPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        senial = ""
        ControlarCaja()

        If flag = "NO" Then
            Limpiar()
            txtMatSoc.Enabled = False
            cmbFormaPago.Enabled = False
            txtObs.Enabled = False
            txtPago.Enabled = False
            btnSalir.Focus()
        Else
            CtasctesTableAdapter.Fill(DbcolmartDataSet.ctasctes)
            Limpiar()
            txtMatSoc.Focus()
            ReportViewer1.RefreshReport()
            txtFecha.Text = Format(Now, "dd/MM/yyyy")
            cmbFormaPago.SelectedIndex = 0
        End If

    End Sub

    Private Sub txtMatSoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatSoc.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 8
            Dim frmMat8 As New frmConsMatri
            AddOwnedForm(frmMat8)
            frmMat8.ShowDialog()
            txtMatSoc.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.F2 Then
            senial = 6
            Dim frmSoc6 As New frmConsSociedad
            AddOwnedForm(frmSoc6)
            frmSoc6.ShowDialog()
            txtNombre.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            If txtMatSoc.Text > 60000 And txtMatSoc.Text < 70000 Then
                LeerSociedades()
                CargarCtasCtes()
            Else
                LeerMatriculados()
                CargarCtasCtes()
            End If
        End If

    End Sub

    Private Sub LeerSociedades()

        comando = New MySqlCommand("SELECT * FROM sociedades WHERE NroSociedad = '" & txtMatSoc.Text & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                txtNombre.Text = dr(2).ToString
                cuit = ""
                tiponro = "SOCIEDAD: "
                flag = "S"
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub LeerMatriculados()

        comando = New MySqlCommand("SELECT * FROM matriculados WHERE NroMatri = '" & txtMatSoc.Text & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                txtNombre.Text = dr(2).ToString
                cuit = dr(11).ToString
                tiponro = "MATRÍCULA: "
                flag = "M"
            End While
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub CargarCtasCtes()

        comando.CommandText = "SELECT * FROM ctasctes WHERE NroCC = " & txtMatSoc.Text & " AND EstadoCC = 'PENDIENTE' ORDER BY FechaCC, ItemCC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        txtSaldo.Text = "0"
        contador = 0

        dgvCtasCtes.DataSource = dt
        'dgvCtasCtes.Columns(7).ReadOnly = False

        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                txtSaldo.Text = txtSaldo.Text + Fila.Cells(13).Value
            Next
            FormatoMoneda(txtSaldo)
            FormatoMoneda(txtPago)
            dgvCtasCtes.Refresh()
            btnLimpiar.Visible = True
            txtPago.Focus()
        Else
            detmsg = "No posee deudas pendientes...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            Limpiar()
            txtMatSoc.Focus()
        End If

    End Sub


    Private Sub txtPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPago.KeyDown

        If e.KeyCode = Keys.Enter Then
            FormatoMoneda(txtPago)
            txtDiferencia.Text = txtSaldo.Text - txtPago.Text
            txtObs.Focus()
            FormatoMoneda(txtDiferencia)
        End If

    End Sub

    Private Sub Limpiar()

        txtMatSoc.Text = ""
        txtNombre.Text = ""
        txtPago.Text = "0"
        txtDiferencia.Text = "0"
        txtSaldo.Text = "0"
        txtObs.Text = ""
        cuit = ""
        contador = 0
        FormatoMoneda(txtSaldo)
        FormatoMoneda(txtPago)
        FormatoMoneda(txtDiferencia)

        dgvCtasCtes.DataSource = Nothing

        btnSalir.Visible = True
        btnProcesar.Visible = False
        btnLimpiar.Visible = False
        btnImprimir.Visible = False

        txtMatSoc.Focus()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

    End Sub

    Private Sub dgvCtasCtes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCtasCtes.CellDoubleClick

        If dgvCtasCtes.CurrentRow.Cells(15).Value = "" Then
            dgvCtasCtes.CurrentRow.Cells(15).Value = "X"
            dgvCtasCtes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
            contador = contador + 1
        Else
            dgvCtasCtes.CurrentRow.Cells(15).Value = ""
            dgvCtasCtes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            contador = contador - 1
        End If
        If contador > 0 Then
            btnProcesar.Visible = True
        Else
            btnProcesar.Visible = False
        End If
        If contador = 8 Then
            detmsg = "Ya completó la cantidad de renglones...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            btnProcesar.Focus()
        End If

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        If txtPago.Text = "0,00" Then
            detmsg = "Debe ingresar un importe...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtPago.Focus()
        Else

            ImpLetras = Letras(txtPago.Text)
            CalcularSaldoBoleta()

            'Limpiemos el DataSource del informe
            ReportViewer1.LocalReport.DataSources.Clear()

            longitud = Len(txtMatSoc.Text)
            If longitud < 5 Then
                cantidad = 5 - longitud
                ceros = ""
                For j = 1 To cantidad
                    ceros = ceros & "0"
                Next j
                txtMatSoc.Text = ceros & txtMatSoc.Text
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
            parametros(2) = New ReportParameter("prmMatSoc", txtMatSoc.Text)
            parametros(3) = New ReportParameter("prmNombre", txtNombre.Text)
            parametros(4) = New ReportParameter("prmImpLetras", ImpLetras)
            parametros(45) = New ReportParameter("prmTotal", txtPago.Text)
            parametros(46) = New ReportParameter("prmObs", txtObs.Text)
            parametros(47) = New ReportParameter("prmFecha", txtFecha.Text)
            parametros(48) = New ReportParameter("prmCuit", cuit)
            parametros(49) = New ReportParameter("prmFormaPago", cmbFormaPago.Text)

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

            ReportViewer1.LocalReport.SetParameters(parametros)
            ReportViewer1.RefreshReport()

            btnImprimir.Visible = True
            btnProcesar.Visible = False
            btnImprimir.Focus()

        End If

    End Sub

    Private Sub CalcularSaldoBoleta()

        auxiliar = txtPago.Text
        saldoant = 0
        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                If Fila.Cells(15).Value = "X" Then
                    If auxiliar >= Fila.Cells(13).Value Then
                        Fila.Cells(12).Value = Fila.Cells(12).Value + Fila.Cells(13).Value
                        auxiliar = auxiliar - Fila.Cells(13).Value
                        Fila.Cells(13).Value = 0
                    Else
                        saldoant = Fila.Cells(13).Value
                        Fila.Cells(12).Value = auxiliar
                        Fila.Cells(13).Value = Fila.Cells(13).Value - auxiliar
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        'Clase del Proyecto
        Dim printer As ReportPrinter = New ReportPrinter()
        printer.Print(ReportViewer1.LocalReport)

        ActualizarTablas()
        Limpiar()

    End Sub

    Private Sub ActualizarTablas()

        dd = Mid(txtFecha.Text, 1, 2)
        mm = Mid(txtFecha.Text, 4, 2)
        yyyy = Mid(txtFecha.Text, 7, 4)
        fecha = yyyy + mm + dd
        observacion = "PERÍODO: "
        obsparcial = ""

        '---Actualizo las ctasctes---
        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                If Fila.Cells(15).Value = "X" Then
                    periodo = Fila.Cells(7).Value
                    importe = Fila.Cells(8).Value
                    saldobol = Fila.Cells(13).Value
                    pagadobol = Fila.Cells(12).Value
                    id = Fila.Cells(0).Value

                    If Fila.Cells(13).Value = 0 Then
                        comando = New MySqlCommand("UPDATE ctasctes SET PagadoCC = '" & pagadobol & "', ObsCC = '" & "* CIP Nro.: " & comprobante & "'," _
                                            & " FecPagoCC = '" & fecha & "', PagadoCC = '" & importe & "', EstadoCC = 'PAGADA', RestoCC = 0 " _
                                            & " WHERE NroCC = '" & txtMatSoc.Text & "' AND id_CC = '" & id & "' ", conexion)
                        comando.ExecuteNonQuery()

                    Else
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = '" & saldobol & "', ObsCC = '" & "* CIP Nro.: " & comprobante & "'," _
                                            & " FecPagoCC = '" & fecha & "', PagadoCC = '" & pagadobol & "', EstadoCC = 'PENDIENTE'" _
                                            & " WHERE NroCC = '" & txtMatSoc.Text & "' AND id_CC = '" & id & "' ", conexion)
                        comando.ExecuteNonQuery()

                    End If
                End If
            Next
        End If

        '---Actualizo la Cta Cte---
        comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id, @nrocta, @fechacta, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)

        comando.Parameters.AddWithValue("@id", 0)
        comando.Parameters.AddWithValue("@nrocta", txtMatSoc.Text)
        comando.Parameters.AddWithValue("@fechacta", fecha)
        comando.Parameters.AddWithValue("@tipo", "CIP")
        comando.Parameters.AddWithValue("@comprobante", comprobante)
        comando.Parameters.AddWithValue("@item", 1)
        comando.Parameters.AddWithValue("@detalle", "CIP Nro.: " & comprobante)
        comando.Parameters.AddWithValue("@periodo", "")
        comando.Parameters.AddWithValue("@debe", 0)
        comando.Parameters.AddWithValue("@haber", txtPago.Text)
        comando.Parameters.AddWithValue("@saldo", 0)
        comando.Parameters.AddWithValue("@estado", "PAGO")
        comando.Parameters.AddWithValue("@pagado", txtPago.Text)
        comando.Parameters.AddWithValue("@fecpago", fecha)
        comando.Parameters.AddWithValue("@resto", 0)
        comando.Parameters.AddWithValue("@obs", observacion)
        comando.ExecuteNonQuery()

        '---Grabar Caja---
        GrabarCaja()

        '---Actualizo Comprobante---
        comando = New MySqlCommand("UPDATE comprobte SET NroCpbte = '" & comprobante & "' WHERE TipoCpbte = 'CIP'", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub GrabarCaja()

        Dim efectivo, tarjeta, transferencia As Double
        efectivo = 0
        tarjeta = 0
        transferencia = 0

        If cmbFormaPago.Text = "EFECTIVO" Then
            efectivo = Val(txtPago.Text)
        ElseIf cmbFormaPago.Text = "TARJETA" Then
            tarjeta = Val(txtPago.Text)
        ElseIf cmbFormaPago.Text = "TRANSFERENCIA" Then
            transferencia = Val(txtPago.Text)
        End If

        comando = New MySqlCommand("INSERT INTO caja VALUES(@fecha, @detalle, @debe, @haber, @saldo, @efectivo, @tarjeta, @transfe, @obs, @estado)", conexion)
        comando.Parameters.AddWithValue("@fecha", fecha)
        comando.Parameters.AddWithValue("@detalle", "CIP Nro.: " & comprobante & " - " & txtNombre.Text)
        comando.Parameters.AddWithValue("@debe", 0)
        comando.Parameters.AddWithValue("@haber", txtPago.Text)
        comando.Parameters.AddWithValue("@saldo", 0)
        comando.Parameters.AddWithValue("@efectivo", efectivo)
        comando.Parameters.AddWithValue("@tarjeta", tarjeta)
        comando.Parameters.AddWithValue("@transfe", transferencia)
        comando.Parameters.AddWithValue("@obs", txtObs.Text)
        comando.Parameters.AddWithValue("@estado", "ABIERTA")
        comando.ExecuteNonQuery()

    End Sub

    Private Sub ControlarCaja()

        txtFecha.Text = Format(Now, "yyyy-MM-dd")
        comando = New MySqlCommand("SELECT * FROM caja WHERE EstadoCaja = 'ABIERTA' ", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows = 0 Then
            detmsg = "CAJA NO ABIERTA...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            flag = "NO"
            'Else
            'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.boletas' Puede moverla o quitarla según sea necesario.
            'BoletasTableAdapter.Fill(DbcolmartDataSet.boletas)
            'Limpiar()
            'txtMatSoc.Focus()
            'ReportViewer1.RefreshReport()
            'txtFecha.Text = Format(Now, "dd/MM/yyyy")
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

End Class