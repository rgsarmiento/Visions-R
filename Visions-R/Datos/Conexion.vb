Imports System.Data.SqlClient
Imports System.IO
Imports Newtonsoft.Json

Public Class Conexion

    Dim con As SqlConnection

    Public Sub New()


        Dim db_servidor = Deploy_parameters.modelo_configuraciones.db_servidor
        Dim db_servidor_documentos = Deploy_parameters.modelo_configuraciones.app_settings.db_servidor_documentos
        Dim db_servidor_cuentas = Deploy_parameters.modelo_configuraciones.app_settings.db_servidor_cuentas

        Dim str_con As String = ""

        Select Case Variables.conexion_acceso
            Case "db_servidor"
                str_con = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                        db_servidor.server_name, db_servidor.database_name, db_servidor.user_name, db_servidor.password)
            Case "db_servidor_documentos"
                str_con = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                        db_servidor_documentos.server_name, db_servidor_documentos.database_name, db_servidor_documentos.user_name, db_servidor_documentos.password)
            Case "db_servidor_cuentas"
                str_con = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                        db_servidor_cuentas.server_name, db_servidor_cuentas.database_name, db_servidor_cuentas.user_name, db_servidor_cuentas.password)
            Case Else
                str_con = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                        db_servidor.server_name, db_servidor.database_name, db_servidor.user_name, db_servidor.password)
        End Select

        Variables.conexion_acceso = ""

        con = New SqlConnection(str_con)
    End Sub

    Public Function conectar() As SqlConnection
        Try
            con.Open()
            Return con
        Catch ex As Exception
            Logger.Registro("Conexion", "conectar", ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function desconectar() As Boolean
        Try
            con.Close()
            Return True
        Catch ex As Exception
            Logger.Registro("Conexion", "desconectar", ex.ToString)
            Return False
        End Try
    End Function



End Class
