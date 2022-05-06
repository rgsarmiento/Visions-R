<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Msgbox_frm
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
        Me.lb_mensaje = New System.Windows.Forms.Label()
        Me.pb_estado = New System.Windows.Forms.PictureBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.panel_titulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_titulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_titulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lb_mensaje)
        Me.Panel1.Controls.Add(Me.pb_estado)
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Controls.Add(Me.panel_titulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 227)
        Me.Panel1.TabIndex = 0
        '
        'lb_mensaje
        '
        Me.lb_mensaje.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_mensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lb_mensaje.Location = New System.Drawing.Point(68, 62)
        Me.lb_mensaje.Name = "lb_mensaje"
        Me.lb_mensaje.Size = New System.Drawing.Size(454, 111)
        Me.lb_mensaje.TabIndex = 3
        Me.lb_mensaje.Text = "Mensaje ..."
        Me.lb_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pb_estado
        '
        Me.pb_estado.Location = New System.Drawing.Point(12, 93)
        Me.pb_estado.Name = "pb_estado"
        Me.pb_estado.Size = New System.Drawing.Size(50, 50)
        Me.pb_estado.TabIndex = 2
        Me.pb_estado.TabStop = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_aceptar.ForeColor = System.Drawing.Color.White
        Me.btn_aceptar.Location = New System.Drawing.Point(397, 184)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(125, 35)
        Me.btn_aceptar.TabIndex = 1
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'panel_titulo
        '
        Me.panel_titulo.BackColor = System.Drawing.Color.Tomato
        Me.panel_titulo.Controls.Add(Me.PictureBox1)
        Me.panel_titulo.Controls.Add(Me.lb_titulo)
        Me.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_titulo.Location = New System.Drawing.Point(0, 0)
        Me.panel_titulo.Name = "panel_titulo"
        Me.panel_titulo.Size = New System.Drawing.Size(530, 50)
        Me.panel_titulo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lb_titulo
        '
        Me.lb_titulo.AutoSize = True
        Me.lb_titulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_titulo.ForeColor = System.Drawing.Color.White
        Me.lb_titulo.Location = New System.Drawing.Point(48, 13)
        Me.lb_titulo.Name = "lb_titulo"
        Me.lb_titulo.Size = New System.Drawing.Size(67, 25)
        Me.lb_titulo.TabIndex = 0
        Me.lb_titulo.Text = "Label1"
        '
        'Msgbox_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(534, 231)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Msgbox_frm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Msgbox_frm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_titulo.ResumeLayout(False)
        Me.panel_titulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents panel_titulo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lb_titulo As Label
    Friend WithEvents lb_mensaje As Label
    Friend WithEvents pb_estado As PictureBox
End Class
