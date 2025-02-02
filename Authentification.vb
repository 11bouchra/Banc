Public Class Authentification
    Private Util As IUtilisateur
    Private _CNX As IDbConnection
    Public Sub New(ByVal util As Utilisateur)
        Me.Util = util
    End Sub
    Public Sub Authentifier()
        Service.Drv = CreateurDriver.GetDriver("sql")
        Service.user = Me.Util
        Service.user.Auth.cnx = Service.Drv.GetConnection(" server=(local) ; database=populaire ;user =" & Me.Util.Login & " ; pwd =" & Me.Util.Password)
        Try
            Service.user.Auth.cnx.Open()

            Dim U As Utilisateur = Createur.GetUser(Dao.GetTypeuser())
            U.Auth.cnx = Service.user.Auth.cnx
            Service.user = U
            Me.Util = U
        Catch ex As Exception
            'MsgBox(ex.Message)
            Me.Util = New Inconnu(Service.user.Login, Service.user.Password)
        End Try
        Me.Util.AfficherMenu()
    End Sub
    Public Property cnx() As IDbConnection
        Get
            Return Me._CNX
        End Get
        Set(ByVal value As IDbConnection)
            Me._CNX = value
        End Set
    End Property
End Class
