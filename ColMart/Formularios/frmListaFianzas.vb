'*******************************************************************************
'* LISTADO DE FIANZAS POR ESTADO                                               *
'*******************************************************************************
Imports Microsoft.Reporting.WinForms

Public Class frmListaFianzas
    Dim detalle As String
    Private Sub frmListaFianzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fianzasTableAdapter.Fill(dbcolmartDataSet.fianzas)

    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged

        btnFiltrar.Focus()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        detalle = "Listado de fianzas con estado "

        If cmbEstado.Text = "TODOS" Then
            comando.CommandText = "SELECT * FROM fianzas"
            detalle = "Listado de fianzas por estado TODOS"
        Else
            comando.CommandText = "SELECT * FROM fianzas WHERE EstadoFza = '" & cmbEstado.Text & "'"
            detalle = "Listado de fianzas por estado " + cmbEstado.Text
        End If

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        Dim parametros As ReportParameter() = New ReportParameter(1) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        parametros(1) = New ReportParameter("prmUser", user)

        Dim ds As New DataSet
        ds = Filtrar()
        Dim rds As New ReportDataSource("dsFianzas", ds.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Close()

    End Sub

    Private Function Filtrar()

        Dim datos As New DataTable
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            adapter = New MySqlDataAdapter(comando.CommandText, "server=DESKTOP; database=dbcolmart; user id=martillero1; password=soporte; Convert Zero Datetime=True")
            adapter.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return ds

    End Function

End Class