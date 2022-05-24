Public Class frmTribunales
    Private Sub frmTribunales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.tribunales' Puede moverla o quitarla según sea necesario.
        Me.TribunalesTableAdapter.Fill(Me.DbcolmartDataSet.tribunales)

    End Sub

    Private Sub TribunalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TribunalesBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.TribunalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbcolmartDataSet)

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