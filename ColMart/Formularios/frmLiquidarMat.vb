﻿'*******************************************************************************
'* PROGRAMA PARA LIQUIDAR A LOS MATRICULADOS                                   *
'*******************************************************************************
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class frmLiquidarMat

    Dim desdemat, hastamat As Integer
    Dim matricula, apelynombre, domicilio, codigopostal, localidad, provincia, estado, detalle As String
    Dim fila, idcodpos, contreg, comprobante, item, posicion1, nrocbte, itemcbte As Integer
    Dim importe1, importe2, importe3, importe4, total, importe, debe, haber, saldo As Double
    Dim concepto1, concepto2, concepto3, concepto4, correo As String
    Dim fecha, dia, mes, yy, anio, periodo, nombrePDF, tipocbte As String
    Dim codbarra, codigodepago As String
    Dim CodigoArmado, CodigoTotal As Object

    Private Sub frmLiquidarMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BoletasTableAdapter.Fill(DbcolmartDataSet.boletas)
        ConectarMySql()

        txtMsg.Visible = False
        txtDesdeMat.Text = 0
        txtHastaMat.Text = 60000
        txtMMPeriodo.Text = ""
        txtYYPeriodo.Text = ""
        cbxOS.Checked = False
        cbxDM.Checked = False
        cbxDU.Checked = False
        rdbNo.Checked = True
        rdbSi.Checked = False

        txtDesdeMat.Focus()

        ReportViewer1.RefreshReport()
    End Sub

    Private Sub txtDesdeMat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDesdeMat.KeyDown

        'Busco matriculados por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmMat1 As New frmConsMatri
            AddOwnedForm(frmMat1)
            frmMat1.ShowDialog()
            senial = 0
            txtHastaMat.Focus()
        End If
        'Busco matriculados por número de matrícula
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            desdemat = txtDesdeMat.Text
            txtHastaMat.Focus()
        End If

    End Sub

    Private Sub txtHastaMat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHastaMat.KeyDown

        'Busco matriculados por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmMat1 As New frmConsMatri
            AddOwnedForm(frmMat1)
            frmMat1.ShowDialog()
            senial = 0
            txtHastaMat.Focus()
        End If

        'Busco matriculados por número de matrícula
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            hastamat = txtHastaMat.Text
            txtHastaMat.Focus()
        End If

    End Sub

    Private Sub txtHastaMat_LostFocus(sender As Object, e As EventArgs) Handles txtHastaMat.LostFocus

        If txtHastaMat.Text IsNot "" Then
            If desdemat > hastamat Then
                detmsg = "Valor erróneo...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
                txtHastaMat.Focus()
            End If
        End If

    End Sub

    Private Sub dtpVencimiento_LostFocus(sender As Object, e As EventArgs) Handles dtpVencimiento.LostFocus

        fechajob = CDate(dtpVencimiento.Value)
        ProcesarFecha()
        dia = dd
        mes = mm
        anio = yyyy
        yy = Mid(anio, 3, 2)

        txtMMPeriodo.Text = mes
        txtYYPeriodo.Text = anio

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        ControlarValores()
        If senial = 1 Then
            GoTo Finalizar
        End If

        LeerComprobante()
        contreg = 0

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri >= '" & txtDesdeMat.Text & "'  AND NroMatri <= '" & txtHastaMat.Text & "' ORDER BY NroMatri "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)
        periodo = txtYYPeriodo.Text & txtMMPeriodo.Text

        For Each row In dt.Rows
            estado = Trim(CStr(row("EstadoMatri")))
            If estado = "ACTIVO" Then
                GoTo seguir
            End If
            'If estado IsNot "SUSPENDIDO" Then
            If estado = "SUSPENDIDO" Then
                GoTo seguir
            Else
                GoTo leerotro
            End If

