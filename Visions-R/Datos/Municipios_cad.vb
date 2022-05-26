Imports System.Data.SqlClient

Public Class Municipios_cad

#Region "Listas de seleccion de municipios"

    Public Shared Function Listar(id_departamento As Integer) As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, nombre + ' (' + codigo + ')' AS nombre
                                   FROM municipios
                                   WHERE (estado = 1) AND (id_departamento = @id_departamento)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)
            comando.Parameters.AddWithValue("@id_departamento", id_departamento)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            Dim fila As DataRow = dt.NewRow()
            fila("id") = 0
            fila("nombre") = "Selccione ▼"
            dt.Rows.InsertAt(fila, 0)
            Return dt

        Catch ex As Exception
            Logger.Registro("Municipios_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region
End Class
