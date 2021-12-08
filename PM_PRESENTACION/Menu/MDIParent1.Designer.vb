<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MNUPRINCIPAL
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionDeEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeIncidenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblusu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblversiones = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.MediumAquamarine
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.AsignacionDeEquiposToolStripMenuItem, Me.FileMenu, Me.ToolsMenu, Me.ReporteDeIncidenciaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1028, 41)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabletToolStripMenuItem, Me.MposToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(105, 37)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'TabletToolStripMenuItem
        '
        Me.TabletToolStripMenuItem.Name = "TabletToolStripMenuItem"
        Me.TabletToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.TabletToolStripMenuItem.Text = "Tablet"
        '
        'MposToolStripMenuItem
        '
        Me.MposToolStripMenuItem.Name = "MposToolStripMenuItem"
        Me.MposToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.MposToolStripMenuItem.Text = "Mpos"
        '
        'AsignacionDeEquiposToolStripMenuItem
        '
        Me.AsignacionDeEquiposToolStripMenuItem.Name = "AsignacionDeEquiposToolStripMenuItem"
        Me.AsignacionDeEquiposToolStripMenuItem.Size = New System.Drawing.Size(141, 37)
        Me.AsignacionDeEquiposToolStripMenuItem.Text = "Asignacion de equipos"
        '
        'FileMenu
        '
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(173, 37)
        Me.FileMenu.Text = "Asignación de disponibilidad"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(151, 37)
        Me.ToolsMenu.Text = "&Busqueda disponibilidad"
        '
        'ReporteDeIncidenciaToolStripMenuItem
        '
        Me.ReporteDeIncidenciaToolStripMenuItem.Name = "ReporteDeIncidenciaToolStripMenuItem"
        Me.ReporteDeIncidenciaToolStripMenuItem.Size = New System.Drawing.Size(140, 37)
        Me.ReporteDeIncidenciaToolStripMenuItem.Text = "Reporte de incidencia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(43, 37)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblusu, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblversiones, Me.ToolStripStatusLabel4, Me.LBLIP})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 507)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 17)
        Me.ToolStripStatusLabel1.Text = "USUARIO:"
        '
        'lblusu
        '
        Me.lblusu.Name = "lblusu"
        Me.lblusu.Size = New System.Drawing.Size(29, 17)
        Me.lblusu.Text = "user"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel2.Text = "  Versión:"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 17)
        '
        'lblversiones
        '
        Me.lblversiones.Name = "lblversiones"
        Me.lblversiones.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel4.Text = "    IP:"
        '
        'LBLIP
        '
        Me.LBLIP.Name = "LBLIP"
        Me.LBLIP.Size = New System.Drawing.Size(0, 17)
        '
        'MNUPRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 529)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MNUPRINCIPAL"
        Me.Text = "MENU PRINCIPAL - MODULO HORARIO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblusu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblversiones As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeIncidenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LBLIP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignacionDeEquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
