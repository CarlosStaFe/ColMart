'*******************************************************************************
'* PROGRAMA PARA LIQUIDAR A LAS SOCIEDADES                                     *
'*******************************************************************************
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class frmLiquidarSoc

    Dim nrosociedad, desdesoc, hastasoc As Integer
    Dim sociedad, nombre, domicilio, codigopostal, localidad, provincia As String
    Dim fila, dia, mes, anio, yy As Integer
    Dim importe1, importe2, importe3, importe4 As Double
    Dim concepto1, concepto2, concepto3, concepto4, correo As String
    Dim total As Double
    Dim contreg, comprobante As Integer
    Dim periodo, posicion1 As Integer
    Dim codbarra, codigodepago As String
    Dim CodigoArmado, CodigoTotal As Object
    Dim nombrePDF As String

    Private Sub frmLiquidarSoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BoletasTableAdapter.Fill(DbcolmartDataSet.boletas)
        ConectarMySql()
        txtDesdeSoc.Text = 60000
        txtHastaSoc.Text = 99999
        txtMMperiodo.Text = ""
        txtYYPeriodo.Text = ""
        cbxDM.Checked = False
        cbxDU.Checked = False

        txtDesdeSoc.Focus()

    End Sub

    Private Sub txtDesdeSoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDesdeSoc.KeyDown

        'Busco matriculados por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmSoc2 As New frmConsSociedad
            AddOwnedForm(frmSoc2)
            frmSoc2.ShowDialog()
            senial = 0
            txtHastaSoc.Focus()
            desdesoc = Val(txtDesdeSoc.Text)
        End If
        'Busco matriculados por número de matrícula
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            nrosociedad = txtDesdeSoc.Text
            desdesoc = Val(txtDesdeSoc.Text)
            txtHastaSoc.Focus()
        End If

    End Sub

    Private Sub txtHastaSoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHastaSoc.KeyDown

        'Busco matriculados por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmSoc3 As New frmConsSociedad
            AddOwnedForm(frmSoc3)
            frmSoc3.ShowDialog()
            senial = 0
            dtpVencimiento.Focus()
            hastasoc = Val(txtDesdeSoc.Text)
        End If
        'Busco matriculados por número de matrícula
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            nrosociedad = txtHastaSoc.Text
            hastasoc = Val(txtDesdeSoc.Text)
            dtpVencimiento.Focus()
        End If

    End Sub

    Private Sub txtHastaSoc_Leave(sender As Object, e As EventArgs) Handles txtHastaSoc.Leave

        If txtDesdeSoc.Text IsNot "" Then
            If desdesoc > hastasoc Then
                detmsg = "Valor erróneo...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
                txtHastaSoc.Focus()
            End If
        End If

    End Sub

    Private Sub LeerSociedad()

        comando.CommandText = "SELECT * FROM sociedades WHERE NroSociedad = " & nrosociedad.ToString & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            nrosociedad = CStr(row("NroSociedad"))
        Else
            nrosociedad = ""
        End If

    End Sub

    Private Sub dtpVencimiento_LostFocus(sender As Object, e As EventArgs) Handles dtpVencimiento.LostFocus

        fechajob = CDate(dtpVencimiento.Value)
        ProcesarFecha()
        dia = dd
        mes = mm
        anio = yyyy
        yy = Mid(anio, 3, 2)

        txtMMperiodo.Text = mes
        txtYYPeriodo.Text = anio

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        ControlarValores()
        If senial = 1 Then
            GoTo Finalizar
        End If

        LeerComprobante()
        contreg = 0

        comando.CommandText = "SELECT * FROM sociedades WHERE NroSociedad >= '" & txtDesdeSoc.Text & "' AND NroSociedad <= '" & txtHastaSoc.Text & "' AND  EstadoSociedad = 'ACTIVA' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)
        fila = dt.Rows.Count
        periodo = txtYYPeriodo.Text & txtMMperiodo.Text

        For Each row In dt.Rows
            estado = CStr(row("EstadoSociedad"))
            If estado IsNot "ACTIVO" Then
                GoTo seguir
            Else
                GoTo leerotro
            End If

