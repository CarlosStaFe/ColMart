'*******************************************************************************
'* LISTADO DE PADRÓN DE SOCIEDADES           O                                 *
'*******************************************************************************
Imports Microsoft.Reporting.WinForms

Public Class frmPadronSoc
    Dim senial As Integer
    Dim detalle As String

    Private Sub frmPadronSoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        detalle = "Listado de Matriculados - Estado : TODOS * Sexo: TODOS * Categoría: TODOS * Ordenado por MATRÍCULA *"
        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.RefreshReport()
        cmbEstado.SelectedIndex = 0
        cmbClase.SelectedIndex = 0
        cmbOrden.SelectedIndex = 0

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        senial = 0
        detalle = "Listado de Sociedades - "

        comando.CommandText = "SELECT * FROM sociedades "
        If cmbEstado.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Estado: TODOS * "
        Else
            comando.CommandText = comando.CommandText & " WHERE EstadoSociedad = '" & cmbEstado.Text & "' "
            detalle = detalle & "Estado: " & cmbEstado.Text & " * "
            senial = 1
        End If
        If cmbClase.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Categoría: TODOS * "
        Else
            If senial = 0 Then
                comando.CommandText = comando.CommandText & "WHERE ClaseSoc = '" & cmbClase.Text & "' "
                detalle = detalle & "Clase: " & cmbClase.Text & " * "
            Else
                comando.CommandText = comando.CommandText & "AND ClaseSoc = '" & cmbClase.Text & "' "
                detalle = detalle & "Clase: " & cmbClase.Text & " * "
            End If
        End If
        If cmbOrden.Text = "NOMBRE" Then
            comando.CommandText = comando.CommandText & "ORDER BY NombSociedad "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        Else
            comando.CommandText = comando.CommandText & "ORDER BY NroSociedad "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        End If

        Dim ds As New DataSet
        ds = Filtrar()
        Dim rds As New ReportDataSource("dsSociedades", ds.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim parametros As ReportParameter() = New ReportParameter(1) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        parametros(1) = New ReportParameter("prmUser", user)
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()

    End Sub

    Private Function Filtrar()

        Dim datos As New DataTable
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            adapter = New MySqlDataAdapter(comando.CommandText, "server=desktop; database=dbcolmart; user id=martillero1; password=soporte")
            adapter.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return ds

    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Close()

    End Sub

End Class