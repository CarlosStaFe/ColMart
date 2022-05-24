Imports Microsoft.Reporting.WinForms

Public Class frmReciboGeneral
    Public fecha, comprobante, letras, tipo, matsoc, nombre, cuit, obs, saldo, pagado, efectivo, transferencia, tarjeta As String

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

        'TODO: esta línea de código carga datos en la tabla 'dbcolmartDataSet.renglones' Puede moverla o quitarla según sea necesario.
        renglonesTableAdapter.Fill(dbcolmartDataSet.renglones)

        ReportViewer1.LocalReport.SetParameters(parametros)

        'ReportViewer1.RefreshReport()
        Dim printer As ReportPrinter = New ReportPrinter()
        printer.Print(ReportViewer1.LocalReport)

        ReportViewer1.RefreshReport()

    End Sub
End Class