seguir:
            txtMsg.Visible = True
            contreg = contreg + 1
            txtMsg.Text = "Procesando Registro " & Str(contreg)

            sociedad = CStr(row("NroSociedad"))
            nombre = CStr(row("NombSociedad"))
            domicilio = CStr(row("CalleSociedad"))
            codigopostal = CStr(row("CodPosSociedad"))
            correo = CStr(row("EmailSociedad"))

            concepto1 = ""
            concepto2 = ""
            concepto3 = ""
            concepto4 = ""
            importe1 = 0
            importe2 = 0
            importe3 = 0
            importe4 = 0
            cantidad = 0
            total = 0

            comando = New MySqlCommand("SELECT * FROM debitosoc INNER JOIN coddebito ON debitosoc.CodDebSoc = coddebito.NroCodDeb AND SocDebSoc = " & sociedad & " ", conexion)
            dr = comando.ExecuteReader

            If dr.HasRows Then
                fila = 1
                While dr.Read
                    sociedad = dr(0).ToString
                    If Mid(dr(10).ToString, 1, 2) = "DM" And cbxDM.Checked Then
                        If dr(9).ToString > 0 Then
                            If fila = 1 Then
                                concepto1 = dr(2).ToString
                                importe1 = dr(9).ToString * txtKilos.Text
                            End If
                            If fila = 2 Then
                                concepto2 = dr(2).ToString
                                importe2 = dr(9).ToString * txtKilos.Text
                            End If
                            If fila = 3 Then
                                concepto3 = dr(2).ToString
                                importe3 = dr(9).ToString * txtKilos.Text
                            End If
                            If fila = 4 Then
                                concepto4 = dr(2).ToString
                                importe4 = dr(9).ToString * txtKilos.Text
                            End If
                            fila = fila + 1
                            total = total + (dr(9).ToString * txtKilos.Text)
                        End If
                    End If
                    If Mid(dr(10).ToString, 1, 2) = "DU" And cbxDU.Checked Then
                        If dr(9).ToString > 0 Then
                            If fila = 1 Then
                                concepto1 = dr(2).ToString
                                importe1 = dr(9).ToString * txtKilos.Text
                            End If
                            If fila = 2 Then
                                concepto2 = dr(2).ToString
                                importe2 = dr(9).ToString * txtKilos.Text
                            End If
                            If fila = 3 Then
                                concepto3 = dr(2).ToString
                                importe3 = dr(9).ToString * txtKilos.Text
                            End If
                            If fila = 4 Then
                                concepto4 = dr(2).ToString
                                importe4 = dr(9).ToString * txtKilos.Text
                            End If
                            fila = fila + 1
                            total = total + (dr(9).ToString * txtKilos.Text)
                        End If
                    End If
                End While

                If total > 0 Then
                    CodigoTotal = ArmaCodigoBarra(sociedad, txtMMperiodo.Text, txtYYPeriodo.Text, total, dd, mm, yy)
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
        txtDesdeSoc.Text = 60000
        txtHastaSoc.Text = 90000
        txtDesdeSoc.Text = ""
        txtHastaSoc.Text = ""
        txtMMperiodo.Text = ""
        txtYYPeriodo.Text = ""
        cbxDM.Checked = False

        txtDesdeSoc.Focus()

