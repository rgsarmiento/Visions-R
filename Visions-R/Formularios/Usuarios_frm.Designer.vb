<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios_frm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_numero_documento = New System.Windows.Forms.TextBox()
        Me.lb_seleccionar_usuarios = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbx_usuarios = New System.Windows.Forms.ListBox()
        Me.cb_usuarios = New System.Windows.Forms.TextBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.check_activo = New System.Windows.Forms.CheckBox()
        Me.cbx_municipios = New System.Windows.Forms.ComboBox()
        Me.cbx_departamentos = New System.Windows.Forms.ComboBox()
        Me.cbx_paises = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_segundo_apellido = New System.Windows.Forms.TextBox()
        Me.txt_primer_apellido = New System.Windows.Forms.TextBox()
        Me.txt_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.txt_primer_nombre = New System.Windows.Forms.TextBox()
        Me.cbx_tipo_responsabilidad = New System.Windows.Forms.ComboBox()
        Me.cbx_tipo_regimen = New System.Windows.Forms.ComboBox()
        Me.cbx_tipo_organizacion = New System.Windows.Forms.ComboBox()
        Me.cbx_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.txt_dv = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.check_otro = New System.Windows.Forms.CheckBox()
        Me.check_vendedor = New System.Windows.Forms.CheckBox()
        Me.check_usuario_programa = New System.Windows.Forms.CheckBox()
        Me.check_proveedor = New System.Windows.Forms.CheckBox()
        Me.check_cliente = New System.Windows.Forms.CheckBox()
        Me.panel_procesos = New System.Windows.Forms.Panel()
        Me.lb_proceso = New System.Windows.Forms.Label()
        Me.panel_titulo = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.panel_procesos.SuspendLayout()
        Me.panel_titulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_numero_documento)
        Me.Panel1.Controls.Add(Me.lb_seleccionar_usuarios)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lbx_usuarios)
        Me.Panel1.Controls.Add(Me.cb_usuarios)
        Me.Panel1.Controls.Add(Me.btn_actualizar)
        Me.Panel1.Controls.Add(Me.btn_nuevo)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Controls.Add(Me.check_activo)
        Me.Panel1.Controls.Add(Me.cbx_municipios)
        Me.Panel1.Controls.Add(Me.cbx_departamentos)
        Me.Panel1.Controls.Add(Me.cbx_paises)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_telefono)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_direccion)
        Me.Panel1.Controls.Add(Me.txt_segundo_apellido)
        Me.Panel1.Controls.Add(Me.txt_primer_apellido)
        Me.Panel1.Controls.Add(Me.txt_segundo_nombre)
        Me.Panel1.Controls.Add(Me.txt_primer_nombre)
        Me.Panel1.Controls.Add(Me.cbx_tipo_responsabilidad)
        Me.Panel1.Controls.Add(Me.cbx_tipo_regimen)
        Me.Panel1.Controls.Add(Me.cbx_tipo_organizacion)
        Me.Panel1.Controls.Add(Me.cbx_tipo_documento)
        Me.Panel1.Controls.Add(Me.txt_dv)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.check_otro)
        Me.Panel1.Controls.Add(Me.check_vendedor)
        Me.Panel1.Controls.Add(Me.check_usuario_programa)
        Me.Panel1.Controls.Add(Me.check_proveedor)
        Me.Panel1.Controls.Add(Me.check_cliente)
        Me.Panel1.Controls.Add(Me.panel_procesos)
        Me.Panel1.Controls.Add(Me.panel_titulo)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 515)
        Me.Panel1.TabIndex = 0
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_documento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_numero_documento.Location = New System.Drawing.Point(11, 171)
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(212, 29)
        Me.txt_numero_documento.TabIndex = 7
        '
        'lb_seleccionar_usuarios
        '
        Me.lb_seleccionar_usuarios.AutoSize = True
        Me.lb_seleccionar_usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_seleccionar_usuarios.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_seleccionar_usuarios.ForeColor = System.Drawing.Color.CadetBlue
        Me.lb_seleccionar_usuarios.Location = New System.Drawing.Point(1041, 91)
        Me.lb_seleccionar_usuarios.Name = "lb_seleccionar_usuarios"
        Me.lb_seleccionar_usuarios.Size = New System.Drawing.Size(21, 19)
        Me.lb_seleccionar_usuarios.TabIndex = 50
        Me.lb_seleccionar_usuarios.Text = "▼"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(521, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 21)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Buscar"
        '
        'lbx_usuarios
        '
        Me.lbx_usuarios.BackColor = System.Drawing.Color.Lavender
        Me.lbx_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbx_usuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbx_usuarios.FormattingEnabled = True
        Me.lbx_usuarios.ItemHeight = 21
        Me.lbx_usuarios.Location = New System.Drawing.Point(580, 116)
        Me.lbx_usuarios.Name = "lbx_usuarios"
        Me.lbx_usuarios.Size = New System.Drawing.Size(486, 86)
        Me.lbx_usuarios.TabIndex = 48
        Me.lbx_usuarios.Visible = False
        '
        'cb_usuarios
        '
        Me.cb_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cb_usuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_usuarios.Location = New System.Drawing.Point(580, 87)
        Me.cb_usuarios.Name = "cb_usuarios"
        Me.cb_usuarios.Size = New System.Drawing.Size(486, 29)
        Me.cb_usuarios.TabIndex = 47
        '
        'btn_actualizar
        '
        Me.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_actualizar.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_actualizar.Image = Global.Visions_R.My.Resources.Resources.update_30px
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(683, 434)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(122, 39)
        Me.btn_actualizar.TabIndex = 24
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = True
        Me.btn_actualizar.Visible = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Gold
        Me.btn_nuevo.Image = Global.Visions_R.My.Resources.Resources.broom_30px
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.Location = New System.Drawing.Point(816, 434)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(122, 39)
        Me.btn_nuevo.TabIndex = 23
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_guardar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_guardar.Image = Global.Visions_R.My.Resources.Resources.save_30px
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(944, 434)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(122, 39)
        Me.btn_guardar.TabIndex = 22
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'check_activo
        '
        Me.check_activo.AutoSize = True
        Me.check_activo.Checked = True
        Me.check_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_activo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.check_activo.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen
        Me.check_activo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.check_activo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.check_activo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.check_activo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.check_activo.Location = New System.Drawing.Point(133, 419)
        Me.check_activo.Name = "check_activo"
        Me.check_activo.Size = New System.Drawing.Size(125, 25)
        Me.check_activo.TabIndex = 46
        Me.check_activo.Text = "Usuario activo"
        Me.check_activo.UseVisualStyleBackColor = True
        '
        'cbx_municipios
        '
        Me.cbx_municipios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_municipios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_municipios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_municipios.FormattingEnabled = True
        Me.cbx_municipios.Location = New System.Drawing.Point(683, 372)
        Me.cbx_municipios.Name = "cbx_municipios"
        Me.cbx_municipios.Size = New System.Drawing.Size(383, 29)
        Me.cbx_municipios.TabIndex = 21
        '
        'cbx_departamentos
        '
        Me.cbx_departamentos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_departamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_departamentos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_departamentos.FormattingEnabled = True
        Me.cbx_departamentos.Location = New System.Drawing.Point(365, 372)
        Me.cbx_departamentos.Name = "cbx_departamentos"
        Me.cbx_departamentos.Size = New System.Drawing.Size(292, 29)
        Me.cbx_departamentos.TabIndex = 20
        '
        'cbx_paises
        '
        Me.cbx_paises.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_paises.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_paises.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_paises.FormattingEnabled = True
        Me.cbx_paises.Location = New System.Drawing.Point(133, 372)
        Me.cbx_paises.Name = "cbx_paises"
        Me.cbx_paises.Size = New System.Drawing.Size(212, 29)
        Me.cbx_paises.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(82, 332)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 21)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Email"
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.Color.FloralWhite
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_telefono.Location = New System.Drawing.Point(683, 293)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(383, 29)
        Me.txt_telefono.TabIndex = 17
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_email.Location = New System.Drawing.Point(133, 328)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(383, 29)
        Me.txt_email.TabIndex = 18
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.FloralWhite
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_direccion.Location = New System.Drawing.Point(133, 293)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(383, 29)
        Me.txt_direccion.TabIndex = 16
        '
        'txt_segundo_apellido
        '
        Me.txt_segundo_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_segundo_apellido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_segundo_apellido.Location = New System.Drawing.Point(683, 258)
        Me.txt_segundo_apellido.Name = "txt_segundo_apellido"
        Me.txt_segundo_apellido.Size = New System.Drawing.Size(383, 29)
        Me.txt_segundo_apellido.TabIndex = 15
        '
        'txt_primer_apellido
        '
        Me.txt_primer_apellido.BackColor = System.Drawing.Color.FloralWhite
        Me.txt_primer_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_primer_apellido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_primer_apellido.Location = New System.Drawing.Point(133, 258)
        Me.txt_primer_apellido.Name = "txt_primer_apellido"
        Me.txt_primer_apellido.Size = New System.Drawing.Size(383, 29)
        Me.txt_primer_apellido.TabIndex = 14
        '
        'txt_segundo_nombre
        '
        Me.txt_segundo_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_segundo_nombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_segundo_nombre.Location = New System.Drawing.Point(683, 223)
        Me.txt_segundo_nombre.Name = "txt_segundo_nombre"
        Me.txt_segundo_nombre.Size = New System.Drawing.Size(383, 29)
        Me.txt_segundo_nombre.TabIndex = 13
        '
        'txt_primer_nombre
        '
        Me.txt_primer_nombre.BackColor = System.Drawing.Color.FloralWhite
        Me.txt_primer_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_primer_nombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_primer_nombre.Location = New System.Drawing.Point(133, 223)
        Me.txt_primer_nombre.Name = "txt_primer_nombre"
        Me.txt_primer_nombre.Size = New System.Drawing.Size(383, 29)
        Me.txt_primer_nombre.TabIndex = 12
        '
        'cbx_tipo_responsabilidad
        '
        Me.cbx_tipo_responsabilidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_tipo_responsabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tipo_responsabilidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_tipo_responsabilidad.FormattingEnabled = True
        Me.cbx_tipo_responsabilidad.Location = New System.Drawing.Point(786, 171)
        Me.cbx_tipo_responsabilidad.Name = "cbx_tipo_responsabilidad"
        Me.cbx_tipo_responsabilidad.Size = New System.Drawing.Size(280, 29)
        Me.cbx_tipo_responsabilidad.TabIndex = 11
        '
        'cbx_tipo_regimen
        '
        Me.cbx_tipo_regimen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_tipo_regimen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tipo_regimen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_tipo_regimen.FormattingEnabled = True
        Me.cbx_tipo_regimen.Location = New System.Drawing.Point(545, 172)
        Me.cbx_tipo_regimen.Name = "cbx_tipo_regimen"
        Me.cbx_tipo_regimen.Size = New System.Drawing.Size(212, 29)
        Me.cbx_tipo_regimen.TabIndex = 10
        '
        'cbx_tipo_organizacion
        '
        Me.cbx_tipo_organizacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_tipo_organizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tipo_organizacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_tipo_organizacion.FormattingEnabled = True
        Me.cbx_tipo_organizacion.Location = New System.Drawing.Point(316, 172)
        Me.cbx_tipo_organizacion.Name = "cbx_tipo_organizacion"
        Me.cbx_tipo_organizacion.Size = New System.Drawing.Size(200, 29)
        Me.cbx_tipo_organizacion.TabIndex = 9
        '
        'cbx_tipo_documento
        '
        Me.cbx_tipo_documento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_tipo_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tipo_documento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_tipo_documento.FormattingEnabled = True
        Me.cbx_tipo_documento.Location = New System.Drawing.Point(11, 111)
        Me.cbx_tipo_documento.Name = "cbx_tipo_documento"
        Me.cbx_tipo_documento.Size = New System.Drawing.Size(212, 29)
        Me.cbx_tipo_documento.TabIndex = 6
        '
        'txt_dv
        '
        Me.txt_dv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_dv.Location = New System.Drawing.Point(251, 172)
        Me.txt_dv.Name = "txt_dv"
        Me.txt_dv.Size = New System.Drawing.Size(38, 29)
        Me.txt_dv.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(71, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 21)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Ciudad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(612, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 21)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Teléfono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 21)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Direccion Ppal."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(549, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Segundo apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Primer apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(549, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Segundo nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Primer nombre"
        '
        'check_otro
        '
        Me.check_otro.AutoSize = True
        Me.check_otro.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.check_otro.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen
        Me.check_otro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.check_otro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.check_otro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.check_otro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.check_otro.Location = New System.Drawing.Point(545, 47)
        Me.check_otro.Name = "check_otro"
        Me.check_otro.Size = New System.Drawing.Size(58, 25)
        Me.check_otro.TabIndex = 5
        Me.check_otro.Text = "Otro"
        Me.check_otro.UseVisualStyleBackColor = True
        '
        'check_vendedor
        '
        Me.check_vendedor.AutoSize = True
        Me.check_vendedor.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.check_vendedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen
        Me.check_vendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.check_vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.check_vendedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.check_vendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.check_vendedor.Location = New System.Drawing.Point(431, 47)
        Me.check_vendedor.Name = "check_vendedor"
        Me.check_vendedor.Size = New System.Drawing.Size(93, 25)
        Me.check_vendedor.TabIndex = 4
        Me.check_vendedor.Text = "Vendedor"
        Me.check_vendedor.UseVisualStyleBackColor = True
        '
        'check_usuario_programa
        '
        Me.check_usuario_programa.AutoSize = True
        Me.check_usuario_programa.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.check_usuario_programa.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen
        Me.check_usuario_programa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.check_usuario_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.check_usuario_programa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.check_usuario_programa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.check_usuario_programa.Location = New System.Drawing.Point(108, 47)
        Me.check_usuario_programa.Name = "check_usuario_programa"
        Me.check_usuario_programa.Size = New System.Drawing.Size(178, 25)
        Me.check_usuario_programa.TabIndex = 2
        Me.check_usuario_programa.Text = "Usuario del programa"
        Me.check_usuario_programa.UseVisualStyleBackColor = True
        '
        'check_proveedor
        '
        Me.check_proveedor.AutoSize = True
        Me.check_proveedor.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.check_proveedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen
        Me.check_proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.check_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.check_proveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.check_proveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.check_proveedor.Location = New System.Drawing.Point(309, 47)
        Me.check_proveedor.Name = "check_proveedor"
        Me.check_proveedor.Size = New System.Drawing.Size(98, 25)
        Me.check_proveedor.TabIndex = 3
        Me.check_proveedor.Text = "Proveedor"
        Me.check_proveedor.UseVisualStyleBackColor = True
        '
        'check_cliente
        '
        Me.check_cliente.AutoSize = True
        Me.check_cliente.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.check_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen
        Me.check_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.check_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.check_cliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.check_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.check_cliente.Location = New System.Drawing.Point(16, 47)
        Me.check_cliente.Name = "check_cliente"
        Me.check_cliente.Size = New System.Drawing.Size(74, 25)
        Me.check_cliente.TabIndex = 1
        Me.check_cliente.Text = "Cliente"
        Me.check_cliente.UseVisualStyleBackColor = True
        '
        'panel_procesos
        '
        Me.panel_procesos.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_procesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_procesos.Controls.Add(Me.lb_proceso)
        Me.panel_procesos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_procesos.Location = New System.Drawing.Point(0, 490)
        Me.panel_procesos.Name = "panel_procesos"
        Me.panel_procesos.Size = New System.Drawing.Size(1089, 25)
        Me.panel_procesos.TabIndex = 5
        '
        'lb_proceso
        '
        Me.lb_proceso.BackColor = System.Drawing.Color.DarkGray
        Me.lb_proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_proceso.ForeColor = System.Drawing.Color.White
        Me.lb_proceso.Location = New System.Drawing.Point(0, 0)
        Me.lb_proceso.Name = "lb_proceso"
        Me.lb_proceso.Size = New System.Drawing.Size(1087, 23)
        Me.lb_proceso.TabIndex = 0
        Me.lb_proceso.Text = "✎ Gestionar Seguridad"
        Me.lb_proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_titulo
        '
        Me.panel_titulo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.panel_titulo.Controls.Add(Me.btn_cerrar)
        Me.panel_titulo.Controls.Add(Me.Label2)
        Me.panel_titulo.Controls.Add(Me.PictureBox1)
        Me.panel_titulo.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_titulo.Location = New System.Drawing.Point(0, 0)
        Me.panel_titulo.Name = "panel_titulo"
        Me.panel_titulo.Size = New System.Drawing.Size(1089, 40)
        Me.panel_titulo.TabIndex = 4
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(1040, 2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(46, 35)
        Me.btn_cerrar.TabIndex = 100
        Me.btn_cerrar.TabStop = False
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuarios del programa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.Visions_R.My.Resources.Resources.users_70px
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(786, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 21)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Responsabilidad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(545, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 21)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Tipo regimen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(316, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 21)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Tipo organizacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(11, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 21)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Tipo documento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Numero documento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(255, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 21)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Dv"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Usuarios_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1093, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Usuarios_frm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_procesos.ResumeLayout(False)
        Me.panel_titulo.ResumeLayout(False)
        Me.panel_titulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_titulo As Panel
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panel_procesos As Panel
    Friend WithEvents lb_proceso As Label
    Friend WithEvents check_otro As CheckBox
    Friend WithEvents check_vendedor As CheckBox
    Friend WithEvents check_usuario_programa As CheckBox
    Friend WithEvents check_proveedor As CheckBox
    Friend WithEvents check_cliente As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_segundo_apellido As TextBox
    Friend WithEvents txt_primer_apellido As TextBox
    Friend WithEvents txt_segundo_nombre As TextBox
    Friend WithEvents txt_primer_nombre As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbx_tipo_responsabilidad As ComboBox
    Friend WithEvents cbx_tipo_regimen As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbx_tipo_organizacion As ComboBox
    Friend WithEvents cbx_tipo_documento As ComboBox
    Friend WithEvents txt_dv As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbx_municipios As ComboBox
    Friend WithEvents cbx_departamentos As ComboBox
    Friend WithEvents cbx_paises As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents check_activo As CheckBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents lbx_usuarios As ListBox
    Friend WithEvents cb_usuarios As TextBox
    Friend WithEvents lb_seleccionar_usuarios As Label
    Friend WithEvents txt_numero_documento As TextBox
End Class
