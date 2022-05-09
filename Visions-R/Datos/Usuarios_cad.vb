Imports System.Data.SqlClient

Public Class Usuarios_cad

    Public Sub New()
        Variables.conexion_acceso = Acceso_Tablas.Validar("usuarios")
    End Sub

#Region "CRUD"

    Public Shared Function Guardar(ByVal e As Usuario_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "INSERT INTO usuarios
                         (numero_identificacion, dv, id_tipo_documento_identificacion, nombre_1, nombre_2, apellido_1, apellido_2, id_tipo_organizacion, id_tipo_regimen, id_tipo_responsabilidad, telefono, direccion, id_pais, id_departamento, 
                         id_municipio, correo, fecha_actualizado, fecha_creado, cliente, vendedor, proveedor, usuario_visions, otro, estado)
                         VALUES (@numero_identificacion,@dv,@id_tipo_documento_identificacion,@nombre_1,@nombre_2,@apellido_1,@apellido_2,@id_tipo_organizacion,@id_tipo_regimen,@id_tipo_responsabilidad,@telefono,@direccion,@id_pais,@id_departamento,@id_municipio,@correo,
                         GETDATE(), GETDATE(),@cliente,@vendedor,@proveedor,@usuario_visions,@otro, 1)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@numero_identificacion", e.Numero_identificacion)
            comando.Parameters.AddWithValue("@dv", e.Dv)
            comando.Parameters.AddWithValue("@id_tipo_documento_identificacion", e.Id_tipo_documento_identificacion)
            comando.Parameters.AddWithValue("@nombre_1", e.Nombre_1)
            comando.Parameters.AddWithValue("@nombre_2", e.Nombre_2)
            comando.Parameters.AddWithValue("@apellido_1", e.Apellido_1)
            comando.Parameters.AddWithValue("@apellido_2", e.Apellido_2)
            comando.Parameters.AddWithValue("@id_tipo_organizacion", e.Id_tipo_organizacion)
            comando.Parameters.AddWithValue("@id_tipo_regimen", e.Id_tipo_regimen)
            comando.Parameters.AddWithValue("@id_tipo_responsabilidad", e.Id_tipo_responsabilidad)
            comando.Parameters.AddWithValue("@telefono", e.Telefono)
            comando.Parameters.AddWithValue("@direccion", e.Direccion)
            comando.Parameters.AddWithValue("@id_pais", e.Id_pais)
            comando.Parameters.AddWithValue("@id_departamento", e.Id_departamento)
            comando.Parameters.AddWithValue("@id_municipio", e.Id_municipio)
            comando.Parameters.AddWithValue("@correo", e.Correo)
            comando.Parameters.AddWithValue("@cliente", e.Cliente)
            comando.Parameters.AddWithValue("@vendedor", e.Vendedor)
            comando.Parameters.AddWithValue("@proveedor", e.Proveedor)
            comando.Parameters.AddWithValue("@usuario_visions", e.Usuario_visions)
            comando.Parameters.AddWithValue("@otro", e.Otro)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Logger.Registro("Usuarios_cad", "Guardar", ex.ToString)
            Return False
        End Try
    End Function

    Public Shared Function Actualizar(ByVal e As Usuario_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "UPDATE usuarios
                         SET numero_identificacion = @numero_identificacion, dv = @dv, id_tipo_documento_identificacion = @id_tipo_documento_identificacion, nombre_1 = @nombre_1, nombre_2 = @nombre_2, apellido_1 = @apellido_1, 
                         apellido_2 = @apellido_2, id_tipo_organizacion = @id_tipo_organizacion, id_tipo_regimen = @id_tipo_regimen, id_tipo_responsabilidad = @id_tipo_responsabilidad, telefono = @telefono, direccion = @direccion, 
                         id_pais = @id_pais, id_departamento = @id_departamento, id_municipio = @id_municipio, correo = @correo, fecha_actualizado = GETDATE(), cliente = @cliente, vendedor = @vendedor, proveedor = @proveedor, 
                         usuario_visions = @usuario_visions, otro = @otro, estado = @estado
                         WHERE (id = @id)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@id", e.Id)
            comando.Parameters.AddWithValue("@numero_identificacion", e.Numero_identificacion)
            comando.Parameters.AddWithValue("@dv", e.Dv)
            comando.Parameters.AddWithValue("@id_tipo_documento_identificacion", e.Id_tipo_documento_identificacion)
            comando.Parameters.AddWithValue("@nombre_1", e.Nombre_1)
            comando.Parameters.AddWithValue("@nombre_2", e.Nombre_2)
            comando.Parameters.AddWithValue("@apellido_1", e.Apellido_1)
            comando.Parameters.AddWithValue("@apellido_2", e.Apellido_2)
            comando.Parameters.AddWithValue("@id_tipo_organizacion", e.Id_tipo_organizacion)
            comando.Parameters.AddWithValue("@id_tipo_regimen", e.Id_tipo_regimen)
            comando.Parameters.AddWithValue("@id_tipo_responsabilidad", e.Id_tipo_responsabilidad)
            comando.Parameters.AddWithValue("@telefono", e.Telefono)
            comando.Parameters.AddWithValue("@direccion", e.Direccion)
            comando.Parameters.AddWithValue("@id_pais", e.Id_pais)
            comando.Parameters.AddWithValue("@id_departamento", e.Id_departamento)
            comando.Parameters.AddWithValue("@id_municipio", e.Id_municipio)
            comando.Parameters.AddWithValue("@correo", e.Correo)
            comando.Parameters.AddWithValue("@cliente", e.Cliente)
            comando.Parameters.AddWithValue("@vendedor", e.Vendedor)
            comando.Parameters.AddWithValue("@proveedor", e.Proveedor)
            comando.Parameters.AddWithValue("@usuario_visions", e.Usuario_visions)
            comando.Parameters.AddWithValue("@otro", e.Otro)
            comando.Parameters.AddWithValue("@estado", e.Estado)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Logger.Registro("Usuarios_cad", "Actualizar", ex.ToString)
            Return False
        End Try
    End Function

    Public Shared Function Seleccionar(ByVal id As Integer) As DataTable
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = ""
        Catch ex As Exception
            Logger.Registro("Usuarios_cad", "Seleccionar", ex.ToString)
        End Try
    End Function

#End Region

#Region "Listas de seleccion de Usuarios"

    Public Shared Function Listar(tipo_usuario As String) As DataTable
        Try

            Select Case tipo_usuario
                Case "u"
                    tipo_usuario = "usuario_visions"
                Case "c"
                    tipo_usuario = "cliente"
                Case "v"
                    tipo_usuario = "vendedor"
                Case "p"
                    tipo_usuario = "proveedor"
                Case "o"
                    tipo_usuario = "otro"
            End Select

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = $"SELECT id, numero_identificacion + ' | ' + nombre_1 + ' ' + nombre_2 + ' ' + apellido_1 + ' ' + apellido_2 AS buscador
                                     FROM  usuarios
                                        WHERE (estado = 1) AND ({tipo_usuario} = 1)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()
            Return dt

        Catch ex As Exception
            Logger.Registro("Usuarios_cad", "Listar", ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region
End Class
