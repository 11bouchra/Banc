Imports System.Data.SqlClient

Module Service
    Public Drv As IDriver
    Public user As IUtilisateur
    Public Function getparameters(ByVal name As String, ByVal value As String) As SqlParameter
        Dim P As New SqlParameter
        P.ParameterName = name
        P.Value = value
        Return P

    End Function
End Module
