Public Class frmConsCptosGastos
    Private Sub frmConsCptosGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CptosgastosTableAdapter.Fill(DbcolmartDataSet.cptosgastos)
        txtNombreCpto.Focus()

    End Sub

    Private Sub txtNombreCpto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCpto.KeyPress

        comando.CommandText = "SELECT * FROM cptosgastos WHERE DetalleCG LIKE '%" & txtNombreCpto.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCptosGastos.DataSource = dt

    End Sub

    Private Sub txtNombreCpto_MouseHover(sender As Object, e As EventArgs) Handles txtNombreCpto.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Detalle Débito."
        ToolTipMsg.SetToolTip(txtNombreCpto, "Ingrese el nombre del concepto que quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvCptosGastos_DoubleClick(sender As Object, e As EventArgs) Handles dgvCptosGastos.DoubleClick

        If senial = 0 Then
            Dim frmCpra0 As frmCompras = CType(Owner, frmCompras)
            frmCpra0.txtIdSRubDetCpra.Text = dgvCptosGastos.CurrentRow.Cells(0).Value.ToString
            frmCpra0.txtSRubDetCpra.Text = dgvCptosGastos.CurrentRow.Cells(1).Value.ToString
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