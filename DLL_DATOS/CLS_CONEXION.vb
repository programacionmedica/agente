Imports System.Data.Odbc
Imports System.Data

Public Class CLS_CONEXION
    Public Shared CADENA As String = "Dsn=PostgreSQL;database=hipocrates;server=10.6.16.14;port=5432;uid=postgres;readonly=0"
    'Public Shared CADENA As String = "Dsn=PostgreSQL;database=pruebitas;server=10.6.16.133;port=5432;uid=postgres;password=postgres;"
    Public Shared CN As New Odbc.OdbcConnection(CADENA)
    Public CMD As OdbcCommand = CN.CreateCommand()
End Class
