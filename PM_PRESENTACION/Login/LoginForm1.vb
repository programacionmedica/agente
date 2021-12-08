Imports DLL_VERSION
Imports DLL_NEGOCIO
Public Class LoginForm1
    Dim obj As New DLL_NEGOCIO.DLL_PROCEDURE
    Dim PERMISO As Integer
    Dim PRO As New PM_PRESENTACION.cls
#Region "Metodos"
    Public Function extraer_datos() As Integer
        Dim valor As Integer
        Dim datos As New DataTable
        Dim datos1 As New DataTable
        datos = DLL_NEGOCIO.DLL_PROCEDURE.valida_acceso(Trim(UsernameTextBox.Text), Trim(PasswordTextBox.Text))
        Try

      
        If datos.Rows.Count > 0 Then
            If Trim(datos.Rows(0)(0).ToString) = Trim(UsernameTextBox.Text) And Trim(datos.Rows(0)(1).ToString) = Trim(PasswordTextBox.Text) Then

                datos1 = DLL_NEGOCIO.DLL_PROCEDURE.valida_permiso(Trim(UsernameTextBox.Text))

                valor = datos1.Rows.Item(0)(0)

            End If


        Else
            valor = False
            End If
        Catch ex As Exception
            valor = 0
        End Try

        Return valor
    End Function
    Sub limpiar()
        Me.UsernameTextBox.Text = ""
        Me.PasswordTextBox.Text = ""
    End Sub
#End Region


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cls_Utilitarios.F_ObtenerUsuarioRed()
        lblversion.Text = "Versión: " & My.Application.Info.Version.ToString()
        'UsernameTextBox.Text = (Cls_Utilitarios.F_ObtenerUsuarioRed)
    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True

            VALIDAR_ACCESO()
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        INI_SESSION = 2
        frmOperador.Show()
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        VALIDAR_ACCESO()
        'PRO.S_ExportarDataGridViewExcel(frmOperador.dgv_reporte, "D:\ED.XLS")

    End Sub
    Sub VALIDAR_ACCESO()
        Frm_Ingreso.btnambulancia.Enabled = False

        MNUPRINCIPAL.MantenimientoToolStripMenuItem.Enabled = False
        MNUPRINCIPAL.AsignacionDeEquiposToolStripMenuItem.Enabled = False


        PERMISO = extraer_datos()
        If PERMISO = 95 Then
            DLL_PROCEDURE.usuario = Trim(Me.UsernameTextBox.Text)
            MNUPRINCIPAL.Show() : MNUPRINCIPAL.lblusu.Text = UsernameTextBox.Text.ToUpper
            MNUPRINCIPAL.FileMenu.Enabled = True
            Frm_Ingreso.lbluser.Text = MNUPRINCIPAL.lblusu.Text
            Me.Hide()
            INI_SESSION = 1
            If Frm_Ingreso.lbluser.Text = "MVALDERRAMA" Then
                Frm_Ingreso.btnambulancia.Enabled = True

            End If
        ElseIf PERMISO = 102 Then

            DLL_PROCEDURE.usuario = Trim(Me.UsernameTextBox.Text)
            MNUPRINCIPAL.Show() : MNUPRINCIPAL.lblusu.Text = UsernameTextBox.Text.ToUpper
            Frm_Ingreso.lbluser.Text = MNUPRINCIPAL.lblusu.Text
            MNUPRINCIPAL.FileMenu.Enabled = False

            Me.Hide()
            INI_SESSION = 3
        ElseIf PERMISO = 0 Then
            MessageBox.Show("USUARIO INCORRECTO O NO TIENE PERMISO", "SISTEMA HORARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            limpiar()
            Me.UsernameTextBox.Focus()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class


