Public Class Variables

    Public Shared ruta_raiz As String = AppDomain.CurrentDomain.BaseDirectory
    Public Shared conexion_acceso As String = ""


    Public Shared costo_con_iva As Integer = 0
    Public Shared precio_x_seleccion As Boolean = False
    Public Shared id_precio_seleccionado As Integer = 0


#Region "colores de la aplicacion"
    Public Shared Function color_cbx_r() As Integer
        Return Deploy_parameters.modelo_configuraciones.app_style.selection_lists.red
    End Function
    Public Shared Function color_cbx_g() As Integer
        Return Deploy_parameters.modelo_configuraciones.app_style.selection_lists.green
    End Function
    Public Shared Function color_cbx_b() As Integer
        Return Deploy_parameters.modelo_configuraciones.app_style.selection_lists.blue
    End Function

    Public Shared Function color_form_r() As Integer
        Return Deploy_parameters.modelo_configuraciones.app_style.form.red
    End Function
    Public Shared Function color_form_g() As Integer
        Return Deploy_parameters.modelo_configuraciones.app_style.form.green
    End Function
    Public Shared Function color_form_b() As Integer
        Return Deploy_parameters.modelo_configuraciones.app_style.form.blue
    End Function
#End Region



End Class
