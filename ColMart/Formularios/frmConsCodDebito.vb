Public Class frmConsCodDebito
    Private Sub frmConsCodDebito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)

        txtDetalleDebito.Focus()

    End Sub

    Private Sub txtDetalleDebito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalleDebito.KeyPress

        comando.CommandText = "SELECT * FROM coddebito WHERE DetalleCodDeb LIKE '%" & txtDetalleDebito.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodDebito.DataSource = dt

    End Sub

    Private Sub txtDetalleDebito_MouseHover(sender As Object, e As EventArgs) Handles txtDetalleDebito.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Detalle Débito."
        ToolTipMsg.SetToolTip(txtDetalleDebito, "Ingrese el nombre del detalle que quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvCodDebito_DoubleClick(sender As Object, e As EventArgs) Handles dgvCodDebito.DoubleClick

        If senial = 0 Then
            Dim frmDebMat As frmCargarDebMat = CType(Owner, frmCargarDebMat)
            frmDebMat.txtCodDebMat.Text = dgvCodDebito.CurrentRow.Cells(1).Value.ToString
            frmDebMat.txtDetDebMat.Text = dgvCodDebito.CurrentRow.Cells(2).Value.ToString
            frmDebMat.txtImpDebMat.Text = dgvCodDebito.CurrentRow.Cells(3).Value.ToString
            frmDebMat.txtCategDebMat.Text = dgvCodDebito.CurrentRow.Cells(5).Value.ToString
        End If

        If senial = 1 Then
            Dim frmDeb As frmCargarDebSoc = CType(Owner, frmCargarDebSoc)
            frmDeb.txtCodDebSoc.Text = dgvCodDebito.CurrentRow.Cells(1).Value.ToString
            frmDeb.txtDetDebSoc.Text = dgvCodDebito.CurrentRow.Cells(2).Value.ToString
            frmDeb.txtKgDebSoc.Text = dgvCodDebito.CurrentRow.Cells(4).Value.ToString
            frmDeb.txtCategDebSoc.Text = dgvCodDebito.CurrentRow.Cells(5).Value.ToString
        End If

        If senial = 2 Then
            Dim frmCodDeb As frmCodigoDebito = CType(Owner, frmCodigoDebito)
            frmCodDeb.txtId_CodDeb.Text = dgvCodDebito.CurrentRow.Cells(0).Value.ToString
            frmCodDeb.txtNroCodDeb.Text = dgvCodDebito.CurrentRow.Cells(1).Value.ToString
            frmCodDeb.txtDetalleCodDeb.Text = dgvCodDebito.CurrentRow.Cells(2).Value.ToString
            frmCodDeb.txtImporteCodDeb.Text = dgvCodDebito.CurrentRow.Cells(3).Value.ToString
            frmCodDeb.txtKgCodDeb.Text = dgvCodDebito.CurrentRow.Cells(4).Value.ToString
            frmCodDeb.txtCategCodDeb.Text = dgvCodDebito.CurrentRow.Cells(5).Value.ToString
            frmCodDeb.cmbTipoRecCodDeb.Text = dgvCodDebito.CurrentRow.Cells(6).Value.ToString
            frmCodDeb.txtObsCodDeb.Text = dgvCodDebito.CurrentRow.Cells(7).Value.ToString
        End If

        If senial = 3 Then
            Dim frmRecGral As frmReciboGral = CType(Owner, frmReciboGral)
            frmRecGral.txtCodigo.Text = dgvCodDebito.CurrentRow.Cells(1).Value.ToString
            frmRecGral.txtDetalle.Text = dgvCodDebito.CurrentRow.Cells(2).Value.ToString
            frmRecGral.txtImporte.Text = dgvCodDebito.CurrentRow.Cells(3).Value.ToString
            frmRecGral.txtCategoria.Text = dgvCodDebito.CurrentRow.Cells(5).Value.ToString
            frmRecGral.txtTipoRec.Text = dgvCodDebito.CurrentRow.Cells(6).Value.ToString
        End If

        Close()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub

    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class