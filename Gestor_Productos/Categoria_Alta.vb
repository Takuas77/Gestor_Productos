Imports MySql.Data.MySqlClient
Public Class Categoria_Alta

    ' Boton Volver
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles Cancelarbtn.Click
        Dim categoria As New Categoria
        categoria.Show()
        Me.Close()
    End Sub

    ' Boton Agregar
    Private Sub Agregarbtn_Click(sender As Object, e As EventArgs) Handles Agregarbtn.Click
        Dim categoria As String = Categoriatxt.Text
        Dim vCategoria As New Categoria
        ' Validar los campos obligatorios (nombre y cantidad)
        If String.IsNullOrEmpty(categoria) Then
            MessageBox.Show("El campo categoria es obligatoria.")
            Exit Sub
        End If

        ' Conectar a la base de datos y agregar el producto
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "INSERT INTO categorias (Categoria) " &
                                      "VALUES (@categoria)"
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar parámetros con los valores del formulario
                    cmd.Parameters.AddWithValue("@categoria", categoria)
                    ' Ejecutar el comando
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria agregada exitosamente.")
                    vCategoria.Show()
                    Me.Close()
                End Using
            End If
        End Using
    End Sub
End Class