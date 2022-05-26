Public Class Impuestos_obj

    Public Class Rootobject
        Public Property impuestos() As Impuesto
    End Class

    Public Class Impuesto
        Public Property id As Integer
        Public Property importe As String
        Public Property porcentaje As String
        Public Property base As String
    End Class

End Class
