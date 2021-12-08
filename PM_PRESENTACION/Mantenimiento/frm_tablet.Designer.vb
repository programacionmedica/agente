<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tablet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tablet))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtareaasig = New System.Windows.Forms.TextBox()
        Me.fecha_entrega = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTMODELO = New System.Windows.Forms.TextBox()
        Me.txtimeitab = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbmarcatab = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(291, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 26)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "FECHA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ENTREGA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(291, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "ASIGNADA A:"
        '
        'txtareaasig
        '
        Me.txtareaasig.Enabled = False
        Me.txtareaasig.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtareaasig.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtareaasig.Location = New System.Drawing.Point(405, 60)
        Me.txtareaasig.Name = "txtareaasig"
        Me.txtareaasig.Size = New System.Drawing.Size(150, 21)
        Me.txtareaasig.TabIndex = 39
        '
        'fecha_entrega
        '
        Me.fecha_entrega.Enabled = False
        Me.fecha_entrega.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_entrega.ForeColor = System.Drawing.Color.DarkGreen
        Me.fecha_entrega.Location = New System.Drawing.Point(406, 33)
        Me.fecha_entrega.Name = "fecha_entrega"
        Me.fecha_entrega.Size = New System.Drawing.Size(149, 21)
        Me.fecha_entrega.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "MODELO :"
        '
        'TXTMODELO
        '
        Me.TXTMODELO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMODELO.ForeColor = System.Drawing.Color.DarkGreen
        Me.TXTMODELO.Location = New System.Drawing.Point(122, 57)
        Me.TXTMODELO.Name = "TXTMODELO"
        Me.TXTMODELO.Size = New System.Drawing.Size(150, 21)
        Me.TXTMODELO.TabIndex = 36
        '
        'txtimeitab
        '
        Me.txtimeitab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimeitab.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtimeitab.Location = New System.Drawing.Point(122, 30)
        Me.txtimeitab.Name = "txtimeitab"
        Me.txtimeitab.Size = New System.Drawing.Size(150, 21)
        Me.txtimeitab.TabIndex = 35
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.ForeColor = System.Drawing.Color.Red
        Me.txtcodigo.Location = New System.Drawing.Point(122, 5)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(150, 21)
        Me.txtcodigo.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "IMEI-TABLET:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "CODIGO:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(291, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "MARCA :"
        '
        'cmbmarcatab
        '
        Me.cmbmarcatab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmarcatab.FormattingEnabled = True
        Me.cmbmarcatab.Items.AddRange(New Object() {"SONY", "SAMSUNG"})
        Me.cmbmarcatab.Location = New System.Drawing.Point(405, 6)
        Me.cmbmarcatab.Name = "cmbmarcatab"
        Me.cmbmarcatab.Size = New System.Drawing.Size(150, 21)
        Me.cmbmarcatab.TabIndex = 42
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(587, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 31)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(587, 41)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(65, 62)
        Me.Button8.TabIndex = 46
        Me.Button8.Text = "Exportar"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(16, 108)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(636, 223)
        Me.GridControl1.TabIndex = 47
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'frm_tablet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 439)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbmarcatab)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtareaasig)
        Me.Controls.Add(Me.fecha_entrega)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTMODELO)
        Me.Controls.Add(Me.txtimeitab)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_tablet"
        Me.Text = "Mantenimiento Tablet"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtareaasig As System.Windows.Forms.TextBox
    Friend WithEvents fecha_entrega As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTMODELO As System.Windows.Forms.TextBox
    Friend WithEvents txtimeitab As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbmarcatab As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
