Public Class CreateurDriver
    Public Shared Function GetDriver(ByVal SGBD As String) As IDriver
        Select Case SGBD.ToLower
            Case "sql"
                Return New DriverSql

        End Select
    End Function
End Class
