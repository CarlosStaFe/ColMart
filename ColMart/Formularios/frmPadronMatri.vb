Imports Microsoft.Reporting.WinForms

Public Class frmPadronMatri
    Public detalle As String

    Private Sub frmPadronMatri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", detalle)

        ReportViewer1.LocalReport.SetParameters(parametros)

        PadronTableAdapter.Fill(DbcolmartDataSet.padron)

        ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport
    End Sub

End Class