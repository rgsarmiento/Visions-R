Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions


Public Class Usuarios_frm

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

    Private id_usuario As Integer = 0

    Public Sub New()
        InitializeComponent()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)

        panel_titulo.BackColor = Color.FromArgb(Variables.color_form_r, Variables.color_form_g, Variables.color_form_b)
    End Sub

    Private Sub Usuarios_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_tipo_documento()
        Listar_tipo_organizacion()
        Listar_tipo_regimen()
        Listar_tipo_responsabilidad()
        Listar_paises()


        Dim usuarios_cad As Usuarios_cad = New Usuarios_cad()
        dt_usuarios = New DataTable
        dt_usuarios = Usuarios_cad.Listar("")
    End Sub

#Region "Listas de seleccion"

    Private Sub Listar_tipo_documento()
        Try

            With cbx_tipo_documento
                .DataSource = Nothing
                .DataSource = Tipo_documentos_identificaciones_cad.Listar()
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

    Private Sub Listar_tipo_organizacion()
        Try

            With cbx_tipo_organizacion
                .DataSource = Nothing
                .DataSource = Tipo_organizaciones_cad.Listar()
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

    Private Sub Listar_tipo_regimen()
        Try

            With cbx_tipo_regimen
                .DataSource = Nothing
                .DataSource = Tipo_regimenes_cad.Listar()
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

    Private Sub Listar_tipo_responsabilidad()
        Try

            With cbx_tipo_responsabilidad
                .DataSource = Nothing
                .DataSource = Tipo_responsabilidades_cad.Listar()
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

    Private Sub Listar_paises()
        Try

            With cbx_paises
                .DataSource = Nothing
                .DataSource = Paises_cad.Listar()
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

    Private Sub cbx_paises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_paises.SelectedIndexChanged
        Try
            Dim cbx = DirectCast(sender, ComboBox)

            If cbx.SelectedValue > 0 Then
                Dim id_pais As Integer = cbx.SelectedValue

                With cbx_departamentos
                    .DataSource = Nothing
                    .DataSource = Departamentos_cad.Listar(id_pais)
                    .DisplayMember = "nombre"
                    .ValueMember = "id"
                    .DropDownStyle = ComboBoxStyle.DropDown
                    .AutoCompleteMode = AutoCompleteMode.Suggest
                    .AutoCompleteSource = AutoCompleteSource.ListItems
                    .FlatStyle = FlatStyle.Standard
                    .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                    .ForeColor = Color.White
                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbx_departamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_departamentos.SelectedIndexChanged
        Try
            Dim cbx = DirectCast(sender, ComboBox)

            If cbx.SelectedValue > 0 Then
                Dim id_departamentos As Integer = cbx.SelectedValue

                With cbx_municipios
                    .DataSource = Nothing
                    .DataSource = Municipios_cad.Listar(id_departamentos)
                    .DisplayMember = "nombre"
                    .ValueMember = "id"
                    .DropDownStyle = ComboBoxStyle.DropDown
                    .AutoCompleteMode = AutoCompleteMode.Suggest
                    .AutoCompleteSource = AutoCompleteSource.ListItems
                    .FlatStyle = FlatStyle.Standard
                    .BackColor = Color.FromArgb(Variables.color_cbx_r, Variables.color_cbx_g, Variables.color_cbx_b)
                    .ForeColor = Color.White
                End With
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region


