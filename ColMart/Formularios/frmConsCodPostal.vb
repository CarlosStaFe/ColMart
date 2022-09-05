'*******************************************************************************
'* CONSULTA DE CÓDIGOS POSTALES PARA EL PROGRAMA frmColegiados                 *
'*******************************************************************************
Public Class frmConsCodPostal
    Private Sub frmConsCodPostal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comando.CommandText = "SELECT localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv, " _
                                 & "localidad.id_local, departamento.id_Dpto, provincia.id_Prov FROM localidad " _
                                 & "INNER JOIN departamento ON localidad.fk_DptoLocal   = departamento.id_Dpto " _
                                 & "INNER JOIN provincia    ON departamento.fk_ProvDpto = provincia.id_Prov ORDER BY localidad.NombreLocal"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodPos.DataSource = dt
        dgvCodPos.Columns(0).Width = 80
        dgvCodPos.Columns(0).HeaderText = "CÓDIGO"
        dgvCodPos.Columns(1).Width = 200
        dgvCodPos.Columns(0).HeaderText = "LOCALIDAD"
        dgvCodPos.Columns(2).Width = 200
        dgvCodPos.Columns(0).HeaderText = "DEPARTAMENTO"
        dgvCodPos.Columns(3).Width = 200
        dgvCodPos.Columns(0).HeaderText = "PROVINCIA"
        dgvCodPos.Columns(4).Visible = False
        dgvCodPos.Columns(5).Visible = False
        dgvCodPos.Columns(6).Visible = False

        txtLocalidad.Focus()

    End Sub

    Private Sub txtLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocalidad.KeyPress

        comando.CommandText = "SELECT localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv, " _
                                 & "localidad.id_local, departamento.id_Dpto, provincia.id_Prov FROM localidad " _
                                 & "INNER JOIN departamento On localidad.fk_DptoLocal   = departamento.id_Dpto " _
                                 & "INNER JOIN provincia    On departamento.fk_ProvDpto = provincia.id_Prov " _
                                 & "WHERE localidad.NombreLocal Like '%" & txtLocalidad.Text & "%' ORDER BY localidad.NombreLocal"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodPos.DataSource = dt

    End Sub

    Private Sub txtLocalidad_MouseHover(sender As Object, e As EventArgs) Handles txtLocalidad.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Localidad."
        ToolTipMsg.SetToolTip(txtLocalidad, "Escriba parte del nombre para encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvCodPos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCodPos.CellDoubleClick

        If senial = 1 Then
            Dim frmCol1 As frmColegiados = CType(Owner, frmColegiados)
            frmCol1.txtCodPosReal.Text = dgvCodPos.CurrentRow.Cells(0).Value.ToString
            frmCol1.lblLocalReal.Text = dgvCodPos.CurrentRow.Cells(1).Value.ToString
            frmCol1.lblDptoReal.Text = dgvCodPos.CurrentRow.Cells(2).Value.ToString
            frmCol1.lblProvReal.Text = dgvCodPos.CurrentRow.Cells(3).Value.ToString
            frmCol1.txtIdLocalRMatri.Text = dgvCodPos.CurrentRow.Cells(4).Value.ToString
            frmCol1.txtIdDptoRMatri.Text = dgvCodPos.CurrentRow.Cells(5).Value.ToString
            frmCol1.txtIdProvRMatri.Text = dgvCodPos.CurrentRow.Cells(6).Value.ToString
        End If

        If senial = 2 Then
            Dim frmCol2 As frmColegiados = CType(Owner, frmColegiados)
            frmCol2.txtCodPosLegal.Text = dgvCodPos.CurrentRow.Cells(0).Value.ToString
            frmCol2.lblLocalLegal.Text = dgvCodPos.CurrentRow.Cells(1).Value.ToString
            frmCol2.lblDptoLegal.Text = dgvCodPos.CurrentRow.Cells(2).Value.ToString
            frmCol2.lblProvLegal.Text = dgvCodPos.CurrentRow.Cells(3).Value.ToString
            frmCol2.txtIdLocalLMatri.Text = dgvCodPos.CurrentRow.Cells(4).Value.ToString
            frmCol2.txtIdDptoLMatri.Text = dgvCodPos.CurrentRow.Cells(5).Value.ToString
            frmCol2.txtIdProvLMatri.Text = dgvCodPos.CurrentRow.Cells(6).Value.ToString
        End If

        If senial = 3 Then
            Dim frmCol3 As frmListaOficio = CType(Owner, frmListaOficio)
            frmCol3.txtCodPostal.Text = dgvCodPos.CurrentRow.Cells(0).Value.ToString
            frmCol3.lblLocalReal.Text = dgvCodPos.CurrentRow.Cells(1).Value.ToString
            frmCol3.lblDptoReal.Text = dgvCodPos.CurrentRow.Cells(2).Value.ToString
            frmCol3.lblProvReal.Text = dgvCodPos.CurrentRow.Cells(3).Value.ToString
            frmCol3.txtLocal.Text = dgvCodPos.CurrentRow.Cells(4).Value.ToString
            frmCol3.txtDpto.Text = dgvCodPos.CurrentRow.Cells(5).Value.ToString
            frmCol3.txtProv.Text = dgvCodPos.CurrentRow.Cells(6).Value.ToString
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