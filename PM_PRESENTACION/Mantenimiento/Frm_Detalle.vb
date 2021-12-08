Imports DLL_NEGOCIO
Imports DLL_DATOS

Public Class Frm_Detalle
    Public objx As New DLL_DATOS.CLS_PROCEDURE
    Public txnom_doc, txhorini_doc, txhorfin_doc, txdes_doc, txfec_asig, txturno, tx_botiquin, tx_especialidad, txempresa, txcod_mot, txnom_mot, txhorini_mot, txhorfin_mot, txnom_usu, txzona, txmpos, txnom_clasif$
    Dim nom_esp$
    Dim xcod_clasif As String
    Dim xcod_doc, xnom_doc, xhorini_doc, xcod_distrito, xhorfin_doc, xdes_doc, xfec_asig, xturno, xcod_esp, xempresa, xcod_mot, xnom_mot, xhorini_mot, xhorfin_mot, xnom_usu, xestado, xzona, xnom_clasif$
    Dim x_codbotiquin As Integer


    Private Sub Frm_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BLOQUEO(False)
        'If INI_SESSION >




        cbo_empresa.DataSource = DLL_PROCEDURE.Listado("select cod_prov_motorizado,descripcion from m_proveedor_motorizado where activo=true")
        cbo_empresa.DisplayMember = "descripcion"
        cbo_empresa.ValueMember = "cod_prov_motorizado"
        Mostrar_Datos()
        ' CLS_PROCEDURE.distrito_x_zona(lst_dis_detalle, cbo_zona_det.Text.Trim)
        If lblestado.Text = 1 Then
            lbl_estado.Text = "PENDIENTE"
        End If
        If lblestado.Text = 2 Then
            lbl_estado.Text = "CONFIRMADO"
        End If



    End Sub

