Public Class frmUsuarios
    Dim usuario As String

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        UsuariosTableAdapter.Fill(DbcolmartDataSet.usuarios)
        BtnGrabar.Visible = False

        'txtApelUsuario.Focus()

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click

        Validate()
        UsuariosBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)

    End Sub

    Private Sub NivelUsuarioTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNivelUsuario.KeyDown

        If e.KeyCode = Keys.F1 Then
            Dim frm As New frmConsNiveles
            AddOwnedForm(frm)
            frm.ShowDialog()
            txtUserUsuario.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            LeerNiveles()
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        txtApelUsuario.Focus()
        UsuariosBindingSource.AddNew()
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

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                UsuariosBindingSource.EndEdit()
                UsuariosTableAdapter.Update(DbcolmartDataSet.usuarios)
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

        'txtApelUsuario.Focus()
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        BtnPrimer.Visible = True
        BtnAnterior.Visible = True
        BtnSiguiente.Visible = True
        BtnUltimo.Visible = True
        UsuariosTableAdapter.Fill(DbcolmartDataSet.usuarios)

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            UsuariosBindingSource.EndEdit()
            UsuariosTableAdapter.Update(DbcolmartDataSet.usuarios)
            detmsg = "Registro actualizado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            ModificarMenues()
        Else
            detmsg = "Edición cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            UsuariosTableAdapter.Fill(DbcolmartDataSet.usuarios)
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            UsuariosBindingSource.RemoveCurrent()
            UsuariosTableAdapter.Update(DbcolmartDataSet.usuarios)
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            BorrarMenues()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            UsuariosTableAdapter.Fill(DbcolmartDataSet.usuarios)
        End If

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        UsuariosTableAdapter.Fill(DbcolmartDataSet.usuarios)
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        BtnPrimer.Visible = True
        BtnAnterior.Visible = True
        BtnSiguiente.Visible = True
        BtnUltimo.Visible = True

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        UsuariosBindingSource.MoveFirst()

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        UsuariosBindingSource.MovePrevious()

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        UsuariosBindingSource.MoveNext()

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        UsuariosBindingSource.MoveLast()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub txtNivelUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtNivelUsuario.MouseHover

        ToolTipMsg.ToolTipTitle = "Nivel Usuario."
        ToolTipMsg.SetToolTip(txtNivelUsuario, "Presione F1 para consultar los niveles.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerNiveles()

        comando = New MySqlCommand("SELECT * FROM niveles WHERE TipoNivel = '" & txtNivelUsuario.Text & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                txtTipoUsuario.Text = dr(2).ToString
            End While
        End If

        dr.Close()
        dr.Dispose()

        txtUserUsuario.Focus()

    End Sub

    Private Sub txtClaveUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtClaveUsuario.LostFocus

        txtClaveUsuario.Text = Encriptar(txtClaveUsuario.Text)

    End Sub

    Private Sub txtActivoUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtActivoUsuario.MouseHover

        ToolTipMsg.ToolTipTitle = "Activo Usuario."
        ToolTipMsg.SetToolTip(txtActivoUsuario, "S = Activo <----> N = No Activo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BorrarMenues()

        comando = New MySqlCommand(("DELETE FROM botonuser WHERE UsuarioBU = '" & txtUserUsuario.Text & "' "), conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub ModificarMenues()

        comando = New MySqlCommand("UPDATE botonuser SET UsuarioBU = '" & txtUserUsuario.Text & "' WHERE UsuarioBU = '" & usuario & "' ", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub txtApelUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtApelUsuario.LostFocus

        usuario = txtUserUsuario.Text

        If usuario <> "" Then
            txtClaveUsuario.Text = Desencriptar(txtClaveUsuario.Text)
        End If

    End Sub
End Class