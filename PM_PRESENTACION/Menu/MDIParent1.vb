Imports System.Windows.Forms

Public Class MNUPRINCIPAL
    Public miip$
    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Cree una nueva instancia del formulario secundario.
    '    'Dim ChildForm As New System.Windows.Forms.Form
    '    '' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
    '    '.MdiParent = Me

    '    'm_ChildFormNumber += 1
    '    'ChildForm.Text = "Ventana " & m_ChildFormNumber

    '    'ChildForm.Show()
    '    Frm_Ingreso.lbluser.Text = lblusu.Text
    '    Frm_Ingreso.Show()
    '    Frm_Ingreso.MdiParent = Me
    'End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
        Frm_ManteTurnos.Show()
        Frm_ManteTurnos.MdiParent = Me
        'Frm_ManteTurnos.Show()
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MNUPRINCIPAL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

  

    Private Sub MNUPRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblversiones.Text = My.Application.Info.Version.ToString()
        Me.Text = Me.Text & "   Versión: " & My.Application.Info.Version.ToString()
        Frm_Ingreso.lbluser.Text = lblusu.Text
        Dim ip As System.Net.IPHostEntry
        ip = System.Net.Dns.GetHostEntry(My.Computer.Name)
        ObtenerDatos()
        LBLIP.Text = miip
    End Sub

    Public Sub ObtenerDatos()
        Dim nombreHost As String = System.Net.Dns.GetHostName
        Dim hostInfo As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(nombreHost)
        Dim val$
        val = hostInfo.HostName.ToString
        For Each ip As System.Net.IPAddress In hostInfo.AddressList
            miip = (ip.ToString)
        Next
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub


    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu.Click
        Frm_Ingreso.Show()
        Frm_Ingreso.MdiParent = Me
        Frm_Ingreso.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ToolsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenu.Click
        'INI_SESSION = 1
        frmOperador.Show()
        frmOperador.MdiParent = Me
        frmOperador.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ReporteDeIncidenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeIncidenciaToolStripMenuItem.Click

        frm_rep_incidencia.MdiParent = Me
        frm_rep_incidencia.WindowState = FormWindowState.Maximized
        frm_rep_incidencia.Show()
    End Sub

    Private Sub TabletToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TabletToolStripMenuItem.Click
        'frm_tablet.MdiParent = Me
        'frm_tablet.WindowState = FormWindowState.Maximized
        'frm_tablet.Show()
    End Sub

    Private Sub MposToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MposToolStripMenuItem.Click
        'frm_mpos.MdiParent = Me
        'frm_mpos.WindowState = FormWindowState.Maximized
        'frm_mpos.Show()
    End Sub

    Private Sub AsignacionDeEquiposToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignacionDeEquiposToolStripMenuItem.Click

    End Sub
End Class
