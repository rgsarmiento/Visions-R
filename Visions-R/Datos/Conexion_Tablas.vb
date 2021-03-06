Imports System.Data.SqlClient

Public Class Conexion_Tablas


#Region "Buscar la relacion de tablas y sus conexiones de datos"
    Public Shared Function Consultar() As DataTable
        Try
            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, conexion, tabla 
                                    FROM conexion_tablas"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()
            Return dt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region


End Class
