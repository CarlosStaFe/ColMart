Public Class frmCptosGastos
    Private Sub frmCptosGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CptosgastosTableAdapter.Fill(DbcolmartDataSet.cptosgastos)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub CptosgastosBindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles CptosgastosBindingNavigatorAddNewItem.Click

        txtDetalleCG.Focus()

    End Sub

    Private Sub CptosgastosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CptosgastosBindingNavigatorSaveItem.Click

        Validate()
        CptosgastosBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.DbcolmartDataSet)

    End Sub
End Class