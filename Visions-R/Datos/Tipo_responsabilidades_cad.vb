Imports System.Data.SqlClient

Public Class Tipo_responsabilidades_cad

    'Public Sub New()
    '    'Obtener la conexion segun la relacion en conexion_tablas
    '    Variables.conexion_acceso = Acceso_Tablas.Validar("tipo_responsabilidades")
    'End Sub

#Region "Listas de seleccion de tipo_responsabilidades"

    Public Shared Function Listar() As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, nombre + ' (' + codigo + ')' AS nombre
                                   FROM tipo_responsabilidades
                                   WHERE (estado = 1)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            Dim fila As DataRow = dt.NewRow()
            fila("id") = 0
            fila("nombre") = "Selccione tipo responsabilidad ►"
            dt.Rows.InsertAt(fila, 0)
            Return dt

        Catch ex As Exception
            Logger.Registro("Tipo_responsabilidades_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region


End Class
