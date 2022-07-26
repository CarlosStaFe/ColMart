Public Class frmProveedores

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        ProveedoresTableAdapter.Fill(DbcolmartDataSet.proveedores)
        CargarIVA()
        idCodigo = DbcolmartDataSet.proveedores.Rows(0).Item(5)
        'idCodigo = 39
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub txtNroProv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProv.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmProv0 As New frmConsProveedores
            AddOwnedForm(frmProv0)
            frmProv0.ShowDialog()
            idCodigo = txtIdCodPosProv.Text
            CodPostal = txtCodPos.Text
            LeerCodigoPostal()
            CargoLocalidad()
            senial = 0
            txtRazonSocialProv.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerProveedor()
            txtRazonSocialProv.Focus()
            If senial = 1 Then
                Actualizar()
                txtNroProv.Focus()
                senial = 0
            End If
        End If

    End Sub

    Private Sub txtNroProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroProv.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        ProveedoresBindingSource.AddNew()
        NroNuevo()
        txtNroProv.Show()
        txtRazonSocialProv.Focus()
        BtnAgregar.Visible = False
        BtnGrabar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        BtnPrimer.Visible = False
        BtnAnterior.Visible = False
        BtnSiguiente.Visible = False
        BtnUltimo.Visible = False
        cmbTipoIvaProv.SelectedIndex = 0

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los datos de un nuevo proveedor.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                ProveedoresBindingSource.EndEdit()
                ProveedoresTableAdapter.Update(DbcolmartDataSet.proveedores)
                detmsg = "Registro guardado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            detmsg = "Grabación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        Actualizar()

        txtNroProv.Focus()

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados del proveedor nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand("UPDATE proveedores SET NroProv = '" & txtNroProv.Text & "', RazonSocialProv = '" & txtRazonSocialProv.Text & "', TitularProv = '" & txtTitularProv.Text & "', " _
                                    & " DomicilioProv = '" & txtDomicilioProv.Text & "', IdCodPosProv = '" & txtIdCodPosProv.Text & "', TipoIvaProv = '" & cmbTipoIvaProv.Text & "', EmailProv = '" & txtEmailProv.Text & "', " _
                                    & " CuitProv = '" & txtCuitProv.Text & "', TelefProv = '" & txtTelefProv.Text & "', IngBrutosProv = '" & txtIngBrutosProv.Text & "', ObsProv = '" & txtObsProv.Text & "' " _
                                    & " WHERE id_Prov = " & txtId_Prov.Text & " AND  NroProv = " & txtNroProv.Text & "", conexion)
            comando.ExecuteNonQuery()
            detmsg = "Registro actualizado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Edición cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        ProveedoresTableAdapter.Fill(DbcolmartDataSet.proveedores)
        idCodigo = txtIdCodPosProv.Text
        CodPostal = txtCodPos.Text
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados del proveedor.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM proveedores WHERE id_Prov = " & txtId_Prov.Text & " AND  NroProv = " & txtNroProv.Text & ""), conexion)
            comando.ExecuteNonQuery()
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        ProveedoresTableAdapter.Fill(DbcolmartDataSet.proveedores)
        idCodigo = txtIdCodPosProv.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el proveedor en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 0
        Dim frmProv0 As New frmConsProveedores
        AddOwnedForm(frmProv0)
        frmProv0.ShowDialog()
        senial = 0
        idCodigo = txtIdCodPosProv.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para buscar en el padrón un proveedor.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Actualizar()

    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(BtnActualizar, "Presione para volver al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        ProveedoresBindingSource.MoveFirst()
        idCodigo = txtIdCodPosProv.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnPrimer_MouseHover(sender As Object, e As EventArgs) Handles BtnPrimer.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Primer."
        ToolTipMsg.SetToolTip(BtnPrimer, "Presione para ir al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        ProveedoresBindingSource.MovePrevious()
        idCodigo = txtIdCodPosProv.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnAnterior_MouseHover(sender As Object, e As EventArgs) Handles BtnAnterior.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Anterior."
        ToolTipMsg.SetToolTip(BtnAnterior, "Presione para ir al registro anterior del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        ProveedoresBindingSource.MoveNext()
        idCodigo = txtIdCodPosProv.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnSiguiente_MouseHover(sender As Object, e As EventArgs) Handles BtnSiguiente.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Siguiente."
        ToolTipMsg.SetToolTip(BtnSiguiente, "Presione para ir al registro siguiente del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        ProveedoresBindingSource.MoveLast()
        idCodigo = txtIdCodPosProv.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnUltimo_MouseHover(sender As Object, e As EventArgs) Handles BtnUltimo.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Último."
        ToolTipMsg.SetToolTip(BtnUltimo, "Presione para ir al último registro del padrón.")
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

    Private Sub txtCodPos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPos.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 4
            Dim frmProv4 As New frmConsCodPos
            AddOwnedForm(frmProv4)
            frmProv4.ShowDialog()
            idCodigo = txtIdCodPosProv.Text
            CodPostal = ""
            LeerCodigoPostal()
            CargoLocalidad()
            txtTelefProv.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            idCodigo = 0
            CodPostal = txtCodPos.Text
            LeerCodigoPostal()
            CargoLocalidad()
            txtTelefProv.Focus()
        End If

    End Sub

    Private Sub txtCodPos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodPos.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCodPos_MouseHover(sender As Object, e As EventArgs) Handles txtCodPos.MouseHover

        ToolTipMsg.ToolTipTitle = "Código Postal."
        ToolTipMsg.SetToolTip(txtCodPos, "Presione F1 para consultar el podrón de códigos postales o el código y luego Enter.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub
    Private Sub LeerProveedor()

        comando.CommandText = "SELECT * FROM proveedores WHERE NroProv = " & txtNroProv.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            CargarProveedor()
            idCodigo = txtIdCodPosProv.Text
            CodPostal = ""
            LeerCodigoPostal()
            CargoLocalidad()
        Else
            detmsg = "Proveedor no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        End If

    End Sub

    Private Sub CargarProveedor()

        Dim row As DataRow = dt.Rows(0)

        txtId_Prov.Text = CStr(row("id_Prov"))
        txtNroProv.Text = CStr(row("NroProv"))
        txtRazonSocialProv.Text = CStr(row("RazonSocialProv"))
        txtTitularProv.Text = CStr(row("TitularProv"))
        txtDomicilioProv.Text = CStr(row("DomicilioProv"))
        txtIdCodPosProv.Text = CStr(row("IdCodPosProv"))
        txtTelefProv.Text = CStr(row("TelefProv"))
        cmbTipoIvaProv.Text = CStr(row("TipoIvaProv"))
        txtCuitProv.Text = CStr(row("CuitProv"))
        txtIngBrutosProv.Text = CStr(row("IngBrutosProv"))
        txtObsProv.Text = CStr(row("ObsProv"))

    End Sub

    Private Sub NroNuevo()

        comando = New MySqlCommand("SELECT MAX(NroProv) NroProv FROM proveedores WHERE NroProv > 0", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtNroProv.Text = Val(dr(0).ToString) + 1
            End While
        Else
            txtNroProv.Text = 1
        End If
        dr.Close()

    End Sub

    Private Sub Actualizar()

        ProveedoresTableAdapter.Fill(DbcolmartDataSet.proveedores)
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = True
        BtnActualizar.Visible = True
        BtnPrimer.Visible = True
        BtnAnterior.Visible = True
        BtnSiguiente.Visible = True
        BtnUltimo.Visible = True
        idCodigo = txtIdCodPosProv.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()
        txtNroProv.Focus()

    End Sub

    Private Sub CargarIVA()

        comando = New MySqlCommand("SELECT DISTINCT DescripcionCI FROM categiva ORDER BY DescripcionCI DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbTipoIvaProv.Items.Add(dr(0).ToString)
            End While
        End If

        dr.Close()

    End Sub

    Private Sub CargoLocalidad()

        txtCodPos.Text = CodPostal
        txtIdCodPosProv.Text = idCodigo
        txtLocalidad.Text = Localidad
        txtProvincia.Text = Provincia

    End Sub

    Private Sub txtCuitProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuitProv.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtIngBrutosProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIngBrutosProv.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class