<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_frm
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
        Me.lbx_precios = New System.Windows.Forms.ListBox()
        Me.lbl_nombre_producto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_precio_venta = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.lb_seleccionar_usuarios = New System.Windows.Forms.Label()
        Me.lbx_usuarios = New System.Windows.Forms.ListBox()
        Me.cb_usuarios = New System.Windows.Forms.TextBox()
        Me.panel_titulo = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_procesos = New System.Windows.Forms.Panel()
        Me.lb_proceso = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panel_titulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_procesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbx_precios)
        Me.Panel1.Controls.Add(Me.lbl_nombre_producto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txt_precio_venta)
        Me.Panel1.Controls.Add(Me.txt_codigo)
        Me.Panel1.Controls.Add(Me.lb_seleccionar_usuarios)
        Me.Panel1.Controls.Add(Me.lbx_usuarios)
        Me.Panel1.Controls.Add(Me.cb_usuarios)
        Me.Panel1.Controls.Add(Me.panel_titulo)
        Me.Panel1.Controls.Add(Me.panel_procesos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 578)
        Me.Panel1.TabIndex = 0
        '
        'lbx_precios
        '
        Me.lbx_precios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbx_precios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbx_precios.FormattingEnabled = True
        Me.lbx_precios.HorizontalScrollbar = True
        Me.lbx_precios.ItemHeight = 20
        Me.lbx_precios.Location = New System.Drawing.Point(512, 50)
        Me.lbx_precios.Name = "lbx_precios"
        Me.lbx_precios.Size = New System.Drawing.Size(241, 82)
        Me.lbx_precios.TabIndex = 58
        '
        'lbl_nombre_producto
        '
        Me.lbl_nombre_producto.AutoSize = True
        Me.lbl_nombre_producto.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre_producto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nombre_producto.ForeColor = System.Drawing.Color.Gray
        Me.lbl_nombre_producto.Location = New System.Drawing.Point(8, 228)
        Me.lbl_nombre_producto.Name = "lbl_nombre_producto"
        Me.lbl_nombre_producto.Size = New System.Drawing.Size(113, 19)
        Me.lbl_nombre_producto.TabIndex = 57
        Me.lbl_nombre_producto.Text = "Codigo producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(183, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Precio"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 21)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Codigo producto"
        '
        'txt_precio_venta
        '
        Me.txt_precio_venta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_precio_venta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_precio_venta.Location = New System.Drawing.Point(183, 196)
        Me.txt_precio_venta.Name = "txt_precio_venta"
        Me.txt_precio_venta.Size = New System.Drawing.Size(94, 29)
        Me.txt_precio_venta.TabIndex = 55
        Me.txt_precio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_codigo
        '
        Me.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_codigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_codigo.Location = New System.Drawing.Point(8, 196)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(136, 29)
        Me.txt_codigo.TabIndex = 55
        Me.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_seleccionar_usuarios
        '
        Me.lb_seleccionar_usuarios.AutoSize = True
        Me.lb_seleccionar_usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_seleccionar_usuarios.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_seleccionar_usuarios.ForeColor = System.Drawing.Color.CadetBlue
        Me.lb_seleccionar_usuarios.Location = New System.Drawing.Point(469, 50)
        Me.lb_seleccionar_usuarios.Name = "lb_seleccionar_usuarios"
        Me.lb_seleccionar_usuarios.Size = New System.Drawing.Size(21, 19)
        Me.lb_seleccionar_usuarios.TabIndex = 54
        Me.lb_seleccionar_usuarios.Text = "▼"
        '
        'lbx_usuarios
        '
        Me.lbx_usuarios.BackColor = System.Drawing.Color.Lavender
        Me.lbx_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbx_usuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbx_usuarios.FormattingEnabled = True
        Me.lbx_usuarios.ItemHeight = 21
        Me.lbx_usuarios.Location = New System.Drawing.Point(8, 75)
        Me.lbx_usuarios.Name = "lbx_usuarios"
        Me.lbx_usuarios.Size = New System.Drawing.Size(486, 23)
        Me.lbx_usuarios.TabIndex = 52
        Me.lbx_usuarios.Visible = False
        '
        'cb_usuarios
        '
        Me.cb_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cb_usuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_usuarios.Location = New System.Drawing.Point(8, 46)
        Me.cb_usuarios.Name = "cb_usuarios"
        Me.cb_usuarios.Size = New System.Drawing.Size(486, 29)
        Me.cb_usuarios.TabIndex = 51
        '
        'panel_titulo
        '
        Me.panel_titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.panel_titulo.Controls.Add(Me.btn_cerrar)
        Me.panel_titulo.Controls.Add(Me.lbl_titulo)
        Me.panel_titulo.Controls.Add(Me.PictureBox1)
        Me.panel_titulo.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_titulo.Location = New System.Drawing.Point(0, 0)
        Me.panel_titulo.Name = "panel_titulo"
        Me.panel_titulo.Size = New System.Drawing.Size(964, 40)
        Me.panel_titulo.TabIndex = 7
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(818, 3)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(46, 35)
        Me.btn_cerrar.TabIndex = 10
        Me.btn_cerrar.TabStop = False
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(41, 10)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(68, 25)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Ventas"
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
        Me.panel_procesos.Location = New System.Drawing.Point(0, 553)
        Me.panel_procesos.Name = "panel_procesos"
        Me.panel_procesos.Size = New System.Drawing.Size(964, 25)
        Me.panel_procesos.TabIndex = 6
        '
        'lb_proceso
        '
        Me.lb_proceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lb_proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_proceso.ForeColor = System.Drawing.Color.White
        Me.lb_proceso.Location = New System.Drawing.Point(0, 0)
        Me.lb_proceso.Name = "lb_proceso"
        Me.lb_proceso.Size = New System.Drawing.Size(962, 23)
        Me.lb_proceso.TabIndex = 0
        Me.lb_proceso.Text = "✎ Gestionar"
        Me.lb_proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ventas_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 578)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ventas_frm"
        Me.Text = "Ventas_frm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_titulo.ResumeLayout(False)
        Me.panel_titulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_procesos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_titulo As Panel
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panel_procesos As Panel
    Friend WithEvents lb_proceso As Label
    Friend WithEvents lb_seleccionar_usuarios As Label
    Friend WithEvents lbx_usuarios As ListBox
    Friend WithEvents cb_usuarios As TextBox
    Friend WithEvents lbl_nombre_producto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_precio_venta As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents lbx_precios As ListBox
End Class
