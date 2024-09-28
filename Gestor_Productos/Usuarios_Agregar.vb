Imports MySql.Data.MySqlClient
Public Class Usuarios_Agregar

    ' Boton volver
    Private Sub Volverbtn_Click(sender As Object, e As EventArgs) Handles Volverbtn.Click
        Dim UsuarioAdmin As New Usuario_Administrar
        UsuarioAdmin.Show()
        Me.Close()
    End Sub

    ' Funcion para limpiar campos
    Private Sub LimpiarCampos()
        Usuariotxt.Clear()
        Correotxt.Clear()
        CategoriaComboBox.ResetText()
        Contraseñatxt.Clear()
        Recontraseñatxt.Clear()
    End Sub

    ' Boton Agregar, la cual incluye el hash de la clave, tomando la funcion hashpassword
    Private Sub Agregarbtn_Click(sender As Object, e As EventArgs) Handles Agregarbtn.Click
        ' Obtener los valores de los TextBox
        Dim username As String = Usuariotxt.Text
        Dim correo As String = Correotxt.Text
        Dim categoria As String = CategoriaComboBox.Text
        Dim contraseña As String = Contraseñatxt.Text
        Dim reContraseña As String = Recontraseñatxt.Text

        ' Verificar si las contraseñas coinciden
        If contraseña <> reContraseña Then
            MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.")
            Exit Sub
        End If

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(correo) OrElse String.IsNullOrEmpty(categoria) OrElse String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Todos los campos son obligatorios.")
            Exit Sub
        End If

        ' Hashear la contraseña antes de almacenarla
        Dim hashedPassword As String = HashPassword(contraseña)

        ' Insertar el nuevo usuario con Estado = 1 (activo)
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "INSERT INTO usuarios (Username, Password, Email, Categoria, Estado) VALUES (@username, @password, @correo, @categoria, 1)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", hashedPassword) ' Guardar la contraseña hasheada
                    cmd.Parameters.AddWithValue("@correo", correo)
                    cmd.Parameters.AddWithValue("@categoria", categoria)

                    ' Ejecutar la consulta
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario agregado exitosamente.")

                    ' Limpiar los campos del formulario
                    LimpiarCampos()
                End Using
            End If
        End Using
    End Sub
End Class