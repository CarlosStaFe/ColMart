Imports Microsoft.Reporting.WinForms

Public Class frmPrintRecGral
    Public fecha, comprobante, letras, tipo, matsoc, nombre, cuit, obs, saldo, pagado, efectivo, transferencia, tarjeta As String

    Private Sub frmPrintRecGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbcolmartDataSet.renglones' Puede moverla o quitarla según sea necesario.
        'Me.renglonesTableAdapter.Fill(Me.dbcolmartDataSet.renglones)
        'Me.ReportViewer1.RefreshReport()

        Dim parametros As ReportParameter() = New ReportParameter(12) {}
        parametros(0) = New ReportParameter("prmFecha", fecha)
        parametros(1) = New ReportParameter("prmComprobante", comprobante)
        parametros(2) = New ReportParameter("prmLetras", letras)
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
        ReportViewer1.LocalReport.SetParameters(parametros)
        renglonesTableAdapter.Fill(dbcolmartDataSet.renglones)

        ReportViewer1.RefreshReport()

    End Sub

End Class