Imports Microsoft.Reporting.WinForms

Public Class frmDetallado
    Private Sub frmDetallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", txtDetalle.Text)
        ReportViewer1.LocalReport.SetParameters(parametros)
        debehaberTableAdapter.Fill(dsDebeHaber.debehaber)
        ReportViewer1.RefreshReport()

    End Sub
End Class