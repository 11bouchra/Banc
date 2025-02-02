Public Class Utilisateur
    Implements Iutilisateur

    Private _Auth As Authentification
    Private _Login As String
    Private _Password As String

    Public Overridable Sub AfficherMenu() Implements Iutilisateur.AfficherMenu

    End Sub

    Public Property Auth() As Authentification Implements Iutilisateur.Auth
        Get
            Return Me._Auth
        End Get
        Set(ByVal value As Authentification)
            Me._Auth = value
        End Set
    End Property

    Public Property Login() As String Implements Iutilisateur.Login
        Get
            Return Me._Login
        End Get
        Set(ByVal value As String)
            Me._Login = value
        End Set
    End Property

    Public Property Password() As String Implements Iutilisateur.Password
        Get
            Return Me._Password
        End Get
        Set(ByVal value As String)
            Me._Password = value
        End Set
    End Property
    Public Sub New(ByVal Login As String, ByVal Password As String)
        Me._Login = Login
        Me._Password = Password
        Me._Auth = New Authentification(Me)
    End Sub
    Public Sub New()

    End Sub
End Class
