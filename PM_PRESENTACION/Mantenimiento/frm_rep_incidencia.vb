Imports DLL_DATOS

Public Class frm_rep_incidencia
    Dim obj As New DLL_DATOS.CLS_PROCEDURE
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        GridControl1.DataSource = obj.Listado("select t1.id_combo,mtp.DESCRIPCION TIPO_PERSONA,t2.cod_doc CODIGO,t2.nom_doc nombre ,tp.horini_asig_doc,tp.horfin_asig_doc,mia.descripcion TIPO_INCIDENTE,t1.observacion,t1.fecha_reg,t1.usu_reg " _
        & "from t_segui_incidencia_agente t1 inner join m_doctores t2 on t1.cod_personal = t2.cod_doc inner join m_tipo_personal_incidencia mtp on mtp.id_tipo=t1.tipo_empleado " _
        & "inner join  m_incidencia_agente  mia on  mia.id_incidencia=t1.id_tipo_incidencia inner join t_prog_doctorxturno tp on  tp.cod_asig= t1.id_combo and t1.tipo_empleado=1  WHERE T1.FECHA_REG >= '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND  T1.FECHA_REG <='" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'" _
            & "   union " _
        & " select t1.id_combo,MTP.DESCRIPCION,t3.cod_mot,t3.nom_mot  ,tp.horini_asig_mot,tp.horfin_asig_mot,mia.descripcion TIPO_INCIDENTE,t1.observacion,t1.fecha_reg,t1.usu_reg from t_segui_incidencia_agente t1 inner join  m_incidencia_agente  mia on  mia.id_incidencia=t1.id_tipo_incidencia " _
        & "inner join m_tipo_personal_incidencia mtp on mtp.id_tipo=t1.tipo_empleado inner join t_prog_doctorxturno tp on  tp.cod_asig= t1.id_combo " _
        & "inner join m_motorizados t3 on t1.cod_personal = t3.cod_mot and t1.tipo_empleado=2   WHERE T1.FECHA_REG >= '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND  T1.FECHA_REG <='" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ruta As String
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            With SaveFileDialog1
                .Filter = "Archivos Excel (*.xlsx)|*.xlsx"
                .Title = "Seleccione un ruta para guardar"
                .ShowDialog()
                ruta = .FileName
            End With

            GridControl1.ExportToXlsx(ruta)
        End If

    End Sub
End Class