Imports System.Runtime.InteropServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Productos_frm

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
    Public Sub New()
        InitializeComponent()
        dt_lista_impuestos = Impuestos_cad.Listar()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)

        panel_titulo.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)
    End Sub

    Dim dt_lista_impuestos As DataTable

    Private Sub Productos_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_marcas()
        Listar_grupos()
        Listar_tipo_unidades_medida()

        Listar_tipo_impuestos()
        Listar_tipo_precios()
        Listar_condiciones()
    End Sub


#Region "Listas de seleccion"
    Private Sub Listar_tipo_impuestos()
        Try

            With cbx_impuestos
                .DataSource = Nothing
                .DataSource = dt_lista_impuestos
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .FlatStyle = FlatStyle.Standard
                .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                .ForeColor = Color.White
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listar_tipo_precios()
        Try

            With cbx_precios
                .DataSource = Nothing
                .DataSource = Tipo_precios_cad.Listar
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .FlatStyle = FlatStyle.Standard
                .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                .ForeColor = Color.White
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listar_marcas()
        Try

            With cbx_marca
                .DataSource = Nothing
                .DataSource = Marcas_cad.Listar
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .FlatStyle = FlatStyle.Standard
                .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                .ForeColor = Color.White
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listar_grupos()
        Try

            With cbx_subgrupo
                .DataSource = Nothing
                .DataSource = Subgrupos_cad.Listar
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .FlatStyle = FlatStyle.Standard
                .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                .ForeColor = Color.White
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listar_tipo_unidades_medida()
        Try

            With cbx_presentacion
                .DataSource = Nothing
                .DataSource = Tipo_unidades_medida_cad.Listar
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .FlatStyle = FlatStyle.Standard
                .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                .ForeColor = Color.White
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listar_condiciones()
        Try

            With cbx_condiciones
                .DataSource = Nothing
                .DataSource = Condiciones_cad.Listar("productos")
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .FlatStyle = FlatStyle.Standard
                .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                .ForeColor = Color.White
            End With
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "impuesto al producto"

    Dim dt_impuestos As New DataTable


    Private Function Filtrar_datos_impuestos(id As Integer) As DataRow
        For Each row As DataRow In dt_lista_impuestos.Rows
            If row("id") = id Then
                Return row
            End If
        Next
        Return Nothing
    End Function

    Private Sub Adicionar_impuesto_dt(
                                  id As Integer,
                                  id_tipo_impuesto As Integer,
                                  impuesto_nombre As String,
                                  porcentaje As Decimal)

        If dt_impuestos.Columns.Contains("id") Then

        Else
            dt_impuestos.Columns.Add("id", GetType(Int32))
            dt_impuestos.Columns.Add("id_tipo_impuesto")
            dt_impuestos.Columns.Add("impuesto", GetType(String))
            dt_impuestos.Columns.Add("porcentaje", GetType(Decimal))
        End If

        dt_impuestos.Rows.Add(id, id_tipo_impuesto, impuesto_nombre, porcentaje)
    End Sub

    Private Function Existe_impuesto_producto(id As Integer) As Boolean
        If dt_impuestos IsNot Nothing Then
            If dt_impuestos.Rows.Count > 0 Then
                For Each row As DataRow In dt_impuestos.Rows
                    If row("Id") = id Then
                        Return True
                    End If
                Next
            End If
        End If
        Return False
    End Function

    Private Sub btn_add_impuesto_Click(sender As Object, e As EventArgs) Handles btn_add_impuesto.Click

        Dim id_impuesto As Integer = cbx_impuestos.SelectedValue
        If id_impuesto > 0 Then
            If Existe_impuesto_producto(id_impuesto) = False Then

                Dim row_impuesto = Filtrar_datos_impuestos(id_impuesto)

                Adicionar_impuesto_dt(id_impuesto, row_impuesto("id_tipo_impuesto"), row_impuesto("nombre"), row_impuesto("porcentaje"))
                crear_tabla_impuestos()
                proceso_estado("ok", $"☑ Se agrego el impuesto {cbx_impuestos.Text}")
                cbx_impuestos.SelectedIndex = 0
            Else
                proceso_estado("error", $"☠ No se puede agregar, ya existe el impuesto {cbx_impuestos.Text}")
            End If
        End If

    End Sub

    Private Sub crear_tabla_impuestos()

        With Me.dgv_impuestos
            .DataSource = Nothing
            .DataSource = dt_impuestos
            '.BorderStyle = BorderStyle.None
            .AllowUserToAddRows = False 'quitar fila vacia
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal 'dejar solo lineas horizontales en la tabla
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None 'quitar el estilo de bodes por default de la cabezera
            'cabezera.........
            .ColumnHeadersHeight = 23
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray  'color de la cabezera
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White 'color fuente cabezera
            .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DimGray 'color de seleccion de la cabezera
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White 'color fuente cabezera seleccionada
            .EnableHeadersVisualStyles = False
            'Filas.........
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersVisible = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            .RowsDefaultCellStyle.ForeColor = Color.DimGray
            .RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen  'color de seleccion de la fila
            .RowsDefaultCellStyle.SelectionForeColor = Color.White  'color fuente fila seleccionada
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With


        dgv_impuestos.Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_impuestos.Columns("id").Width = 0%
        dgv_impuestos.Columns("id_tipo_impuesto").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_impuestos.Columns("id_tipo_impuesto").Width = 0%
        'dgv_impuestos.Columns("importe").DefaultCellStyle.Format = "C2"

        dgv_impuestos.CurrentCell = Nothing

    End Sub

    Private Function serializar_objeto_impuesto() As String

        Dim impuestos_json As New List(Of impuestos)

        For Each row As DataRow In dt_impuestos.Rows
            impuestos_json.Add(New impuestos() With {
            .id = row("id"),
            .id_tipo_impuesto = row("id_tipo_impuesto"),
            .porcentaje = row("Porcentaje")
                       })
        Next

        Return JsonConvert.SerializeObject(impuestos_json)

    End Function

    Private Sub dgv_impuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_impuestos.CellDoubleClick
        Try
            Dim fila As Integer = e.RowIndex
            cbx_impuestos.SelectedValue = dt_impuestos.Rows(fila)("id").ToString
            proceso_estado("ok", $"☑ Se elimino el impuesto {cbx_impuestos.Text}")
            dt_impuestos.Rows(fila).Delete()
            crear_tabla_impuestos()
        Catch ex As Exception
        End Try
    End Sub

