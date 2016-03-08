Public Class frmMain

    Private Sub msiCoobâtirQuitter_Click(sender As Object, e As EventArgs) Handles msiCoobâtirQuitter.Click
        Dim res = MsgBox(
            "Vous êtes sur le point de quitter l'exécution du programme, 
            voulez-vous vraiment quitter COOBÂTIR ?",
            MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Quitter l'application")
        If res = MsgBoxResult.Yes Then

        End If
    End Sub

End Class