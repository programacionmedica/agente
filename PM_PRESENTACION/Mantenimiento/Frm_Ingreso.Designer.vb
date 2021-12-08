<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ingreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ingreso))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp_asignacion = New System.Windows.Forms.TabPage()
        Me.rb_auto_covid = New System.Windows.Forms.RadioButton()
        Me.rb_ccs = New System.Windows.Forms.RadioButton()
        Me.rb_mad = New System.Windows.Forms.RadioButton()
        Me.lbl_asociado = New System.Windows.Forms.Label()
        Me.dgv_listado = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_empresa = New System.Windows.Forms.ComboBox()
        Me.dtp_HoraIni_Doc = New System.Windows.Forms.DateTimePicker()
        Me.dtp_HoraFin_Mot = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtp_HoraIni_Mot = New System.Windows.Forms.DateTimePicker()
        Me.cbo_motorizado = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_desc_doc = New System.Windows.Forms.TextBox()
        Me.dtp_HoraFin_Doc = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_doctor = New System.Windows.Forms.ComboBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tdpfec_asignacion = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_turno = New System.Windows.Forms.ComboBox()
        Me.lblcodigo_asig = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnambulancia = New System.Windows.Forms.Button()
        Me.btn_asociar = New System.Windows.Forms.Button()
        Me.btn_Actualiza = New System.Windows.Forms.Button()
        Me.lbl_semana = New System.Windows.Forms.Label()
        Me.btn_exporta_pdf = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_Exporta = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tp_asignacion.SuspendLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cbo_especialidad)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 69)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Especialidades"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 69)
        Me.Panel1.TabIndex = 52
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(190, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 14)
        Me.Label25.TabIndex = 54
        Me.Label25.Text = "Codigo:"
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_especialidad.ForeColor = System.Drawing.Color.Black
        Me.cbo_especialidad.FormatString = "Seleccionar aqui"
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(7, 14)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(284, 22)
        Me.cbo_especialidad.TabIndex = 0
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(242, 45)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(51, 14)
        Me.lblcodigo.TabIndex = 53
        Me.lblcodigo.Text = "lblcodigo"
        Me.lblcodigo.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tp_asignacion)
        Me.TabControl1.Location = New System.Drawing.Point(5, 95)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1281, 489)
        Me.TabControl1.TabIndex = 4
        '
        'tp_asignacion
        '
        Me.tp_asignacion.BackColor = System.Drawing.Color.White
        Me.tp_asignacion.Controls.Add(Me.rb_auto_covid)
        Me.tp_asignacion.Controls.Add(Me.rb_ccs)
        Me.tp_asignacion.Controls.Add(Me.rb_mad)
        Me.tp_asignacion.Controls.Add(Me.lbl_asociado)
        Me.tp_asignacion.Controls.Add(Me.dgv_listado)
        Me.tp_asignacion.Controls.Add(Me.Label9)
        Me.tp_asignacion.Controls.Add(Me.cbo_empresa)
        Me.tp_asignacion.Controls.Add(Me.dtp_HoraIni_Doc)
        Me.tp_asignacion.Controls.Add(Me.dtp_HoraFin_Mot)
        Me.tp_asignacion.Controls.Add(Me.Label1)
        Me.tp_asignacion.Controls.Add(Me.Label11)
        Me.tp_asignacion.Controls.Add(Me.Label12)
        Me.tp_asignacion.Controls.Add(Me.dtp_HoraIni_Mot)
        Me.tp_asignacion.Controls.Add(Me.cbo_motorizado)
        Me.tp_asignacion.Controls.Add(Me.Label13)
        Me.tp_asignacion.Controls.Add(Me.txt_desc_doc)
        Me.tp_asignacion.Controls.Add(Me.dtp_HoraFin_Doc)
        Me.tp_asignacion.Controls.Add(Me.Label14)
        Me.tp_asignacion.Controls.Add(Me.Label15)
        Me.tp_asignacion.Controls.Add(Me.Label16)
        Me.tp_asignacion.Controls.Add(Me.cbo_doctor)
        Me.tp_asignacion.Location = New System.Drawing.Point(4, 22)
        Me.tp_asignacion.Name = "tp_asignacion"
        Me.tp_asignacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_asignacion.Size = New System.Drawing.Size(1273, 463)
        Me.tp_asignacion.TabIndex = 5
        Me.tp_asignacion.Text = "Asignacion de Disponibilidad"
        '
        'rb_auto_covid
        '
        Me.rb_auto_covid.AutoSize = True
        Me.rb_auto_covid.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_auto_covid.Location = New System.Drawing.Point(236, 1)
        Me.rb_auto_covid.Name = "rb_auto_covid"
        Me.rb_auto_covid.Size = New System.Drawing.Size(67, 17)
        Me.rb_auto_covid.TabIndex = 39
        Me.rb_auto_covid.Text = "A. COVID"
        Me.rb_auto_covid.UseVisualStyleBackColor = True
        '
        'rb_ccs
        '
        Me.rb_ccs.AutoSize = True
        Me.rb_ccs.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_ccs.Location = New System.Drawing.Point(170, 2)
        Me.rb_ccs.Name = "rb_ccs"
        Me.rb_ccs.Size = New System.Drawing.Size(67, 17)
        Me.rb_ccs.TabIndex = 38
        Me.rb_ccs.Text = "CRONICO"
        Me.rb_ccs.UseVisualStyleBackColor = True
        '
        'rb_mad
        '
        Me.rb_mad.AutoSize = True
        Me.rb_mad.Checked = True
        Me.rb_mad.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_mad.Location = New System.Drawing.Point(110, 2)
        Me.rb_mad.Name = "rb_mad"
        Me.rb_mad.Size = New System.Drawing.Size(60, 17)
        Me.rb_mad.TabIndex = 38
        Me.rb_mad.TabStop = True
        Me.rb_mad.Text = "AGUDO"
        Me.rb_mad.UseVisualStyleBackColor = True
        '
        'lbl_asociado
        '
        Me.lbl_asociado.AutoSize = True
        Me.lbl_asociado.Location = New System.Drawing.Point(33, 6)
        Me.lbl_asociado.Name = "lbl_asociado"
        Me.lbl_asociado.Size = New System.Drawing.Size(39, 13)
        Me.lbl_asociado.TabIndex = 37
        Me.lbl_asociado.Text = "Label2"
        Me.lbl_asociado.Visible = False
        '
        'dgv_listado
        '
        Me.dgv_listado.AllowUserToAddRows = False
        Me.dgv_listado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_listado.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listado.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_listado.GridColor = System.Drawing.Color.Blue
        Me.dgv_listado.Location = New System.Drawing.Point(14, 106)
        Me.dgv_listado.Name = "dgv_listado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listado.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_listado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listado.Size = New System.Drawing.Size(1297, 355)
        Me.dgv_listado.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(757, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 14)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Empresa"
        '
        'cbo_empresa
        '
        Me.cbo_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_empresa.FormattingEnabled = True
        Me.cbo_empresa.Location = New System.Drawing.Point(813, 11)
        Me.cbo_empresa.Name = "cbo_empresa"
        Me.cbo_empresa.Size = New System.Drawing.Size(230, 21)
        Me.cbo_empresa.TabIndex = 33
        '
        'dtp_HoraIni_Doc
        '
        Me.dtp_HoraIni_Doc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraIni_Doc.CustomFormat = "HH:mm"
        Me.dtp_HoraIni_Doc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraIni_Doc.Location = New System.Drawing.Point(53, 76)
        Me.dtp_HoraIni_Doc.Name = "dtp_HoraIni_Doc"
        Me.dtp_HoraIni_Doc.ShowUpDown = True
        Me.dtp_HoraIni_Doc.Size = New System.Drawing.Size(82, 20)
        Me.dtp_HoraIni_Doc.TabIndex = 22
        Me.dtp_HoraIni_Doc.Value = New Date(2013, 6, 3, 6, 0, 0, 0)
        '
        'dtp_HoraFin_Mot
        '
        Me.dtp_HoraFin_Mot.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraFin_Mot.CustomFormat = "HH:mm"
        Me.dtp_HoraFin_Mot.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraFin_Mot.Location = New System.Drawing.Point(945, 60)
        Me.dtp_HoraFin_Mot.Name = "dtp_HoraFin_Mot"
        Me.dtp_HoraFin_Mot.ShowUpDown = True
        Me.dtp_HoraFin_Mot.Size = New System.Drawing.Size(97, 20)
        Me.dtp_HoraFin_Mot.TabIndex = 14
        Me.dtp_HoraFin_Mot.Value = New Date(2013, 6, 3, 15, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(695, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Conductor"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(909, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 28)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Hora Final"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(697, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 28)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Hora Oficina"
        '
        'dtp_HoraIni_Mot
        '
        Me.dtp_HoraIni_Mot.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraIni_Mot.CustomFormat = "HH:mm"
        Me.dtp_HoraIni_Mot.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraIni_Mot.Location = New System.Drawing.Point(760, 60)
        Me.dtp_HoraIni_Mot.Name = "dtp_HoraIni_Mot"
        Me.dtp_HoraIni_Mot.ShowUpDown = True
        Me.dtp_HoraIni_Mot.Size = New System.Drawing.Size(102, 20)
        Me.dtp_HoraIni_Mot.TabIndex = 13
        Me.dtp_HoraIni_Mot.Value = New Date(2013, 6, 3, 6, 0, 0, 0)
        '
        'cbo_motorizado
        '
        Me.cbo_motorizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_motorizado.FormattingEnabled = True
        Me.cbo_motorizado.Location = New System.Drawing.Point(760, 33)
        Me.cbo_motorizado.Name = "cbo_motorizado"
        Me.cbo_motorizado.Size = New System.Drawing.Size(283, 21)
        Me.cbo_motorizado.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(313, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 14)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Indicaciones del Doctor"
        '
        'txt_desc_doc
        '
        Me.txt_desc_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_doc.Location = New System.Drawing.Point(300, 27)
        Me.txt_desc_doc.Multiline = True
        Me.txt_desc_doc.Name = "txt_desc_doc"
        Me.txt_desc_doc.Size = New System.Drawing.Size(384, 70)
        Me.txt_desc_doc.TabIndex = 10
        '
        'dtp_HoraFin_Doc
        '
        Me.dtp_HoraFin_Doc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraFin_Doc.CustomFormat = "HH:mm"
        Me.dtp_HoraFin_Doc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_HoraFin_Doc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraFin_Doc.Location = New System.Drawing.Point(201, 77)
        Me.dtp_HoraFin_Doc.Name = "dtp_HoraFin_Doc"
        Me.dtp_HoraFin_Doc.ShowUpDown = True
        Me.dtp_HoraFin_Doc.Size = New System.Drawing.Size(77, 20)
        Me.dtp_HoraFin_Doc.TabIndex = 4
        Me.dtp_HoraFin_Doc.Value = New Date(2013, 6, 3, 15, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 14)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Doctor"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(159, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 28)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Hora Final"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 28)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Hora Inicial"
        '
        'cbo_doctor
        '
        Me.cbo_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_doctor.FormattingEnabled = True
        Me.cbo_doctor.Location = New System.Drawing.Point(3, 44)
        Me.cbo_doctor.Name = "cbo_doctor"
        Me.cbo_doctor.Size = New System.Drawing.Size(275, 21)
        Me.cbo_doctor.TabIndex = 1
        '
        'lblcantidad
        '
        Me.lblcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcantidad.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.Location = New System.Drawing.Point(1251, 594)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(54, 20)
        Me.lblcantidad.TabIndex = 36
        Me.lblcantidad.Text = "00000"
        Me.lblcantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblcantidad.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1196, 596)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Registro:"
        Me.Label8.Visible = False
        '
        'tdpfec_asignacion
        '
        Me.tdpfec_asignacion.Location = New System.Drawing.Point(340, 26)
        Me.tdpfec_asignacion.Name = "tdpfec_asignacion"
        Me.tdpfec_asignacion.Size = New System.Drawing.Size(200, 20)
        Me.tdpfec_asignacion.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(543, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "turno"
        '
        'cbo_turno
        '
        Me.cbo_turno.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_turno.ForeColor = System.Drawing.Color.Black
        Me.cbo_turno.FormattingEnabled = True
        Me.cbo_turno.Items.AddRange(New Object() {"MAÑANA", "TARDE", "MADRUGADA"})
        Me.cbo_turno.Location = New System.Drawing.Point(546, 26)
        Me.cbo_turno.Name = "cbo_turno"
        Me.cbo_turno.Size = New System.Drawing.Size(174, 22)
        Me.cbo_turno.TabIndex = 3
        Me.cbo_turno.Tag = "[Seleccione turno]"
        Me.cbo_turno.Text = "[---Seleccione Turno---]"
        '
        'lblcodigo_asig
        '
        Me.lblcodigo_asig.BackColor = System.Drawing.SystemColors.Info
        Me.lblcodigo_asig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo_asig.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo_asig.ForeColor = System.Drawing.Color.Blue
        Me.lblcodigo_asig.Location = New System.Drawing.Point(961, 0)
        Me.lblcodigo_asig.Name = "lblcodigo_asig"
        Me.lblcodigo_asig.Size = New System.Drawing.Size(67, 18)
        Me.lblcodigo_asig.TabIndex = 29
        Me.lblcodigo_asig.Text = "0001"
        Me.lblcodigo_asig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblcodigo_asig.Visible = False
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(778, 62)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(0, 13)
        Me.lbluser.TabIndex = 47
        Me.lbluser.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(921, 590)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 30)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_fecha.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecha.Location = New System.Drawing.Point(340, 47)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(91, 14)
        Me.lbl_fecha.TabIndex = 51
        Me.lbl_fecha.Text = "0"
        Me.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_fecha.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha asignacion"
        Me.Label5.Visible = False
        '
        'btnambulancia
        '
        Me.btnambulancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnambulancia.Location = New System.Drawing.Point(356, 590)
        Me.btnambulancia.Name = "btnambulancia"
        Me.btnambulancia.Size = New System.Drawing.Size(123, 30)
        Me.btnambulancia.TabIndex = 52
        Me.btnambulancia.Text = "Generar ambulancia"
        Me.btnambulancia.UseVisualStyleBackColor = True
        '
        'btn_asociar
        '
        Me.btn_asociar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_asociar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_asociar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_asociar.ForeColor = System.Drawing.Color.Red
        Me.btn_asociar.Image = Global.PM_PRESENTACION.My.Resources.Resources.bookmark_folder
        Me.btn_asociar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_asociar.Location = New System.Drawing.Point(615, 590)
        Me.btn_asociar.Name = "btn_asociar"
        Me.btn_asociar.Size = New System.Drawing.Size(29, 30)
        Me.btn_asociar.TabIndex = 50
        Me.btn_asociar.Text = "&Asociar"
        Me.btn_asociar.UseVisualStyleBackColor = False
        Me.btn_asociar.Visible = False
        '
        'btn_Actualiza
        '
        Me.btn_Actualiza.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_Actualiza.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Actualiza.Image = Global.PM_PRESENTACION.My.Resources.Resources.actualiza
        Me.btn_Actualiza.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Actualiza.Location = New System.Drawing.Point(364, 634)
        Me.btn_Actualiza.Name = "btn_Actualiza"
        Me.btn_Actualiza.Size = New System.Drawing.Size(142, 30)
        Me.btn_Actualiza.TabIndex = 49
        Me.btn_Actualiza.Text = "&Actualizar"
        Me.btn_Actualiza.UseVisualStyleBackColor = False
        Me.btn_Actualiza.Visible = False
        '
        'lbl_semana
        '
        Me.lbl_semana.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_semana.BackColor = System.Drawing.Color.Transparent
        Me.lbl_semana.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_semana.ForeColor = System.Drawing.Color.Blue
        Me.lbl_semana.Image = Global.PM_PRESENTACION.My.Resources.Resources.sana
        Me.lbl_semana.Location = New System.Drawing.Point(961, 0)
        Me.lbl_semana.Name = "lbl_semana"
        Me.lbl_semana.Size = New System.Drawing.Size(298, 92)
        Me.lbl_semana.TabIndex = 41
        Me.lbl_semana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_exporta_pdf
        '
        Me.btn_exporta_pdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_exporta_pdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_exporta_pdf.Image = Global.PM_PRESENTACION.My.Resources.Resources.icono_pdf
        Me.btn_exporta_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exporta_pdf.Location = New System.Drawing.Point(802, 590)
        Me.btn_exporta_pdf.Name = "btn_exporta_pdf"
        Me.btn_exporta_pdf.Size = New System.Drawing.Size(117, 30)
        Me.btn_exporta_pdf.TabIndex = 44
        Me.btn_exporta_pdf.Text = "Exportar PDF"
        Me.btn_exporta_pdf.UseVisualStyleBackColor = False
        Me.btn_exporta_pdf.Visible = False
        '
        'btn_agregar
        '
        Me.btn_agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_agregar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Image = Global.PM_PRESENTACION.My.Resources.Resources.agregar
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_agregar.Location = New System.Drawing.Point(139, 590)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(122, 30)
        Me.btn_agregar.TabIndex = 42
        Me.btn_agregar.Text = "&Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_Exporta
        '
        Me.btn_Exporta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exporta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Exporta.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exporta.Image = Global.PM_PRESENTACION.My.Resources.Resources._16__Doc_excel_
        Me.btn_Exporta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exporta.Location = New System.Drawing.Point(667, 590)
        Me.btn_Exporta.Name = "btn_Exporta"
        Me.btn_Exporta.Size = New System.Drawing.Size(129, 30)
        Me.btn_Exporta.TabIndex = 22
        Me.btn_Exporta.Text = "Exportar Excel"
        Me.btn_Exporta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exporta.UseVisualStyleBackColor = False
        Me.btn_Exporta.Visible = False
        '
        'Frm_Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 627)
        Me.Controls.Add(Me.btnambulancia)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbo_turno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.btn_asociar)
        Me.Controls.Add(Me.btn_Actualiza)
        Me.Controls.Add(Me.lbl_semana)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.btn_exporta_pdf)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lblcodigo_asig)
        Me.Controls.Add(Me.btn_Exporta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tdpfec_asignacion)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Ingreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO - PROGRAMACION HORARIO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tp_asignacion.ResumeLayout(False)
        Me.tp_asignacion.PerformLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tdpfec_asignacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbo_turno As System.Windows.Forms.ComboBox
    Friend WithEvents tp_asignacion As System.Windows.Forms.TabPage
    Friend WithEvents dtp_HoraFin_Mot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraIni_Mot As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_motorizado As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_desc_doc As System.Windows.Forms.TextBox
    Friend WithEvents dtp_HoraFin_Doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbo_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Exporta As System.Windows.Forms.Button
    Friend WithEvents dtp_HoraIni_Doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblcodigo_asig As System.Windows.Forms.Label
    Friend WithEvents lbl_semana As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbo_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv_listado As System.Windows.Forms.DataGridView
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_exporta_pdf As System.Windows.Forms.Button
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Actualiza As System.Windows.Forms.Button
    Friend WithEvents btn_asociar As System.Windows.Forms.Button
    Friend WithEvents lbl_asociado As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_ccs As System.Windows.Forms.RadioButton
    Friend WithEvents rb_mad As System.Windows.Forms.RadioButton
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnambulancia As System.Windows.Forms.Button
    Friend WithEvents rb_auto_covid As System.Windows.Forms.RadioButton

End Class
