Imports System.Net.Mail
Public Class Notifications

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress("kevinvarmen020595@gmail.com")
            EmailMessage.To.Add("kevinvarmen020595@gmail.com")
            EmailMessage.Subject = "Notificacion de multa"
            EmailMessage.Body = ("No cumplio con los requisitos de reservacion se le debe multar")
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