#Region "REGLAS"

    Sub llenar_combobox(ByVal combo As ComboBox)
        With combo
            .Items.Add("PEDIATRIA")
            .Items.Add("MEDICINA")
            .Items.Add("CARDIOLOGIA")
            .Items.Add("ENDOCRINOLOGIA")
            .Items.Add("NEUMOLOGIA")
            .Items.Add("NUTRICIONISTA")
            .Items.Add("ESPECIALISTA")
        End With
    End Sub
    Sub Mostrar_Datos()
        Try
            txnom_doc = txhorini_doc = ""
            txhorfin_doc = ""
            txdes_doc = ""
            txfec_asig = ""
            txturno = ""
            tx_botiquin = ""
            tx_especialidad = ""
            txempresa = ""
            txcod_mot = ""
            txnom_mot = ""
            txhorini_mot = ""
            txhorfin_mot = ""
            txnom_usu = ""
            txzona = ""
            txmpos = ""
            txnom_clasif = ""
     
        Dim dt As New DataTable
            dt = CLS_PROCEDURE.Listado("Select * from t_prog_doctorxturno where cod_asig ='" & txtcod.Text & "'")
            'las variables que empiezan con t son temporales para la auditoria

            xcod_doc = dt.Rows(0).Item(1).ToString
            xnom_doc = dt.Rows(0).Item(2).ToString
            txnom_doc = xnom_doc ' var temporal
            xhorini_doc = dt.Rows(0).Item(3).ToString
            txhorini_doc = xhorini_doc ' var temporal
            xhorfin_doc = dt.Rows(0).Item(4).ToString
            txhorfin_doc = xhorfin_doc ' var temporal
            xdes_doc = dt.Rows(0).Item(5).ToString
            txdes_doc = xdes_doc ' var temporal
            xfec_asig = dt.Rows(0).Item(6).ToString
            txfec_asig = xfec_asig ' var temporal
            xturno = dt.Rows(0).Item(7).ToString

            xcod_esp = dt.Rows(0).Item(8).ToString
            If xcod_esp = "006" Then
                xcod_esp = "006','010"
            ElseIf xcod_esp = "012" Then
                xcod_esp = "012','003','009"
            End If
        xzona = dt.Rows(0).Item(9).ToString
        xcod_distrito = dt.Rows(0).Item(10).ToString

        ' distrito_x_zona_Busqueda(xzona.Trim)
            xempresa = dt.Rows(0).Item(20).ToString
            xcod_mot = dt.Rows(0).Item(12).ToString
            xnom_mot = dt.Rows(0).Item(13).ToString
            xhorini_mot = dt.Rows(0).Item(14).ToString
            xhorfin_mot = dt.Rows(0).Item(15).ToString
            xnom_usu = dt.Rows(0).Item(18).ToString
            xestado = dt.Rows(0).Item(16).ToString
            xnom_clasif = dt.Rows(0).Item(19).ToString

        If dt.Rows(0).Item(23).ToString = False Then
            cmbMpos.SelectedIndex = 0
        Else
            cmbMpos.SelectedIndex = 1

        End If

            txmpos = cmbMpos.Text ' var temporal
        dtp_ini_doc.Text = xhorini_doc
        dtp_fin_doc.Text = xhorfin_doc
            txt_des.Text = xdes_doc
            txt_ind.Text = dt.Rows(0).Item(38).ToString
        txt_fecha.Text = xfec_asig
        lblusuario.Text = xnom_usu
        If xestado = 1 Then lbl_estado.Text = "PENDIENTE"
        If xestado = 2 Then lbl_estado.Text = "CONFIRMADO"
        lblestado.Text = xestado
        txtcod_mot.Text = Trim(xcod_mot)
        If xturno = "M" Then cbo_turno.Text = "MAÑANA"
        If xturno = "T" Then cbo_turno.Text = "TARDE"
            If xturno = "Z" Then cbo_turno.Text = "MADRUGADA"


            txturno = cbo_turno.Text   ' var temporal
            'MsgBox(xzona) 
            Try
                cbo_empresa.SelectedValue = xempresa
                Lleando_Motorizado(xempresa)
            Catch ex As Exception
                cbo_empresa.SelectedText = "NINGUNO"

            End Try
       
            If Trim(xcod_mot) <> "" Then
                cbo_motorizado.SelectedValue = Trim(xcod_mot)
            Else
                cbo_motorizado.Text = ""

            End If

            txempresa = cbo_empresa.Text ' var temporal
            txnom_mot = cbo_motorizado.Text ' var temporal 

            dtp_horini_mot.Text = xhorini_mot
            txhorini_mot = xhorini_mot ' var temporal
            dtp_horfin_mot.Text = xhorfin_mot
            txhorfin_mot = xhorfin_mot ' var temporal
        'cbo_zona_det.Text = xzona
            If Trim(xnom_mot) = "" Then
                cbo_motorizado.Text = "NINGUNO"
            Else
                cbo_motorizado.Text = xnom_mot
            End If


        If xnom_clasif = "AGUDO" Then
            rb_agudo_1.Checked = True
                rb_acovid.Checked = False
                rb_cronico.Checked = False
            ElseIf xnom_clasif = "CRONICO" Then
                rb_cronico.Checked = True
                rb_agudo_1.Checked = False
                rb_acovid.Checked = False
            ElseIf xnom_clasif = "AUTO COVID" Then
                rb_acovid.Checked = True
                rb_agudo_1.Checked = False
                rb_cronico.Checked = False
            End If

            txtcod_esp.Text = dt.Rows(0).Item(8).ToString
            txt_turno.Text = xturno
            txtcod_doc.Text = xcod_doc

            ESPECIALIDADES()
            doctores_especialidad(xcod_esp)
            cbo_doctor.SelectedValue = xcod_doc
            txnom_doc = cbo_doctor.Text ' var temporal 

            If txtcod_esp.Text = "005" Then cbo_especialidad.SelectedText = "PEDIATRIA"
            If txtcod_esp.Text = "001" Then cbo_especialidad.SelectedText = "CARDIOLOGIA"
            If txtcod_esp.Text = "027" Then cbo_especialidad.SelectedText = "NEUMOLOGIA"
            If txtcod_esp.Text = "011" Then cbo_especialidad.SelectedText = "ENDOCRINOLOGIA"
            If txtcod_esp.Text = "026" Then cbo_especialidad.SelectedText = "NUTRICIONISTA"
            If txtcod_esp.Text = "10" Or txtcod_esp.Text = "006" Then cbo_especialidad.SelectedText = "MEDICINA GENERAL"
            If txtcod_esp.Text = "012" Or txtcod_esp.Text = "003" Or txtcod_esp.Text = "009" Then cbo_especialidad.SelectedText = "ESPECIALISTA"
            tx_especialidad = cbo_especialidad.Text ' var temporal

            x_codbotiquin = Val(dt.Rows(0).Item(24).ToString)
            llenado_botiquin(txtcod_esp.Text)
            cbo_botiquin.SelectedValue = x_codbotiquin
            tx_botiquin = cbo_botiquin.Text  ' var temporal
        Catch ex As Exception

        End Try

    End Sub
    Sub llenado_botiquin(ByVal cod_esp As String)
        With cbo_botiquin

            .DataSource = DLL_PROCEDURE.ListaControlCombo("select MA.COD_ALMACEN ,ma.cod_almacen || '  ' || ma.descp_almacen botiquin  from mae_almacen ma inner join i_almacen_especialidad ae on ma.cod_almacen = ae.cod_almacen where cod_esp in ('" & cod_esp & "') order by 1 asc ")
            .ValueMember = "cod_almacen"
            .DisplayMember = "botiquin"
        End With
    End Sub
    Sub Lleando_Motorizado(ByVal cadena As String)
        'Llenado de motorizados
        With cbo_motorizado

            .DataSource = DLL_PROCEDURE.ListaControlCombo("select * from m_motorizados where activi =true and cod_prov_motorizado=" & cadena & " order by nom_mot asc ")
            .ValueMember = "cod_mot"
            .DisplayMember = "nom_mot"
        End With
    End Sub
    Sub Lleando_Especialidad(ByVal cadena As String)
        'Llenado de motorizados
        With cbo_especialidad
            .DataSource = DLL_PROCEDURE.ListaControlCombo("select * from m_especialidades  where cod_esp='" & cadena & "'")
            .ValueMember = "cod_esp"
            .DisplayMember = "nom_esp"
        End With
    End Sub
    Sub ESPECIALIDADES()
        With cbo_especialidad
            .Items.Add("MEDICINA GENERAL")
            .Items.Add("PEDIATRIA")
            .Items.Add("CARDIOLOGIA")
            .Items.Add("NEUMOLOGIA")

            .Items.Add("ENDOCRINOLOGIA")
            '.Items.Add("NEUMOLOGIA")
            .Items.Add("NUTRICIONISTA")
            .Items.Add("ESPECIALISTA")

        End With
    End Sub
