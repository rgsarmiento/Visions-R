Imports System.Runtime.InteropServices
Imports Newtonsoft.Json.Linq

Public Class Ventas_frm

#Region "para mover formulario desde el panel titulo"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panel_titulo_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_titulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
#End Region

#Region "cerrar formulario"
    Private Sub btn_cerrar_MouseHover(sender As Object, e As EventArgs) Handles btn_cerrar.MouseHover
        btn_cerrar.BackColor = Color.Tomato
    End Sub

    Private Sub btn_cerrar_MouseLeave(sender As Object, e As EventArgs) Handles btn_cerrar.MouseLeave
        btn_cerrar.BackColor = Color.Transparent
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub


#End Region

    Dim dt_lista_impuestos As DataTable

    Public Sub New()
        InitializeComponent()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)

        panel_titulo.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)

        dt_lista_impuestos = Impuestos_cad.Listar()
    End Sub


    Dim producto


    Private Sub Ventas_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuevo()

    End Sub


#Region "Eventos del teclado"

    Private Sub cb_usuarios_Leave(sender As Object, e As EventArgs) Handles cb_usuarios.Leave
        If cb_usuarios.Text = "" Then
            cb_usuarios.Text = "✍ Buscar cliente"
        End If
    End Sub

    Private Sub cb_usuarios_Enter(sender As Object, e As EventArgs) Handles cb_usuarios.Enter
        If cb_usuarios.Text = "✍ Buscar cliente" Then
            cb_usuarios.Text = ""
        End If
    End Sub



#End Region



#Region "Procesos"
    Private Sub nuevo()
        cb_usuarios.Text = "✍ Buscar cliente"
    End Sub

    Private Sub txt_codigo_Leave(sender As Object, e As EventArgs) Handles txt_codigo.Leave

        Dim txt = DirectCast(sender, TextBox)
        buscar_producto(txt)

    End Sub
    Private Sub buscar_producto(txt)
        Dim Productos_cad As Productos_cad = New Productos_cad
        producto = Productos_cad.buscar_producto(txt.Text)

        lbl_nombre_producto.Text = producto.nombre

        leer_precios_json(producto.precios_venta)
    End Sub
#End Region


#Region "impuestos"

    Private Function Filtrar_datos_impuestos(id As Integer) As DataRow
        For Each row As DataRow In dt_lista_impuestos.Rows
            If row("id") = id Then
                Return row
            End If
        Next
        Return Nothing
    End Function

#End Region


#Region "leer objetos json"
    Private Function de_objeto_json_impuestos_a_tabla(impuestos_str) As DataTable

        Dim impuestos_array As JArray = JArray.Parse(impuestos_str)

        For Each jsonChildren As JObject In impuestos_array.Children(Of JObject)()
            Dim id As Integer = jsonChildren("id")
            Dim id_tipo_impuesto As Integer = jsonChildren("id_tipo_impuesto")

            Dim row_impuesto = Filtrar_datos_impuestos(id)
            Dim impuesto_nombre As String = row_impuesto("nombre")

            Dim porcentaje As String = jsonChildren("porcentaje")

        Next
        Return Nothing
    End Function

    Private Sub leer_precios_json(str_json)

        Dim array As JArray = JArray.Parse(str_json)

        lbx_precios.Items.Clear()

        Dim i = 0
        Dim item_defecto = 0
        For Each jsonChildren As JObject In array.Children(Of JObject)()
            Dim id As Integer = jsonChildren("id")
            Dim precio_defecto As Integer = jsonChildren("precio_defecto")
            Dim nombre As String = jsonChildren("nombre")
            Dim utilidad As Decimal = jsonChildren("utilidad")
            Dim valor As String = CStr(jsonChildren("valor"))

            lbx_precios.Items.Add($"{Formulas_formatos.Formato_moneda_general(valor)} | {nombre} # {id}")
            If precio_defecto = 1 And Variables.precio_x_seleccion = False Then
                item_defecto = i
                Variables.id_precio_seleccionado = 0
            ElseIf Variables.precio_x_seleccion = True Then
                If precio_defecto = Variables.id_precio_seleccionado Then
                    item_defecto = i
                End If
            End If

            i += 1
        Next
        lbx_precios.SelectedIndex = item_defecto

    End Sub

    Private Function de_objeto_json_condiciones_a_tabla(str_json) As DataTable

        Dim array As JArray = JArray.Parse(str_json)

        For Each jsonChildren As JObject In array.Children(Of JObject)()
            Dim id As Integer = jsonChildren("id")
            Dim nombre As String = jsonChildren("nombre")



        Next
        Return Nothing
    End Function

    Private Sub lbx_precios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_precios.SelectedIndexChanged
        Dim precio As String = lbx_precios.SelectedItem.ToString
        Dim x = precio.IndexOf("#")
        If x > -1 Then
            Dim id = precio.Substring(x, precio.Length - x)
            Variables.id_precio_seleccionado = id
        End If

    End Sub


#End Region


End Class