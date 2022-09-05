'*******************************************************************************
'* CONSULTA DE CÓDIGOS A DEBITAR DEL TIPO REC PARA EL RECIBO GENERAL           *
'*******************************************************************************
Public Class frmConsCodDebRec
    Private Sub frmConsCodDebRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)

        comando.CommandText = "SELECT * FROM coddebito WHERE TipoRecCodDeb = 'REC' ORDER BY NroCodDeb "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodDebito.DataSource = dt
        txtDetalleDebito.Focus()

    End Sub

    Private Sub dgvCodDebito_DoubleClick(sender As Object, e As EventArgs) Handles dgvCodDebito.DoubleClick

        If senial = 3 Then
            Dim frmRecGral As frmReciboGral = CType(Owner, frmReciboGral)
            frmReciboGral.txtCodigo.Text = dgvCodDebito.CurrentRow.Cells(1).Value.ToString
            frmReciboGral.txtDetalle.Text = dgvCodDebito.CurrentRow.Cells(2).Value.ToString
            frmReciboGral.txtImporte.Text = dgvCodDebito.CurrentRow.Cells(3).Value.ToString
            frmReciboGral.txtCategoria.Text = dgvCodDebito.CurrentRow.Cells(5).Value.ToString
            frmReciboGral.txtTipoRec.Text = dgvCodDebito.CurrentRow.Cells(6).Value.ToString
        End If

        Close()

    End Sub

    Private Sub txtDetalleDebito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalleDebito.KeyPress

        comando.CommandText = "SELECT * FROM coddebito WHERE TipoRecCodDeb = 'REC' AND DetalleCodDeb LIKE '%" & txtDetalleDebito.Text & "%' ORDER BY NroCodDeb"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodDebito.DataSource = dt

    End Sub

End Class