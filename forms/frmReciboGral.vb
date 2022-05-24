Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReciboGral
    Dim fecha, comprobante, tipo, impletras, cuit As String
    Dim flag, fechaaux, fechajur As String
    Dim longitud, cantidad, item, pos1, pos2 As Integer
    Dim ceros, newcompro, dd, mm, yyyy As String
    Dim periodo, id As String
    Dim pagado, total, resto, saldo As Double
    Dim observacion, obsparcial As String
    Dim parametros As ReportParameter() = New ReportParameter(6) {}

    Private Sub frmReciboGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        senial = ""
        ControlarCaja()

        If flag = "NO" Then
            Limpiar()
            txtMatSoc.Enabled = False
            btnSalir.Focus()
        Else
            Limpiar()
            txtMatSoc.Focus()
            'ReportViewer1.RefreshReport()
            txtFecha.Text = Format(Now, "dd/MM/yyyy")
        End If

    End Sub

    Private Sub txtMatSoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatSoc.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 10
            Dim frmMat10 As New frmConsMatri
            AddOwnedForm(frmMat10)
            frmMat10.ShowDialog()
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
            Else
                LeerMatriculados()
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
                tipo = "SOCIEDAD: "
                flag = "S"
            End While
        End If

        dr.Close()
        dr.Dispose()

        txtCodigo.Focus()
        btnLimpiar.Visible = True

    End Sub

    Private Sub LeerMatriculados()

        comando = New MySqlCommand("SELECT * FROM matriculados WHERE NroMatri = '" & txtMatSoc.Text & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                txtNombre.Text = dr(2).ToString
                cuit = dr(11).ToString
                fechajur = dr(12).ToString
                tipo = "MATRÍCULA: "
                flag = "M"
                If txtMatSoc.Text < 1148 Then
                    txtAntiguedad.Text = "6 AÑOS"
                End If
                If txtMatSoc.Text > 1147 And txtMatSoc.Text < 1220 Then
                    txtAntiguedad.Text = "2 AÑOS"
                End If
                If txtMatSoc.Text > 1219 Then
                    txtAntiguedad.Text = "MENOS DE 2"
                End If
                fechaaux = dr(25).ToString
                MoverFecha()
                txtFianza.Text = yyyy + "-" + mm + "-" + dd

            End While
        End If

        CalcularSaldo()

        dr.Close()
        dr.Dispose()

        txtCodigo.Focus()

    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown

        'Busco códigos a debitar por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmRecGral As New frmConsCodDebito
            AddOwnedForm(frmRecGral)
            frmRecGral.ShowDialog()
            senial = 0
            LeerCodigos()
            btnLimpiar.Visible = True
        ElseIf e.KeyCode = Keys.Enter Then 'Busco códigos a debitar por número de código
            LeerCodigos()
            btnLimpiar.Visible = True
        End If

    End Sub

    Private Sub LeerCodigos()

        comando.CommandText = "SELECT * FROM coddebito WHERE NroCodDeb = '" & txtCodigo.Text & "' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtDetalle.Text = CStr(row("DetalleCodDeb"))
            txtImporte.Text = CStr(row("ImporteCodDeb"))
            txtCantidad.Text = 1
            txtSubtotal.Text = CStr(row("ImporteCodDeb")) * 1
            txtCategoria.Text = CStr(row("CategCodDeb"))
            FormatoMoneda(txtImporte)
            FormatoMoneda(txtSubtotal)

            txtImporte.Focus()
            btnAgregar.Visible = True

        Else
            If txtTotal.Text = 0 Then
                detmsg = "Debe ingresar un código...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
                txtCodigo.Focus()
            Else
                txtDetalle.Text = ""
                txtImporte.Text = ""
                txtCantidad.Text = ""
                txtSubtotal.Text = ""
                txtEfectivo.Focus()
            End If
        End If

    End Sub

    Private Sub txtImporte_LostFocus(sender As Object, e As EventArgs) Handles txtImporte.LostFocus

        If txtImporte.Text = 0 Then
            detmsg = "Debe ingresar un importe...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

            FormatoMoneda(txtImporte)
            txtImporte.Focus()
        Else
            'txtCantidad.Focus()
            FormatoMoneda(txtImporte)
        End If

    End Sub

    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtCantidad.LostFocus

        If txtCantidad.Text = 0 Then
            detmsg = "Debe ingresar una cantidad...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

            txtCantidad.Focus()
        Else
            txtSubtotal.Text = txtImporte.Text * txtCantidad.Text
            FormatoMoneda(txtSubtotal)
            btnAgregar.Focus()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            comando = New MySqlCommand("INSERT INTO renglones VALUES(@id, @codigo, @detalle, @importe, @cantidad, @subtotal, @categoria)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@codigo", txtCodigo.Text)
            comando.Parameters.AddWithValue("@detalle", txtDetalle.Text)
            comando.Parameters.AddWithValue("@importe", txtImporte.Text)
            comando.Parameters.AddWithValue("@cantidad", txtCantidad.Text)
            comando.Parameters.AddWithValue("@subtotal", txtSubtotal.Text)
            comando.Parameters.AddWithValue("@categoria", "")
            comando.ExecuteNonQuery()

        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Grabación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

    End Sub

    Private Sub CargarDgv()

        comando.CommandText = "SELECT * FROM renglones"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvRenglones.DataSource = dt

        txtTotal.Text = 0

        If dgvRenglones.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvRenglones.Rows
                If Not Fila Is Nothing Then
                    txtTotal.Text = txtTotal.Text + Fila.Cells(5).Value
                    txtSaldo.Text = txtTotal.Text
                End If
            Next
        End If

        FormatoMoneda(txtTotal)
        FormatoMoneda(txtSaldo)

        dgvRenglones.Refresh()

        txtCodigo.Text = ""
        txtDetalle.Text = ""
        txtImporte.Text = ""
        txtCantidad.Text = ""
        txtSubtotal.Text = ""
        txtCodigo.Focus()

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
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

    End Sub

    Private Sub Limpiar()

        txtMatSoc.Text = ""
        txtNombre.Text = ""
        txtCodigo.Text = ""
        txtDetalle.Text = ""
        txtImporte.Text = ""
        txtCantidad.Text = ""
        txtSubtotal.Text = ""
        txtAntiguedad.Text = ""
        txtObs.Text = ""
        txtTotal.Text = 0
        txtFianza.Text = ""
        FormatoMoneda(txtTotal)
        txtEfectivo.Text = 0
        FormatoMoneda(txtEfectivo)
        txtTransferencia.Text = 0
        FormatoMoneda(txtTransferencia)
        txtTarjeta.Text = 0
        FormatoMoneda(txtTarjeta)
        txtSaldo.Text = 0
        FormatoMoneda(txtSaldo)

        dgvRenglones.DataSource = Nothing

        BorrarRenglones()

        txtMatSoc.Focus()
        btnImprimir.Visible = False
        btnLimpiar.Visible = False
        btnAgregar.Visible = False

    End Sub

    Private Sub BorrarRenglones()

        comando = New MySqlCommand("DELETE FROM renglones", conexion)
        dr = comando.ExecuteReader
        dr.Close()

    End Sub

    Private Sub txtEfectivo_LostFocus(sender As Object, e As EventArgs) Handles txtEfectivo.LostFocus

        If txtEfectivo.Text > 0 Then
            txtSaldo.Text = txtTotal.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            FormatoMoneda(txtEfectivo)
            FormatoMoneda(txtTransferencia)
            FormatoMoneda(txtTarjeta)
            FormatoMoneda(txtSaldo)
        End If

        If txtSaldo.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtTransferencia_LostFocus(sender As Object, e As EventArgs) Handles txtTransferencia.LostFocus

        If txtTransferencia.Text > 0 Then
            txtSaldo.Text = txtTotal.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            FormatoMoneda(txtEfectivo)
            FormatoMoneda(txtTransferencia)
            FormatoMoneda(txtTarjeta)
            FormatoMoneda(txtSaldo)
        End If

        If txtSaldo.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtTarjeta_LostFocus(sender As Object, e As EventArgs) Handles txtTarjeta.LostFocus

        If txtTarjeta.Text > 0 Then
            txtSaldo.Text = txtTotal.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            FormatoMoneda(txtEfectivo)
            FormatoMoneda(txtTransferencia)
            FormatoMoneda(txtTarjeta)
            FormatoMoneda(txtSaldo)
        End If

        If txtSaldo.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtObs_LostFocus(sender As Object, e As EventArgs) Handles txtObs.LostFocus

        If dgvRenglones.Rows.Count > 0 Then
            If txtTotal.Text = txtSaldo.Text Then
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
            detmsg = "DEBE CARGAR ALGÚN CÓDIGO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtCodigo.Focus()
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        BuscarDatos()

        GrabarCtasCtes()

        GrabarCaja()

        Dim frm As New frmPrintRecGral
        frm.fecha = txtFecha.Text
        frm.comprobante = comprobante
        frm.letras = impletras
        frm.tipo = tipo
        frm.matsoc = txtMatSoc.Text
        frm.nombre = txtNombre.Text
        frm.cuit = cuit
        frm.saldo = txtSaldo.Text
        frm.obs = txtObs.Text
        frm.pagado = pagado
        frm.efectivo = txtEfectivo.Text
        frm.transferencia = txtTransferencia.Text
        frm.tarjeta = txtTarjeta.Text
        frm.ShowDialog()

        '---Actualizo Comprobante---
        comando = New MySqlCommand("UPDATE comprobte SET NroCpbte = '" & comprobante & "' WHERE TipoCpbte = 'CIP'", conexion)
        comando.ExecuteNonQuery()

        Limpiar()

        'frmPrintRecGral.ShowDialog()

    End Sub

    Private Sub BuscarDatos()

        pagado = 0
        pagado = Val(txtEfectivo.Text) + Val(txtTransferencia.Text) + Val(txtTarjeta.Text)

        If pagado = 0 Then
            detmsg = "NO HA INGRESADO NINGÚN VALOR...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            impletras = Letras(pagado)
            'CalcularSaldoBoleta()

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

            fechaaux = txtFecha.Text
            MoverFecha()
            fecha = yyyy + "-" + mm + "-" + dd

        End If

    End Sub

    Private Sub GrabarCtasCtes()

        item = 0
        total = Val(txtTotal.Text)
        pagado = Val(txtEfectivo.Text) + Val(txtTarjeta.Text) + Val(txtTransferencia.Text)
        saldo = pagado
        resto = 0

        Try
            If dgvRenglones.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgvRenglones.Rows
                    item = item + 1
                    comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)
                    comando.Parameters.AddWithValue("@id_ctacte", id)
                    comando.Parameters.AddWithValue("@matricula", txtMatSoc.Text)
                    comando.Parameters.AddWithValue("@fecha", fecha)
                    comando.Parameters.AddWithValue("@tipo", "CIP")
                    comando.Parameters.AddWithValue("@comprobante", comprobante)
                    comando.Parameters.AddWithValue("@item", item)
                    comando.Parameters.AddWithValue("@detalle", Fila.Cells(2).Value)
                    comando.Parameters.AddWithValue("@periodo", "")
                    If saldo >= Fila.Cells(5).Value Then
                        comando.Parameters.AddWithValue("@debe", Fila.Cells(5).Value)
                        comando.Parameters.AddWithValue("@estado", "PAGADA")
                        comando.Parameters.AddWithValue("@pagado", Fila.Cells(5).Value)
                        comando.Parameters.AddWithValue("@resto", 0)
                        saldo = saldo - Fila.Cells(5).Value
                    Else
                        comando.Parameters.AddWithValue("@debe", Fila.Cells(5).Value)
                        comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        comando.Parameters.AddWithValue("@pagado", Fila.Cells(5).Value - saldo)
                        comando.Parameters.AddWithValue("@resto", saldo)
                    End If
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    comando.Parameters.AddWithValue("@fecpago", fecha)
                    comando.Parameters.AddWithValue("@obs", "CIP Nro.: " + comprobante)
                    comando.ExecuteNonQuery()
                Next
            End If

            comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)
            item = item + 1
            comando.Parameters.AddWithValue("@id_ctacte", id)
            comando.Parameters.AddWithValue("@matricula", txtMatSoc.Text)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@tipo", "CIP")
            comando.Parameters.AddWithValue("@comprobante", comprobante)
            comando.Parameters.AddWithValue("@item", item)
            comando.Parameters.AddWithValue("@detalle", "CIP Nro.: " + comprobante)
            comando.Parameters.AddWithValue("@periodo", "")
            comando.Parameters.AddWithValue("@debe", 0)
            comando.Parameters.AddWithValue("@haber", pagado)
            comando.Parameters.AddWithValue("@saldo", 0)
            comando.Parameters.AddWithValue("@estado", "PAGO")
            comando.Parameters.AddWithValue("@pagado", pagado)
            comando.Parameters.AddWithValue("@fecpago", fecha)
            comando.Parameters.AddWithValue("@resto", 0)
            comando.Parameters.AddWithValue("@obs", "")
            comando.ExecuteNonQuery()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub GrabarCaja()

        Dim efectivo, tarjeta, transferencia As Double
        efectivo = Val(txtEfectivo.Text)
        tarjeta = Val(txtTarjeta.Text)
        transferencia = Val(txtTransferencia.Text)

        comando = New MySqlCommand("INSERT INTO caja VALUES(@fecha, @detalle, @debe, @haber, @saldo, @efectivo, @tarjeta, @transfe, @obs, @estado)", conexion)
        comando.Parameters.AddWithValue("@fecha", fecha)
        comando.Parameters.AddWithValue("@detalle", "CIP Nro.: " & comprobante & " - " & txtNombre.Text)
        comando.Parameters.AddWithValue("@debe", 0)
        comando.Parameters.AddWithValue("@haber", txtTotal.Text)
        comando.Parameters.AddWithValue("@saldo", 0)
        comando.Parameters.AddWithValue("@efectivo", efectivo)
        comando.Parameters.AddWithValue("@tarjeta", tarjeta)
        comando.Parameters.AddWithValue("@transfe", transferencia)
        comando.Parameters.AddWithValue("@obs", txtObs.Text)
        comando.Parameters.AddWithValue("@estado", "ABIERTA")
        comando.ExecuteNonQuery()

    End Sub

    Private Sub MoverFecha()

        pos1 = InStr(1, fechaaux, "/")
        pos2 = InStr(pos1 + 1, fechaaux, "/")
        If pos1 > 0 Then
            dd = Mid(fechaaux, 1, pos1 - 1)
            mm = Mid(fechaaux, pos1 + 1, ((pos2 - 1) - pos1))
            yyyy = Mid(fechaaux, pos2 + 1, 4)
        End If

        ceros = ""

        longitud = Len(dd)
        If longitud < 2 Then
            cantidad = 2 - longitud
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            dd = ceros & dd
        End If

        ceros = ""

        longitud = Len(mm)
        If longitud < 2 Then
            cantidad = 2 - longitud
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            mm = ceros & mm
        End If

    End Sub

    Private Sub CalcularSaldo()

        dr.Close()
        dr.Dispose()

        comando = New MySqlCommand("SELECT * FROM ctasctes WHERE NroCC = '" & txtMatSoc.Text & "'", conexion)
        dr = comando.ExecuteReader

        total = 0

        If dr.HasRows Then
            While dr.Read
                total = total + Val(dr(8).ToString) - Val(dr(9).ToString)
                txtSaldoMat.Text = total
                FormatoMoneda(txtSaldoMat)
            End While
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub


End Class