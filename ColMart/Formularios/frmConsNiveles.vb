'*******************************************************************************
'* CONSULTA DE NIVELES DE USUARIOS DEL SISTEMA                                 *
'*******************************************************************************
Public Class frmConsNiveles
    Private Sub frmConsNiveles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NivelesTableAdapter.Fill(DbcolmartDataSet.niveles)

    End Sub

    Private Sub dgvNiveles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNiveles.CellDoubleClick

        Dim frm As frmUsuarios = CType(Owner, frmUsuarios)
        frm.txtNivelUsuario.Text = dgvNiveles.CurrentRow.Cells(0).Value.ToString
        frm.txtTipoUsuario.Text = dgvNiveles.CurrentRow.Cells(1).Value.ToString
        Close()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub

End Class