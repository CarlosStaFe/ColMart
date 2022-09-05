'*******************************************************************************
'* PANTALLA PARA LA IMPRESION DE CTASCTES                                      *
'*******************************************************************************
Imports Microsoft.Reporting.WinForms
Public Class frmImpCtaCte
    Private Sub frmImpCtaCte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametros As ReportParameter() = New ReportParameter(1) {}
        parametros(0) = New ReportParameter("prmDetalle", txtDetalle.Text)
        parametros(1) = New ReportParameter("prmUser", txtUser.Text)
        ReportViewer1.LocalReport.SetParameters(parametros)

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsImpCtaCte", ImpctacteBindingSource))
        ImpctacteTableAdapter.Fill(DbcolmartDataSet.impctacte)

        ReportViewer1.RefreshReport()

    End Sub

End Class