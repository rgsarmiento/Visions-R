Public Class Usuarios_funciones

    Public Shared Function CalcularDigito(ByVal numeroDocumento As Decimal) As Integer
        Dim _numeroDocumentoString As String = numeroDocumento.ToString()
        Dim _primos As Integer() = New Integer() {0, 3, 7, 13, 17, 19, 23, 29, 37, 41, 43, 47, 53, 59, 67, 71}
        Dim _digitoVerificacion, _primoActual, _residuo As Integer, _totalOperacion As Integer = 0, _cantidadDigitos As Integer = _numeroDocumentoString.Length

        If Not (numeroDocumento > Decimal.Zero) Then
            Return Nothing
        End If

        For i As Integer = 0 To _cantidadDigitos - 1
            _primoActual = Integer.Parse(_numeroDocumentoString.Substring(i, 1))
            _totalOperacion += _primoActual * _primos(_cantidadDigitos - i)
        Next

        _residuo = _totalOperacion Mod 11

        If _residuo > 1 Then
            _digitoVerificacion = 11 - _residuo
        Else
            _digitoVerificacion = _residuo
        End If

        Return _digitoVerificacion
    End Function

End Class
