Imports Microsoft.Office.interop
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
'Import para PDF
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Net
Imports System.IO

Public Class ClsExportar
    Dim obj As New CLS_CONEXION
#Region "Metodo Exportar Excel"
    Public Sub Exportar_datagrid(ByVal datagrid As DataGridView)
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'Aca se agregan las cabeceras de nuestro datagrid.

        For i As Integer = 1 To datagrid.Columns.Count
            worksheet.Cells(1, i) = datagrid.Columns(i - 1).HeaderText
        Next

        'Aca se ingresa el detalle recorrera la tabla celda por celda

        For i As Integer = 0 To datagrid.Rows.Count - 1
            For j As Integer = 0 To datagrid.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = datagrid.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Aca le damos el formato a nuestro excel
        worksheet.Rows.Item(1).Font.Bold = 1
        worksheet.Rows.Item(1).HorizontalAlignment = 3
        worksheet.Columns.AutoFit()
        worksheet.Columns.HorizontalAlignment = 2

        app.Visible = True
        app = Nothing
        workbook = Nothing
        worksheet = Nothing
        FileClose(1)
        GC.Collect()
    End Sub
    Public Sub S_ExportarDataGridViewExcel(ByVal xobjDatGrdViw As DataGridView)

        Dim t As System.Data.DataTable


        Dim appExc As New Excel.Application
        Dim wrkExc As Excel.Workbook
        Dim shtExc As Excel.Worksheet
        Dim c As Integer
        Dim h As Integer
        ' Dim por As Decimal

        t = CType(xobjDatGrdViw.DataSource, System.Data.DataTable)

        Try
            '  ruta = cadCnx.cadenaConeccion(ruta, 7)
            ' If ruta <> "" Then
            appExc.Visible = False
            wrkExc = appExc.Workbooks.Add
            shtExc = wrkExc.Worksheets(1)

            Windows.Forms.Cursor.Show()
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            If t.Rows.Count > 0 Then
                For h = 0 To t.Columns.Count - 2
                    shtExc.Cells(1, h + 1).Value = t.Columns(h).ColumnName
                    shtExc.Cells(1, h + 1).Interior.ColorIndex = 10
                    shtExc.Cells(1, h + 1).Font.Bold = True

                    'shtExc.Cells(1, h + 1).Font.ColorIndex = 1234
                Next
                h = 0
                For c = 0 To t.Rows.Count - 1
                    For h = 0 To t.Columns.Count - 2
                        shtExc.Cells(c + 2, h + 1).Value = t.Rows(c).Item(h).ToString
                        shtExc.Cells(c + 2, h + 1).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    Next
                    ' lblDetalle.Text = "... " & (c + 1) & " registros exportados"
                    ' por = (c + 1) / t.Rows.Count
                    '  lblPor.Text = Format((por * 100), "0.0") & "%"
                    'lblTotal.Width = 375 * por
                    'lblPor.Location = New System.Drawing.Point((355) * por + 9, 59)

                Next
                If MessageBox.Show("¿Desea guardar la Exportacion?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim guardar As New SaveFileDialog
                    With guardar
                        .InitialDirectory = "C:\"
                        .Filter = "Excel | *.xlsx"
                        .Title = "Guardar Datos"
                    End With
                    If guardar.ShowDialog = DialogResult.OK Then
                        wrkExc.SaveAs(guardar.FileName)
                    End If
                End If
                ' End If
                appExc.Visible = True
            End If
        Catch ex As Exception
            Throw New Exception("Error en la cargar del archivo." & vbCrLf & ex.Message)
        Finally
            If Not IsNothing(shtExc) Then
                shtExc = Nothing
                wrkExc = Nothing
                appExc = Nothing
            End If
        End Try
        ' End Sub

    End Sub
    Public Sub S_Exportar_Detalle(ByVal xobjDatGrdViw As DataGridView)

        Dim t As System.Data.DataTable


        Dim appExc As New Excel.Application
        Dim wrkExc As Excel.Workbook
        Dim shtExc As Excel.Worksheet
        Dim c As Integer
        Dim h As Integer
        ' Dim por As Decimal

        t = CType(xobjDatGrdViw.DataSource, System.Data.DataTable)

        Try
            '  ruta = cadCnx.cadenaConeccion(ruta, 7)
            ' If ruta <> "" Then
            appExc.Visible = False
            wrkExc = appExc.Workbooks.Add
            shtExc = wrkExc.Worksheets(1)

            Windows.Forms.Cursor.Show()
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            If t.Rows.Count > 0 Then
                For h = 0 To t.Columns.Count - 1
                    shtExc.Cells(1, h + 1).Value = t.Columns(h).ColumnName
                    shtExc.Cells(1, h + 1).Interior.ColorIndex = 10
                    shtExc.Cells(1, h + 1).Font.Bold = True

                    'shtExc.Cells(1, h + 1).Font.ColorIndex = 1234
                Next
                h = 0
                For c = 0 To t.Rows.Count - 1
                    For h = 0 To t.Columns.Count - 2
                        shtExc.Cells(c + 2, h + 1).Value = t.Rows(c).Item(h).ToString
                        shtExc.Cells(c + 2, h + 1).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    Next
                Next
                If MessageBox.Show("¿Desea guardar la Exportacion?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim guardar As New SaveFileDialog
                    With guardar
                        .InitialDirectory = "C:\"
                        .Filter = "Excel | *.xlsx"
                        .Title = "Guardar Datos"
                    End With
                    If guardar.ShowDialog = DialogResult.OK Then
                        wrkExc.SaveAs(guardar.FileName)
                    End If
                End If
                ' End If
                appExc.Visible = True
            End If
        Catch ex As Exception
            Throw New Exception("Error en la cargar del archivo." & vbCrLf & ex.Message)
        Finally
            If Not IsNothing(shtExc) Then
                shtExc = Nothing
                wrkExc = Nothing
                appExc = Nothing
            End If
        End Try
        ' End Sub

    End Sub
    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
                ' MsgBox(exHoja.Cells.Item(1, i))
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se

            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False
        End Try

        Return True

    End Function

#End Region




End Class

