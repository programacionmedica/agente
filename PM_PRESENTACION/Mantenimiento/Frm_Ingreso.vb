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
Public Class Frm_Ingreso
    Public obj As New DLL_DATOS.CLS_PROCEDURE
    Public CodEsp As String
    Public cadena As String
    Public xcod_esp As String
    Dim _turno, _xturno As String
    Dim xcod_asig As Integer
    Dim xusuario As String
    Public codesp_b As String
    Dim query As String
    Public xcod_clasif As String

#Region "Llenar Combo"
    'LLenado de doctores
    Sub doctores_especialidad(ByVal val As String)
        With cbo_doctor
            .DataSource = DLL_PROCEDURE.ListaControlCombo("select * from m_doctores  as m,m_espcxdoctor as e,m_especialidades as esp " _
                                                         + " where m.cod_doc=e.cod_doc and e.cod_esp=esp.cod_esp and m.activi=true and e.cod_esp in('" & val & "') order by m.nom_doc desc")
            .ValueMember = "cod_doc"
            .DisplayMember = "nom_doc"
        End With
    End Sub
   
    Sub Lleando_Motorizado(ByVal cadena As String) ' validar que sea con una tabla maestra
        'Llenado de motorizados
        With cbo_motorizado
            .DataSource = DLL_PROCEDURE.ListaControlCombo("select * from m_motorizados where activi =true and cod_prov_motorizado=" & cadena & "")
            .ValueMember = "cod_mot"
            .DisplayMember = "nom_mot"
        End With

    End Sub
    Sub Llenar_Combos(ByVal control As ComboBox, ByVal SQL$, ByVal val As String, ByVal nom As String)
        With control
            .DataSource = DLL_PROCEDURE.ListaControlCombo(SQL)
            .ValueMember = val
            .DisplayMember = nom
        End With
    End Sub

#End Region
#Region "Procedimientos para DataGridView"

#End Region
#Region "Validacion"
    Sub verifica(ByVal estado As Boolean)

        If cbo_especialidad.Text = "" Then
            MsgBox("Seleccione la Especilialidad")
            estado = True
        End If
        If cbo_turno.Text = "" Then
            MsgBox("Seleccione un turno")
            estado = True
        End If
       
        If cbo_doctor.Text = "" Then
            MsgBox("Seleccione un  Dr")
            estado = True
        End If
        If txt_desc_doc.Text = "" Then
            MsgBox("Digite alguna descripcion del Medico")
            estado = True
        End If
      
    End Sub