seguir:

            txtMsg.Visible = True
            contreg = contreg + 1

            matricula = CStr(row("NroMatri"))

            BuscarLiquidado()
            If senial = 1 Then
                GoTo leerotro
            Else
                senial = 0
            End If

            apelynombre = CStr(row("ApelNombMatri"))
            domicilio = CStr(row("CalleRealMatri"))
            idcodpos = CStr(row("idLocalRMatri"))
            correo = CStr(row("EmailMatri"))

            txtMsg.Text = "Procesando Registro " & Str(matricula)
            txtMsg.Refresh()

            concepto1 = ""
            concepto2 = ""
            concepto3 = ""
            concepto4 = ""
            detalle = ""
            importe1 = 0
            importe2 = 0
            importe3 = 0
            importe4 = 0
            total = 0

            comando = New MySqlCommand("SELECT * FROM debitomatri INNER JOIN coddebito ON debitomatri.CodDebMat = coddebito.NroCodDeb AND MatDebMat = " & matricula & " ", conexion)
            dr = comando.ExecuteReader

            If dr.HasRows Then
                fila = 1
                While dr.Read
                    matricula = dr(0).ToString
                    If Mid(dr(10).ToString, 1, 2) = "DM" And cbxDM.Checked Then
                        If dr(8).ToString <> 0 Then
                            If fila = 1 Then
                                concepto1 = dr(2).ToString
                                importe1 = dr(8).ToString
                            End If
                            If fila = 2 Then
                                concepto2 = dr(2).ToString
                                importe2 = dr(8).ToString
                            End If
                            If fila = 3 Then
                                concepto3 = dr(2).ToString
                                importe3 = dr(8).ToString
                            End If
                            If fila = 4 Then
                                concepto4 = dr(2).ToString
                                importe4 = dr(8).ToString
                            End If
                            fila = fila + 1
                            total = total + dr(8).ToString
                        End If
                    End If
                    If Mid(dr(10).ToString, 1, 2) = "DU" And cbxDU.Checked Then
                        If dr(3).ToString <> 0 Then
                            If fila = 1 Then
                                concepto1 = dr(2).ToString
                                importe1 = dr(3).ToString
                            End If
                            If fila = 2 Then
                                concepto2 = dr(2).ToString
                                importe2 = dr(3).ToString
                            End If
                            If fila = 3 Then
                                concepto3 = dr(2).ToString
                                importe3 = dr(3).ToString
                            End If
                            If fila = 4 Then
                                concepto4 = dr(2).ToString
                                importe4 = dr(3).ToString
                            End If
                            detalle = dr(2).ToString
                            fila = fila + 1
                            total = total + dr(3).ToString
                        End If
                    End If
                    If Mid(dr(10).ToString, 1, 2) = "OS" And cbxOS.Checked Then
                        If dr(8).ToString <> 0 Then
                            If fila = 1 Then
                                concepto1 = dr(2).ToString
                                importe1 = dr(8).ToString
                            End If
                            If fila = 2 Then
                                concepto2 = dr(2).ToString
                                importe2 = dr(8).ToString
                            End If
                            If fila = 3 Then
                                concepto3 = dr(2).ToString
                                importe3 = dr(8).ToString
                            End If
                            If fila = 4 Then
                                concepto4 = dr(2).ToString
                                importe4 = dr(8).ToString
                            End If
                            fila = fila + 1
                            total = total + dr(8).ToString
                        End If
                    End If
                End While

                If total <> 0 Then
                    CodigoTotal = ArmaCodigoBarra(matricula, txtMMPeriodo.Text, txtYYPeriodo.Text, total, dd, mm, yy)
                    SepararCodigo()
                End If
            End If
            dr.Close()

            If total > 0 Then
                GrabarBoleta()
            End If
leerotro:

        Next

        detmsg = "Liquidación ejecutada...!!!"
        tipomsg = "info"
        btnmsg = 1
        frmMsgBox.ShowDialog()

        txtMsg.Visible = False
        txtDesdeMat.Text = 0
        txtHastaMat.Text = 60000
        txtMMPeriodo.Text = ""
        txtYYPeriodo.Text = ""
        desdemat = 0
        hastamat = 0
        cbxOS.Checked = False
        cbxDM.Checked = False
        cbxDU.Checked = False

        txtDesdeMat.Focus()