#End Region


    Private Function de_objeto_json_impuestos_a_tabla(impuestos_str) As DataTable

        Dim impuestos_array As JArray = JArray.Parse(impuestos_str)

        For Each jsonChildren As JObject In impuestos_array.Children(Of JObject)()
            Dim id As Integer = jsonChildren("id")
            Dim id_tipo_impuesto As Integer = jsonChildren("id_tipo_impuesto")
            Dim impuesto_nombre As Integer = jsonChildren("impuesto")
            Dim porcentaje As Integer = jsonChildren("porcentaje")

            Adicionar_impuesto_dt(id, id_tipo_impuesto, impuesto_nombre, porcentaje)
            crear_tabla_impuestos()

        Next
        Return Nothing
    End Function


#Region "condiciones"
    Dim dt_condiciones As New DataTable

    Private Sub Adicionar_condicion_dt(
                                  id As Integer,
                                  nombre As String)

        If dt_condiciones.Columns.Contains("id") Then
        Else
            dt_condiciones.Columns.Add("id", GetType(Int32))
            dt_condiciones.Columns.Add("nombre", GetType(String))
        End If

        dt_condiciones.Rows.Add(id, nombre)
    End Sub

    Private Function Existe_condicion(id As Integer) As Boolean
        If dt_condiciones IsNot Nothing Then
            If dt_condiciones.Rows.Count > 0 Then
                For Each row As DataRow In dt_condiciones.Rows
                    If row("Id") = id Then
                        Return True
                    End If
                Next
            End If
        End If
        Return False
    End Function

    Private Sub crear_tabla_condiciones()

        With Me.dgv_condiciones
            .DataSource = Nothing
            .DataSource = dt_condiciones
            '.BorderStyle = BorderStyle.None
            .AllowUserToAddRows = False 'quitar fila vacia
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal 'dejar solo lineas horizontales en la tabla
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None 'quitar el estilo de bodes por default de la cabezera
            'cabezera.........
            .ColumnHeadersHeight = 23
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray  'color de la cabezera
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White 'color fuente cabezera
            .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DimGray 'color de seleccion de la cabezera
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White 'color fuente cabezera seleccionada
            .EnableHeadersVisualStyles = False
            'Filas.........
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersVisible = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            .RowsDefaultCellStyle.ForeColor = Color.DimGray
            .RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen  'color de seleccion de la fila
            .RowsDefaultCellStyle.SelectionForeColor = Color.White  'color fuente fila seleccionada
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .CurrentCell = Nothing
            .Columns("id").Visible = False

        End With

        dgv_condiciones.CurrentCell = Nothing

    End Sub

    Private Sub btn_add_condiciones_Click(sender As Object, e As EventArgs) Handles btn_add_condiciones.Click
        Dim id_condicion As Integer = cbx_condiciones.SelectedValue
        Dim nombre_condicion As String = cbx_condiciones.Text
        If id_condicion > 0 Then
            If Existe_condicion(id_condicion) = False Then

                Adicionar_condicion_dt(id_condicion, nombre_condicion)
                crear_tabla_condiciones()
                dgv_condiciones.CurrentCell = Nothing

                proceso_estado("ok", $"☑ Se agrego la condicion de {cbx_condiciones.Text}")
                cbx_condiciones.SelectedIndex = 0
            Else
                proceso_estado("error", $"☠ No se puede agregar, ya existe la condicion de {cbx_condiciones.Text}")
            End If
        End If
    End Sub

    Private Sub dgv_condiciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_condiciones.CellDoubleClick
        Try
            Dim fila As Integer = e.RowIndex
            cbx_condiciones.SelectedValue = dt_condiciones.Rows(fila)("id").ToString
            proceso_estado("ok", $"☑ Se elimino la condicion de {cbx_condiciones.Text}")
            dt_condiciones.Rows(fila).Delete()
            crear_tabla_condiciones()
        Catch ex As Exception
        End Try
    End Sub

