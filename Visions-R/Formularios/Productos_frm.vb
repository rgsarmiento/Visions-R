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
        dt_productos = Productos_cad.Lista_completa()
        lbl_total_productos.Text = $"{dt_productos.Rows.Count - 1} Encontrados"

        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)

        panel_titulo.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)
    End Sub

    Dim dt_productos As DataTable

    Dim dt_lista_impuestos As DataTable

    Dim id_producto As Integer = 0

    Private Sub Productos_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Listar_productos_codigo()
        Listar_productos_nombre()

        Listar_marcas()
        Listar_grupos()
        Listar_tipo_unidades_medida()

        Listar_tipo_impuestos()
        Listar_tipo_precios()
        Listar_condiciones()

        nuevo()

    End Sub


#Region "Listas de seleccion"

    Private Sub Listar_productos_codigo()
        Try

            With cbx_codigo
                .DataSource = Nothing
                .DataSource = dt_productos
                .DisplayMember = "codigo"
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

    Private Sub Listar_productos_nombre()
        Try

            With cbx_nombre
                .DataSource = Nothing
                .DataSource = dt_productos
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

    Private Function Validar_controles(proceso As String) As Boolean
        Dim mensaje As String = ""
        ErrorProvider1.Clear()

        Select Case proceso
            Case "guardar"

                If cbx_codigo.Text.Length = 0 Then
                    mensaje = "☠ Debe seleccionar o escriiibir un codogo de producto"
                    ErrorProvider1.SetError(cbx_marca, mensaje)
                    proceso_estado("error", mensaje)
                    Return False
                End If

                If cbx_nombre.Text.Length = 0 Then
                    mensaje = "☠ Debe seleccionar o escriiibir un nombre de producto"
                    ErrorProvider1.SetError(cbx_marca, mensaje)
                    proceso_estado("error", mensaje)
                    Return False
                End If

            Case "actualizar"

                If cbx_codigo.SelectedValue <= 0 Then
                    mensaje = "☠ La marca es requerida"
                    ErrorProvider1.SetError(cbx_marca, mensaje)
                    proceso_estado("error", mensaje)
                    Return False
                End If

        End Select

        If cbx_marca.SelectedValue <= 0 Then
            mensaje = "☠ La marca es requerida"
            ErrorProvider1.SetError(cbx_marca, mensaje)
            proceso_estado("error", mensaje)
            Return False
        End If

        If cbx_subgrupo.SelectedValue <= 0 Then
            mensaje = "☠ El grupo es requerido"
            ErrorProvider1.SetError(cbx_subgrupo, mensaje)
            proceso_estado("error", mensaje)
            Return False
        End If

        If cbx_presentacion.SelectedValue <= 0 Then
            mensaje = "☠ La presentacion es requerida"
            ErrorProvider1.SetError(cbx_presentacion, mensaje)
            proceso_estado("error", mensaje)
            Return False
        End If

        If existe_precio_defecto() = False Then
            mensaje = "☠ Debe existir un precio por defecto (1) con un valor"
            ErrorProvider1.SetError(cbx_precios, mensaje)
            proceso_estado("error", mensaje)
            Return False
        End If

        Return True
    End Function

    Private Function existe_precio_defecto() As Boolean
        For Each row As DataRow In dt_precios.Rows
            If CInt(row("precio_defecto")) = 1 Then
                Return True
            End If
        Next
        Return False
    End Function


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

    Private Sub nuevo()

        id_producto = 0

        cbx_codigo.SelectedValue = 0
        cbx_nombre.SelectedValue = 0

        cbx_marca.SelectedValue = 0
        cbx_subgrupo.SelectedValue = 0
        cbx_presentacion.SelectedValue = 0
        cbx_condiciones.SelectedValue = 0
        cbx_precios.SelectedValue = 0
        cbx_impuestos.SelectedValue = 0

        txt_codigo_interno.Text = ""
        txt_embalaje.Text = "1"
        txt_peso.Text = "0"
        txt_existencias_maximas.Text = "0"
        txt_existencias_minimas.Text = "0"

        txt_costo.Text = "0"
        txt_costo_iva.Text = "0"
        txt_utilidad_precio.Text = ""
        txt_precio.Text = ""

        txt_notas.Text = "Notas"

        Try
            dt_impuestos.Clear()
            dt_precios.Clear()
            dt_condiciones.Clear()

            dgv_impuestos.DataSource = Nothing
            dgv_precios.DataSource = Nothing
            dgv_condiciones.DataSource = Nothing

            dgv_impuestos.Rows.Clear()
            dgv_precios.Rows.Clear()
            dgv_condiciones.Rows.Clear()

        Catch ex As Exception
        End Try

        dtp_actualizado.Value = Now
        dtp_compra.Value = Now
        dtp_venta.Value = Now

        btn_actualizar.Enabled = False
        btn_guardar.Enabled = True


        proceso_estado("na", "✎ Gestionar Productos")
        lb_proceso.BackColor = Color.DarkGray
        ErrorProvider1.Clear()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        nuevo()
    End Sub

