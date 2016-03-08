Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbLogin.Text = "admin" And tbPassword.Text = "pass" Then
            Me.Close()
        Else
            MsgBox("Désolé, le nom d'utilisateur ou le mot de passe est incorrect",
                   MsgBoxStyle.Critical, "Information")
            tbLogin.SelectAll()
            tbLogin.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub selectionnerTout(sender As Object, e As EventArgs) Handles tbLogin.Enter, tbPassword.Enter
        sender.SelectAll()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class