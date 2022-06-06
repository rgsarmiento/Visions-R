Imports System.Data.SqlClient

Public Class Condiciones_cad


#Region "Listas de seleccion de condiciones"

    Public Shared Function Listar(tabla As String) As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = $"SELECT id, nombre
                                    FROM condiciones
                                    WHERE (estado = 1) AND (tabla = '{tabla}')"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            Dim fila As DataRow = dt.NewRow()
            fila("id") = 0
            fila("nombre") = "Selccione ▼"
            dt.Rows.InsertAt(fila, 0)
            Return dt

        Catch ex As Exception
            Logger.Registro("Condiciones_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region

End Class
