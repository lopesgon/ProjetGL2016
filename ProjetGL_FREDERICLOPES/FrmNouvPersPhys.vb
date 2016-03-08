Public Class FrmNouvPersPhys
    Private Sub FrmNouvPersPhys_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAjoutAdresse_Click(sender As Object, e As EventArgs) Handles btnAjoutAdresse.Click
        Dim frmAdresse As FrmNouvelleAdresse = New FrmNouvelleAdresse
        frmAdresse.ShowDialog()
    End Sub
End Class