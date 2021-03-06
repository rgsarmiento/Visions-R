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
            comando.Parameters.AddWithValue("@cliente", Math.Abs(e.Cliente))
            comando.Parameters.AddWithValue("@vendedor", Math.Abs(e.Vendedor))
            comando.Parameters.AddWithValue("@proveedor", Math.Abs(e.Proveedor))
            comando.Parameters.AddWithValue("@usuario_visions", Math.Abs(e.Usuario_visions))
            comando.Parameters.AddWithValue("@otro", Math.Abs(e.Otro))

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            Logger.Registro("Usuarios_cad", "Guardar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm

            For Each err As SqlError In ex.Errors                '
                If err.Number = 2627 Then 'Infracción de la restricción "%.ls". No se puede insertar una fila de clave duplicada en el objeto '%. ls'.
                    Msgbox_frm.abrir_frm("error", "Error al guardar usuario", $"El numero de documento y el correo electronico son valores unicos")
                    Return False
                    Exit For
                End If
            Next
            Msgbox_frm.abrir_frm("error", "Error al guardar usuario", ex.Message)
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
            comando.Parameters.AddWithValue("@cliente", Math.Abs(e.Cliente))
            comando.Parameters.AddWithValue("@vendedor", Math.Abs(e.Vendedor))
            comando.Parameters.AddWithValue("@proveedor", Math.Abs(e.Proveedor))
            comando.Parameters.AddWithValue("@usuario_visions", Math.Abs(e.Usuario_visions))
            comando.Parameters.AddWithValue("@otro", Math.Abs(e.Otro))
            comando.Parameters.AddWithValue("@estado", Math.Abs(e.Estado))

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

#End Region

    Public Shared Function Seleccionar(id As Integer) As Usuario_modelo

        Dim con As Conexion = New Conexion()
        Dim dt As DataTable = New DataTable

        Dim query As String = $"SELECT * FROM usuarios WHERE (id = {id})"

        Try
            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            If dt.Rows.Count > 0 Then
                Dim objeto As Usuario_modelo = New Usuario_modelo()

                objeto.Id = dt.Rows(0)("id").ToString
                objeto.Apellido_1 = dt.Rows(0)("apellido_1").ToString
                objeto.Apellido_2 = dt.Rows(0)("apellido_2").ToString
                objeto.Cliente = dt.Rows(0)("cliente").ToString
                objeto.Correo = dt.Rows(0)("correo").ToString
                objeto.Direccion = dt.Rows(0)("direccion").ToString
                objeto.Dv = dt.Rows(0)("dv").ToString
                objeto.Id_departamento = dt.Rows(0)("id_departamento").ToString
                objeto.Id_municipio = dt.Rows(0)("id_municipio").ToString
                objeto.Id_pais = dt.Rows(0)("id_pais").ToString
                objeto.Id_tipo_documento_identificacion = dt.Rows(0)("id_tipo_documento_identificacion").ToString
                objeto.Id_tipo_organizacion = dt.Rows(0)("id_tipo_organizacion").ToString
                objeto.Id_tipo_regimen = dt.Rows(0)("id_tipo_regimen").ToString
                objeto.Id_tipo_responsabilidad = dt.Rows(0)("id_tipo_responsabilidad").ToString
                objeto.Nombre_1 = dt.Rows(0)("nombre_1").ToString
                objeto.Nombre_2 = dt.Rows(0)("nombre_2").ToString
                objeto.Numero_identificacion = dt.Rows(0)("numero_identificacion").ToString
                objeto.Otro = dt.Rows(0)("otro").ToString
                objeto.Proveedor = dt.Rows(0)("proveedor").ToString
                objeto.Telefono = dt.Rows(0)("telefono").ToString
                objeto.Usuario_visions = dt.Rows(0)("usuario_visions").ToString
                objeto.Vendedor = dt.Rows(0)("vendedor").ToString
                objeto.Estado = dt.Rows(0)("estado").ToString

                Return objeto
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Logger.Registro("Usuarios_cad", "Seleccionar", ex.ToString)
            Return Nothing
        End Try

    End Function


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
                Case Else
                    tipo_usuario = "todos"
            End Select

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = ""

            If tipo_usuario = "todos" Then
                query = "SELECT id, numero_identificacion + ' | ' + nombre_1 + ' ' + nombre_2 + ' ' + apellido_1 + ' ' + apellido_2 AS nombre, 
                                    numero_identificacion + ' ' + nombre_1 + ' ' + nombre_2 + ' ' + apellido_1 + ' ' + apellido_2 + ' ' + correo + ' ' + telefono + ' ' + direccion AS buscador
                                    FROM usuarios"

            Else
                query = $"SELECT id, numero_identificacion + ' | ' + nombre_1 + ' ' + nombre_2 + ' ' + apellido_1 + ' ' + apellido_2 AS nombre, 
                                    numero_identificacion + ' ' + nombre_1 + ' ' + nombre_2 + ' ' + apellido_1 + ' ' + apellido_2 + ' ' + correo + ' ' + telefono + ' ' + direccion AS buscador
                                    FROM usuarios
                                    WHERE (estado = 1) AND ({tipo_usuario} = 1)"
            End If


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