#End Region
    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbo_empresa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_empresa.Click
        'Dim VAL As String = cbo_empresa.SelectedValue
        'If cbo_motorizado.Text = "NINGUNO" Then
        '    cbo_motorizado.DropDownStyle = ComboBoxStyle.DropDownList
        '    Lleando_Motorizado(VAL)
        '    cbo_motorizado.Text = ""
        'Else
        '    Lleando_Motorizado(VAL)
        'End If
    End Sub



    Sub doctores_especialidad(ByVal val As String)
        With cbo_doctor
            .DataSource = DLL_PROCEDURE.ListaControlCombo("select * from m_doctores  as m,m_espcxdoctor as e,m_especialidades as esp " _
                                                         + " where m.cod_doc=e.cod_doc and e.cod_esp=esp.cod_esp and m.activi=true and e.cod_esp in ('" & val & "') order by nom_doc asc")
            .ValueMember = "cod_doc"
            .DisplayMember = "nom_doc"
        End With
    End Sub

    Private Sub cbo_especialidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_especialidad.Click
        cbo_especialidad.Items.Clear()
        ESPECIALIDADES()

    End Sub

    Private Sub cbo_especialidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_especialidad.SelectedIndexChanged

        If cbo_especialidad.Text = "MEDICINA GENERAL" Then
            nom_esp = "010','006"
            txtcod_esp.Text = "006"
        End If

        If cbo_especialidad.Text = "PEDIATRIA" Then
            nom_esp = "005"
            txtcod_esp.Text = "005"
        End If
        If cbo_especialidad.Text = "CARDIOLOGIA" Then
            nom_esp = "001"
            txtcod_esp.Text = "001"
        End If
        If cbo_especialidad.Text = "NEUMOLOGIA" Then
            nom_esp = "027"
            txtcod_esp.Text = "027"
        End If
        If cbo_especialidad.Text = "ENDOCRINOLOGIA" Then
            nom_esp = "011"
            txtcod_esp.Text = "011"
        End If
        If cbo_especialidad.Text = "NUTRICIONISTA" Then
            nom_esp = "026"
            txtcod_esp.Text = "026"
        End If
        doctores_especialidad(nom_esp)
        llenado_botiquin(txtcod_esp.Text)
    End Sub

    Private Sub btn_confirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirmar.Click
        DLL_PROCEDURE.CONFIRMAR_PROGRAMACION(txtcod.Text, "2")
        ' DLL_PROCEDURE.habilita_combo(1, DLL_PROCEDURE.usuario, txtcod.Text)
        DLL_PROCEDURE.Guardar_Historico(txtcod.Text, MNUPRINCIPAL.lblusu.Text, 1, "CONFIRMACIÓN", "PROGRAMACION CONFIRMADA", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), MNUPRINCIPAL.LBLIP.Text, 1)
        Mostrar_Datos()
        If lblestado.Text = 1 Then
            lbl_estado.Text = "PENDIENTE"
            ' btn_confirmar.Enabled = True
            ' btn_editar.Enabled = True
        End If
        If lblestado.Text = 2 Then
            lbl_estado.Text = "CONFIRMADO"
            ' btn_editar.Enabled = False
            ' btn_confirmar.Enabled = False
        End If
    End Sub
    Private Sub btn_grabar_det_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar_det.Click

        Dim dt As New DataTable
        Dim cambios$ = ""
        Dim idpos As Integer
        Dim _cod_mot$
        Dim _nom_mot$
        Dim _zona$
        Dim _fec_asig As Date = CDate(txt_fecha.Text)
        Dim vacio$ = ""
        Dim _horainimot$ = ""
        Dim _horafinmot$ = ""
        Dim _horainidoc$ = ""
        Dim _horafindoc$ = ""
        Dim _conMpos As Boolean

        'Dim _cod_doc$
        Dim _nom_doc$
        Dim _usuario As String
        If rb_agudo_1.Checked = False And rb_acovid.Checked = False Then
            MsgBox("Debe seleccionar una clasificacion")
            Exit Sub
        End If
        If rb_agudo_1.Checked = True Then
            xcod_clasif = "AGUDO"
        Else
            xcod_clasif = "CRONICO"
        End If


        If rb_agudo_1.Checked = True Then
            xcod_clasif = "AGUDO"
        End If
        If rb_acovid.Checked = True Then
            xcod_clasif = "AUTO COVID"
        End If
        If rb_cronico.Checked = True Then
            xcod_clasif = "CRONICO"
        End If


        If cbo_empresa.Text = "NINGUNO" Then
            _cod_mot = cbo_motorizado.SelectedValue
            _nom_mot = vacio
        Else
            '_cod_mot = txtcod_mot.Text.Trim
            _cod_mot = cbo_motorizado.SelectedValue
            _nom_mot = cbo_motorizado.Text.Trim.ToUpper
        End If

        If cmbMpos.SelectedIndex = 0 Then
            _conMpos = False
        Else
            _conMpos = True

        End If
        '  _zona = cbo_zona_det.Text
        _horainimot = dtp_horini_mot.Value.ToString("HH:mm:00")
        _horafinmot = dtp_horfin_mot.Value.ToString("HH:mm:00")
        _horainidoc = dtp_ini_doc.Value.ToString("HH:mm:00")
        _horafindoc = dtp_fin_doc.Value.ToString("HH:mm:00")
        _nom_doc = cbo_doctor.Text.Trim.ToUpper
        '_cod_doc = cbo_doctor.SelectedValue
        _usuario = DLL_PROCEDURE.usuario
        ' VALIDAR CAMBIOS PARA AUDITORIA

        idpos = 0
        If cbo_especialidad.Text <> tx_especialidad Then
            tx_especialidad = " Esp: " & Trim(cbo_especialidad.Text)
        Else
            tx_especialidad = ""
        End If

        If cbo_doctor.Text <> txnom_doc Then
            txnom_doc = " | Doc: " & Trim(cbo_doctor.Text)
        Else
            txnom_doc = ""
        End If
        If dtp_ini_doc.Text & ":00" <> txhorini_doc Then
            txhorini_doc = " | Ini M: " & Trim(dtp_ini_doc.Text)
        Else
            txhorini_doc = ""
        End If
        If dtp_fin_doc.Text & ":00" <> txhorfin_doc Then
            txhorfin_doc = " | Fin M: " & Trim(dtp_fin_doc.Text)
        Else
            txhorfin_doc = ""
        End If
        If txt_des.Text <> txdes_doc Then
            txdes_doc = " | Indicacion: " & Trim(txt_des.Text)
        Else
            txdes_doc = ""
        End If
        If txt_fecha.Text <> txfec_asig Then
            txfec_asig = " | Fec asig: " & txt_fecha.Text
        Else
            txfec_asig = ""
        End If
        If cbo_turno.Text <> txturno Then
            txturno = " | Turno: " & Trim(cbo_turno.Text)
        Else
            txturno = ""
        End If
        If cbo_botiquin.Text <> tx_botiquin Then
            tx_botiquin = " | Bot: " & Trim(cbo_botiquin.Text)
        Else
            tx_botiquin = ""
        End If

        If cbo_empresa.Text <> txempresa Then
            txempresa = " | Emp : " & Trim(cbo_empresa.Text)
        Else
            txempresa = ""
        End If

        If cbo_motorizado.Text <> txnom_mot Then
            txnom_mot = " | Cond: " & Trim(cbo_motorizado.Text)
        Else
            txnom_mot = ""
        End If
        If dtp_horini_mot.Text & ":00" <> txhorini_mot Then
            txhorini_mot = " | Ini C: " & dtp_horini_mot.Text
        Else
            txhorini_mot = ""
        End If

        If dtp_horfin_mot.Text & ":00" <> txhorfin_mot Then
            txhorfin_mot = " |Ini C: " & dtp_horfin_mot.Text
        Else
            txhorfin_mot = ""
        End If

        If cmbMpos.Text <> txmpos Then
            txmpos = " |POS: " & cmbMpos.Text
        Else
            txmpos = ""
        End If

        dt = DLL_PROCEDURE.Listado("select  max( id_posicion) +1  as id_posicion from t_aud_agente where cod_asig =" & txtcod.Text)

        If IsDBNull(dt.Rows.Item(0)(0)) Then
            idpos = 1
        Else
            idpos = Val(dt.Rows.Item(0)(0))
        End If
        cambios = tx_especialidad & txnom_doc & txhorini_doc & txhorfin_doc & txdes_doc & txfec_asig & txturno & tx_botiquin & txempresa & txcod_mot & txnom_mot & txhorini_mot & txhorfin_mot & txnom_usu & txzona & txmpos & txnom_clasif

        If chk_conductor.Checked = False Then
            DLL_PROCEDURE.Editar_Motorizado(txtcod.Text, cbo_empresa.SelectedValue, _cod_mot, _nom_mot, _horainimot, _horafinmot, _conMpos)
            'DLL_PROCEDURE.actualiza_conductor(txtcod_mot.Text.Trim, _nom_mot, _horainidoc, _horafindoc, _usuario, txtcod.Text)
            MessageBox.Show("Datos del conductor modificado, con exito.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            chk_conductor.Checked = True
        End If
        If chk_doctor.Checked = False Then
            DLL_PROCEDURE.Editar_Detalle(txtcod.Text, txt_des.Text, cbo_botiquin.Text, _fec_asig.ToString("yyyy-MM-dd"), txt_turno.Text, _horainidoc, _horafindoc, cbo_doctor.Text.Trim, txtcod_doc.Text.Trim, txtcod_esp.Text, xcod_clasif, cbo_botiquin.SelectedValue)
            'DLL_PROCEDURE.actualiza_doctor(txtcod_doc.Text.Trim, _nom_doc, _horainidoc, _horafindoc, _usuario, txtcod.Text)
            MessageBox.Show("Datos del doctor modificado, con exito.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            chk_doctor.Checked = True
        End If
        'BLOQUEO(False)
        DLL_PROCEDURE.Guardar_Historico(txtcod.Text, MNUPRINCIPAL.lblusu.Text, idpos, "CAMBIO", cambios, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), MNUPRINCIPAL.LBLIP.Text, 1)
        frmOperador.FILTRAR("")
        Me.Close()
    End Sub

    Private Sub cbo_zona_det_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        '   CLS_PROCEDURE.Busqueda_Combo_Zona(cbo_zona_det, "select * from t_prog_doctorxturno where cod_asig='" & txtcod.Text & "'")
    End Sub

    Private Sub cbo_zona_det_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'distrito_x_zona_Busqueda(cbo_zona_det.Text.Trim)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Llenar_GridView(DgvBusqueda, "select cod_asig as codigo,nom_doc as doctor,fecini_asig as fecha,des_doc as detalle,turno,horini_asig_doc as hora_Ini,horfin_asig_doc as hora_fin,zona,esp.nom_esp,horini_asig_mot,horfin_asig_mot,estado_prog as estado from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp and asig_activo=TRUE and estado_prog in ('1','2') order by estado asc")
        Me.Close()
    End Sub
    Private Sub lst_dis_detalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbo_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_turno.SelectedIndexChanged
        Dim _turno$
        _turno = cbo_turno.Text
        If _turno = "MAÑANA" Then txt_turno.Text = "M"
        If _turno = "TARDE" Then txt_turno.Text = "T"
        If _turno = "MADRUGADA" Then txt_turno.Text = "Z"
    End Sub
    Private Sub cbo_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_doctor.SelectedIndexChanged
        'MsgBox(cbo_doctor.SelectedValue.ToString)
        txtcod_doc.Text = cbo_doctor.SelectedValue.ToString.Trim
    End Sub
    Private Sub gbx_doctor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_doctor.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_conductor.CheckedChanged
        If chk_conductor.Checked = True Then
            gbx_motorizado.Enabled = False
        Else
            gbx_motorizado.Enabled = True
            'Mostrar_Datos
        End If
    End Sub

    Private Sub chk_doctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_doctor.CheckedChanged
        If chk_doctor.Checked = True Then
            gbx_doctor.Enabled = False
            gbx_Detalle.Enabled = False
        Else
            gbx_doctor.Enabled = True
            gbx_Detalle.Enabled = True


        End If
    End Sub

    Private Sub btn_desconfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_desconfirma.Click
        DLL_PROCEDURE.CONFIRMAR_PROGRAMACION(txtcod.Text, "1")
        ' DLL_PROCEDURE.habilita_combo(2, DLL_PROCEDURE.usuario, txtcod.Text)
        Mostrar_Datos()
        If lblestado.Text = 1 Then
            lbl_estado.Text = "PENDIENTE"
            ' btn_confirmar.Enabled = True
            ' btn_editar.Enabled = True
        End If
        If lblestado.Text = 2 Then
            lbl_estado.Text = "CONFIRMADO"
            ' btn_editar.Enabled = False
            ' btn_confirmar.Enabled = False
        End If
    End Sub
    Private Sub cbo_motorizado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_motorizado.SelectedIndexChanged
        txtcod_mot.Text = cbo_motorizado.SelectedValue.ToString.Trim
    End Sub

    Private Sub cbo_empresa_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_empresa.SelectionChangeCommitted
        Dim VAL As String = cbo_empresa.SelectedValue


        Lleando_Motorizado(VAL)

    End Sub

    Private Sub cbo_empresa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_empresa.SelectedIndexChanged

    End Sub
End Class