Public Class Dao
    Public Shared Function GetTypeuser() As String
        Dim cmd As IDbCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = "select role from utilisateur where utilisateur.login='" & Service.user.Login & "'"
        Dim s As String = cmd.ExecuteScalar
        Return s
    End Function
    Public Shared Function GetData(ByVal Da As IDbDataAdapter) As DataTable
        Dim Ds As New DataSet
        Try
            Da.Fill(Ds)
        Catch ex As Exception

        End Try
        Return Ds.Tables(0)
    End Function
End Class