#End Region
    Sub llenar_combobox(ByVal combo As ComboBox)
        With combo
            .Items.Add("PEDIATRIA")
            .Items.Add("MEDICINA")
            .Items.Add("CARDIOLOGIA")
            .Items.Add("ENDOCRINOLOGIA")
            .Items.Add("NEUMOLOGIA")
            .Items.Add("NUTRICIONISTA")
            ''''ESPECIALISTAS
            .Items.Add("ESPECIALISTAS")

        End With
    End Sub
    Private Sub Frm_Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    

        Panel1.Visible = False
        lbl_fecha.Visible = False
        Panel1.Width = 722
        Panel1.Height = 73
        cbo_especialidad.Items.Clear()
        llenar_combobox(cbo_especialidad) 'e cambia por checkbox



        cbo_empresa.DataSource = DLL_PROCEDURE.Listado("select cod_prov_motorizado,descripcion from m_proveedor_motorizado where activo=true")
        cbo_empresa.DisplayMember = "descripcion"
        cbo_empresa.ValueMember = "cod_prov_motorizado"
        cbo_empresa.SelectedValue = 99

        ' Bloquea_Control(False)
        TabControl1.TabIndex = 1
        colorear(dgv_listado)
        cbo_especialidad.SelectedIndex = 0
        Llenar_GridView(dgv_listado, "select cod_asig as codigo,nom_doc as Doctor,turno,nom_clasif as clasificacion,zona,des_doc as descripcion,to_char(horini_asig_doc,'HH:mm') as HorIni,to_char(horfin_asig_doc,'HH:mm') as HorFin,to_char(fecini_asig,'dd-MM-yyyy') AS FECHA,esp.nom_esp as Especialidad,nom_mot as Conductor,to_char(horini_asig_mot,'HH:mm') as HorMot_ini,to_char(horfin_asig_mot,'HH:mm') as horMotfin,estado_prog as estado  from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp  AND TURNO in ('M','T','N') and asig_activo=true and estado_prog in ('1','2') order by cod_asig desc limit 50")
    End Sub
  
    Private Sub dgv_maestro_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Frm_Detalle.ShowDialog()
    End Sub
 


    Private Sub cbo_especialidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_especialidad.SelectedIndexChanged

        If cbo_especialidad.SelectedIndex = 0 Then
            xcod_esp = "005"
            query = "005"
            doctores_especialidad(query)

        End If

        If cbo_especialidad.SelectedIndex = 1 Then
            xcod_esp = "006" '' + 10
            query = "006','010"
            doctores_especialidad(query)
        End If

        If cbo_especialidad.SelectedIndex = 2 Then
            xcod_esp = "001"
            query = "001"
            doctores_especialidad(query)
        End If

        If cbo_especialidad.SelectedIndex = 3 Then
            xcod_esp = "011"
            query = "011"
            doctores_especialidad(query)
        End If

        If cbo_especialidad.SelectedIndex = 4 Then
            xcod_esp = "027"
            query = "027"
            doctores_especialidad(query)
        End If

        If cbo_especialidad.SelectedIndex = 5 Then
            xcod_esp = "026"
            query = "026"
            doctores_especialidad(query)
        End If

        If cbo_especialidad.SelectedIndex = 6 Then
            xcod_esp = "012"
            query = "012','003','009"
            doctores_especialidad(query)
        End If
        'MsgBox(xcod_esp)

    End Sub
    Private Sub cbo_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_turno.SelectedIndexChanged
        If cbo_turno.SelectedItem = "MAÑANA" Then
            'Hora Doctor
            dtp_HoraIni_Doc.Value = "03/06/2013 06:00"
            dtp_HoraFin_Doc.Value = "03/06/2013 15:00"
            'Hora Motorizado
            dtp_HoraIni_Mot.Value = "03/06/2013 06:00"
            dtp_HoraFin_Mot.Value = "03/06/2013 15:00"
        End If
        If cbo_turno.SelectedItem = "TARDE" Then
            dtp_HoraIni_Doc.Value = "03/06/2013 15:00"
            dtp_HoraFin_Doc.Value = "03/06/2013 00:00"
            'Hora Motorizado
            dtp_HoraIni_Mot.Value = "03/06/2013 15:00"
            dtp_HoraFin_Mot.Value = "03/06/2013 00:00"
        End If
        If cbo_turno.SelectedItem = "MADRUGADA" Then
            dtp_HoraIni_Doc.Value = "03/06/2013 00:00"
            dtp_HoraFin_Doc.Value = "03/06/2013 06:00"
            'Hora Motorizado
            dtp_HoraIni_Mot.Value = "03/06/2013 00:00"
            dtp_HoraFin_Mot.Value = "03/06/2013 06:00"
        End If
    End Sub
    Sub Bloquea_Control(ByVal estado As Boolean)
        cbo_especialidad.Enabled = estado
        cbo_turno.Enabled = estado
        dgv_listado.Enabled = estado
    End Sub

    Sub GENERAR_CODIGO()
        cadena = (DLL_PROCEDURE.Listado("select max(cod_asig) from t_prog_doctorxturno").Rows(0).Item(0).ToString)
        xcod_asig = (Val(cadena) + 1)
    End Sub
    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Bloquea_Control(False)
        btn_agregar.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xcod, xcodigo As String
        xcod = (DLL_PROCEDURE.Listado("select max(cod_asig) from t_doctorxturno").ToString)
        xcodigo = Val(xcod) + 1
        MsgBox("000" & xcodigo)
    End Sub
 
    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click

        Dim cambios As String = ""

        If cbo_especialidad.Text = "" Or cbo_turno.Text = "" Or cbo_doctor.Text = "" Or cbo_doctor.Text = "" Then
            MessageBox.Show("Falta ingresar los datos", "Sistemas DR+")
        Else
            Dim _cod_doc$ = cbo_doctor.SelectedValue.ToString.Trim
            Dim _nom_doc$ = cbo_doctor.Text.Trim.ToUpper.Trim
            Dim _hor_inidoc As String

            Dim _hor_historico As String
            Dim _hor_findoc As String
            Dim _fec_asig As Date
            Dim _fec_finasig As Date
            _hor_historico = DateTime.Now.ToString("HH:mm:00")
            _hor_inidoc = dtp_HoraIni_Doc.Value.ToString("HH:mm:00")
            _hor_findoc = dtp_HoraFin_Doc.Value.ToString("HH:mm:00")
            _fec_asig = CDate(tdpfec_asignacion.Text)
            If CInt(VB.Left(_hor_findoc, 2)) < CInt(VB.Left(_hor_inidoc, 2)) Then
                _fec_finasig = CDate(tdpfec_asignacion.Value.AddDays(1)).ToString("d")
            Else
                _fec_finasig = _fec_asig
            End If

            Dim _descri$ = txt_desc_doc.Text.Trim.ToUpper
            'Dim _fec_asig As Date = CDate(tdpfec_asignacion.Text)
            _turno = cbo_turno.Text ''Microsoft.VisualBasic.Left(

            '--- Declaracion de Variables
            If _turno = "MAÑANA" Then _xturno = "M"
            If _turno = "TARDE" Then _xturno = "T"
            If _turno = "MADRUGADA" Then _xturno = "Z"
            ' If _turno = "TODOS" Then _xturno = "'M','T','N'"
            'Dim _esp$ = cbo_especialidad.SelectedValue.ToString
            Dim _zona$ = "ZONA 01"
            'Dim _cod_dis$ = lst_distritos.SelectedValue.ToString
            Dim _cod_tipo_mot = cbo_empresa.SelectedValue
            ''Secundario ------------------------------------------------
            Dim _cod_mot$
            Dim _nom_mot$
            Dim vacio$ = ""
            If rb_mad.Checked = True Then
                xcod_clasif = "AGUDO"
            End If
            If rb_auto_covid.Checked = True Then
                xcod_clasif = "AUTO COVID"
            End If
            If rb_ccs.Checked = True Then
                xcod_clasif = "CRONICO"
            End If
            If cbo_empresa.Text = "NINGUNO" Then
                _cod_mot = vacio
                _nom_mot = vacio
            Else
                _cod_mot = cbo_motorizado.SelectedValue.ToString.Trim
                _nom_mot = cbo_motorizado.Text.ToUpper.Trim
            End If
            Dim _hor_inimot$ = dtp_HoraIni_Mot.Value.ToString("HH:mm:00")
            Dim _hor_finmot$ = dtp_HoraFin_Mot.Value.ToString("HH:mm:00")

            Dim _estado$ = 1
            Dim _usuario = DLL_PROCEDURE.usuario
            'Genera codigo

            'Genera codigo
            CAMBIOS = ""
            If MsgBox("¿Desea insertar una programacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro de horario") = MsgBoxResult.Yes Then
                GENERAR_CODIGO()


         
                If DLL_PROCEDURE.Guardar_principal(xcod_asig, _cod_doc, _nom_doc, _hor_inidoc, _hor_findoc, _descri, _fec_asig, _xturno, xcod_esp, _zona, _cod_tipo_mot, _cod_mot, _nom_mot, _hor_inimot, _hor_finmot, _estado, True, lbluser.Text, xcod_clasif) = 0 Then
                    GENERAR_CODIGO()
                    If DLL_PROCEDURE.Guardar_principal(xcod_asig, _cod_doc, _nom_doc, _hor_inidoc, _hor_findoc, _descri, _fec_asig, _xturno, xcod_esp, _zona, _cod_tipo_mot, _cod_mot, _nom_mot, _hor_inimot, _hor_finmot, _estado, True, lbluser.Text, xcod_clasif) = 1 Then
                        cambios = "Cod: " & xcod_asig & " | Clasificacion: " & xcod_clasif & " | Doc: " & _nom_doc & " | Ini Doc: " & _hor_inidoc & " | Fin Doc: " & _hor_findoc & " | Indicacion: " & _descri & " | Fecha asig: " & _fec_asig & " | Turno: " & _xturno & " | Zona: " & _zona & " | Conductor: " & _nom_mot & " | Ini Cond: " & _hor_inimot & " | Fin Cond: " & _hor_finmot
                        DLL_PROCEDURE.Guardar_Historico(xcod_asig, MNUPRINCIPAL.lblusu.Text, 1, "CREACION", cambios, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), MNUPRINCIPAL.LBLIP.Text, 1)

                        Llenar_GridView(dgv_listado, "select cod_asig as codigo,nom_doc as Doctor,turno,nom_clasif as clasificacion,zona,des_doc as descripcion,to_char(horini_asig_doc,'HH:mm') as HorIni,to_char(horfin_asig_doc,'HH:mm') as HorFin,to_char(fecini_asig,'dd-MM-yyyy') AS FECHA,esp.nom_esp as Especialidad,nom_mot as Conductor,to_char(horini_asig_mot,'HH:mm') as HorMot_ini,to_char(horfin_asig_mot,'HH:mm') as horMotfin,estado_prog as estado  from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp  AND TURNO in ('M','T','N') and asig_activo=true and estado_prog in ('1','2') order by cod_asig desc limit 50")
                        MsgBox("Se creó el registro N°: " & xcod_asig.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Modulo Horario")
                    End If
                Else
                    cambios = "Cod: " & xcod_asig & " | Clasificacion: " & xcod_clasif & " | Doc: " & _nom_doc & " | Ini Doc: " & _hor_inidoc & " | Fin Doc: " & _hor_findoc & " | Indicacion: " & _descri & " | Fecha asig: " & _fec_asig & " | Turno: " & _xturno & " | Zona: " & _zona & " | Conductor: " & _nom_mot & " | Ini Cond: " & _hor_inimot & " | Fin Cond: " & _hor_finmot
                    DLL_PROCEDURE.Guardar_Historico(xcod_asig, MNUPRINCIPAL.lblusu.Text, 1, "CREACION", cambios, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), MNUPRINCIPAL.LBLIP.Text, 1)

                    Llenar_GridView(dgv_listado, "select cod_asig as codigo,nom_doc as Doctor,turno,nom_clasif as clasificacion,zona,des_doc as descripcion,to_char(horini_asig_doc,'HH:mm') as HorIni,to_char(horfin_asig_doc,'HH:mm') as HorFin,to_char(fecini_asig,'dd-MM-yyyy') AS FECHA,esp.nom_esp as Especialidad,nom_mot as Conductor,to_char(horini_asig_mot,'HH:mm') as HorMot_ini,to_char(horfin_asig_mot,'HH:mm') as horMotfin,estado_prog as estado  from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp  AND TURNO in ('M','T','N') and asig_activo=true and estado_prog in ('1','2') order by cod_asig desc limit 50")
                    MsgBox("Se creó el registro N°: " & xcod_asig.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Modulo Horario")
                End If







             
            End If



        End If

    End Sub

   

 
    Private Sub dgv_listado_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_listado.CellContentDoubleClick
        Dim cod_asig$
        cod_asig = (dgv_listado.Rows(e.RowIndex).Cells(0).Value)
        DLL_PROCEDURE.Cancelar_Principal(cod_asig)
        Llenar_GridView(dgv_listado, "select cod_asig,cod_doc,nom_doc,fecini_asig,des_doc,turno,horini_asig_doc,horfin_asig_doc,zona,esp.nom_esp,horini_asig_mot,horfin_asig_mot,estado_prog from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp and asig_activo=TRUE and estado_prog in ('1','2') order by cod_asig desc")
    End Sub


    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_Actualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualiza.Click
        Llenar_GridView(dgv_listado, "select cod_asig as codigo,nom_doc as Doctor,turno,zona,des_doc as descripcion,to_char(horini_asig_doc,'HH24:MI') as HorIni,to_char(horfin_asig_doc,'HH24:MI') as HorFin,to_char(fecini_asig,'dd-MM-yyyy') AS FECHA,esp.nom_esp as Especialidad,nom_mot as Conductor,to_char(horini_asig_mot,'HH24:MI') as HorMot_ini,to_char(horfin_asig_mot,'HH24:MI') as horMotfin,estado_prog as estado  from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp  AND TURNO in ('M','T','N') and asig_activo=true and estado_prog in ('1','2') order by turno,zona,horini asc")
        ' Llenar_GridView(DgvBusqueda, "select cod_asig as codigo,nom_doc as Doctor,turno,zona,des_doc as descripcion,to_char(horini_asig_doc,'HH24:MI') as HorIni,to_char(horfin_asig_doc,'HH24:MI') as HorFin,to_char(fecini_asig,'dd-MM-yyyy') AS FECHA,esp.nom_esp as Especialidad,nom_mot as Conductor,to_char(horini_asig_mot,'HH24:MI') as HorMot_ini,to_char(horfin_asig_mot,'HH24:MI') as horMotfin,estado_prog as estado  from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp  AND TURNO in ('M','T','N') and asig_activo=true and estado_prog in ('1','2') order by turno,zona,horini asc")

        '   colorear(DgvBusqueda)
        colorear(dgv_listado)
    End Sub
    Sub colorear(ByVal grid As DataGridView)
        For Each Fila As DataGridViewRow In grid.Rows
            If Fila.Cells("estado").Value = 1 Then
                'Fila.Cells(1).Style.BackColor = Color.PaleTurquoise
                Fila.Cells(1).Style.BackColor = Color.White
                Fila.Cells(0).Style.BackColor = Color.White
            Else
                Fila.Cells(1).Style.BackColor = Color.SpringGreen
            End If

        Next
    End Sub

    Private Sub cbo_zona_bus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    CLS_PROCEDURE.distrito_x_zona(lst_bus_distrito, cbo_zona_bus.SelectedValue.ToString)
    End Sub

    Private Sub DgvBusqueda_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Dim cod_asig$

        Dim cod_asig$

        '  cod_asig = (DgvBusqueda.Rows(e.RowIndex).Cells(0).Value)
        'nom_doc = (DgvBusqueda.Rows(e.RowIndex).Cells(1).Value)
        'descrip = (DgvBusqueda.Rows(e.RowIndex).Cells(3).Value)

        Frm_Detalle.txtcod.Text = cod_asig
        Frm_Detalle.ShowDialog()
    End Sub
    

    Private Sub btn_asociar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asociar.Click
        ' Panel1.Visible = False

        'alex
        ''cbo_turno.Visible = True
        ''TabControl1.SelectedIndex = 0
        ''lbl_asociado.Text = 1
        ''cbo_doctor.Enabled = False
        ''txt_desc_doc.Text = "ASOCIADO A LA SUB ZONA:"
        ''lbl_fecha.Visible = True
        ''Dim fec As Date
        ''fec = dtp_fecini_asig_bus.Text
        ''lbl_fecha.Text = fec
        ''tdpfec_asignacion.Enabled = False

        ''cbo_turno.Text = cbo_xturno.Text
        ''dtp_HoraIni_Doc.Text = DgvBusqueda.Rows(0).Cells(6).Value
        ''dtp_HoraFin_Doc.Text = DgvBusqueda.Rows(0).Cells(7).Value
        ''txt_desc_doc.Text = "PROGRAMACION ASOCIADA A LA SUB " & cbo_zona_bus.Text
    End Sub





    '****************************

    Sub Llenar_GridView(ByVal grid As DataGridView, ByVal sql As String)
        grid.DataSource = DLL_PROCEDURE.Listado(sql)
        'grid.AutoResizeColumns()
        'grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '  lbl_cantmedico.Text = grid.RowCount
    End Sub


    Private Sub cbo_empresa_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_empresa.SelectionChangeCommitted
        Dim VAL As String = (cbo_empresa.SelectedValue)

        Lleando_Motorizado(VAL)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnambulancia.Click
        frm_ingreso_ambulancia.ShowDialog()
    End Sub
End Class
