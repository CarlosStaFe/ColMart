Imports Microsoft.Reporting.WinForms

Public Class frmInforme
    Private Sub frmInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("prmDetalle", txtDetalle.Text)
        ReportViewer1.LocalReport.SetParameters(parametros)

        'TODO: esta línea de código carga datos en la tabla 'dbcolmartDataSet.debehaber' Puede moverla o quitarla según sea necesario.
        Me.debehaberTableAdapter.Fill(Me.dbcolmartDataSet.debehaber)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class