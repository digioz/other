Imports DotNetOpenMail

Public Class frmMain

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim emailMessage As New DotNetOpenMail.EmailMessage
        Dim smtpServer As SmtpServer

        If smtp_host = "" Or smtp_user = "" Or smtp_pass = "" Then
            Dim f As New frmSMTPServerSettings
            f.ShowDialog()
            Exit Sub
        End If

        Try
            emailMessage.FromAddress = New EmailAddress(txtFrom.Text.ToString())
            emailMessage.AddToAddress(New EmailAddress(txtTo.Text.ToString()))

            emailMessage.Subject = txtSubject.Text.ToString()

            emailMessage.BodyText = txtMessage.Text.ToString()


            smtpServer = New SmtpServer(smtp_host)
            smtpServer.SmtpAuthToken = New SmtpAuth.SmtpAuthToken(smtp_user, smtp_pass)

            emailMessage.Send(smtpServer)
        Catch ex As Exception
            MessageBox.Show("Error In Sending Mail:" & vbNewLine & ex.Message.ToString())
        End Try

        MessageBox.Show("Email Message Sent!")

    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuSMTPServerSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSMTPServerSettings.Click
        Dim f As New frmSMTPServerSettings
        f.ShowDialog()
    End Sub

    Private Sub mnuCopyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyright.Click
        MessageBox.Show("Copyright 2006 DigiOz Multimedia" & vbNewLine & "Visit Us At www.digioz.com")
    End Sub
End Class
