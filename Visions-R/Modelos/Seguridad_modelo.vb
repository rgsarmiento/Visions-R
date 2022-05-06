Public Class Seguridad_modelo
    Public Sub New()
        Me._id = 0
        Me._nombre_usuario = ""
        Me._clave = ""
        Me._estado = 0
        Me._id_usuario = 0
        Me._id_perfil = 0
    End Sub



#Region "Declaraciones"
    Private _id As Integer
    Private _nombre_usuario As String
    Private _clave As String
    Private _estado As Integer
    Private _id_usuario As Integer
    Private _id_perfil As Integer
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

    Public Property nombre_usuario As String
        Get
            Return _nombre_usuario
        End Get
        Set(value As String)
            _nombre_usuario = value
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

    Public Property estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    Public Property id_usuario As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property id_perfil As Integer
        Get
            Return _id_perfil
        End Get
        Set(value As Integer)
            _id_perfil = value
        End Set
    End Property
#End Region


End Class
