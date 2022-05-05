Public Class Configuracion


    Public Class Rootobject
        Public Property db_visions As Db_Visions
        Public Property app_settings As App_Settings
    End Class

    Public Class Db_Visions
        Public Property server_name As String
        Public Property database_name As String
        Public Property user_name As String
        Public Property password As String
    End Class

    Public Class App_Settings
        Public Property logger As Logger
    End Class

    Public Class Logger
        Public Property status As Boolean
        Public Property path As String
    End Class


End Class
