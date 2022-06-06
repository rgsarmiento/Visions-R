Public Class Producto_modelo

    Public Sub New()
        _id = 0
        _codigo = ""
        _codigo_interno = ""
        _nombre = ""
        _id_marca = 0
        _id_subgrupo = 0
        _id_tipo_unidades_medida = 0
        _embalaje = 0
        _existencias = 0
        _existencias_minimas = 0
        _existencias_maximas = 0
        _peso_gramos = 0
        _impuestos = ""
        _precio_costo = 0
        _precio_costo_iva = 0
        _precios_venta = ""
        _condiciones = ""
        _id_estado = 0
        _notas = ""
        _fecha_venta = Nothing
        _fecha_compra = Nothing
        _fecha_actualizado = Nothing
        _fecha_creado = Nothing
    End Sub

    Dim _id As Integer
    Dim _codigo As String
    Dim _codigo_interno As String
    Dim _nombre As String
    Dim _id_marca As Integer
    Dim _id_subgrupo As Integer
    Dim _id_tipo_unidades_medida As Integer
    Dim _embalaje As Decimal
    Dim _existencias As Decimal
    Dim _existencias_minimas As Decimal
    Dim _existencias_maximas As Decimal
    Dim _peso_gramos As Decimal
    Dim _impuestos As String
    Dim _precio_costo As Decimal
    Dim _precio_costo_iva As Decimal
    Dim _precios_venta As String
    Dim _condiciones As String
    Dim _id_estado As Integer
    Dim _notas As String
    Dim _fecha_venta As DateTime
    Dim _fecha_compra As DateTime
    Dim _fecha_actualizado As DateTime
    Dim _fecha_creado As DateTime

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property codigo_interno As String
        Get
            Return _codigo_interno
        End Get
        Set(value As String)
            _codigo_interno = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property id_marca As Integer
        Get
            Return _id_marca
        End Get
        Set(value As Integer)
            _id_marca = value
        End Set
    End Property

    Public Property id_subgrupo As Integer
        Get
            Return _id_subgrupo
        End Get
        Set(value As Integer)
            _id_subgrupo = value
        End Set
    End Property

    Public Property id_tipo_unidades_medida As Integer
        Get
            Return _id_tipo_unidades_medida
        End Get
        Set(value As Integer)
            _id_tipo_unidades_medida = value
        End Set
    End Property

    Public Property embalaje As Decimal
        Get
            Return _embalaje
        End Get
        Set(value As Decimal)
            _embalaje = value
        End Set
    End Property

    Public Property existencias As Decimal
        Get
            Return _existencias
        End Get
        Set(value As Decimal)
            _existencias = value
        End Set
    End Property

    Public Property existencias_minimas As Decimal
        Get
            Return _existencias_minimas
        End Get
        Set(value As Decimal)
            _existencias_minimas = value
        End Set
    End Property

    Public Property existencias_maximas As Decimal
        Get
            Return _existencias_maximas
        End Get
        Set(value As Decimal)
            _existencias_maximas = value
        End Set
    End Property

    Public Property peso_gramos As Decimal
        Get
            Return _peso_gramos
        End Get
        Set(value As Decimal)
            _peso_gramos = value
        End Set
    End Property

    Public Property impuestos As String
        Get
            Return _impuestos
        End Get
        Set(value As String)
            _impuestos = value
        End Set
    End Property

    Public Property precio_costo As Decimal
        Get
            Return _precio_costo
        End Get
        Set(value As Decimal)
            _precio_costo = value
        End Set
    End Property

    Public Property precio_costo_iva As Decimal
        Get
            Return _precio_costo_iva
        End Get
        Set(value As Decimal)
            _precio_costo_iva = value
        End Set
    End Property

    Public Property precios_venta As String
        Get
            Return _precios_venta
        End Get
        Set(value As String)
            _precios_venta = value
        End Set
    End Property

    Public Property condiciones As String
        Get
            Return _condiciones
        End Get
        Set(value As String)
            _condiciones = value
        End Set
    End Property

    Public Property id_estado As Integer
        Get
            Return _id_estado
        End Get
        Set(value As Integer)
            _id_estado = value
        End Set
    End Property

    Public Property notas As String
        Get
            Return _notas
        End Get
        Set(value As String)
            _notas = value
        End Set
    End Property

    Public Property fecha_venta As Date
        Get
            Return _fecha_venta
        End Get
        Set(value As Date)
            _fecha_venta = value
        End Set
    End Property

    Public Property fecha_compra As Date
        Get
            Return _fecha_compra
        End Get
        Set(value As Date)
            _fecha_compra = value
        End Set
    End Property

    Public Property fecha_actualizado As Date
        Get
            Return _fecha_actualizado
        End Get
        Set(value As Date)
            _fecha_actualizado = value
        End Set
    End Property

    Public Property fecha_creado As Date
        Get
            Return _fecha_creado
        End Get
        Set(value As Date)
            _fecha_creado = value
        End Set
    End Property
End Class
