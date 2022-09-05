'*******************************************************************************
'* PANTALLA PARA IMPRIMIR EL LIBRO VENTAS                                      *
'*******************************************************************************
Imports Microsoft.Reporting.WinForms
Public Class frmLibroVentas
    Dim detalle As String

    Private Sub frmLibroVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CargarCombos()
        cmbDesdePer.SelectedIndex = 0
        cmbHastaPer.SelectedIndex = 0
        cmbDesdePer.Focus()

    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs)

        btnFiltrar.Focus()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        ReportViewer1.Visible = False
        ReportViewer2.Visible = False

        If cmbDesdePer.Text > cmbHastaPer.Text Then
            detmsg = "ERROR EN LA SELECCIÓN DE PERÍODOS...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            cmbDesdePer.Focus()
        Else

            comando.CommandText = "SELECT * FROM ventas WHERE PeriodoVta >= '" & cmbDesdePer.Text & "' AND PeriodoVta <= '" & cmbHastaPer.Text & "' ORDER BY CpbteVta "

            Dim ds As New DataSet
            ds = Filtrar()
            Dim rds As New ReportDataSource("dsVentas", ds.Tables(0))

            If rdbDetallado.Checked Then
                detalle = "Listado de ventas DETALLADO desde el período " + cmbDesdePer.Text + " hasta el período " + cmbHastaPer.Text
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(rds)
            End If

            If rdbResumido.Checked Then
                detalle = "Listado de ventas RESUMIDO desde el período " + cmbDesdePer.Text + " hasta el período " + cmbHastaPer.Text
                ReportViewer2.LocalReport.DataSources.Clear()
                ReportViewer2.LocalReport.DataSources.Add(rds)
            End If

            Dim parametros As ReportParameter() = New ReportParameter(1) {}
            parametros(0) = New ReportParameter("prmDetalle", detalle)
            parametros(1) = New ReportParameter("prmUser", user)

            If rdbDetallado.Checked Then
                ReportViewer1.Visible = True
                ReportViewer1.LocalReport.SetParameters(parametros)
                ReportViewer1.RefreshReport()
            Else
                ReportViewer2.Visible = True
                ReportViewer2.LocalReport.SetParameters(parametros)
                ReportViewer2.RefreshReport()
            End If

        End If

    End Sub

    Private Function Filtrar()

        Dim datos As New DataTable
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            adapter = New MySqlDataAdapter(comando.CommandText, "server=DESKTOP; database=dbcolmart; user id=martillero1; password=soporte; Convert Zero Datetime=True")
            adapter.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return ds

    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub CargarCombos()

        dr.Close()
        dr.Dispose()
        comando = New MySqlCommand("SELECT DISTINCT PeriodoVta FROM ventas ORDER BY PeriodoVta DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbDesdePer.Items.Add(dr(0).ToString)
                cmbHastaPer.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

End Class