Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing.Printing
Imports System.Drawing
'Imports PY_FAC_DOCTOR__LN
'Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Public Class Cls_Utilitarios
    Private prtSettings As PrinterSettings
    Private Declare Function GetProfileString Lib "kernel32" Alias "GetProfileStringA" ( _
    ByVal lpAppName As String, _
    ByVal lpKeyName As String, _
    ByVal lpDefault As String, _
    ByVal lpReturnedString As String, _
    ByVal nSize As Long) As Long
    Public Shared Function F_ObtenerUsuarioRed() As String
        Try
            Dim ws As Object
            Dim lstrMatUsu As String
            lstrMatUsu = ""
            ws = CreateObject("WScript.Network")
            lstrMatUsu = ws.UserName

            ws = Nothing
            Return UCase(lstrMatUsu)
        Catch ex As Exception
            Return ""
            MsgBox(Err.Description)
        End Try

    End Function
End Class
