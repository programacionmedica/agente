<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperador
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp_busqueda = New System.Windows.Forms.TabPage()
        Me.cbo_clasificacion = New System.Windows.Forms.ComboBox()
        Me.txtnom_esp = New System.Windows.Forms.TextBox()
        Me.txtcod_esp = New System.Windows.Forms.TextBox()
        Me.lbldesprogramado = New System.Windows.Forms.Label()
        Me.lblprogramado = New System.Windows.Forms.Label()
        Me.lbl_cantmedico = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chk_lista_doctor = New System.Windows.Forms.CheckedListBox()
        Me.panel_filtro = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbo_detalle = New System.Windows.Forms.ComboBox()
        Me.btn_filtro = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtnom_doc = New System.Windows.Forms.TextBox()
        Me.lst_bus_distrito = New System.Windows.Forms.ListBox()
        Me.dgv_reporte = New System.Windows.Forms.DataGridView()
        Me.DgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbo_xturno = New System.Windows.Forms.ComboBox()
        Me.cbo_flag = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_zona_bus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_fecfin_asig_bus = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecini_asig_bus = New System.Windows.Forms.DateTimePicker()
        Me.textboxespecialidad = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_busqueda = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_incidencia = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_Exporta = New System.Windows.Forms.Button()
        Me.btn_exporta_pdf = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tp_busqueda.SuspendLayout()
        Me.panel_filtro.SuspendLayout()
        CType(Me.dgv_reporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tp_busqueda)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1273, 540)
        Me.TabControl1.TabIndex = 5
        '
        'tp_busqueda
        '
        Me.tp_busqueda.BackColor = System.Drawing.Color.White
        Me.tp_busqueda.Controls.Add(Me.cbo_clasificacion)
        Me.tp_busqueda.Controls.Add(Me.txtnom_esp)
        Me.tp_busqueda.Controls.Add(Me.txtcod_esp)
        Me.tp_busqueda.Controls.Add(Me.lbldesprogramado)
        Me.tp_busqueda.Controls.Add(Me.lblprogramado)
        Me.tp_busqueda.Controls.Add(Me.lbl_cantmedico)
        Me.tp_busqueda.Controls.Add(Me.Label23)
        Me.tp_busqueda.Controls.Add(Me.Label22)
        Me.tp_busqueda.Controls.Add(Me.Label21)
        Me.tp_busqueda.Controls.Add(Me.chk_lista_doctor)
        Me.tp_busqueda.Controls.Add(Me.panel_filtro)
        Me.tp_busqueda.Controls.Add(Me.Button2)
        Me.tp_busqueda.Controls.Add(Me.txtnom_doc)
        Me.tp_busqueda.Controls.Add(Me.lst_bus_distrito)
        Me.tp_busqueda.Controls.Add(Me.dgv_reporte)
        Me.tp_busqueda.Controls.Add(Me.DgvBusqueda)
        Me.tp_busqueda.Controls.Add(Me.chk_todos)
        Me.tp_busqueda.Controls.Add(Me.Label24)
        Me.tp_busqueda.Controls.Add(Me.Label19)
        Me.tp_busqueda.Controls.Add(Me.cbo_xturno)
        Me.tp_busqueda.Controls.Add(Me.cbo_flag)
        Me.tp_busqueda.Controls.Add(Me.Label7)
        Me.tp_busqueda.Controls.Add(Me.cbo_zona_bus)
        Me.tp_busqueda.Controls.Add(Me.Label6)
        Me.tp_busqueda.Controls.Add(Me.dtp_fecfin_asig_bus)
        Me.tp_busqueda.Controls.Add(Me.dtp_fecini_asig_bus)
        Me.tp_busqueda.Controls.Add(Me.textboxespecialidad)
        Me.tp_busqueda.Controls.Add(Me.Label18)
        Me.tp_busqueda.Controls.Add(Me.Label3)
        Me.tp_busqueda.Controls.Add(Me.btn_busqueda)
        Me.tp_busqueda.Location = New System.Drawing.Point(4, 22)
        Me.tp_busqueda.Name = "tp_busqueda"
        Me.tp_busqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_busqueda.Size = New System.Drawing.Size(1265, 514)
        Me.tp_busqueda.TabIndex = 1
        Me.tp_busqueda.Text = "Busqueda Disponibilidad"
        '
        'cbo_clasificacion
        '
        Me.cbo_clasificacion.FormattingEnabled = True
        Me.cbo_clasificacion.Items.AddRange(New Object() {"AGUDO", "CRONICO", "AUTO COVID", "TODOS", "NINGUNA"})
        Me.cbo_clasificacion.Location = New System.Drawing.Point(515, 56)
        Me.cbo_clasificacion.Name = "cbo_clasificacion"
        Me.cbo_clasificacion.Size = New System.Drawing.Size(96, 21)
        Me.cbo_clasificacion.TabIndex = 56
        Me.cbo_clasificacion.Tag = "[Seleccione turno]"
        Me.cbo_clasificacion.Text = "[---Seleccione clasificacion---]"
        '
        'txtnom_esp
        '
        Me.txtnom_esp.Location = New System.Drawing.Point(153, 29)
        Me.txtnom_esp.Name = "txtnom_esp"
        Me.txtnom_esp.Size = New System.Drawing.Size(128, 20)
        Me.txtnom_esp.TabIndex = 55
        Me.txtnom_esp.Visible = False
        '
        'txtcod_esp
        '
        Me.txtcod_esp.Location = New System.Drawing.Point(153, 6)
        Me.txtcod_esp.Name = "txtcod_esp"
        Me.txtcod_esp.Size = New System.Drawing.Size(128, 20)
        Me.txtcod_esp.TabIndex = 54
        Me.txtcod_esp.Visible = False
        '
        'lbldesprogramado
        '
        Me.lbldesprogramado.AutoSize = True
        Me.lbldesprogramado.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldesprogramado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbldesprogramado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesprogramado.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbldesprogramado.Location = New System.Drawing.Point(948, 84)
        Me.lbldesprogramado.Name = "lbldesprogramado"
        Me.lbldesprogramado.Size = New System.Drawing.Size(14, 15)
        Me.lbldesprogramado.TabIndex = 52
        Me.lbldesprogramado.Text = "0"
        Me.lbldesprogramado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbldesprogramado.Visible = False
        '
        'lblprogramado
        '
        Me.lblprogramado.AutoSize = True
        Me.lblprogramado.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblprogramado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblprogramado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogramado.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblprogramado.Location = New System.Drawing.Point(690, 85)
        Me.lblprogramado.Name = "lblprogramado"
        Me.lblprogramado.Size = New System.Drawing.Size(14, 15)
        Me.lblprogramado.TabIndex = 52
        Me.lblprogramado.Text = "0"
        Me.lblprogramado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblprogramado.Visible = False
        '
        'lbl_cantmedico
        '
        Me.lbl_cantmedico.BackColor = System.Drawing.Color.Black
        Me.lbl_cantmedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_cantmedico.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantmedico.ForeColor = System.Drawing.Color.White
        Me.lbl_cantmedico.Location = New System.Drawing.Point(553, 85)
        Me.lbl_cantmedico.Name = "lbl_cantmedico"
        Me.lbl_cantmedico.Size = New System.Drawing.Size(50, 15)
        Me.lbl_cantmedico.TabIndex = 52
        Me.lbl_cantmedico.Text = "0"
        Me.lbl_cantmedico.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(816, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(130, 16)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Pendientes x Programar:"
        Me.Label23.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(610, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 16)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Programados:"
        Me.Label22.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(443, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 17)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Cantidad Medicos:"
        '
        'chk_lista_doctor
        '
        Me.chk_lista_doctor.BackColor = System.Drawing.Color.White
        Me.chk_lista_doctor.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_lista_doctor.ForeColor = System.Drawing.Color.Black
        Me.chk_lista_doctor.FormattingEnabled = True
        Me.chk_lista_doctor.Items.AddRange(New Object() {"PEDIATRIA", "MEDICINA", "CARDIOLOGIA", "ENDOCRINOLOGIA", "NEUMOLOGIA", "NUTRICIONISTA", "ESPECIALISTA"})
        Me.chk_lista_doctor.Location = New System.Drawing.Point(3, 15)
        Me.chk_lista_doctor.Name = "chk_lista_doctor"
        Me.chk_lista_doctor.Size = New System.Drawing.Size(144, 89)
        Me.chk_lista_doctor.TabIndex = 50
        '
        'panel_filtro
        '
        Me.panel_filtro.Controls.Add(Me.Label20)
        Me.panel_filtro.Controls.Add(Me.cbo_detalle)
        Me.panel_filtro.Controls.Add(Me.btn_filtro)
        Me.panel_filtro.Controls.Add(Me.Label4)
        Me.panel_filtro.Controls.Add(Me.Label2)
        Me.panel_filtro.Location = New System.Drawing.Point(617, 1)
        Me.panel_filtro.Name = "panel_filtro"
        Me.panel_filtro.Size = New System.Drawing.Size(153, 60)
        Me.panel_filtro.TabIndex = 49
        Me.panel_filtro.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(17, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 14)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Seleccione el filtro"
        '
        'cbo_detalle
        '
        Me.cbo_detalle.FormattingEnabled = True
        Me.cbo_detalle.Items.AddRange(New Object() {"turno,zona,horini,fecini_asig", "turno,zona,horini", "fecha,turno,zona", "horini,fecha,turno"})
        Me.cbo_detalle.Location = New System.Drawing.Point(127, 31)
        Me.cbo_detalle.Name = "cbo_detalle"
        Me.cbo_detalle.Size = New System.Drawing.Size(196, 21)
        Me.cbo_detalle.TabIndex = 8
        '
        'btn_filtro
        '
        Me.btn_filtro.ForeColor = System.Drawing.Color.LimeGreen
        Me.btn_filtro.Image = Global.PM_PRESENTACION.My.Resources.Resources._16__Filter_2_
        Me.btn_filtro.Location = New System.Drawing.Point(329, 32)
        Me.btn_filtro.Name = "btn_filtro"
        Me.btn_filtro.Size = New System.Drawing.Size(63, 24)
        Me.btn_filtro.TabIndex = 5
        Me.btn_filtro.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(376, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "[X]"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Filtro de Busqueda"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Image = Global.PM_PRESENTACION.My.Resources.Resources.up2
        Me.Button2.Location = New System.Drawing.Point(992, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 26)
        Me.Button2.TabIndex = 48
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtnom_doc
        '
        Me.txtnom_doc.BackColor = System.Drawing.SystemColors.Info
        Me.txtnom_doc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom_doc.ForeColor = System.Drawing.Color.Black
        Me.txtnom_doc.Location = New System.Drawing.Point(816, 11)
        Me.txtnom_doc.Name = "txtnom_doc"
        Me.txtnom_doc.Size = New System.Drawing.Size(222, 23)
        Me.txtnom_doc.TabIndex = 47
        '
        'lst_bus_distrito
        '
        Me.lst_bus_distrito.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_bus_distrito.FormattingEnabled = True
        Me.lst_bus_distrito.Location = New System.Drawing.Point(297, 4)
        Me.lst_bus_distrito.Name = "lst_bus_distrito"
        Me.lst_bus_distrito.Size = New System.Drawing.Size(137, 95)
        Me.lst_bus_distrito.TabIndex = 46
        '
        'dgv_reporte
        '
        Me.dgv_reporte.AllowUserToAddRows = False
        Me.dgv_reporte.AllowUserToResizeRows = False
        Me.dgv_reporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_reporte.BackgroundColor = System.Drawing.Color.White
        Me.dgv_reporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_reporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_reporte.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_reporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_reporte.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_reporte.Location = New System.Drawing.Point(4, 105)
        Me.dgv_reporte.Name = "dgv_reporte"
        Me.dgv_reporte.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_reporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_reporte.RowHeadersWidth = 12
        Me.dgv_reporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_reporte.Size = New System.Drawing.Size(1252, 409)
        Me.dgv_reporte.TabIndex = 28
        Me.dgv_reporte.VirtualMode = True
        Me.dgv_reporte.Visible = False
        '
        'DgvBusqueda
        '
        Me.DgvBusqueda.AllowUserToAddRows = False
        Me.DgvBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvBusqueda.BackgroundColor = System.Drawing.Color.White
        Me.DgvBusqueda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvBusqueda.ColumnHeadersHeight = 40
        Me.DgvBusqueda.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBusqueda.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvBusqueda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DgvBusqueda.GridColor = System.Drawing.Color.Green
        Me.DgvBusqueda.Location = New System.Drawing.Point(7, 105)
        Me.DgvBusqueda.Name = "DgvBusqueda"
        Me.DgvBusqueda.ReadOnly = True
        Me.DgvBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBusqueda.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBusqueda.Size = New System.Drawing.Size(1255, 409)
        Me.DgvBusqueda.TabIndex = 45
        Me.DgvBusqueda.VirtualMode = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_todos.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_todos.Location = New System.Drawing.Point(237, 58)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(49, 17)
        Me.chk_todos.TabIndex = 43
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(440, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 20)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "Clasif"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(440, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 20)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "turno"
        '
        'cbo_xturno
        '
        Me.cbo_xturno.FormattingEnabled = True
        Me.cbo_xturno.Items.AddRange(New Object() {"MAÑANA", "TARDE", "MADRUGADA", "TODOS"})
        Me.cbo_xturno.Location = New System.Drawing.Point(484, 33)
        Me.cbo_xturno.Name = "cbo_xturno"
        Me.cbo_xturno.Size = New System.Drawing.Size(127, 21)
        Me.cbo_xturno.TabIndex = 41
        '
        'cbo_flag
        '
        Me.cbo_flag.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_flag.FormattingEnabled = True
        Me.cbo_flag.Items.AddRange(New Object() {"CONFIRMADO", "SIN CONFIRMAR", "REGISTRADO", "TODOS"})
        Me.cbo_flag.Location = New System.Drawing.Point(484, 9)
        Me.cbo_flag.Name = "cbo_flag"
        Me.cbo_flag.Size = New System.Drawing.Size(127, 22)
        Me.cbo_flag.TabIndex = 40
        Me.cbo_flag.Tag = ""
        Me.cbo_flag.Text = "[-- ESTADO --]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(439, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 14)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Estado"
        '
        'cbo_zona_bus
        '
        Me.cbo_zona_bus.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_zona_bus.FormattingEnabled = True
        Me.cbo_zona_bus.Items.AddRange(New Object() {"ZONA 01", "ZONA 02", "ZONA 03", "ZONA 04", "ZONA 05", "ZONA 06", "ZONA 07", "ZONA 08", "ZONA 09", "ZONA 10", "ZONA 11", "ZONA 12"})
        Me.cbo_zona_bus.Location = New System.Drawing.Point(155, 78)
        Me.cbo_zona_bus.Name = "cbo_zona_bus"
        Me.cbo_zona_bus.Size = New System.Drawing.Size(136, 22)
        Me.cbo_zona_bus.TabIndex = 38
        Me.cbo_zona_bus.Text = "[--- SUB ZONA ---]"
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(155, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Sub Zona"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtp_fecfin_asig_bus
        '
        Me.dtp_fecfin_asig_bus.Location = New System.Drawing.Point(653, 36)
        Me.dtp_fecfin_asig_bus.Name = "dtp_fecfin_asig_bus"
        Me.dtp_fecfin_asig_bus.Size = New System.Drawing.Size(148, 20)
        Me.dtp_fecfin_asig_bus.TabIndex = 33
        '
        'dtp_fecini_asig_bus
        '
        Me.dtp_fecini_asig_bus.Location = New System.Drawing.Point(653, 9)
        Me.dtp_fecini_asig_bus.Name = "dtp_fecini_asig_bus"
        Me.dtp_fecini_asig_bus.Size = New System.Drawing.Size(148, 20)
        Me.dtp_fecini_asig_bus.TabIndex = 33
        '
        'textboxespecialidad
        '
        Me.textboxespecialidad.AutoSize = True
        Me.textboxespecialidad.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxespecialidad.Location = New System.Drawing.Point(3, 2)
        Me.textboxespecialidad.Name = "textboxespecialidad"
        Me.textboxespecialidad.Size = New System.Drawing.Size(68, 14)
        Me.textboxespecialidad.TabIndex = 31
        Me.textboxespecialidad.Text = "Especialidad"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(614, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 37)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Fecha Final"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(614, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha Inicial"
        '
        'btn_busqueda
        '
        Me.btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_busqueda.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_busqueda.ForeColor = System.Drawing.Color.Black
        Me.btn_busqueda.Image = Global.PM_PRESENTACION.My.Resources.Resources.Busqueda
        Me.btn_busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_busqueda.Location = New System.Drawing.Point(816, 34)
        Me.btn_busqueda.Name = "btn_busqueda"
        Me.btn_busqueda.Size = New System.Drawing.Size(170, 26)
        Me.btn_busqueda.TabIndex = 37
        Me.btn_busqueda.Text = "Busqueda"
        Me.btn_busqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_busqueda.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(878, 559)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 30)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_incidencia
        '
        Me.btn_incidencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_incidencia.BackColor = System.Drawing.Color.White
        Me.btn_incidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_incidencia.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_incidencia.ForeColor = System.Drawing.Color.Navy
        Me.btn_incidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_incidencia.Location = New System.Drawing.Point(489, 558)
        Me.btn_incidencia.Name = "btn_incidencia"
        Me.btn_incidencia.Size = New System.Drawing.Size(114, 30)
        Me.btn_incidencia.TabIndex = 53
        Me.btn_incidencia.Text = "Registrar Incidencia"
        Me.btn_incidencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_incidencia.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(360, 558)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 30)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Seguimiento"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_quitar
        '
        Me.btn_quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_quitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_quitar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar.Image = Global.PM_PRESENTACION.My.Resources.Resources.quitar
        Me.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_quitar.Location = New System.Drawing.Point(136, 558)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(135, 30)
        Me.btn_quitar.TabIndex = 52
        Me.btn_quitar.Text = "&Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = False
        '
        'btn_Exporta
        '
        Me.btn_Exporta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exporta.BackColor = System.Drawing.Color.White
        Me.btn_Exporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exporta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exporta.ForeColor = System.Drawing.Color.Navy
        Me.btn_Exporta.Image = Global.PM_PRESENTACION.My.Resources.Resources._16__Doc_excel_
        Me.btn_Exporta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exporta.Location = New System.Drawing.Point(636, 558)
        Me.btn_Exporta.Name = "btn_Exporta"
        Me.btn_Exporta.Size = New System.Drawing.Size(113, 30)
        Me.btn_Exporta.TabIndex = 49
        Me.btn_Exporta.Text = "Exportar Excel"
        Me.btn_Exporta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exporta.UseVisualStyleBackColor = False
        '
        'btn_exporta_pdf
        '
        Me.btn_exporta_pdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_exporta_pdf.BackColor = System.Drawing.Color.White
        Me.btn_exporta_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exporta_pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exporta_pdf.ForeColor = System.Drawing.Color.Navy
        Me.btn_exporta_pdf.Image = Global.PM_PRESENTACION.My.Resources.Resources.icono_pdf
        Me.btn_exporta_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exporta_pdf.Location = New System.Drawing.Point(754, 559)
        Me.btn_exporta_pdf.Name = "btn_exporta_pdf"
        Me.btn_exporta_pdf.Size = New System.Drawing.Size(113, 30)
        Me.btn_exporta_pdf.TabIndex = 45
        Me.btn_exporta_pdf.Text = "Exportar PDF"
        Me.btn_exporta_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exporta_pdf.UseVisualStyleBackColor = False
        '
        'frmOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 598)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_incidencia)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Exporta)
        Me.Controls.Add(Me.btn_exporta_pdf)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmOperador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programacion médica"
        Me.TabControl1.ResumeLayout(False)
        Me.tp_busqueda.ResumeLayout(False)
        Me.tp_busqueda.PerformLayout()
        Me.panel_filtro.ResumeLayout(False)
        Me.panel_filtro.PerformLayout()
        CType(Me.dgv_reporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tp_busqueda As System.Windows.Forms.TabPage
    Friend WithEvents cbo_clasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents txtnom_esp As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_esp As System.Windows.Forms.TextBox
    Friend WithEvents lbldesprogramado As System.Windows.Forms.Label
    Friend WithEvents lblprogramado As System.Windows.Forms.Label
    Friend WithEvents lbl_cantmedico As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chk_lista_doctor As System.Windows.Forms.CheckedListBox
    Friend WithEvents panel_filtro As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbo_detalle As System.Windows.Forms.ComboBox
    Friend WithEvents btn_filtro As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtnom_doc As System.Windows.Forms.TextBox
    Friend WithEvents lst_bus_distrito As System.Windows.Forms.ListBox
    Public WithEvents dgv_reporte As System.Windows.Forms.DataGridView
    Public WithEvents DgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbo_xturno As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_flag As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo_zona_bus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecfin_asig_bus As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecini_asig_bus As System.Windows.Forms.DateTimePicker
    Friend WithEvents textboxespecialidad As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_busqueda As System.Windows.Forms.Button
    Friend WithEvents btn_exporta_pdf As System.Windows.Forms.Button
    Friend WithEvents btn_Exporta As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_incidencia As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
