Imports System.IO
Imports System
Public Class frm_importar
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim xls_cn As New OleDb.OleDbConnection
        Dim xls_cmd As New OleDb.OleDbCommand
        Dim xls_reader As New OleDb.OleDbDataAdapter
        Try
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then

                MsgBox("Selecciona un archivo.")
                Exit Sub
            Else
                Dim strExtension As String = ""
                Dim nombreXls As String
                Dim m_Excel As Microsoft.Office.Interop.Excel.Application
                nombreXls = OpenFileDialog1.FileName
                xls_cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + nombreXls + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'"
                Using xls_cn
                    m_Excel = CreateObject("Excel.Application")
                    m_Excel.Workbooks.Open(nombreXls)
                    xls_cmd.CommandText = "SELECT * FROM [Hoja1$]"
                    xls_cmd.Connection = xls_cn
                    xls_reader.SelectCommand = xls_cmd
                    Dim da As New OleDb.OleDbDataAdapter(xls_cmd)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                    txtcod.Text = Trim(DataGridView1.Item(0, 0).Value.ToString)
                    txtdoc.Text = Trim(DataGridView1.Item(1, 0).Value.ToString)
                    txtesp.Text = Trim(DataGridView1.Item(2, 0).Value.ToString)


                    'For         txtesp.Text = Trim(DataGridView1.Item(2, 0).Value.ToString)



                End Using
                If Not m_Excel Is Nothing Then
                    xls_cn.Close()
                    m_Excel.Quit()
                    m_Excel = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox("Error" & Chr(13) & Chr(13) & ex.Message)
        End Try
    End Sub
End Class