'*******************************************************************************
'* PROGRAMA CARGAR LOS DATOS DE LAS FIANZAS                                    *
'*******************************************************************************
Imports System.Drawing

Public Class frmFianzas
    Dim fecha1, fecha2, user1, user2, fecvto, fechaaux As String
    Dim id, meses, senial1, senial2 As Integer

    Private Sub frmFianzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        FianzasTableAdapter.Fill(DbcolmartDataSet.fianzas)
        dgvFianzas.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub txtMatricula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 12
            Dim frmMat12 As New frmConsMatri
            AddOwnedForm(frmMat12)
            frmMat12.ShowDialog()
            senial = 0
            LeerMatricula()
            LeerFianzas()
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerMatricula()
            LeerFianzas()
        End If

    End Sub

    Private Sub LeerMatricula()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = " & txtMatricula.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelNombre.Text = CStr(row("ApelNombMatri"))
        Else
            txtApelNombre.Text = ""
        End If

    End Sub

    Private Sub txtMatricula_MouseHover(sender As Object, e As EventArgs) Handles txtMatricula.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Matrícula."
        ToolTipMsg.SetToolTip(txtMatricula, "Presione F1 para buscar la matrícula deseada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerFianzas()

        comando.CommandText = "SELECT * FROM fianzas WHERE MatriFza = " & txtMatricula.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvFianzas.DataSource = dt

        dgvFianzas.Sort(dgvFianzas.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        If dgvFianzas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvFianzas.Rows

                If Not Fila Is Nothing Then
                    If Fila.Cells(2).Value = "INCOMPLETA" Then
                        Fila.DefaultCellStyle.ForeColor = Color.Red
                        lblEstado.Text = Fila.Cells(2).Value
                        id = Fila.Cells(0).Value
                        If IsDBNull(Fila.Cells(4).Value) Then
                            txtFecFirma1.Text = ""
                            senial1 = 0
                        Else
                            txtFecFirma1.Text = Fila.Cells(4).Value
                            senial1 = 1
                        End If
                        If IsDBNull(Fila.Cells(6).Value) Then
                            txtFecFirma2.Text = ""
                            senial2 = 0
                        Else
                            txtFecFirma2.Text = Fila.Cells(6).Value
                            senial2 = 1
                        End If
                        txtDocFiador.Text = Fila.Cells(9).Value
                        txtNombreFiador.Text = Fila.Cells(10).Value
                        txtCalleFiador.Text = Fila.Cells(11).Value
                        txtTelFiador.Text = Fila.Cells(12).Value
                    Else
                        lblEstado.Text = Fila.Cells(2).Value
                    End If
                End If
            Next
            dgvFianzas.FirstDisplayedScrollingRowIndex = dgvFianzas.RowCount - 1
            dgvFianzas.Rows(dgvFianzas.RowCount - 1).Selected = True
        Else
            detmsg = "No posee movimientos de fianzas...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        dgvFianzas.Refresh()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtDocFiador_Leave(sender As Object, e As EventArgs) Handles txtDocFiador.Leave

        If txtDocFiador.Text = "" Then
            detmsg = "Debe ingresar un documento...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtDocFiador.Focus()
        End If

    End Sub

    Private Sub txtDocFiador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocFiador.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNombreFiador_Leave(sender As Object, e As EventArgs) Handles txtNombreFiador.Leave

        If txtDocFiador.Text = "" Then
            detmsg = "Debe ingresar un Apellido y Nombre...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtNombreFiador.Focus()
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        frmListaFianzas.ShowDialog()

    End Sub

    Private Sub txtCalleFiador_Leave(sender As Object, e As EventArgs) Handles txtCalleFiador.Leave

        If txtCalleFiador.Text = "" Then
            detmsg = "Debe ingresar un domicilio...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtCalleFiador.Focus()
        End If

    End Sub

    Private Sub txtTelFiador_Leave(sender As Object, e As EventArgs) Handles txtTelFiador.Leave

        If txtTelFiador.Text = "" Then
            detmsg = "Debe ingresar un teléfono...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtTelFiador.Focus()
        End If

    End Sub

    Private Sub txtFecFirma1_Leave(sender As Object, e As EventArgs) Handles txtFecFirma1.Leave

        senial = 0
        fechajob = txtFecFirma1.Text
        If fechajob = "" Then
            txtFecFirma2.Focus()
        Else
            ControlFecha(fechajob)
            If senial = 0 Then
                ProcesarFecha()
                fecha1 = fechadb
                txtFecFirma2.Focus()
                user1 = user
            Else
                txtFecFirma1.Focus()
            End If
        End If

    End Sub

    Private Sub txtFecFirma2_Leave(sender As Object, e As EventArgs) Handles txtFecFirma2.Leave

        senial = 0
        fecvto = ""

        fechajob = txtFecFirma2.Text
        If fechajob = "" Then
            BtnGrabar.Focus()
        Else
            ControlFecha(fechajob)
            If senial = 0 Then
                ProcesarFecha()
                fecha2 = fechadb
                BtnGrabar.Focus()
                user2 = user
            Else
                txtFecFirma2.Focus()
            End If
        End If

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        comando.CommandText = "UPDATE fianzas SET "

        If fecha1 <> "" And senial1 = 0 Then
            comando.CommandText = comando.CommandText & "FecFirma1Fza = '" & fecha1 & "', UserFirma1Fza = '" & user1 & "', "
        End If
        If fecha2 <> "" And senial2 = 0 Then
            comando.CommandText = comando.CommandText & "FecFirma2Fza = '" & fecha2 & "', UserFirma2Fza = '" & user2 & "', "
        End If

        '******* Fecha Vence Fianza ********
        If fecha1 <> "" And fecha2 <> "" Then
            fechajob = fecha1
            ProcesarFecha()
            fecha1 = fechadb
            fechajob = fecha2
            ProcesarFecha()
            fecha2 = fechadb
            If fecha1 <= fecha2 Then
                fechaaux = fecha2
                meses = 24
                fechajob = DateAdd("m", meses, fechaaux)
                ProcesarFecha()
                fecvto = fechadb
                comando.CommandText = comando.CommandText & "FecVtoFza = '" & fecvto & "', EstadoFza = 'COMPLETA', "
            Else
                fechaaux = fecha1
                meses = 24
                fechajob = DateAdd("m", meses, fechaaux)
                ProcesarFecha()
                fecvto = fechadb
                comando.CommandText = comando.CommandText & "FecVtoFza = '" & fecvto & "', EstadoFza = 'COMPLETA', "
            End If
        End If

        comando.CommandText = comando.CommandText & "DocFiadorFza = '" & txtDocFiador.Text & "', NomFiadorFza = '" & txtNombreFiador.Text & "', CalleFiadorFza = '" & txtCalleFiador.Text & "'," _
                                  & " TelFiadorFza = '" & txtTelFiador.Text & "' WHERE id_Fza = '" & id & "' AND MatriFza = '" & txtMatricula.Text & "' "

        comando.ExecuteNonQuery()

        If fecvto <> "" Then
            GrabarMatriculados()
        End If

        Limpiar()

    End Sub

    Private Sub Limpiar()

        txtMatricula.Text = ""
        txtApelNombre.Text = ""
        txtDocFiador.Text = ""
        txtNombreFiador.Text = ""
        txtCalleFiador.Text = ""
        txtTelFiador.Text = ""
        txtFecFirma1.Text = ""
        txtFecFirma2.Text = ""
        lblEstado.Text = ""
        fecha1 = ""
        fecha2 = ""
        fechaaux = ""
        fecvto = ""
        senial1 = 0
        senial2 = 0
        dgvFianzas.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

    End Sub

    Private Sub GrabarMatriculados()

        fechajob = Format(Now, "dd/MM/yyyy")
        ProcesarFecha()

        comando.CommandText = "UPDATE matriculados SET FianzaMatri = '" & fechadb & "', EstadoMatri = 'ACTIVO', FecEstadoMatri = '" & fechadb & "', " _
                                & " DocFiadorMatri = '" & txtDocFiador.Text & "', FiadorMatri = '" & txtNombreFiador.Text & "', CalleFiadorMatri = '" & txtCalleFiador.Text & "', " _
                                & " TelFiadorMatri = '" & txtTelFiador.Text & "' WHERE NroMatri = '" & txtMatricula.Text & "' "
        comando.ExecuteNonQuery()

    End Sub
End Class