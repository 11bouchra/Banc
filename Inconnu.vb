Public Class Inconnu
    Inherits Utilisateur
    Public Sub New(ByVal Login As String, ByVal Password As String)
        MyBase.New(Login, Password)
    End Sub
    Public Overrides Sub AfficherMenu()
        MsgBox("je suis inconnu")
    End Sub
End Class
