Public Class Adresse
    Private adresse1 As String
    Private adresse2 As String
    Private npa As Byte
    Private ville As String
    Private pays As String
    Private cp As String

    Public Sub New(ByVal adresse1, adresse2, npa, ville, pays, cp)
        Me.adresse1 = adresse1
        Me.adresse2 = adresse2
        Me.npa = npa
        Me.ville = ville
        Me.pays = pays
        Me.cp = cp
    End Sub 'Constructeur
    Public Sub New(ByVal adresse1, npa, ville, pays, cp)
        Me.New(adresse1, "", npa, ville, pays, cp)
    End Sub 'Constructeur
    Public Sub New(ByVal adresse1, npa, ville, pays)
        Me.New(adresse1, npa, ville, pays, "")
    End Sub 'Constructeur
    Public Sub New()
        Me.New("", "", "", "", "", "")
    End Sub 'Constructeur

    ' Accesseurs de la class Adresse
    Public Function getAdresse()
        Return Me.adresse1
    End Function 'getAdresse1
    Public Function getNpa()
        Return Me.npa
    End Function 'getNpa
    Public Function getVille()
        Return Me.ville
    End Function

End Class
