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

        Catch ex As SqlException
            Logger.Registro("Seguridad_cad", "Guardar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm

            For Each err As SqlError In ex.Errors                '
                If err.Number = 2627 Then 'Infracción de la restricción "%.ls". No se puede insertar una fila de clave duplicada en el objeto '%. ls'.
                    Msgbox_frm.abrir_frm("error", "Error al guardar seguridad", $"El usuario {e.nombre_usuario} ya existe")
                    Return False
                    Exit For
                End If
            Next
            Msgbox_frm.abrir_frm("error", "Error al guardar seguridad", ex.Message)
            Return False
        End Try
    End Function


    Public Shared Function Actualizar(ByVal e As Seguridad_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "UPDATE Seguridad
                                   SET nombre_usuario = @nombre_usuario, clave = @clave, id_usuario = @id_usuario, id_perfil = @id_perfil, estado = @estado, fecha_actualizado = GETDATE()
                                   WHERE (id = @id)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@id", e.Id)
            comando.Parameters.AddWithValue("@nombre_usuario", e.nombre_usuario)
            comando.Parameters.AddWithValue("@clave", e.Clave)
            comando.Parameters.AddWithValue("@id_usuario", e.id_usuario)
            comando.Parameters.AddWithValue("@id_perfil", e.id_perfil)
            comando.Parameters.AddWithValue("@estado", Math.Abs(e.estado))

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            Logger.Registro("Seguridad_cad", "Actualizar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm

            For Each err As SqlError In ex.Errors                '
                If err.Number = 2627 Then 'Infracción de la restricción "%.ls". No se puede insertar una fila de clave duplicada en el objeto '%. ls'.
                    Msgbox_frm.abrir_frm("error", "Error al actualizar seguridad", $"El usuario {e.nombre_usuario} ya existe")
                    Return False
                    Exit For
                End If
            Next
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


    Public Shared Function Seleccionar() As DataTable
        Try
            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = $"SELECT Seguridad.id, Seguridad.nombre_usuario AS Usuario_Acceso, Seguridad.clave AS Clave, usuarios.nombre_1 + ' ' + usuarios.apellido_1 AS Usuario, perfiles.nombre AS Perfil, Seguridad.estado AS Estado, Seguridad.id_usuario, usuarios.numero_identificacion + ' | ' + usuarios.nombre_1 + ' ' + usuarios.nombre_2 + ' ' + usuarios.apellido_1 + ' ' + usuarios.apellido_2 AS select_usuario
                                    FROM Seguridad INNER JOIN
                                    usuarios ON Seguridad.id_usuario = usuarios.id INNER JOIN
                                    perfiles ON Seguridad.id_perfil = perfiles.id"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()
            Return dt
        Catch ex As Exception
            Logger.Registro("Seguridad_cad", "Seleccionar", ex.ToString)
            Return Nothing
        End Try
    End Function

End Class
