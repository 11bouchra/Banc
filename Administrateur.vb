Public Class Administrateur
    Inherits Utilisateur
    Public Sub New(ByVal Login As String, ByVal Password As String)
        MyBase.New(Login, Password)
    End Sub
    Public Overrides Sub AfficherMenu()
        Dim M As New MenuUtilisateur
        M.Show()
    End Sub
End Class
