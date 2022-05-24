Imports System.ComponentModel
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmListaOficio
    Dim aaaa, fechajob, fechadb, dd, mm, yyyy As String
    Dim pos1, pos2, flag As Integer

    Private Sub frmListaOficio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        Me.ListaoficioTableAdapter.Fill(Me.DbcolmartDataSet.listaoficio)
        dgvListaOficio.DataSource = Nothing
        CargarCombo()
        txtMatricula.Focus()
        aaaa = Today.Date.ToString("dd-MM-yyyy")
        txtAaaa.Text = Year(aaaa) + 1

    End Sub

    Private Sub txtMatricula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 9
            Dim frmMat9 As New frmConsMatri
            AddOwnedForm(frmMat9)
            frmMat9.ShowDialog()
            LeerMatriculado()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerMatriculado()
        End If

    End Sub

    Private Sub LeerMatriculado()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = '" & txtMatricula.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelNomb.Text = CStr(row("ApelNombMatri"))
            txtCuit.Text = CStr(row("CuitMatri"))
            txtDomicilio.Text = CStr(row("CalleRealMatri"))
            txtCodPostal.Text = CStr(row("CPRealMatri"))
            txtEmail.Text = CStr(row("EmailMatri"))
            txtNroDoc.Text = CStr(row("NroDocMatri"))
            txtTelFijo.Text = CStr(row("FijoRealMatri"))
            txtCelular.Text = CStr(row("CeluRealMatri"))
            txtFechaJur.Text = CStr(row("FecJurMatri"))
            InvertirFecha()
            txtFechaJur.Text = fechajob
            LeerCodPos()
            CargarListaOficio()
        Else
            txtApelNomb.Text = ""
        End If
        BtnGrabar.Visible = True
        BtnGrabar.Enabled = True

    End Sub

    Private Sub CargarListaOficio()

        comando.CommandText = "SELECT * FROM listaoficio WHERE MatriLis = '" & txtMatricula.Text & "' ORDER BY YyyyLis DESC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvListaOficio.DataSource = dt

        dgvListaOficio.Sort(dgvListaOficio.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        dgvListaOficio.Refresh()

        cmbTribunal.Focus()

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

    Private Sub LeerCodPos()

        comando.Connection = conexion

        Try
            comando.CommandText = "SELECT LocalCodPos, ProvCodPos FROM codpostal WHERE NroCodPos = '" & txtCodPostal.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtLocalidad.Text = CStr(row("LocalCodPos"))
                txtProvincia.Text = CStr(row("ProvCodPos"))
            Else
                txtLocalidad.Text = ""
                txtProvincia.Text = ""
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

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
                    cbxDistrito.Visible = False
                Else
                    cbxDistrito.Visible = True
                End If
                If IsDBNull(row("CircuitoTribu")) = True Then
                    cbxCircuito.Visible = False
                Else
                    cbxCircuito.Visible = True
                End If
                If IsDBNull(row("TasacionesTribu")) = True Then
                    cbxTasaciones.Visible = False
                Else
                    cbxTasaciones.Visible = True
                End If
                If IsDBNull(row("ConcursalesTribu")) = True Then
                    cbxConcursales.Visible = False
                Else
                    cbxConcursales.Visible = True
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Error en el archivo...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        ControlarListado()

    End Sub

    Private Sub ControlarListado()

        Try
            comando.CommandText = "SELECT * FROM listaoficio WHERE MatriLis = '" & txtMatricula.Text & "' AND TribunalLis = '" & cmbTribunal.SelectedItem & "' AND YyyyLis = '" & txtAaaa.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                If Str(row("DistritoLis")) = False Then
                    cbxDistrito.Checked = False
                Else
                    cbxDistrito.Checked = True
                End If
                If Str(row("CircuitoLis")) = False Then
                    cbxCircuito.Checked = False
                Else
                    cbxCircuito.Checked = True
                End If
                If Str(row("TasacionesLis")) = False Then
                    cbxTasaciones.Checked = False
                Else
                    cbxTasaciones.Checked = True
                End If
                If Str(row("ConcursalesLis")) = False Then
                    cbxConcursales.Checked = False
                Else
                    cbxConcursales.Checked = True
                End If

                txtDomLocal.Text = row("DomicilioLis")

                detmsg = "Tribunal ya cargado...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()

                BtnAgregar.Visible = False
                BtnEliminar.Visible = True
                BtnModificar.Visible = True

            Else
                BtnAgregar.Visible = True
                BtnEliminar.Visible = False
                BtnModificar.Visible = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        ControlarChequeo()

        GrabarLista()

    End Sub

    Private Sub GrabarLista()

        If txtDomLocal.Text = "" Then
            detmsg = "Debe ingresar un domicilio...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtDomLocal.Focus()
        Else
            If flag = 1 Then

                Try
                    comando = New MySqlCommand("INSERT INTO listaoficio VALUES(@id, @matricula, @nombre, @yyyy, @tribunal, @distrito, @circuito, @tasaciones, @concursales ,@domicilio)", conexion)
                    comando.Parameters.AddWithValue("@id", 0)
                    comando.Parameters.AddWithValue("@matricula", txtMatricula.Text)
                    comando.Parameters.AddWithValue("@nombre", txtApelNomb.Text)
                    comando.Parameters.AddWithValue("@yyyy", txtAaaa.Text)
                    comando.Parameters.AddWithValue("@tribunal", cmbTribunal.SelectedItem)
                    If cbxDistrito.Checked = True Then
                        comando.Parameters.AddWithValue("@distrito", 1)
                    Else
                        comando.Parameters.AddWithValue("@distrito", 0)
                    End If
                    If cbxCircuito.Checked = True Then
                        comando.Parameters.AddWithValue("@circuito", 1)
                    Else
                        comando.Parameters.AddWithValue("@circuito", 0)
                    End If
                    If cbxTasaciones.Checked = True Then
                        comando.Parameters.AddWithValue("@tasaciones", 1)
                    Else
                        comando.Parameters.AddWithValue("@tasaciones", 0)
                    End If
                    If cbxConcursales.Checked = True Then
                        comando.Parameters.AddWithValue("@concursales", 1)
                    Else
                        comando.Parameters.AddWithValue("@concursales", 0)
                    End If
                    comando.Parameters.AddWithValue("@domicilio", txtDomLocal.Text)

                    comando.ExecuteNonQuery()

                Catch ex As Exception
                    'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
                    detmsg = "Error en el archivo...!!!"
                    tipomsg = "info"
                    btnmsg = 1
                    frmMsgBox.ShowDialog()
                End Try

                dgvListaOficio.DataSource = Nothing

                CargarListaOficio()
                Limpiar()

            Else

                detmsg = "NO MARCÓ NINGÚN JUZGADO...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()

                Limpiar()

            End If
        End If


    End Sub

    Private Sub ControlarChequeo()

        flag = 0

        If cbxDistrito.Checked = True Then
            flag = 1
        End If
        If cbxCircuito.Checked = True Then
            flag = 1
        End If
        If cbxTasaciones.Checked = True Then
            flag = 1
        End If
        If cbxConcursales.Checked = True Then
            flag = 1
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        ControlarChequeo()

        If flag = 1 Then

            Try
                BorrarListado()
                GrabarLista()

                detmsg = "Registro actualizado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()

            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
                detmsg = "Error en el archivo...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End Try

            dgvListaOficio.DataSource = Nothing

            CargarListaOficio()

            Limpiar()

            cmbTribunal.Focus()

        Else

            detmsg = "NO MARCÓ NINGÚN JUZGADO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

            Limpiar()

        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        BorrarListado()

        dgvListaOficio.DataSource = Nothing

        CargarListaOficio()
        Limpiar()

        detmsg = "Registro eliminado correctamente...!!!"
        tipomsg = "ok"
        btnmsg = 1
        frmMsgBox.ShowDialog()

    End Sub

    Private Sub BorrarListado()

        comando = New MySqlCommand("DELETE FROM listaoficio WHERE MatriLis = '" & txtMatricula.Text & "' AND TribunalLis = '" & cmbTribunal.SelectedItem & "' AND YyyyLis = '" & txtAaaa.Text & "' ", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        InvertirFecha()
        txtFechaJur.Text = fechadb

        comando = New MySqlCommand("UPDATE matriculados SET ApelNombMatri = '" & txtApelNomb.Text & "', NroDocMatri = '" & txtNroDoc.Text & "', CuitMatri = '" & txtCuit.Text & "', " _
                                    & "FecJurMatri = '" & txtFechaJur.Text & "', CalleRealMatri = '" & txtDomicilio.Text & "', CPRealMatri = '" & txtCodPostal.Text & "', " _
                                    & "EmailMatri = '" & txtEmail.Text & "', CeluRealMatri = '" & txtCelular.Text & "', FijoRealMatri = '" & txtTelFijo.Text & "' " _
                                    & "WHERE NroMatri = " & txtMatricula.Text & "", conexion)
        comando.ExecuteNonQuery()

        InvertirFecha()
        txtFechaJur.Text = fechajob

        BtnGrabar.Enabled = False

        Limpiar()

        cmbTribunal.Focus()

    End Sub

    Private Sub Limpiar()

        cmbTribunal.Text = ""
        txtDomLocal.Text = ""
        cbxDistrito.Checked = False
        cbxCircuito.Checked = False
        cbxTasaciones.Checked = False
        cbxConcursales.Checked = False
        BtnAgregar.Visible = False
        BtnEliminar.Visible = False
        BtnModificar.Visible = False

    End Sub

    Private Sub InvertirFecha()

        fechajob = ""
        '-----Fecha Juramento
        fechajob = txtFechaJur.Text
        ProcesarFecha()

    End Sub

    Private Sub ProcesarFecha()

        pos1 = InStr(1, fechajob, "/")
        pos2 = InStr(pos1 + 1, fechajob, "/")

        If pos1 = 5 Then
            yyyy = Mid(fechajob, 1, pos1 - 1)
            mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))
            dd = Mid(fechajob, pos2 + 1, 2)
        ElseIf pos1 = 3 Then
            dd = Mid(fechajob, 1, pos1 - 1)
            mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))
            yyyy = Mid(fechajob, pos2 + 1, 4)
        End If

        fechajob = dd & "/" & mm & "/" & yyyy
        fechadb = yyyy & "/" & mm & "/" & dd

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Limpiar()
        txtMatricula.Text = ""
        txtApelNomb.Text = ""
        txtCuit.Text = ""
        txtDomicilio.Text = ""
        txtNroDoc.Text = ""
        txtCodPostal.Text = ""
        txtLocalidad.Text = ""
        txtProvincia.Text = ""
        txtTelFijo.Text = ""
        txtCelular.Text = ""
        txtFechaJur.Text = ""
        txtEmail.Text = ""
        BtnGrabar.Visible = False
        dgvListaOficio.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub btnListados_Click(sender As Object, e As EventArgs) Handles btnListados.Click

        frmPrintLista.ShowDialog()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

End Class