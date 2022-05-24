Imports System.IO
Imports System.Net.Mail

Public Class frmPrintCaja
    Dim archivo As String

    Private Sub frmPrintCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cajaTableAdapter.Fill(dbcolmartDataSet.caja)

        Dim nombrePDF As String
        nombrePDF = "Caja" & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ""
        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim newFile As New FileStream("E:\dbcolmart\cajas\" & nombrePDF & ".pdf", FileMode.Create)
        archivo = nombrePDF & ".pdf"
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()

        EnviarMail()

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub EnviarMail()

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("sistema@martilleros.org.ar", "D{Lm)Rz(GHw+")
        Smtp_Server.Port = 587
        Smtp_Server.Host = "mail.martilleros.org.ar"

        e_mail = New MailMessage
        e_mail.From = New MailAddress("sistema@martilleros.org.ar")

        'Direcciones de mail para proceso ---------------
        e_mail.To.Add(CStr("tesoreria@martilleros.org.ar"))
        e_mail.Bcc.Add(CStr("carlos.a.mayans@gmail.com"))

        e_mail.Subject = "PDF cierre de caja"
        e_mail.IsBodyHtml = False
        e_mail.Body = "PDF de cierre de caja de la fecha de hoy"

        Dim adjunto As Net.Mail.Attachment = New Net.Mail.Attachment("E:\dbcolmart\cajas\" & archivo)
        e_mail.Attachments.Add(adjunto)

        Smtp_Server.Send(e_mail)

    End Sub

End Class