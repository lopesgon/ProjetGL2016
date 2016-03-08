Public Class Physique
    Inherits Personne

    Private nom As String
    Private prenom As String

    Public Sub New(ByRef noPers As Integer, nom As String, prenom As String)
        MyBase.New(noPers)
        Me.nom = nom
        Me.prenom = prenom
    End Sub

End Class
