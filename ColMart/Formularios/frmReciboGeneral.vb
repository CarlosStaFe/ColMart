Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class frmReciboGeneral
    Public fecha, comprobante, letras, tipo, matsoc, nombre, cuit, obs, saldo, pagado, efectivo, transferencia, tarjeta As String
    Dim archivo As String

    Private Sub frmReciboGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametros As ReportParameter() = New ReportParameter(12) {}
        parametros(0) = New ReportParameter("prmFecha", fecha)
        parametros(1) = New ReportParameter("prmComprobante", comprobante)
        parametros(2) = New ReportParameter("prmLetras", Letras)
        parametros(3) = New ReportParameter("prmTipo", tipo)
        parametros(4) = New ReportParameter("prmMatSoc", matsoc)
        parametros(5) = New ReportParameter("prmNombre", nombre)
        parametros(6) = New ReportParameter("prmCuit", cuit)
        parametros(7) = New ReportParameter("prmSaldo", saldo)
        parametros(8) = New ReportParameter("prmObs", obs)
        parametros(9) = New ReportParameter("prmPagado", pagado)
        parametros(10) = New ReportParameter("prmEfectivo", efectivo)
        parametros(11) = New ReportParameter("prmTransferencia", transferencia)
        parametros(12) = New ReportParameter("prmTarjeta", tarjeta)

        renglonesTableAdapter.Fill(dbcolmartDataSet.renglones)

        ReportViewer1.LocalReport.SetParameters(parametros)

        ReciboAPDF()

        Dim printer As ReportPrinter = New ReportPrinter()
        printer.Print(ReportViewer1.LocalReport)

        Close()

        'ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReciboAPDF()

        Dim nombrePDF As String
        nombrePDF = "CIP" & "-" & comprobante & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ""
        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim newFile As New FileStream("E:\dbcolmart\CIP\" & nombrePDF & ".pdf", FileMode.Create)
        archivo = nombrePDF & ".pdf"
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()

    End Sub

End Class