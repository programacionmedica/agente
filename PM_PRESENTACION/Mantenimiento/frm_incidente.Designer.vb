<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_incidente
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtid_combo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_tipo_incidencia = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtnom_med = New System.Windows.Forms.TextBox()
        Me.txtnom_cond = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcod_doc = New System.Windows.Forms.TextBox()
        Me.txtcod_mot = New System.Windows.Forms.TextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 35)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Doctor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(327, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Conductor"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtid_combo
        '
        Me.txtid_combo.Enabled = False
        Me.txtid_combo.Location = New System.Drawing.Point(67, 7)
        Me.txtid_combo.Name = "txtid_combo"
        Me.txtid_combo.Size = New System.Drawing.Size(91, 20)
        Me.txtid_combo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id Combo:"
        '
        'cbo_tipo_incidencia
        '
        Me.cbo_tipo_incidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_incidencia.FormattingEnabled = True
        Me.cbo_tipo_incidencia.Location = New System.Drawing.Point(198, 87)
        Me.cbo_tipo_incidencia.Name = "cbo_tipo_incidencia"
        Me.cbo_tipo_incidencia.Size = New System.Drawing.Size(309, 21)
        Me.cbo_tipo_incidencia.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 119)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(617, 69)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(650, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtnom_med
        '
        Me.txtnom_med.Enabled = False
        Me.txtnom_med.Location = New System.Drawing.Point(8, 58)
        Me.txtnom_med.Name = "txtnom_med"
        Me.txtnom_med.Size = New System.Drawing.Size(301, 20)
        Me.txtnom_med.TabIndex = 8
        '
        'txtnom_cond
        '
        Me.txtnom_cond.Enabled = False
        Me.txtnom_cond.Location = New System.Drawing.Point(324, 58)
        Me.txtnom_cond.Name = "txtnom_cond"
        Me.txtnom_cond.Size = New System.Drawing.Size(301, 20)
        Me.txtnom_cond.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipo de incidente:"
        '
        'txtcod_doc
        '
        Me.txtcod_doc.Location = New System.Drawing.Point(12, 201)
        Me.txtcod_doc.Name = "txtcod_doc"
        Me.txtcod_doc.Size = New System.Drawing.Size(61, 20)
        Me.txtcod_doc.TabIndex = 11
        '
        'txtcod_mot
        '
        Me.txtcod_mot.Location = New System.Drawing.Point(79, 201)
        Me.txtcod_mot.Name = "txtcod_mot"
        Me.txtcod_mot.Size = New System.Drawing.Size(82, 20)
        Me.txtcod_mot.TabIndex = 12
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(503, 195)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(0, 13)
        Me.lblusuario.TabIndex = 14
        '
        'frm_incidente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(736, 314)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.txtcod_mot)
        Me.Controls.Add(Me.txtcod_doc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnom_cond)
        Me.Controls.Add(Me.txtnom_med)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.cbo_tipo_incidencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtid_combo)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_incidente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Incidente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtid_combo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_incidencia As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtnom_med As System.Windows.Forms.TextBox
    Friend WithEvents txtnom_cond As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcod_doc As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_mot As System.Windows.Forms.TextBox
    Friend WithEvents lblusuario As System.Windows.Forms.Label
End Class
