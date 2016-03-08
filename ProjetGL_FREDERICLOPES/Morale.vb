Public Class Morale
    Inherits Personne

    Private raisonSociale As String
    Private ide As String 'Il s'agit du N° unique de TVA de l'entreprise

    'DEBUT CONSTRUCTEURS
    Public Sub New(ByRef noPers As Integer)
        MyBase.New(noPers)
    End Sub

    Public Sub New(ByRef noPers As Integer, ide As String)
        Me.New(noPers)
        Me.ide = ide
    End Sub
    'FIN CONSTRUCTEURS

    'DEBUT DES ACCESSEURS
    Public Function getRaisonSociale() As String
        Return Me.raisonSociale
    End Function

    Public Function getIde() As String
        Return Me.ide
    End Function
    'FIN DES ACCESSEURS

End Class
