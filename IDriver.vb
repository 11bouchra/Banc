Public Interface IDriver
    Function GetConnection(ByVal Connectionstring As String) As IDbConnection
    Function GetParameter(ByVal name As String, ByVal valeu As Object) As IDbDataParameter
    Function GetParameter() As IDbDataParameter
    Function GetDataAdapter(ByVal requet As String) As IDbDataAdapter
End Interface
