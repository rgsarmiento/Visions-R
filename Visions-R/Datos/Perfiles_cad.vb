Imports System.Data.SqlClient

Public Class Perfiles_cad

    Public Sub New()
        Variables.conexion_acceso = Acceso_Tablas.Validar("perfiles")
    End Sub

#Region "Listas de seleccion de perfiles"

    Public Shared Function Listar() As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, nombre FROM perfiles WHERE (estado = 1)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()
            Return dt

        Catch ex As Exception
            Logger.Registro("Perfiles_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region

End Class