Finalizar:

    End Sub

    Private Sub btnProcesar_MouseHover(sender As Object, e As EventArgs) Handles btnProcesar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Procesar."
        ToolTipMsg.SetToolTip(btnProcesar, "Presione para procesar las boletas requeridad en los parámetros.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub GrabarBoleta()

        comando.CommandText = "SELECT matriculados.idLocalRMatri, localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv FROM matriculados " _
                                   & "INNER JOIN localidad    ON matriculados.idLocalRMatri = localidad.id_Local " _
                                   & "INNER JOIN departamento ON localidad.fk_DptoLocal     = departamento.id_Dpto " _
                                   & "INNER JOIN provincia    ON departamento.fk_ProvDpto   = provincia.id_Prov " _
                                   & "WHERE matriculados.NroMatri = '" & matricula & "' "

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            codigopostal = CStr(row("CodPosLocal"))
            localidad = CStr(row("NombreLocal"))
            provincia = CStr(row("NombreProv"))
        Else
            localidad = ""
        End If

        comprobante = comprobante + 1

        Try
            comando = New MySqlCommand("INSERT INTO boletas VALUES(@id, @matricula, @apelynombre, @domicilio, @codigopostal, @localidad, @provincia, @fecvto, @periodo ,@total," _
                                       & " @estado, @concepto1, @importe1, @concepto2, @importe2, @concepto3, @importe3, @concepto4, @importe4, @fecpago, @pagado, @saldo," _
                                       & " @formapago, @correo, @codigoboleta, @codigopago)", conexion)
            comando.Parameters.AddWithValue("@id", comprobante)
            comando.Parameters.AddWithValue("@matricula", matricula)
            comando.Parameters.AddWithValue("@apelynombre", apelynombre)
            comando.Parameters.AddWithValue("@domicilio", domicilio)
            comando.Parameters.AddWithValue("@codigopostal", codigopostal)
            comando.Parameters.AddWithValue("@localidad", localidad)
            comando.Parameters.AddWithValue("@provincia", provincia)
            comando.Parameters.AddWithValue("@fecvto", yyyy & mm & dd)
            comando.Parameters.AddWithValue("@periodo", periodo)
            comando.Parameters.AddWithValue("@total", total)
            comando.Parameters.AddWithValue("@estado", "LIQUIDADA")
            comando.Parameters.AddWithValue("@concepto1", concepto1)
            comando.Parameters.AddWithValue("@importe1", importe1)
            comando.Parameters.AddWithValue("@concepto2", concepto2)
            comando.Parameters.AddWithValue("@importe2", importe2)
            comando.Parameters.AddWithValue("@concepto3", concepto3)
            comando.Parameters.AddWithValue("@importe3", importe3)
            comando.Parameters.AddWithValue("@concepto4", concepto4)
            comando.Parameters.AddWithValue("@importe4", importe4)
            comando.Parameters.AddWithValue("@fecpago", Nothing)
            comando.Parameters.AddWithValue("@pagado", 0)
            comando.Parameters.AddWithValue("@saldo", total)
            comando.Parameters.AddWithValue("@formapago", "")
            comando.Parameters.AddWithValue("@correo", correo)
            comando.Parameters.AddWithValue("@codigoboleta", CodigoArmado)
            comando.Parameters.AddWithValue("@codigopago", codigodepago)

            comando.ExecuteNonQuery()

            'Limpiemos el DataSource del informe
            ReportViewer1.LocalReport.DataSources.Clear()
            'Establezcamos los parametros que enviaremos al reporte
            Dim parametros As ReportParameter() = New ReportParameter(20) {}

            PonerCeros(matricula, 5)
            matricula = nroconceros

            fecha = dia & "/" & mes & "/" & anio
            codbarra = CodigoArmado

            parametros(0) = New ReportParameter("prmMatricula", matricula)
            parametros(1) = New ReportParameter("prmApelyNombre", apelynombre)
            parametros(2) = New ReportParameter("prmDomicilio", domicilio)
            parametros(3) = New ReportParameter("prmCodigoPostal", codigopostal)
            parametros(4) = New ReportParameter("prmLocalidad", localidad)
            parametros(5) = New ReportParameter("prmProvincia", provincia)
            parametros(6) = New ReportParameter("prmPeriodo", periodo)
            parametros(7) = New ReportParameter("prmFechaVto", fecha)
            parametros(8) = New ReportParameter("prmCodigo", codbarra)
            parametros(9) = New ReportParameter("prmConcepto1", concepto1)
            parametros(10) = New ReportParameter("prmConcepto2", concepto2)
            parametros(11) = New ReportParameter("prmConcepto3", concepto3)
            parametros(12) = New ReportParameter("prmConcepto4", concepto4)
            parametros(13) = New ReportParameter("prmImporte1", importe1)
            parametros(14) = New ReportParameter("prmImporte2", importe2)
            parametros(15) = New ReportParameter("prmImporte3", importe3)
            parametros(16) = New ReportParameter("prmImporte4", importe4)
            parametros(17) = New ReportParameter("prmTotal", total)
            parametros(18) = New ReportParameter("prmTipoNro", "MATRÍCULA:")
            parametros(19) = New ReportParameter("prmTipoNom", "MCP:")
            parametros(20) = New ReportParameter("prmNroDePago", codigodepago)

            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsBoletas", BoletasBindingSource))
            ReportViewer1.LocalReport.SetParameters(parametros)

            nombrePDF = matricula & "-" & periodo

            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            'Dim newFile As New FileStream("\\DESKTOP\dbcolmart\boletas\" & nombrePDF & ".pdf", FileMode.Create)
            Dim newFile As New FileStream("E:\dbcolmart\boletas\" & nombrePDF & ".pdf", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()

            ReportViewer1.RefreshReport()

            '***CALCULAMOS EL SALDO A FAVOR SI TIENE***
            CalcularSaldo()

            '***GRABAMOS LAS CTAS CTES NUEVAS***
            If concepto1 <> "" Then
                Try
                    comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id, @matricula, @fecvto, @tipo, @comprobante, @item, @detalle, @periodo, @debe ,@haber, @saldo, @estado, @pagado, @fecha, @resto, @obs)", conexion)
                    comando.Parameters.AddWithValue("@id", 0)
                    comando.Parameters.AddWithValue("@matricula", matricula)
                    comando.Parameters.AddWithValue("@fecvto", yyyy & "-" & mm & "-" & dd)
                    comando.Parameters.AddWithValue("@tipo", "LIQ")
                    comando.Parameters.AddWithValue("@comprobante", comprobante)
                    comando.Parameters.AddWithValue("@item", 1)
                    comando.Parameters.AddWithValue("@detalle", concepto1)
                    comando.Parameters.AddWithValue("@periodo", periodo)
                    comando.Parameters.AddWithValue("@debe", importe1)
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    comando.Parameters.AddWithValue("@pagado", 0)
                    comando.Parameters.AddWithValue("@fecha", "1900-01-01")
                    comando.Parameters.AddWithValue("@obs", "")

                    If senial = 1 Then
                        saldo = saldo + importe1
                        If saldo = 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                        If saldo > 0 Then
                            comando.Parameters.AddWithValue("@resto", saldo)
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                        If saldo < 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                    Else
                        comando.Parameters.AddWithValue("@resto", importe1)
                        If rdbNo.Checked = True And rdbSi.Checked = False Then
                            comando.Parameters.AddWithValue("@estado", "LIQUIDADA")
                        ElseIf rdbNo.Checked = False And rdbSi.Checked = True Then
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                    End If

                    comando.ExecuteNonQuery()

                    If saldo > 0 Then
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = 0 WHERE NroCpbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    Else
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = '" & saldo & "' WHERE NroCbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    End If

                    item = 1
                    detalle = concepto1
                    importe = importe1
                    GrabarVentas()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If concepto2 <> "" Then
                Try
                    comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id, @matricula, @fecvto, @tipo, @comprobante, @item, @detalle, @periodo, @debe ,@haber, @saldo, @estado, @pagado, @fecha, @resto, @obs)", conexion)
                    comando.Parameters.AddWithValue("@id", 0)
                    comando.Parameters.AddWithValue("@matricula", matricula)
                    comando.Parameters.AddWithValue("@fecvto", yyyy & "-" & mm & "-" & dd)
                    comando.Parameters.AddWithValue("@tipo", "LIQ")
                    comando.Parameters.AddWithValue("@comprobante", comprobante)
                    comando.Parameters.AddWithValue("@item", 2)
                    comando.Parameters.AddWithValue("@detalle", concepto2)
                    comando.Parameters.AddWithValue("@periodo", periodo)
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    comando.Parameters.AddWithValue("@pagado", 0)
                    comando.Parameters.AddWithValue("@fecha", "1900-01-01")
                    comando.Parameters.AddWithValue("@resto", importe2)
                    comando.Parameters.AddWithValue("@obs", "")

                    If senial = 1 Then
                        saldo = saldo + importe2
                        If saldo = 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                        If saldo > 0 Then
                            comando.Parameters.AddWithValue("@resto", saldo)
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                        If saldo < 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                    Else
                        comando.Parameters.AddWithValue("@debe", importe2)
                        If rdbNo.Checked = True And rdbSi.Checked = False Then
                            comando.Parameters.AddWithValue("@estado", "LIQUIDADA")
                        ElseIf rdbNo.Checked = False And rdbSi.Checked = True Then
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                    End If

                    comando.ExecuteNonQuery()

                    If saldo > 0 Then
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = 0 WHERE NroCpbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    Else
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = '" & saldo & "' WHERE NroCbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    End If

                    item = 2
                    detalle = concepto2
                    importe = importe2
                    GrabarVentas()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If concepto3 <> "" Then
                Try
                    comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id, @matricula, @fecvto, @tipo, @comprobante, @item, @detalle, @periodo, @debe ,@haber, @saldo, @estado, @pagado, @fecha, @resto, @obs)", conexion)
                    comando.Parameters.AddWithValue("@id", 0)
                    comando.Parameters.AddWithValue("@matricula", matricula)
                    comando.Parameters.AddWithValue("@fecvto", yyyy & "-" & mm & "-" & dd)
                    comando.Parameters.AddWithValue("@tipo", "LIQ")
                    comando.Parameters.AddWithValue("@comprobante", comprobante)
                    comando.Parameters.AddWithValue("@item", 3)
                    comando.Parameters.AddWithValue("@detalle", concepto3)
                    comando.Parameters.AddWithValue("@periodo", periodo)
                    comando.Parameters.AddWithValue("@debe", importe3)
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    comando.Parameters.AddWithValue("@pagado", 0)
                    comando.Parameters.AddWithValue("@fecha", "1900-01-01")
                    comando.Parameters.AddWithValue("@obs", "")

                    If senial = 1 Then
                        saldo = saldo + importe3
                        If saldo = 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                        If saldo > 0 Then
                            comando.Parameters.AddWithValue("@resto", saldo)
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                        If saldo < 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                    Else
                        comando.Parameters.AddWithValue("@resto", importe3)
                        If rdbNo.Checked = True And rdbSi.Checked = False Then
                            comando.Parameters.AddWithValue("@estado", "LIQUIDADA")
                        ElseIf rdbNo.Checked = False And rdbSi.Checked = True Then
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                    End If

                    comando.ExecuteNonQuery()

                    If saldo > 0 Then
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = 0 WHERE NroCpbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    Else
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = '" & saldo & "' WHERE NroCbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    End If

                    item = 3
                    detalle = concepto3
                    importe = importe3
                    GrabarVentas()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If concepto4 <> "" Then
                Try
                    comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id, @matricula, @fecvto, @tipo, @comprobante, @item, @detalle, @periodo, @debe ,@haber, @saldo, @estado, @pagado, @fecha, @resto, @obs)", conexion)
                    comando.Parameters.AddWithValue("@id", 0)
                    comando.Parameters.AddWithValue("@matricula", matricula)
                    comando.Parameters.AddWithValue("@fecvto", yyyy & "-" & mm & "-" & dd)
                    comando.Parameters.AddWithValue("@tipo", "LIQ")
                    comando.Parameters.AddWithValue("@comprobante", comprobante)
                    comando.Parameters.AddWithValue("@item", 4)
                    comando.Parameters.AddWithValue("@detalle", concepto4)
                    comando.Parameters.AddWithValue("@periodo", periodo)
                    comando.Parameters.AddWithValue("@haber", 0)
                    comando.Parameters.AddWithValue("@saldo", 0)
                    comando.Parameters.AddWithValue("@pagado", 0)
                    comando.Parameters.AddWithValue("@fecha", "1900-01-01")
                    comando.Parameters.AddWithValue("@resto", importe4)
                    comando.Parameters.AddWithValue("@obs", "")

                    If senial = 1 Then
                        saldo = saldo + importe4
                        If saldo = 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                        If saldo > 0 Then
                            comando.Parameters.AddWithValue("@resto", saldo)
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                        If saldo < 0 Then
                            comando.Parameters.AddWithValue("@resto", 0)
                            comando.Parameters.AddWithValue("@estado", "PAGADA")
                        End If
                    Else
                        comando.Parameters.AddWithValue("@debe", importe4)
                        If rdbNo.Checked = True And rdbSi.Checked = False Then
                            comando.Parameters.AddWithValue("@estado", "LIQUIDADA")
                        ElseIf rdbNo.Checked = False And rdbSi.Checked = True Then
                            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                        End If
                    End If

                    comando.ExecuteNonQuery()

                    If saldo > 0 Then
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = 0 WHERE NroCpbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    Else
                        comando = New MySqlCommand("UPDATE ctasctes SET RestoCC = '" & saldo & "' WHERE NroCbteCC = '" & nrocbte & "' AND TipoCbteCC = '" & tipocbte & "' AND ItemCC = '" & itemcbte & "' ", conexion)
                        comando.ExecuteNonQuery()
                    End If

                    item = 4
                    detalle = concepto4
                    importe = importe4
                    GrabarVentas()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            comando = New MySqlCommand("UPDATE comprobte SET NroCpbte = '" & comprobante & "' WHERE TipoCpbte = 'LIQ' ", conexion)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ControlarValores()

        senial = 0
        If desdemat > hastamat Then
            senial = 1
            txtDesdeMat.Focus()
        End If
        If txtMMPeriodo.Text = 0 Or txtMMPeriodo.Text > 12 Then
            senial = 1
            txtMMPeriodo.Focus()
        End If
        If txtYYPeriodo.Text = 0 Or txtYYPeriodo.Text < Year(dtpVencimiento.Value) Then
            senial = 1
            txtYYPeriodo.Focus()
        End If
        If cbxOS.Checked = False And cbxDM.Checked = False And cbxDU.Checked = False Then
            senial = 1
            cbxOS.Focus()
        End If
        If senial = 1 Then
            detmsg = "Controlar los valores ingresados...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub rdbNo_MouseHover(sender As Object, e As EventArgs) Handles rdbNo.MouseHover

        ToolTipMsg.ToolTipTitle = "Opción NO."
        ToolTipMsg.SetToolTip(rdbNo, "Marcar para liquidar boletas con el proceso completo de envío por mail desde el sistema.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub rdbSi_MouseHover(sender As Object, e As EventArgs) Handles rdbSi.MouseHover

        ToolTipMsg.ToolTipTitle = "Opción SI."
        ToolTipMsg.SetToolTip(rdbSi, "Marcar para liquidar boletas sin enviar por mail desde el sistema.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub cbxOS_MouseHover(sender As Object, e As EventArgs) Handles cbxOS.MouseHover

        ToolTipMsg.ToolTipTitle = "Opción OS - Obra Social."
        ToolTipMsg.SetToolTip(cbxOS, "Marcar para liquidar a martilleros con cuota y Obra Social.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub cbxDM_MouseHover(sender As Object, e As EventArgs) Handles cbxDM.MouseHover

        ToolTipMsg.ToolTipTitle = "Opción DM - Débito Mensual."
        ToolTipMsg.SetToolTip(cbxDM, "Marcar para liquidar a martilleros con cuota solamente.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

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

    Private Sub SepararCodigo()

        posicion1 = InStr(1, CodigoTotal, "*")
        CodigoArmado = Mid(CodigoTotal, 1, posicion1 - 1)
        codigodepago = Mid(CodigoTotal, posicion1 + 1)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub GrabarVentas()

        comando = New MySqlCommand("INSERT INTO ventas VALUES(@id, @fecha, @tipo, @cpbte, @item, @detalle, @periodo, @neto, @total)", conexion)
        comando.Parameters.AddWithValue("@id", 0)
        comando.Parameters.AddWithValue("@fecha", yyyy & "-" & mm & "-" & dd)
        comando.Parameters.AddWithValue("@tipo", "LIQ")
        comando.Parameters.AddWithValue("@cpbte", comprobante)
        comando.Parameters.AddWithValue("@item", item)
        comando.Parameters.AddWithValue("@detalle", detalle)
        comando.Parameters.AddWithValue("@periodo", periodo)
        comando.Parameters.AddWithValue("@neto", importe)
        comando.Parameters.AddWithValue("@total", 0)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub BuscarLiquidado()

        comando = New MySqlCommand("SELECT * FROM ctasctes WHERE NroCC = '" & matricula & "' AND TipoCbteCC = 'LIQ' AND PeriodoCC = '" & periodo & "'", conexion)
        dr = comando.ExecuteReader
        senial = 0

        If dr.HasRows Then
            While dr.Read
                senial = 1
            End While
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub CalcularSaldo()

        saldo = 0
        senial = 0

        comando = New MySqlCommand("SELECT * FROM ctasctes WHERE NroCC = '" & matricula & "' AND RestoCC < 0 ", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                senial = 1
                tipocbte = dr(3).ToString
                nrocbte = dr(4).ToString
                itemcbte = dr(5).ToString
                saldo = dr(14).ToString
            End While
        End If

        dr.Close()
        dr.Dispose()

    End Sub

End Class