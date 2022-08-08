Public Class frmMatriculados

    'Dim fechajob, fechadb, dd, mm, yyyy, fechaaux, fechavenc As String
    Dim dd, mm, yyyy, fechaaux, fechavenc As String
    Dim pos1, pos2, codigoreal, codigolegal, senial, meses As Integer
    Dim fecha1, fecha2 As Date

    Private Sub frmMatriculados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        MatriculadosTableAdapter.Fill(DbcolmartDataSet.matriculados)
        LeerCodPos()
        BtnGrabar.Visible = False
        MostrarFecha()
        txtNroMatri.Focus()

    End Sub

#Region "INGRESO DE DATOS"

    'Control por número de matrícula
    Private Sub txtNroMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroMatri.KeyDown
        'Busco matriculado presionando F1
        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmMat0 As New frmConsMatri
            AddOwnedForm(frmMat0)
            frmMat0.ShowDialog()
            LeerCodPos()
            senial = 0
            txtApelNombMatri.Focus()
        End If

        'Busco matriculado por Nro de matrícula
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

    'Controlo que el valor de NroMatri sea numérico
    Private Sub txtNroMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroMatri.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    'Controlo que el valor del Documento sea numérico
    Private Sub txtNroDocMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocMatri.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

#End Region

#Region "BOTONES DEL FORMULARIO"

    'Proceso del botón Agregar
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        MatriculadosBindingSource.AddNew()
        MatriculaNueva()
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
        cmbTipoDocMatri.SelectedIndex = 0
        cmbEstadoMatri.SelectedIndex = 0
        cmbSexoMatri.SelectedIndex = 0
        cmbCatAporteMatri.SelectedIndex = 0

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los datos de un nuevo martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Grabar
    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
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

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados del martillero nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Modificar
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
                                    & "CPRealMatri = '" & txtCPRealMatri.Text & "', EmailMatri = '" & txtEmailMatri.Text & "', CeluRealMatri = '" & txtCeluRealMatri.Text & "', " _
                                    & "FijoRealMatri = '" & txtFijoRealMatri.Text & "', CalleLegalMatri = '" & txtCalleLegalMatri.Text & "', CPLegalMatri = '" & txtCPLegalMatri.Text & "', " _
                                    & "CeluLegalMatri = '" & txtCeluLegalMatri.Text & "', FijoLegalMatri = '" & txtFijoLegalMatri.Text & "', FianzaMatri = '" & txtFianzaMatri.Text & "', " _
                                    & "DocFiadorMatri = '" & txtDocFiadorMatri.Text & "', FiadorMatri = '" & txtFiadorMatri.Text & "', CalleFiadorMatri = '" & txtCalleFiadorMatri.Text & "', " _
                                    & "TelFiadorMatri = '" & txtTelFiadorMatri.Text & "', ObsMatri = '" & txtObsMatri.Text & "' WHERE id_Matri = " & txtId_Matri.Text & " AND  NroMatri = " & txtNroMatri.Text & "", conexion)
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

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados del martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Eliminar
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM matriculados WHERE id_Matri = " & txtId_Matri.Text & " AND  NroMatri = " & txtNroMatri.Text & ""), conexion)
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

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el martillero en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Buscar
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 0
        Dim frmMat1 As New frmConsMatri
        AddOwnedForm(frmMat1)
        frmMat1.ShowDialog()
        'txtApelNombMatri.Focus()
        MostrarFecha()
        LeerCodPos()
        senial = 0

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para buscar en el padrón un martillero.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Actualizar
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Actualizar()

    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(BtnActualizar, "Presione para volver al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Principio
    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        MatriculadosBindingSource.MoveFirst()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnPrimer_MouseHover(sender As Object, e As EventArgs) Handles BtnPrimer.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Primer."
        ToolTipMsg.SetToolTip(BtnPrimer, "Presione para ir al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Anterior
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        MatriculadosBindingSource.MovePrevious()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnAnterior_MouseHover(sender As Object, e As EventArgs) Handles BtnAnterior.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Anterior."
        ToolTipMsg.SetToolTip(BtnAnterior, "Presione para ir al registro anterior del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Siguiente
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        MatriculadosBindingSource.MoveNext()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnSiguiente_MouseHover(sender As Object, e As EventArgs) Handles BtnSiguiente.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Siguiente."
        ToolTipMsg.SetToolTip(BtnSiguiente, "Presione para ir al registro siguiente del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Ultimo
    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        MatriculadosBindingSource.MoveLast()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnUltimo_MouseHover(sender As Object, e As EventArgs) Handles BtnUltimo.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Último."
        ToolTipMsg.SetToolTip(BtnUltimo, "Presione para ir al último registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    'Proceso del botón Salir
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

#End Region

#Region "CÓDIGOS POSTALES"

    'Ingreso el Código Postal Real
    Private Sub txtCPRealMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPostal1.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmMat1 As New frmConsCodPos
            AddOwnedForm(frmMat1)
            frmMat1.ShowDialog()
            LeerCodPos()
            txtCeluRealMatri.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            LeerCodPos()
            lblAtencion1.Visible = False
            txtCodPostal1.Focus()
        End If

    End Sub

    'Controlo que el código postal sea numérico
    Private Sub txtCPRealMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodPostal1.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    'Ingreso el Código Postal Legal
    Private Sub txtCPLegalMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPostal2.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmMat2 As New frmConsCodPos
            AddOwnedForm(frmMat2)
            frmMat2.ShowDialog()
            LeerCodPos()
            txtCeluLegalMatri.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            LeerCodPos()
            lblAtencion2.Visible = False
            txtCodPostal2.Focus()
        End If

    End Sub

    'Controlo que el código postal sea numérico
    Private Sub txtCPLegalMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodPostal2.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    'Busco el matriculado ingresado por NroMatri
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

    'Proceso que carga el matriculado leído
    Private Sub CargarMatriculado()

        Dim row As DataRow = dt.Rows(0)

        txtId_Matri.Text = CStr(row("id_Matri"))
        txtNroMatri.Text = CStr(row("NroMatri"))
        txtApelNombMatri.Text = CStr(row("ApelNombMatri"))
        txtApelMatMatri.Text = CStr(row("ApelMatMatri"))

        'fechajob = CStr(row("FecNacMatri"))
        'ProcesarFecha()
        'txtFecNacMatri.Text = fechajob

        txtFecNacMatri.Text = CStr(row("FecNacMatri"))

        txtLugarNacMatri.Text = CStr(row("LugarNacMatri"))
        txtNacionNacMatri.Text = CStr(row("NacionNacMatri"))
        cmbTipoDocMatri.Text = CStr(row("TipoDocMatri"))
        txtNroDocMatri.Text = CStr(row("NroDocMatri"))
        cmbSexoMatri.Text = CStr(row("SexoMatri"))
        cmbEstCivilMatri.Text = CStr(row("EstCivilMatri"))
        txtCuitMatri.Text = CStr(row("CuitMatri"))

        'fechajob = CStr(row("FecJurMatri"))
        'ProcesarFecha()
        'txtFecJurMatri.Text = fechajob

        txtFecJurMatri.Text = CStr(row("FecJurMatri"))

        cmbCatAporteMatri.Text = CStr(row("CatAporteMatri"))
        cmbEstadoMatri.Text = CStr(row("EstadoMatri"))

        'fechajob = CStr(row("FecEstadoMatri"))
        'ProcesarFecha()
        'txtFecEstadoMatri.Text = fechajob

        txtFecEstadoMatri.Text = CStr(row("FecEstadoMatri"))

        txtCalleRealMatri.Text = CStr(row("CalleRealMatri"))
        txtCodPostal1.Text = CStr(row("CPRealMatri"))
        txtCPRealMatri.Text = txtCodPostal1.Text
        txtEmailMatri.Text = CStr(row("EmailMatri"))
        txtCeluRealMatri.Text = CStr(row("CeluRealMatri"))
        txtFijoRealMatri.Text = CStr(row("FijoRealMatri"))
        txtCalleLegalMatri.Text = CStr(row("CalleLegalMatri"))
        txtCodPostal2.Text = CStr(row("CPLegalMatri"))
        txtCPLegalMatri.Text = txtCodPostal2.Text
        txtCeluLegalMatri.Text = CStr(row("CeluLegalMatri"))
        txtFijoLegalMatri.Text = CStr(row("FijoLegalMatri"))

        'fechajob = CStr(row("FianzaMatri"))
        'ProcesarFecha()
        'txtFianzaMatri.Text = fechajob

        txtFianzaMatri.Text = CStr(row("FianzaMatri"))

        txtDocFiadorMatri.Text = CStr(row("DocFiadorMatri"))
        txtFiadorMatri.Text = CStr(row("FiadorMatri"))
        txtCalleFiadorMatri.Text = CStr(row("CalleFiadorMatri"))
        txtObsMatri.Text = CStr(row("ObsMatri"))

        MostrarFecha()

    End Sub

    'Proceso para leer los códigos postales por su ID
    Private Sub LeerCodPos()

        comando.Connection = conexion

        Try
            comando.CommandText = "SELECT * FROM codpostal WHERE id_CodPos = '" & txtCPRealMatri.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtCPRealMatri.Text = Val(CStr(row("id_CodPos")))
                txtLocalReal.Text = CStr(row("LocalCodPos"))
                txtProvReal.Text = CStr(row("ProvCodPos"))
                txtCodPostal1.Text = CStr(row("NroCodPos"))
            Else
                txtLocalReal.Text = ""
                txtProvReal.Text = ""
            End If

            comando.CommandText = "SELECT * FROM codpostal WHERE id_CodPos = '" & txtCPLegalMatri.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtCPLegalMatri.Text = Val(CStr(row("id_CodPos")))
                txtLocalLegal.Text = CStr(row("LocalCodPos"))
                txtProvLegal.Text = CStr(row("ProvCodPos"))
                txtCodPostal2.Text = CStr(row("NroCodPos"))
            Else
                txtLocalLegal.Text = ""
                txtProvLegal.Text = ""
            End If
        Catch ex As Exception
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub txtCPRealMatri_GotFocus(sender As Object, e As EventArgs) Handles txtCodPostal1.GotFocus

        lblAtencion1.Visible = True

    End Sub

    Private Sub txtCPRealMatri_LostFocus(sender As Object, e As EventArgs) Handles txtCodPostal1.LostFocus

        lblAtencion1.Visible = False

    End Sub

    Private Sub txtCPLegalMatri_GotFocus(sender As Object, e As EventArgs) Handles txtCodPostal2.GotFocus

        lblAtencion2.Visible = True

    End Sub

    Private Sub txtCPLegalMatri_LostFocus(sender As Object, e As EventArgs) Handles txtCodPostal2.LostFocus

        lblAtencion2.Visible = False

    End Sub

#End Region

#Region "PROCESOS DE FECHA"
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
        txtVenceFianza.Show()

    End Sub

    'Private Sub ProcesarFecha()

    '    pos1 = InStr(1, fechajob, "/")
    '    pos2 = InStr(pos1 + 1, fechajob, "/")

    '    If pos1 = 5 Then
    '        yyyy = Mid(fechajob, 1, pos1 - 1)
    '        mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))
    '        dd = Mid(fechajob, pos2 + 1, 2)
    '    ElseIf pos1 = 3 Then
    '        dd = Mid(fechajob, 1, pos1 - 1)
    '        mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))
    '        yyyy = Mid(fechajob, pos2 + 1, 4)
    '    End If

    '    fechajob = dd & "/" & mm & "/" & yyyy
    '    fechadb = yyyy & "/" & mm & "/" & dd

    'End Sub

    Private Sub txtNroMatri_MouseHover(sender As Object, e As EventArgs) Handles txtNroMatri.MouseHover

        ToolTipMsg.ToolTipTitle = "Ingreso de Matrícula."
        ToolTipMsg.SetToolTip(txtNroMatri, "Presione F1 para consultar el padrón de martilleros.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

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

    Private Sub txtFianzaMatri_Leave(sender As Object, e As EventArgs) Handles txtFianzaMatri.Leave

        fechajob = txtFianzaMatri.Text
        ControlFecha(fechajob)
        If senial = 1 Then
            txtFianzaMatri.Text = ""
            txtFianzaMatri.Focus()
        Else
            MatriculadosBindingSource.Current("FianzaMatri") = txtFianzaMatri.Text
            txtFiadorMatri.Focus()
        End If
        senial = 0

    End Sub

#End Region

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
        txtNroMatri.Focus()

    End Sub

    Private Sub CorregirBoletas()

        comando = New MySqlCommand("UPDATE boletas SET MailBoleta = '" & txtEmailMatri.Text & "' WHERE MatBoleta = " & txtNroMatri.Text & "", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub btnSinMatricula_Click(sender As Object, e As EventArgs) Handles btnSinMatricula.Click

        MatriculadosBindingSource.AddNew()
        SinMatricula()
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
        cmbTipoDocMatri.SelectedIndex = 0
        cmbEstadoMatri.SelectedIndex = 0
        cmbSexoMatri.SelectedIndex = 0
        cmbCatAporteMatri.SelectedIndex = 0

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

    Private Sub ModificarMatricula()

        comando = New MySqlCommand("UPDATE matriculados SET NroMatri = '" & txtNuevaMatricula.Text & "' WHERE id_Matri = " & txtId_Matri.Text & " AND  NroMatri = " & txtNroMatri.Text & "", conexion)
        comando.ExecuteNonQuery()

        comando = New MySqlCommand("UPDATE ctasctes SET NroCC = '" & txtNuevaMatricula.Text & "' WHERE NroCC = " & txtNroMatri.Text & " ", conexion)
        comando.ExecuteNonQuery()

    End Sub

End Class