#End Region


#Region "Costos"
    Private Sub txt_costo_Leave(sender As Object, e As EventArgs) Handles txt_costo.Leave
        If txt_costo.Text.Length = 0 Then
            txt_costo.Text = "0"
        End If
        txt_costo_iva.Text = Formulas_formatos.hallar_precio_con_iva(txt_costo.Text, 0)
        For Each row As DataRow In dt_impuestos.Rows
            Dim iva As Decimal = CDec(row("porcentaje"))
            If iva > 0 Then
                txt_costo_iva.Text = Formulas_formatos.hallar_precio_con_iva(txt_costo.Text, iva)
            End If
        Next
        Formulas_formatos.Formato_moneda(txt_costo_iva)
        Formulas_formatos.Formato_moneda(txt_costo)
    End Sub

    Private Sub txt_costo_iva_Leave(sender As Object, e As EventArgs) Handles txt_costo_iva.Leave, TextBox7.Leave, TextBox2.Leave
        If txt_costo_iva.Text.Length = 0 Then
            txt_costo_iva.Text = "0"
        End If
        txt_costo.Text = Formulas_formatos.hallar_precio_sin_iva(txt_costo_iva.Text, 0)
        For Each row As DataRow In dt_impuestos.Rows
            Dim iva As Decimal = CDec(row("porcentaje"))
            If iva > 0 Then
                txt_costo.Text = Formulas_formatos.hallar_precio_sin_iva(txt_costo_iva.Text, iva)
            End If
        Next
        Formulas_formatos.Formato_moneda(txt_costo_iva)
        Formulas_formatos.Formato_moneda(txt_costo)
    End Sub
#End Region

