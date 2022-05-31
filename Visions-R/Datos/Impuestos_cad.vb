Imports System.Data.SqlClient

Public Class Impuestos_cad

#Region "Listas de seleccion de impuestos"

    Public Shared Function Listar() As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT impuestos.id, impuestos.nombre, impuestos.porcentaje, impuestos.conversion, impuestos.id_tipo_impuesto, tipo_impuestos.nombre AS tipo_inpuesto, tipo_impuestos.codigo
                                    FROM impuestos INNER JOIN
                                    tipo_impuestos ON impuestos.id_tipo_impuesto = tipo_impuestos.id
                                    WHERE (impuestos.estado = 1)"

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
            Logger.Registro("Impuestos_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region

End Class
