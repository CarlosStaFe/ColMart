Public Class frmConsNiveles
    Private Sub NivelesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.NivelesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbcolmartDataSet)

    End Sub

    Private Sub frmConsNiveles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.niveles' Puede moverla o quitarla según sea necesario.
        Me.NivelesTableAdapter.Fill(Me.DbcolmartDataSet.niveles)

    End Sub

    Private Sub dgvNiveles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNiveles.CellDoubleClick

        Dim frm As frmUsuarios = CType(Owner, frmUsuarios)
        frm.txtNivelUsuario.Text = dgvNiveles.CurrentRow.Cells(0).Value.ToString
        frm.txtTipoUsuario.Text = dgvNiveles.CurrentRow.Cells(1).Value.ToString
        Me.Close()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub

End Class