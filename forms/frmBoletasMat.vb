Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Configuration
Imports Microsoft.Reporting.WinForms
Imports System.ComponentModel

Public Class frmBoletasMat
    Dim longitud, largo As Integer
    Dim ceros As String
    Dim cantidad As String
    Dim nombrePDF As String
    Dim yyyy, yy, mm, dd, fecha As String
    Dim i As Integer
    Dim periodo, total, MMperiodo, YYYYperiodo As String
    Dim fechavto, codigodepago As String
    Dim posicion1, posicion2 As Integer
    Dim CodigoArmado, CodigoTotal As Object
    Dim parametros As ReportParameter() = New ReportParameter(20) {}

    Private Sub frmBoletasMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        dgvBoletas.Columns(6).DefaultCellStyle.Format = "d"

        'TODO: esta línea de código carga datos en la tabla 'dbcolmartDataSet.boletas' Puede moverla o quitarla según sea necesario.
        boletasTableAdapter.Fill(dbcolmartDataSet.boletas)
        dgvBoletas.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub txtMatricula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 4
            Dim frmMat As New frmConsMatri
            AddOwnedForm(frmMat)
            frmMat.ShowDialog()
            senial = 0
        End If

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerMatriculado()
        End If

    End Sub

    Private Sub LeerMatriculado()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = " & txtMatricula.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelyNomb.Text = CStr(row("ApelNombMatri"))
        Else
            txtApelyNomb.Text = ""
            detmsg = "Matricula no existente"
            tipomsg = "informacion"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        comando.CommandText = "SELECT * FROM boletas WHERE MatBoleta = " & txtMatricula.Text & " AND EstadoBoleta <> 'PAGADA' ORDER BY FecVtoBoleta"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvBoletas.Columns(6).DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvBoletas.DataSource = dt

    End Sub

    Private Sub dgvBoletas_DoubleClick(sender As Object, e As EventArgs) Handles dgvBoletas.DoubleClick

        ReportViewer1.LocalReport.DataSources.Clear()

        longitud = Len(dgvBoletas.CurrentRow.Cells(0).Value.ToString)
        If longitud < 5 Then
            cantidad = 5 - longitud
            ceros = ""
            For i = 1 To cantidad
                ceros = ceros & "0"
            Next i
            txtMatricula.Text = ceros & dgvBoletas.CurrentRow.Cells(0).Value.ToString
        End If

        fecha = CDate(dgvBoletas.CurrentRow.Cells(6).Value.ToString)
        periodo = dgvBoletas.CurrentRow.Cells(7).Value.ToString

        MoverDatos()

    End Sub

    Private Sub btnReliquidar_Click(sender As Object, e As EventArgs) Handles btnReliquidar.Click

        fechavto = CStr(dgvBoletas.CurrentRow.Cells(6).Value.ToString)
        periodo = CStr(dgvBoletas.CurrentRow.Cells(7).Value.ToString)
        total = CStr(dgvBoletas.CurrentRow.Cells(8).Value.ToString)
        MMperiodo = Mid(periodo, 5, 2)
        YYYYperiodo = Mid(periodo, 1, 4)

        posicion1 = InStr(1, fechavto, "/")
        posicion2 = InStr(posicion1 + 1, fechavto, "/")
        dd = Mid(fechavto, 1, posicion1 - 1)
        mm = Mid(fechavto, posicion1 + 1, ((posicion2 - 1) - posicion1))
        yy = Mid(fechavto, posicion2 + 3, 2)
        yyyy = Mid(fechavto, posicion2 + 1, 4)

        ceros = ""

        largo = Len(dd)
        If largo < 2 Then
            cantidad = 2 - largo
            For i = 1 To cantidad
                ceros = ceros & "0"
            Next i
            dd = ceros & dd
        End If

        ceros = ""

        largo = Len(mm)
        If largo < 2 Then
            cantidad = 2 - largo
            For i = 1 To cantidad
                ceros = ceros & "0"
            Next i
            mm = ceros & mm
        End If

        fechavto = yyyy & mm & dd
        fecha = dd & "/" & mm & "/" & yyyy

        CodigoTotal = ArmaCodigoBarra(txtMatricula.Text, MMperiodo, YYYYperiodo, total, dd, mm, yy)
        SepararCodigo()

        comando.CommandText = "UPDATE boletas SET FecVtoBoleta = '" & fechavto & "', CodigoBoleta = '" & CodigoArmado & "' WHERE MatBoleta = " & txtMatricula.Text & " AND PeriodoBoleta = " & periodo & ""
        comando.ExecuteNonQuery()

        ActualizaDGV()

        ceros = ""

        longitud = Len(txtMatricula.Text)
        If longitud < 5 Then
            cantidad = 5 - longitud
            ceros = ""
            For i = 1 To cantidad
                ceros = ceros & "0"
            Next i
            txtMatricula.Text = ceros & txtMatricula.Text
        End If

        nombrePDF = txtMatricula.Text & "-" & dgvBoletas.CurrentRow.Cells(7).Value.ToString

        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim newFile As New FileStream("E:\boletas\" & nombrePDF & ".pdf", FileMode.Create)
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub MoverDatos()

        parametros(0) = New ReportParameter("prmMatricula", txtMatricula.Text)
        parametros(1) = New ReportParameter("prmApelyNombre", dgvBoletas.CurrentRow.Cells(1).Value.ToString)
        parametros(2) = New ReportParameter("prmDomicilio", dgvBoletas.CurrentRow.Cells(2).Value.ToString)
        parametros(3) = New ReportParameter("prmCodigoPostal", dgvBoletas.CurrentRow.Cells(3).Value.ToString)
        parametros(4) = New ReportParameter("prmLocalidad", dgvBoletas.CurrentRow.Cells(4).Value.ToString)
        parametros(5) = New ReportParameter("prmProvincia", dgvBoletas.CurrentRow.Cells(5).Value.ToString)
        parametros(6) = New ReportParameter("prmPeriodo", dgvBoletas.CurrentRow.Cells(7).Value.ToString)
        parametros(7) = New ReportParameter("prmFechaVto", fecha)
        parametros(8) = New ReportParameter("prmCodigo", dgvBoletas.CurrentRow.Cells(21).Value.ToString)
        parametros(9) = New ReportParameter("prmConcepto1", dgvBoletas.CurrentRow.Cells(12).Value.ToString)
        parametros(10) = New ReportParameter("prmConcepto2", dgvBoletas.CurrentRow.Cells(14).Value.ToString)
        parametros(11) = New ReportParameter("prmConcepto3", dgvBoletas.CurrentRow.Cells(16).Value.ToString)
        parametros(12) = New ReportParameter("prmConcepto4", dgvBoletas.CurrentRow.Cells(18).Value.ToString)
        parametros(13) = New ReportParameter("prmImporte1", dgvBoletas.CurrentRow.Cells(13).Value.ToString)
        parametros(14) = New ReportParameter("prmImporte2", dgvBoletas.CurrentRow.Cells(15).Value.ToString)
        parametros(15) = New ReportParameter("prmImporte3", dgvBoletas.CurrentRow.Cells(17).Value.ToString)
        parametros(16) = New ReportParameter("prmImporte4", dgvBoletas.CurrentRow.Cells(19).Value.ToString)
        parametros(17) = New ReportParameter("prmTotal", dgvBoletas.CurrentRow.Cells(8).Value.ToString)
        parametros(18) = New ReportParameter("prmTipoNro", "MATRÍCULA:")
        parametros(19) = New ReportParameter("prmTipoNom", "MCP:")
        parametros(20) = New ReportParameter("prmNroDePago", dgvBoletas.CurrentRow.Cells(22).Value.ToString)

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", boletasBindingSource))
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub ActualizaDGV()

        comando.CommandText = "SELECT * FROM boletas WHERE MatBoleta = " & txtMatricula.Text & " ORDER BY FecVtoBoleta"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvBoletas.DataSource = dt

        If dgvBoletas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvBoletas.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(7).Value = periodo Then
                        MoverDatos()
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub btnListados_Click(sender As Object, e As EventArgs) Handles btnListados.Click

        frmListaBoletas.ShowDialog()

    End Sub

    Private Sub SepararCodigo()

        posicion1 = InStr(1, CodigoTotal, "*")
        CodigoArmado = Mid(CodigoTotal, 1, posicion1 - 1)
        codigodepago = Mid(CodigoTotal, posicion1 + 1)

    End Sub


    Private Sub frmBoletas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        DesconectarMySql()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        dr.Close()
        dr.Dispose()
        DesconectarMySql()
        Close()

    End Sub

End Class