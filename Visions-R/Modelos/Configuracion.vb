Public Class Configuracion


    Public Class Rootobject
        Public Property db_servidor As Db_Servidor
        Public Property app_settings As App_Settings
    End Class

    Public Class Db_Servidor
        Public Property description As String
        Public Property server_name As String
        Public Property database_name As String
        Public Property user_name As String
        Public Property password As String
    End Class

    Public Class App_Settings
        Public Property db_servidor_documentos As Db_Servidor_Documentos
        Public Property db_servidor_cuentas As Db_Servidor_Cuentas
        Public Property logger As Logger
    End Class

    Public Class Db_Servidor_Documentos
        Public Property description As String
        Public Property server_name As String
        Public Property database_name As String
        Public Property user_name As String
        Public Property password As String
    End Class

    Public Class Db_Servidor_Cuentas
        Public Property description As String
        Public Property server_name As String
        Public Property database_name As String
        Public Property user_name As String
        Public Property password As String
    End Class

    Public Class Logger
        Public Property description As String
        Public Property status As Boolean
        Public Property path As String
    End Class


End Class
