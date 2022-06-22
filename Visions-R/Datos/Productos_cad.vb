Imports System.Data.SqlClient

Public Class Productos_cad

    Public Sub New()
        Variables.conexion_acceso = Acceso_Tablas.Validar("productos")
    End Sub


#Region "CRUD"

    Public Shared Function Guardar(ByVal e As Producto_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "INSERT INTO productos
                         (codigo, codigo_interno, nombre, id_marca, id_subgrupo, id_tipo_unidades_medida, embalaje, existencias, existencias_minimas, existencias_maximas, peso_gramos, impuestos, precio_costo, precio_costo_iva, 
                         precios_venta, condiciones, id_estado, notas)
                         VALUES (@codigo,@codigo_interno,@nombre,@id_marca,@id_subgrupo,@id_tipo_unidades_medida,@embalaje,@existencias,@existencias_minimas,@existencias_maximas,@peso_gramos,@impuestos,@precio_costo,@precio_costo_iva,@precios_venta,@condiciones,@id_estado,@notas)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@codigo", e.codigo)
            comando.Parameters.AddWithValue("@codigo_interno", e.codigo_interno)
            comando.Parameters.AddWithValue("@nombre", e.nombre)
            comando.Parameters.AddWithValue("@id_marca", e.id_marca)
            comando.Parameters.AddWithValue("@id_subgrupo", e.id_subgrupo)
            comando.Parameters.AddWithValue("@id_tipo_unidades_medida", e.id_tipo_unidades_medida)
            comando.Parameters.AddWithValue("@embalaje", e.embalaje)
            comando.Parameters.AddWithValue("@existencias", e.existencias)
            comando.Parameters.AddWithValue("@existencias_minimas", e.existencias_minimas)
            comando.Parameters.AddWithValue("@existencias_maximas", e.existencias_maximas)
            comando.Parameters.AddWithValue("@peso_gramos", e.peso_gramos)
            comando.Parameters.AddWithValue("@impuestos", e.impuestos)
            comando.Parameters.AddWithValue("@precio_costo", e.precio_costo)
            comando.Parameters.AddWithValue("@precio_costo_iva", e.precio_costo_iva)
            comando.Parameters.AddWithValue("@precios_venta", e.precios_venta)
            comando.Parameters.AddWithValue("@condiciones", e.condiciones)
            comando.Parameters.AddWithValue("@id_estado", e.id_estado)
            comando.Parameters.AddWithValue("@notas", e.notas)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            Logger.Registro("Productos_cad", "Guardar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm

            For Each err As SqlError In ex.Errors                '
                If err.Number = 2627 Then 'Infracción de la restricción "%.ls". No se puede insertar una fila de clave duplicada en el objeto '%. ls'.
                    Msgbox_frm.abrir_frm("error", "Error al guardar Producto", $"El producto {e.codigo} {e.codigo_interno} {e.nombre} ya existe")
                    Return False
                    Exit For
                End If
            Next
            Msgbox_frm.abrir_frm("error", "Error al guardar Producto", ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function Actualizar(ByVal e As Producto_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "UPDATE productos
                                 SET codigo = @codigo, codigo_interno = @codigo_interno, nombre = @nombre, id_marca = @id_marca, id_subgrupo = @id_subgrupo, id_tipo_unidades_medida = @id_tipo_unidades_medida, embalaje = @embalaje, 
                                 existencias = @existencias, existencias_minimas = @existencias_minimas, existencias_maximas = @existencias_maximas, peso_gramos = @peso_gramos, impuestos = @impuestos, precio_costo = @precio_costo, 
                                 precio_costo_iva = @precio_costo_iva, precios_venta = @precios_venta, condiciones = @condiciones, id_estado = @id_estado, notas = @notas, fecha_actualizado = GETDATE()
                                 WHERE (id = @id)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@id", e.id)
            comando.Parameters.AddWithValue("@codigo", e.codigo)
            comando.Parameters.AddWithValue("@codigo_interno", e.codigo_interno)
            comando.Parameters.AddWithValue("@nombre", e.nombre)
            comando.Parameters.AddWithValue("@id_marca", e.id_marca)
            comando.Parameters.AddWithValue("@id_subgrupo", e.id_subgrupo)
            comando.Parameters.AddWithValue("@id_tipo_unidades_medida", e.id_tipo_unidades_medida)
            comando.Parameters.AddWithValue("@embalaje", e.embalaje)
            comando.Parameters.AddWithValue("@existencias", e.existencias)
            comando.Parameters.AddWithValue("@existencias_minimas", e.existencias_minimas)
            comando.Parameters.AddWithValue("@existencias_maximas", e.existencias_maximas)
            comando.Parameters.AddWithValue("@peso_gramos", e.peso_gramos)
            comando.Parameters.AddWithValue("@impuestos", e.impuestos)
            comando.Parameters.AddWithValue("@precio_costo", e.precio_costo)
            comando.Parameters.AddWithValue("@precio_costo_iva", e.precio_costo_iva)
            comando.Parameters.AddWithValue("@precios_venta", e.precios_venta)
            comando.Parameters.AddWithValue("@condiciones", e.condiciones)
            comando.Parameters.AddWithValue("@id_estado", e.id_estado)
            comando.Parameters.AddWithValue("@notas", e.notas)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            Logger.Registro("Productos_cad", "Actualizar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm

            For Each err As SqlError In ex.Errors                '
                If err.Number = 2627 Then 'Infracción de la restricción "%.ls". No se puede insertar una fila de clave duplicada en el objeto '%. ls'.
                    Msgbox_frm.abrir_frm("error", "Error al actualizar Productos", $"El usuario {e.codigo} {e.codigo_interno} {e.nombre} ya existe")
                    Return False
                    Exit For
                End If
            Next
            Msgbox_frm.abrir_frm("error", "Error al actualizar Productos", ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function Eliminar(ByVal e As Seguridad_modelo) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "DELETE FROM productos
                                    WHERE (id = @id)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@id", e.id)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Logger.Registro("Productos_cad", "Eliminar", ex.ToString)
            Dim Msgbox_frm As New Msgbox_frm
            Msgbox_frm.abrir_frm("error", "Error al eliminar Productos", ex.Message)
            Return False
        End Try
    End Function

#End Region


    Public Shared Function Lista_completa() As DataTable
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim query As String = "SELECT id, codigo, codigo_interno, nombre, id_marca, id_subgrupo, id_tipo_unidades_medida, embalaje, existencias, existencias_minimas, existencias_maximas, peso_gramos, impuestos, precio_costo, precio_costo_iva, 
                                    precios_venta, condiciones, id_estado, notas, fecha_venta, fecha_compra, fecha_actualizado, fecha_creado
                                    FROM productos"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            Dim dr As SqlDataReader = comando.ExecuteReader(CommandBehavior.CloseConnection)
            dt.Load(dr)
            con.desconectar()

            Dim fila As DataRow = dt.NewRow()
            fila("id") = 0
            fila("nombre") = ""
            fila("codigo") = ""
            fila("codigo_interno") = ""
            fila("impuestos") = ""
            fila("precios_venta") = ""
            fila("condiciones") = ""
            fila("id_marca") = 0
            fila("id_subgrupo") = 0
            fila("id_tipo_unidades_medida") = 0
            fila("embalaje") = 0
            fila("existencias") = 0
            fila("existencias_minimas") = 0
            fila("existencias_maximas") = 0
            fila("peso_gramos") = 0
            fila("precio_costo") = 0
            fila("precio_costo_iva") = 0
            fila("id_estado") = 0
            fila("notas") = ""
            fila("fecha_venta") = Now
            fila("fecha_compra") = Now
            fila("fecha_actualizado") = Now
            fila("fecha_creado") = Now

            dt.Rows.InsertAt(fila, 0)

            Return dt

        Catch ex As Exception
            Logger.Registro("Productos_cad", "Lista_completa", ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Shared Function buscar_producto(codigo As String) As Producto_modelo
        Try

            Dim con As Conexion = New Conexion()
            Dim dt As DataTable = New DataTable

            Dim obj As Producto_modelo = New Producto_modelo()

            Dim query As String = "SELECT id, codigo, codigo_interno, nombre, id_marca, id_subgrupo, id_tipo_unidades_medida, embalaje, existencias, existencias_minimas, existencias_maximas, peso_gramos, impuestos, precio_costo, precio_costo_iva, 
                                    precios_venta, condiciones, id_estado, notas, fecha_venta, fecha_compra, fecha_actualizado, fecha_creado
                                    FROM productos
                                    WHERE (codigo = @codigo) OR (codigo_interno = @codigo)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@codigo", codigo)

            Dim sdr As SqlDataReader = comando.ExecuteReader()
            While sdr.Read()
                obj.codigo = sdr("codigo").ToString()
                obj.codigo_interno = sdr("codigo_interno").ToString()
                obj.nombre = sdr("nombre").ToString()
                obj.id_marca = sdr("id_marca").ToString()
                obj.id_subgrupo = sdr("id_subgrupo").ToString()
                obj.id_tipo_unidades_medida = sdr("id_tipo_unidades_medida").ToString()
                obj.embalaje = sdr("embalaje").ToString()
                obj.existencias = sdr("existencias").ToString()
                obj.existencias_minimas = sdr("existencias_minimas").ToString()
                obj.existencias_maximas = sdr("existencias_maximas").ToString()
                obj.peso_gramos = sdr("peso_gramos").ToString()
                obj.impuestos = sdr("impuestos").ToString()
                obj.precio_costo = sdr("precio_costo").ToString()
                obj.precio_costo_iva = sdr("precio_costo_iva").ToString()
                obj.precios_venta = sdr("precios_venta").ToString()
                obj.condiciones = sdr("condiciones").ToString()
                obj.id_estado = sdr("id_estado").ToString()
                obj.notas = sdr("notas").ToString()
                obj.fecha_venta = sdr("fecha_venta").ToString()
                obj.fecha_compra = sdr("fecha_compra").ToString()
                obj.fecha_actualizado = sdr("fecha_actualizado").ToString()
                obj.fecha_creado = sdr("fecha_creado").ToString()
            End While

            con.desconectar()

            Return obj

        Catch ex As Exception
            Logger.Registro("Productos_cad", "buscar_producto", ex.ToString)
            Return Nothing
        End Try
    End Function

End Class
