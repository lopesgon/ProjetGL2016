Public Class frmMain
    Private fmTB As frmTB

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbLogin.Text = "admin" And tbPassword.Text = "pass" Then
            Me.Hide()
            frmTB.ShowDialog()
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fmTB = New frmTB()
    End Sub

    Private Sub selectionnerTout(sender As Object, e As EventArgs) Handles tbLogin.Enter, tbPassword.Enter
        sender.SelectAll()
    End Sub
End Class
