'*******************************************************************************
'* ACTUALIZACIÓN DE SOCIEDADES                                                 *
'*******************************************************************************
Public Class frmSociedades
    Private Sub frmSociedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        SociedadesTableAdapter.Fill(DbcolmartDataSet.sociedades)
        LeerCodPos()
        BtnGrabar.Visible = False
        txtNroSociedad.Focus()

    End Sub

    Private Sub txtNroSociedad_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmSoc1 As New frmConsSociedad
            AddOwnedForm(frmSoc1)
            frmSoc1.ShowDialog()
            LeerCodPos()
            senial = 0
            txtNombSociedad.Focus()
        End If

    End Sub

    Private Sub txtCodPosSociedad_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmSoc0 As New frmConsCodPos
            AddOwnedForm(frmSoc0)
            frmSoc0.ShowDialog()
            txtTelSociedad.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            LeerCodPos()
            txtCodPosSociedad.Focus()
        End If

    End Sub

    Private Sub LeerCodPos()

        comando.Connection = conexion

        Try
            comando.CommandText = "SELECT LocalCodPos, ProvCodPos FROM codpostal WHERE NroCodPos = '" & txtCodPosSociedad.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtLocalSociedad.Text = CStr(row("LocalCodPos"))
                txtProvSociedad.Text = CStr(row("ProvCodPos"))
            Else
                txtLocalSociedad.Text = ""
                txtProvSociedad.Text = ""
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        SociedadesBindingSource.AddNew()
        SociedadNueva()
        txtNroSociedad.Show()
        txtNroSociedad.Focus()
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

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                SociedadesBindingSource.EndEdit()
                SociedadesTableAdapter.Update(DbcolmartDataSet.sociedades)
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

        txtNroSociedad.Focus()
        'NivelesBindingSource.AddNew()
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
        SociedadesTableAdapter.Fill(DbcolmartDataSet.sociedades)
        LeerCodPos()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            SociedadesBindingSource.EndEdit()
            SociedadesTableAdapter.Update(DbcolmartDataSet.sociedades)
            detmsg = "Registro actualizado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Edición cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            SociedadesTableAdapter.Fill(DbcolmartDataSet.sociedades)
        End If
        LeerCodPos()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM sociedades WHERE id_Soc = " & txtId_Soc.Text & " AND  NroCodDeb = " & txtNroSociedad.Text & ""), conexion)
            comando.ExecuteNonQuery()
            SociedadesTableAdapter.Fill(DbcolmartDataSet.sociedades)
            'SociedadesBindingSource.RemoveCurrent()
            'SociedadesTableAdapter.Update(DbcolmartDataSet.sociedades)
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            SociedadesTableAdapter.Fill(DbcolmartDataSet.sociedades)
        End If
        LeerCodPos()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 1
        Dim frmSoc1 As New frmConsSociedad
        AddOwnedForm(frmSoc1)
        frmSoc1.ShowDialog()
        txtNombSociedad.Focus()
        LeerCodPos()
        senial = 0

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        SociedadesTableAdapter.Fill(DbcolmartDataSet.sociedades)
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
        'LeerCodPos()

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        SociedadesBindingSource.MoveFirst()
        'LeerCodPos()

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        SociedadesBindingSource.MovePrevious()
        'LeerCodPos()

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        SociedadesBindingSource.MoveNext()
        'LeerCodPos()

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        SociedadesBindingSource.MoveLast()
        'LeerCodPos()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub SociedadNueva()

        comando = New MySqlCommand("SELECT MAX(NroSociedad) NroSociedad FROM sociedades WHERE NroSociedad > 60000", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtNroSociedad.Text = dr(0).ToString + 1
            End While
        End If
        dr.Close()

    End Sub

End Class