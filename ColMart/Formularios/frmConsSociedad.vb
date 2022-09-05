'*******************************************************************************
'* CONSULTA DE SOCIEDADES DE REMATES                                           *
'*******************************************************************************
Public Class frmConsSociedad

    Private Sub frmConsSociedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SociedadesTableAdapter.Fill(DbcolmartDataSet.sociedades)
        txtNombre.Focus()

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

        comando.CommandText = "SELECT * FROM sociedades WHERE NombSociedad LIKE '%" & txtNombre.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvSociedades.DataSource = dt

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Sociedad."
        ToolTipMsg.SetToolTip(txtNombre, "Presione F1 para buscar la Sociedad.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvSociedades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSociedades.CellDoubleClick

        If senial = 0 Then
            Dim frmSoc0 As frmCargarDebSoc = CType(Owner, frmCargarDebSoc)
            frmSoc0.txtSociedad.Text = dgvSociedades.CurrentRow.Cells(0).Value.ToString
            frmSoc0.txtNombSociedad.Text = dgvSociedades.CurrentRow.Cells(1).Value.ToString
        End If

        If senial = 1 Then
            Dim frmSoc1 As frmSociedades = CType(Owner, frmSociedades)
            frmSoc1.txtNroSociedad.Text = dgvSociedades.CurrentRow.Cells(0).Value.ToString
            frmSoc1.txtNombSociedad.Text = dgvSociedades.CurrentRow.Cells(1).Value.ToString
            frmSoc1.txtCalleSociedad.Text = dgvSociedades.CurrentRow.Cells(2).Value.ToString
            frmSoc1.txtCodPosSociedad.Text = dgvSociedades.CurrentRow.Cells(3).Value.ToString
            frmSoc1.txtLocalSociedad.Text = dgvSociedades.CurrentRow.Cells(4).Value.ToString
            frmSoc1.txtDptoSociedad.Text = dgvSociedades.CurrentRow.Cells(5).Value.ToString
            frmSoc1.txtProvSociedad.Text = dgvSociedades.CurrentRow.Cells(6).Value.ToString
            frmSoc1.txtTelSociedad.Text = dgvSociedades.CurrentRow.Cells(7).Value.ToString
            frmSoc1.txtEmailSociedad.Text = dgvSociedades.CurrentRow.Cells(8).Value.ToString
            frmSoc1.cmbEstadoSociedad.Text = dgvSociedades.CurrentRow.Cells(9).Value.ToString
            frmSoc1.cmbClaseSoc.Text = dgvSociedades.CurrentRow.Cells(10).Value.ToString
            frmSoc1.txtMartilleroSoc.Text = dgvSociedades.CurrentRow.Cells(11).Value.ToString
        End If

        If senial = 2 Then
            Dim frmSoc2 As frmLiquidarSoc = CType(Owner, frmLiquidarSoc)
            frmSoc2.txtDesdeSoc.Text = dgvSociedades.CurrentRow.Cells(0).Value.ToString
        End If

        If senial = 3 Then
            Dim frmSoc3 As frmLiquidarSoc = CType(Owner, frmLiquidarSoc)
            frmSoc3.txtHastaSoc.Text = dgvSociedades.CurrentRow.Cells(0).Value.ToString
        End If

        If senial = 4 Then
            Dim frmSoc4 As frmCtasCtesSoc = CType(Owner, frmCtasCtesSoc)
            frmSoc4.txtSociedad.Text = dgvSociedades.CurrentRow.Cells(0).Value.ToString
            frmSoc4.txtNombSociedad.Text = dgvSociedades.CurrentRow.Cells(1).Value.ToString
        End If

        If senial = 6 Then
            Dim frmSoc6 As frmReciboB1 = CType(Owner, frmReciboB1)
            frmSoc6.txtMatSoc.Text = dgvSociedades.CurrentRow.Cells(0).Value.ToString
            frmSoc6.txtNombre.Text = dgvSociedades.CurrentRow.Cells(1).Value.ToString
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