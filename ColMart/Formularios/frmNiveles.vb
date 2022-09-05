'*******************************************************************************
'* ACTUALIZACIÓN DE NIVELES DE USUARIO                                         *
'*******************************************************************************
Public Class frmNiveles
    Private Sub frmNiveles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NivelesTableAdapter.Fill(DbcolmartDataSet.niveles)
        BtnGrabar.Visible = False

        txtTipoNivel.Focus()

    End Sub

    Private Sub NivelesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NivelesBindingNavigatorSaveItem.Click

        Validate()
        NivelesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)

    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        txtTipoNivel.Focus()
        NivelesBindingSource.AddNew()
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
                NivelesBindingSource.EndEdit()
                NivelesTableAdapter.Update(DbcolmartDataSet.niveles)
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

        txtTipoNivel.Focus()
        'NivelesBindingSource.AddNew()
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
        Me.NivelesTableAdapter.Fill(Me.DbcolmartDataSet.niveles)

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            NivelesBindingSource.EndEdit()
            NivelesTableAdapter.Update(DbcolmartDataSet.niveles)
            detmsg = "Registro actualizado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Edición cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            NivelesTableAdapter.Fill(DbcolmartDataSet.niveles)
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            NivelesBindingSource.RemoveCurrent()
            NivelesTableAdapter.Update(DbcolmartDataSet.niveles)
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            NivelesTableAdapter.Fill(DbcolmartDataSet.niveles)
        End If

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        NivelesTableAdapter.Fill(DbcolmartDataSet.niveles)
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

        NivelesBindingSource.MoveFirst()

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        NivelesBindingSource.MovePrevious()

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        NivelesBindingSource.MoveNext()

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        NivelesBindingSource.MoveLast()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub

End Class