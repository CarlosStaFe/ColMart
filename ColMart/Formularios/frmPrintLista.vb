'*******************************************************************************
'* LISTADO DE LISTAS DE NOMBRAMIENTO DE OFICIO                                 *
'*******************************************************************************
Imports Microsoft.Reporting.WinForms

Public Class frmPrintLista
    Dim senial As Integer
    Private da As New MySqlDataAdapter

    Private Sub frmPrintLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ConectarMySql()

        Dim parametros As ReportParameter() = New ReportParameter(3) {}
        parametros(0) = New ReportParameter("prmAaaa", "")
        parametros(1) = New ReportParameter("prmJuzgado", "")
        parametros(2) = New ReportParameter("prmTribunal", "")
        parametros(3) = New ReportParameter("prmUser", "")

        'ReportViewer1.LocalReport.SetParameters(parametros)

        CargarAaaa()
        CargarCombo()

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub CargarAaaa()

        comando = New MySqlCommand("SELECT DISTINCT YyyyLis FROM listaoficio ORDER BY YyyyLis Desc", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbAaaa.Items.Add(dr(0).ToString)
            End While
        End If

        cmbAaaa.SelectedIndex = 0

        dr.Close()
        dr.Dispose()

    End Sub


    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT SedeTribu FROM Tribunales ORDER BY SedeTribu ASC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbTribunal.Items.Add(dr(0).ToString)
            End While
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub cmbTribunal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTribunal.SelectedIndexChanged

        Try
            comando.CommandText = "SELECT * FROM tribunales WHERE SedeTribu = '" & cmbTribunal.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                If IsDBNull(row("DistritoTribu")) = True Then
                    rdbDistrito.Visible = False
                Else
                    rdbDistrito.Visible = True
                End If
                If IsDBNull(row("CircuitoTribu")) = True Then
                    rdbCircuito.Visible = False
                Else
                    rdbCircuito.Visible = True
                End If
                If IsDBNull(row("TasacionesTribu")) = True Then
                    rdbTasaciones.Visible = False
                Else
                    rdbTasaciones.Visible = True
                End If
                If IsDBNull(row("ConcursalesTribu")) = True Then
                    rdbConcursales.Visible = False
                Else
                    rdbConcursales.Visible = True
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Error en el archivo...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        ControlarRDB()

        If senial = 1 Then
            Dim parametros As ReportParameter() = New ReportParameter(3) {}

            If rdbDistrito.Checked = True Then
                parametros(0) = New ReportParameter("prmAaaa", cmbAaaa.Text)
                parametros(1) = New ReportParameter("prmJuzgado", cmbTribunal.Text)
                parametros(2) = New ReportParameter("prmTribunal", "Art. 67 - Inc. B Distrito")
                parametros(3) = New ReportParameter("prmUser", user)

                comando.CommandText = "SELECT * FROM listaoficio WHERE YyyyLis = '" & cmbAaaa.Text & "' AND TribunalLis = '" & cmbTribunal.Text & "' AND DistritoLis = 1 ORDER BY ApelNombLis ASC"

            End If
            If rdbCircuito.Checked = True Then
                parametros(0) = New ReportParameter("prmAaaa", cmbAaaa.Text)
                parametros(1) = New ReportParameter("prmJuzgado", cmbTribunal.Text)
                parametros(2) = New ReportParameter("prmTribunal", "Art. 67 - Inc. CH Circuito")
                parametros(3) = New ReportParameter("prmUser", user)

                comando.CommandText = "SELECT * FROM listaoficio WHERE YyyyLis = '" & cmbAaaa.Text & "' AND TribunalLis = '" & cmbTribunal.Text & "' AND CircuitoLis = 1 ORDER BY ApelNombLis ASC"

            End If
            If rdbTasaciones.Checked = True Then
                parametros(0) = New ReportParameter("prmAaaa", cmbAaaa.Text)
                parametros(1) = New ReportParameter("prmJuzgado", cmbTribunal.Text)
                parametros(2) = New ReportParameter("prmTribunal", "Art. 67 - Inc. D Tasaciones")
                parametros(3) = New ReportParameter("prmUser", user)

                comando.CommandText = "SELECT * FROM listaoficio WHERE YyyyLis = '" & cmbAaaa.Text & "' AND TribunalLis = '" & cmbTribunal.Text & "' AND TasacionesLis = 1 ORDER BY ApelNombLis ASC"

            End If
            If rdbConcursales.Checked = True Then
                parametros(0) = New ReportParameter("prmAaaa", cmbAaaa.Text)
                parametros(1) = New ReportParameter("prmJuzgado", cmbTribunal.Text)
                parametros(2) = New ReportParameter("prmTribunal", "Art. 67 - Inc. A Concursales")
                parametros(3) = New ReportParameter("prmUser", user)

                comando.CommandText = "SELECT * FROM listaoficio WHERE YyyyLis = '" & cmbAaaa.Text & "' AND TribunalLis = '" & cmbTribunal.Text & "' AND ConcursalesLis = 1 ORDER BY ApelNombLis ASC"

            End If

            Dim ds As New DataSet
            ds = Filtrar()
            Dim rds As New ReportDataSource("dsListaOficio", ds.Tables(0))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(parametros)
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.RefreshReport()
        Else
            detmsg = "Debe elegir que tipo de listado...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
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

    Private Sub ControlarRDB()

        senial = 0

        If rdbDistrito.Checked = True Then
            senial = 1
        End If
        If rdbCircuito.Checked = True Then
            senial = 1
        End If
        If rdbTasaciones.Checked = True Then
            senial = 1
        End If
        If rdbConcursales.Checked = True Then
            senial = 1
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        'DesconectarMySql()
        Close()

    End Sub

End Class