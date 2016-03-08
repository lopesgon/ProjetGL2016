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
        Dim fm As New FrmLogin
        Dim dialRes As DialogResult = fm.ShowDialog
        If dialRes = DialogResult.Cancel Then
            fm.Close()
            Me.Close()
        End If
        fm.Close()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub msiClientsNouveau_Click(sender As Object, e As EventArgs) Handles msiClientsNouveau.Click
        Dim frm As FrmTypeClient = New FrmTypeClient
        frm.ShowDialog()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
End Class