Finalizar:

    End Sub

    Private Sub btnProcesar_MouseHover(sender As Object, e As EventArgs) Handles btnProcesar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Procesar."
        ToolTipMsg.SetToolTip(btnProcesar, "Presione para procesar las boletas requeridad en los parámetros.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub GrabarBoleta()

        comando.CommandText = "SELECT LocalCodPos, ProvCodPos FROM codpostal WHERE NroCodPos = '" & codigopostal & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            localidad = CStr(row("LocalCodPos"))
            provincia = CStr(row("ProvCodPos"))
        Else
            localidad = ""
        End If

        comprobante = comprobante + 1

        Try
            comando = New MySqlCommand("INSERT INTO boletas VALUES(@id, @matricula, @apelynombre, @domicilio, @codigopostal, @localidad, @provincia, @fecvto, @periodo ,@total," _
                                       & " @estado, @concepto1, @importe1, @concepto2, @importe2, @concepto3, @importe3, @concepto4, @importe4, @fecpago, @pagado, @saldo," _
                                       & " @formapago, @correo, @codigoboleta, @codigopago)", conexion)
            comando.Parameters.AddWithValue("@id", comprobante)
            comando.Parameters.AddWithValue("@matricula", sociedad)
            comando.Parameters.AddWithValue("@apelynombre", nombre)
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

            PonerCeros(sociedad, 5)
            sociedad = nroconceros

            fecha = dia & "/" & mes & "/" & anio
            codbarra = CodigoArmado

            parametros(0) = New ReportParameter("prmMatricula", sociedad)
            parametros(1) = New ReportParameter("prmApelyNombre", nombre)
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
            parametros(18) = New ReportParameter("prmTipoNro", "SOCIEDAD:")
            parametros(19) = New ReportParameter("prmTipoNom", "NOM:")
            parametros(20) = New ReportParameter("prmNroDePago", codigodepago)

            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsBoletas", BoletasBindingSource))
            ReportViewer1.LocalReport.SetParameters(parametros)

            nombrePDF = sociedad & "-" & periodo

            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim newFile As New FileStream("E:\DBColMart\boletas\" & nombrePDF & ".pdf", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()

            ReportViewer1.RefreshReport()

            'GRABAMOS LAS CTAS CTES
            Try
                comando = New MySqlCommand("INSERT INTO ctasctes VALUES(@id, @matricula, @fecvto, @tipo, @comprobante, @item, @detalle, @periodo, @debe ,@haber, @saldo, @estado, @pagado, @fecha, @resto, @obs)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@matricula", sociedad)
                comando.Parameters.AddWithValue("@fecvto", yyyy & "-" & mm & "-" & dd)
                comando.Parameters.AddWithValue("@tipo", "LIQ")
                comando.Parameters.AddWithValue("@comprobante", comprobante)
                comando.Parameters.AddWithValue("@item", 1)
                comando.Parameters.AddWithValue("@detalle", concepto1)
                comando.Parameters.AddWithValue("@periodo", periodo)
                comando.Parameters.AddWithValue("@debe", importe1)
                comando.Parameters.AddWithValue("@haber", 0)
                comando.Parameters.AddWithValue("@saldo", 0)
                comando.Parameters.AddWithValue("@estado", "PENDIENTE")
                comando.Parameters.AddWithValue("@pagado", 0)
                comando.Parameters.AddWithValue("@fecha", "1900-01-01")
                comando.Parameters.AddWithValue("@resto", importe1)
                comando.Parameters.AddWithValue("@obs", "")
                comando.ExecuteNonQuery()

                GrabarVentas()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            comando = New MySqlCommand("UPDATE comprobte SET NroCpbte = '" & comprobante & "' WHERE TipoCpbte = 'LIQ' ", conexion)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ControlarValores()

        senial = 0
        If desdesoc > hastasoc Then
            senial = 1
            txtDesdeSoc.Focus()
        End If
        If txtMMperiodo.Text = 0 Or txtMMperiodo.Text > 12 Then
            senial = 1
            txtMMperiodo.Focus()
        End If
        If txtYYPeriodo.Text = 0 Or txtYYPeriodo.Text < Year(dtpVencimiento.Value) Then
            senial = 1
            txtYYPeriodo.Focus()
        End If
        If cbxDM.Checked = False And cbxDU.Checked = False Then
            senial = 1
            cbxDM.Focus()
        End If
        If senial = 1 Then
            detmsg = "Controlar los valores ingresados...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub cbxDM_MouseHover(sender As Object, e As EventArgs) Handles cbxDM.MouseHover

        ToolTipMsg.ToolTipTitle = "Opción DM - Débito Mensual."
        ToolTipMsg.SetToolTip(cbxDM, "Marcar para liquidar a las sociedades un débito semestral.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub cbxDU_MouseHover(sender As Object, e As EventArgs) Handles cbxDU.MouseHover

        ToolTipMsg.ToolTipTitle = "Opción DU - Débito Único."
        ToolTipMsg.SetToolTip(cbxDM, "Marcar para liquidar a las sociedades un débito único.")
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
        comando.Parameters.AddWithValue("@item", 1)
        comando.Parameters.AddWithValue("@detalle", concepto1)
        comando.Parameters.AddWithValue("@periodo", periodo)
        comando.Parameters.AddWithValue("@neto", importe1)
        comando.Parameters.AddWithValue("@total", 0)
        comando.ExecuteNonQuery()

    End Sub

End Class