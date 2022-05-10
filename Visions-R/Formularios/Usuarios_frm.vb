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
                End With
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class