Imports System.Data.SqlClient
Public Class DriverSql
    Inherits Driver
    Protected Overrides Function Creatconnection(ByVal Connectionstring As String) As System.Data.IDbConnection
        Dim cnx As IDbConnection
        cnx = New sqlconnection
        cnx.ConnectionString = Connectionstring
        Return cnx
    End Function
    Protected Overrides Function CreatDataAdapter(ByVal requet As String) As IDbDataAdapter
        Dim cmd As SqlCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = requet
        Dim Da As New SqlDataAdapter(cmd)
        Try
            Dim cb As New SqlCommandBuilder(Da)
            Da.InsertCommand = cb.GetInsertCommand
            Da.DeleteCommand = cb.GetDeleteCommand
            Da.UpdateCommand = cb.GetUpdateCommand
        Catch ex As Exception

        End Try
        Return Da
    End Function
    Protected Overrides Function creatParameter() As IDbDataParameter

    End Function
    Protected Overrides Function creatParameter(ByVal nom As String, ByVal value As Object) As IDbDataParameter
        Dim p As New SqlParameter
        p.ParameterName = nom
        p.Value = value
        Return p
    End Function
End Class
