Imports DLL_DATOS

Public Class frm_incidente
    Dim obj As New DLL_DATOS.CLS_PROCEDURE
    Dim objdll As New DLL_NEGOCIO.DLL_PROCEDURE
    Dim sql As String = ""
    Dim tipo_empleado As Integer
    Dim COD_PERSONAL As String

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        sql = "select id_incidencia,descripcion from m_incidencia_agente where id_tipo_empleado =1   and estado = true  order by 2 asc"
        obj.Llenar_Combos(cbo_tipo_incidencia, sql, "id_incidencia", "descripcion")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        sql = "select id_incidencia,descripcion from m_incidencia_agente where id_tipo_empleado =2   and estado = true  order by 2 asc"
        obj.Llenar_Combos(cbo_tipo_incidencia, sql, "id_incidencia", "descripcion")
    End Sub
 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        If MessageBox.Show("Esta seguro que desea guaradar?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then




            If RadioButton1.Checked = True Then
                tipo_empleado = 1
                COD_PERSONAL = txtcod_doc.Text
            Else
                tipo_empleado = 2
                COD_PERSONAL = txtcod_mot.Text

            End If

            If RadioButton2.Checked = True Then
                tipo_empleado = 2
                COD_PERSONAL = txtcod_mot.Text
            Else
                tipo_empleado = 1
                COD_PERSONAL = txtcod_doc.Text

            End If
            objdll.registra_incidencia(COD_PERSONAL, txtid_combo.Text, cbo_tipo_incidencia.SelectedValue, RichTextBox1.Text.ToUpper, Now.ToString("yyyy-MM-dd"), MNUPRINCIPAL.lblusu.Text, tipo_empleado)
            MsgBox("Datos guardos correctamente")
            RichTextBox1.Clear()

        End If





    End Sub

    Private Sub frm_incidente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from t_segui_incidencia_agente where id_combo=" & txtid_combo.Text & ";"
        ' DataGridView1.DataSource = obj.Listado(sql)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
