Public Class Modelo_Seguridad
    Public Sub New()
        Me._id = 0
        Me._codigo = ""
        Me._clave = ""
        Me._perfil = ""
        Me._nombre = ""
        Me._nit = ""
    End Sub



#Region "Declaraciones"
    Private _id As Integer
    Private _codigo As String
    Private _clave As String
    Private _perfil As String
    Private _nombre As String
    Private _nit As String
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

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property

    Public Property Perfil As String
        Get
            Return _perfil
        End Get
        Set(value As String)
            _perfil = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Nit As String
        Get
            Return _nit
        End Get
        Set(value As String)
            _nit = value
        End Set
    End Property
#End Region


End Class
