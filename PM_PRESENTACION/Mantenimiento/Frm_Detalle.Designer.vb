<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Detalle
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
        Me.gbx_doctor = New System.Windows.Forms.GroupBox()
        Me.rb_acovid = New System.Windows.Forms.RadioButton()
        Me.rb_cronico = New System.Windows.Forms.RadioButton()
        Me.rb_agudo_1 = New System.Windows.Forms.RadioButton()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp_ini_doc = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fin_doc = New System.Windows.Forms.DateTimePicker()
        Me.cbo_doctor = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_motorizado = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbMpos = New System.Windows.Forms.ComboBox()
        Me.dtp_horfin_mot = New System.Windows.Forms.DateTimePicker()
        Me.dtp_horini_mot = New System.Windows.Forms.DateTimePicker()
        Me.cbo_motorizado = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbo_empresa = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_grabar_det = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_botiquin = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tdpfec_asignacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.cbo_turno = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.chk_conductor = New System.Windows.Forms.CheckBox()
        Me.txt_turno = New System.Windows.Forms.TextBox()
        Me.txtcod_esp = New System.Windows.Forms.TextBox()
        Me.txtcod_doc = New System.Windows.Forms.TextBox()
        Me.chk_doctor = New System.Windows.Forms.CheckBox()
        Me.txtcod_mot = New System.Windows.Forms.TextBox()
        Me.btn_desconfirma = New System.Windows.Forms.Button()
        Me.txt_ind = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gbx_doctor.SuspendLayout()
        Me.gbx_motorizado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_doctor
        '
        Me.gbx_doctor.Controls.Add(Me.rb_acovid)
        Me.gbx_doctor.Controls.Add(Me.rb_cronico)
        Me.gbx_doctor.Controls.Add(Me.rb_agudo_1)
        Me.gbx_doctor.Controls.Add(Me.cbo_especialidad)
        Me.gbx_doctor.Controls.Add(Me.Label8)
        Me.gbx_doctor.Controls.Add(Me.dtp_ini_doc)
        Me.gbx_doctor.Controls.Add(Me.dtp_fin_doc)
        Me.gbx_doctor.Controls.Add(Me.cbo_doctor)
        Me.gbx_doctor.Controls.Add(Me.Label15)
        Me.gbx_doctor.Controls.Add(Me.Label16)
        Me.gbx_doctor.Controls.Add(Me.Label1)
        Me.gbx_doctor.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_doctor.Location = New System.Drawing.Point(4, 4)
        Me.gbx_doctor.Name = "gbx_doctor"
        Me.gbx_doctor.Size = New System.Drawing.Size(443, 108)
        Me.gbx_doctor.TabIndex = 0
        Me.gbx_doctor.TabStop = False
        Me.gbx_doctor.Text = "Datos del Doctor"
        '
        'rb_acovid
        '
        Me.rb_acovid.AutoSize = True
        Me.rb_acovid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_acovid.Location = New System.Drawing.Point(371, 12)
        Me.rb_acovid.Name = "rb_acovid"
        Me.rb_acovid.Size = New System.Drawing.Size(79, 17)
        Me.rb_acovid.TabIndex = 48
        Me.rb_acovid.TabStop = True
        Me.rb_acovid.Text = "A. COVID"
        Me.rb_acovid.UseVisualStyleBackColor = True
        '
        'rb_cronico
        '
        Me.rb_cronico.AutoSize = True
        Me.rb_cronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_cronico.Location = New System.Drawing.Point(305, 22)
        Me.rb_cronico.Name = "rb_cronico"
        Me.rb_cronico.Size = New System.Drawing.Size(81, 17)
        Me.rb_cronico.TabIndex = 49
        Me.rb_cronico.TabStop = True
        Me.rb_cronico.Text = "CRONICO"
        Me.rb_cronico.UseVisualStyleBackColor = True
        '
        'rb_agudo_1
        '
        Me.rb_agudo_1.AutoSize = True
        Me.rb_agudo_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_agudo_1.Location = New System.Drawing.Point(272, 7)
        Me.rb_agudo_1.Name = "rb_agudo_1"
        Me.rb_agudo_1.Size = New System.Drawing.Size(69, 17)
        Me.rb_agudo_1.TabIndex = 48
        Me.rb_agudo_1.TabStop = True
        Me.rb_agudo_1.Text = "AGUDO"
        Me.rb_agudo_1.UseVisualStyleBackColor = True
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(75, 16)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(195, 22)
        Me.cbo_especialidad.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 14)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Especialidad :"
        '
        'dtp_ini_doc
        '
        Me.dtp_ini_doc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ini_doc.CustomFormat = "HH:mm"
        Me.dtp_ini_doc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ini_doc.Location = New System.Drawing.Point(144, 71)
        Me.dtp_ini_doc.Name = "dtp_ini_doc"
        Me.dtp_ini_doc.ShowUpDown = True
        Me.dtp_ini_doc.Size = New System.Drawing.Size(82, 22)
        Me.dtp_ini_doc.TabIndex = 40
        Me.dtp_ini_doc.Value = New Date(2013, 6, 3, 6, 0, 0, 0)
        '
        'dtp_fin_doc
        '
        Me.dtp_fin_doc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fin_doc.CustomFormat = "HH:mm"
        Me.dtp_fin_doc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_fin_doc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fin_doc.Location = New System.Drawing.Point(315, 71)
        Me.dtp_fin_doc.Name = "dtp_fin_doc"
        Me.dtp_fin_doc.ShowUpDown = True
        Me.dtp_fin_doc.Size = New System.Drawing.Size(109, 22)
        Me.dtp_fin_doc.TabIndex = 39
        Me.dtp_fin_doc.Value = New Date(2013, 6, 3, 15, 0, 0, 0)
        '
        'cbo_doctor
        '
        Me.cbo_doctor.FormattingEnabled = True
        Me.cbo_doctor.Location = New System.Drawing.Point(71, 44)
        Me.cbo_doctor.Name = "cbo_doctor"
        Me.cbo_doctor.Size = New System.Drawing.Size(353, 22)
        Me.cbo_doctor.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(251, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 18)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Hora Final"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 18)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Hora Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Doctor :"
        '
        'gbx_motorizado
        '
        Me.gbx_motorizado.Controls.Add(Me.Label9)
        Me.gbx_motorizado.Controls.Add(Me.cmbMpos)
        Me.gbx_motorizado.Controls.Add(Me.dtp_horfin_mot)
        Me.gbx_motorizado.Controls.Add(Me.dtp_horini_mot)
        Me.gbx_motorizado.Controls.Add(Me.cbo_motorizado)
        Me.gbx_motorizado.Controls.Add(Me.Label12)
        Me.gbx_motorizado.Controls.Add(Me.cbo_empresa)
        Me.gbx_motorizado.Controls.Add(Me.Label4)
        Me.gbx_motorizado.Controls.Add(Me.Label6)
        Me.gbx_motorizado.Controls.Add(Me.Label3)
        Me.gbx_motorizado.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_motorizado.Location = New System.Drawing.Point(4, 391)
        Me.gbx_motorizado.Name = "gbx_motorizado"
        Me.gbx_motorizado.Size = New System.Drawing.Size(443, 138)
        Me.gbx_motorizado.TabIndex = 1
        Me.gbx_motorizado.TabStop = False
        Me.gbx_motorizado.Text = "Datos del Motorizado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 14)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Con MPOS"
        '
        'cmbMpos
        '
        Me.cmbMpos.FormattingEnabled = True
        Me.cmbMpos.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmbMpos.Location = New System.Drawing.Point(128, 70)
        Me.cmbMpos.Name = "cmbMpos"
        Me.cmbMpos.Size = New System.Drawing.Size(297, 22)
        Me.cmbMpos.TabIndex = 43
        '
        'dtp_horfin_mot
        '
        Me.dtp_horfin_mot.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_horfin_mot.CustomFormat = "HH:mm"
        Me.dtp_horfin_mot.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_horfin_mot.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_horfin_mot.Location = New System.Drawing.Point(315, 108)
        Me.dtp_horfin_mot.Name = "dtp_horfin_mot"
        Me.dtp_horfin_mot.ShowUpDown = True
        Me.dtp_horfin_mot.Size = New System.Drawing.Size(109, 22)
        Me.dtp_horfin_mot.TabIndex = 42
        Me.dtp_horfin_mot.Value = New Date(2013, 6, 3, 15, 0, 0, 0)
        '
        'dtp_horini_mot
        '
        Me.dtp_horini_mot.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_horini_mot.CustomFormat = "HH:mm"
        Me.dtp_horini_mot.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_horini_mot.Location = New System.Drawing.Point(128, 111)
        Me.dtp_horini_mot.Name = "dtp_horini_mot"
        Me.dtp_horini_mot.ShowUpDown = True
        Me.dtp_horini_mot.Size = New System.Drawing.Size(82, 22)
        Me.dtp_horini_mot.TabIndex = 41
        Me.dtp_horini_mot.Value = New Date(2013, 6, 3, 6, 0, 0, 0)
        '
        'cbo_motorizado
        '
        Me.cbo_motorizado.FormattingEnabled = True
        Me.cbo_motorizado.Location = New System.Drawing.Point(128, 43)
        Me.cbo_motorizado.Name = "cbo_motorizado"
        Me.cbo_motorizado.Size = New System.Drawing.Size(297, 22)
        Me.cbo_motorizado.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 14)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Empresa"
        '
        'cbo_empresa
        '
        Me.cbo_empresa.FormattingEnabled = True
        Me.cbo_empresa.Items.AddRange(New Object() {"PROPIO", "GMA", "JP", "CASA REMISSE", "MOTORIZADO", "AMBULANCIA", "NINGUNO"})
        Me.cbo_empresa.Location = New System.Drawing.Point(128, 18)
        Me.cbo_empresa.Name = "cbo_empresa"
        Me.cbo_empresa.Size = New System.Drawing.Size(296, 22)
        Me.cbo_empresa.TabIndex = 35
        Me.cbo_empresa.Text = "NINGUNO"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Hora Final"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Hora Inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Conductor"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.lbl_estado)
        Me.Panel1.Controls.Add(Me.lblusuario)
        Me.Panel1.Controls.Add(Me.lblestado)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(4, 532)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 32)
        Me.Panel1.TabIndex = 18
        '
        'lbl_estado
        '
        Me.lbl_estado.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_estado.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estado.ForeColor = System.Drawing.Color.Red
        Me.lbl_estado.Location = New System.Drawing.Point(329, 8)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(97, 19)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "PENDIENTE"
        Me.lbl_estado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblusuario
        '
        Me.lblusuario.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.White
        Me.lblusuario.Location = New System.Drawing.Point(57, 11)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(95, 14)
        Me.lblusuario.TabIndex = 0
        Me.lblusuario.Text = "ADMINISTRADOR"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.White
        Me.lblestado.Location = New System.Drawing.Point(213, 11)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(114, 14)
        Me.lblestado.TabIndex = 0
        Me.lblestado.Text = "Estado Programacion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Usuario:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(110, 569)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_grabar_det
        '
        Me.btn_grabar_det.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_grabar_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar_det.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_grabar_det.Location = New System.Drawing.Point(4, 569)
        Me.btn_grabar_det.Name = "btn_grabar_det"
        Me.btn_grabar_det.Size = New System.Drawing.Size(104, 23)
        Me.btn_grabar_det.TabIndex = 16
        Me.btn_grabar_det.Text = "Grabar"
        Me.btn_grabar_det.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.Blue
        Me.btn_confirmar.Location = New System.Drawing.Point(331, 569)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(104, 23)
        Me.btn_confirmar.TabIndex = 18
        Me.btn_confirmar.Text = "&Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(481, 73)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(116, 20)
        Me.txtcod.TabIndex = 19
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Controls.Add(Me.Label17)
        Me.gbx_Detalle.Controls.Add(Me.txt_ind)
        Me.gbx_Detalle.Controls.Add(Me.ComboBox2)
        Me.gbx_Detalle.Controls.Add(Me.Label14)
        Me.gbx_Detalle.Controls.Add(Me.ComboBox1)
        Me.gbx_Detalle.Controls.Add(Me.Label11)
        Me.gbx_Detalle.Controls.Add(Me.cbo_botiquin)
        Me.gbx_Detalle.Controls.Add(Me.Label2)
        Me.gbx_Detalle.Controls.Add(Me.tdpfec_asignacion)
        Me.gbx_Detalle.Controls.Add(Me.txt_fecha)
        Me.gbx_Detalle.Controls.Add(Me.cbo_turno)
        Me.gbx_Detalle.Controls.Add(Me.Label10)
        Me.gbx_Detalle.Controls.Add(Me.Label5)
        Me.gbx_Detalle.Controls.Add(Me.Label13)
        Me.gbx_Detalle.Controls.Add(Me.txt_des)
        Me.gbx_Detalle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Detalle.Location = New System.Drawing.Point(4, 118)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(443, 260)
        Me.gbx_Detalle.TabIndex = 20
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Detalle Asignacion"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(235, 106)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(191, 22)
        Me.ComboBox2.TabIndex = 58
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(237, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 14)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "N° Maletin"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(235, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(191, 22)
        Me.ComboBox1.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(235, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 14)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "N° Tablet"
        '
        'cbo_botiquin
        '
        Me.cbo_botiquin.FormattingEnabled = True
        Me.cbo_botiquin.Location = New System.Drawing.Point(235, 27)
        Me.cbo_botiquin.Name = "cbo_botiquin"
        Me.cbo_botiquin.Size = New System.Drawing.Size(191, 22)
        Me.cbo_botiquin.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Botiquin"
        '
        'tdpfec_asignacion
        '
        Me.tdpfec_asignacion.Location = New System.Drawing.Point(205, 228)
        Me.tdpfec_asignacion.Name = "tdpfec_asignacion"
        Me.tdpfec_asignacion.Size = New System.Drawing.Size(21, 22)
        Me.tdpfec_asignacion.TabIndex = 48
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(4, 228)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(202, 22)
        Me.txt_fecha.TabIndex = 47
        '
        'cbo_turno
        '
        Me.cbo_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_turno.FormattingEnabled = True
        Me.cbo_turno.Items.AddRange(New Object() {"MAÑANA", "TARDE", "MADRUGADA"})
        Me.cbo_turno.Location = New System.Drawing.Point(294, 133)
        Me.cbo_turno.Name = "cbo_turno"
        Me.cbo_turno.Size = New System.Drawing.Size(132, 22)
        Me.cbo_turno.TabIndex = 46
        Me.cbo_turno.Tag = "[Seleccione turno]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(249, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 14)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Fecha asignacion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 14)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Observacion"
        '
        'txt_des
        '
        Me.txt_des.Location = New System.Drawing.Point(7, 30)
        Me.txt_des.Multiline = True
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(219, 74)
        Me.txt_des.TabIndex = 42
        '
        'chk_conductor
        '
        Me.chk_conductor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_conductor.Checked = True
        Me.chk_conductor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_conductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_conductor.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_conductor.Location = New System.Drawing.Point(380, 384)
        Me.chk_conductor.Name = "chk_conductor"
        Me.chk_conductor.Size = New System.Drawing.Size(53, 19)
        Me.chk_conductor.TabIndex = 49
        Me.chk_conductor.Text = "Editar"
        Me.chk_conductor.UseVisualStyleBackColor = True
        '
        'txt_turno
        '
        Me.txt_turno.Location = New System.Drawing.Point(490, 149)
        Me.txt_turno.Name = "txt_turno"
        Me.txt_turno.Size = New System.Drawing.Size(54, 20)
        Me.txt_turno.TabIndex = 22
        '
        'txtcod_esp
        '
        Me.txtcod_esp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcod_esp.Location = New System.Drawing.Point(490, 175)
        Me.txtcod_esp.Name = "txtcod_esp"
        Me.txtcod_esp.Size = New System.Drawing.Size(54, 20)
        Me.txtcod_esp.TabIndex = 23
        '
        'txtcod_doc
        '
        Me.txtcod_doc.Location = New System.Drawing.Point(490, 203)
        Me.txtcod_doc.Name = "txtcod_doc"
        Me.txtcod_doc.Size = New System.Drawing.Size(54, 20)
        Me.txtcod_doc.TabIndex = 24
        '
        'chk_doctor
        '
        Me.chk_doctor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_doctor.Checked = True
        Me.chk_doctor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_doctor.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_doctor.Location = New System.Drawing.Point(382, 0)
        Me.chk_doctor.Name = "chk_doctor"
        Me.chk_doctor.Size = New System.Drawing.Size(53, 19)
        Me.chk_doctor.TabIndex = 50
        Me.chk_doctor.Text = "Editar"
        Me.chk_doctor.UseVisualStyleBackColor = True
        '
        'txtcod_mot
        '
        Me.txtcod_mot.Location = New System.Drawing.Point(490, 229)
        Me.txtcod_mot.Name = "txtcod_mot"
        Me.txtcod_mot.Size = New System.Drawing.Size(54, 20)
        Me.txtcod_mot.TabIndex = 51
        '
        'btn_desconfirma
        '
        Me.btn_desconfirma.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_desconfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desconfirma.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desconfirma.ForeColor = System.Drawing.Color.Blue
        Me.btn_desconfirma.Location = New System.Drawing.Point(243, 570)
        Me.btn_desconfirma.Name = "btn_desconfirma"
        Me.btn_desconfirma.Size = New System.Drawing.Size(85, 22)
        Me.btn_desconfirma.TabIndex = 52
        Me.btn_desconfirma.Text = "&Desconfirmar"
        Me.btn_desconfirma.UseVisualStyleBackColor = False
        '
        'txt_ind
        '
        Me.txt_ind.Location = New System.Drawing.Point(7, 128)
        Me.txt_ind.Multiline = True
        Me.txt_ind.Name = "txt_ind"
        Me.txt_ind.Size = New System.Drawing.Size(219, 74)
        Me.txt_ind.TabIndex = 59
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 14)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Indicaciones del Doctor"
        '
        'Frm_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(448, 645)
        Me.Controls.Add(Me.btn_desconfirma)
        Me.Controls.Add(Me.txtcod_mot)
        Me.Controls.Add(Me.chk_conductor)
        Me.Controls.Add(Me.chk_doctor)
        Me.Controls.Add(Me.txtcod_doc)
        Me.Controls.Add(Me.txtcod_esp)
        Me.Controls.Add(Me.txt_turno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.gbx_motorizado)
        Me.Controls.Add(Me.gbx_doctor)
        Me.Controls.Add(Me.btn_grabar_det)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(454, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(454, 520)
        Me.Name = "Frm_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Detalle de Horario]"
        Me.gbx_doctor.ResumeLayout(False)
        Me.gbx_doctor.PerformLayout()
        Me.gbx_motorizado.ResumeLayout(False)
        Me.gbx_motorizado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Detalle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbx_doctor As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_motorizado As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_grabar_det As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbo_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_motorizado As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_ini_doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fin_doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents dtp_horfin_mot As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_horini_mot As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents chk_conductor As System.Windows.Forms.CheckBox
    Friend WithEvents tdpfec_asignacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents cbo_turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents txt_turno As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_esp As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_doc As System.Windows.Forms.TextBox
    Friend WithEvents chk_doctor As System.Windows.Forms.CheckBox
    Friend WithEvents txtcod_mot As System.Windows.Forms.TextBox
    Friend WithEvents btn_desconfirma As System.Windows.Forms.Button
    Friend WithEvents rb_acovid As System.Windows.Forms.RadioButton
    Friend WithEvents rb_agudo_1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbMpos As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_botiquin As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rb_cronico As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_ind As System.Windows.Forms.TextBox
End Class
