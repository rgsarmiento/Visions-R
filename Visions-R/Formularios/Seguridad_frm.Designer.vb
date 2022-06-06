<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seguridad_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbx_usuarios = New System.Windows.Forms.ListBox()
        Me.cb_perfil = New System.Windows.Forms.ComboBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.check_activo = New System.Windows.Forms.CheckBox()
        Me.txt_clave_acceso = New System.Windows.Forms.TextBox()
        Me.txt_usuario_acceso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_usuarios = New System.Windows.Forms.TextBox()
        Me.panel_titulo = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_procesos = New System.Windows.Forms.Panel()
        Me.lb_proceso = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_titulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_procesos.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_guardar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_guardar.Image = Global.Visions_R.My.Resources.Resources.save_30px
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(549, 254)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(103, 39)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbx_usuarios)
        Me.Panel1.Controls.Add(Me.cb_perfil)
        Me.Panel1.Controls.Add(Me.btn_actualizar)
        Me.Panel1.Controls.Add(Me.btn_nuevo)
        Me.Panel1.Controls.Add(Me.dgv_data)
        Me.Panel1.Controls.Add(Me.check_activo)
        Me.Panel1.Controls.Add(Me.txt_clave_acceso)
        Me.Panel1.Controls.Add(Me.txt_usuario_acceso)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cb_usuarios)
        Me.Panel1.Controls.Add(Me.panel_titulo)
        Me.Panel1.Controls.Add(Me.panel_procesos)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 526)
        Me.Panel1.TabIndex = 2
        '
        'lbx_usuarios
        '
        Me.lbx_usuarios.BackColor = System.Drawing.Color.Lavender
        Me.lbx_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbx_usuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbx_usuarios.FormattingEnabled = True
        Me.lbx_usuarios.ItemHeight = 21
        Me.lbx_usuarios.Location = New System.Drawing.Point(8, 104)
        Me.lbx_usuarios.Name = "lbx_usuarios"
        Me.lbx_usuarios.Size = New System.Drawing.Size(486, 86)
        Me.lbx_usuarios.TabIndex = 2
        Me.lbx_usuarios.Visible = False
        '
        'cb_perfil
        '
        Me.cb_perfil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cb_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_perfil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_perfil.FormattingEnabled = True
        Me.cb_perfil.Location = New System.Drawing.Point(8, 261)
        Me.cb_perfil.Name = "cb_perfil"
        Me.cb_perfil.Size = New System.Drawing.Size(268, 29)
        Me.cb_perfil.TabIndex = 5
        '
        'btn_actualizar
        '
        Me.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_actualizar.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_actualizar.Image = Global.Visions_R.My.Resources.Resources.update_30px
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(549, 201)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(221, 39)
        Me.btn_actualizar.TabIndex = 9
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
        Me.btn_nuevo.Location = New System.Drawing.Point(667, 254)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(103, 39)
        Me.btn_nuevo.TabIndex = 8
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'dgv_data
        '
        Me.dgv_data.BackgroundColor = System.Drawing.Color.White
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data.Location = New System.Drawing.Point(8, 309)
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.RowTemplate.Height = 25
        Me.dgv_data.Size = New System.Drawing.Size(762, 186)
        Me.dgv_data.TabIndex = 13
        '
        'check_activo
        '
        Me.check_activo.AutoSize = True
        Me.check_activo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.check_activo.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen
        Me.check_activo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.check_activo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.check_activo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.check_activo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.check_activo.Location = New System.Drawing.Point(368, 268)
        Me.check_activo.Name = "check_activo"
        Me.check_activo.Size = New System.Drawing.Size(119, 25)
        Me.check_activo.TabIndex = 6
        Me.check_activo.Text = "Acceso activo"
        Me.check_activo.UseVisualStyleBackColor = True
        '
        'txt_clave_acceso
        '
        Me.txt_clave_acceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave_acceso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_clave_acceso.Location = New System.Drawing.Point(8, 197)
        Me.txt_clave_acceso.Name = "txt_clave_acceso"
        Me.txt_clave_acceso.Size = New System.Drawing.Size(218, 29)
        Me.txt_clave_acceso.TabIndex = 4
        '
        'txt_usuario_acceso
        '
        Me.txt_usuario_acceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario_acceso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_usuario_acceso.Location = New System.Drawing.Point(8, 138)
        Me.txt_usuario_acceso.Name = "txt_usuario_acceso"
        Me.txt_usuario_acceso.Size = New System.Drawing.Size(218, 29)
        Me.txt_usuario_acceso.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(469, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "▼"
        '
        'cb_usuarios
        '
        Me.cb_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cb_usuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_usuarios.Location = New System.Drawing.Point(8, 75)
        Me.cb_usuarios.Name = "cb_usuarios"
        Me.cb_usuarios.Size = New System.Drawing.Size(486, 29)
        Me.cb_usuarios.TabIndex = 1
        '
        'panel_titulo
        '
        Me.panel_titulo.BackColor = System.Drawing.Color.CadetBlue
        Me.panel_titulo.Controls.Add(Me.btn_cerrar)
        Me.panel_titulo.Controls.Add(Me.Label2)
        Me.panel_titulo.Controls.Add(Me.PictureBox1)
        Me.panel_titulo.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_titulo.Location = New System.Drawing.Point(0, 0)
        Me.panel_titulo.Name = "panel_titulo"
        Me.panel_titulo.Size = New System.Drawing.Size(780, 40)
        Me.panel_titulo.TabIndex = 3
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cerrar.Location = New System.Drawing.Point(730, 2)
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
        Me.Label2.Size = New System.Drawing.Size(235, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seguridad de la aplicación"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.Visions_R.My.Resources.Resources.key_70px
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panel_procesos
        '
        Me.panel_procesos.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_procesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_procesos.Controls.Add(Me.lb_proceso)
        Me.panel_procesos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_procesos.Location = New System.Drawing.Point(0, 501)
        Me.panel_procesos.Name = "panel_procesos"
        Me.panel_procesos.Size = New System.Drawing.Size(780, 25)
        Me.panel_procesos.TabIndex = 2
        '
        'lb_proceso
        '
        Me.lb_proceso.BackColor = System.Drawing.Color.DarkGray
        Me.lb_proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_proceso.ForeColor = System.Drawing.Color.White
        Me.lb_proceso.Location = New System.Drawing.Point(0, 0)
        Me.lb_proceso.Name = "lb_proceso"
        Me.lb_proceso.Size = New System.Drawing.Size(778, 23)
        Me.lb_proceso.TabIndex = 0
        Me.lb_proceso.Text = "✎ Gestionar Seguridad"
        Me.lb_proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contraseña de acceso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Usuario acceso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Perfil"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Seguridad_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(784, 530)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Seguridad_frm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_titulo.ResumeLayout(False)
        Me.panel_titulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_procesos.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_guardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_procesos As Panel
    Friend WithEvents lb_proceso As Label
    Friend WithEvents panel_titulo As Panel
    Friend WithEvents lbx_usuarios As ListBox
    Friend WithEvents cb_usuarios As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents dgv_data As DataGridView
    Friend WithEvents check_activo As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_clave_acceso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_usuario_acceso As TextBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_perfil As ComboBox
End Class
