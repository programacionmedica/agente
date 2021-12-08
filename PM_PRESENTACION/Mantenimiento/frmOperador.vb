Imports DLL_NEGOCIO
Imports DLL_DATOS
Imports System.Management
Imports System.Data
Imports System.Net.Dns
Imports System.Windows
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports VB = Microsoft.VisualBasic

Public Class frmOperador
    Public codesp_b As String
    Dim dt As New DataTable

    Private Sub btn_busqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_busqueda.Click
        FILTRAR("")
    End Sub


    Public Sub FILTRAR(ByVal FILTRO As String)
        Dim FIL As String = ""
        Dim cod_zona, turno, _xturno As String
        Dim _xfec_ini As DateTime = (dtp_fecini_asig_bus.Text)
        Dim _xfec_fin As DateTime = (dtp_fecfin_asig_bus.Text)
        Dim flag$

        _xturno = ""
        ' codesp_b = ""
        flag = ""
        Call Chekeo_listEspecialidades()
        'Turno 
        'CONFIRMADO()
        'SIN(CONFIRMAR)
        'REGISTRADO()
        'TODOS()

        If cbo_flag.SelectedIndex = 0 Then flag = "2"
        If cbo_flag.SelectedIndex = 1 Then flag = "1"
        If cbo_flag.SelectedIndex = 2 Then flag = "0"
        'If cbo_flag.SelectedIndex = 2 Then flag = "C"
        If cbo_flag.SelectedIndex = 3 Then flag = "0','1','2"
        turno = cbo_xturno.Text
        If turno = "MAÑANA" Then _xturno = "M"
        If turno = "TARDE" Then _xturno = "T"
        If turno = "MADRUGADA" Then _xturno = "Z"
        If turno = "TODOS" Then _xturno = "M','T','Z"
        If cbo_clasificacion.Text = "[---Seleccione clasificacion---]" Then
            MsgBox("Seleccione un tipo de clasificacion! - {Agudo//Cronico}")
            Exit Sub
        End If

        Dim clasif$
        clasif = ""
        If cbo_clasificacion.SelectedItem.ToString = "AGUDO" Then
            clasif = "nom_clasif in ('AGUDO')"
        End If
        If cbo_clasificacion.SelectedItem.ToString = "CRONICO" Then
            clasif = "nom_clasif in ('CRONICO')"
        End If
        If cbo_clasificacion.SelectedItem.ToString = "AUTO COVID" Then
            clasif = "nom_clasif in ('AUTO COVID')"
        End If
        If cbo_clasificacion.SelectedItem.ToString = "TODOS" Then
            clasif = "nom_clasif in ('AGUDO','CRONICO')"
        End If
        If cbo_clasificacion.SelectedItem.ToString = "NINGUNA" Then
            clasif = "nom_clasif isnull"
        End If


        '**********MODICACIONES POR ALEX ****************
        If chk_todos.Checked = True Then
            For X = 1 To 12 Step +1

                If X < 10 Then
                    cod_zona = cod_zona & "'ZONA 0" & X & "',"
                ElseIf X < 12 Then
                    cod_zona = cod_zona & "'ZONA " & X & "',"
                Else
                    cod_zona = cod_zona & "'ZONA " & X & "'"
                End If
            Next
        Else

            cod_zona = "'" & cbo_zona_bus.SelectedItem.ToString & "'"
        End If
        If FILTRO = "" Then
            FIL = "fecha,zona,turno,horini"
        Else
            FIL = cbo_detalle.Text
        End If
        Llenar_GridView(dgv_reporte, "select to_char(fecini_asig,'yyyy/MM/dd') as FECHA,nom_doc  as Doctor,turno,cod_botiquin as botiquin,zona as sub_zona,nom_clasif as clasificacion,to_char(horini_asig_doc,'HH24:MI') as HorIni,to_char(horfin_asig_doc,'HH24:MI') as HorFin,des_doc as descripcion,nom_mot as Conductor,case when con_mpos = false then 'No' else 'Si' end Con_Mpos,to_char(horini_asig_mot,'HH24:MI') as Hor_ini,to_char(horfin_asig_mot,'HH24:MI') as hor_fin,estado_prog as estado  from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp AND t_prog_doctorxturno.cod_esp in('" & txtcod_esp.Text & "')  AND TURNO in ('" & _xturno & "') and zona IN (" & cod_zona & " ) and t_prog_doctorxturno.fecini_asig between '" & _xfec_ini.ToString("yyyy/MM/dd") & "' and '" & _xfec_fin.ToString("yyyy/MM/dd") & "' and nom_doc like '%" & txtnom_doc.Text.ToUpper & "%' and estado_prog in ('" & flag & "') and " & clasif & " order by " & FIL & " asc")
        'Llenar_GridView(DgvBusqueda, "select cod_asig as codigo,nom_doc  as Doctor,turno,cod_botiquin as botiquin,nom_clasif as clasificacion,des_doc as descripcion,to_char(fecini_asig,'dd-MM-yyyy') AS FECHA,to_char(horini_asig_doc,'HH24:MI') as HorIni,to_char(horfin_asig_doc,'HH24:MI') as HorFin,nom_mot as Conductor,case when con_mpos = false then 'No' else 'Si' end Con_Mpos,to_char(horini_asig_mot,'HH24:MI') as Hor_ini,to_char(horfin_asig_mot,'HH24:MI') as hor_fin,estado_prog as estado ,cod_doc,cod_mot   from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp AND t_prog_doctorxturno.cod_esp in('" & txtcod_esp.Text & "') and zona IN (" & cod_zona & " ) AND TURNO in ('" & _xturno & "') and t_prog_doctorxturno.fecini_asig between '" & _xfec_ini.ToString("yyyy-MM-dd") & "' and '" & _xfec_fin.ToString("yyyy-MM-dd") & "' and nom_doc like '%" & txtnom_doc.Text.ToUpper & "%'  and estado_prog in ('" & flag & "')and " & clasif & "   order by " & FIL & " asc")
        Llenar_GridView(DgvBusqueda, "select t_dxc.cod_asig as codigo,t_dxc.nom_doc  as Doctor  , mp.nom_pais as nacionalidad,((current_date - mdoc.fec_nac)/365) edad  , t_dxc.turno,t_dxc.cod_botiquin as botiquin,t_dxc.nom_clasif as clasificacion,t_dxc.des_doc as descripcion,to_char(t_dxc.fecini_asig,'dd-MM-yyyy') AS FECHA,to_char(t_dxc.horini_asig_doc,'HH24:MI') as HorIni,to_char(t_dxc.horfin_asig_doc,'HH24:MI') as HorFin,t_dxc.nom_mot as Conductor,case when t_dxc.con_mpos = false then 'No' else 'Si' end Con_Mpos,to_char(t_dxc.horini_asig_mot,'HH24:MI') as Hor_ini,to_char(t_dxc.horfin_asig_mot,'HH24:MI') as hor_fin,t_dxc.estado_prog as estado ,t_dxc.cod_doc,t_dxc.cod_mot   from t_prog_doctorxturno t_dxc inner join m_especialidades esp on (t_dxc.cod_esp=esp.cod_esp) inner join m_doctores mdoc on (t_dxc.cod_doc= mdoc.cod_doc) inner join mae_pais mp on (mdoc.id_pais= mp.id_pais)  where t_dxc.cod_esp in('" & txtcod_esp.Text & "')  AND TURNO in ('" & _xturno & "') and zona IN (" & cod_zona & " ) and t_dxc.fecini_asig between '" & _xfec_ini.ToString("yyyy/MM/dd") & "' and '" & _xfec_fin.ToString("yyyy/MM/dd") & "' and t_dxc.nom_doc like '%" & txtnom_doc.Text.ToUpper & "%' and estado_prog in ('" & flag & "') and " & clasif & " order by " & FIL & " asc")

        If DgvBusqueda.RowCount > 0 Then
            corregir_columna(DgvBusqueda, "turno", 2, "Z", "N")
            corregir_columna(dgv_reporte, "turno", 2, "Z", "N")
            ''CORRREGIR LA COLUMNA ZONA
            corregir_columna_zonas(dgv_reporte, 4)
            corregir_columna_zonas(DgvBusqueda, 4)
            medidas_grilla(DgvBusqueda)
            medidas_Reporte(dgv_reporte)
        Else
            MessageBox.Show("No se encontro Registros", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lbl_cantmedico.Text = DgvBusqueda.Rows.Count
    End Sub




    Private Sub txtnom_doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtnom_doc.Text = "" Then
                MessageBox.Show("Ingresar Nombre del Medico", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                FILTRAR("")
            End If
        End If
    End Sub

    Private Sub frmOperador_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If INI_SESSION > 1 Then
         
            End
        End If
    End Sub
    Private Sub frmOperador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm1.Hide()
        'INI_SESION = 1 SON LOS ADMINISTRADORES COD ACCESO 95
        'INI_SESION =2 OPERADOR  SOLO VISUALIZA
        'INI_SESION =3 SON LOS QUE REGISTRAN INCIDENCIAS 102


        If INI_SESSION = 1 Then
            btn_quitar.Enabled = True
            btn_incidencia.Enabled = True
        ElseIf INI_SESSION = 2 Then
            btn_quitar.Enabled = False
            btn_incidencia.Enabled = False
        ElseIf INI_SESSION = 3 Then
            btn_quitar.Enabled = False
            btn_incidencia.Enabled = True
        End If
        cbo_zona_bus.SelectedIndex = 0
        '   cbo_especialidad.Items.Clear()
        ' llenar_combobox(cbo_especialidad) e cambia por checkbox
        '  Call Llenar_Combo(cbo_zona_bus, "select DISTINCT(cod_zona) from m_distritos order by cod_zona asc", "cod_zona", "des_dis")
    End Sub
    Sub Llenar_GridView(ByVal grid As DataGridView, ByVal sql As String)
        grid.DataSource = DLL_PROCEDURE.Listado(sql)
        'grid.AutoResizeColumns()
        'grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        lbl_cantmedico.Text = grid.RowCount
    End Sub
    Sub Chekeo_listEspecialidades()
        Dim sb, nom_esp_bus As New System.Text.StringBuilder
        Dim i As Integer
        For i = 0 To Me.chk_lista_doctor.CheckedItems.Count - 1
            If chk_lista_doctor.CheckedItems(i) = "PEDIATRIA" Then
                sb.Append("'005'")
                nom_esp_bus.Append("PEDIATRIA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "MEDICINA" Then
                sb.Append("'010','006'")
                nom_esp_bus.Append("MEDICINA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "CARDIOLOGIA" Then
                sb.Append("'001'")
                nom_esp_bus.Append("CARDIOLOGIA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "ENDOCRINOLOGIA" Then
                sb.Append("'011'")
                nom_esp_bus.Append("ENDOCRINOLOGIA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "NEUMOLOGIA" Then
                sb.Append("'027'")
                nom_esp_bus.Append("NEUMOLOGIA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "NUTRICIONISTA" Then
                sb.Append("'026'")
                nom_esp_bus.Append("NUTRICIONISTA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "ESPECIALISTA" Then
                sb.Append("'012','003','009'")
                nom_esp_bus.Append("ESPECIALISTA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "INTERNISTA" Then
                sb.Append("'010'")
                nom_esp_bus.Append("INTERNISTA")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
            If chk_lista_doctor.CheckedItems(i) = "GENERAL" Then
                sb.Append("'006'")
                nom_esp_bus.Append("GENERAL")
                sb.Append(",")
                nom_esp_bus.Append(",")
            End If
        Next i
        Dim CAD As String
        If sb.ToString = "" Then
            MessageBox.Show("INGRESE LA ESPECIALIDAD", "HORARIO", MessageBoxButtons.OK)
            Exit Sub
        Else
            CAD = (sb.ToString.Remove(sb.ToString.Length - 1, 1))
            txtcod_esp.Text = (Mid(CAD, 2, CAD.ToString.Length - 2))
            txtnom_esp.Text = nom_esp_bus.ToString()
        End If

    End Sub

    Sub corregir_columna(ByVal grid As DataGridView, ByVal texto As String, ByVal col As Integer, ByVal anterior$, ByVal nuevo$)
        For Each columna As DataGridViewColumn In grid.Columns
            If columna.Name.ToString = texto Then
                For x = 0 To grid.Rows.Count - 1
                    'MsgBox(grid.Item(col, x).Value)
                    If grid.Item(col, x).Value = anterior Then ''Z
                        grid.Item(col, x).Value = nuevo     ''N
                    End If
                Next
            End If
        Next
    End Sub
    Sub corregir_columna_zonas(ByVal grid As DataGridView, ByVal colu As Integer)


        Dim cadena$
        For Each columna As DataGridViewColumn In grid.Columns
            If columna.Name.ToString = "sub_zona" Then
                For x = 0 To grid.Rows.Count - 1

                    cadena = (Microsoft.VisualBasic.Trim(grid.Item(colu, x).Value))
                    cadena = Microsoft.VisualBasic.Right(cadena, 2)

                    If grid.Item(colu, x).Value = (grid.Item(colu, x).Value) Then ''Z
                        'MsgBox(grid.Item(3, x).Value)
                        grid.Item(colu, x).Value = cadena     ''N
                    End If

                Next
            End If
        Next columna
    End Sub
    Sub medidas_grilla(ByVal grid As DataGridView)
        With grid
            .Columns(0).Width = 50
            .Columns(1).Width = 220
            .Columns(2).Width = 100
            .Columns(3).Width = 45
            .Columns(4).Width = 40
            .Columns(5).Width = 30
            .Columns(6).Width = 70
            .Columns(7).Width = 220
            .Columns(8).Width = 70
            .Columns(9).Width = 45
            .Columns(10).Width = 45
            .Columns(11).Width = 220
            .Columns(12).Width = 45
            .Columns(13).Width = 50
            .Columns(14).Width = 45
            .Columns(15).Width = 50
            .Columns(16).Width = 5
            .Columns(17).Width = 5

        End With
    End Sub
    Sub medidas_Reporte(ByVal grid As DataGridView)
        With grid
            .Columns(0).Width = 120
            .Columns(1).Width = 200
            .Columns(2).Width = 40
            .Columns(3).Width = 30
            .Columns(4).Width = 45
            .Columns(5).Width = 45
            .Columns(6).Width = 200
            .Columns(7).Width = 100
            .Columns(8).Width = 45
            .Columns(9).Width = 45


        End With
    End Sub

    Private Sub btn_exporta_pdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exporta_pdf.Click
        Try
            ' Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            ' Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc, dgv_reporte)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            '  Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ExportarDatosPDF(ByVal document As Document, ByVal grid1 As DataGridView)
        'alex

        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.  
        Dim datatable As New PdfPTable(grid1.ColumnCount)
        'Dim fonts As iTextSharp.text.pdf.BaseFont
        'fonts = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
        Dim nom_esp, NOM_USUARIO$
        Dim FEC_REP, FEC_FIN As Date
        FEC_REP = dtp_fecini_asig_bus.Text
        nom_esp = txtnom_esp.Text
        FEC_FIN = dtp_fecfin_asig_bus.Text
        NOM_USUARIO = "OPERADOR"
        'MsgBox(nom_esp)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 1
        Dim headerwidths As Single() = GetColumnasSize()
        ' Dim headerhights As Single() = GetHightSize()
        datatable.SetWidths(headerwidths)
        'datatable.DefaultCell.HeaderHeight = headerhights
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'datatable.DefaultCell.
        '   datatable.

    

        'Se crea el encabezado en el PDF.  
        Dim encabezado As New Paragraph("REPORTE DE HORARIO", New Font(Font.Name = "Tahoma", 12, Font.Bold))
        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("ESPECIALIDAD DE: " & nom_esp, New Font(Font.Name = "Tahoma", 10, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To grid1.ColumnCount - 1
            Dim cell1 As New Phrase(grid1.Columns(i).HeaderText.ToUpper, New Font(Font.Name = "Tahoma", 9, Font.Bold))
            datatable.AddCell(cell1)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
    

        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        For i As Integer = 0 To grid1.Rows.Count - 1
            For j As Integer = 0 To grid1.Columns.Count - 1

                Dim cell As New Phrase((grid1(j, i).Value).ToString, New Font(Font.Name = "Arial black", 8, Font.Bold))
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next
        'da 2 tab entre columnas
        datatable.AddCell("")
        datatable.AddCell("")
        'imprime resultados
        'datatable.AddCell(grid1(2, 6).Value)
        'datatable.AddCell(grid1(3, 6).Value)
        datatable.CompleteRow()
        ' Dim CELDA As iTextSharp.text.Font = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Se agrega etiquetas
        Dim texto2 As New Phrase("FECHA:" & FEC_REP, New Font(Font.Name = "Tahoma", 12, Font.Bold))
        Dim texto3 As New Phrase("AL: " & FEC_FIN, New Font(Font.Name = "Tahoma", 10, Font.Bold))
        Dim texto4 As New Phrase("EL USUARIO: " & NOM_USUARIO & " " & "CREO EL HORARIO SIENDO HOY:" & Date.Now, New Font(Font.Name = "Tahoma", 12, Font.Bold))

        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)

        document.Add(texto2)
        document.Add(New Paragraph(" ")) 'Salto de linea
        document.Add(texto3)
        document.Add(New Paragraph(" ")) 'Salto de linea
        document.Add(texto4)

    End Sub
    Public Function GetColumnasSize() As Single()
        Dim values As Single() = New Single(Me.dgv_reporte.ColumnCount - 1) {}
        For i As Integer = 0 To dgv_reporte.ColumnCount - 1
            If i = 0 Then
                values(i) = CSng(dgv_reporte.Columns(i).Width + 20)
            Else
                values(i) = CSng(dgv_reporte.Columns(i).Width)
            End If

        Next
        Return values
    End Function
    Public Function GetHightSize() As Single()
        Dim values As Single() = New Single(Me.dgv_reporte.ColumnCount - 1) {}
        For i As Integer = 0 To dgv_reporte.ColumnCount - 1
            values(i) = CSng(25)
        Next
        Return values
    End Function

    Private Sub btn_Exporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exporta.Click
        Dim obj As New DLL_DATOS.ClsExportar
        Dim file As New FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Horario_1.xls", FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        If dgv_reporte.RowCount = 0 Then
            MsgBox("No hay registros, favor de consultar una busqueda de disponibilidad.!")
        Else
            obj.S_ExportarDataGridViewExcel(dgv_reporte)
            '   obj.Exportar_datagrid(dgv_reporte)
            'Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Horario_1.xls")
            Process.GetCurrentProcess.Dispose()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panel_filtro.Width = 500
        panel_filtro.Height = 60
        panel_filtro.Visible = True
    End Sub

    Private Sub DgvBusqueda_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvBusqueda.CellDoubleClick
        Dim cod_asig, estado$
        If INI_SESSION = 1 Then

            cod_asig = DgvBusqueda.Rows(e.RowIndex).Cells(0).Value.ToString
            estado = DgvBusqueda.Rows(e.RowIndex).Cells(13).Value.ToString
            'nom_doc = (DgvBusqueda.Rows(e.RowIndex).Cells(1).Value)
            'descrip = (DgvBusqueda.Rows(e.RowIndex).Cells(3).Value)
            If estado = "C" Then
                MsgBox("No se puede editar un estado cancelado.")
            Else
                Frm_Detalle.txtcod.Text = cod_asig
                Frm_Detalle.Show()
                ' Frm_Ingreso.Show()
            End If
   

        End If
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        panel_filtro.Width = 403
        panel_filtro.Height = 60
        panel_filtro.Visible = True
    End Sub



    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        panel_filtro.Visible = False
    End Sub

    Private Sub btn_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtro.Click
        FILTRAR(cbo_detalle.Text)
        
    End Sub

    Private Sub txtnom_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom_doc.TextChanged
        FILTRAR("")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If INI_SESSION > 1 Then
            End
        End If
    End Sub

    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Dim myValue As Object
        Dim idpos As Integer
        ' Display dialog box at position 100, 100.
        myValue = InputBox("Ingrese codigo de programacion", "Eliminar programacion")
        ' If user has clicked Cancel, set myValue to defaultValue
        idpos = 0
        If myValue Is "" Then
            MsgBox("ingrese codigo")
        Else

            dt = DLL_PROCEDURE.Listado("select  max( id_posicion) +1  as id_posicion from t_aud_agente where cod_asig =" & myValue)

            If IsDBNull(dt.Rows.Item(0)(0)) Then
                idpos = 1
            Else
                idpos = Val(dt.Rows.Item(0)(0))
            End If
            DLL_PROCEDURE.Cancelar_Principal(myValue)
            DLL_PROCEDURE.Guardar_Historico(myValue, MNUPRINCIPAL.lblusu.Text, IDPOS, "ANULACION", "ANULAR PROGRAMACION", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), MNUPRINCIPAL.LBLIP.Text, 1)
            MsgBox("Programacion Cancelada con exito...!")
            FILTRAR("")

        End If
    End Sub

    Private Sub dgv_reporte_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_reporte.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incidencia.Click

        Try

  
        Dim cod_asig$
        Dim nom_med$
        Dim nom_cond$
        Dim cod_mot$
        Dim cod_doc$
        Dim r As Integer
        If INI_SESSION = 1 Or 2 Then


            r = DgvBusqueda.CurrentRow.Index
            cod_asig = DgvBusqueda.Item(0, r).Value.ToString
            nom_med = DgvBusqueda.Item(1, r).Value.ToString
                nom_cond = DgvBusqueda.Item(11, r).Value.ToString
                cod_doc = DgvBusqueda.Item(16, r).Value.ToString
                cod_mot = DgvBusqueda.Item(17, r).Value.ToString
            frm_incidente.txtid_combo.Text = cod_asig
            frm_incidente.txtnom_med.Text = nom_med
            frm_incidente.txtnom_cond.Text = nom_cond
            frm_incidente.txtcod_doc.Text = cod_doc
            frm_incidente.txtcod_mot.Text = cod_mot
            frm_incidente.Show()
            ' Frm_Ingreso.Show()

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim cod_asig$
        Dim r As Integer
        Try
            r = DgvBusqueda.CurrentRow.Index
            cod_asig = DgvBusqueda.Item(0, r).Value.ToString
            frm_seguimiento.lblcod_Asig.Text = cod_asig
            'frm_seguimiento.lblcod_Asig.Text = 162961
            frm_seguimiento.ShowDialog()
        Catch ex As Exception
            MsgBox("Debe seleccionar una fila ")
        End Try
      


    End Sub

    Private Sub cbo_flag_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_flag.SelectedIndexChanged

    End Sub

    Private Sub cbo_clasificacion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_clasificacion.SelectedIndexChanged

    End Sub
End Class