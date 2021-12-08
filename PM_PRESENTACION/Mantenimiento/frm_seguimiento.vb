Imports DLL_NEGOCIO

Public Class frm_seguimiento

    Private Sub frm_seguimiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgv_seguimiento.DataSource = DLL_PROCEDURE.Listado("SELECT COD_ASIG , NOM_USU AS USUARIO,TIPO_REGISTRO AS EVENTO  , CAMBIOS_REALIZADOS AS REGISTRO, FEC_REG AS FECHA,HORA_REG AS HORA  FROM T_AUD_AGENTE WHERE  cod_asig=" & lblcod_Asig.Text & "ORDER BY ID_POSICION ASC ")
        If dgv_seguimiento.RowCount > 0 Then
            dgv_seguimiento.Columns(0).Width = 80
            dgv_seguimiento.Columns(1).Width = 100
            dgv_seguimiento.Columns(2).Width = 100
            dgv_seguimiento.Columns(3).Width = 550
            dgv_seguimiento.Columns(4).Width = 80
            dgv_seguimiento.Columns(5).Width = 80
            dgv_seguimiento.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Else
            MsgBox("No se encontró seguimiento")
        End If
    End Sub
End Class