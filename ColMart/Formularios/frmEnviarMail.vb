Imports System.ComponentModel
Imports System.Net.Mail

Public Class frmEnviarMail

    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim archivo, ceros, matricula, mail, periodo, yyyy, mm, perdesde, perhasta As String
    Dim longitud, cantidad, contreg, pos, i As Integer

    Private Sub frmEnviarMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CargarCombo()
        cmbPeriodoDes.SelectedIndex = 0
        cmbPeriodoHas.SelectedIndex = 0
        cmbPeriodoDes.Focus()

    End Sub

    Private Sub txtHastaMat_LostFocus(sender As Object, e As EventArgs) Handles txtHastaMat.LostFocus

        longitud = Len(txtDesdeMat.Text)
        If longitud < 5 Then
            cantidad = 5 - longitud
            ceros = ""
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            txtDesdeMat.Text = ceros & txtDesdeMat.Text
        End If
        txtDesdeMat.Show()
        longitud = Len(txtHastaMat.Text)
        If longitud < 5 Then
            cantidad = 5 - longitud
            ceros = ""
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            txtHastaMat.Text = ceros & txtHastaMat.Text
        End If
        txtHastaMat.Show()

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        ControlarValores()
        If senial = 1 Then
            GoTo Terminar
        End If

        txtMsg.Visible = True
        contreg = 0
        perdesde = cmbPeriodoDes.Text
        perhasta = cmbPeriodoHas.Text

        dr.Close()
        dr.Dispose()

        comando.CommandText = "SELECT NroMatri, EmailMatri FROM matriculados WHERE Nromatri >= '" & txtDesdeMat.Text & "' AND Nromatri <= '" & txtHastaMat.Text & "' ORDER BY NroMatri "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows

                matricula = CStr(row("NroMatri"))
                mail = Trim(CStr(row("EmailMatri")))
                contreg = contreg + 1
                txtMsg.Text = "Procesando Registro: " & Str(contreg) & " * Matrícula: " & matricula
                txtMsg.Refresh()
                txtMsg.Show()

                longitud = Len(matricula)
                If longitud < 5 Then
                    cantidad = 5 - longitud
                    ceros = ""
                    For j = 1 To cantidad
                        ceros = ceros & "0"
                    Next j
                    matricula = ceros & matricula
                Else
                    matricula = matricula
                End If

                pos = InStr(1, mail, "@")

                If pos > 0 Then
                    ProcesarMail()
                End If

            Next
        End If

        dr.Close()
        dr.Dispose()

        detmsg = "Proceso terminado...!!!"
        tipomsg = "info"
        btnmsg = 1
        frmMsgBox.ShowDialog()

