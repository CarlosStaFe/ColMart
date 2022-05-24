Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmConsCodDebito
    Private Sub frmConsCodDebito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.coddebito' Puede moverla o quitarla según sea necesario.
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
            frmCodDeb.txtObsCodDeb.Text = dgvCodDebito.CurrentRow.Cells(6).Value.ToString
        End If

        If senial = 3 Then
            Dim frmRecGral As frmReciboGral = CType(Owner, frmReciboGral)
            frmReciboGral.txtCodigo.Text = dgvCodDebito.CurrentRow.Cells(1).Value.ToString
            frmReciboGral.txtDetalle.Text = dgvCodDebito.CurrentRow.Cells(2).Value.ToString
            frmReciboGral.txtImporte.Text = dgvCodDebito.CurrentRow.Cells(3).Value.ToString
            frmReciboGral.txtCategoria.Text = dgvCodDebito.CurrentRow.Cells(5).Value.ToString
        End If

        Close()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()


    End Sub
End Class