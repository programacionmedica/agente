<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ingreso_ambulancia
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbo_turno = New System.Windows.Forms.ComboBox()
        Me.dtp_HoraIni_Doc = New System.Windows.Forms.DateTimePicker()
        Me.dtp_HoraFin_Doc = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdpfec_asignacion = New System.Windows.Forms.DateTimePicker()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbo_turno
        '
        Me.cbo_turno.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_turno.ForeColor = System.Drawing.Color.Black
        Me.cbo_turno.FormattingEnabled = True
        Me.cbo_turno.Items.AddRange(New Object() {"MAÑANA", "TARDE", "MADRUGADA"})
        Me.cbo_turno.Location = New System.Drawing.Point(84, 44)
        Me.cbo_turno.Name = "cbo_turno"
        Me.cbo_turno.Size = New System.Drawing.Size(183, 22)
        Me.cbo_turno.TabIndex = 4
        Me.cbo_turno.Tag = "[Seleccione turno]"
        Me.cbo_turno.Text = "[---Seleccione Turno---]"
        '
        'dtp_HoraIni_Doc
        '
        Me.dtp_HoraIni_Doc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraIni_Doc.CustomFormat = "HH:mm"
        Me.dtp_HoraIni_Doc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraIni_Doc.Location = New System.Drawing.Point(54, 14)
        Me.dtp_HoraIni_Doc.Name = "dtp_HoraIni_Doc"
        Me.dtp_HoraIni_Doc.ShowUpDown = True
        Me.dtp_HoraIni_Doc.Size = New System.Drawing.Size(55, 20)
        Me.dtp_HoraIni_Doc.TabIndex = 26
        Me.dtp_HoraIni_Doc.Value = New Date(2013, 6, 3, 6, 0, 0, 0)
        '
        'dtp_HoraFin_Doc
        '
        Me.dtp_HoraFin_Doc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraFin_Doc.CustomFormat = "HH:mm"
        Me.dtp_HoraFin_Doc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_HoraFin_Doc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraFin_Doc.Location = New System.Drawing.Point(55, 38)
        Me.dtp_HoraFin_Doc.Name = "dtp_HoraFin_Doc"
        Me.dtp_HoraFin_Doc.ShowUpDown = True
        Me.dtp_HoraFin_Doc.Size = New System.Drawing.Size(55, 20)
        Me.dtp_HoraFin_Doc.TabIndex = 23
        Me.dtp_HoraFin_Doc.Value = New Date(2013, 6, 3, 15, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 14)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Fin"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 14)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Inicio"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(424, 12)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(35, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Turno"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_HoraFin_Doc)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtp_HoraIni_Doc)
        Me.GroupBox1.Location = New System.Drawing.Point(273, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 69)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Días"
        '
        'tdpfec_asignacion
        '
        Me.tdpfec_asignacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tdpfec_asignacion.Location = New System.Drawing.Point(84, 14)
        Me.tdpfec_asignacion.Name = "tdpfec_asignacion"
        Me.tdpfec_asignacion.Size = New System.Drawing.Size(183, 20)
        Me.tdpfec_asignacion.TabIndex = 32
        '
        'txtobs
        '
        Me.txtobs.Location = New System.Drawing.Point(84, 140)
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(375, 20)
        Me.txtobs.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Obs:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Proveedor"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 22)
        Me.ComboBox1.TabIndex = 35
        Me.ComboBox1.Tag = "[Seleccione turno]"
        '
        'frm_ingreso_ambulancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 208)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtobs)
        Me.Controls.Add(Me.tdpfec_asignacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbo_turno)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_ingreso_ambulancia"
        Me.Text = "Ingreso ambulancia"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbo_turno As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_HoraIni_Doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_HoraFin_Doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tdpfec_asignacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtobs As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
