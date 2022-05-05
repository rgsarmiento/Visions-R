Public Class Form1


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim obj_seguridad As Modelo_Seguridad = New Modelo_Seguridad()

        obj_seguridad.Clave = "8911"
        obj_seguridad.Codigo = "robert"
        obj_seguridad.Nombre = "robert sarmiento"
        obj_seguridad.Nit = "1110491530"
        obj_seguridad.Perfil = "SEGURIDAD"

        If Seguridad_cad.guardar(obj_seguridad) Then
            Logger.Registro("Registro", "form1-btn_guardar_Click")
        End If

    End Sub
End Class
