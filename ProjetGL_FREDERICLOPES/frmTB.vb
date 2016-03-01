Public Class frmTB

    Private Sub msiCoobâtirQuitter_Click(sender As Object, e As EventArgs) Handles msiCoobâtirQuitter.Click
        Dim res = MsgBox(
            "Vous êtes sur le point de quitter l'exécution du programme, 
            voulez-vous vraiment quitter COOBÂTIR ?",
            MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Quitter l'application")
        If res = MsgBoxResult.Yes Then
            frmMain.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbTb.CellContentClick

    End Sub
End Class