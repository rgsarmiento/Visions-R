Public Class Usuario_modelo

    Public Sub New()
        _id = 0
        _numero_identificacion = ""
        _dv = 0
        _id_tipo_documento_identificacion = 0
        _nombre_1 = ""
        _nombre_2 = ""
        _apellido_1 = ""
        _apellido_2 = ""
        _id_tipo_organizacion = 0
        _id_tipo_regimen = 0
        _id_tipo_responsabilidad = 0
        _telefono = ""
        _direccion = ""
        _id_pais = 0
        _id_departamento = 0
        _id_municipio = 0
        _correo = Correo
        _fecha_actualizado = ""
        _fecha_creado = ""
        _cliente = 0
        _vendedor = 0
        _proveedor = 0
        _usuario_visions = 0
        _otro = 0
        _estado = 0
    End Sub

#Region "Declaraciones"

    Private _id As Integer
    Private _numero_identificacion As String
    Private _dv As Integer
    Private _id_tipo_documento_identificacion As Integer
    Private _nombre_1 As String
    Private _nombre_2 As String
    Private _apellido_1 As String
    Private _apellido_2 As String
    Private _id_tipo_organizacion As Integer
    Private _id_tipo_regimen As Integer
    Private _id_tipo_responsabilidad As Integer
    Private _telefono As String
    Private _direccion As String
    Private _id_pais As Integer
    Private _id_departamento As Integer
    Private _id_municipio As Integer
    Private _correo As String
    Private _fecha_actualizado As String
    Private _fecha_creado As String
    Private _cliente As Integer
    Private _vendedor As Integer
    Private _proveedor As Integer
    Private _usuario_visions As Integer
    Private _otro As Integer
    Private _estado As Integer
#End Region

#Region "Esquema del modelo de datos"
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Numero_identificacion As String
        Get
            Return _numero_identificacion
        End Get
        Set(value As String)
            _numero_identificacion = value
        End Set
    End Property

    Public Property Dv As Integer
        Get
            Return _dv
        End Get
        Set(value As Integer)
            _dv = value
        End Set
    End Property

    Public Property Id_tipo_documento_identificacion As Integer
        Get
            Return _id_tipo_documento_identificacion
        End Get
        Set(value As Integer)
            _id_tipo_documento_identificacion = value
        End Set
    End Property

    Public Property Nombre_1 As String
        Get
            Return _nombre_1
        End Get
        Set(value As String)
            _nombre_1 = value
        End Set
    End Property

    Public Property Nombre_2 As String
        Get
            Return _nombre_2
        End Get
        Set(value As String)
            _nombre_2 = value
        End Set
    End Property

    Public Property Apellido_1 As String
        Get
            Return _apellido_1
        End Get
        Set(value As String)
            _apellido_1 = value
        End Set
    End Property

    Public Property Apellido_2 As String
        Get
            Return _apellido_2
        End Get
        Set(value As String)
            _apellido_2 = value
        End Set
    End Property

    Public Property Id_tipo_organizacion As Integer
        Get
            Return _id_tipo_organizacion
        End Get
        Set(value As Integer)
            _id_tipo_organizacion = value
        End Set
    End Property

    Public Property Id_tipo_regimen As Integer
        Get
            Return _id_tipo_regimen
        End Get
        Set(value As Integer)
            _id_tipo_regimen = value
        End Set
    End Property

    Public Property Id_tipo_responsabilidad As Integer
        Get
            Return _id_tipo_responsabilidad
        End Get
        Set(value As Integer)
            _id_tipo_responsabilidad = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Id_pais As Integer
        Get
            Return _id_pais
        End Get
        Set(value As Integer)
            _id_pais = value
        End Set
    End Property

    Public Property Id_departamento As Integer
        Get
            Return _id_departamento
        End Get
        Set(value As Integer)
            _id_departamento = value
        End Set
    End Property

    Public Property Id_municipio As Integer
        Get
            Return _id_municipio
        End Get
        Set(value As Integer)
            _id_municipio = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Fecha_actualizado As String
        Get
            Return _fecha_actualizado
        End Get
        Set(value As String)
            _fecha_actualizado = value
        End Set
    End Property

    Public Property Fecha_creado As String
        Get
            Return _fecha_creado
        End Get
        Set(value As String)
            _fecha_creado = value
        End Set
    End Property

    Public Property Cliente As Integer
        Get
            Return _cliente
        End Get
        Set(value As Integer)
            _cliente = value
        End Set
    End Property

    Public Property Vendedor As Integer
        Get
            Return _vendedor
        End Get
        Set(value As Integer)
            _vendedor = value
        End Set
    End Property

    Public Property Proveedor As Integer
        Get
            Return _proveedor
        End Get
        Set(value As Integer)
            _proveedor = value
        End Set
    End Property

    Public Property Usuario_visions As Integer
        Get
            Return _usuario_visions
        End Get
        Set(value As Integer)
            _usuario_visions = value
        End Set
    End Property

    Public Property Otro As Integer
        Get
            Return _otro
        End Get
        Set(value As Integer)
            _otro = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

#End Region

End Class
