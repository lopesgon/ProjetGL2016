Public MustInherit Class Personne
    Protected noPers As Integer
    Protected adresse As Adresse
    Protected email As String
    Protected telephone As Integer
    Protected fax As Integer
    Protected iban As String

    'DEBUT DES CONSTRUCTEURS DE CLASS
    Public Sub New(ByRef noPers As Integer, adresse As Adresse, email As String,
                   telephone As Integer, fax As Integer, iban As String)
        Me.noPers = noPers
        Me.adresse = adresse
        Me.email = email
        Me.telephone = telephone
        Me.fax = fax
        Me.iban = iban
    End Sub 'Constructeur

    Protected Sub New(ByRef noPers As Integer)
        Me.New(noPers, New Adresse(), "", -1, -1, -1)
    End Sub 'Constructeur
    'FIN DES CONSTRUCTEURS DE CLASS

    'DEBUT DES ACCESSEURS DE CLASS
    Public Function getAdresse() As Adresse
        Return Me.adresse
    End Function

    Public Function getEmail() As String
        Return Me.email
    End Function

    Public Function getTelephone() As Integer
        Return Me.telephone
    End Function

    Public Function getFax() As Integer
        Return Me.fax
    End Function

    Public Function getIban() As String
        Return Me.iban
    End Function

    Public Function getNoPers() As Integer
        Return Me.noPers
    End Function
    'FIN DES ACCESSEURS DE CLASS

    Public Overrides Function equals(o As Object) As Boolean
        Dim p As Personne = CType(o, Personne)
        Return Me.noPers = p.getNoPers()
    End Function

End Class
