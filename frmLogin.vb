Public Class frmLogin

    Dim Attempts As Byte = 0

    Private Sub cbxCharacter_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbxCharacter.CheckedChanged

        If (cbxCharacter.Checked = True) Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim UserName As String = "Valentin"
        Dim Password As String = "1234"

        Attempts = Attempts + 1

        If (UserName = txtUserName.Text.Trim) And (Password = txtPassword.Text.Trim) Then
            frmOrder.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failed Login")
        End If

        If Attempts = 4 Then
            MessageBox.Show("No More Allowed, The System is Shutting Down")
            Me.Close()

        End If


    End Sub
End Class
