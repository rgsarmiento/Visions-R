Imports System.IO

Public Class Logger

    Public Shared Sub Registro(clase As String, funcion As String, mensaje As String)
        If Deploy_parameters.modelo_configuraciones.app_settings.logger.status Then
            Dim logger = Deploy_parameters.modelo_configuraciones.app_settings.logger.path
            Using writer As StreamWriter = New StreamWriter(logger, True)
                writer.WriteLine("")
                writer.WriteLine($"{DateTime.Now } clase: ### {clase}>{funcion} ###")
                writer.WriteLine($"> {mensaje}")
            End Using
        End If

    End Sub

End Class
