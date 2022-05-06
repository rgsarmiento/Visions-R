Public Class Msgbox_frm

    Public Sub abrir_frm(tipo As String, titulo As String, mensaje As String)
        Me.FormBorderStyle = FormBorderStyle.None

        lb_mensaje.Text = mensaje
        lb_titulo.Text = titulo

        Select Case tipo
            Case "ok"
                btn_aceptar.BackColor = System.Drawing.Color.LightSeaGreen
                Me.BackColor = System.Drawing.Color.LightSeaGreen
                panel_titulo.BackColor = System.Drawing.Color.LightSeaGreen
            Case "error"
                btn_aceptar.BackColor = System.Drawing.Color.Tomato
                Me.BackColor = System.Drawing.Color.Tomato
                panel_titulo.BackColor = System.Drawing.Color.Tomato
            Case Else
                Me.Close()
        End Select

        Me.ShowDialog()

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Me.Close()
    End Sub
End Class