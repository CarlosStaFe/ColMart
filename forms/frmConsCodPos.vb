﻿Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmConsCodPos
    Private Sub frmConsCodPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comando.CommandText = "SELECT NroCodPos AS 'CODIGO', LocalCodPos AS 'LOCALIDAD', DptoCodPos AS 'DEPARTAMENTO' , ProvCodPos AS 'PROVINCIA' FROM codpostal"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodpostal.DataSource = dt
        dgvCodpostal.Columns(0).Width = 50
        dgvCodpostal.Columns(1).Width = 150
        dgvCodpostal.Columns(2).Width = 140
        dgvCodpostal.Columns(3).Width = 140

        txtLocalidad.Focus()

    End Sub

    Private Sub txtLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocalidad.KeyPress

        comando.CommandText = "SELECT NroCodPos AS 'CODIGO', LocalCodPos AS 'LOCALIDAD', DptoCodPos AS 'DEPARTAMENTO' , ProvCodPos AS 'PROVINCIA' FROM codpostal WHERE LocalCodPos LIKE '%" & txtLocalidad.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodpostal.DataSource = dt

    End Sub

    Private Sub dgvCodpostal_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCodpostal.CellDoubleClick

        If senial = 0 Then
            Dim frm As frmCodPostal = CType(Owner, frmCodPostal)
            frm.txtNroCodPos.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frm.txtLocalCodPos.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frm.txtDptoCodPos.Text = dgvCodpostal.CurrentRow.Cells(2).Value.ToString
            frm.txtProvCodPos.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
        End If

        If senial = 1 Then
            Dim frmMat1 As frmMatriculados = CType(Owner, frmMatriculados)
            frmMat1.txtCPRealMatri.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frmMat1.txtLocalReal.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frmMat1.txtProvReal.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
        End If

        If senial = 2 Then
            Dim frmMat2 As frmMatriculados = CType(Owner, frmMatriculados)
            frmMat2.txtCPLegalMatri.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frmMat2.txtLocalLegal.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frmMat2.txtProvLegal.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
        End If

        If senial = 3 Then
            Dim frmSoc0 As frmSociedades = CType(Owner, frmSociedades)
            frmSoc0.txtCodPosSociedad.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frmSoc0.txtLocalSociedad.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frmSoc0.txtDptoSociedad.Text = dgvCodpostal.CurrentRow.Cells(2).Value.ToString
            frmSoc0.txtProvSociedad.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
        End If

        Me.Close()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub

End Class