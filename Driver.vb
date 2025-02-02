Public Class Driver
    Implements IDriver


    Public Function GetConnection(ByVal Connectionstring As String) As System.Data.IDbConnection Implements IDriver.GetConnection
        Return Creatconnection(Connectionstring)
    End Function
    Protected Overridable Function Creatconnection(ByVal connectionstring As String) As System.Data.IDbConnection

    End Function

    Public Function GetDataAdapter(ByVal requet As String) As System.Data.IDbDataAdapter Implements IDriver.GetDataAdapter
        Return CreatDataAdapter(requet)
    End Function
    Protected Overridable Function CreatDataAdapter(ByVal requet As String) As System.Data.IDbDataAdapter

    End Function

    Public Function GetParameter() As System.Data.IDbDataParameter Implements IDriver.GetParameter
        Return CreatParameter()
    End Function
    Protected Overridable Function CreatParameter() As System.Data.IDbDataParameter

    End Function
    Public Function GetParameter(ByVal name As String, ByVal valeu As Object) As System.Data.IDbDataParameter Implements IDriver.GetParameter
        Return CreatParameter(name, valeu)
    End Function
    Protected Overridable Function CreatParameter(ByVal name As String, ByVal value As Object) As System.Data.IDbDataParameter

    End Function
End Class
