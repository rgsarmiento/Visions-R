Imports System.Runtime.InteropServices

Public Class Seguridad_frm
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

#Region "CRUD"


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If Validar_controles() Then
            proceso_estado("na", "✎ Guardando Seguridad")

            Dim obj_seguridad As Seguridad_modelo = New Seguridad_modelo()

            obj_seguridad.clave = txt_clave_acceso.Text
            obj_seguridad.nombre_usuario = txt_usuario_acceso.Text
            obj_seguridad.id_usuario = id_usuario
            obj_seguridad.id_perfil = cb_perfil.SelectedValue
            obj_seguridad.estado = check_activo.Checked

            Dim Seguridad_cad As Seguridad_cad = New Seguridad_cad()

            If Seguridad_cad.Guardar(obj_seguridad) Then
                Cargar_data()
                nuevo()
                proceso_estado("ok", $"☑ Acceso {txt_usuario_acceso.Text} creado correctamente")
            Else
                proceso_estado("error", $"☠ No se pudo completar el proceso en Guardar")
            End If

        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If Validar_controles() Then
            proceso_estado("na", "⚡ Actualizando Seguridad")

            Dim obj_seguridad As Seguridad_modelo = New Seguridad_modelo()

            obj_seguridad.id = id_seguridad
            obj_seguridad.clave = txt_clave_acceso.Text
            obj_seguridad.nombre_usuario = txt_usuario_acceso.Text
            obj_seguridad.id_usuario = id_usuario
            obj_seguridad.id_perfil = cb_perfil.SelectedValue
            obj_seguridad.estado = check_activo.Checked

            Dim Seguridad_cad As Seguridad_cad = New Seguridad_cad()

            If Seguridad_cad.Actualizar(obj_seguridad) Then
                Cargar_data()
                nuevo()
                proceso_estado("ok", $"☑ Acceso {txt_usuario_acceso.Text} actualizado correctamente")
            Else
                proceso_estado("error", $"☠ No se pudo completar el proceso en Actualizar")
            End If

        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
#End Region



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Usuarios_frm As New Usuarios_frm
        Usuarios_frm.ShowDialog()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None

        Dim usuarios_cad As Usuarios_cad = New Usuarios_cad()
        dt_usuarios = New DataTable
        dt_usuarios = usuarios_cad.Listar("u")

        Listar_perfiles()
    End Sub

    Private Sub Seguridad_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_data()
        nuevo()
    End Sub


    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        nuevo()
    End Sub

    Private Sub Listar_perfiles()
        Try
            Dim perfiles_cad As Perfiles_cad = New Perfiles_cad()

            With cb_perfil
                .DataSource = Nothing
                .DataSource = Perfiles_cad.Listar()
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub nuevo()
        cb_usuarios.Text = ""
        id_usuario = 0
        id_seguridad = 0
        lbx_usuarios.Visible = False
        txt_clave_acceso.Text = ""
        txt_usuario_acceso.Text = ""
        dgv_data.CurrentCell = Nothing
        cb_perfil.SelectedItem = 1
        btn_actualizar.Visible = False
        btn_guardar.Visible = True
        check_activo.Checked = False
        lb_proceso.Text = "✎ Gestionar Seguridad"
        lb_proceso.BackColor = Color.DarkGray
    End Sub

    Private Function Validar_controles() As Boolean

        Dim mensaje As String = ""
        ErrorProvider1.Clear()

        If id_usuario = 0 Then
            mensaje = "☠ No ha seleccionado un usuario valido"
            ErrorProvider1.SetError(cb_usuarios, mensaje)
            proceso_estado("error", mensaje)
            Return False
        End If

        If txt_usuario_acceso.Text.Length = 0 Then
            mensaje = "☠ Usuario acceso es requerido"
            ErrorProvider1.SetError(txt_usuario_acceso, mensaje)
            proceso_estado("error", mensaje)
            Return False
        End If

        If txt_clave_acceso.Text.Length = 0 Then
            mensaje = "☠ Clave acceso es requerido"
            ErrorProvider1.SetError(txt_clave_acceso, mensaje)
            proceso_estado("error", mensaje)
            Return False
        End If

        Return True
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



    Private Sub txt_usuario_acceso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario_acceso.KeyPress, txt_clave_acceso.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub cb_perfil_KeyDown(sender As Object, e As KeyEventArgs) Handles cb_perfil.KeyDown
        Dim a As String = e.KeyCode
        If a = "13" Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

