Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.IO.File
Imports System.Data

Public Class frmPasaje

    Dim items, contreg, pos1, pos2, longitud, cantidad As Integer
    Dim comprobante, yyyy, mm, dd, id, fechaaux, ceros As String
    Dim matricula, periodo, detalle, fecha, estado, obs As String
    Dim concepto, tipocbte, formapago, fecpago As String
    Dim impboleta, pagado, resto, importe As Double
    Dim debe, haber, saldo As Double
    Private Sub frmPasaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        comando = New MySqlCommand("DELETE FROM ctasctes", conexion)
        dr = comando.ExecuteReader
        dr.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        LeerComprobante()
        contreg = 0
        id = "1"

        Try
            'comando.CommandText = "SELECT * FROM boletas LEFT OUTER JOIN ctactemat ON boletas.id_Boleta = ctactemat.id_CCMat ORDER BY MatBoleta"
            comando.CommandText = "SELECT * FROM boletas ORDER BY MatBoleta"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows
                contreg = contreg + 1
                debe = 0
                haber = 0
                saldo = 0
                senial = 0

                txtMsg.Text = "PROCESANDO REGISTRO: " & CStr(contreg)
                matricula = CStr(row("MatBoleta"))

                fechaaux = row("FecVtoBoleta")
                MoverFecha()
                fecha = yyyy + "-" + mm + "-" + dd

                If IsDBNull(row("FecPagoBoleta")) Then
                    fecpago = "1900-01-01"
                    'fechaaux = row("FecPagoBoleta")
                Else
                    fechaaux = row("FecPagoBoleta")
                    MoverFecha()
                    fecpago = yyyy + "-" + mm + "-" + dd
                End If

                periodo = row("PeriodoBoleta")
                tipocbte = "LIQ"
                comprobante = comprobante + 1
                impboleta = 0
                pagado = 0
                impboleta = row("ImporteBoleta")
                pagado = row("PagadoBoleta")
                obs = ""
                estado = row("EstadoBoleta")
                formapago = row("FormaPagoBoleta")

                concepto = row("Concepto2Boleta")
                importe = row("ImpCon2Boleta")
                If concepto <> "" Then
                    items = 2
                    GrabarCtasCtes()
                    id = id + 1
                End If

                concepto = row("Concepto1Boleta")
                importe = row("ImpCon1Boleta")
                If concepto <> "" Then
                    items = 1
                    GrabarCtasCtes()
                    id = id + 1
                End If
            Next

            comando = New MySqlCommand("UPDATE comprobte SET NroCpbte = '" & comprobante & "' WHERE TipoCpbte = 'LIQ' ", conexion)
            comando.ExecuteNonQuery()

            GrabarPagos()

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        DesconectarMySql()

        detmsg = "PROCESO TERMINADO...!!!"
        tipomsg = "info"
        btnmsg = 1
        frmMsgBox.ShowDialog()


    End Sub

    Private Sub GrabarCtasCtes()

        Try
            comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)

            comando.Parameters.AddWithValue("@id_ctacte", id)
            comando.Parameters.AddWithValue("@matricula", matricula)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@tipo", "LIQ")
            comando.Parameters.AddWithValue("@comprobante", comprobante)
            comando.Parameters.AddWithValue("@item", items)
            comando.Parameters.AddWithValue("@detalle", concepto)
            comando.Parameters.AddWithValue("@periodo", periodo)
            If estado = "PENDIENTE" Then
                estado = "CON SALDO"
            End If
            If estado = "PAGADA" Then
                comando.Parameters.AddWithValue("@debe", importe)
                comando.Parameters.AddWithValue("@haber", 0)
                comando.Parameters.AddWithValue("@saldo", 0)
                comando.Parameters.AddWithValue("@estado", estado)
                comando.Parameters.AddWithValue("@pagado", importe)
                comando.Parameters.AddWithValue("@fecpago", fecpago)
                comando.Parameters.AddWithValue("@resto", 0)
                comando.Parameters.AddWithValue("@obs", obs)
            End If
            If estado = "ENVIADA" Then
                comando.Parameters.AddWithValue("@debe", importe)
                comando.Parameters.AddWithValue("@haber", 0)
                comando.Parameters.AddWithValue("@saldo", 0)
                comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                comando.Parameters.AddWithValue("@pagado", 0)
                comando.Parameters.AddWithValue("@fecpago", fecpago)
                comando.Parameters.AddWithValue("@resto", importe)
                comando.Parameters.AddWithValue("@obs", obs)
            End If
            If estado = "LIQUIDADA" Then
                comando.Parameters.AddWithValue("@debe", importe)
                comando.Parameters.AddWithValue("@haber", 0)
                comando.Parameters.AddWithValue("@saldo", 0)
                comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                comando.Parameters.AddWithValue("@pagado", 0)
                comando.Parameters.AddWithValue("@fecpago", fecpago)
                comando.Parameters.AddWithValue("@resto", importe)
                comando.Parameters.AddWithValue("@obs", obs)
            End If
            If estado = "IMPRESA" Then
                comando.Parameters.AddWithValue("@debe", importe)
                comando.Parameters.AddWithValue("@haber", 0)
                comando.Parameters.AddWithValue("@saldo", 0)
                comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                comando.Parameters.AddWithValue("@pagado", 0)
                comando.Parameters.AddWithValue("@fecpago", fecpago)
                comando.Parameters.AddWithValue("@resto", importe)
                comando.Parameters.AddWithValue("@obs", obs)
            End If
            If estado = "CON SALDO" Then
                saldo = impboleta - pagado

                If items = 2 Then
                    comando.Parameters.AddWithValue("@debe", importe)
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    If saldo > 0 Then
                        comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        comando.Parameters.AddWithValue("@pagado", pagado)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", saldo)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    If saldo = 0 Then
                        comando.Parameters.AddWithValue("@estado", "PAGADA")
                        comando.Parameters.AddWithValue("@pagado", importe)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", 0)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    If saldo < 0 Then
                        comando.Parameters.AddWithValue("@estado", "PAGADA")
                        comando.Parameters.AddWithValue("@pagado", importe)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", 0)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    senial = 2
                End If
                If items = 1 Then
                    comando.Parameters.AddWithValue("@debe", importe)
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    If saldo > 0 And senial = 2 Then
                        comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        comando.Parameters.AddWithValue("@pagado", 0)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", importe)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    If saldo > 0 And senial = 0 Then
                        comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        comando.Parameters.AddWithValue("@pagado", pagado)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", saldo)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    If saldo = 0 And senial = 2 Then
                        comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        comando.Parameters.AddWithValue("@pagado", 0)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", importe)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    If saldo = 0 And senial = 0 Then
                        comando.Parameters.AddWithValue("@estado", "PAGADA")
                        comando.Parameters.AddWithValue("@pagado", importe)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", 0)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    If saldo < 0 And senial = 0 Then
                        comando.Parameters.AddWithValue("@estado", "PAGADA")
                        comando.Parameters.AddWithValue("@pagado", importe)
                        comando.Parameters.AddWithValue("@fecpago", fecpago)
                        comando.Parameters.AddWithValue("@resto", saldo)
                        comando.Parameters.AddWithValue("@obs", obs)
                    End If
                    If saldo < 0 And senial = 2 Then
                        saldo = saldo + importe
                        If saldo > 0 Then
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                            comando.Parameters.AddWithValue("@pagado", impboleta - saldo)
                            comando.Parameters.AddWithValue("@fecpago", fecpago)
                            comando.Parameters.AddWithValue("@resto", saldo)
                            comando.Parameters.AddWithValue("@obs", obs)
                        End If
                        If saldo = 0 Then
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                            comando.Parameters.AddWithValue("@pagado", importe)
                            comando.Parameters.AddWithValue("@fecpago", fecpago)
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@obs", obs)
                        End If
                        If saldo < 0 Then
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                            comando.Parameters.AddWithValue("@pagado", importe)
                            comando.Parameters.AddWithValue("@fecpago", fecpago)
                            comando.Parameters.AddWithValue("@resto", saldo)
                            comando.Parameters.AddWithValue("@obs", obs)
                        End If
                    End If
                End If
            End If

            'If matricula < 60000 Then
            comando.ExecuteNonQuery()
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GrabarPagos()

        Try
            comando.CommandText = "SELECT * FROM ctactemat WHERE HaberCCMat <> '0' ORDER BY NroCCMat"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows

                matricula = CStr(row("NroCCMat"))
                fechaaux = row("FechaCCMat")
                MoverFecha()
                fecha = yyyy + "-" + mm + "-" + dd

                debe = row("DebeCCMat")
                haber = row("HaberCCMat")
                saldo = row("SaldoCCMat")
                obs = CStr(row("ObsCCMat"))
                estado = CStr(row("EstadoCCMat"))
                comprobante = comprobante + 1

                If estado = "PAGO" Then
                    comprobante = CStr(row("DetCCMat"))
                    comprobante = Val(Mid(comprobante, 11, 8))
                    tipocbte = "CIP"
                End If

                If estado = "PAGO BANCO" Then
                    comprobante = CStr(row("ObsCCMat"))
                    comprobante = Val(Mid(comprobante, 14, 8))
                    tipocbte = "BCO"
                End If

                comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)

                comando.Parameters.AddWithValue("@id_ctacte", id)
                comando.Parameters.AddWithValue("@matricula", matricula)
                comando.Parameters.AddWithValue("@fecha", fecha)
                comando.Parameters.AddWithValue("@tipo", tipocbte)
                comando.Parameters.AddWithValue("@comprobante", comprobante)
                comando.Parameters.AddWithValue("@item", 1)
                comando.Parameters.AddWithValue("@detalle", CStr(row("DetCCMat")))
                comando.Parameters.AddWithValue("@periodo", "")
                comando.Parameters.AddWithValue("@debe", debe)
                comando.Parameters.AddWithValue("@haber", haber)
                comando.Parameters.AddWithValue("@saldo", saldo)
                comando.Parameters.AddWithValue("@estado", estado)
                comando.Parameters.AddWithValue("@pagado", haber)
                comando.Parameters.AddWithValue("@fecpago", fecha)
                comando.Parameters.AddWithValue("@resto", 0)
                comando.Parameters.AddWithValue("@obs", obs)

                comando.ExecuteNonQuery()

                id = id + 1

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            comando.CommandText = "SELECT * FROM ctactesoc WHERE HaberCCSoc <> '0' ORDER BY NroCCSoc"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows

                matricula = CStr(row("NroCCSoc"))
                fechaaux = row("FechaCCSoc")
                MoverFecha()
                fecha = yyyy + "-" + mm + "-" + dd

                debe = row("DebeCCSoc")
                haber = row("HaberCCSoc")
                saldo = row("SaldoCCSoc")
                obs = CStr(row("ObsCCSoc"))
                estado = CStr(row("EstadoCCSoc"))
                comprobante = comprobante + 1

                If estado = "PAGO" Then
                    comprobante = CStr(row("DetCCSoc"))
                    comprobante = Val(Mid(comprobante, 11, 8))
                    tipocbte = "CIP"
                End If

                If estado = "PAGO BANCO" Then
                    comprobante = CStr(row("ObsCCSoc"))
                    comprobante = Val(Mid(comprobante, 14, 8))
                    tipocbte = "BCO"
                End If

                comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id_ctacte, @matricula, @fecha, @tipo, @comprobante, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado, @pagado, @fecpago, @resto, @obs)", conexion)

                comando.Parameters.AddWithValue("@id_ctacte", id)
                comando.Parameters.AddWithValue("@matricula", matricula)
                comando.Parameters.AddWithValue("@fecha", fecha)
                comando.Parameters.AddWithValue("@tipo", tipocbte)
                comando.Parameters.AddWithValue("@comprobante", comprobante)
                comando.Parameters.AddWithValue("@item", 1)
                comando.Parameters.AddWithValue("@detalle", CStr(row("DetCCSoc")))
                comando.Parameters.AddWithValue("@periodo", "")
                comando.Parameters.AddWithValue("@debe", debe)
                comando.Parameters.AddWithValue("@haber", haber)
                comando.Parameters.AddWithValue("@saldo", saldo)
                comando.Parameters.AddWithValue("@estado", estado)
                comando.Parameters.AddWithValue("@pagado", haber)
                comando.Parameters.AddWithValue("@fecpago", fecha)
                comando.Parameters.AddWithValue("@resto", 0)
                comando.Parameters.AddWithValue("@obs", obs)

                comando.ExecuteNonQuery()

                id = id + 1

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub LeerComprobante()

        comando = New MySqlCommand("SELECT * FROM comprobte WHERE TipoCpbte = 'LIQ'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                comprobante = dr(1).ToString
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub
End Class