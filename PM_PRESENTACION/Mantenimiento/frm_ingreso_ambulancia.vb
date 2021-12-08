
Imports DLL_NEGOCIO
Imports DLL_DATOS
Public Class frm_ingreso_ambulancia
    Dim cod_asig, cadena, _turno, _cod_doc, _nom_doc, _hor_inidoc, _hor_findoc, _descri, _fec_asig, _xturno, xcod_esp, cambios2, _zona, _cod_mot, _nom_mot, _hor_inimot, _hor_finmot, _estado, xcod_clasif As String
    Dim x, _cod_tipo_mot As Integer

    Private Sub frm_ingreso_ambulancia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _zona = "ZONA 01"
        _cod_tipo_mot = 99
        _estado = 1
        xcod_clasif = "AGUDO"
        ComboBox1.DataSource = DLL_PROCEDURE.ListaControlCombo("select rtrim(COD_DOC)as COD_DOC ,ltrim(NOM_DOC) as NOM_DOC from m_doctores where  COD_DOC IN ('5604','6113','6178','6246') order by 2 asc")
        ComboBox1.DisplayMember = "NOM_DOC"
        ComboBox1.ValueMember = "COD_DOC"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try




            _hor_inidoc = dtp_HoraIni_Doc.Value.ToString("HH:mm:00")
            _hor_findoc = dtp_HoraFin_Doc.Value.ToString("HH:mm:00")
            _hor_inimot = dtp_HoraIni_Doc.Value.ToString("HH:mm:00")
            _hor_finmot = dtp_HoraFin_Doc.Value.ToString("HH:mm:00")
            _fec_asig = CDate(tdpfec_asignacion.Text)
            '--- Declaracion de Variables
            _turno = cbo_turno.Text ''Microsoft.VisualBasic.Left(
            If _turno = "MAÑANA" Then _xturno = "M"
            If _turno = "TARDE" Then _xturno = "T"
            If _turno = "MADRUGADA" Then _xturno = "Z"
            x = Val(TextBox1.Text)
            _descri = txtobs.Text.ToUpper
            cambios2 = ""
            For m = 0 To x - 1 Step +1

                _fec_asig = CDate(tdpfec_asignacion.Value.AddDays(m).ToString("dd/MM/yyyy"))
                GENERAR_CODIGO()
                If DLL_PROCEDURE.Guardar_principal(cod_asig, ComboBox1.SelectedValue.ToString.Trim, ComboBox1.Text.ToUpper.Trim, _hor_inidoc, _hor_findoc, _descri, _fec_asig, _xturno, xcod_esp, _zona, _cod_tipo_mot, _cod_mot, _nom_mot, _hor_inimot, _hor_finmot, _estado, True, Frm_Ingreso.lbluser.Text, xcod_clasif) = 0 Then
                    GENERAR_CODIGO()
                    If DLL_PROCEDURE.Guardar_principal(cod_asig, ComboBox1.SelectedValue.ToString.Trim, ComboBox1.Text.ToUpper.Trim, _hor_inidoc, _hor_findoc, _descri, _fec_asig, _xturno, xcod_esp, _zona, _cod_tipo_mot, _cod_mot, _nom_mot, _hor_inimot, _hor_finmot, _estado, True, Frm_Ingreso.lbluser.Text, xcod_clasif) = 1 Then
                        cambios2 = "Cod: " & cod_asig & " | Clasificacion: " & xcod_clasif & " | Doc: " & ComboBox1.Text.ToUpper.Trim & " | Ini Doc: " & _hor_inidoc & " | Fin Doc: " & _hor_findoc & " | Indicacion: " & _descri & " | Fecha asig: " & _fec_asig & " | Turno: " & _xturno & " | Zona: " & _zona & " | Conductor: " & _nom_mot & " | Ini Cond: " & _hor_inimot & " | Fin Cond: " & _hor_finmot
                        DLL_PROCEDURE.Guardar_Historico(cod_asig, MNUPRINCIPAL.lblusu.Text, 1, "CREACION", cambios2, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), MNUPRINCIPAL.LBLIP.Text, 1)
                    End If
                Else
                    cambios2 = "Cod: " & cod_asig & " | Clasificacion: " & xcod_clasif & " | Doc: " & ComboBox1.Text.ToUpper.Trim & " | Ini Doc: " & _hor_inidoc & " | Fin Doc: " & _hor_findoc & " | Indicacion: " & _descri & " | Fecha asig: " & _fec_asig & " | Turno: " & _xturno & " | Zona: " & _zona & " | Conductor: " & _nom_mot & " | Ini Cond: " & _hor_inimot & " | Fin Cond: " & _hor_finmot
                    DLL_PROCEDURE.Guardar_Historico(cod_asig, MNUPRINCIPAL.lblusu.Text, 1, "CREACION", cambios2, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), MNUPRINCIPAL.LBLIP.Text, 1)

                End If



            Next
            MsgBox("Se generó " & x & "día(s) correctamente")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_turno.SelectedIndexChanged
        If cbo_turno.SelectedItem = "MAÑANA" Then
            'Hora Doctor
            dtp_HoraIni_Doc.Value = "03/06/2013 06:00"
            dtp_HoraFin_Doc.Value = "03/06/2013 15:00"

        End If
        If cbo_turno.SelectedItem = "TARDE" Then
            dtp_HoraIni_Doc.Value = "03/06/2013 15:00"
            dtp_HoraFin_Doc.Value = "03/06/2013 00:00"

        End If
        If cbo_turno.SelectedItem = "MADRUGADA" Then
            dtp_HoraIni_Doc.Value = "03/06/2013 00:00"
            dtp_HoraFin_Doc.Value = "03/06/2013 06:00"

        End If
    End Sub
    Sub GENERAR_CODIGO()
        cadena = (DLL_PROCEDURE.Listado("select max(cod_asig) from t_prog_doctorxturno").Rows(0).Item(0).ToString)
        cod_asig = (Val(cadena) + 1)
    End Sub



    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.SelectedValue = "5604" Then
            xcod_esp = "006"
        Else
            xcod_esp = "005"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class