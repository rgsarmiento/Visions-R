Imports System.Data.SqlClient

Public Class Departamentos_cad

#Region "Listas de seleccion de departamentos"

    Public Shared Function Listar(id_pais As Integer) As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, nombre + ' (' + codigo + ')' AS nombre
                                   FROM departamentos
                                   WHERE (estado = 1) AND (id_pais = @id_pais)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)
            comando.Parameters.AddWithValue("@id_pais", id_pais)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            Dim fila As DataRow = dt.NewRow()
            fila("id") = 0
            fila("nombre") = "Selccione un departamento ►"
            dt.Rows.InsertAt(fila, 0)
            Return dt

        Catch ex As Exception
            Logger.Registro("Departamentos_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region

End Class
