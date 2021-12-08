Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class CLS_PROCEDURE
    Sub CLS_PROCEDURE() 'metodo constructor vacio
    End Sub
    Public Shared Function valida_acceso(ByVal usu$, ByVal clave$) As DataTable
        Try
            Dim cmd As New Odbc.OdbcCommand("select nom_usu,pas_usu,activo from m_usuarios where nom_usu='" & usu & "' and pas_usu='" & clave & "' and activo=true", CLS_CONEXION.CN)
            cmd.CommandType = CommandType.Text
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
            da.Dispose() 'liberar recursos de memoria
            dt.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function valida_permiso(ByVal usu$) As DataTable
        Try
            Dim cmd As New Odbc.OdbcCommand("select cod_permiso from m_permisoxusuario where nom_usu='" & usu$ & "' and  cod_permiso in (95,102)", CLS_CONEXION.CN)
            cmd.CommandType = CommandType.Text
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
            da.Dispose() 'liberar recursos de memoria
            dt.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#Region " Get Y Set"
    Private _Idasig As String
    Public Property Idasig() As Integer
        Get
            Return _Idasig
        End Get
        Set(ByVal value As Integer)
            _Idasig = value
        End Set
    End Property

    Private _cod_doc As String
    Public Property cod_doc() As String
        Get
            Return _cod_doc
        End Get
        Set(ByVal value As String)
            _cod_doc = value
        End Set
    End Property

    Private _nom_doc As String
    Public Property nom_doc() As String
        Get
            Return _nom_doc
        End Get
        Set(ByVal value As String)
            _nom_doc = value
        End Set
    End Property

    Private _horini_asig_doc As Date
    Public Property horini_asig_doc() As Date
        Get
            Return _horini_asig_doc
        End Get
        Set(ByVal value As Date)
            _horini_asig_doc = value
        End Set
    End Property

    Private _horfin_asig_doc As String
    Public Property horfin_asig_doc() As String
        Get
            Return _horfin_asig_doc
        End Get
        Set(ByVal value As String)
            _horfin_asig_doc = value
        End Set
    End Property

    Public Property _des_doc As String
    Public Property des_doc() As String
        Get
            Return _des_doc
        End Get
        Set(ByVal value As String)
            _des_doc = value
        End Set
    End Property

    Public Property _fecini_asig As Date
    Public Property fecini_asig() As Date
        Get
            Return _fecini_asig
        End Get
        Set(ByVal value As Date)
            _fecini_asig = value
        End Set
    End Property

    Public Property _turno As String
    Public Property turno() As String
        Get
            Return _turno
        End Get
        Set(ByVal value As String)
            _turno = value
        End Set
    End Property

    Public Property _cod_esp As String
    Public Property cod_esp() As String
        Get
            Return _cod_esp
        End Get
        Set(ByVal value As String)
            _cod_esp = value
        End Set
    End Property
#End Region
    Sub CLS_PROCEDURE(ByVal cod_asig As Integer, ByVal cod_doc As String, ByVal nom_doc As String, ByVal horini_asig_doc As Date, _
                    ByVal horfin_asig_doc As Date, ByVal des_doc As String, ByVal fecini_asig As Date, ByVal turno As String, ByVal cod_esp$)
        'representar los valores  por los campos
        _Idasig = cod_asig
        _cod_doc = cod_doc
        _nom_doc = nom_doc
        _horini_asig_doc = horini_asig_doc
        _horfin_asig_doc = horfin_asig_doc
        _des_doc = des_doc
        _fecini_asig = fecini_asig
        _turno = turno
        _cod_esp = cod_esp
    End Sub
    Public Shared Function ListaProcCombos(ByVal sql As String) As DataTable
        Try
            Dim cmd As New Odbc.OdbcCommand(sql, CLS_CONEXION.CN)
            cmd.CommandType = CommandType.Text
            Dim df As New Odbc.OdbcDataAdapter(cmd)
            Dim dt As New DataTable
            df.Fill(dt)
            Return dt
            df.Dispose() 'liberar recursos de memoria
            dt.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Function Listado(ByVal sql As String) As DataTable
        Try
            Dim cmd As New Odbc.OdbcCommand(sql, CLS_CONEXION.CN)
            cmd.CommandType = CommandType.Text

            Dim df As New Odbc.OdbcDataAdapter(cmd)
            Dim dt As New DataTable
            df.Fill(dt)
            Return dt
            df.Dispose() 'liberar recursos de memoria
            dt.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Sub InsertarHorario(ByVal E As CLS_PROCEDURE)
        'Abrir la Conexion
        CLS_CONEXION.CN.Open()
        Dim cmd As New OdbcCommand("Usp_Insertarclientes", CLS_CONEXION.CN)
        'ejecutar el comando
        cmd.ExecuteNonQuery()
        'Cerrar la conexion
        CLS_CONEXION.CN.Close()
    End Sub
    Public Shared Sub GenerarNuevoCodigo(ByVal cadena As String)
        Dim Cmd As New Odbc.OdbcCommand("Select count (*) from t_prog_doctorxturno", CLS_CONEXION.CN)
        CLS_CONEXION.CN.Open()
        cadena = Cmd.ExecuteScalar
        CLS_CONEXION.CN.Close()
    End Sub
    Public Shared Sub Llenar_Combos(ByVal control As ComboBox, ByVal SQL$, ByVal val As String, ByVal nom As String)
        With control
            .DataSource = Listado(SQL)
            .ValueMember = val
            .DisplayMember = nom
        End With
    End Sub
    Public Shared Sub Llenar_Combo_Zona(ByVal combo As ComboBox)
        With combo
            .DataSource = Listado("select DISTINCT(cod_zona) from m_distritos order by cod_zona asc")
            .ValueMember = "cod_zona"
            .DisplayMember = "des_dis"
        End With
    End Sub
    Public Shared Sub Busqueda_Combo_Zona(ByVal combo As ComboBox, ByVal sql As String)
        With combo
            .DataSource = Listado("select DISTINCT(cod_zona) from m_distritos order by cod_zona asc")
            .ValueMember = "cod_zona"
            .DisplayMember = "des_dis"
        End With
    End Sub
    Public Shared Sub distrito_x_zona(ByVal lista As ListBox, ByVal val As String)
        With lista
            .DataSource = Listado("SELECT * from m_distritos where cod_zona in('" & val & "') order by des_dis asc ")
            .ValueMember = "cod_dis"
            .DisplayMember = "des_dis"
        End With
    End Sub
End Class
