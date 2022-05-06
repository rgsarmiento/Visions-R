Imports System.Data.SqlClient

Public Class Seguridad_cad

    Public Sub New()
        'Obtener la conexion segun la relacion en conexion_tablas
        Variables.conexion_acceso = Acceso_Tablas.Validar("seguridad")
    End Sub

    Public Shared Function Guardar(ByVal e As Seguridad_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "INSERT INTO Seguridad
                         (nombre_usuario, clave, id_usuario, id_perfil, estado)
                         VALUES (@nombre_usuario,@clave,@id_usuario,@id_perfil,@estado)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@nombre_usuario", e.nombre_usuario)
            comando.Parameters.AddWithValue("@clave", e.Clave)
            comando.Parameters.AddWithValue("@id_usuario", e.id_usuario)
            comando.Parameters.AddWithValue("@id_perfil", e.id_perfil)
            comando.Parameters.AddWithValue("@estado", 1)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Logger.Registro("Seguridad_cad", "Guardar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm
            Msgbox_frm.abrir_frm("error", "Error al guardar seguridad", ex.Message)
            Return False
        End Try
    End Function


    Public Shared Function Actualizar(ByVal e As Seguridad_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "UPDATE Seguridad
                                   SET nombre_usuario = @nombre_usuario, clave = @clave, id_usuario = @id_usuario, id_perfil = @id_perfil, estado = @estado
                                   WHERE (id = @id)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@id", e.Id)
            comando.Parameters.AddWithValue("@nombre_usuario", e.nombre_usuario)
            comando.Parameters.AddWithValue("@clave", e.Clave)
            comando.Parameters.AddWithValue("@id_usuario", e.id_usuario)
            comando.Parameters.AddWithValue("@id_perfil", e.id_perfil)
            comando.Parameters.AddWithValue("@estado", e.estado)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Logger.Registro("Seguridad_cad", "Actualizar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm
            Msgbox_frm.abrir_frm("error", "Error al actualizar seguridad", ex.Message)
            Return False
        End Try
    End Function


    Public Shared Function Eliminar(ByVal e As Seguridad_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "DELETE FROM Seguridad
                                    WHERE (id = @id)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@id", e.Id)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Logger.Registro("Seguridad_cad", "Eliminar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm
            Msgbox_frm.abrir_frm("error", "Error al eliminar seguridad", ex.Message)
            Return False
        End Try
    End Function

End Class
