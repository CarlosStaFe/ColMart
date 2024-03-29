﻿Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmListaPadron

    Dim senial As Integer
    Dim detalle As String
    Private da As New MySqlDataAdapter

    Private Sub frmListaPadron_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        detalle = "Listado de Matriculados - Estado : TODOS * Sexo: TODOS * Categoría: TODOS * Ordenado por MATRÍCULA *"
        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.RefreshReport()
        cmbEstado.SelectedIndex = 0
        cmbSexo.SelectedIndex = 0
        cmbCategoria.SelectedIndex = 0
        cmbOrden.SelectedIndex = 0

    End Sub


    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        senial = 0
        detalle = "Listado de Matriculados - "

        comando.CommandText = "SELECT * FROM matriculados "
        If cmbEstado.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Estado: TODOS * "
        Else
            comando.CommandText = comando.CommandText & " WHERE EstadoMatri = '" & cmbEstado.Text & "' "
            detalle = detalle & "Estado: " & cmbEstado.Text & " * "
            senial = 1
        End If
        If cmbSexo.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Sexo: TODOS * "
        Else
            If senial = 0 Then
                comando.CommandText = comando.CommandText & "WHERE SexoMatri = '" & cmbSexo.Text & "' "
                detalle = detalle & "Sexo: " & cmbSexo.Text & " * "
                senial = 1
            Else
                comando.CommandText = comando.CommandText & "AND SexoMatri = '" & cmbSexo.Text & "' "
                detalle = detalle & "Sexo: " & cmbSexo.Text & " * "
            End If
        End If
        If cmbCategoria.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Categoría: TODOS * "
        Else
            If senial = 0 Then
                comando.CommandText = comando.CommandText & "WHERE CatAporteMatri = '" & cmbCategoria.Text & "' "
                detalle = detalle & "Categoría: " & cmbCategoria.Text & " * "
            Else
                comando.CommandText = comando.CommandText & "AND CatAporteMatri = '" & cmbCategoria.Text & "' "
                detalle = detalle & "Categoría: " & cmbCategoria.Text & " * "
            End If
        End If
        If cmbOrden.Text = "APELLIDO" Then
            comando.CommandText = comando.CommandText & "ORDER BY ApelNombMatri "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        Else
            comando.CommandText = comando.CommandText & "ORDER BY NroMatri "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        End If

        Dim ds As New DataSet
        ds = Filtrar()
        Dim rds As New ReportDataSource("dsPadronMatri", ds.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()

    End Sub

    Private Function Filtrar()

        Dim datos As New DataTable
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            adapter = New MySqlDataAdapter(comando.CommandText, "server=desktop; database=dbcolmart; user id=martillero; password=soporte")
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