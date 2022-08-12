Imports Microsoft.Reporting.WinForms

Public Class frmInforme
    Private Sub frmInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametros As ReportParameter() = New ReportParameter(1) {}
        parametros(0) = New ReportParameter("prmDetalle", txtDetalle.Text)
        parametros(1) = New ReportParameter("prmUser", txtUser.Text)
        ReportViewer1.LocalReport.SetParameters(parametros)

        debehaberTableAdapter.Fill(dbcolmartDataSet.debehaber)

        ReportViewer1.RefreshReport()

    End Sub
End Class