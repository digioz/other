Public Class frmSMTPServerSettings

    Private Sub btnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSettings.Click
        smtp_host = txtHost.Text.ToString()
        smtp_user = txtUsername.Text.ToString()
        smtp_pass = txtPassword.Text.ToString()
        Me.Close()
    End Sub

End Class