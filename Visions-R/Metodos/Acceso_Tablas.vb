Public Class Acceso_Tablas

    Public Shared Function Validar(ByVal tabla As String) As String
        Try
            Dim conexion_tablas As Conexion_Tablas = New Conexion_Tablas()

            Dim dt As DataTable = Conexion_Tablas.Consultar

            For Each MiDataRow As DataRow In dt.Rows
                If MiDataRow("tabla").ToLower = tabla.ToLower Then
                    Return MiDataRow("conexion").ToLower
                End If
            Next
            Return "db_servidor"
        Catch ex As Exception
            Logger.Registro("Acceso_Tablas", "Validar", ex.ToString)
            Return "db_servidor"
        End Try
    End Function

End Class
