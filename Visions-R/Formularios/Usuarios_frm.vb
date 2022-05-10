Public Class Usuarios_frm
    Private Sub Usuarios_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_paises()
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
            End With
        Catch ex As Exception

        End Try
    End Sub

End Class