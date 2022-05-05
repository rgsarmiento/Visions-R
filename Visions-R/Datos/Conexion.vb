Imports System.Data.SqlClient
Imports System.IO
Imports Newtonsoft.Json

Public Class Conexion

    Dim con As SqlConnection

    Public Sub New()


        Dim db_visions = Deploy_parameters.modelo_configuraciones.db_visions

        Dim str_con As String = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", db_visions.server_name, db_visions.database_name, db_visions.user_name, db_visions.password)

        con = New SqlConnection(str_con)
    End Sub

    Public Function conectar() As SqlConnection
        Try
            con.Open()
            Return con
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function desconectar() As Boolean
        Try
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function







End Class
