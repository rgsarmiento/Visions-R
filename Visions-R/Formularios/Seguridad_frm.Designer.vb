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
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel_procesos = New System.Windows.Forms.Panel()
        Me.lb_proceso = New System.Windows.Forms.Label()
        Me.panel_titulo = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.panel_procesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(50, 298)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(90, 39)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.panel_titulo)
        Me.Panel1.Controls.Add(Me.panel_procesos)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(796, 446)
        Me.Panel1.TabIndex = 2
        '
        'panel_procesos
        '
        Me.panel_procesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_procesos.Controls.Add(Me.lb_proceso)
        Me.panel_procesos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_procesos.Location = New System.Drawing.Point(2, 419)
        Me.panel_procesos.Name = "panel_procesos"
        Me.panel_procesos.Size = New System.Drawing.Size(792, 25)
        Me.panel_procesos.TabIndex = 2
        '
        'lb_proceso
        '
        Me.lb_proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_proceso.Location = New System.Drawing.Point(0, 0)
        Me.lb_proceso.Name = "lb_proceso"
        Me.lb_proceso.Size = New System.Drawing.Size(790, 23)
        Me.lb_proceso.TabIndex = 0
        Me.lb_proceso.Text = "✎ Gestionar Seguridad"
        Me.lb_proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_titulo
        '
        Me.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_titulo.Location = New System.Drawing.Point(2, 2)
        Me.panel_titulo.Name = "panel_titulo"
        Me.panel_titulo.Size = New System.Drawing.Size(792, 45)
        Me.panel_titulo.TabIndex = 3
        '
        'Seguridad_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Seguridad_frm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.panel_procesos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_guardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_procesos As Panel
    Friend WithEvents lb_proceso As Label
    Friend WithEvents panel_titulo As Panel
End Class
