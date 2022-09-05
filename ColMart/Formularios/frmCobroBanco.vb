'*******************************************************************************
'* PROCESAR LOS ARCHIVOS DE PAGOS EN BANCO DE LAS BOLETAS                      *
'*******************************************************************************
Public Class frmCobroBanco

    Dim nomArchivo As New OpenFileDialog
    Dim contlineas, contreg, StringLength, CurrentCharNum As Integer
    Dim cadena, nrolote, fechalote, transaccion, operacion, matricula, tipo, importe, periodo As String
    Dim banco, sucursal, codpostal, nrocheque, cuenta, plazo, codbarra, fechapago, modopago, formapago As String
    Dim detalle, obs, StartCode, Stopcode, DataToPrint, pagado As String
    Dim total, debe, haber, saldo, haberant As Double
    Dim control, id, flag, dd, mm, yyyy, vencto As String
    Dim CodigoArmado As Object

    Private Sub frmCobroBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        nomArchivo.Filter = "Archivos | *.*"
        If nomArchivo.ShowDialog = SaveFileDialog1.ShowDialog.OK Then
            txtArchivo.Text = nomArchivo.FileName
            btnProcesar.Enabled = True
        End If

    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(btnBuscar, "Presione para buscar el archivo a procesar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        FileOpen(1, nomArchivo.FileName, OpenMode.Input)
        contlineas = 0
        contreg = 0
        total = 0
        control = ""

        While Not EOF(1)
            debe = 0
            haber = 0
            saldo = 0
            detalle = ""
            obs = ""
            contlineas = contlineas + 1
            cadena = LineInput(1)
            txtMsg.Text = "Procesando Línea" & " " & Str(contlineas)

            If contlineas = 1 Then
                nrolote = Mid(cadena, 26, 5)
                fechalote = Mid(cadena, 18, 8)
                LeerLote()
                If control = "noOK" Then
                    GoTo finalizar
                End If
            End If

            If Mid(cadena, 1, 5) = "DATOS" Then
                contreg = contreg + 1
                transaccion = Mid(cadena, 41, 8)
                If Mid(cadena, 49, 2) = "A3" Then
                    operacion = "efectivo"
                End If
                If Mid(cadena, 49, 2) = "A2" Then
                    operacion = "cheque v.impuestos"
                End If
                If Mid(cadena, 49, 2) = "A5" Then
                    operacion = "cheque común"
                End If
                matricula = Mid(cadena, 65, 5)
                tipo = Mid(cadena, 70, 2)
                periodo = Mid(cadena, 76, 2) & "-" & Mid(cadena, 72, 4)
                importe = Mid(cadena, 78, 11)
                haber = Val(importe) / 100
                total = total + (Val(importe) / 100)
                banco = Mid(cadena, 136, 3)
                sucursal = Mid(cadena, 139, 3)
                codpostal = Mid(cadena, 142, 4)
                nrocheque = Mid(cadena, 146, 8)
                cuenta = Mid(cadena, 154, 8)
                plazo = Mid(cadena, 162, 3)
                codbarra = Mid(cadena, 165, 60)
                fechapago = "20" & Mid(cadena, 225, 6)
                dd = Mid(cadena, 194, 2)
                mm = Mid(cadena, 196, 2)
                yyyy = "20" & Mid(cadena, 198, 2)
                vencto = yyyy & "-" & mm & "-" & dd

                If Mid(cadena, 231, 1) = "1" Then
                    modopago = "cheque presentado"
                ElseIf Mid(cadena, 231, 1) = "2" Then
                    modopago = "cheque conformado"
                ElseIf Mid(cadena, 231, 1) = "3" Then
                    modopago = "cheque rechazado"
                Else
                    modopago = "otros"
                End If

                If Mid(cadena, 248, 2) = "00" Then
                    formapago = "efectivo"
                End If
                If Mid(cadena, 248, 2) = "90" Then
                    formapago = "débito"
                End If
                detalle = "PAGO BANCO PERÍODO " & periodo
                obs = "Transaccion: " & transaccion & " Período: " & periodo & " Forma: " & formapago

                GrabarPago()
                BuscarBoleta()
                GrabarBoletas()
                GrabarCtaCte()
                GrabarCaja()

            End If

            If Mid(cadena, 1, 7) = "TRAILER" Then
                If Val(Mid(cadena, 8, 8)) <> contreg Then
                    detmsg = "Cantidad de Registros diferente...!!!"
                    tipomsg = "info"
                    btnmsg = 1
                    frmMsgBox.ShowDialog()
                End If
                If Val(Mid(cadena, 16, 13)) / 100 <> total Then
                    detmsg = "Importe de Cupones diferente...!!!"
                    tipomsg = "info"
                    btnmsg = 1
                    frmMsgBox.ShowDialog()
                End If
                If contreg > 0 Then
                    GrabarLote()
                Else
                    GrabarLote()
                    detmsg = "LOTE SIN REGISTROS...!!!"
                    tipomsg = "info"
                    btnmsg = 1
                    frmMsgBox.ShowDialog()
                End If
            End If

        End While

        detmsg = "Proceso terminado...!!!"
        tipomsg = "info"
        btnmsg = 1
        frmMsgBox.ShowDialog()
        txtArchivo.Text = ""
        txtMsg.Text = ""
        btnProcesar.Enabled = False

finalizar:

        FileClose(1)

    End Sub

    Private Sub btnProcesar_MouseHover(sender As Object, e As EventArgs) Handles btnProcesar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Procesar."
        ToolTipMsg.SetToolTip(btnProcesar, "Presione para realizar el proceso de carga de pagos.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerLote()

        comando.CommandText = "SELECT * FROM lotebanco WHERE NroLote = " & nrolote & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            detmsg = "Lote ya procesado...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            control = "noOK"
        End If

    End Sub

    Private Sub GrabarPago()

        periodo = Mid(periodo, 4, 4) + Mid(periodo, 1, 2)

        Try
            comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)

            comando.Parameters.AddWithValue("@id_ctacte", 0)
            comando.Parameters.AddWithValue("@matricula", matricula)
            comando.Parameters.AddWithValue("@fecha", fechapago)
            comando.Parameters.AddWithValue("@tipo", "BCO")
            comando.Parameters.AddWithValue("@comprobante", transaccion)
            comando.Parameters.AddWithValue("@item", 1)
            comando.Parameters.AddWithValue("@detalle", detalle)
            comando.Parameters.AddWithValue("@periodo", periodo)
            comando.Parameters.AddWithValue("@debe", 0)
            comando.Parameters.AddWithValue("@haber", haber)
            comando.Parameters.AddWithValue("@saldo", 0)
            comando.Parameters.AddWithValue("@estado", "PAGO BANCO")
            comando.Parameters.AddWithValue("@pagado", haber)
            comando.Parameters.AddWithValue("@fecpago", fechapago)
            comando.Parameters.AddWithValue("@resto", 0)
            comando.Parameters.AddWithValue("@obs", obs)

            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GrabarCaja()

        Dim efectivo, tarjeta, transferencia As Double
        efectivo = 0
        tarjeta = 0
        transferencia = haber

        detalle = "PAGO BANCO - MAT.: " & matricula & " Fec.: " & fechapago & ""
        obs = "Per.: " & periodo & " Lote: " & nrolote & " Trans.: " & transaccion & ""

        comando = New MySqlCommand("INSERT INTO caja VALUES(@fecha, @detalle, @debe, @haber, @saldo, @efectivo, @tarjeta, @transfe, @obs, @estado)", conexion)
        comando.Parameters.AddWithValue("@fecha", fechapago)
        comando.Parameters.AddWithValue("@detalle", detalle)
        comando.Parameters.AddWithValue("@debe", 0)
        comando.Parameters.AddWithValue("@haber", haber)
        comando.Parameters.AddWithValue("@saldo", 0)
        comando.Parameters.AddWithValue("@efectivo", efectivo)
        comando.Parameters.AddWithValue("@tarjeta", tarjeta)
        comando.Parameters.AddWithValue("@transfe", transferencia)
        comando.Parameters.AddWithValue("@obs", obs)
        comando.Parameters.AddWithValue("@estado", "ABIERTA")
        comando.ExecuteNonQuery()

    End Sub

    Private Sub BuscarBoleta()

        flag = ""
        CodigoArmado = ""
        DataToPrint = ""

        'Assign start and stop codes
        StartCode = ChrW(40)
        Stopcode = ChrW(41)
        StringLength = Len(codbarra)
        For j = 1 To 46 Step 2
            'Get the value of each number pair
            CurrentCharNum = Val((Mid(codbarra, j, 2)))
            'Get the ASCII value of CurrentChar
            If CurrentCharNum <= 49 Then DataToPrint = DataToPrint & ChrW(CurrentCharNum + 48)
            If CurrentCharNum >= 50 Then DataToPrint = DataToPrint & ChrW(CurrentCharNum + 142)
        Next j

        codbarra = StartCode + codbarra + Stopcode
        'Get Printable String
        CodigoArmado = StartCode + DataToPrint + Stopcode

        comando.CommandText = "SELECT * FROM boletas WHERE CodigoBoleta = '" & CodigoArmado & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            id = CStr(row("id_Boleta"))
            flag = "SI"
        Else
            flag = "NO"
        End If

    End Sub

    Private Sub GrabarBoletas()

        If flag = "SI" Then
            Try
                comando = New MySqlCommand(("UPDATE boletas SET EstadoBoleta = 'PAGADA', FecPagoBoleta = '" & fechapago & "', FormaPagoBoleta = 'PAGO BANCO'," _
                                            & " PagadoBoleta = '" & haber & "', SaldoBoleta = '0' WHERE MatBoleta = '" & matricula & "' AND  id_Boleta = '" & id & "'"), conexion)
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            BuscarSaldo()
        End If

    End Sub

    Private Sub GrabarCtaCte()

        If Val(matricula) < 60000 Then
            Try
                comando = New MySqlCommand(("UPDATE ctasctes SET EstadoCC = 'PAGO BANCO', FecPagoCC = '" & fechapago & "', RestoCC = 0, PagadoCC = DebeCC " _
                                            & " WHERE NroCC = '" & matricula & "' AND  FechaCC = '" & vencto & "' AND TipoCbteCC =  'LIQ' "), conexion)
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                comando = New MySqlCommand(("UPDATE ctasctes SET EstadoCC = 'PAGO BANCO', FecPagoCC = '" & fechapago & "', RestoCC = 0, PagadoCC = DebeCC " _
                                            & " WHERE NroCC = '" & matricula & "' AND  FechaCC = '" & vencto & "' AND TipoCbteCC =  'LIQ' "), conexion)
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub BuscarSaldo()

        comando.CommandText = "SELECT * FROM boletas WHERE MatBoleta = '" & matricula & "' AND Concepto1Boleta = 'SALDO AL 30-06-2021'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            id = CStr(row("id_Boleta"))
            haberant = row("PagadoBoleta")
            saldo = row("SaldoBoleta")
            haberant = haberant + haber
            saldo = saldo - haber
            If saldo > 0 Then
                comando = New MySqlCommand(("UPDATE boletas SET EstadoBoleta = 'CON SALDO', FecPagoBoleta = '" & fechapago & "', FormaPagoBoleta = 'PAGO BANCO'," _
                                            & " PagadoBoleta = '" & haberant & "', SaldoBoleta = '" & saldo & "' WHERE MatBoleta = '" & matricula & "' AND  id_Boleta = '" & id & "'"), conexion)
            Else
                comando = New MySqlCommand(("UPDATE boletas SET EstadoBoleta = 'PAGADA', FecPagoBoleta = '" & fechapago & "', FormaPagoBoleta = 'PAGO BANCO'," _
                                            & " PagadoBoleta = '" & haberant & "', SaldoBoleta = '" & saldo & "' WHERE MatBoleta = '" & matricula & "' AND  id_Boleta = '" & id & "'"), conexion)
            End If
            comando.ExecuteNonQuery()
        Else
            detmsg = "NO POSEE BOLETAS PARA ESE PAGO...!!!" & matricula
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            control = "noOK"
        End If

    End Sub

    Private Sub GrabarLote()

        Try
            comando = New MySqlCommand("INSERT INTO lotebanco VALUES(@id, @nrolote, @fechalote, @cantidad)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@nrolote", nrolote)
            comando.Parameters.AddWithValue("@fechalote", fechalote)
            comando.Parameters.AddWithValue("@cantidad", contreg)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

End Class