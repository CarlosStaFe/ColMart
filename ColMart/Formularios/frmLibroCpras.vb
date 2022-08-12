Imports Microsoft.Reporting.WinForms

Public Class frmLibroCpras
    Dim senial As Integer
    Dim titulo As String
    Dim desde, hasta As String

    Private Sub frmLibroCpras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        titulo = ""
        ReportViewer1.LocalReport.DataSources.Clear()
        txtDesde.Focus()
        btnLimpiar.Visible = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub txtDesde_Leave(sender As Object, e As EventArgs) Handles txtDesde.Leave

        fechajob = txtDesde.Text
        If txtDesde.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtDesde.Text = ""
                txtDesde.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtDesde.Text = fechajob
                desde = fechadb
                txtDesde.Refresh()
            End If
        End If

    End Sub

    Private Sub txtHasta_Leave(sender As Object, e As EventArgs) Handles txtHasta.Leave

        fechajob = txtHasta.Text
        If txtHasta.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtHasta.Text = ""
                txtHasta.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtHasta.Text = fechajob
                hasta = fechadb
                txtHasta.Refresh()
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtDesde.Text = ""
        txtHasta.Text = ""
        titulo = ""
        ReportViewer1.LocalReport.DataSources.Clear()
        txtDesde.Focus()
        btnImprimir.Visible = True
        btnLimpiar.Visible = False
        rbtnLibro.Checked = False
        rbtnTodas.Checked = False

        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmTitulo", titulo)
        ReportViewer1.LocalReport.SetParameters(parametros)

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        btnLimpiar.Visible = True
        btnImprimir.Visible = False

        If desde > hasta Then

        End If

        If rbtnTodas.Checked Then

            comando.CommandText = "SELECT * FROM compras WHERE compras.FechaCpra >= '" & desde & "' AND compras.FechaCpra <= '" & hasta & "' ORDER BY compras.FechaCpra "
            titulo = "***** Libro de compras *****" & " desde el " & txtDesde.Text & " hasta el " & txtHasta.Text

        End If

        If rbtnLibro.Checked Then

            comando.CommandText = "SELECT * FROM compras WHERE compras.FechaCpra >= '" & desde & "' AND compras.FechaCpra <= '" & hasta & "' " _
                                   & " AND compras.TipoCbteCpra <> 'X' AND compras.TipoCbteCpra <> 'REM' ORDER BY compras.FechaCpra "
            titulo = "***** LIBRO I.V.A. COMPRAS *****" & " desde el " & txtDesde.Text & " hasta el " & txtHasta.Text

        End If

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsCompras", dt))
        Dim parametros As ReportParameter() = New ReportParameter(1) {}
        parametros(0) = New ReportParameter("prmTitulo", titulo)
        parametros(1) = New ReportParameter("prmUser", user)
        ReportViewer1.LocalReport.SetParameters(parametros)

        ReportViewer1.RefreshReport()

    End Sub


End Class