Imports System.ComponentModel
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmMatriculados

    Dim fechajob, fechadb, dd, mm, yyyy As String
    Dim pos1, pos2 As Integer

    Private Sub frmMatriculados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.matriculados' Puede moverla o quitarla según sea necesario.
        MatriculadosTableAdapter.Fill(DbcolmartDataSet.matriculados)
        LeerCodPos()
        BtnGrabar.Visible = False
        MostrarFecha()
        txtNroMatri.Focus()

    End Sub

#Region "INGRESO DE DATOS"
    Private Sub txtNroMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroMatri.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmMat0 As New frmConsMatri
            AddOwnedForm(frmMat0)
            frmMat0.ShowDialog()
            LeerCodPos()
            senial = 0
            txtApelNombMatri.Focus()
        End If

    End Sub

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


#End Region

#Region "BOTONES DEL FORMULARIO"

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

        txtNroMatri.Focus()
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
        MatriculadosTableAdapter.Fill(Me.DbcolmartDataSet.matriculados)
        LeerCodPos()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            InvertirFecha()
            'MatriculadosBindingSource.EndEdit()
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
        MatriculadosTableAdapter.Fill(Me.DbcolmartDataSet.matriculados)
        LeerCodPos()
        MostrarFecha()

    End Sub

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
        MatriculadosTableAdapter.Fill(Me.DbcolmartDataSet.matriculados)
        LeerCodPos()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 0
        Dim frmMat1 As New frmConsMatri
        AddOwnedForm(frmMat1)
        frmMat1.ShowDialog()
        txtApelNombMatri.Focus()
        MostrarFecha()
        LeerCodPos()
        senial = 0

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

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

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        MatriculadosBindingSource.MoveFirst()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        MatriculadosBindingSource.MovePrevious()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        MatriculadosBindingSource.MoveNext()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        MatriculadosBindingSource.MoveLast()
        MostrarFecha()
        LeerCodPos()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

#End Region

#Region "CÓDIGOS POSTALES"

    Private Sub txtCPRealMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPRealMatri.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmMat1 As New frmConsCodPos
            AddOwnedForm(frmMat1)
            frmMat1.ShowDialog()
            txtCeluRealMatri.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            LeerCodPos()
            lblAtencion1.Visible = False
            txtCPRealMatri.Focus()
        End If

    End Sub

    Private Sub txtCPRealMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPRealMatri.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCPLegalMatri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPLegalMatri.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmMat2 As New frmConsCodPos
            AddOwnedForm(frmMat2)
            frmMat2.ShowDialog()
            txtCeluLegalMatri.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            LeerCodPos()
            lblAtencion2.Visible = False
            txtCPLegalMatri.Focus()
        End If

    End Sub

    Private Sub txtCPLegalMatri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPLegalMatri.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub LeerCodPos()

        comando.Connection = conexion

        Try
            comando.CommandText = "SELECT LocalCodPos, ProvCodPos FROM codpostal WHERE NroCodPos = '" & txtCPRealMatri.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtLocalReal.Text = CStr(row("LocalCodPos"))
                txtProvReal.Text = CStr(row("ProvCodPos"))
            Else
                txtLocalReal.Text = ""
                txtProvReal.Text = ""
            End If

            comando.CommandText = "SELECT LocalCodPos, ProvCodPos FROM codpostal WHERE NroCodPos = '" & txtCPLegalMatri.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtLocalLegal.Text = CStr(row("LocalCodPos"))
                txtProvLegal.Text = CStr(row("ProvCodPos"))
            Else
                txtLocalLegal.Text = ""
                txtProvLegal.Text = ""
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub txtCPRealMatri_GotFocus(sender As Object, e As EventArgs) Handles txtCPRealMatri.GotFocus

        lblAtencion1.Visible = True

    End Sub

    Private Sub txtCPRealMatri_LostFocus(sender As Object, e As EventArgs) Handles txtCPRealMatri.LostFocus

        lblAtencion1.Visible = False

    End Sub

    Private Sub txtCPLegalMatri_GotFocus(sender As Object, e As EventArgs) Handles txtCPLegalMatri.GotFocus

        lblAtencion2.Visible = True

    End Sub

    Private Sub txtCPLegalMatri_LostFocus(sender As Object, e As EventArgs) Handles txtCPLegalMatri.LostFocus

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

    End Sub

    Private Sub ProcesarFecha()

        pos1 = InStr(1, fechajob, "/")
        pos2 = InStr(pos1 + 1, fechajob, "/")

        If pos1 = 5 Then
            yyyy = Mid(fechajob, 1, pos1 - 1)
            mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))
            dd = Mid(fechajob, pos2 + 1, 2)
        ElseIf pos1 = 3 Then
            dd = Mid(fechajob, 1, pos1 - 1)
            mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))
            yyyy = Mid(fechajob, pos2 + 1, 4)
        End If

        fechajob = dd & "/" & mm & "/" & yyyy
        fechadb = yyyy & "/" & mm & "/" & dd

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
                txtNroMatri.Text = dr(0).ToString + 1
            End While
        End If
        dr.Close()

    End Sub

    Private Sub CorregirBoletas()

        comando = New MySqlCommand("UPDATE boletas SET MailBoleta = '" & txtEmailMatri.Text & "' WHERE MatBoleta = " & txtNroMatri.Text & "", conexion)
        comando.ExecuteNonQuery()

    End Sub

End Class