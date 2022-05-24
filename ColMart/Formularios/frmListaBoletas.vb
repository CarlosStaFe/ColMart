Imports Microsoft.Reporting.WinForms

Public Class frmListaBoletas
    Dim senial As Integer
    Dim detalle As String

    Private Sub frmListaBoletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        detalle = "Listado de Boletas - Estado : TODOS * Mail: TODOS * Períodos: TODOS * Ordenado por MATRÍCULA *"
        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        ReportViewer1.LocalReport.SetParameters(parametros)
        boletasTableAdapter.Fill(dsListaBoletas.boletas)
        ReportViewer1.RefreshReport()
        CargarCombo()
        cmbEstado.SelectedIndex = 0
        cmbMail.SelectedIndex = 0
        cmbPeriodo.SelectedIndex = 0
        cmbOrden.SelectedIndex = 0

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        senial = 0
        detalle = "Listado de Boletas - "

        comando.CommandText = "SELECT * FROM boletas "
        If cmbEstado.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Estado: TODOS * "
        Else
            comando.CommandText = comando.CommandText & " WHERE EstadoBoleta = '" & cmbEstado.Text & "' "
            detalle = detalle & "Estado: " & cmbEstado.Text & " * "
            senial = 1
        End If
        If cmbMail.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Mail: TODOS * "
        Else
            If cmbMail.Text = "CON MAIL" Then
                If senial = 0 Then
                    comando.CommandText = comando.CommandText & "WHERE MailBoleta LIKE '%@%'"
                    detalle = detalle & "Mail: " & cmbMail.Text & " * "
                    senial = 1
                Else
                    comando.CommandText = comando.CommandText & "AND MailBoleta LIKE '%@%'"
                    detalle = detalle & "Mail: " & cmbMail.Text & " * "
                End If
            Else
                If senial = 0 Then
                    comando.CommandText = comando.CommandText & "WHERE MailBoleta NOT LIKE '%@%'"
                    detalle = detalle & "Mail: " & cmbMail.Text & " * "
                    senial = 1
                Else
                    comando.CommandText = comando.CommandText & "AND MailBoleta NOT LIKE '%@%'"
                    detalle = detalle & "Mail: " & cmbMail.Text & " * "
                End If
            End If
        End If
        If cmbPeriodo.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Período: TODOS * "
        Else
            If senial = 0 Then
                comando.CommandText = comando.CommandText & "WHERE PeriodoBoleta = '" & cmbPeriodo.Text & "' "
                detalle = detalle & "Período: " & cmbPeriodo.Text & " * "
            Else
                comando.CommandText = comando.CommandText & "AND PeriodoBoleta = '" & cmbPeriodo.Text & "' "
                detalle = detalle & "Período: " & cmbPeriodo.Text & " * "
            End If
        End If
        If cmbOrden.Text = "APELLIDO" Then
            comando.CommandText = comando.CommandText & "ORDER BY ApelNomBoleta "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        Else
            comando.CommandText = comando.CommandText & "ORDER BY MatBoleta "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        End If


        Dim ds As New DataSet
        ds = Filtrar()
        Dim rds As New ReportDataSource("dsListaBoletas", ds.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()

    End Sub
    Private Sub btnFiltrar_MouseHover(sender As Object, e As EventArgs) Handles btnFiltrar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Filtrar."
        ToolTipMsg.SetToolTip(btnFiltrar, "Presione para realizar el informe seleccionado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Function Filtrar()

        Dim datos As New DataTable
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            adapter = New MySqlDataAdapter(comando.CommandText, "server=localhost; database=dbcolmart; user id=root; password=camb9145")
            adapter.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return ds

    End Function

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT DISTINCT PeriodoBoleta FROM Boletas ORDER BY PeriodoBoleta DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            cmbPeriodo.Items.Add("TODOS")
            While dr.Read
                cmbPeriodo.Items.Add(dr(0).ToString)
            End While
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class