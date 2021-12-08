Imports DLL_DATOS
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class DLL_PROCEDURE
    Public Shared usuario As String = ""
    Public Shared Function ListaControlCombo(ByVal sql$) As DataTable
        Return CLS_PROCEDURE.ListaProcCombos(sql)
    End Function
    Public Shared Function Listado(ByVal sql$) As DataTable
        Return CLS_PROCEDURE.Listado(sql)
    End Function
    Public Shared Sub Guardar_Historico(ByVal xcod_asig$, ByVal xnom_usu$, id_posicion As Integer, ByVal tipo_regsistro$, ByVal cambios_realizados$, ByVal fec_reg$, ByVal hora_reg$, ByVal ip_reg$, ByVal estado_reg As Integer)
        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            cmd.CommandText = "insert into t_aud_agente values (" & xcod_asig & ",'" & xnom_usu & "'," & id_posicion & ",'" & tipo_regsistro & "','" & cambios_realizados & "','" & fec_reg & "','" & hora_reg & "','" & ip_reg & "'," & estado_reg & ")"


            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()
            '            da.SelectCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            '           da.Fill(dt)
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Function Guardar_principal(ByVal xcod%, ByVal xcod_doc$, ByVal xnom_doc$, ByVal xhorini_asig_doc$, _
                                        ByVal horfin_asig_doc$, ByVal xdescrip As String, ByVal xfec_iniasig As Date, ByVal xturno$, _
                                        ByVal xcod_esp$, ByVal xzona$, ByVal xtipo_mot$, ByVal xcod_mot$, ByVal xnom_mot$, ByVal xhorini_asig_mot$, _
                                        ByVal horfin_asig_mot$, ByVal xestado$, ByVal xflag As Boolean, ByVal xnom_usu$, ByVal xcod_clasif As String) As Integer
        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Dim exito As Integer
        Try
            CLS_CONEXION.CN.Open()
            ' MsgBox("Conexión establecida a la base de datos PostgreSQL. ", MsgBoxStyle.Information, "Conexión establecida")

            cmd.CommandText = "INSERT INTO t_prog_doctorxturno(cod_asig,cod_doc,nom_doc,horini_asig_doc,horfin_asig_doc,des_doc,fecini_asig,turno,cod_Esp,zona,cod_prov_motorizado,cod_mot,nom_mot,horini_asig_mot,horfin_asig_mot,estado_prog,asig_activo,nom_usu,nom_clasif) values (" & xcod & ",'" & xcod_doc & "','" & xnom_doc & "','" & xhorini_asig_doc & "','" & horfin_asig_doc & "','" & xdescrip & "', " _
               + " '" & xfec_iniasig & "','" & xturno & "' ,'" & xcod_esp & "','" & xzona & "','" & xtipo_mot & "','" & xcod_mot & "','" & xnom_mot & "','" & xhorini_asig_mot & "','" & horfin_asig_mot & "'," _
               + " '" & xestado & "','" & xflag & "','" & xnom_usu & "','" & xcod_clasif & "')"
            'MessageBox.Show(cmd.CommandText.ToString)
            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()
            'ejecución de select en PostgreSQL 


            CLS_CONEXION.CN.Close()
            exito = 1

        Catch ex As Exception
            exito = 0

        End Try
        Return exito
    End Function

    Public Shared Sub Cancelar_Principal(ByVal xcod%)
        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            If MsgBox("¿Desea Eliminar la programacion seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar Programacion Horario") = MsgBoxResult.Yes Then
                cmd.CommandText = "update t_prog_doctorxturno set asig_activo=false,estado_prog='C'  where cod_asig='" & xcod & "'"
                da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
                da.InsertCommand.ExecuteNonQuery()
                'ejecución de select en PostgreSQL 
                cmd.CommandText = "select * from t_prog_doctorxturno where estado_prog in('1','2') and asig_activo='t'  order by cod_asig desc limit 50"
                da.SelectCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
                da.Fill(dt)
            End If
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub CONFIRMAR_PROGRAMACION(ByVal xcod%, ByVal estado$)
        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            If MsgBox("¿Desea confirmar la programacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Programacion") = MsgBoxResult.Yes Then
                cmd.CommandText = "update t_prog_doctorxturno set estado_prog='" & estado & "'  where cod_asig='" & xcod & "'"
                da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
                da.InsertCommand.ExecuteNonQuery()
                'ejecución de select en PostgreSQL 
                'cmd.CommandText = "select * from t_prog_doctorxturno where estado_prog in('1','2') and asig_activo='t' order by cod_asig desc"
                da.SelectCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
                da.Fill(dt)
            End If
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub Editar_Motorizado(ByVal xcod%, ByVal xtipo_mot$, ByVal xcod_mot$, ByVal xnom_mot$, ByVal xhorini_asig_mot As String, _
                                        ByVal horfin_asig_mot As String, ByVal conmpos As Boolean)

        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            If MsgBox("¿Desea Modificar los datos del conductor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar Conductor") = MsgBoxResult.Yes Then
                cmd.CommandText = "update t_prog_doctorxturno set cod_prov_motorizado='" & xtipo_mot & "',cod_mot='" & xcod_mot & "',nom_mot='" & xnom_mot & "',horini_asig_mot='" & xhorini_asig_mot & "',horfin_asig_mot='" & horfin_asig_mot & "' , con_mpos = " & conmpos & " where cod_asig='" & xcod & "'"
                da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
                da.InsertCommand.ExecuteNonQuery()
                'ejecución de select en PostgreSQL 
                'cmd.CommandText = "select * from t_prog_doctorxturno where estado_prog in('1','2') and asig_activo='t' order by cod_Asig desc"
                'da.SelectCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
                'da.Fill(dt)
            End If
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub Editar_Detalle(ByVal xcod%, ByVal xdes$, ByVal xzona$, ByVal xfec_ini As Date, ByVal xturno As String, ByVal xhor_ini As String, ByVal xhor_fin As String, ByVal xnom_doc$, ByVal xcod_doc$, ByVal xcod_esp$, ByVal xcod_clasif$, ByVal xcod_botiq As Integer)

        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            cmd.CommandText = "update t_prog_doctorxturno  set des_doc='" & xdes & "',fecini_asig='" & xfec_ini & "',turno='" & xturno & "',horini_asig_doc='" & xhor_ini & "',horfin_asig_doc='" & xhor_fin & "',nom_doc='" & xnom_doc & "',cod_doc='" & xcod_doc & "',cod_esp='" & xcod_esp & "',nom_clasif='" & xcod_clasif & "' , cod_botiquin=" & xcod_botiq & " where cod_asig='" & xcod & "'"
            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()

            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Function valida_acceso(ByVal usu$, ByVal clave$) As DataTable
        Return CLS_PROCEDURE.valida_acceso(usu, clave)
    End Function


    Public Shared Function valida_permiso(ByVal usu$) As DataTable
        Return CLS_PROCEDURE.valida_permiso(usu)
    End Function
    Public Shared Sub Guardar_combo(ByVal cod_asig%, ByVal cod_doc$, ByVal nom_doc$, ByVal cod_mot$, ByVal nom_mot$, ByVal fecini_asig As Date, ByVal horini_asig As String, ByVal usu_asig As String, _
                                    ByVal fecfin_asig As Date, ByVal horfin_asig As String, ByVal usufin_asig As String, ByVal asig_activo As Boolean, ByVal fecreg_ini As Date, ByVal horreg_ini As String, _
                                    ByVal usureg_ini As String, ByVal fecreg_fin As Date, ByVal horreg_fin As String, ByVal usureg_fin As String, ByVal anulada As Boolean, ByVal flg_reporte As String, ByVal cod_agente As Integer)
        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            cmd.CommandText = "insert into t_doctorxchofer(cod_asig,cod_doc,nom_doc,cod_mot,nom_mot,fecini_asig,horini_asig,usu_asig,fecfin_asig,horfin_asig,usufin_asig,asig_activo,fecreg_ini,horreg_ini,usureg_ini,fecreg_fin,horreg_fin,usureg_fin,anulada,flg_reporte,cod_agente) values (" & cod_asig & ",'" & cod_doc & "','" & nom_doc & "','" & cod_mot & "','" & nom_mot & "','" & fecini_asig & "'," _
                   + " '" & horini_asig & "' ,'" & usu_asig & "','" & fecfin_asig & "','" & horfin_asig & "','" & usufin_asig & "','" & asig_activo & "','" & fecreg_ini & "','" & horreg_ini & "'," _
                   + " '" & usureg_ini & "','" & fecreg_fin & "','" & horreg_fin & "','" & usureg_fin & "'," & anulada & "," & flg_reporte & "," & cod_agente & ")"
            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Function ultimo_codigo() As Integer
        Try
            Dim valor As Integer
            CLS_CONEXION.CN.Open()
            Dim cmd As New Odbc.OdbcCommand("select max(cod_asig) from t_doctorxchofer", CLS_CONEXION.CN)
            cmd.CommandType = CommandType.Text
            ' CLS_CONEXION.CN.Open()
            valor = cmd.ExecuteScalar
            CLS_CONEXION.CN.Close()
            Return valor
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Sub actualiza_conductor(ByVal cod_mot As String, ByVal nom_mot As String, ByVal horini_asig As String, ByVal horfin_asig As String, _
                                       ByVal usuario As String, ByVal cod_agente As Integer)

        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            cmd.CommandText = "update t_doctorxchofer set cod_mot='" & cod_mot & "',nom_mot='" & nom_mot & "',horini_asig='" & horini_asig & "',horfin_asig='" & horfin_asig & "',horreg_ini='" & horini_asig & "',horreg_fin='" & horfin_asig & "',usureg_ini='" & usuario & "',usureg_fin='" & usuario & "' where cod_agente=" & cod_agente & ""
            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub actualiza_doctor(ByVal cod_doc As String, ByVal nom_doc As String, ByVal horini_asig As String, ByVal horfin_asig As String, _
                                     ByVal usuario As String, ByVal cod_agente As Integer)

        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            cmd.CommandText = "update t_doctorxchofer set cod_doc='" & cod_doc & "',nom_doc='" & nom_doc & "',horini_asig='" & horini_asig & "',horfin_asig='" & horfin_asig & "',horreg_ini='" & horini_asig & "',horreg_fin='" & horfin_asig & "',usureg_ini='" & usuario & "',usureg_fin='" & usuario & "' where cod_agente=" & cod_agente & ""
            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub habilita_combo(ByVal opcion As Integer, ByVal usuario As String, ByVal cod_agente As String)

        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            '1 = se visualiza en SM
            '2 = desabiltamos el combo
            If opcion = 1 Then
                cmd.CommandText = "update t_doctorxchofer set anulada=null,usureg_ini='" & usuario & "',usureg_fin='" & usuario & "' where cod_agente=" & cod_agente & ""
            ElseIf opcion = 2 Then
                cmd.CommandText = "update t_doctorxchofer set anulada=true,usureg_ini='" & usuario & "',usureg_fin='" & usuario & "' where cod_agente=" & cod_agente & ""
            End If
            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub registra_incidencia(ByVal Cod_EMPLEADO As String, ByVal id_combo As Integer, ByVal id_tipo_incidencia As String, ByVal observacion As String, ByVal fecha As String, ByVal nom_usu As String, ByVal tipo_empleado As Integer)

        Dim cmd As OdbcCommand = CLS_CONEXION.CN.CreateCommand()
        Dim dt As New DataSet
        Dim da As New Odbc.OdbcDataAdapter
        Try
            CLS_CONEXION.CN.Open()
            cmd.CommandText = "insert into t_segui_incidencia_agente  (cod_personal,id_combo,id_tipo_incidencia,observacion,fecha_reg,usu_reg,tipo_empleado,ESTADO) VALUES ('" & Cod_EMPLEADO & "'," & id_combo & "," & id_tipo_incidencia & ",'" & observacion & "','" & fecha & " ','" & nom_usu & "'," & tipo_empleado & ",TRUE)"
            da.InsertCommand = New Odbc.OdbcCommand(cmd.CommandText, CLS_CONEXION.CN)
            da.InsertCommand.ExecuteNonQuery()
            CLS_CONEXION.CN.Close()
        Catch ex As Exception
            MsgBox("Error en la conexión a la base de datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



End Class
