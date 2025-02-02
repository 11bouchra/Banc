Public Class Createur
    Public Shared Function GetUser(ByVal role As String) As IUtilisateur
        Try
            Select Case role.ToLower
                Case "administrateur"
                    Return New Administrateur(Service.user.Login, Service.user.Password)
                Case Else
                    Return New Inconnu(Service.user.Login, Service.user.Password)
            End Select
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
