Imports System.Data.SqlClient

Public Class Paises_cad

#Region "Listas de seleccion de paises"

    Public Shared Function Listar() As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, nombre + ' (' + codigo + ')' AS nombre
                                   FROM paises
                                   WHERE (estado = 1)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            'Dim fila As DataRow = dt.NewRow()
            'fila("id") = 0
            'fila("nombre") = "Selccione un pais ►"
            'dt.Rows.InsertAt(fila, 0)
            Return dt

        Catch ex As Exception
            Logger.Registro("Paises_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region

End Class
