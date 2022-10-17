'*******************************************************************************
'* PROGRAMA PARA ENVIAR LAS BOLETAS POR MAIL                                   *
'*******************************************************************************
Imports System.ComponentModel
Imports System.Net.Mail

Public Class frmEnviarMail
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim archivo, matricula, mail, periodo, yyyy, mm, perdesde, perhasta As String
    Dim contreg, pos, i, senial As Integer
    Dim quien As String

    Private Sub frmEnviarMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CargarCombo()
        cmbPeriodoDes.SelectedIndex = 0
        cmbPeriodoHas.SelectedIndex = 0
        cmbPeriodoDes.Focus()

    End Sub

    Private Sub txtHastaMat_LostFocus(sender As Object, e As EventArgs) Handles txtHastaMat.LostFocus

        PonerCeros(txtDesdeMat.Text, 5)
        txtDesdeMat.Text = nroconceros
        txtDesdeMat.Show()

        PonerCeros(txtHastaMat.Text, 5)
        txtHastaMat.Text = nroconceros
        txtHastaMat.Show()

        If txtDesdeMat.Text > txtHastaMat.Text Then
            txtDesdeMat.Focus()
        End If

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

        If txtDesdeMat.Text < "60000" Then
            quien = "M"
            comando.CommandText = "SELECT NroMatri, EmailMatri FROM matriculados WHERE Nromatri >= '" & txtDesdeMat.Text & "' AND Nromatri <= '" & txtHastaMat.Text & "' ORDER BY NroMatri "
        Else
            quien = "S"
            comando.CommandText = "SELECT NroSociedad, EmailSociedad FROM sociedades WHERE NroSociedad >= '" & txtDesdeMat.Text & "' AND NroSociedad <= '" & txtHastaMat.Text & "' ORDER BY NroSociedad "
        End If
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows

                If quien = "M" Then
                    matricula = CStr(row("NroMatri"))
                    mail = Trim(CStr(row("EmailMatri")))
                Else
                    matricula = CStr(row("NroSociedad"))
                    mail = Trim(CStr(row("EmailSociedad")))
                End If
                contreg = contreg + 1
                txtMsg.Text = "Procesando Registro: " & Str(contreg) & " * Matrícula: " & matricula
                txtMsg.Refresh()
                txtMsg.Show()

                PonerCeros(matricula, 5)
                matricula = nroconceros
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

        '********** ARMO CABECERA DE MAIL *************************
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage
        e_mail.To.Clear()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("martillerosfe@martilleros.org.ar", "8TfvzRX5.A^X")
        Smtp_Server.Port = 587
        Smtp_Server.Host = "mail.martilleros.org.ar"
        e_mail = New MailMessage
        e_mail.From = New MailAddress("martillerosfe@martilleros.org.ar")
        e_mail.To.Add(Trim(mail))
        '**********************************************************

        '********** ARMO CABECERA DE MAIL PARA SENDINBLUE *********
        'Dim Smtp_Server As New SmtpClient
        'Dim e_mail As New MailMessage
        'e_mail.To.Clear()
        'Smtp_Server.UseDefaultCredentials = False
        'Smtp_Server.Credentials = New Net.NetworkCredential("martillerosfe@martilleros.org.ar", "pkPLQbEatVz6qB3f")
        'Smtp_Server.Port = 587
        'Smtp_Server.Host = "smtp-relay.sendinblue.com"
        'e_mail = New MailMessage
        'e_mail.From = New MailAddress("martillerosfe@martilleros.org.ar")
        'e_mail.To.Add(Trim(mail))
        '**********************************************************

        '********** DIRECIONES DE MAIL PARA PRUEBAS ***************
        'e_mail.To.Add(CStr("carlos.a.mayans@gmail.com"))
        'e_mail.Bcc.Add(CStr("carlos.a.mayans@gmail.com"))
        '***********************************************************

        senial = 0

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

                        e_mail.Subject = txtAsunto.Text + " " + mm + "/" + yyyy + "."
                        e_mail.IsBodyHtml = False
                        e_mail.Body = txtDetalle.Text

                        Dim adjunto As Net.Mail.Attachment = New Net.Mail.Attachment("E:/DBColMart/Boletas/" & archivo)
                        e_mail.Attachments.Add(adjunto)

                        txtMsg.Text = "Adjuntando Matrícula: " & matricula & " - Período: " & mm & "/" & yyyy & "."
                        txtMsg.Refresh()
                        txtMsg.Show()

                        senial = 1

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

        If senial = 1 Then

            txtMsg.Text = "ENVIANDO =====>>>> Matrícula: " & matricula & " ESPERE.... "
            txtMsg.Refresh()
            txtMsg.Show()

            '************** ENVÍO DE MAIL ****************************
            Smtp_Server.Send(e_mail)

            txtMsg.Text = "************** ENVIADO **************"
            txtMsg.Refresh()
            txtMsg.Show()

        End If

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
        quien = ""

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

End Class