#Region "Precios"

    Dim dt_precios As New DataTable

    Private Sub Adicionar_precio_dt(
                                  id As Integer,
                                  precio_defecto As Integer,
                                  nombre As String,
                                  utilidad As Decimal,
                                  valor As Decimal)

        If dt_precios.Columns.Contains("id") Then

        Else
            dt_precios.Columns.Add("id", GetType(Int32))
            dt_precios.Columns.Add("precio_defecto", GetType(Int32))
            dt_precios.Columns.Add("nombre", GetType(String))
            dt_precios.Columns.Add("utilidad", GetType(Decimal))
            dt_precios.Columns.Add("valor", GetType(Decimal))
        End If

        dt_precios.Rows.Add(id, precio_defecto, nombre, utilidad, valor)
    End Sub

    Private Function Existe_precio_producto(id As Integer) As Boolean
        If dt_precios IsNot Nothing Then
            If dt_precios.Rows.Count > 0 Then
                For Each row As DataRow In dt_precios.Rows
                    If row("Id") = id Then
                        Return True
                    End If
                Next
            End If
        End If
        Return False
    End Function

    Private Sub crear_tabla_precios()

        With Me.dgv_precios
            .DataSource = Nothing
            .DataSource = dt_precios
            '.BorderStyle = BorderStyle.None
            .AllowUserToAddRows = False 'quitar fila vacia
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal 'dejar solo lineas horizontales en la tabla
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None 'quitar el estilo de bodes por default de la cabezera
            'cabezera.........
            .ColumnHeadersHeight = 23
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray  'color de la cabezera
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White 'color fuente cabezera
            .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DimGray 'color de seleccion de la cabezera
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White 'color fuente cabezera seleccionada
            .EnableHeadersVisualStyles = False
            'Filas.........
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersVisible = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            .RowsDefaultCellStyle.ForeColor = Color.DimGray
            .RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen  'color de seleccion de la fila
            .RowsDefaultCellStyle.SelectionForeColor = Color.White  'color fuente fila seleccionada
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

        dgv_precios.Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_precios.Columns("id").Width = 0%
        dgv_precios.Columns("precio_defecto").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_precios.Columns("precio_defecto").Width = 0%
        dgv_precios.Columns("utilidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_precios.Columns("utilidad").Width = 100%
        dgv_precios.Columns("valor").DefaultCellStyle.Format = "C2"
        dgv_precios.Columns("valor").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_precios.Columns("valor").Width = 100%

        dgv_precios.CurrentCell = Nothing

    End Sub

    Private Function liquidar_precio(utilidad As Decimal) As String

        utilidad = (utilidad / 100) + 1

        If Variables.costo_con_iva = 1 Then
            Dim costo As Decimal = txt_costo_iva.Text
            Return costo * utilidad
        Else
            Dim costo As Decimal = txt_costo.Text
            Dim iva As Decimal = 0
            For Each row As DataRow In dt_impuestos.Rows
                iva = CDec(row("porcentaje"))
            Next
            Dim valor As Decimal = Decimal.Round(costo * utilidad, 2)
            Return Formulas_formatos.hallar_precio_con_iva(valor, iva)
        End If
        Return Nothing
    End Function

    Private Function liquidar_utilidad(precio As Decimal) As String

        If Variables.costo_con_iva = 1 Then
            Dim costo As Decimal = txt_costo_iva.Text
            Dim diferencia As Decimal = precio - costo
            Return (diferencia * 100) / costo
        Else
            Dim costo As Decimal = txt_costo.Text
            Dim iva As Decimal = 0
            For Each row As DataRow In dt_impuestos.Rows
                iva = CDec(row("porcentaje"))
            Next
            costo = CDec(Formulas_formatos.hallar_precio_con_iva(costo, iva))
            Dim diferencia As Decimal = Decimal.Round(precio - costo, 2)
            Return Decimal.Round((diferencia * 100) / costo, 2)
        End If
        Return Nothing
    End Function

    Private Sub btn_add_precios_Click(sender As Object, e As EventArgs) Handles btn_add_precios.Click
        Dim id_precio As Integer = cbx_precios.SelectedValue
        If id_precio > 0 And txt_precio.Text.Length > 0 And txt_utilidad_precio.Text.Length > 0 Then

            Dim icial As Integer = cbx_precios.Text.LastIndexOf("(") + 1
            Dim longitud As Integer = cbx_precios.Text.IndexOf(")") - icial
            Dim precio_defecto As Integer = cbx_precios.Text.Substring(icial, longitud)

            If Existe_precio_producto(id_precio) = False Then
                Adicionar_precio_dt(id_precio, precio_defecto, cbx_precios.Text, txt_utilidad_precio.Text, txt_precio.Text)
                crear_tabla_precios()
                proceso_estado("ok", $"☑ Se agrego el precio: {cbx_precios.Text}")
                cbx_precios.SelectedIndex = 0
            Else
                proceso_estado("error", $"☠ No se puede agregar, ya existe un valor para {cbx_precios.Text}")
            End If
        End If
    End Sub

    Private Sub txt_utilidad_precio_Leave(sender As Object, e As EventArgs) Handles txt_utilidad_precio.Leave
        If txt_utilidad_precio.Text.Length > 0 Then
            txt_precio.Text = liquidar_precio(txt_utilidad_precio.Text.Replace(".", ","))
            Formulas_formatos.Formato_moneda(txt_precio)
        End If
    End Sub

    Private Sub txt_precio_Leave(sender As Object, e As EventArgs) Handles txt_precio.Leave
        If txt_precio.Text.Length > 0 Then
            txt_utilidad_precio.Text = liquidar_utilidad(txt_precio.Text)
            Formulas_formatos.Formato_moneda(txt_precio)
        End If
    End Sub

    Private Sub dgv_precios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_precios.CellDoubleClick
        Try
            Dim fila As Integer = e.RowIndex
            cbx_precios.SelectedValue = dt_precios.Rows(fila)("id").ToString
            proceso_estado("ok", $"☑ Se elimino el precio: {cbx_precios.Text}")
            dt_precios.Rows(fila).Delete()
            crear_tabla_precios()
        Catch ex As Exception
        End Try
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

#Region "Procesos"

    Private Sub proceso_estado(tipo, mensaje)
        lb_proceso.Text = mensaje
        Select Case tipo
            Case "na"
                lb_proceso.BackColor = Color.DarkGray
            Case "error"
                lb_proceso.BackColor = Color.Tomato
            Case "ok"
                lb_proceso.BackColor = Color.LightSeaGreen
        End Select
    End Sub

#End Region



End Class

