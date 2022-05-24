Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Net
Imports System.Net.Mail

Public Class frmEnviarMail

    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim yyyy, yy, mm, dd, archivo, ceros, matricula, mail As String
    Dim longitud, cantidad, contreg As Integer

    Private Sub frmEnviarMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CargarCombo()
        cmbPeriodo.SelectedIndex = 0
        cmbPeriodo.Focus()

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

        dr.Close()
        dr.Dispose()

        comando.CommandText = "SELECT * FROM boletas WHERE MatBoleta >= '" & txtDesdeMat.Text & "' AND MatBoleta <= '" & txtHastaMat.Text & "' " _
                                                          & " AND PeriodoBoleta = '" & cmbPeriodo.Text & "' " 'AND EstadoBoleta = 'LIQUIDADA' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        Dim row As DataRow = dt.Rows(0)

        For Each row In dt.Rows
            contreg = contreg + 1
            txtMsg.Text = "Procesando Registro: " & Str(contreg) & " * Matrícula: " & CStr(row("MatBoleta"))
            txtMsg.Show()
            mail = CStr(row("MailBoleta"))

            If Mid(CStr(row("MailBoleta")), 1, 5) <> "     " Then
                'If InStr(1, CStr(row("MailBoleta")), "@") <> 0 Then
                Try
                    Dim Smtp_Server As New SmtpClient
                    Dim e_mail As New MailMessage
                    Smtp_Server.UseDefaultCredentials = False
                    Smtp_Server.Credentials = New Net.NetworkCredential("martillerosfe@martilleros.org.ar", "solosequenosenada")
                    'Smtp_Server.Port = 465
                    Smtp_Server.Port = 587
                    Smtp_Server.Host = "mail.martilleros.org.ar"

                    e_mail = New MailMessage
                    e_mail.From = New MailAddress("martillerosfe@martilleros.org.ar")

                    'Direcciones de mail para proceso ---------------
                    e_mail.To.Add(CStr(row("MailBoleta")))
                    e_mail.Bcc.Add(CStr("martillerosfe@martilleros.org.ar"))

                    'Direcciones de mail para prueba ----------------
                    'e_mail.To.Add(CStr("carlos.a.mayans@gmail.com"))
                    'e_mail.Bcc.Add(CStr("carlos.a.mayans@gmail.com"))
                    '-------------------------------------------------------------

                    e_mail.Subject = txtAsunto.Text
                    e_mail.IsBodyHtml = False
                    e_mail.Body = txtDetalle.Text

                    longitud = Len(CStr(row("MatBoleta")))
                    If longitud < 5 Then
                        cantidad = 5 - longitud
                        ceros = ""
                        For j = 1 To cantidad
                            ceros = ceros & "0"
                        Next j
                        matricula = ceros & CStr(row("MatBoleta"))
                    Else
                        matricula = CStr(row("MatBoleta"))
                    End If

                    archivo = matricula & "-" & cmbPeriodo.Text & ".pdf"

                    Dim adjunto As Net.Mail.Attachment = New Net.Mail.Attachment("E:/DBColMart/Boletas/" & archivo)
                    e_mail.Attachments.Add(adjunto)

                    If CStr(row("EstadoBoleta")) = "PENDIENTE" Then
                        detmsg = "ATENCIÓN...!!! Boleta matrícula  " & matricula & "  ENVIADA, desea reenviarla...?"
                        tipomsg = "question"
                        btnmsg = 2
                        frmMsgBox.ShowDialog()
                        If frmMsgBox.Tag = "SI" Then
                            Smtp_Server.Send(e_mail)
                        End If
                    Else
                        Smtp_Server.Send(e_mail)
                    End If
                    txtMsg.Text = "Enviando Matrícula: " & CStr(row("MatBoleta"))

                    comando = New MySqlCommand("UPDATE boletas SET EstadoBoleta = 'PENDIENTE' WHERE MatBoleta = " & matricula & " AND PeriodoBoleta = '" & cmbPeriodo.Text & "'", conexion)
                    comando.ExecuteNonQuery()

                    comando = New MySqlCommand("UPDATE ctasctes SET EstadoCC = 'PENDIENTE' WHERE NroCC = " & matricula & " AND PeriodoCC = '" & cmbPeriodo.Text & "'", conexion)
                    comando.ExecuteNonQuery()

                    'MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR EN MATRÍCULA: " & CStr(row("MatBoleta")), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                'comando = New MySqlCommand("UPDATE boletas SET EstadoBoleta = 'NO ENVIADA' WHERE MatBoleta = " & matricula & " AND PeriodoBoleta = '" & cmbPeriodo.Text & "'", conexion)
                'comando.ExecuteNonQuery()
            End If
        Next

        detmsg = "Proceso de envío terminado...!!!"
        tipomsg = "info"
        btnmsg = 1
        frmMsgBox.ShowDialog()

Terminar:

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

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT DISTINCT PeriodoBoleta FROM Boletas ORDER BY PeriodoBoleta DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbPeriodo.Items.Add(dr(0).ToString)
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

End Class