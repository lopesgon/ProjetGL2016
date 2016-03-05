Public Class FrmMain

    Private Sub msiCoobâtirQuitter_Click(sender As Object, e As EventArgs) Handles msiCoobâtirQuitter.Click
        Dim res = MsgBox(
            "Vous êtes sur le point de quitter l'exécution du programme, 
            voulez-vous vraiment quitter COOBÂTIR ?",
            MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Quitter l'application")
        If res = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim fm As FrmLogin = New FrmLogin()
        Dim dialRes As DialogResult = fm.ShowDialog
        If dialRes = DialogResult.Cancel Then
            Me.Close()
        End If

    End Sub
End Class