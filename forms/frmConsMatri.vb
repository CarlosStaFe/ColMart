Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmConsMatri

    Dim fecha, fechaaux, dd, mm, yyyy As String
    Dim posicion1, posicion2 As Integer
    Dim numero As Integer

    Private Sub frmConsMatri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.matriculados' Puede moverla o quitarla según sea necesario.
        Me.MatriculadosTableAdapter.Fill(Me.DbcolmartDataSet.matriculados)

        txtApellido.Focus()

    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress

        comando.CommandText = "SELECT * FROM matriculados WHERE ApelNombMatri LIKE '%" & txtApellido.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvMatriculados.DataSource = dt

    End Sub

    Private Sub dgvMatriculados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMatriculados.CellDoubleClick

        If senial = 0 Then
            Dim frmMat As frmMatriculados = CType(Owner, frmMatriculados)
            frmMat.txtId_Matri.Text = dgvMatriculados.CurrentRow.Cells(0).Value.ToString
            frmMat.txtNroMatri.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat.txtApelNombMatri.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
            frmMat.txtApelMatMatri.Text = dgvMatriculados.CurrentRow.Cells(3).Value.ToString
            fecha = dgvMatriculados.CurrentRow.Cells(4).Value.ToString
            ProcesarFecha()
            frmMat.txtFecNacMatri.Text = fechaaux
            frmMat.txtLugarNacMatri.Text = dgvMatriculados.CurrentRow.Cells(5).Value.ToString
            frmMat.txtNacionNacMatri.Text = dgvMatriculados.CurrentRow.Cells(6).Value.ToString
            frmMat.cmbTipoDocMatri.Text = dgvMatriculados.CurrentRow.Cells(7).Value.ToString
            frmMat.txtNroDocMatri.Text = dgvMatriculados.CurrentRow.Cells(8).Value.ToString
            frmMat.cmbSexoMatri.Text = dgvMatriculados.CurrentRow.Cells(9).Value.ToString
            frmMat.cmbEstCivilMatri.Text = dgvMatriculados.CurrentRow.Cells(10).Value.ToString
            frmMat.txtCuitMatri.Text = dgvMatriculados.CurrentRow.Cells(11).Value.ToString
            fecha = dgvMatriculados.CurrentRow.Cells(12).Value.ToString
            ProcesarFecha()
            frmMat.txtFecJurMatri.Text = fechaaux
            frmMat.cmbCatAporteMatri.Text = dgvMatriculados.CurrentRow.Cells(13).Value.ToString
            frmMat.cmbEstadoMatri.Text = dgvMatriculados.CurrentRow.Cells(14).Value.ToString
            fecha = dgvMatriculados.CurrentRow.Cells(15).Value.ToString
            ProcesarFecha()
            frmMat.txtFecEstadoMatri.Text = fechaaux
            frmMat.txtCalleRealMatri.Text = dgvMatriculados.CurrentRow.Cells(16).Value.ToString
            frmMat.txtCPRealMatri.Text = dgvMatriculados.CurrentRow.Cells(17).Value.ToString
            frmMat.txtEmailMatri.Text = dgvMatriculados.CurrentRow.Cells(18).Value.ToString
            frmMat.txtCeluRealMatri.Text = dgvMatriculados.CurrentRow.Cells(19).Value.ToString
            frmMat.txtFijoRealMatri.Text = dgvMatriculados.CurrentRow.Cells(20).Value.ToString
            frmMat.txtCalleLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(21).Value.ToString
            frmMat.txtCPLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(22).Value.ToString
            frmMat.txtCeluLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(23).Value.ToString
            frmMat.txtFijoLegalMatri.Text = dgvMatriculados.CurrentRow.Cells(24).Value.ToString
            fecha = dgvMatriculados.CurrentRow.Cells(25).Value.ToString
            ProcesarFecha()
            frmMat.txtFianzaMatri.Text = fechaaux
            frmMat.txtDocFiadorMatri.Text = dgvMatriculados.CurrentRow.Cells(26).Value.ToString
            frmMat.txtFiadorMatri.Text = dgvMatriculados.CurrentRow.Cells(27).Value.ToString
            frmMat.txtCalleFiadorMatri.Text = dgvMatriculados.CurrentRow.Cells(28).Value.ToString
            frmMat.txtObsMatri.Text = dgvMatriculados.CurrentRow.Cells(29).Value.ToString
        End If

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

        If senial = 4 Then
            Dim frmMat4 As frmBoletasSoc = CType(Owner, frmBoletasSoc)
            frmMat4.txtSociedad.Text = dgvMatriculados.CurrentRow.Cells(1).Value.ToString
            frmMat4.txtNombre.Text = dgvMatriculados.CurrentRow.Cells(2).Value.ToString
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
            Dim frmMat8 As frmReciboPago = CType(Owner, frmReciboPago)
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
        End If

        Close()

    End Sub

    Private Sub LlenarDGVini()

        comando = New MySqlCommand("SELECT * FROM matriculados", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                fecha = dr(4).ToString
                posicion1 = InStr(1, fecha, "/")
                posicion2 = InStr(posicion1 + 1, fecha, "/")
                dd = Mid(fecha, 1, posicion1 - 1)
                mm = Mid(fecha, posicion1 + 1, ((posicion2 - 1) - posicion1))
                yyyy = Mid(fecha, posicion2 + 1, 4)
                fecha = dd & "/" & mm & "/" & yyyy
                dgvMatriculados.Rows.Add(dr(0).ToString, dr(1).ToString, dr(2).ToString, fecha, dr(7).ToString, dr(8).ToString, dr(9).ToString, dr(13).ToString)
            End While
        End If

        dr.Close()

    End Sub

    Private Sub LlenarDGVotro()

        comando = New MySqlCommand("SELECT * FROM matriculados WHERE ApelNombMatri LIKE '%" & txtApellido.Text & "%'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                fecha = dr(4).ToString
                posicion1 = InStr(1, fecha, "/")
                posicion2 = InStr(posicion1 + 1, fecha, "/")
                dd = Mid(fecha, 1, posicion1 - 1)
                mm = Mid(fecha, posicion1 + 1, ((posicion2 - 1) - posicion1))
                yyyy = Mid(fecha, posicion2 + 1, 4)
                fecha = dd & "/" & mm & "/" & yyyy
                dgvMatriculados.Rows.Add(dr(0).ToString, dr(1).ToString, dr(2).ToString, fecha, dr(7).ToString, dr(8).ToString, dr(9).ToString, dr(13).ToString)
            End While
        End If

        dr.Close()

    End Sub

    Private Sub ProcesarFecha()
        fechaaux = fecha
        posicion1 = InStr(1, fechaaux, "/")
        posicion2 = InStr(posicion1 + 1, fechaaux, "/")
        If posicion1 > 0 Then
            dd = Mid(fecha, 1, posicion1 - 1)
            mm = Mid(fecha, posicion1 + 1, ((posicion2 - 1) - posicion1))
            yyyy = Mid(fecha, posicion2 + 1, 4)
        Else
            dd = Mid(fechaaux, 7, 2)
            mm = Mid(fechaaux, 5, 2)
            yyyy = Mid(fechaaux, 1, 4)
        End If
        fechaaux = dd & "/" & mm & "/" + yyyy

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub


End Class