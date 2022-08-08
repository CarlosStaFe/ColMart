Public Class frmCargarMenues
    Private Sub frmCargarMenues_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        BotonesTableAdapter.Fill(DbcolmartDataSet.botones)
        txtNombreBtn.Focus()

    End Sub

    Private Sub BotonesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BotonesBindingNavigatorSaveItem.Click

        Validate()
        BotonesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        comando = New MySqlCommand(("DELETE FROM botones WHERE NombreBtn = '" & txtNombreBtn.Text & "' "), conexion)
        comando.ExecuteNonQuery()

        comando = New MySqlCommand(("DELETE FROM botonuser WHERE BotonBU = '" & txtNombreBtn.Text & "' "), conexion)
        comando.ExecuteNonQuery()

        Validate()
        BotonesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)


    End Sub
End Class