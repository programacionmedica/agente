<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_seguimiento
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
        Me.dgv_seguimiento = New System.Windows.Forms.DataGridView()
        Me.lblcod_Asig = New System.Windows.Forms.Label()
        CType(Me.dgv_seguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_seguimiento
        '
        Me.dgv_seguimiento.AllowUserToAddRows = False
        Me.dgv_seguimiento.AllowUserToDeleteRows = False
        Me.dgv_seguimiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_seguimiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_seguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_seguimiento.Location = New System.Drawing.Point(3, 3)
        Me.dgv_seguimiento.Name = "dgv_seguimiento"
        Me.dgv_seguimiento.ReadOnly = True
        Me.dgv_seguimiento.RowHeadersVisible = False
        Me.dgv_seguimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_seguimiento.Size = New System.Drawing.Size(997, 431)
        Me.dgv_seguimiento.TabIndex = 0
        '
        'lblcod_Asig
        '
        Me.lblcod_Asig.AutoSize = True
        Me.lblcod_Asig.Location = New System.Drawing.Point(382, 5)
        Me.lblcod_Asig.Name = "lblcod_Asig"
        Me.lblcod_Asig.Size = New System.Drawing.Size(0, 13)
        Me.lblcod_Asig.TabIndex = 1
        Me.lblcod_Asig.Visible = False
        '
        'frm_seguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 439)
        Me.Controls.Add(Me.lblcod_Asig)
        Me.Controls.Add(Me.dgv_seguimiento)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1019, 478)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1019, 478)
        Me.Name = "frm_seguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento"
        CType(Me.dgv_seguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_seguimiento As System.Windows.Forms.DataGridView
    Friend WithEvents lblcod_Asig As System.Windows.Forms.Label
End Class