#Region "listar y seleccionar usuarios"
    Dim dt_usuarios As DataTable
    Dim dt_lista_buscador As New DataTable
    Dim renglon_buscador As DataRow

    Sub lista_usuarios(id As Integer, buscador As String)
        If dt_lista_buscador.Columns.Contains("id") Then
            'ha encontrado la columna no se hace nada
        Else
            dt_lista_buscador.Columns.Add("id")
            dt_lista_buscador.Columns.Add("buscador")
        End If

        renglon_buscador = dt_lista_buscador.NewRow
        renglon_buscador("id") = id
        renglon_buscador("buscador") = buscador

        dt_lista_buscador.Rows.Add(renglon_buscador)

    End Sub

    Private Sub cb_usuarios_KeyUp(sender As Object, e As KeyEventArgs) Handles cb_usuarios.KeyUp
        id_usuario = 0
        If cb_usuarios.Text.Length > 0 Then
            Dim filas() As DataRow
            filas = dt_usuarios.Select("buscador LIKE '%" & cb_usuarios.Text & "%'")

            Me.lbx_usuarios.DataSource = Nothing
            dt_lista_buscador.Clear()

            If filas.Length > 0 Then
                lbx_usuarios.Visible = True

                For Each dr As DataRow In filas
                    lista_usuarios(dr("id").ToString, dr("buscador").ToString)
                Next

                With lbx_usuarios
                    .DataSource = dt_lista_buscador
                    .DisplayMember = "buscador"
                    .ValueMember = "id"
                End With

                lbx_usuarios.Visible = True
                lbx_usuarios.ClearSelected()

            Else
                lbx_usuarios.Visible = False

            End If

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
            id_usuario = id
            lbx_usuarios.Visible = False
            Me.lbx_usuarios.DataSource = Nothing
        Catch ex As Exception

        End Try


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
        Mostrar_todos_usuarios()
    End Sub

    Private Sub Mostrar_todos_usuarios()
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
                lista_usuarios(dr("id").ToString, dr("buscador").ToString)
            Next

            With lbx_usuarios
                .DataSource = dt_lista_buscador
                .DisplayMember = "buscador"
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

    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseClick
        Mostrar_todos_usuarios()
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

#Region "Estilos, datos  y funciones del datagridview"

    Private Sub Cargar_data()

        Dim seguridad_cad As Seguridad_cad = New Seguridad_cad()

        With Me.dgv_data
            .DataSource = Nothing
            .DataSource = Seguridad_cad.Seleccionar()
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
            .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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


        dgv_data.Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_data.Columns("id").Width = 0%
        dgv_data.Columns("id_usuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_data.Columns("id_usuario").Width = 0%
        dgv_data.Columns("select_usuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_data.Columns("select_usuario").Width = 0%
        dgv_data.Columns("Estado").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_data.Columns("Estado").Width = 80%

    End Sub

    Private id_usuario As Integer = 0
    Private id_seguridad As Integer = 0
    Private Sub dgv_data_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data.CellClick
        Dim fila As Integer = e.RowIndex
        If fila < 0 Then
            Exit Sub
        End If

        Dim dgv = DirectCast(sender, DataGridView)
        id_seguridad = dgv.Rows(fila).Cells("id").Value
        txt_usuario_acceso.Text = dgv.Rows(fila).Cells("Usuario_Acceso").Value
        txt_clave_acceso.Text = dgv.Rows(fila).Cells("Clave").Value
        check_activo.Checked = dgv.Rows(fila).Cells("Estado").Value
        cb_usuarios.Text = dgv.Rows(fila).Cells("select_usuario").Value
        id_usuario = dgv.Rows(fila).Cells("id_usuario").Value

        btn_actualizar.Visible = True
        btn_guardar.Visible = False
    End Sub




#End Region

End Class
