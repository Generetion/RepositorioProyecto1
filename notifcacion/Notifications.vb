Imports System.Net.Mail
Public Class Notifications

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emailVariable As String
        emailVariable = TbxEmail.Text
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress(emailVariable)
            EmailMessage.To.Add(emailVariable)
            EmailMessage.Subject = "Notificacion del sistema"
            EmailMessage.Body = ("Esta es una alerta del sistema")
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("rocabrujamailsender@gmail.com", "rocabruja123")
            SMTP.Send(EmailMessage)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Notifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class