Imports DLL_NEGOCIO
Imports DLL_DATOS
Public Class Frm_ManteTurnos
    Dim obj As New ClsExportar
    Dim xcod_esp As String
    Dim col, fil%
    Dim valor1, valor2, cad$
    Dim _xturno, _xturno2$
    Dim _fec As Date
    Private Sub Frm_ManteTurnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x%
        For x = 0 To dgvMañana.ColumnCount - 1
            dgvMañana.Columns(x).Width = 40
        Next
        llenar_combobox(cbo_especialidad)
    End Sub
    Sub llenar_combobox(ByVal combo As ComboBox)
        With combo
            .Items.Add("PEDIATRIA")
            .Items.Add("MEDICINA")
            .Items.Add("CARDIOLOGIA")
            .Items.Add("ENDOCRINOLOGIA")
            .Items.Add("NEUMOLOGIA")
            .Items.Add("NUTRICIONISTA")
        End With
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_especialidad.SelectedIndexChanged
        If cbo_especialidad.SelectedIndex = 0 Then xcod_esp = "005"
        If cbo_especialidad.SelectedIndex = 1 Then xcod_esp = "006" '' + 10
        If cbo_especialidad.SelectedIndex = 2 Then xcod_esp = "001"
        If cbo_especialidad.SelectedIndex = 3 Then xcod_esp = "011"
        If cbo_especialidad.SelectedIndex = 4 Then xcod_esp = "027"
        If cbo_especialidad.SelectedIndex = 5 Then xcod_esp = "026"
        'doctores_especialidad(xcod_esp)
    End Sub
    Sub corregir_hora(ByVal grid As DataGridView, ByVal texto As String, ByVal col As Integer, ByVal anterior$, ByVal nuevo As String)
        For Each columna As DataGridViewColumn In grid.Columns
            If columna.Name.ToString = texto Then
                For x = 0 To grid.Rows.Count - 1
                    If grid.Item(col, x).Value.ToString = anterior Then ''Z
                        grid.Item(col, x).Value = DBNull.Value
                        grid.Item(col, x).Value = Convert.ToString(nuevo)
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        _xturno = Microsoft.VisualBasic.Left(cbo_turno.Text.ToUpper, 1)
        _xturno2 = Microsoft.VisualBasic.Left(cbo_turno.Text.ToUpper, 3)
        _fec = CDate(dtp_fecha.Text)
        If cbo_especialidad.SelectedIndex = 0 Then xcod_esp = "005"
        If cbo_especialidad.SelectedIndex = 1 Then xcod_esp = "006" '' + 10
        If cbo_especialidad.SelectedIndex = 2 Then xcod_esp = "001"
        If cbo_especialidad.SelectedIndex = 3 Then xcod_esp = "011"
        If cbo_especialidad.SelectedIndex = 4 Then xcod_esp = "027"
        If cbo_especialidad.SelectedIndex = 5 Then xcod_esp = "026"

        If _xturno2 = "MAÑ" Then
            dgv_doctores.DataSource = DLL_PROCEDURE.Listado("select cod_doc,nom_doc,horini_asig_doc,horfin_asig_doc from t_prog_doctorxturno where cod_esp ='" & xcod_esp & "' and turno='" & _xturno & "' and fecini_asig='" & _fec & "'")
            Programacion_Grilla(dgvMañana)
            llenado_pintado(dgvMañana)
            dgvMañana.Visible = True
            dgvTarde.Visible = False
            dgvMadrugada.Visible = False
            lblhora.Text = Sumar("colhoraM", dgvMañana)
            lblcantidad.Text = dgv_doctores.Rows.Count
            'colorea_grafico(dgvMañana)
        End If
        If _xturno2 = "TAR" Then
            dgv_doctores.DataSource = DLL_PROCEDURE.Listado("select cod_doc,nom_doc,horini_asig_doc,horfin_asig_doc from t_prog_doctorxturno where cod_esp ='" & xcod_esp & "' and turno='" & _xturno & "' and fecini_asig='" & _fec & "'")
            corregir_hora(dgv_doctores, "horfin_asig_doc", 3, "00:00:00", "23:59:00")
            Programacion_Grilla(dgvTarde)
            llenado_pintado(dgvTarde)
            dgvMañana.Visible = False
            dgvTarde.Visible = True
            dgvMadrugada.Visible = False
            lblhora.Text = Sumar("colhoraT", dgvTarde)
            lblcantidad.Text = dgv_doctores.Rows.Count
            'colorea_grafico(dgvTarde)
        End If
        If _xturno2 = "MAD" Then
            _xturno = "Z"
            dgv_doctores.DataSource = DLL_PROCEDURE.Listado("select cod_doc,nom_doc,horini_asig_doc,horfin_asig_doc from t_prog_doctorxturno where cod_esp ='" & xcod_esp & "' and turno='" & _xturno & "' and fecini_asig='" & _fec & "'")
            Programacion_Grilla(dgvMadrugada)
            llenado_pintado(dgvMadrugada)
            dgvMañana.Visible = False
            dgvTarde.Visible = False
            dgvMadrugada.Visible = True
            lblcantidad.Text = dgv_doctores.Rows.Count
            lblhora.Text = Sumar("colhoraN", dgvMadrugada)
        End If

    End Sub
    Sub Programacion_Grilla(ByVal grid As DataGridView)
        Dim datos As New DataTable
        datos = DLL_PROCEDURE.Listado("select nom_doc from t_prog_doctorxturno where cod_esp ='" & xcod_esp & "' and turno='" & _xturno & "' and fecini_asig='" & _fec & "'")
        grid.Rows.Clear()
        If dgv_doctores.RowCount - 1 = 0 Then MsgBox("No se encontro registro.")

        Dim x As Integer = dgv_doctores.Rows.Count
        grid.Rows.Clear()
        For i = 0 To x - 1
            grid.Rows.Add()
        Next
        For i = 0 To datos.Rows.Count - 1
            grid.Rows(i).Cells(0).Value = datos.Rows(i)(0)
        Next
        grid.Columns(0).Width = 100
    End Sub
    Sub llenado_pintado(ByVal grid As DataGridView)
        Dim sum, fil, col%
        For fil = 0 To grid.Rows.Count - 1 ' Recorre las filas del datagrid principal
            sum = 0
            For col = 1 To grid.ColumnCount - 1 ' Recorre las columnas del datagrid principal
                valor1 = Mid(dgv_doctores.Rows(fil).Cells(2).Value.ToString, 1, 5)
                valor2 = Mid(dgv_doctores.Rows(fil).Cells(3).Value.ToString, 1, 5)
                'MsgBox(grid.Columns(col).HEADERTEXT)
                If grid.Columns(col).HEADERTEXT >= valor1 And grid.Columns(col).HEADERTEXT <= valor2 Then
                    grid.Rows(fil).Cells(col).Value = "1"
                    'grid.Rows(fil).Cells(col).Style.BackColor = Color.Goldenrod
                    sum = sum + 1
                End If
            Next
            grid.Rows(fil).Cells(col - 1).Value = Val(sum / 2)
        Next
    End Sub
    Sub colorea_grafico(ByVal grid As DataGridView)
        Dim col%
        For Each Row As DataGridViewRow In grid.Rows
            For col = 1 To grid.Columns.Count - 1
                With grid
                    If .Rows(0).Cells(col).value = "1" Then
                        .Rows(0).Cells(col).Style.BackColor = Color.IndianRed
                    End If
                    If .Rows(1).Cells(col).value = "1" Then
                        .Rows(1).Cells(col).Style.BackColor = Color.GreenYellow
                    End If
                    If .Rows(2).Cells(col).value = "1" Then
                        .Rows(2).Cells(col).Style.BackColor = Color.Indigo
                    End If
                    If .Rows(3).Cells(col).value = "1" Then
                        .Rows(3).Cells(col).Style.BackColor = Color.Honeydew
                    End If
                    If .Rows(4).Cells(col).value = "1" Then
                        .Rows(4).Cells(col).Style.BackColor = Color.Ivory
                    End If
                    If .Rows(5).Cells(col).value = "1" Then
                        .Rows(5).Cells(col).Style.BackColor = Color.HotPink
                    End If
                    If .Rows(6).Cells(col).value = "1" Then
                        .Rows(6).Cells(col).Style.BackColor = Color.IndianRed
                    End If
                    If .Rows(7).Cells(col).value = "1" Then
                        .Rows(7).Cells(col).Style.BackColor = Color.Lavender
                    End If

                End With


            Next

        Next
    End Sub
    Private Function Sumar( _
       ByVal nombre_Columna As String, _
       ByVal Dgv As DataGridView) As Double
        Dim total As Double = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        ' retornar el valor  
        Return total
    End Function

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Dim obj As New DLL_DATOS.ClsExportar
        Select Case cbo_turno.Text
            Case "MAÑANA"
                If dgvMañana.RowCount = 0 Then
                    MsgBox("No hay registros, favor de consultar una busqueda de disponibilidad.!")
                Else
                    obj.GridAExcel(dgvMañana)
                    ' obj.Exportar_datagrid(dgv_reporte)
                    'Process.Start("C:\Horario_1.xls")
                    Process.GetCurrentProcess.Dispose()
                End If
            Case "TARDE"
                If dgvTarde.RowCount = 0 Then
                    MsgBox("No hay registros, favor de consultar una busqueda de disponibilidad.!")
                Else
                    obj.GridAExcel(dgvTarde)
                    ' obj.Exportar_datagrid(dgv_reporte)
                    'Process.Start("C:\Horario_1.xls")
                    Process.GetCurrentProcess.Dispose()
                End If
            Case "MADRUGADA"
                If dgvMadrugada.RowCount = 0 Then
                    MsgBox("No hay registros, favor de consultar una busqueda de disponibilidad.!")
                Else
                    obj.GridAExcel(dgvMadrugada)
                    ' obj.Exportar_datagrid(dgv_reporte)
                    'Process.Start("C:\Horario_1.xls")
                    Process.GetCurrentProcess.Dispose()
                End If

        End Select


       

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click, Label8.Click, Label7.Click

    End Sub
End Class