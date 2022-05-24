Public Class frmCodPostal
    Private Sub frmCodPostal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.codpostal' Puede moverla o quitarla según sea necesario.
        Me.CodpostalTableAdapter.Fill(Me.DbcolmartDataSet.codpostal)

        txtNroCodPos.Focus()

    End Sub

    Private Sub CodpostalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CodpostalBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.CodpostalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbcolmartDataSet)

    End Sub

    Private Sub txtNroCodPos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroCodPos.KeyDown

        If e.KeyCode = Keys.F1 Then

            senial = 0
            Dim frm As New frmConsCodPos
            AddOwnedForm(frm)
            frm.ShowDialog()
            txtLocalCodPos.Focus()

        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

End Class