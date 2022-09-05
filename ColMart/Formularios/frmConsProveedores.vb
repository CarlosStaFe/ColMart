'*******************************************************************************
'* CONSULTA DE PROVEEDORES                                                     *
'*******************************************************************************
Public Class frmConsProveedores
    Private Sub frmConsProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProveedoresTableAdapter.Fill(DbcolmartDataSet.proveedores)
        txtRazonSocial.Focus()

    End Sub

    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress

        comando.CommandText = "SELECT * FROM proveedores WHERE RazonSocialProv LIKE '%" & txtRazonSocial.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvProveedores.DataSource = dt

    End Sub

    Private Sub txtRazonSocial_MouseHover(sender As Object, e As EventArgs) Handles txtRazonSocial.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Nombre."
        ToolTipMsg.SetToolTip(txtRazonSocial, "Ingrese el nombre del proveedorque quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick

        If senial = 0 Then
            Dim frmProv0 As frmProveedores = CType(Owner, frmProveedores)
            frmProv0.txtId_Prov.Text = dgvProveedores.CurrentRow.Cells(0).Value.ToString
            frmProv0.txtNroProv.Text = dgvProveedores.CurrentRow.Cells(1).Value.ToString
            frmProv0.txtRazonSocialProv.Text = dgvProveedores.CurrentRow.Cells(2).Value.ToString
            frmProv0.txtTitularProv.Text = dgvProveedores.CurrentRow.Cells(3).Value.ToString
            frmProv0.txtDomicilioProv.Text = dgvProveedores.CurrentRow.Cells(4).Value.ToString
            frmProv0.txtIdCodPosProv.Text = dgvProveedores.CurrentRow.Cells(5).Value.ToString
            frmProv0.cmbTipoIvaProv.Text = dgvProveedores.CurrentRow.Cells(6).Value.ToString
            frmProv0.txtCuitProv.Text = dgvProveedores.CurrentRow.Cells(7).Value.ToString
            frmProv0.txtTelefProv.Text = dgvProveedores.CurrentRow.Cells(8).Value.ToString
            frmProv0.txtIngBrutosProv.Text = dgvProveedores.CurrentRow.Cells(9).Value.ToString
            frmProv0.txtObsProv.Text = dgvProveedores.CurrentRow.Cells(11).Value.ToString
            frmProv0.txtEmailProv.Text = dgvProveedores.CurrentRow.Cells(12).Value.ToString
        End If
        If senial = 1 Then
            Dim frmProv1 As frmCompras = CType(Owner, frmCompras)
            frmProv1.txtId_Cpra.Text = dgvProveedores.CurrentRow.Cells(0).Value.ToString
            frmProv1.txtNroProvCpra.Text = dgvProveedores.CurrentRow.Cells(1).Value.ToString
            frmProv1.txtTitularCpra.Text = dgvProveedores.CurrentRow.Cells(2).Value.ToString
        End If
        If senial = 2 Then
            Dim frmProv2 As frmCtasCtesPro = CType(Owner, frmCtasCtesPro)
            frmProv2.txtProveedor.Text = dgvProveedores.CurrentRow.Cells(1).Value.ToString
            frmProv2.txtNombProveedor.Text = dgvProveedores.CurrentRow.Cells(2).Value.ToString
        End If
        If senial = 3 Then
            Dim frmProv3 As frmPagoCpras = CType(Owner, frmPagoCpras)
            frmProv3.txtProveedor.Text = dgvProveedores.CurrentRow.Cells(1).Value.ToString
            frmProv3.txtNombre.Text = dgvProveedores.CurrentRow.Cells(2).Value.ToString
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