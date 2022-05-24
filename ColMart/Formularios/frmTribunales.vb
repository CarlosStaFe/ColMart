Public Class frmTribunales
    Private Sub frmTribunales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TribunalesTableAdapter.Fill(DbcolmartDataSet.tribunales)

    End Sub

    Private Sub TribunalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TribunalesBindingNavigatorSaveItem.Click

        Validate()
        TribunalesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        cbxDistritoTribu.Checked = True
        cbxCircuitoTribu.Checked = True
        cbxTasacionesTribu.Checked = True
        cbxConcursalesTribu.Checked = True

        txtSedeTribu.Focus()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        DesconectarMySql()
        Close()

    End Sub

End Class