Imports System.IO
Imports Newtonsoft.Json

Public Class Deploy_parameters

    Public Shared r As StreamReader = New StreamReader(Variables.ruta_raiz & "/deploy.parameters.json")
    Public Shared jsonString As String = r.ReadToEnd()

    Public Shared Function modelo_configuraciones() As Configuracion.Rootobject
        Dim configuraciones As Configuracion.Rootobject = JsonConvert.DeserializeObject(Of Configuracion.Rootobject)(jsonString)
        Return configuraciones
    End Function


End Class
