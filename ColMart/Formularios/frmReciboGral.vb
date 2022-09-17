'*******************************************************************************
'* RECIBO GENERAL DE COBRO                                                     *
'*******************************************************************************
Imports System.Drawing

Public Class frmReciboGral
    Dim fecha, comprobante, tipo, impletras, cuit As String
    Dim flag, fechaaux, fechajur, tipoA, tipoF, detalle As String
    Dim longitud, cantidad, item, meses, ctrolf, ctrolv, ctroll As Integer
    Dim ceros, id, yyyy, anio, mes As String
    Dim pagado, total, resto, saldo, importe As Double
    Dim fecha1, fecha2 As Date

    Private Sub frmReciboGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        senial = ""
        lblVenceFianza.Text = ""
        lblAntiguedad.Text = ""
        ControlarCaja()

        If flag = "NO" Then
            Limpiar()
            txtMatSoc.Enabled = False
            btnSalir.Focus()
        Else
            Limpiar()
            txtMatSoc.Focus()
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
                txtTelefono.Text = dr(22).ToString + " * " + dr(23).ToString
                tipo = "MATRÍCULA: "
                flag = "M"

                '*** Fecha de Antiguedad ***
                fechajob = Format(Now, "dd/MM/yyyy")
                ProcesarFecha()
                fechajur = dr(12).ToString
                yyyy = DateDiff("yyyy", fechajur, fechadb)
                lblAntiguedad.Text = yyyy + " años"

                If yyyy < 2 Then
                    lblAntiguedad.ForeColor = Color.Red
                    tipoA = "A"
                    Timer1.Start()
                End If
                If yyyy >= 2 And yyyy < 6 Then
                    lblAntiguedad.ForeColor = Color.Yellow
                    tipoA = "A"
                    Timer1.Start()
                End If
                If yyyy >= 6 Then
                    lblAntiguedad.Visible = True
                    lblAntiguedad.ForeColor = Color.Lime
                    Timer1.Stop()
                End If

                '*** Fecha Vence Fianza ***
                fechaaux = dr(29).ToString
                meses = 24
                fechajob = DateAdd("m", meses, fechaaux)
                ProcesarFecha()
                lblVenceFianza.Text = fechajob
                fecha1 = fechajob

                fechajob = Format(Now, "dd/MM/yyyy")
                ProcesarFecha()
                fecha2 = fechadb

                If fecha1 <= fecha2 Then
                    lblVenceFianza.ForeColor = Color.Red
                    ctrolv = 1
                    tipoF = "F"
                    Timer1.Start()
                Else
                    lblVenceFianza.Visible = True
                    lblVenceFianza.ForeColor = Color.Lime
                    ctrolv = 0
                    Timer1.Stop()
                End If

            End While
        End If

        CalcularSaldo()

        dr.Close()
        dr.Dispose()

        txtCodigo.Focus()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Static c As Integer
        c = c + 1

        If tipoA = "A" Then
            If c = 1 Then
                lblAntiguedad.Visible = True
            ElseIf c = 2 Then
                lblAntiguedad.Visible = False
            Else : c = 3
                c = 0
            End If
        End If

        If tipoF = "F" Then
            If c = 1 Then
                lblVenceFianza.Visible = True
            ElseIf c = 2 Then
                lblVenceFianza.Visible = False
            Else : c = 3
                c = 0
            End If
        End If

    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown

        'Busco códigos a debitar por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmRecGral As New frmConsCodDebRec
            'Dim frmRecGral As New frmConsCodDebito
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

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress

        If e.KeyChar = Chr(13) And txtCodigo.Text = "" Then
            btnLimpiar.Visible = True
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub LeerCodigos()

        comando.CommandText = "SELECT * FROM coddebito WHERE NroCodDeb = '" & txtCodigo.Text & "' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)
            txtTipoRec.Text = CStr(row("TipoRecCodDeb"))

            If txtTipoRec.Text = "REC" Then
                txtDetalle.Text = CStr(row("DetalleCodDeb"))
                txtImporte.Text = CStr(row("ImporteCodDeb"))
                txtCantidad.Text = 1
                txtSubtotal.Text = CStr(row("ImporteCodDeb")) * 1
                txtCategoria.Text = CStr(row("CategCodDeb"))

                FormatoMoneda(txtImporte)
                FormatoMoneda(txtSubtotal)

                txtImporte.Focus()
                btnAgregar.Visible = True

                'If txtTotal.Text = 0 Then
                '    detmsg = "Debe ingresar un código...!!!"
                '    tipomsg = "info"
                '    btnmsg = 1
                '    frmMsgBox.ShowDialog()
                '    txtCodigo.Focus()
                'Else
                '    txtDetalle.Text = ""
                '    txtImporte.Text = ""
                '    txtCantidad.Text = ""
                '    txtSubtotal.Text = ""
                '    txtEfectivo.Focus()
                'End If
            Else
                detmsg = "DEBE INGRESAR UN CÓDIGO TIPO REC ...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
                txtCodigo.Text = ""
                txtDetalle.Text = ""
                txtImporte.Text = ""
                txtCantidad.Text = ""
                txtSubtotal.Text = ""
                txtCodigo.Focus()
            End If
        End If

    End Sub

    Private Sub txtImporte_LostFocus(sender As Object, e As EventArgs) Handles txtImporte.LostFocus

        If txtImporte.Text = "0" Then
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

        If txtCantidad.Text = "0" Then
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
            importe = Val(txtImporte.Text)
            comando.Parameters.AddWithValue("@importe", importe)
            comando.Parameters.AddWithValue("@cantidad", txtCantidad.Text)
            importe = Val(txtSubtotal.Text)
            comando.Parameters.AddWithValue("@subtotal", importe)
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

        ControlarFianza()

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
        lblAntiguedad.Text = ""
        txtObs.Text = ""
        txtTotal.Text = 0
        lblVenceFianza.Text = ""
        FormatoMoneda(txtTotal)
        txtEfectivo.Text = 0
        FormatoMoneda(txtEfectivo)
        txtTransferencia.Text = 0
        FormatoMoneda(txtTransferencia)
        txtTarjeta.Text = 0
        FormatoMoneda(txtTarjeta)
        txtSaldo.Text = 0
        FormatoMoneda(txtSaldo)
        txtSaldoMat.Text = 0
        FormatoMoneda(txtSaldoMat)
        ctrolf = 0
        ctrolv = 0
        ctroll = 0

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
            If txtTotal.Text = txtSaldo.Text And nivel > 3 Then
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
        If txtSaldo.Text < "0" Then
            detmsg = "DEBE MODIFICAR EL IMPORTE DE PAGO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

            btnImprimir.Visible = False
            txtEfectivo.Focus()
        End If
        If ctrolv = 1 And ctrolf = 0 And ctroll = 1 Then
            detmsg = "DEBE INGRESAR EL CÓDIGO 5 POR FIANZA VENCIDA...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            btnImprimir.Enabled = False
            txtCodigo.Focus()
        Else
            btnImprimir.Enabled = True
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        BuscarDatos()

        GrabarCtasCtes()

        GrabarCaja()

        '***SEPUSO DENTRO DE GRABAR CTASCTES***
        'GrabarFianza()

        '***ACTUALIZO COMPROBANTE***
        comando = New MySqlCommand("UPDATE comprobte SET NroCpbte = '" & comprobante & "' WHERE TipoCpbte = 'CIC'", conexion)
        comando.ExecuteNonQuery()

        Dim frm As New frmReciboGeneral
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

            comando.CommandText = "SELECT * FROM comprobte WHERE TipoCpbte = 'CIC'"
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

            fechajob = txtFecha.Text
            ProcesarFecha()
            fecha = fechadb

        End If

    End Sub

    Private Sub GrabarCtasCtes()

        item = 0
        total = Val(txtTotal.Text)
        pagado = Val(txtEfectivo.Text) + Val(txtTarjeta.Text) + Val(txtTransferencia.Text)
        saldo = Val(txtSaldo.Text)
        resto = pagado

        Try
            If dgvRenglones.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgvRenglones.Rows
                    item = item + 1
                    comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)
                    comando.Parameters.AddWithValue("@id_ctacte", id)
                    comando.Parameters.AddWithValue("@matricula", txtMatSoc.Text)
                    comando.Parameters.AddWithValue("@fecha", fecha)
                    comando.Parameters.AddWithValue("@tipo", "LIQ")
                    comando.Parameters.AddWithValue("@comprobante", comprobante)
                    comando.Parameters.AddWithValue("@item", item)
                    comando.Parameters.AddWithValue("@detalle", Fila.Cells(2).Value)
                    comando.Parameters.AddWithValue("@periodo", "")
                    If resto >= Fila.Cells(5).Value Then
                        comando.Parameters.AddWithValue("@debe", Fila.Cells(5).Value)
                        comando.Parameters.AddWithValue("@estado", "PAGADA")
                        comando.Parameters.AddWithValue("@pagado", Fila.Cells(5).Value)
                        comando.Parameters.AddWithValue("@resto", 0)
                        resto = resto - Fila.Cells(5).Value
                    Else
                        comando.Parameters.AddWithValue("@debe", Fila.Cells(5).Value)
                        comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        comando.Parameters.AddWithValue("@pagado", Fila.Cells(5).Value - resto)
                        comando.Parameters.AddWithValue("@resto", saldo)
                    End If
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    comando.Parameters.AddWithValue("@fecpago", fecha)
                    comando.Parameters.AddWithValue("@obs", "CIC Nro.: " + comprobante)
                    comando.ExecuteNonQuery()

                    If Fila.Cells(1).Value = 5 Then
                        GrabarFianza()
                    End If

                    detalle = Fila.Cells(2).Value
                    importe = Fila.Cells(5).Value
                    GrabarVentas()

                Next
            End If

            comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)
            item = item + 1
            comando.Parameters.AddWithValue("@id_ctacte", id)
            comando.Parameters.AddWithValue("@matricula", txtMatSoc.Text)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@tipo", "CIC")
            comando.Parameters.AddWithValue("@comprobante", comprobante)
            comando.Parameters.AddWithValue("@item", item)
            comando.Parameters.AddWithValue("@detalle", "CIC Nro.: " + comprobante)
            comando.Parameters.AddWithValue("@periodo", "")
            comando.Parameters.AddWithValue("@debe", 0)
            comando.Parameters.AddWithValue("@haber", pagado)
            comando.Parameters.AddWithValue("@saldo", 0)
            comando.Parameters.AddWithValue("@estado", "PAGO")
            comando.Parameters.AddWithValue("@pagado", 0)
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
        comando.Parameters.AddWithValue("@detalle", "CIC Nro.: " & comprobante & " - " & txtNombre.Text)
        comando.Parameters.AddWithValue("@debe", 0)
        importe = Val(txtTotal.Text)
        comando.Parameters.AddWithValue("@haber", importe)
        comando.Parameters.AddWithValue("@saldo", 0)
        comando.Parameters.AddWithValue("@efectivo", efectivo)
        comando.Parameters.AddWithValue("@tarjeta", tarjeta)
        comando.Parameters.AddWithValue("@transfe", transferencia)
        comando.Parameters.AddWithValue("@obs", txtObs.Text)
        comando.Parameters.AddWithValue("@estado", "ABIERTA")
        comando.ExecuteNonQuery()

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

    Private Sub ControlarFianza()

        ctrolf = 0
        ctroll = 0

        If dgvRenglones.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvRenglones.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(1).Value > 23 Or Fila.Cells(1).Value < 27 Then
                        ctroll = 1
                    End If
                    If Fila.Cells(1).Value = 5 Then
                        ctrolf = 1
                    End If
                End If
            Next
        End If

        If ctrolv = 1 And ctrolf = 0 And ctroll = 1 Then
            detmsg = "DEBE INGRESAR EL CÓDIGO 5 POR FIANZA VENCIDA...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            btnImprimir.Enabled = True
            txtCodigo.Focus()
        End If

    End Sub

    Private Sub GrabarFianza()

        comando = New MySqlCommand("INSERT INTO fianzas VALUES(@id, @matri, @fecpago, @user, @firma1, @user1, @firma2, @user2, @fecvto, @docum, @nombre, " _
                                                   & "@calle, @tel, @estado, @obs, @apellido, @telefmatri)", conexion)
        comando.Parameters.AddWithValue("@id", 0)
        comando.Parameters.AddWithValue("@matri", txtMatSoc.Text)
        comando.Parameters.AddWithValue("@fecpago", fecha)
        comando.Parameters.AddWithValue("@user", user)
        comando.Parameters.AddWithValue("@firma1", DBNull.Value)
        comando.Parameters.AddWithValue("@user1", "")
        comando.Parameters.AddWithValue("@Firma2", DBNull.Value)
        comando.Parameters.AddWithValue("@user2", "")
        comando.Parameters.AddWithValue("@fecvto", DBNull.Value)
        comando.Parameters.AddWithValue("@docum", "")
        comando.Parameters.AddWithValue("@nombre", "")
        comando.Parameters.AddWithValue("@calle", "")
        comando.Parameters.AddWithValue("@tel", "")
        comando.Parameters.AddWithValue("@estado", "INCOMPLETA")
        comando.Parameters.AddWithValue("@obs", "CIC Nro.: " & comprobante)
        comando.Parameters.AddWithValue("@apellido", txtNombre.Text)
        comando.Parameters.AddWithValue("@telefmatri", txtTelefono.Text)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub GrabarVentas()

        mes = Month(Today)
        PonerCeros(mes, 2)
        mes = nroconceros
        anio = Year(Today)

        comando = New MySqlCommand("INSERT INTO ventas VALUES(@id, @fecha, @tipo, @cpbte, @item, @detalle, @periodo, @neto, @total)", conexion)
        comando.Parameters.AddWithValue("@id", 0)
        comando.Parameters.AddWithValue("@fecha", fecha)
        comando.Parameters.AddWithValue("@tipo", "LIQ")
        comando.Parameters.AddWithValue("@cpbte", comprobante)
        comando.Parameters.AddWithValue("@item", item)
        comando.Parameters.AddWithValue("@detalle", detalle)
        comando.Parameters.AddWithValue("@periodo", anio + mes)
        comando.Parameters.AddWithValue("@neto", importe)
        comando.Parameters.AddWithValue("@total", 0)
        comando.ExecuteNonQuery()

    End Sub

End Class