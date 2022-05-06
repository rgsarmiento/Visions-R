Imports System.Runtime.InteropServices

Public Class Seguridad_frm
#Region "para mover formulario desde el panel titulo"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panel_titulo_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_titulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
#End Region


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Me.lb_proceso.Text = "⌛ Guardando datos"
        lb_proceso.Refresh()

        Dim obj_seguridad As Seguridad_modelo = New Seguridad_modelo()

        obj_seguridad.Clave = "8911"
        obj_seguridad.nombre_usuario = "robert"
        obj_seguridad.id_usuario = 1
        obj_seguridad.id_perfil = 1
        obj_seguridad.estado = 1

        Dim Seguridad_cad As Seguridad_cad = New Seguridad_cad()

        If Seguridad_cad.Guardar(obj_seguridad) Then

        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
        lb_proceso.Text = "✎ Gestionar Seguridad"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Usuarios_frm As New Usuarios_frm
        Usuarios_frm.ShowDialog()
    End Sub






End Class