#End Region


#Region "CRUD"

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Validar_controles("guardar") Then

            Dim obj As Producto_modelo = New Producto_modelo()

            obj.codigo = cbx_codigo.Text
            obj.codigo_interno = txt_codigo_interno.Text
            obj.nombre = cbx_nombre.Text
            obj.id_marca = cbx_marca.SelectedValue
            obj.id_subgrupo = cbx_subgrupo.SelectedValue
            obj.id_tipo_unidades_medida = cbx_presentacion.SelectedValue
            obj.embalaje = txt_embalaje.Text
            obj.existencias = 0
            obj.existencias_minimas = txt_existencias_minimas.Text
            obj.existencias_maximas = txt_existencias_maximas.Text
            obj.peso_gramos = txt_peso.Text
            obj.impuestos = de_tabla_impuestos_a_objeto_json()
            obj.precio_costo = txt_costo.Text
            obj.precio_costo_iva = txt_costo_iva.Text
            obj.precios_venta = de_tabla_precios_a_objeto_json()
            obj.condiciones = de_tabla_condiciones_a_objeto_json()
            obj.id_estado = 1
            obj.notas = txt_notas.Text

            Dim Productos_cad As Productos_cad = New Productos_cad()

            If Productos_cad.Guardar(obj) Then
                nuevo()
                proceso_estado("ok", $"☑ producto {cbx_codigo.Text} - {cbx_nombre.Text} creado correctamente")
            Else
                proceso_estado("error", $"☠ No se pudo completar el proceso en Guardar")
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Validar_controles("actualizar") Then
            Dim obj As Producto_modelo = New Producto_modelo()

            obj.id = id_producto
            obj.codigo = cbx_codigo.Text
            obj.codigo_interno = txt_codigo_interno.Text
            obj.nombre = cbx_nombre.Text
            obj.id_marca = cbx_marca.SelectedValue
            obj.id_subgrupo = cbx_subgrupo.SelectedValue
            obj.id_tipo_unidades_medida = cbx_presentacion.SelectedValue
            obj.embalaje = txt_embalaje.Text
            obj.existencias = 0
            obj.existencias_minimas = txt_existencias_minimas.Text
            obj.existencias_maximas = txt_existencias_maximas.Text
            obj.peso_gramos = txt_peso.Text
            obj.impuestos = de_tabla_impuestos_a_objeto_json()
            obj.precio_costo = txt_costo.Text
            obj.precio_costo_iva = txt_costo_iva.Text
            obj.precios_venta = de_tabla_precios_a_objeto_json()
            obj.condiciones = de_tabla_condiciones_a_objeto_json()
            obj.id_estado = 1
            obj.notas = txt_notas.Text

            Dim Productos_cad As Productos_cad = New Productos_cad()

            If Productos_cad.Actualizar(obj) Then
                nuevo()
                proceso_estado("ok", $"☑ producto {cbx_codigo.Text} - {cbx_nombre.Text} actualizado correctamente")
            Else
                proceso_estado("error", $"☠ No se pudo completar el proceso en Actualizar")
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cbx_codigo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_codigo.SelectionChangeCommitted, cbx_nombre.SelectionChangeCommitted
        Dim cbx = DirectCast(sender, ComboBox)
        Dim id As Integer = cbx.SelectedIndex
        If cbx.SelectedIndex > 0 Then
            nuevo()
            selecionar_datos_producto(id)
        End If
    End Sub

    Private Sub selecionar_datos_producto(indice As Integer)
        Dim row = dt_productos(indice)

        id_producto = row("id")

        cbx_codigo.Text = row("codigo")
        cbx_nombre.Text = row("nombre")
        cbx_marca.SelectedValue = row("id_marca")
        cbx_subgrupo.SelectedValue = row("id_subgrupo")
        cbx_presentacion.SelectedValue = row("id_tipo_unidades_medida")

        txt_codigo_interno.Text = row("codigo_interno")
        txt_embalaje.Text = row("embalaje")
        txt_peso.Text = row("peso_gramos")
        txt_existencias_minimas.Text = row("existencias_minimas")
        txt_existencias_maximas.Text = row("existencias_maximas")
        txt_notas.Text = row("notas")

        de_objeto_json_impuestos_a_tabla(row("impuestos"))
        de_objeto_json_precios_a_tabla(row("precios_venta"))
        de_objeto_json_condiciones_a_tabla(row("condiciones"))

        txt_costo.Text = row("precio_costo")
        Formulas_formatos.Formato_moneda(txt_costo)

        txt_costo_iva.Text = row("precio_costo_iva")
        Formulas_formatos.Formato_moneda(txt_costo_iva)

        dtp_actualizado.Value = row("fecha_actualizado")
        dtp_compra.Value = row("fecha_compra")
        dtp_venta.Value = row("fecha_venta")

        btn_guardar.Enabled = False
        btn_actualizar.Enabled = True

    End Sub
