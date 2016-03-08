Public Class FrmTypeClient
    Private Sub btnConfirmer_Click(sender As Object, e As EventArgs) Handles btnConfirmer.Click
        If rbPhysique.Checked Then
            FrmNouvPersPhys.MdiParent = FrmMain
            FrmNouvPersPhys.Show()
            Me.Close()
        Else
            FrmNouvPersMorale.MdiParent = FrmMain
            FrmNouvPersMorale.Show()
            Me.Close()
        End If
    End Sub
End Class