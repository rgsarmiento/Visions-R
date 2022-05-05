Imports System.Data.SqlClient

Public Class Seguridad_cad

    Public Shared Function guardar(ByVal e As Modelo_Seguridad) As Boolean
        Try
            Dim con As Conexion = New Conexion()
            Dim query As String = "INSERT INTO SEGURIDAD
                                     (CODIGO, CLAVE, PERFIL, NOMBRE, NIT)
                                      VALUES (@CODIGO,@CLAVE,@PERFIL,@NOMBRE,@NIT)"

            Dim comando As SqlCommand = New SqlCommand(query, con.conectar)

            comando.Parameters.AddWithValue("@CODIGO", e.Codigo)
            comando.Parameters.AddWithValue("@CLAVE", e.Clave)
            comando.Parameters.AddWithValue("@PERFIL", e.Perfil)
            comando.Parameters.AddWithValue("@NOMBRE", e.Nombre)
            comando.Parameters.AddWithValue("@NIT", e.Nit)

            Dim cantidad As Integer = comando.ExecuteNonQuery

            con.desconectar()

            If cantidad = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
