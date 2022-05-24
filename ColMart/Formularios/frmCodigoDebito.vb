Public Class frmCodigoDebito
    Dim importe As Double

    Private Sub frmCodigoDebito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
        BtnGrabar.Visible = False
        txtDetalleCodDeb.Focus()

    End Sub

    Private Sub NroCodDebTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroCodDeb.KeyDown

        If e.KeyCode = Keys.F1 Then
            Dim frmDeb As New frmConsCodDebito
            AddOwnedForm(frmDeb)
            frmDeb.ShowDialog()
            txtDetalleCodDeb.Focus()
        End If

    End Sub

    Private Sub txtNroCodDeb_MouseHover(sender As Object, e As EventArgs) Handles txtNroCodDeb.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Código a Debitar."
        ToolTipMsg.SetToolTip(txtNroCodDeb, "Presione F1 para buscar en el listado el código a debitar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        txtNroCodDeb.Focus()
        CoddebitoBindingSource.AddNew()
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

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los valores del nuevo Código a Debitar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                'CoddebitoBindingSource.EndEdit()
                comando = New MySqlCommand("INSERT INTO coddebito (NroCodDeb, DetalleCodDeb, ImporteCodDeb, KgCodDeb, CategCodDeb, TipoRecCodDeb, ObsCodDeb) " _
                                           & "VALUES('" & txtNroCodDeb.Text & "', '" & txtDetalleCodDeb.Text & "', '" & txtImporteCodDeb.Text & "', " _
                                           & " '" & txtKgCodDeb.Text & "', '" & txtCategCodDeb.Text & "', '" & cmbTipoRecCodDeb.Text & "', '" & txtObsCodDeb.Text & "')", conexion)
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

        txtNroCodDeb.Focus()
        'NivelesBindingSource.AddNew()
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
        CoddebitoTableAdapter.Fill(Me.DbcolmartDataSet.coddebito)

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para Grabar en la tabla el Código de Débito ingresado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            'CoddebitoBindingSource.EndEdit()
            comando = New MySqlCommand("UPDATE coddebito SET NroCodDeb = '" & txtNroCodDeb.Text & "', DetalleCodDeb = '" & txtDetalleCodDeb.Text & "', ImporteCodDeb = '" & txtImporteCodDeb.Text & "', " _
                                    & "KgCodDeb = '" & txtKgCodDeb.Text & "', CategCodDeb = '" & txtCategCodDeb.Text & "', TipoRecCodDeb = '" & cmbTipoRecCodDeb.Text & "', ObsCodDeb = '" & txtObsCodDeb.Text & "' " _
                                    & " WHERE id_CodDeb = " & txtId_CodDeb.Text & " AND  NroCodDeb = " & txtNroCodDeb.Text & "", conexion)
            comando.ExecuteNonQuery()

            '*** ESTE MODIFICA TAMBIEN EL NOMBRE EN LOS DEBITOS DE LOS MATRICULADOS *********
            'comando = New MySqlCommand("UPDATE debitomatri SET DetDebMat = '" & txtDetalleCodDeb.Text & "', ImpDebMat = '" & Val(txtImporteCodDeb.Text) & "'" _
            '                        & " WHERE CodDebMat = " & txtNroCodDeb.Text & " ", conexion)

            '*** ESTE MODIFICA SOLO EL IMPORTE EN LOS DEBITOS DE LOS MATRICULADOS *********
            comando = New MySqlCommand("UPDATE debitomatri SET ImpDebMat = '" & Val(txtImporteCodDeb.Text) & "'" _
                                    & " WHERE CodDebMat = " & txtNroCodDeb.Text & " ", conexion)
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
            CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
        End If

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para Modificar con los datos ingresados el Código de Débito seleccionado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM coddebito WHERE id_CodDeb = " & txtId_CodDeb.Text & " AND  NroCodDeb = " & txtNroCodDeb.Text & ""), conexion)
            comando.ExecuteNonQuery()
            CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
        End If

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para Eliminar el Código de Débito seleccionado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 2
        Dim frmDeb As New frmConsCodDebito
        AddOwnedForm(frmDeb)
        frmDeb.ShowDialog()
        senial = 0
        txtDetalleCodDeb.Focus()

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para Buscar en la tabla el Código de Débito a procesar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
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

    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(BtnActualizar, "Presione para Actualizar sin modificar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        CoddebitoBindingSource.MoveFirst()

    End Sub

    Private Sub BtnPrimer_MouseHover(sender As Object, e As EventArgs) Handles BtnPrimer.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Primer."
        ToolTipMsg.SetToolTip(BtnPrimer, "Presione para moverse al primer registro de la tabla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        CoddebitoBindingSource.MovePrevious()

    End Sub

    Private Sub BtnAnterior_MouseHover(sender As Object, e As EventArgs) Handles BtnAnterior.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Anterior."
        ToolTipMsg.SetToolTip(BtnAnterior, "Presione para moverse al registro anterior.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        CoddebitoBindingSource.MoveNext()

    End Sub

    Private Sub BtnSiguiente_MouseHover(sender As Object, e As EventArgs) Handles BtnSiguiente.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Siguiente."
        ToolTipMsg.SetToolTip(BtnSiguiente, "Presione para moverse al registro siguiente.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        CoddebitoBindingSource.MoveLast()

    End Sub

    Private Sub BtnUltimo_MouseHover(sender As Object, e As EventArgs) Handles BtnUltimo.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Último."
        ToolTipMsg.SetToolTip(BtnUltimo, "Presione para moverse al último registro de la tabla.")
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

End Class