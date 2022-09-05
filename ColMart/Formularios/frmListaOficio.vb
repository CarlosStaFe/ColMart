'*******************************************************************************
'* CARGA DE LISTAS DE NOMBRAMIENTO DE OFICIO                                   *
'*******************************************************************************
Public Class frmListaOficio
    Dim aaaa, dd, mm, yyyy, fechaaux, fecha1, fecha2 As String
    Dim pos1, pos2, flag, meses As Integer

    Private Sub frmListaOficio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        ListaoficioTableAdapter.Fill(DbcolmartDataSet.listaoficio)
        dgvListaOficio.DataSource = Nothing
        CargarCombo()
        txtMatricula.Focus()
        aaaa = Today.Date.ToString("dd-MM-yyyy")
        txtAaaa.Text = Year(aaaa) + 1
        lblLocalReal.Text = ""
        lblDptoReal.Text = ""
        lblProvReal.Text = ""

    End Sub

    Private Sub txtMatricula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 9
            Dim frmMat9 As New frmConsMatri
            AddOwnedForm(frmMat9)
            frmMat9.ShowDialog()
            LeerMatriculado()
            senial = 0
        ElseIf e.KeyCode = Keys.Enter Then
            LeerMatriculado()
            senial = 0
        Else
            txtApelNomb.Text = ""
            txtCuit.Enabled = False
            txtDomicilio.Enabled = False
            txtNroDoc.Enabled = False
            txtCodPostal.Enabled = False
            txtTelFijo.Enabled = False
            txtCelular.Enabled = False
            txtFechaJur.Enabled = False
            txtEmail.Enabled = False
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
            txtEmail.Text = CStr(row("EmailMatri"))
            txtNroDoc.Text = CStr(row("NroDocMatri"))
            txtTelFijo.Text = CStr(row("FijoRealMatri"))
            txtCelular.Text = CStr(row("CeluRealMatri"))

            fechajob = CStr(row("FecJurMatri"))
            ProcesarFecha()
            txtFechaJur.Text = fechajob

            fechajob = CStr(row("FianzaMatri"))
            ProcesarFecha()
            lblVenceFianza.Text = fechajob
            txtFianza.Text = fechajob

            LeerCodPos()
            Habilitar()
            CargarListaOficio()

            '-----Fecha Vence Fianza
            meses = 24
            fechajob = DateAdd("m", meses, txtFianza.Text)
            ProcesarFecha()
            lblVenceFianza.Text = fechajob
            fechaaux = Format(Now, "dd/MM/yyyy")

            fecha1 = CDate(fechajob)
            fecha2 = CDate(fechaaux)
            If fecha1 < fecha2 Then
                lblVenceFianza.ForeColor = Color.Red
                Impedir()
            Else
                lblVenceFianza.ForeColor = Color.Lime
                Permitir()
            End If

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

        '***BUSCAMOS EL CÓDIGO POSTAL REAL***
        comando.CommandText = "SELECT matriculados.idLocalRMatri, localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv, " _
                                & "matriculados.idLocalRMatri, matriculados.idDptoRMatri, matriculados.idProvRMatri FROM matriculados " _
                                & "INNER JOIN localidad    ON matriculados.idLocalRMatri = localidad.id_Local " _
                                & "INNER JOIN departamento ON localidad.fk_DptoLocal     = departamento.id_Dpto " _
                                & "INNER JOIN provincia    ON departamento.fk_ProvDpto   = provincia.id_Prov " _
                                & "WHERE matriculados.NroMatri = '" & txtMatricula.Text & "' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtCodPostal.Text = Val(CStr(row("CodPosLocal")))
            lblLocalReal.Text = CStr(row("NombreLocal"))
            lblDptoReal.Text = CStr(row("NombreDpto"))
            lblProvReal.Text = CStr(row("NombreProv"))
            txtLocal.Text = CStr(row("idLocalRMatri"))
            txtDpto.Text = CStr(row("idDptoRMatri"))
            txtProv.Text = CStr(row("idProvRMatri"))
        Else
            txtCodPostal.Text = 0
            lblLocalReal.Text = ""
            lblDptoReal.Text = ""
            lblProvReal.Text = ""
            txtLocal.Text = "164"
            txtDpto.Text = "1"
            txtProv.Text = "1"
        End If
        lblLocalReal.Visible = True
        lblDptoReal.Visible = True
        lblProvReal.Visible = True

    End Sub

    Private Sub BuscarCodPos()

        '***BUSCAMOS EL CÓDIGO POSTAL POR CÓDIGO***
        comando.CommandText = "SELECT localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv, localidad.id_Local, departamento.id_Dpto, provincia.id_Prov FROM localidad " _
                               & "INNER JOIN departamento ON localidad.fk_DptoLocal     = departamento.id_Dpto " _
                               & "INNER JOIN provincia    ON departamento.fk_ProvDpto   = provincia.id_Prov " _
                               & "WHERE localidad.CodPosLocal = '" & txtCodPostal.Text & "' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtCodPostal.Text = Val(CStr(row("CodPosLocal")))
            lblLocalReal.Text = CStr(row("NombreLocal"))
            lblDptoReal.Text = CStr(row("NombreDpto"))
            lblProvReal.Text = CStr(row("NombreProv"))
            txtLocal.Text = CStr(row("id_Local"))
            txtDpto.Text = CStr(row("id_Dpto"))
            txtProv.Text = CStr(row("id_Prov"))
        Else
            txtCodPostal.Text = 0
            lblLocalReal.Text = ""
            lblDptoReal.Text = ""
            lblProvReal.Text = ""
            txtLocal.Text = "164"
            txtDpto.Text = "1"
            txtProv.Text = "1"
        End If
        lblLocalReal.Visible = True
        lblDptoReal.Visible = True
        lblProvReal.Visible = True

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

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para grabar a la lista los datos ingresados.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

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

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para modificar la lista ingresada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

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

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar la lista ingresada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BorrarListado()

        comando = New MySqlCommand("DELETE FROM listaoficio WHERE MatriLis = '" & txtMatricula.Text & "' AND TribunalLis = '" & cmbTribunal.SelectedItem & "' AND YyyyLis = '" & txtAaaa.Text & "' ", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        fechajob = txtFechaJur.Text
        ProcesarFecha()
        txtFechaJur.Text = fechadb

        comando = New MySqlCommand("UPDATE matriculados SET ApelNombMatri = '" & txtApelNomb.Text & "', NroDocMatri = '" & txtNroDoc.Text & "', CuitMatri = '" & txtCuit.Text & "', " _
                                    & "FecJurMatri = '" & txtFechaJur.Text & "', CalleRealMatri = '" & txtDomicilio.Text & "', idLocalRMatri = '" & txtLocal.Text & "', idDptoRMatri = '" & txtDpto.Text & "', " _
                                    & "idProvRMatri = '" & txtProv.Text & "', EmailMatri = '" & txtEmail.Text & "', CeluRealMatri = '" & txtCelular.Text & "', FijoRealMatri = '" & txtTelFijo.Text & "' " _
                                    & "WHERE NroMatri = " & txtMatricula.Text & "", conexion)
        comando.ExecuteNonQuery()

        txtFechaJur.Text = fechajob

        BtnGrabar.Enabled = False

        Limpiar()

        cmbTribunal.Focus()

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados en el legajo del martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

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

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Limpiar()
        txtMatricula.Text = ""
        txtApelNomb.Text = ""
        txtCuit.Text = ""
        txtDomicilio.Text = ""
        txtNroDoc.Text = ""
        txtCodPostal.Text = ""
        lblLocalReal.Text = ""
        lblDptoReal.Text = ""
        lblProvReal.Text = ""
        txtTelFijo.Text = ""
        txtCelular.Text = ""
        txtFechaJur.Text = ""
        txtEmail.Text = ""
        BtnGrabar.Visible = False
        dgvListaOficio.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub BtnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles BtnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(BtnLimpiar, "Presione para limpiar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Habilitar()

        txtCuit.Enabled = True
        txtDomicilio.Enabled = True
        txtNroDoc.Enabled = True
        txtCodPostal.Enabled = True
        txtTelFijo.Enabled = True
        txtCelular.Enabled = True
        txtFechaJur.Enabled = True
        txtEmail.Enabled = True

    End Sub
    Private Sub btnListados_Click(sender As Object, e As EventArgs) Handles btnListados.Click

        frmPrintLista.ShowDialog()

    End Sub

    Private Sub btnListados_MouseHover(sender As Object, e As EventArgs) Handles btnListados.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Listado."
        ToolTipMsg.SetToolTip(btnListados, "Presione para imprimir las listas deseadas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtCodPostal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPostal.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmCol1 As New frmConsCodPostal
            AddOwnedForm(frmCol1)
            frmCol1.ShowDialog()
            txtTelFijo.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCodPos()
            txtTelFijo.Focus()
        End If

    End Sub
    Private Sub Permitir()

        txtAaaa.Enabled = True
        cmbTribunal.Enabled = True
        cbxCircuito.Enabled = True
        cbxConcursales.Enabled = True
        cbxDistrito.Enabled = True
        cbxTasaciones.Enabled = True
        txtDomLocal.Enabled = True

    End Sub
    Private Sub Impedir()

        txtAaaa.Enabled = False
        cmbTribunal.Enabled = False
        cbxCircuito.Enabled = False
        cbxConcursales.Enabled = False
        cbxDistrito.Enabled = False
        cbxTasaciones.Enabled = False
        txtDomLocal.Enabled = False

    End Sub

End Class