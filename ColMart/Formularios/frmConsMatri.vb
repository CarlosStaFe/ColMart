'*******************************************************************************
'* CONSULTA DE MATRICULADOS                                                    *
'*******************************************************************************
Public Class frmConsMatri
    Private Sub frmConsMatri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MatriculadosTableAdapter.Fill(DbcolmartDataSet.matriculados)

        txtApellido.Focus()

    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress

        comando.CommandText = "SELECT * FROM matriculados WHERE ApelNombMatri LIKE '%" & txtApellido.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvMatriculados.DataSource = dt

    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Apellido."
        ToolTipMsg.SetToolTip(txtApellido, "Ingrese el apellido que quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvMatriculados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMatriculados.CellDoubleClick

        'If senial = 0 Then
        '    Dim frmMat As frmMatriculados = CType(Owner, frmMatriculados)
        '    frmMat.txtId_Matri.Text = dgvMatriculados.CurrentRow.Cells(0).Value.ToString
        '    frmMat.txtNroMatri.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
        '    frmMat.txtApelNombMatri.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
        '    frmMat.txtApelMatMatri.Text = dgvMatriculados.CurrentRow.Cells(3).Value.ToString
        '    fecha = dgvMatriculados.CurrentRow.Cells(4).Value.ToString
        '    ProcesarFecha()
        '    frmMat.txtFecNacMatri.Text = fechaaux
        '    frmMat.txtLugarNacMatri.Text = dgvMatriculados.CurrentRow.Cells(5).Value.ToString
        '    frmMat.txtNacionNacMatri.Text = dgvMatriculados.CurrentRow.Cells(6).Value.ToString
        '    frmMat.cmbTipoDocMatri.Text = dgvMatriculados.CurrentRow.Cells(7).Value.ToString
        '    frmMat.txtNroDocMatri.Text = dgvMatriculados.CurrentRow.Cells(8).Value.ToString
        '    frmMat.cmbSexoMatri.Text = dgvMatriculados.CurrentRow.Cells(9).Value.ToString
        '    frmMat.cmbEstCivilMatri.Text = dgvMatriculados.CurrentRow.Cells(10).Value.ToString
        '    frmMat.txtCuitMatri.Text = dgvMatriculados.CurrentRow.Cells(11).Value.ToString
        '    fecha = dgvMatriculados.CurrentRow.Cells(12).Value.ToString
        '    ProcesarFecha()
        '    frmMat.txtFecJurMatri.Text = fechaaux
        '    frmMat.cmbCatAporteMatri.Text = dgvMatriculados.CurrentRow.Cells(13).Value.ToString
        '    frmMat.cmbEstadoMatri.Text = dgvMatriculados.CurrentRow.Cells(14).Value.ToString
        '    fecha = dgvMatriculados.CurrentRow.Cells(15).Value.ToString
        '    ProcesarFecha()
        '    frmMat.txtFecEstadoMatri.Text = fechaaux
        '    frmMat.txtCalleRealMatri.Text = dgvMatriculados.CurrentRow.Cells(16).Value.ToString
        '    frmMat.txtCPRealMatri.Text = dgvMatriculados.CurrentRow.Cells(17).Value.ToString
        '    frmMat.txtEmailMatri.Text = dgvMatriculados.CurrentRow.Cells(18).Value.ToString
        '    frmMat.txtCeluRealMatri.Text = dgvMatriculados.CurrentRow.Cells(19).Value.ToString
        '    frmMat.txtFijoRealMatri.Text = dgvMatriculados.CurrentRow.Cells(20).Value.ToString
        '    frmMat.txtCalleLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(21).Value.ToString
        '    frmMat.txtCPLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(22).Value.ToString
        '    frmMat.txtCeluLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(23).Value.ToString
        '    frmMat.txtFijoLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(24).Value.ToString
        '    fecha = dgvMatriculados.CurrentRow.Cells(25).Value.ToString
        '    ProcesarFecha()
        '    frmMat.txtFianzaMatri.Text = fechaaux
        '    frmMat.txtDocFiadorMatri.Text = dgvMatriculados.CurrentRow.Cells(26).Value.ToString
        '    frmMat.txtFiadorMatri.Text = dgvMatriculados.CurrentRow.Cells(27).Value.ToString
        '    frmMat.txtCalleFiadorMatri.Text = dgvMatriculados.CurrentRow.Cells(28).Value.ToString
        '    frmMat.txtObsMatri.Text = dgvMatriculados.CurrentRow.Cells(29).Value.ToString
        'End If

        If senial = 1 Then
            Dim frmDeb As frmCargarDebMat = CType(Owner, frmCargarDebMat)
            frmDeb.txtMatricula.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmDeb.txtApelNombre.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
        End If

        If senial = 2 Then
            Dim frmMat2 As frmLiquidarMat = CType(Owner, frmLiquidarMat)
            frmMat2.txtDesdeMat.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
        End If

        If senial = 3 Then
            Dim frmMat3 As frmLiquidarMat = CType(Owner, frmLiquidarMat)
            frmMat3.txtHastaMat.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
        End If

        If senial = 5 Then
            Dim frmMat5 As frmEnviarMail = CType(Owner, frmEnviarMail)
            frmMat5.txtDesdeMat.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
        End If

        If senial = 6 Then
            Dim frmMat6 As frmEnviarMail = CType(Owner, frmEnviarMail)
            frmMat6.txtHastaMat.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
        End If

        If senial = 7 Then
            Dim frmMat7 As frmCtasCtesMat = CType(Owner, frmCtasCtesMat)
            frmMat7.txtMatricula.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat7.txtApelyNomb.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
        End If

        If senial = 8 Then
            Dim frmMat8 As frmReciboB1 = CType(Owner, frmReciboB1)
            frmMat8.txtMatSoc.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat8.txtNombre.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
        End If

        If senial = 9 Then
            Dim frmMat9 As frmListaOficio = CType(Owner, frmListaOficio)
            frmMat9.txtMatricula.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat9.txtApelNomb.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
            frmMat9.txtCuit.Text = dgvMatriculados.CurrentRow.Cells(11).Value.ToString
            frmMat9.txtDomicilio.Text = dgvMatriculados.CurrentRow.Cells(16).Value.ToString
            frmMat9.txtCodPostal.Text = dgvMatriculados.CurrentRow.Cells(17).Value.ToString
            frmMat9.txtEmail.Text = dgvMatriculados.CurrentRow.Cells(18).Value.ToString
            frmMat9.txtCelular.Text = dgvMatriculados.CurrentRow.Cells(19).Value.ToString
            frmMat9.txtTelFijo.Text = dgvMatriculados.CurrentRow.Cells(20).Value.ToString
        End If

        If senial = 10 Then
            Dim frmMat10 As frmReciboGral = CType(Owner, frmReciboGral)
            frmMat10.txtMatSoc.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat10.txtNombre.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
            frmMat10.txtTelefono.Text = dgvMatriculados.CurrentRow.Cells(22).Value.ToString + dgvMatriculados.CurrentRow.Cells(23).Value.ToString
        End If

        If senial = 11 Then
            Dim frmMat11 As frmListaSaldoPago = CType(Owner, frmListaSaldoPago)
            frmMat11.txtNroMatri.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat11.txtNombreMatri.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
        End If

        If senial = 12 Then
            Dim frmMat12 As frmFianzas = CType(Owner, frmFianzas)
            frmMat12.txtMatricula.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat12.txtApelNombre.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
        End If

        If senial = 13 Then
            Dim frmCol13 As frmColegiados = CType(Owner, frmColegiados)
            frmCol13.txtNroMatri.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
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