Terminar:

    End Sub

    Private Sub ProcesarMail()

        For i = perdesde To perhasta

            comando = New MySqlCommand("SELECT * FROM boletas WHERE MatBoleta = '" & matricula & "' " _
                                                                  & " AND PeriodoBoleta = '" & i & "' AND EstadoBoleta = 'LIQUIDADA' ORDER BY PeriodoBoleta", conexion)
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                While dr.Read
                    Try
                        periodo = dr(8).ToString
                        yyyy = Mid(periodo, 1, 4)
                        mm = Mid(periodo, 5, 2)
                        archivo = matricula & "-" & periodo & ".pdf"

                        '********** ARMO CABECERA DE MAIL *************************

                        Dim Smtp_Server As New SmtpClient
                        Dim e_mail As New MailMessage
                        e_mail.To.Clear()
                        Smtp_Server.UseDefaultCredentials = False
                        Smtp_Server.Credentials = New Net.NetworkCredential("martillerosfe@martilleros.org.ar", "Fx7kdIkA!=sf")
                        'Smtp_Server.Port = 465
                        Smtp_Server.Port = 587
                        Smtp_Server.Host = "mail.martilleros.org.ar"

                        e_mail = New MailMessage
                        e_mail.From = New MailAddress("martillerosfe@martilleros.org.ar")

                        '********** Direcciones de mail para proceso ---------------
                        e_mail.To.Add(Trim(mail))
                        'e_mail.Bcc.Add(CStr("martillerosfe@martilleros.org.ar"))

                        '********** Direcciones de mail para prueba ----------------
                        'e_mail.To.Add(CStr("carlos.a.mayans@gmail.com"))
                        'e_mail.Bcc.Add(CStr("carlos.a.mayans@gmail.com"))

                        '***********************************************************

                        e_mail.Subject = txtAsunto.Text + " " + mm + "/" + yyyy + "."
                        e_mail.IsBodyHtml = False
                        e_mail.Body = txtDetalle.Text

                        Dim adjunto As Net.Mail.Attachment = New Net.Mail.Attachment("E:/DBColMart/Boletas/" & archivo)
                        e_mail.Attachments.Add(adjunto)

                        txtMsg.Text = "Enviando Matrícula: " & matricula & " - Período: " & mm & "/" & yyyy & "."
                        txtMsg.Refresh()
                        txtMsg.Show()

                        '************** Envío el mail ****************************
                        Smtp_Server.Send(e_mail)

                        'MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "ERROR EN MATRÍCULA: " & matricula & " - Período: " & mm & "/" & yyyy & ".", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End While

                dr.Close()
                dr.Dispose()

                '************** Actualizo boletas ****************************
                comando = New MySqlCommand("UPDATE boletas SET EstadoBoleta = 'PENDIENTE' WHERE MatBoleta = '" & matricula & "' AND PeriodoBoleta = '" & i & "' " _
                                            & " AND EstadoBoleta = 'LIQUIDADA' ", conexion)
                comando.ExecuteNonQuery()

                '************** Actualizo cuentas corrientes *****************
                comando = New MySqlCommand("UPDATE ctasctes SET EstadoCC = 'PENDIENTE' WHERE NroCC = " & matricula & " AND PeriodoCC = '" & i & "' " _
                                           & " AND EstadoCC = 'LIQUIDADA' ", conexion)
                comando.ExecuteNonQuery()

            Else

                dr.Close()
                dr.Dispose()

            End If

        Next i

    End Sub

    Private Sub FiltrarBoletas()

        comando = New MySqlCommand("SELECT * FROM boletas WHERE MatBoleta = '" & matricula & "' " _
                                                                  & " AND PeriodoBoleta >= '" & cmbPeriodoDes.Text & "' AND PeriodoBoleta <= '" & cmbPeriodoHas.Text & "' " _
                                                                  & " AND EstadoBoleta = 'LIQUIDADA' ORDER BY PeriodoBoleta", conexion)
        dr = comando.ExecuteReader()

        comando = New MySqlCommand("UPDATE boletas SET EstadoBoleta = 'PENDIENTE' WHERE MatBoleta = '" & matricula & "' AND PeriodoBoleta >= '" & cmbPeriodoDes.Text & "' " _
                                            & " AND PeriodoBoleta <= '" & cmbPeriodoHas.Text & "' AND EstadoBoleta = 'LIQUIDADA' ", conexion)
        comando.ExecuteNonQuery()

        comando = New MySqlCommand("UPDATE ctasctes SET EstadoCC = 'PENDIENTE' WHERE NroCC = " & matricula & " AND PeriodoCC >= '" & cmbPeriodoDes.Text & "' " _
                                           & " AND PeriodoCC <= '" & cmbPeriodoHas.Text & "' AND EstadoCC = 'LIQUIDADA' ", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub btnEnviar_MouseHover(sender As Object, e As EventArgs) Handles btnEnviar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Enviar."
        ToolTipMsg.SetToolTip(btnEnviar, "Presione para enviar las boletas con correo electrónico.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub ControlarValores()

        senial = 0
        If txtDesdeMat.Text > txtHastaMat.Text Then
            senial = 1
            txtDesdeMat.Focus()
        End If
        If txtAsunto.Text = "" Then
            senial = 1
            txtAsunto.Focus()
        End If
        If txtDetalle.Text = "" Then
            senial = 1
            txtDetalle.Focus()
        End If
        If senial = 1 Then
            detmsg = "Controlar los valores ingresados...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        frmEnviarBoletas.ShowDialog()

    End Sub

    Private Sub btnImprimir_MouseHover(sender As Object, e As EventArgs) Handles btnImprimir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Imprimir."
        ToolTipMsg.SetToolTip(btnImprimir, "Presione para generar la impresión de boletas no enviadas por mail.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT DISTINCT PeriodoBoleta FROM Boletas ORDER BY PeriodoBoleta DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbPeriodoDes.Items.Add(dr(0).ToString)
                cmbPeriodoHas.Items.Add(dr(0).ToString)
            End While
        End If

    End Sub

    Private Sub frmEnviarMail_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        DesconectarMySql()

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

    Private Sub cmbPeriodoHas_LostFocus(sender As Object, e As EventArgs) Handles cmbPeriodoHas.LostFocus

        If cmbPeriodoDes.Text > cmbPeriodoHas.Text Then

            detmsg = "Período desde mayor al período hasta...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

            cmbPeriodoDes.Focus()

        End If

    End Sub
End Class