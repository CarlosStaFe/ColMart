Imports Microsoft.Reporting.WinForms

Public Class frmPadronMatri
    Public detalle As String
    Public useraux As String

    Private Sub frmPadronMatri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametros As ReportParameter() = New ReportParameter(1) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)
        parametros(1) = New ReportParameter("prmUser", useraux)

        ReportViewer1.LocalReport.SetParameters(parametros)

        PadronTableAdapter.Fill(DbcolmartDataSet.padron)

        ReportViewer1.RefreshReport()

    End Sub

End Class