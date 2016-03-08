Public Class FrmNouvelleAdresse

    Private Sub verifierChamps(sender As Object, e As EventArgs) Handles tbAdresse1.TextChanged
        If tbAdresse1.TextLength > 0 And tbNPA.TextLength >= 4 And
            tbVille.TabIndex > 0 Then
            btnConfirmer.Enabled = True
        Else
            btnConfirmer.Enabled = False
        End If
    End Sub

    Private Sub errProvider(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbNPA.Validating
        If Me.tbNPA.Text <> "" And Not (IsNumeric(Me.tbNPA.Text)) Then
            Me.erpNPA.SetError(Me.tbNPA, "L'entrée doit être numérique")
            e.Cancel = True
        Else
            Me.erpNPA.SetError(Me.tbNPA, "")
        End If
    End Sub

End Class