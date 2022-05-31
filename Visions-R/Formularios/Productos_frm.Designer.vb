<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos_frm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_costo_iva = New System.Windows.Forms.TextBox()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_utilidad_precio = New System.Windows.Forms.TextBox()
        Me.btn_add_precios = New System.Windows.Forms.Button()
        Me.cbx_precios = New System.Windows.Forms.ComboBox()
        Me.dgv_precios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_add_impuesto = New System.Windows.Forms.Button()
        Me.dgv_impuestos = New System.Windows.Forms.DataGridView()
        Me.cbx_impuestos = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbx_subgrupo = New System.Windows.Forms.ComboBox()
        Me.cbx_marca = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txt_numero_documento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel_titulo = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_procesos = New System.Windows.Forms.Panel()
        Me.lb_proceso = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_precios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_impuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_titulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_procesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txt_costo_iva)
        Me.Panel1.Controls.Add(Me.txt_costo)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.cbx_subgrupo)
        Me.Panel1.Controls.Add(Me.cbx_marca)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.txt_numero_documento)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.panel_titulo)
        Me.Panel1.Controls.Add(Me.panel_procesos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 694)
        Me.Panel1.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(197, 439)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "+ Iva"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(18, 439)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 21)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Costo"
        '
        'txt_costo_iva
        '
        Me.txt_costo_iva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_iva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_costo_iva.Location = New System.Drawing.Point(246, 435)
        Me.txt_costo_iva.Name = "txt_costo_iva"
        Me.txt_costo_iva.Size = New System.Drawing.Size(119, 29)
        Me.txt_costo_iva.TabIndex = 30
        Me.txt_costo_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_costo
        '
        Me.txt_costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_costo.Location = New System.Drawing.Point(71, 435)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(123, 29)
        Me.txt_costo.TabIndex = 30
        Me.txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_precio)
        Me.GroupBox2.Controls.Add(Me.txt_utilidad_precio)
        Me.GroupBox2.Controls.Add(Me.btn_add_precios)
        Me.GroupBox2.Controls.Add(Me.cbx_precios)
        Me.GroupBox2.Controls.Add(Me.dgv_precios)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 480)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 183)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(119, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 21)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(147, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 21)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Valor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(9, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 21)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Utilidad"
        '
        'txt_precio
        '
        Me.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_precio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_precio.Location = New System.Drawing.Point(196, 28)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(122, 29)
        Me.txt_precio.TabIndex = 29
        Me.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_utilidad_precio
        '
        Me.txt_utilidad_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_utilidad_precio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_utilidad_precio.Location = New System.Drawing.Point(76, 28)
        Me.txt_utilidad_precio.Name = "txt_utilidad_precio"
        Me.txt_utilidad_precio.Size = New System.Drawing.Size(40, 29)
        Me.txt_utilidad_precio.TabIndex = 29
        '
        'btn_add_precios
        '
        Me.btn_add_precios.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btn_add_precios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_precios.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_add_precios.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_add_precios.Image = Global.Visions_R.My.Resources.Resources.pricing_30px
        Me.btn_add_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_precios.Location = New System.Drawing.Point(403, 59)
        Me.btn_add_precios.Name = "btn_add_precios"
        Me.btn_add_precios.Size = New System.Drawing.Size(129, 32)
        Me.btn_add_precios.TabIndex = 28
        Me.btn_add_precios.Text = "Add. Precio"
        Me.btn_add_precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add_precios.UseVisualStyleBackColor = True
        '
        'cbx_precios
        '
        Me.cbx_precios.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cbx_precios.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbx_precios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_precios.ForeColor = System.Drawing.Color.White
        Me.cbx_precios.FormattingEnabled = True
        Me.cbx_precios.Location = New System.Drawing.Point(6, 63)
        Me.cbx_precios.Name = "cbx_precios"
        Me.cbx_precios.Size = New System.Drawing.Size(371, 29)
        Me.cbx_precios.TabIndex = 27
        '
        'dgv_precios
        '
        Me.dgv_precios.BackgroundColor = System.Drawing.Color.White
        Me.dgv_precios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_precios.Location = New System.Drawing.Point(6, 95)
        Me.dgv_precios.Name = "dgv_precios"
        Me.dgv_precios.RowTemplate.Height = 25
        Me.dgv_precios.Size = New System.Drawing.Size(526, 82)
        Me.dgv_precios.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btn_add_impuesto)
        Me.GroupBox1.Controls.Add(Me.dgv_impuestos)
        Me.GroupBox1.Controls.Add(Me.cbx_impuestos)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 108)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impuestos"
        '
        'btn_add_impuesto
        '
        Me.btn_add_impuesto.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btn_add_impuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_impuesto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_add_impuesto.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_add_impuesto.Image = Global.Visions_R.My.Resources.Resources.add_tax_30px
        Me.btn_add_impuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_impuesto.Location = New System.Drawing.Point(6, 63)
        Me.btn_add_impuesto.Name = "btn_add_impuesto"
        Me.btn_add_impuesto.Size = New System.Drawing.Size(180, 33)
        Me.btn_add_impuesto.TabIndex = 26
        Me.btn_add_impuesto.Text = "Add. Impuesto"
        Me.btn_add_impuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add_impuesto.UseVisualStyleBackColor = True
        '
        'dgv_impuestos
        '
        Me.dgv_impuestos.BackgroundColor = System.Drawing.Color.White
        Me.dgv_impuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_impuestos.Location = New System.Drawing.Point(193, 24)
        Me.dgv_impuestos.Name = "dgv_impuestos"
        Me.dgv_impuestos.RowTemplate.Height = 25
        Me.dgv_impuestos.Size = New System.Drawing.Size(339, 72)
        Me.dgv_impuestos.TabIndex = 25
        '
        'cbx_impuestos
        '
        Me.cbx_impuestos.BackColor = System.Drawing.Color.White
        Me.cbx_impuestos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbx_impuestos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_impuestos.ForeColor = System.Drawing.Color.Black
        Me.cbx_impuestos.FormattingEnabled = True
        Me.cbx_impuestos.Location = New System.Drawing.Point(6, 24)
        Me.cbx_impuestos.Name = "cbx_impuestos"
        Me.cbx_impuestos.Size = New System.Drawing.Size(180, 29)
        Me.cbx_impuestos.TabIndex = 24
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 275)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 29)
        Me.ComboBox1.TabIndex = 22
        '
        'cbx_subgrupo
        '
        Me.cbx_subgrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cbx_subgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_subgrupo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_subgrupo.FormattingEnabled = True
        Me.cbx_subgrupo.Location = New System.Drawing.Point(110, 235)
        Me.cbx_subgrupo.Name = "cbx_subgrupo"
        Me.cbx_subgrupo.Size = New System.Drawing.Size(496, 29)
        Me.cbx_subgrupo.TabIndex = 22
        '
        'cbx_marca
        '
        Me.cbx_marca.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cbx_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_marca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbx_marca.FormattingEnabled = True
        Me.cbx_marca.Location = New System.Drawing.Point(110, 200)
        Me.cbx_marca.Name = "cbx_marca"
        Me.cbx_marca.Size = New System.Drawing.Size(496, 29)
        Me.cbx_marca.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(394, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 29)
        Me.TextBox1.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(110, 163)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(496, 29)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox5.Location = New System.Drawing.Point(827, 282)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(62, 29)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.Location = New System.Drawing.Point(608, 280)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(62, 29)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(396, 278)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(62, 29)
        Me.TextBox3.TabIndex = 3
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_documento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_numero_documento.Location = New System.Drawing.Point(110, 118)
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(212, 29)
        Me.txt_numero_documento.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(9, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Presentación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(53, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Grupo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(676, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 21)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Existencias minimas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(54, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Marca"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(464, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cantidad empaque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(331, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Peso gr."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(331, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Interno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(47, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Codigo"
        '
        'panel_titulo
        '
        Me.panel_titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.panel_titulo.Controls.Add(Me.btn_cerrar)
        Me.panel_titulo.Controls.Add(Me.Label2)
        Me.panel_titulo.Controls.Add(Me.PictureBox1)
        Me.panel_titulo.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_titulo.Location = New System.Drawing.Point(0, 0)
        Me.panel_titulo.Name = "panel_titulo"
        Me.panel_titulo.Size = New System.Drawing.Size(896, 40)
        Me.panel_titulo.TabIndex = 5
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(747, 3)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(46, 35)
        Me.btn_cerrar.TabIndex = 10
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
        Me.Label2.Location = New System.Drawing.Point(41, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Productos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.Visions_R.My.Resources.Resources.product_70px
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panel_procesos
        '
        Me.panel_procesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panel_procesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_procesos.Controls.Add(Me.lb_proceso)
        Me.panel_procesos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_procesos.Location = New System.Drawing.Point(0, 669)
        Me.panel_procesos.Name = "panel_procesos"
        Me.panel_procesos.Size = New System.Drawing.Size(896, 25)
        Me.panel_procesos.TabIndex = 4
        '
        'lb_proceso
        '
        Me.lb_proceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lb_proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_proceso.ForeColor = System.Drawing.Color.White
        Me.lb_proceso.Location = New System.Drawing.Point(0, 0)
        Me.lb_proceso.Name = "lb_proceso"
        Me.lb_proceso.Size = New System.Drawing.Size(894, 23)
        Me.lb_proceso.TabIndex = 0
        Me.lb_proceso.Text = "✎ Gestionar"
        Me.lb_proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Productos_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 698)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Productos_frm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_precios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_impuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_titulo.ResumeLayout(False)
        Me.panel_titulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_procesos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_titulo As Panel
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panel_procesos As Panel
    Friend WithEvents lb_proceso As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_numero_documento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbx_impuestos As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cbx_subgrupo As ComboBox
    Friend WithEvents cbx_marca As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_impuestos As DataGridView
    Friend WithEvents btn_add_impuesto As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_utilidad_precio As TextBox
    Friend WithEvents btn_add_precios As Button
    Friend WithEvents cbx_precios As ComboBox
    Friend WithEvents dgv_precios As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_costo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_costo_iva As TextBox
End Class
