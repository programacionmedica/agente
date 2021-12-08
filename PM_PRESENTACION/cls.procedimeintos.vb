Imports Microsoft.Office.Interop
Imports System.Net
Imports System.IO
Imports System
Public Class cls
    Public Sub S_ExportarDataGridViewExcel(ByVal xobjDatGrdViw As DataGridView, ByVal ruta_archivo As String)
        'Dim ruta$ = "C:\envio\Reporte_de_servicios" & Now.AddDays(-1).ToString("ddMMyyyy") & ".xlsx"
        Dim ruta = ruta_archivo
        'Dim t As System.Data.DataTable
        Dim appExc As New Excel.Application
        Dim wrkExc As Excel.Workbook
        Dim shtExc As Excel.Worksheet
        appExc.Visible = True
        wrkExc = appExc.Workbooks.Add
        shtExc = wrkExc.Worksheets(1)
        appExc.DisplayAlerts = False

        Windows.Forms.Cursor.Show()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        shtExc.Range("A1").Select()

        '_________________________ Cabecera de la Grilla MAD ____________________________________________________
        Dim NUM As Integer = xobjDatGrdViw.Columns.Count
        shtExc.Cells(2, 2) = "COD: "
        shtExc.Cells(3, 2) = "MM01023"
        shtExc.Range(shtExc.Cells(2, 2), shtExc.Cells(2, 4)).Interior.Color = RGB(140, 232, 116)
        shtExc.Cells(2, 3) = "   DOCTOR   "
        shtExc.Cells(3, 3) = " GUZMAN PEREZ RAMOS "
        shtExc.Cells(2, 4) = "   ESPECIALIDAD   "
        shtExc.Cells(3, 4) = "   CARDIOLOGÍA    "
        shtExc.Range(shtExc.Cells(2, 4), shtExc.Cells(2, 4)).Interior.Color = RGB(140, 232, 116)
        Dim objRango As Excel.Range = shtExc.Range(shtExc.Cells(2, 2), shtExc.Cells(3, 4))
        objRango.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        shtExc.Cells(5, 2) = "    FECHA     "
        shtExc.Cells(5, 3) = "HORA INICIO "
        shtExc.Cells(5, 4) = " HORA  FIN     "
        shtExc.Range(shtExc.Cells(6, 2), shtExc.Cells(100, 2)).NumberFormatLocal = "dd/mm/yyyy"
        shtExc.Range(shtExc.Cells(6, 3), shtExc.Cells(100, 3)).NumberFormatLocal = "HH:mm"
        shtExc.Range(shtExc.Cells(6, 4), shtExc.Cells(100, 4)).NumberFormatLocal = "HH:mm"
        shtExc.Range(shtExc.Cells(5, 2), shtExc.Cells(100, 4)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

        shtExc.Range(shtExc.Cells(5, 2), shtExc.Cells(5, 4)).Interior.Color = RGB(140, 232, 116)
        shtExc.Range(shtExc.Cells(5, 2), shtExc.Cells(5, 4)).Font.Bold = 1
        ' objRango.Cells.Interior.Color = RGB(122, 172, 81)
        '   objRango1.Cells.Interior.Color = RGB(140, 232, 116)
        objRango.Cells.Font.Bold = 1
        objRango.Cells.Font.Size = 12
        '  objRango.Merge(True) ' JUNTA LAS CELDAS DE ACUERDO A UN RANGO
        objRango.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        'For i As Integer = 1 To xobjDatGrdViw.Columns.Count 'DIBUJA EL BORDE Y AGREGA EL TEXTO DE LA CABECERA' 
        '    shtExc.Cells(2, i + 2) = xobjDatGrdViw.Columns(i - 1).HeaderText.ToUpper
        '    shtExc.Cells(2, i + 2).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble
        'Next
        'Dim objRango1 As Excel.Range = shtExc.Range(shtExc.Cells(2, 3), shtExc.Cells(2, 10 + 2))
        'objRango1.Cells.Interior.Color = RGB(140, 232, 116)
        'objRango1.Cells.Font.Bold = 1
        'objRango1.Cells.HorizontalAlignment = HorizontalAlignment.Center

        '___________________________ Detalle de la Grilla MAD ____________________________________________________
        'For i As Integer = 0 To xobjDatGrdViw.Rows.Count - 1
        '    For j As Integer = 0 To xobjDatGrdViw.Columns.Count - 1
        '        shtExc.Cells(i + 3, j + 3) = xobjDatGrdViw.Rows(i).Cells(j).Value
        '        shtExc.Cells(i + 3, j + 3).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        '    Next

        'Next



        '***********************************************************************************************************


        shtExc.Columns.AutoFit() ' AUTO AJUSTE DE CELDAS
        'PROTEGER CELDAS
        'shtExc.Range(shtExc.Cells(6, 2), shtExc.Cells(1000, 4)).Locked = False
        'shtExc.Range(shtExc.Cells(2, 3), shtExc.Cells(3, 3)).Locked = True
        'shtExc.Protect(DrawingObjects:=True, Contents:=True, Scenarios:=True)
        '**************************
        'shtExc.Columns.WrapText = True
        ''shtExc.Columns.AutoFit()
        'shtExc.Columns.HorizontalAlignment = 3  ' CENTRAR EN FORMA HORIZAONTAL
        'shtExc.Columns.VerticalAlignment = 2   ' CENTRAR EN DFORMA VERTICAL
        wrkExc.SaveAs(ruta)
        wrkExc.Close()
        appExc.Quit()


        releaseObject(appExc)
        releaseObject(wrkExc)
        releaseObject(shtExc)
    End Sub
    Public Shared Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try



    End Sub
End Class
