'*******************************************************************************
'* ACTUALIZA LOS DATOS DE LOS MARTILLEROS                                      *
'*******************************************************************************
Imports System.Drawing

Public Class frmColegiados
    Dim dd, mm, yyyy, fechaaux, fechavenc, estadoant As String
    Dim pos1, pos2, codigoreal, codigolegal, idcodpostal, meses As Integer
    Dim fecha1, fecha2 As Date

    Private Sub frmColegiados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        MatriculadosTableAdapter.Fill(DbcolmartDataSet.matriculados)
        LeerCodPos()
        MostrarFianza()
        BtnGrabar.Visible = False
        MostrarFecha()
        txtNroMatri.Focus()

        If nivel > 5 Then
            btnSinMatricula.Enabled = False
            btnCambiar.Enabled = False
            BtnAgregar.Enabled = False
            BtnEliminar.Enabled = False
            BtnGrabar.Enabled = False
            BtnModificar.Enabled = False
        End If

        If nivel < 4 Then
            btnLimpiar.Enabled = True
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        MatriculadosBindingSource.AddNew()
        MatriculaNueva()
        MostrarFianza()
        txtNroMatri.Show()
        txtApelNombMatri.Focus()

        BtnAgregar.Visible = False
        BtnGrabar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        BtnPrimer.Visible = False
        BtnAnterior.Visible = False
        BtnSiguiente.Visible = False
        BtnUltimo.Visible = False

        txtCodPosReal.Text = 0
        lblLocalReal.Text = ""
        lblDptoReal.Text = ""
        lblProvReal.Text = ""
        txtCodPosLegal.Text = 0
        lblLocalLegal.Text = ""
        lblDptoLegal.Text = ""
        lblProvLegal.Text = ""


        cmbTipoDocMatri.SelectedIndex = 0
        cmbEstadoMatri.SelectedIndex = 0
        cmbSexoMatri.SelectedIndex = 0
        cmbCatAporteMatri.SelectedIndex = 0

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                txtDocFiadorMatri.Text = ""
                txtFiadorMatri.Text = ""
                txtCalleFiadorMatri.Text = ""
                txtTelFiadorMatri.Text = ""
                txtFianzaMatri.Text = "1900/01/01"
                InvertirFecha()
                MatriculadosBindingSource.EndEdit()
                MatriculadosTableAdapter.Update(DbcolmartDataSet.matriculados)
                CorregirBoletas()
                detmsg = "Registro guardado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            detmsg = "Grabación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        Actualizar()

        txtNroMatri.Focus()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            InvertirFecha()
            comando = New MySqlCommand("UPDATE matriculados SET NroMatri = '" & txtNroMatri.Text & "', ApelNombMatri = '" & txtApelNombMatri.Text & "', ApelMatMatri = '" & txtApelMatMatri.Text & "', " _
                                    & "FecNacMatri = '" & txtFecNacMatri.Text & "', LugarNacMatri = '" & txtLugarNacMatri.Text & "', NacionNacMatri = '" & txtNacionNacMatri.Text & "', " _
                                    & "TipoDocMatri = '" & cmbTipoDocMatri.Text & "', NroDocMatri = '" & txtNroDocMatri.Text & "', SexoMatri = '" & cmbSexoMatri.Text & "', EstCivilMatri = '" & cmbEstCivilMatri.Text & "', " _
                                    & "CuitMatri = '" & txtCuitMatri.Text & "', FecJurMatri = '" & txtFecJurMatri.Text & "', CatAporteMatri = '" & cmbCatAporteMatri.Text & "', " _
                                    & "EstadoMatri = '" & cmbEstadoMatri.Text & "', FecEstadoMatri = '" & txtFecEstadoMatri.Text & "', CalleRealMatri = '" & txtCalleRealMatri.Text & "', " _
                                    & "IdLocalRMatri = '" & txtIdLocalRMatri.Text & "', IdDptoRMatri = '" & txtIdDptoRMatri.Text & "', IdProvRMatri = '" & txtIdProvRMatri.Text & "', " _
                                    & "EmailMatri = '" & txtEmailMatri.Text & "', CeluRealMatri = '" & txtCeluRealMatri.Text & "', FijoRealMatri = '" & txtFijoRealMatri.Text & "', CalleLegalMatri = '" & txtCalleLegalMatri.Text & "', " _
                                    & "IdLocalLMatri = '" & txtIdLocalLMatri.Text & "', IdDptoLMatri = '" & txtIdDptoLMatri.Text & "', IdProvLMatri = '" & txtIdProvLMatri.Text & "'," _
                                    & "CeluLegalMatri = '" & txtCeluLegalMatri.Text & "', FijoLegalMatri = '" & txtFijoLegalMatri.Text & "', FianzaMatri = '" & txtFianzaMatri.Text & "', " _
                                    & "DocFiadorMatri = '" & txtDocFiadorMatri.Text & "', FiadorMatri = '" & txtFiadorMatri.Text & "', CalleFiadorMatri = '" & txtCalleFiadorMatri.Text & "', " _
                                    & "TelFiadorMatri = '" & txtTelFiadorMatri.Text & "', ObsMatri = '" & txtObsMatri.Text & "', TomoMatri = '" & txtTomoMatri.Text & "', FolioMatri = '" & txtFolioMatri.Text & "' " _
                                    & "WHERE id_Matri = " & txtId_Matri.Text & " And  NroMatri = " & txtNroMatri.Text & "", conexion)
            comando.ExecuteNonQuery()
            CorregirBoletas()
            detmsg = "Registro actualizado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Edición cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        MatriculadosTableAdapter.Fill(DbcolmartDataSet.matriculados)
        LeerCodPos()
        MostrarFecha()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM matriculados WHERE id_Matri = " & txtId_Matri.Text & " And  NroMatri = " & txtNroMatri.Text & ""), conexion)
            comando.ExecuteNonQuery()
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        MatriculadosTableAdapter.Fill(DbcolmartDataSet.matriculados)
        LeerCodPos()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 13
        Dim frmCol13 As New frmConsMatri
        AddOwnedForm(frmCol13)
        frmCol13.ShowDialog()
        LeerMatriculado()
        LeerCodPos()
        MostrarFecha()
        senial = 0

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Actualizar()

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        MatriculadosBindingSource.MoveFirst()
        MostrarFecha()
        LeerCodPos()
        MostrarFianza()

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        MatriculadosBindingSource.MovePrevious()
        MostrarFecha()
        LeerCodPos()
        MostrarFianza()

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        MatriculadosBindingSource.MoveNext()
        MostrarFecha()
        LeerCodPos()
        MostrarFianza()

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        MatriculadosBindingSource.MoveLast()
        MostrarFecha()
        LeerCodPos()
        MostrarFianza()

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        comando.CommandText = "UPDATE matriculados SET FianzaMatri = '1900-01-01', DocFiadorMatri = '', FiadorMatri = '', CalleFiadorMatri = '', TelFiadorMatri = '' " _
                                & " WHERE id_Matri = " & txtId_Matri.Text & " And  NroMatri = " & txtNroMatri.Text & " "
        comando.ExecuteNonQuery()

        Actualizar()

    End Sub


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSinMatricula_Click(sender As Object, e As EventArgs) Handles btnSinMatricula.Click

        MatriculadosBindingSource.AddNew()
        SinMatricula()
        MostrarFianza()
        txtNroMatri.Show()
        txtApelNombMatri.Focus()

        BtnAgregar.Visible = False
        BtnGrabar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        BtnPrimer.Visible = False
        BtnAnterior.Visible = False
        BtnSiguiente.Visible = False
        BtnUltimo.Visible = False

        txtCodPosReal.Text = 0
        lblLocalReal.Text = ""
        lblDptoReal.Text = ""
        lblProvReal.Text = ""
        txtCodPosLegal.Text = 0
        lblLocalLegal.Text = ""
        lblDptoLegal.Text = ""
        lblProvLegal.Text = ""

        cmbTipoDocMatri.SelectedIndex = 0
        cmbEstadoMatri.SelectedIndex = 0
        cmbSexoMatri.SelectedIndex = 0
        cmbCatAporteMatri.SelectedIndex = 0

    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click

        If txtNroMatri.Text > "79000" And txtNroMatri.Text < "90000" Then
            lblMatricula.Visible = True
            txtNuevaMatricula.Visible = True
            senial = 1
            MatriculaNueva()
            senial = 0

            detmsg = "DESEA MODIFICAR ESTE NÚMERO DE MATRICULADO...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                ModificarMatricula()
            End If

        Else
            detmsg = "NO SE PERMITE CAMBIAR EL NÚMERO A ESTE MATRICULADO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        lblMatricula.Visible = False
        txtNuevaMatricula.Visible = False

        Actualizar()

    End Sub

    Private Sub txtNroMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroMatri.KeyDown

        '***BUSCO EL MATRICULADO CON F1***
        If e.KeyCode = Keys.F1 Then
            senial = 13
            Dim frmCol13 As New frmConsMatri
            AddOwnedForm(frmCol13)
            frmCol13.ShowDialog()
            LeerMatriculado()
            LeerCodPos()
            MostrarFecha()
            senial = 0
            txtApelNombMatri.Focus()
        End If

        '***BUSCO EL MATRICULADO POR EL NRO DE MATRÍCULA***
        If e.KeyCode = Keys.Enter Then
            LeerMatriculado()
            LeerCodPos()
            txtApelNombMatri.Focus()
            If senial = 1 Then
                Actualizar()
                txtNroMatri.Focus()
                senial = 0
            End If
        End If

    End Sub

    Private Sub txtCodPosReal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPosReal.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmCol1 As New frmConsCodPostal
            AddOwnedForm(frmCol1)
            frmCol1.ShowDialog()
            txtCeluRealMatri.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            senial = 1
            BuscarCodPos()
            txtCodPosReal.Focus()
        End If

    End Sub

    Private Sub txtCodPosLegal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPosLegal.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmCol2 As New frmConsCodPostal
            AddOwnedForm(frmCol2)
            frmCol2.ShowDialog()
            txtCeluLegalMatri.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            senial = 2
            BuscarCodPos()
            txtCodPosLegal.Focus()
        End If

    End Sub

    Private Sub txtFecNacMatri_Leave(sender As Object, e As EventArgs) Handles txtFecNacMatri.Leave

        fechajob = txtFecNacMatri.Text
        ControlFecha(fechajob)
        If senial = 1 Then
            txtFecNacMatri.Text = ""
            txtFecNacMatri.Focus()
        Else
            MatriculadosBindingSource.Current("FecNacMatri") = txtFecNacMatri.Text
            txtLugarNacMatri.Focus()
        End If
        senial = 0

    End Sub

    Private Sub txtFecJurMatri_Leave(sender As Object, e As EventArgs) Handles txtFecJurMatri.Leave

        fechajob = txtFecJurMatri.Text
        ControlFecha(fechajob)
        If senial = 1 Then
            txtFecJurMatri.Text = ""
            txtFecJurMatri.Focus()
        Else
            MatriculadosBindingSource.Current("FecJurMatri") = txtFecJurMatri.Text
            cmbCatAporteMatri.Focus()
        End If
        senial = 0

    End Sub

    Private Sub txtFecEstadoMatri_Leave(sender As Object, e As EventArgs) Handles txtFecEstadoMatri.Leave

        fechajob = txtFecEstadoMatri.Text
        ControlFecha(fechajob)
        If senial = 1 Then
            txtFecEstadoMatri.Text = ""
            txtFecEstadoMatri.Focus()
        Else
            MatriculadosBindingSource.Current("FecEstadoMatri") = txtFecEstadoMatri.Text
            txtEmailMatri.Focus()
        End If
        senial = 0

    End Sub

    Private Sub cmbEstadoMatri_Leave(sender As Object, e As EventArgs) Handles cmbEstadoMatri.Leave

        If estadoant <> cmbEstadoMatri.Text Then
            txtFecEstadoMatri.Text = Today.Date.ToString("dd/MM/yyyy")
        End If

    End Sub

    Private Sub LeerMatriculado()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = " & txtNroMatri.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            CargarMatriculado()
            LeerCodPos()
        Else
            detmsg = "Matrícula no Existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        End If

    End Sub

    Private Sub CargarMatriculado()

        Dim row As DataRow = dt.Rows(0)

        txtId_Matri.Text = CStr(row("id_Matri"))
        txtNroMatri.Text = CStr(row("NroMatri"))
        txtApelNombMatri.Text = CStr(row("ApelNombMatri"))
        txtApelMatMatri.Text = CStr(row("ApelMatMatri"))
        txtFecNacMatri.Text = CStr(row("FecNacMatri"))
        txtLugarNacMatri.Text = CStr(row("LugarNacMatri"))
        txtNacionNacMatri.Text = CStr(row("NacionNacMatri"))
        cmbTipoDocMatri.Text = CStr(row("TipoDocMatri"))
        txtNroDocMatri.Text = CStr(row("NroDocMatri"))
        cmbSexoMatri.Text = CStr(row("SexoMatri"))
        cmbEstCivilMatri.Text = CStr(row("EstCivilMatri"))
        txtCuitMatri.Text = CStr(row("CuitMatri"))
        txtFecJurMatri.Text = CStr(row("FecJurMatri"))
        cmbCatAporteMatri.Text = CStr(row("CatAporteMatri"))
        cmbEstadoMatri.Text = CStr(row("EstadoMatri"))
        estadoant = CStr(row("EstadoMatri"))
        txtFecEstadoMatri.Text = CStr(row("FecEstadoMatri"))
        txtCalleRealMatri.Text = CStr(row("CalleRealMatri"))
        idcodpostal = CStr(row("idLocalRMatri"))
        txtIdLocalRMatri.Text = CStr(row("idLocalRMatri"))
        txtIdDptoRMatri.Text = CStr(row("idDptoRMatri"))
        txtIdProvRMatri.Text = CStr(row("idProvRMatri"))
        LeerCodPos()

        txtEmailMatri.Text = CStr(row("EmailMatri"))
        txtCeluRealMatri.Text = CStr(row("CeluRealMatri"))
        txtFijoRealMatri.Text = CStr(row("FijoRealMatri"))
        txtCalleLegalMatri.Text = CStr(row("CalleLegalMatri"))
        idcodpostal = CStr(row("idLocalLMatri"))
        txtIdLocalLMatri.Text = CStr(row("idLocalLMatri"))
        txtIdDptoLMatri.Text = CStr(row("idDptoLMatri"))
        txtIdProvLMatri.Text = CStr(row("idProvLMatri"))
        LeerCodPos()

        txtCeluLegalMatri.Text = CStr(row("CeluLegalMatri"))
        txtFijoLegalMatri.Text = CStr(row("FijoLegalMatri"))
        txtFianzaMatri.Text = CStr(row("FianzaMatri"))
        txtDocFiadorMatri.Text = CStr(row("DocFiadorMatri"))
        txtFiadorMatri.Text = CStr(row("FiadorMatri"))
        txtCalleFiadorMatri.Text = CStr(row("CalleFiadorMatri"))
        txtTelFiadorMatri.Text = CStr(row("TelFiadorMatri"))
        lblFianzaMatri.Text = CStr(row("FianzaMatri"))
        lblDocFiadorMatri.Text = CStr(row("DocFiadorMatri"))
        lblFiadorMatri.Text = CStr(row("FiadorMatri"))
        lblCalleFiadorMatri.Text = CStr(row("CalleFiadorMatri"))
        lblTelFiadorMatri.Text = CStr(row("TelFiadorMatri"))
        lblFianzaMatri.Visible = True
        lblDocFiadorMatri.Visible = True
        lblFiadorMatri.Visible = True
        lblCalleFiadorMatri.Visible = True
        lblTelFiadorMatri.Visible = True
        txtObsMatri.Text = CStr(row("ObsMatri"))
        txtTomoMatri.Text = CStr(row("TomoMatri"))
        txtFolioMatri.Text = CStr(row("FolioMatri"))

        MostrarFecha()

    End Sub

    Private Sub MostrarFianza()

        lblFianzaMatri.Text = txtFianzaMatri.Text
        lblDocFiadorMatri.Text = txtDocFiadorMatri.Text
        lblFiadorMatri.Text = txtFiadorMatri.Text
        lblCalleFiadorMatri.Text = txtCalleFiadorMatri.Text
        lblTelFiadorMatri.Text = txtTelFiadorMatri.Text
        lblFianzaMatri.Visible = True
        lblDocFiadorMatri.Visible = True
        lblFiadorMatri.Visible = True
        lblCalleFiadorMatri.Visible = True
        lblTelFiadorMatri.Visible = True

    End Sub

    Private Sub LeerCodPos()

        '***BUSCAMOS EL CÓDIGO POSTAL REAL***
        Try
            comando.CommandText = "SELECT matriculados.idLocalRMatri, localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv FROM matriculados " _
                                   & "INNER JOIN localidad    ON matriculados.idLocalRMatri = localidad.id_Local " _
                                   & "INNER JOIN departamento ON localidad.fk_DptoLocal     = departamento.id_Dpto " _
                                   & "INNER JOIN provincia    ON departamento.fk_ProvDpto   = provincia.id_Prov " _
                                   & "WHERE matriculados.NroMatri = '" & txtNroMatri.Text & "' "
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtCodPosReal.Text = Val(CStr(row("CodPosLocal")))
                lblLocalReal.Text = CStr(row("NombreLocal"))
                lblDptoReal.Text = CStr(row("NombreDpto"))
                lblProvReal.Text = CStr(row("NombreProv"))
            Else
                txtCodPosReal.Text = 0
                lblLocalReal.Text = ""
                lblDptoReal.Text = ""
                lblProvReal.Text = ""
            End If
            lblLocalReal.Visible = True
            lblDptoReal.Visible = True
            lblProvReal.Visible = True

            '***BUSCAMOS EL CÓDIGO POSTAL LEGAL***
            comando.CommandText = "SELECT matriculados.idLocalLMatri, localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv FROM matriculados " _
                                   & "INNER JOIN localidad    ON matriculados.idLocalLMatri = localidad.id_Local " _
                                   & "INNER JOIN departamento ON localidad.fk_DptoLocal     = departamento.id_Dpto " _
                                   & "INNER JOIN provincia    ON departamento.fk_ProvDpto   = provincia.id_Prov " _
                                   & "WHERE matriculados.NroMatri = '" & txtNroMatri.Text & "' "
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtCodPosLegal.Text = Val(CStr(row("CodPosLocal")))
                lblLocalLegal.Text = CStr(row("NombreLocal"))
                lblDptoLegal.Text = CStr(row("NombreDpto"))
                lblProvLegal.Text = CStr(row("NombreProv"))
            Else
                txtCodPosLegal.Text = 0
                lblLocalLegal.Text = ""
                lblDptoLegal.Text = ""
                lblProvLegal.Text = ""
            End If
            lblLocalLegal.Visible = True
            lblDptoLegal.Visible = True
            lblProvLegal.Visible = True

        Catch ex As Exception
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub BuscarCodPos()

        '***BUSCAMOS EL CÓDIGO POSTAL POR CÓDIGO***
        If senial = 1 Then
            comando.CommandText = "SELECT localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv, localidad.id_Local, departamento.id_Dpto, provincia.id_Prov FROM localidad " _
                                   & "INNER JOIN departamento ON localidad.fk_DptoLocal     = departamento.id_Dpto " _
                                   & "INNER JOIN provincia    ON departamento.fk_ProvDpto   = provincia.id_Prov " _
                                   & "WHERE localidad.CodPosLocal = '" & txtCodPosReal.Text & "' "
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtCodPosReal.Text = Val(CStr(row("CodPosLocal")))
                lblLocalReal.Text = CStr(row("NombreLocal"))
                lblDptoReal.Text = CStr(row("NombreDpto"))
                lblProvReal.Text = CStr(row("NombreProv"))
                txtIdLocalRMatri.Text = CStr(row("id_Local"))
                txtIdDptoRMatri.Text = CStr(row("id_Dpto"))
                txtIdProvRMatri.Text = CStr(row("id_Prov"))
            Else
                txtCodPosReal.Text = 0
                lblLocalReal.Text = ""
                lblDptoReal.Text = ""
                lblProvReal.Text = ""
            End If
            lblLocalReal.Visible = True
            lblDptoReal.Visible = True
            lblProvReal.Visible = True
        End If

        If senial = 2 Then
            comando.CommandText = "SELECT localidad.CodPosLocal, localidad.NombreLocal, departamento.NombreDpto, provincia.NombreProv, localidad.id_Local, departamento.id_Dpto, provincia.id_Prov FROM localidad " _
                                   & "INNER JOIN departamento ON localidad.fk_DptoLocal     = departamento.id_Dpto " _
                                   & "INNER JOIN provincia    ON departamento.fk_ProvDpto   = provincia.id_Prov " _
                                   & "WHERE localidad.CodPosLocal = '" & txtCodPosLegal.Text & "' "
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtCodPosLegal.Text = Val(CStr(row("CodPosLocal")))
                lblLocalLegal.Text = CStr(row("NombreLocal"))
                lblDptoLegal.Text = CStr(row("NombreDpto"))
                lblProvLegal.Text = CStr(row("NombreProv"))
                txtIdLocalLMatri.Text = CStr(row("id_Local"))
                txtIdDptoLMatri.Text = CStr(row("id_Dpto"))
                txtIdProvLMatri.Text = CStr(row("id_Prov"))
            Else
                txtCodPosLegal.Text = 0
                lblLocalLegal.Text = ""
                lblDptoLegal.Text = ""
                lblProvLegal.Text = ""
            End If
            lblLocalLegal.Visible = True
            lblDptoLegal.Visible = True
            lblProvLegal.Visible = True
        End If

        senial = 0

    End Sub

    Private Sub MostrarFecha()

        fechajob = ""
        '-----Fecha Nacimiento
        fechajob = txtFecNacMatri.Text
        ProcesarFecha()
        txtFecNacMatri.Text = fechajob
        txtFecNacMatri.Show()
        '-----Fecha Juramento
        fechajob = txtFecJurMatri.Text
        ProcesarFecha()
        txtFecJurMatri.Text = fechajob
        txtFecJurMatri.Show()
        '-----Fecha Estado
        fechajob = txtFecEstadoMatri.Text
        ProcesarFecha()
        txtFecEstadoMatri.Text = fechajob
        txtFecEstadoMatri.Show()
        '-----Fecha Fianza
        fechajob = txtFianzaMatri.Text
        ProcesarFecha()
        txtFianzaMatri.Text = fechajob
        txtFianzaMatri.Show()
        '-----Fecha Vence Fianza
        meses = 24
        fechajob = DateAdd("m", meses, txtFianzaMatri.Text)
        ProcesarFecha()
        lblVenceFianza.Text = fechajob
        fechaaux = Format(Now, "dd/MM/yyyy")

        fecha1 = CDate(fechajob)
        fecha2 = CDate(fechaaux)
        If fecha1 < fecha2 Then
            lblVenceFianza.ForeColor = Color.Red
        Else
            lblVenceFianza.ForeColor = Color.Lime
        End If

    End Sub

    Private Sub InvertirFecha()

        fechajob = ""
        '-----Fecha Nacimiento
        fechajob = txtFecNacMatri.Text
        ProcesarFecha()
        txtFecNacMatri.Text = fechadb
        '-----Fecha Juramento
        fechajob = txtFecJurMatri.Text
        ProcesarFecha()
        txtFecJurMatri.Text = fechadb
        '-----Fecha Estado
        fechajob = txtFecEstadoMatri.Text
        ProcesarFecha()
        txtFecEstadoMatri.Text = fechadb
        '-----Fecha Fianza
        fechajob = txtFianzaMatri.Text
        ProcesarFecha()
        txtFianzaMatri.Text = fechadb

    End Sub

    Private Sub MatriculaNueva()

        comando = New MySqlCommand("SELECT MAX(NroMatri) NroMatri FROM matriculados WHERE NroMatri < 50000", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                If senial = 0 Then
                    txtNroMatri.Text = dr(0).ToString + 1
                Else
                    txtNuevaMatricula.Text = dr(0).ToString + 1
                End If
            End While
        End If
        dr.Close()

    End Sub

    Private Sub Actualizar()

        MatriculadosTableAdapter.Fill(DbcolmartDataSet.matriculados)
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = True
        BtnActualizar.Visible = True
        BtnPrimer.Visible = True
        BtnAnterior.Visible = True
        BtnSiguiente.Visible = True
        BtnUltimo.Visible = True
        MostrarFecha()
        LeerCodPos()
        MostrarFianza()
        txtNroMatri.Focus()

    End Sub

    Private Sub CorregirBoletas()

        comando = New MySqlCommand("UPDATE boletas SET MailBoleta = '" & txtEmailMatri.Text & "' WHERE MatBoleta = " & txtNroMatri.Text & "", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub SinMatricula()

        comando = New MySqlCommand("SELECT MAX(NroMatri) NroMatri FROM matriculados WHERE NroMatri < 90000 AND NroMatri > 79000 ", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtNroMatri.Text = dr(0).ToString
                If txtNroMatri.Text = "" Then
                    txtNroMatri.Text = "80000"
                Else
                    txtNroMatri.Text = dr(0).ToString + 1
                End If
            End While
        End If
        dr.Close()

    End Sub

    Private Sub ModificarMatricula()

        comando = New MySqlCommand("UPDATE matriculados SET NroMatri = '" & txtNuevaMatricula.Text & "' WHERE id_Matri = " & txtId_Matri.Text & " AND  NroMatri = " & txtNroMatri.Text & "", conexion)
        comando.ExecuteNonQuery()

        comando = New MySqlCommand("UPDATE ctasctes SET NroCC = '" & txtNuevaMatricula.Text & "' WHERE NroCC = " & txtNroMatri.Text & " ", conexion)
        comando.ExecuteNonQuery()

        comando = New MySqlCommand("UPDATE fianzas SET MatriFza = '" & txtNuevaMatricula.Text & "' WHERE MatriFza = " & txtNroMatri.Text & " ", conexion)
        comando.ExecuteNonQuery()

    End Sub

#Region "MOUSE HOVER"

    Private Sub txtNroMatri_MouseHover(sender As Object, e As EventArgs) Handles txtNroMatri.MouseHover

        ToolTipMsg.ToolTipTitle = "Ingreso de Matrícula."
        ToolTipMsg.SetToolTip(txtNroMatri, "Presione F1 para consultar el padrón de martilleros.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los datos de un nuevo martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados del martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el martillero en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para buscar en el padrón un martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(BtnActualizar, "Presione para volver al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnPrimer_MouseHover(sender As Object, e As EventArgs) Handles BtnPrimer.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Primer."
        ToolTipMsg.SetToolTip(BtnPrimer, "Presione para ir al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAnterior_MouseHover(sender As Object, e As EventArgs) Handles BtnAnterior.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Anterior."
        ToolTipMsg.SetToolTip(BtnAnterior, "Presione para ir al registro anterior del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSiguiente_MouseHover(sender As Object, e As EventArgs) Handles BtnSiguiente.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Siguiente."
        ToolTipMsg.SetToolTip(BtnSiguiente, "Presione para ir al registro siguiente del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnUltimo_MouseHover(sender As Object, e As EventArgs) Handles BtnUltimo.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Último."
        ToolTipMsg.SetToolTip(BtnUltimo, "Presione para ir al último registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnSinMatricula_MouseHover(sender As Object, e As EventArgs) Handles btnSinMatricula.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón S/Matrícula."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para generar un colegiado sin juramento.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnCambiar_MouseHover(sender As Object, e As EventArgs) Handles btnCambiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Cambiar."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para asignarle un número de matrícula nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtCodPosReal_MouseHover(sender As Object, e As EventArgs) Handles txtCodPosReal.MouseHover

        ToolTipMsg.ToolTipTitle = "Campo Código Postal."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione F1 para consultar los códigos postales.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtCodPosLegal_MouseHover(sender As Object, e As EventArgs) Handles txtCodPosLegal.MouseHover

        ToolTipMsg.ToolTipTitle = "Campo Código Postal."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione F1 para consultar los códigos postales.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Limpiar datos de Fianza."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para limpiar los datos de la fianza.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub


#End Region

#Region "KEY PRESS"

    Private Sub txtNroMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroMatri.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNroDocMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocMatri.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCPRealMatri_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCPLegalMatri_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

#End Region

End Class