#End Region


#Region "de tablas a objetos json"
    Private Function de_tabla_impuestos_a_objeto_json() As String
        Dim json As New List(Of impuestos_obj)
        For Each row As DataRow In dt_impuestos.Rows
            json.Add(New impuestos_obj() With {
            .id = row("id"),
            .id_tipo_impuesto = row("id_tipo_impuesto"),
            .porcentaje = row("Porcentaje")
                       })
        Next
        Return JsonConvert.SerializeObject(json)
    End Function

    Private Function de_tabla_precios_a_objeto_json() As String
        Dim json As New List(Of Precios_obj)
        For Each row As DataRow In dt_precios.Rows
            json.Add(New Precios_obj() With {
            .id = row("id"),
            .precio_defecto = row("precio_defecto"),
            .nombre = row("nombre"),
            .utilidad = row("utilidad"),
            .valor = row("valor")
                       })
        Next
        Return JsonConvert.SerializeObject(json)
    End Function

    Private Function de_tabla_condiciones_a_objeto_json() As String
        Dim json As New List(Of Condiciones_obj)
        For Each row As DataRow In dt_condiciones.Rows
            json.Add(New Condiciones_obj() With {
            .id = row("id"),
            .nombre = row("nombre")
                       })
        Next
        Return JsonConvert.SerializeObject(json)
    End Function
#End Region


#Region "de objetos json a tablas"
    Private Function de_objeto_json_impuestos_a_tabla(impuestos_str) As DataTable

        Dim impuestos_array As JArray = JArray.Parse(impuestos_str)

        For Each jsonChildren As JObject In impuestos_array.Children(Of JObject)()
            Dim id As Integer = jsonChildren("id")
            Dim id_tipo_impuesto As Integer = jsonChildren("id_tipo_impuesto")

            Dim row_impuesto = Filtrar_datos_impuestos(id)
            Dim impuesto_nombre As String = row_impuesto("nombre")

            Dim porcentaje As String = jsonChildren("porcentaje")

            If Existe_impuesto_producto(id) = False Then
                Adicionar_impuesto_dt(id, id_tipo_impuesto, impuesto_nombre, porcentaje)
                crear_tabla_impuestos()
            End If

        Next
        Return Nothing
    End Function

    Private Sub de_objeto_json_precios_a_tabla(str_json)

        Dim array As JArray = JArray.Parse(str_json)

        For Each jsonChildren As JObject In array.Children(Of JObject)()
            Dim id As Integer = jsonChildren("id")
            Dim precio_defecto As Integer = jsonChildren("precio_defecto")
            Dim nombre As String = jsonChildren("nombre")
            Dim utilidad As Decimal = jsonChildren("utilidad")
            Dim valor As String = CStr(jsonChildren("valor"))

            If Existe_precio_producto(id) = False Then
                Adicionar_precio_dt(id, precio_defecto, nombre, utilidad, valor)
                crear_tabla_precios()
            End If

        Next

    End Sub

    Private Function de_objeto_json_condiciones_a_tabla(str_json) As DataTable

        Dim array As JArray = JArray.Parse(str_json)

        For Each jsonChildren As JObject In array.Children(Of JObject)()
            Dim id As Integer = jsonChildren("id")
            Dim nombre As String = jsonChildren("nombre")

            If Existe_condicion(id) = False Then
                Adicionar_condicion_dt(id, nombre)
                crear_tabla_condiciones()
            End If

        Next
        Return Nothing
    End Function


#End Region


#Region "Eventos del teclado"
    Private Sub txt_codigo_interno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo_interno.KeyPress, txt_peso.KeyPress, txt_embalaje.KeyPress, txt_existencias_minimas.KeyPress, txt_existencias_maximas.KeyPress,
            txt_costo.KeyPress, txt_costo_iva.KeyPress, txt_utilidad_precio.KeyPress, txt_precio.KeyPress, txt_notas.KeyPress

        Dim txt = DirectCast(sender, TextBox)

        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

        'validar q se ingresen solo numeros
        If txt.Name = "txt_peso" Or txt.Name = "txt_embalaje" Or txt.Name = "txt_existencias_maximas" Or
            txt.Name = "txt_existencias_minimas" Or txt.Name = "txt_costo" Or txt.Name = "txt_utilidad_precio" Or txt.Name = "txt_precio" Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If

    End Sub

    Private Sub cbx_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbx_codigo.KeyDown, cbx_condiciones.KeyDown, cbx_impuestos.KeyDown, cbx_marca.KeyDown,
            cbx_nombre.KeyDown, cbx_precios.KeyDown, cbx_presentacion.KeyDown, cbx_subgrupo.KeyDown

        Dim a As String = e.KeyCode
        If a = "13" Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

#End Region






End Class

