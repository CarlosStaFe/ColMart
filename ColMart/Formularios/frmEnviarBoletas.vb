'*******************************************************************************
'* PROCESO DE IMPRIMIR BOLETAS QUE NO SENVIARON POR MAIL                       *
'*******************************************************************************
Imports Microsoft.Reporting.WinForms
Public Class frmEnviarBoletas
    Dim fila, senial As Integer
    Dim matricula, periodo As String
    Dim tabla(500, 19)

    Private Sub frmEnviarBoletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ConectarMySql()
        ReportViewer1.RefreshReport()
        CargarCombos()
        cmbDesdePer.SelectedIndex = 2
        cmbHastaPer.SelectedIndex = 0
        cmbDesdePer.Focus()

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub CargarCombos()

        dr.Close()
        dr.Dispose()
        comando = New MySqlCommand("SELECT DISTINCT PeriodoBoleta FROM Boletas ORDER BY PeriodoBoleta DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbDesdePer.Items.Add(dr(0).ToString)
                cmbHastaPer.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub txtHastaMat_LostFocus(sender As Object, e As EventArgs) Handles txtHastaMat.LostFocus

        PonerCeros(txtDesdeMat.Text, 5)
        txtDesdeMat.Text = nroconceros
        txtDesdeMat.Show()

        PonerCeros(txtHastaMat.Text, 5)
        txtHastaMat.Text = nroconceros
        txtHastaMat.Show()

        If txtDesdeMat.Text > txtHastaMat.Text Then
            txtDesdeMat.Focus()
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        comando.CommandText = "SELECT * FROM Boletas WHERE MatBoleta >= '" & txtDesdeMat.Text & "' AND MatBoleta <= '" & txtHastaMat.Text & "'" _
                            & " AND PeriodoBoleta >= '" & cmbDesdePer.Text & "' AND PeriodoBoleta <= '" & cmbHastaPer.Text & "'" _
                            & " AND EstadoBoleta = 'LIQUIDADA' " _
                            & " ORDER BY MatBoleta"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)
        fila = 0
        senial = 0

        For Each row In dt.Rows
            If CStr(row("EstadoBoleta")) = "LIQUIDADA" Then
                senial = 1
            Else
                detmsg = "ATENCIÓN...!!! Boleta YA IMPRESA, desea imprimirla...?"
                tipomsg = "question"
                btnmsg = 2
                frmMsgBox.ShowDialog()
                If frmMsgBox.Tag = "SI" Then
                    senial = 1
                End If
            End If
            If senial = 1 Then
                matricula = CStr(row("MatBoleta"))
                periodo = CStr(row("PeriodoBoleta"))

                tabla(fila, 0) = CStr(row("MatBoleta"))
                tabla(fila, 1) = CStr(row("ApelNomBoleta"))
                tabla(fila, 2) = CStr(row("CalleBoleta"))
                tabla(fila, 3) = CStr(row("CodPosBoleta"))
                tabla(fila, 4) = CStr(row("LocalBoleta"))
                tabla(fila, 5) = CStr(row("ProvBoleta"))
                tabla(fila, 6) = CStr(row("PeriodoBoleta"))
                tabla(fila, 7) = CStr(row("FecVtoBoleta"))
                tabla(fila, 8) = CStr(row("CodigoBoleta"))
                tabla(fila, 9) = CStr(row("Concepto1Boleta"))
                tabla(fila, 10) = CStr(row("Concepto2Boleta"))
                tabla(fila, 11) = CStr(row("Concepto3Boleta"))
                tabla(fila, 12) = CStr(row("Concepto4Boleta"))
                tabla(fila, 13) = CStr(row("ImpCon1Boleta"))
                tabla(fila, 14) = CStr(row("ImpCon2Boleta"))
                tabla(fila, 15) = CStr(row("ImpCon3Boleta"))
                tabla(fila, 16) = CStr(row("ImpCon4Boleta"))
                tabla(fila, 17) = CStr(row("ImporteBoleta"))
                tabla(fila, 18) = CStr(row("EstadoBoleta"))
                tabla(fila, 19) = CStr(row("NroPagoBoleta"))
                comando = New MySqlCommand("UPDATE boletas SET EstadoBoleta = 'PENDIENTE' WHERE MatBoleta = " & matricula & " AND PeriodoBoleta = '" & periodo & "'", conexion)
                comando.ExecuteNonQuery()

                If matricula < 70000 Then
                    comando = New MySqlCommand("UPDATE ctasctes SET EstadoCC = 'PENDIENTE' WHERE NroCC = " & matricula & " AND PeriodoCC = '" & periodo & "'", conexion)
                    comando.ExecuteNonQuery()
                    fila = fila + 1
                    senial = 0
                End If
            End If
        Next

        Imprimir()

    End Sub

    Private Sub btnImprimir_MouseHover(sender As Object, e As EventArgs) Handles btnImprimir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Imprimir."
        ToolTipMsg.SetToolTip(btnImprimir, "Presione para imprimir las boletas deseadas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Imprimir()

        ReportViewer1.RefreshReport()

        fila = fila - 1

        For i = 0 To fila

            Dim parametros As ReportParameter() = New ReportParameter(62) {}
            parametros(0) = New ReportParameter("prmMatricula1", CStr(tabla(i, 0)))
            parametros(1) = New ReportParameter("prmApelyNombre1", CStr(tabla(i, 1)))
            parametros(2) = New ReportParameter("prmDomicilio1", CStr(tabla(i, 2)))
            parametros(3) = New ReportParameter("prmCodigoPostal1", CStr(tabla(i, 3)))
            parametros(4) = New ReportParameter("prmLocalidad1", CStr(tabla(i, 4)))
            parametros(5) = New ReportParameter("prmProvincia1", CStr(tabla(i, 5)))
            parametros(6) = New ReportParameter("prmPeriodo1", CStr(tabla(i, 6)))
            parametros(7) = New ReportParameter("prmFechaVto1", CStr(tabla(i, 7)))
            parametros(8) = New ReportParameter("prmCodigo1", CStr(tabla(i, 8)))
            parametros(9) = New ReportParameter("prmConcepto11", CStr(tabla(i, 9)))
            parametros(10) = New ReportParameter("prmConcepto12", CStr(tabla(i, 10)))
            parametros(11) = New ReportParameter("prmConcepto13", CStr(tabla(i, 11)))
            parametros(12) = New ReportParameter("prmConcepto14", CStr(tabla(i, 12)))
            parametros(13) = New ReportParameter("prmImporte11", CStr(tabla(i, 13)))
            parametros(14) = New ReportParameter("prmImporte12", CStr(tabla(i, 14)))
            parametros(15) = New ReportParameter("prmImporte13", CStr(tabla(i, 15)))
            parametros(16) = New ReportParameter("prmImporte14", CStr(tabla(i, 16)))
            parametros(17) = New ReportParameter("prmTotal1", CStr(tabla(i, 17)))
            If CStr(tabla(i, 0)) > 60000 And CStr(tabla(i, 0)) < 69999 Then
                parametros(18) = New ReportParameter("prmTipoNro1", "SOCIEDAD:")
                parametros(19) = New ReportParameter("prmTipoNom1", "SOC:")
            Else
                parametros(18) = New ReportParameter("prmTipoNro1", "MATRÍCULA:")
                parametros(19) = New ReportParameter("prmTipoNom1", "MCP:")
            End If
            parametros(60) = New ReportParameter("prmCodigoDePago1", CStr(tabla(i, 19)))

            i = i + 1

            parametros(20) = New ReportParameter("prmMatricula2", CStr(tabla(i, 0)))
            parametros(21) = New ReportParameter("prmApelyNombre2", CStr(tabla(i, 1)))
            parametros(22) = New ReportParameter("prmDomicilio2", CStr(tabla(i, 2)))
            parametros(23) = New ReportParameter("prmCodigoPostal2", CStr(tabla(i, 3)))
            parametros(24) = New ReportParameter("prmLocalidad2", CStr(tabla(i, 4)))
            parametros(25) = New ReportParameter("prmProvincia2", CStr(tabla(i, 5)))
            parametros(26) = New ReportParameter("prmPeriodo2", CStr(tabla(i, 6)))
            parametros(27) = New ReportParameter("prmFechaVto2", CStr(tabla(i, 7)))
            parametros(28) = New ReportParameter("prmCodigo2", CStr(tabla(i, 8)))
            parametros(29) = New ReportParameter("prmConcepto21", CStr(tabla(i, 9)))
            parametros(30) = New ReportParameter("prmConcepto22", CStr(tabla(i, 10)))
            parametros(31) = New ReportParameter("prmConcepto23", CStr(tabla(i, 11)))
            parametros(32) = New ReportParameter("prmConcepto24", CStr(tabla(i, 12)))
            parametros(33) = New ReportParameter("prmImporte21", CStr(tabla(i, 13)))
            parametros(34) = New ReportParameter("prmImporte22", CStr(tabla(i, 14)))
            parametros(35) = New ReportParameter("prmImporte23", CStr(tabla(i, 15)))
            parametros(36) = New ReportParameter("prmImporte24", CStr(tabla(i, 16)))
            parametros(37) = New ReportParameter("prmTotal2", CStr(tabla(i, 17)))
            If CStr(tabla(i, 0)) > 60000 And CStr(tabla(i, 0)) < 69999 Then
                parametros(18) = New ReportParameter("prmTipoNro1", "SOCIEDAD:")
                parametros(19) = New ReportParameter("prmTipoNom1", "SOC:")
            Else
                parametros(18) = New ReportParameter("prmTipoNro1", "MATRÍCULA:")
                parametros(19) = New ReportParameter("prmTipoNom1", "MCP:")
            End If
            parametros(61) = New ReportParameter("prmCodigoDePago2", CStr(tabla(i, 19)))

            i = i + 1

            parametros(40) = New ReportParameter("prmMatricula3", CStr(tabla(i, 0)))
            parametros(41) = New ReportParameter("prmApelyNombre3", CStr(tabla(i, 1)))
            parametros(42) = New ReportParameter("prmDomicilio3", CStr(tabla(i, 2)))
            parametros(43) = New ReportParameter("prmCodigoPostal3", CStr(tabla(i, 3)))
            parametros(44) = New ReportParameter("prmLocalidad3", CStr(tabla(i, 4)))
            parametros(45) = New ReportParameter("prmProvincia3", CStr(tabla(i, 5)))
            parametros(46) = New ReportParameter("prmPeriodo3", CStr(tabla(i, 6)))
            parametros(47) = New ReportParameter("prmFechaVto3", CStr(tabla(i, 7)))
            parametros(48) = New ReportParameter("prmCodigo3", CStr(tabla(i, 8)))
            parametros(49) = New ReportParameter("prmConcepto31", CStr(tabla(i, 9)))
            parametros(50) = New ReportParameter("prmConcepto32", CStr(tabla(i, 10)))
            parametros(51) = New ReportParameter("prmConcepto33", CStr(tabla(i, 11)))
            parametros(52) = New ReportParameter("prmConcepto34", CStr(tabla(i, 12)))
            parametros(53) = New ReportParameter("prmImporte31", CStr(tabla(i, 13)))
            parametros(54) = New ReportParameter("prmImporte32", CStr(tabla(i, 14)))
            parametros(55) = New ReportParameter("prmImporte33", CStr(tabla(i, 15)))
            parametros(56) = New ReportParameter("prmImporte34", CStr(tabla(i, 16)))
            parametros(57) = New ReportParameter("prmTotal3", CStr(tabla(i, 17)))
            If CStr(tabla(i, 0)) > 60000 And CStr(tabla(i, 0)) < 69999 Then
                parametros(18) = New ReportParameter("prmTipoNro1", "SOCIEDAD:")
                parametros(19) = New ReportParameter("prmTipoNom1", "SOC:")
            Else
                parametros(18) = New ReportParameter("prmTipoNro1", "MATRÍCULA:")
                parametros(19) = New ReportParameter("prmTipoNom1", "MCP:")
            End If
            parametros(62) = New ReportParameter("prmCodigoDePago3", CStr(tabla(i, 19)))

            ReportViewer1.LocalReport.SetParameters(parametros)
            ReportViewer1.RefreshReport()

            'Clase del Proyecto
            Dim printer As ReportPrinter = New ReportPrinter()
            printer.Print(ReportViewer1.LocalReport)

        Next

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class