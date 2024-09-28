Imports MySql.Data.MySqlClient
Public Class Categoria_Baja

    ' Boton Volver
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles Cancelarbtn.Click
        Dim categoria As New Categoria
        categoria.Show()
        Me.Close()
    End Sub

    ' Boton Buscar

    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim idCategoria As Integer

        ' Verificar si el ID del categoria es válida
        If Not Integer.TryParse(IdCategoriatxt.Text, idCategoria) Then
            MessageBox.Show("Ingrese un ID de Categoria válida.")
            Exit Sub
        End If

        ' Conectar a la base de datos y buscar el categoria por ID
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT * FROM categorias WHERE IdCategoria = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idCategoria)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    ' Verificar si se encontró la categoria
                    If reader.Read() Then
                        ' Llenar los TextBox con los datos de la categoria
                        Categoriatxt.Text = reader("Categoria").ToString()
                        Eliminarbtn.Enabled = True
                    Else
                        MessageBox.Show("Categoria no encontrada.")
                    End If
                End Using
            End If
        End Using
    End Sub

    ' Boton Eliminar
    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click
        Dim idCategoria As Integer

        ' Verificar si el ID de la categoria es válida
        If Not Integer.TryParse(IdCategoriatxt.Text, idCategoria) Then
            MessageBox.Show("Ingrese un ID de una categoria válida.")
            Exit Sub
        End If

        ' Confirmar la eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        End If

        ' Conectar a la base de datos y eliminar la categoria por ID
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "DELETE FROM categorias WHERE IdCategoria = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idCategoria)

                    ' Ejecutar el comando de eliminación
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria eliminada exitosamente.")

                    ' Limpiar los campos
                    IdCategoriatxt.Clear()
                    Categoriatxt.Clear()
                    Eliminarbtn.Enabled = False
                End Using
            End If
        End Using
    End Sub
End Class