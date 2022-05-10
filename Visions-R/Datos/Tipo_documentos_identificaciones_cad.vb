Imports System.Data.SqlClient

Public Class Tipo_documentos_identificaciones_cad
    '    Public Sub New()
    '        Variables.conexion_acceso = Acceso_Tablas.Validar("tipo_documentos_identificaciones")
    '    End Sub

#Region "Listas de seleccion de tipo_regimenes"

    Public Shared Function Listar() As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, nombre + ' (' + CONVERT(varchar(10), codigo) + ')' AS nombre
                                   FROM tipo_documentos_identificaciones
                                   WHERE (estado = 1)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            Dim fila As DataRow = dt.NewRow()
            fila("id") = 0
            fila("nombre") = "Selccione tipo documento ►"
            dt.Rows.InsertAt(fila, 0)
            Return dt

        Catch ex As Exception
            Logger.Registro("Tipo_documentos_identificaciones_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region

End Class
