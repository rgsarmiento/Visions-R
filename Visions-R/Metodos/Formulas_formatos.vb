Public Class Formulas_formatos
    Public Shared Sub Formato_fecha(txt As TextBox)

    End Sub

    Public Shared Sub Formato_moneda(txt As TextBox) 'para textbox
        If txt.Text.Length > 0 Then
            Dim monto As Decimal = 0
            monto = Convert.ToDecimal(txt.Text)
            txt.Text = Decimal.Round(monto, 2).ToString("N2")
        End If
    End Sub

    Public Shared Function Formato_moneda_general(valor As String) As String 'para textbox
        Dim monto As Decimal = 0
        If valor.Length > 0 Then
            monto = Convert.ToDecimal(valor)
        End If
        Return Decimal.Round(monto, 2).ToString("N2")
    End Function


    Public Shared Function hallar_precio_sin_iva(base As Decimal, iva As Decimal) As String
        Dim tarifa = (iva / 100) + 1
        Return base / tarifa
    End Function

    Public Shared Function hallar_precio_con_iva(base As Decimal, iva As Decimal) As String
        Dim tarifa = (iva / 100) + 1
        Return base * tarifa
    End Function

End Class
