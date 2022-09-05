Public Class frmCargarDebMat
    Private Sub frmCargarDebMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        DebitomatriTableAdapter.Fill(DbcolmartDataSet.debitomatri)
        Limpiar()
        txtMatricula.Focus()

    End Sub

    Private Sub txtMatricula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyDown

        'Busco matriculados por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmMat As New frmConsMatri
            AddOwnedForm(frmMat)
            frmMat.ShowDialog()
            CargarDgv()
            senial = 0
            txtMatDebMat.Text = txtMatricula.Text
            txtCodDebMat.Focus()
        End If

        'Busco matriculados por número de matrícula
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerMatriculado()
            CargarDgv()
            txtMatDebMat.Text = txtMatricula.Text
            txtCodDebMat.Focus()
        End If

        txtCodDebMat.Text = ""
        txtDetDebMat.Text = ""
        txtImpDebMat.Text = ""
        txtCategDebMat.Text = ""

    End Sub

    Private Sub txtMatricula_MouseHover(sender As Object, e As EventArgs) Handles txtMatricula.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Matrícula."
        ToolTipMsg.SetToolTip(txtMatricula, "Presione F1 para buscar en el padrón de Martilleros.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub CargarDgv()

        comando.CommandText = "SELECT * FROM debitomatri WHERE MatDebMat = '" & txtMatricula.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvDebitoMat.DataSource = dt

        If dt.Rows.Count > 0 Then
            txtMatDebMat.Text = dgvDebitoMat.CurrentRow.Cells(0).Value.ToString
            txtCodDebMat.Text = dgvDebitoMat.CurrentRow.Cells(1).Value.ToString
            txtDetDebMat.Text = dgvDebitoMat.CurrentRow.Cells(2).Value.ToString
            txtImpDebMat.Text = dgvDebitoMat.CurrentRow.Cells(3).Value.ToString
            txtCategDebMat.Text = dgvDebitoMat.CurrentRow.Cells(4).Value.ToString
        Else
            txtCodDebMat.Text = ""
            txtDetDebMat.Text = ""
            txtImpDebMat.Text = ""
            txtCategDebMat.Text = ""
        End If

    End Sub

    Private Sub txtCodDebMat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodDebMat.KeyDown

        'Busco códigos a debitar por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmDebMat As New frmConsCodDebito
            AddOwnedForm(frmDebMat)
            frmDebMat.ShowDialog()
            LeerDebitos()
            senial = 0
            txtImpDebMat.Focus()
            btnLimpiar.Visible = True
        ElseIf e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then 'Busco códigos a debitar por número de código
            LeerCodigos()
            LeerDebitos()
            txtImpDebMat.Focus()
            btnLimpiar.Visible = True
        Else
            btnLimpiar.Visible = True
        End If

    End Sub

    Private Sub txtCodDebMat_MouseHover(sender As Object, e As EventArgs) Handles txtCodDebMat.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Código a Debitar."
        ToolTipMsg.SetToolTip(txtCodDebMat, "Presione F1 para buscar en el listado de Códigos a Debitar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand("INSERT INTO debitomatri VALUES(@txtMatDebMat, @txtCodDebMat, @txtDetDebMat, @txtImpDebMat, @txtCategDebMat)", conexion)
                comando.Parameters.AddWithValue("@txtMatDebMat", txtMatDebMat.Text)
                comando.Parameters.AddWithValue("@txtCodDebMat", txtCodDebMat.Text)
                comando.Parameters.AddWithValue("@txtDetDebMat", txtDetDebMat.Text)
                comando.Parameters.AddWithValue("@txtImpDebMat", txtImpDebMat.Text)
                comando.Parameters.AddWithValue("@txtCategDebMat", txtCategDebMat.Text)
                comando.ExecuteNonQuery()
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

        CargarDgv()

        txtCodDebMat.Text = ""
        txtDetDebMat.Text = ""
        txtImpDebMat.Text = ""
        txtCategDebMat.Text = ""
        btnAgregar.Visible = False

    End Sub

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(btnAgregar, "Presione para agregar el débito ingresado a la lista a debitar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerMatriculado()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = " & txtMatricula.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelNombre.Text = CStr(row("ApelNombMatri"))
        Else
            txtApelNombre.Text = ""
            detmsg = "Matrícula no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub LeerCodigos()

        comando.CommandText = "SELECT * FROM coddebito WHERE NroCodDeb = " & txtCodDebMat.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtDetDebMat.Text = CStr(row("DetalleCodDeb"))
            txtImpDebMat.Text = CStr(row("ImporteCodDeb"))
            txtCategDebMat.Text = CStr(row("CategCodDeb"))
            txtImpDebMat.Text = Format(Val(txtImpDebMat.Text), "#.###,##")
            txtImpDebMat.Refresh()
        Else
            txtDetDebMat.Text = ""
            txtImpDebMat.Text = ""
            txtCategDebMat.Text = ""
        End If

    End Sub

    Private Sub dgvDebitoMat_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvDebitoMat.MouseClick

        txtMatDebMat.Text = dgvDebitoMat.CurrentRow.Cells(0).Value.ToString
        txtCodDebMat.Text = dgvDebitoMat.CurrentRow.Cells(1).Value.ToString
        txtDetDebMat.Text = dgvDebitoMat.CurrentRow.Cells(2).Value.ToString
        txtImpDebMat.Text = dgvDebitoMat.CurrentRow.Cells(3).Value.ToString
        txtCategDebMat.Text = dgvDebitoMat.CurrentRow.Cells(4).Value.ToString

        btnEliminar.Visible = True
        btnActualizar.Visible = True
        btnAgregar.Visible = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            detmsg = "Desea Eliminar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand(("DELETE FROM debitomatri WHERE MatDebMat = " & txtMatricula.Text & " AND  CodDebMat = " & txtCodDebMat.Text & ""), conexion)
                comando.ExecuteNonQuery()
                detmsg = "Registro eliminado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

        btnEliminar.Visible = False

    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(btnEliminar, "Presione para eliminar el concepto ingresado para el Martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Try
            detmsg = "Desea Actualizar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand(("UPDATE debitomatri SET ImpDebMat = '" & txtImpDebMat.Text & "' WHERE MatDebMat = '" & txtMatricula.Text & "' AND  CodDebMat = '" & txtCodDebMat.Text & "'"), conexion)
                comando.ExecuteNonQuery()
                detmsg = "Registro actualizado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Modificación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

        btnActualizar.Visible = False
        btnEliminar.Visible = False

    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(btnActualizar, "Presiones para actualizar con el nuevo valor el concepto a debitar del Martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

        txtMatricula.Focus()

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar sin borrar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Limpiar()

        txtMatricula.Text = ""
        txtApelNombre.Text = ""
        txtCodDebMat.Text = ""
        txtDetDebMat.Text = ""
        txtImpDebMat.Text = ""
        txtCategDebMat.Text = ""

        comando.CommandText = "SELECT * FROM debitomatri WHERE MatDebMat = " & txtMatricula.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)

        dgvDebitoMat.DataSource = dt

        btnActualizar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnLimpiar.Visible = False

    End Sub

    Private Sub LeerDebitos()

        comando.CommandText = "SELECT * FROM debitomatri WHERE MatDebMat = '" & txtMatricula.Text & "' AND CodDebMat = '" & txtCodDebMat.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            btnActualizar.Visible = True
            btnEliminar.Visible = True
        Else
            btnAgregar.Visible = True
            btnActualizar.Visible = False
            btnEliminar.Visible = False
        End If

        txtImpDebMat.Text = Format(Val(txtImpDebMat.Text), "#.###,##")
        txtImpDebMat.Refresh()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtImpDebMat_MouseHover(sender As Object, e As EventArgs) Handles txtImpDebMat.MouseHover

        ToolTipMsg.ToolTipTitle = "Ingresar importe."
        ToolTipMsg.SetToolTip(txtImpDebMat, "Deje el valor recomendado o ingrese el importe nuevo a cargar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class