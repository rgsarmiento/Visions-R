Imports System.ComponentModel.DataAnnotations

#Region "Para uso interno de la aplicacion"
Public Class impuestos_obj
    <Display(Description:="id tabla impuestos")>
    Public Property id As Integer

    <Display(Description:="id tabla tipo impuesto")>
    Public Property id_tipo_impuesto As Integer

    <Display(Description:="Porcentaje del impuesto")>
    Public Property porcentaje As String = "0.00"

End Class
#End Region



#Region "Para usar con DINA"
Public Class tax_totals_obj
    <Display(Description:="Tipo de impuesto tabla taxes.")>
    Public Property tax_id As Integer = 1

    <Display(Description:="Valor del impuesto")>
    Public Property tax_amount As String = "0.00"

    <Display(Description:="Porcentaje del impuesto")>
    Public Property percent As String = "0.00"

    <Display(Description:="Valor numérico que informa la base del impuesto")>
    Public Property taxable_amount As String = "0.00"

    <Display(Description:="Valor precio unitario para la bolsa plastica")>
    Public Property per_unit_amount As String = "0.00"

    <Display(Description:="Valor numérico que informa la presentacion del producto ejem:Unidad")>
    Public Property unit_measure_id As Integer = 70
    Public Property base_unit_measure As Integer = "0.00"
End Class
#End Region