#Region "Validaciones"
    Private Function Validar_controles(Optional enviar_error = 0) As Boolean

        Dim mensaje As String = ""
        ErrorProvider1.Clear()

        If enviar_error = 0 Then

            If cbx_tipo_documento.SelectedValue <= 0 Then
                mensaje = "☠ El tipo de documento es requerido"
                ErrorProvider1.SetError(cbx_tipo_documento, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If txt_numero_documento.Text.Length = 0 Then
                mensaje = "☠ Se requiere un numero de documento"
                ErrorProvider1.SetError(txt_numero_documento, mensaje)
                proceso_estado("error", mensaje)
                Return False
            ElseIf txt_numero_documento.Text.Length > 15 Then
                mensaje = "☠ El numero de documento debe estar en 1 y 15 digitos"
                ErrorProvider1.SetError(txt_numero_documento, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If txt_dv.Text.Length = 0 Then
                mensaje = "☠ Se requiere un digito de verificacion"
                ErrorProvider1.SetError(txt_dv, mensaje)
                proceso_estado("error", mensaje)
                Return False
            ElseIf txt_dv.Text.Length > 1 Then
                mensaje = "☠ El digito de verificacion debe ser de 1 digito"
                ErrorProvider1.SetError(txt_dv, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If cbx_tipo_organizacion.SelectedValue <= 0 Then
                mensaje = "☠ El tipo de organizacion es requerido"
                ErrorProvider1.SetError(cbx_tipo_organizacion, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If cbx_tipo_regimen.SelectedValue <= 0 Then
                mensaje = "☠ El tipo de regimen es requerido"
                ErrorProvider1.SetError(cbx_tipo_regimen, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If cbx_tipo_responsabilidad.SelectedValue <= 0 Then
                mensaje = "☠ El tipo de responsabilidad es requerido"
                ErrorProvider1.SetError(cbx_tipo_responsabilidad, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If txt_primer_nombre.Text.Length = 0 Then
                mensaje = "☠ El primer nombre es obligatorio"
                ErrorProvider1.SetError(txt_primer_nombre, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If txt_primer_apellido.Text.Length = 0 Then
                mensaje = "☠ El primer apellido es obligatorio"
                ErrorProvider1.SetError(txt_primer_apellido, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If txt_direccion.Text.Length = 0 Then
                mensaje = "☠ La direccion es obligatoria"
                ErrorProvider1.SetError(txt_direccion, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If txt_primer_apellido.Text.Length = 0 Then
                mensaje = "☠ El primer apellido es obligatorio"
                ErrorProvider1.SetError(txt_primer_apellido, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If txt_telefono.Text.Length = 0 Then
                mensaje = "☠ El telefono es obligatorio"
                ErrorProvider1.SetError(txt_telefono, mensaje)
                proceso_estado("error", mensaje)
                Return False
            ElseIf txt_telefono.Text.Length < 7 Or txt_telefono.Text.Length > 10 Then
                mensaje = "☠ El telefono debe estar entre 7 y 10 digitos"
                ErrorProvider1.SetError(txt_telefono, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

            If check_cliente.Checked = True Then
                If txt_email.Text.Length = 0 Then
                    mensaje = "☠ El email es obligatorio"
                    ErrorProvider1.SetError(txt_email, mensaje)
                    proceso_estado("error", mensaje)
                    Return False
                ElseIf IsValidEmail(txt_email.Text) = False Then
                    mensaje = "☠ El formato del email no es correcto 'visions@example.com'"
                    ErrorProvider1.SetError(txt_email, mensaje)
                    proceso_estado("error", mensaje)
                    Return False
                End If
            End If

            If cbx_municipios.SelectedValue <= 0 Then
                mensaje = "☠ La ciudad es obligatoria"
                ErrorProvider1.SetError(cbx_municipios, mensaje)
                proceso_estado("error", mensaje)
                Return False
            End If

        End If


        Select Case enviar_error
            Case 1 'enviar error numero de documento o email repetido
                ErrorProvider1.SetError(txt_numero_documento, $"☠ Es probable que el numero de documento {txt_numero_documento.Text } ya exista")
                ErrorProvider1.SetError(txt_email, $"☠ Es probable que el E-mail {txt_email.Text } ya exista")
                Return False
        End Select

        Return True
    End Function

    Private Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Private Sub check_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles check_cliente.CheckedChanged

        If check_cliente.Checked = True Then
            txt_email.BackColor = Color.FloralWhite
        Else
            txt_email.BackColor = Color.White
        End If

    End Sub


    Private Sub ocultar_mostrar_controles(proceso)
        btn_guardar.Visible = True
        btn_actualizar.Visible = True
        btn_nuevo.Visible = True

        Select Case proceso
            Case 1 'usuario seleccionado
                btn_guardar.Visible = False
            Case 2 'se hace click en nuevo 
                btn_actualizar.Visible = False
        End Select
    End Sub

#End Region



#Region "listar y seleccionar usuarios"
    Dim dt_usuarios As DataTable
    Dim dt_lista_buscador As New DataTable
    Dim renglon_buscador As DataRow

    Sub lista_usuarios(id As Integer, nombre As String, buscador As String)
        If dt_lista_buscador.Columns.Contains("id") Then
            'ha encontrado la columna no se hace nada
        Else
            dt_lista_buscador.Columns.Add("id")
            dt_lista_buscador.Columns.Add("nombre")
            dt_lista_buscador.Columns.Add("buscador")
        End If

        renglon_buscador = dt_lista_buscador.NewRow
        renglon_buscador("id") = id
        renglon_buscador("nombre") = nombre
        renglon_buscador("buscador") = buscador

        dt_lista_buscador.Rows.Add(renglon_buscador)

    End Sub

    Private Sub Filtrar(texto As String)
        Dim filas() As DataRow
        filas = dt_usuarios.Select("buscador LIKE '%" & texto & "%'")

        Me.lbx_usuarios.DataSource = Nothing
        dt_lista_buscador.Clear()

        If filas.Length > 0 Then
            proceso_estado("ok", $"☞ Se encontraron ({filas.Length}) coincidencias")
            lbx_usuarios.Visible = True

            For Each dr As DataRow In filas
                lista_usuarios(dr("id").ToString, dr("nombre").ToString, dr("buscador").ToString)
            Next

            With lbx_usuarios
                .DataSource = dt_lista_buscador
                .DisplayMember = "nombre"
                .ValueMember = "id"
            End With

            lbx_usuarios.Visible = True
            lbx_usuarios.ClearSelected()
        Else
            lbx_usuarios.Visible = False
        End If
    End Sub

    Private Sub cb_usuarios_KeyUp(sender As Object, e As KeyEventArgs) Handles cb_usuarios.KeyUp
        id_usuario = 0
        If cb_usuarios.Text.Length > 0 Then

            Filtrar(cb_usuarios.Text)

            Select Case e.KeyData
                Case Keys.Enter
                    lbx_usuarios.Focus()
                Case Keys.Down
                    lbx_usuarios.Focus()
                Case Keys.Escape
                    cb_usuarios.Text = ""
                    id_usuario = 0
                    lbx_usuarios.Visible = False
                    Me.lbx_usuarios.DataSource = Nothing
            End Select

        Else
            lbx_usuarios.Visible = False
            Me.lbx_usuarios.DataSource = Nothing
        End If
    End Sub

    Private Sub opcion_seleccionada()
        Try
            Dim select_item As String = lbx_usuarios.GetItemText(lbx_usuarios.SelectedItem)

            Dim indice As Integer = select_item.IndexOf("|")
            Dim largo As Integer = select_item.Length

            Dim id As Integer = lbx_usuarios.SelectedValue
            Dim numero As String = select_item.Substring(0, indice).Trim
            Dim nombre As String = select_item.Substring(indice, largo - indice).Trim.Replace("| ", "")

            cb_usuarios.Text = select_item

            lbx_usuarios.Visible = False
            Me.lbx_usuarios.DataSource = Nothing

            Buscar_usuario(id)
            ocultar_mostrar_controles(1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Buscar_usuario(id As Integer)

        Dim usuarios_cad As Usuarios_cad = New Usuarios_cad

        Dim objeto = Usuarios_cad.Seleccionar(id)
        If objeto IsNot Nothing Then

            nuevo()

            id_usuario = objeto.Id
            txt_primer_apellido.Text = objeto.Apellido_1
            txt_segundo_apellido.Text = objeto.Apellido_2
            check_cliente.Checked = objeto.Cliente
            txt_email.Text = objeto.Correo
            txt_direccion.Text = objeto.Direccion
            txt_dv.Text = objeto.Dv
            cbx_paises.SelectedValue = objeto.Id_pais
            cbx_departamentos.SelectedValue = objeto.Id_departamento
            cbx_municipios.SelectedValue = objeto.Id_municipio
            cbx_tipo_documento.SelectedValue = objeto.Id_tipo_documento_identificacion
            cbx_tipo_organizacion.SelectedValue = objeto.Id_tipo_organizacion
            cbx_tipo_regimen.SelectedValue = objeto.Id_tipo_regimen
            cbx_tipo_responsabilidad.SelectedValue = objeto.Id_tipo_responsabilidad
            txt_primer_nombre.Text = objeto.Nombre_1
            txt_segundo_nombre.Text = objeto.Nombre_2
            txt_numero_documento.Text = objeto.Numero_identificacion
            check_otro.Checked = objeto.Otro
            check_proveedor.Checked = objeto.Proveedor
            txt_telefono.Text = objeto.Telefono
            check_usuario_programa.Checked = objeto.Usuario_visions
            check_vendedor.Checked = objeto.Vendedor
            check_activo.Checked = objeto.Estado


            proceso_estado("ok", $"▼ Usuario ({id_usuario}) - {txt_numero_documento.Text} {txt_primer_nombre.Text} {txt_primer_apellido.Text} seleccionado")
        End If

    End Sub


    Private Sub lbx_usuarios_KeyUp(sender As Object, e As KeyEventArgs) Handles lbx_usuarios.KeyUp
        Select Case e.KeyData
            Case Keys.Enter
                opcion_seleccionada()
            Case Keys.Escape
                cb_usuarios.Text = ""
                lbx_usuarios.Visible = False
                Me.lbx_usuarios.DataSource = Nothing
        End Select
    End Sub

    Private Sub lbx_usuarios_MouseClick(sender As Object, e As MouseEventArgs) Handles lbx_usuarios.MouseClick
        opcion_seleccionada()
    End Sub

    Private Sub cb_usuarios_MouseClick(sender As Object, e As MouseEventArgs) Handles cb_usuarios.MouseClick
        Mostrar_usuarios()
    End Sub

    Private Sub Mostrar_usuarios()
        Dim filas() As DataRow

        If cb_usuarios.Text.Length > 0 Then
            filas = dt_usuarios.Select("buscador LIKE '%" & cb_usuarios.Text & "%'")
        Else
            filas = dt_usuarios.Select()
        End If

        Me.lbx_usuarios.DataSource = Nothing
        dt_lista_buscador.Clear()

        If filas.Length > 0 Then
            lbx_usuarios.Visible = True

            For Each dr As DataRow In filas
                lista_usuarios(dr("id").ToString, dr("nombre").ToString, dr("buscador").ToString)
            Next

            With lbx_usuarios
                .DataSource = dt_lista_buscador
                .DisplayMember = "nombre"
                .ValueMember = "id"
            End With

            lbx_usuarios.Visible = True
            lbx_usuarios.ClearSelected()

        Else
            lbx_usuarios.Visible = False

        End If
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        lbx_usuarios.Visible = False
    End Sub

    Private Sub lb_seleccionar_usuarios_MouseClick(sender As Object, e As MouseEventArgs) Handles lb_seleccionar_usuarios.MouseClick
        cb_usuarios.Text = ""
        If lbx_usuarios.Visible Then
            lbx_usuarios.Visible = False
        Else
            Mostrar_usuarios()
        End If
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

    Private Sub nuevo()
        txt_numero_documento.Text = ""
        id_usuario = 0
        cb_usuarios.Text = ""
        lbx_usuarios.Visible = False

        txt_segundo_nombre.Text = ""
        txt_primer_nombre.Text = ""
        txt_primer_apellido.Text = ""
        txt_segundo_apellido.Text = ""
        txt_telefono.Text = ""
        txt_direccion.Text = ""
        txt_email.Text = ""

        cbx_tipo_documento.SelectedIndex = 0
        cbx_tipo_organizacion.SelectedIndex = 0
        cbx_tipo_regimen.SelectedIndex = 0
        cbx_tipo_responsabilidad.SelectedIndex = 0

        Try
            cbx_paises.SelectedIndex = 0
            cbx_departamentos.Items.Clear()
            cbx_municipios.Items.Clear()
        Catch ex As Exception

        End Try


        ocultar_mostrar_controles(2)

        check_cliente.Checked = False
        check_otro.Checked = False
        check_proveedor.Checked = False
        check_usuario_programa.Checked = False
        check_vendedor.Checked = False

        check_activo.Checked = True

        proceso_estado("na", "✎ Gestionar Usuarios")
        lb_proceso.BackColor = Color.DarkGray
        ErrorProvider1.Clear()
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


#Region "eventos del teclado"
    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dv.KeyPress, txt_primer_nombre.KeyPress, txt_segundo_nombre.KeyPress, txt_primer_apellido.KeyPress, txt_segundo_apellido.KeyPress, txt_direccion.KeyPress, txt_telefono.KeyPress, txt_email.KeyPress, txt_numero_documento.KeyPress
        Dim txt = DirectCast(sender, TextBox)

        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

        'validar q se ingresen solo numeros
        If txt.Name = "txt_telefono" Or txt.Name = "txt_dv" Or txt.Name = "txt_numero_documento" Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
        lbx_usuarios.Visible = False
    End Sub

    Private Sub cbx_KeyDown(sender As Object, e As KeyEventArgs) Handles cbx_tipo_documento.KeyDown, cbx_tipo_organizacion.KeyDown, cbx_tipo_regimen.KeyDown, cbx_tipo_responsabilidad.KeyDown, cbx_paises.KeyDown, cbx_departamentos.KeyDown, cbx_municipios.KeyDown
        Dim a As String = e.KeyCode
        If a = "13" Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
        lbx_usuarios.Visible = False
    End Sub

    Private Sub txt_numero_documento_Leave(sender As Object, e As EventArgs) Handles txt_numero_documento.Leave
        If txt_numero_documento.TextLength > 5 Then
            Filtrar(txt_numero_documento.Text)
            txt_dv.Text = Usuarios_funciones.CalcularDigito(txt_numero_documento.Text)
        End If
    End Sub
#End Region


#Region "CRUD"
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If Validar_controles() Then
            proceso_estado("na", "✎ Guardando Usuario")

            Dim objeto As Usuario_modelo = New Usuario_modelo()

            objeto.Apellido_1 = txt_primer_apellido.Text.ToUpper
            objeto.Apellido_2 = txt_segundo_apellido.Text.ToUpper
            objeto.Cliente = check_cliente.Checked
            objeto.Correo = txt_email.Text.ToLower
            objeto.Direccion = txt_direccion.Text
            objeto.Dv = txt_dv.Text
            objeto.Id_departamento = cbx_departamentos.SelectedValue
            objeto.Id_municipio = cbx_municipios.SelectedValue
            objeto.Id_pais = cbx_paises.SelectedValue
            objeto.Id_tipo_documento_identificacion = cbx_tipo_documento.SelectedValue
            objeto.Id_tipo_organizacion = cbx_tipo_organizacion.SelectedValue
            objeto.Id_tipo_regimen = cbx_tipo_regimen.SelectedValue
            objeto.Id_tipo_responsabilidad = cbx_tipo_responsabilidad.SelectedValue
            objeto.Nombre_1 = txt_primer_nombre.Text.ToUpper
            objeto.Nombre_2 = txt_segundo_nombre.Text.ToUpper
            objeto.Numero_identificacion = txt_numero_documento.Text
            objeto.Otro = check_otro.Checked
            objeto.Proveedor = check_proveedor.Checked
            objeto.Telefono = txt_telefono.Text
            objeto.Usuario_visions = check_usuario_programa.Checked
            objeto.Vendedor = check_vendedor.Checked
            objeto.Estado = check_activo.Checked

            Dim Usuarios_cad As Usuarios_cad = New Usuarios_cad()

            If Usuarios_cad.Guardar(objeto) Then
                proceso_estado("ok", $"☑ El usuario {txt_numero_documento.Text} {txt_primer_nombre.Text} {txt_primer_apellido.Text} creado correctamente")
                nuevo()
                Usuarios_cad = New Usuarios_cad()
                dt_usuarios = New DataTable
                dt_usuarios = Usuarios_cad.Listar("")
            Else
                Validar_controles(1)
                proceso_estado("error", $"☠ No se pudo Guardar el Usuario")
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        nuevo()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If Validar_controles() Then
            proceso_estado("na", "✎ Actualizando Usuario")

            Dim objeto As Usuario_modelo = New Usuario_modelo()

            objeto.Id = id_usuario
            objeto.Apellido_1 = txt_primer_apellido.Text.ToUpper
            objeto.Apellido_2 = txt_segundo_apellido.Text.ToUpper
            objeto.Cliente = check_cliente.Checked
            objeto.Correo = txt_email.Text.ToLower
            objeto.Direccion = txt_direccion.Text
            objeto.Dv = txt_dv.Text
            objeto.Id_departamento = cbx_departamentos.SelectedValue
            objeto.Id_municipio = cbx_municipios.SelectedValue
            objeto.Id_pais = cbx_paises.SelectedValue
            objeto.Id_tipo_documento_identificacion = cbx_tipo_documento.SelectedValue
            objeto.Id_tipo_organizacion = cbx_tipo_organizacion.SelectedValue
            objeto.Id_tipo_regimen = cbx_tipo_regimen.SelectedValue
            objeto.Id_tipo_responsabilidad = cbx_tipo_responsabilidad.SelectedValue
            objeto.Nombre_1 = txt_primer_nombre.Text.ToUpper
            objeto.Nombre_2 = txt_segundo_nombre.Text.ToUpper
            objeto.Numero_identificacion = txt_numero_documento.Text
            objeto.Otro = check_otro.Checked
            objeto.Proveedor = check_proveedor.Checked
            objeto.Telefono = txt_telefono.Text
            objeto.Usuario_visions = check_usuario_programa.Checked
            objeto.Vendedor = check_vendedor.Checked
            objeto.Estado = check_activo.Checked

            Dim Usuarios_cad As Usuarios_cad = New Usuarios_cad()

            If Usuarios_cad.Actualizar(objeto) Then
                proceso_estado("ok", $"☑ El usuario {txt_numero_documento.Text} {txt_primer_nombre.Text} {txt_primer_apellido.Text} se Actualizo correctamente")
                nuevo()
                Usuarios_cad = New Usuarios_cad()
                dt_usuarios = New DataTable
                dt_usuarios = Usuarios_cad.Listar("")
            Else
                Validar_controles(1)
                proceso_estado("error", $"☠ No se pudo Actualizar el Usuario")
            End If

        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

#End Region




End Class