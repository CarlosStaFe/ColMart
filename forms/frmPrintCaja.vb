Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Configuration
Imports Microsoft.Reporting.WinForms

Public Class frmPrintCaja
    Private Sub frmPrintCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'dbcolmartDataSet.caja' Puede moverla o quitarla según sea necesario.
        Me.cajaTableAdapter.Fill(Me.dbcolmartDataSet.caja)

        Dim nombrePDF As String
        nombrePDF = "Caja" & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ""
        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim newFile As New FileStream("E:\dbcolmart\cajas\" & nombrePDF & ".pdf", FileMode.Create)
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class