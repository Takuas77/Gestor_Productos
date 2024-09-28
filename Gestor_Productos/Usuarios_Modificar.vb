Imports MySql.Data.MySqlClient
Public Class Usuarios_Modificar
    Private idUsuario As Integer

    ' Recibe el ID del usuario seleccionado
    Public Sub New(id As Integer)
        ' Guardar el ID del usuario
        InitializeComponent()
        idUsuario = id

        ' Cargar los datos del usuario para modificarlos
        CargarDatosUsuario()
    End Sub

    ' Función para cargar los datos del usuario en los TextBox
    Private Sub CargarDatosUsuario()
        ' Conectar a la base de datos y traer los datos del usuario
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT * FROM usuarios WHERE idUsuario = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idUsuario)

                    ' Ejecutar la consulta y llenar los TextBox con los datos
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Usuariotxt.Text = reader("Username").ToString()
                            Correotxt.Text = reader("Email").ToString()
                            CategoriaComboBox.Text = reader("Categoria").ToString()
                            ' No cargar la contraseña para mayor seguridad, si es necesario
                        End If
                    End Using
                End Using
            End If
        End Using
    End Sub

    ' Boton Modifcar
    Private Sub Modificarbtn_Click(sender As Object, e As EventArgs) Handles Modificarbtn.Click
        ' Obtener los nuevos datos desde los TextBox
        Dim nuevoUsername As String = Usuariotxt.Text
        Dim nuevoCorreo As String = Correotxt.Text
        Dim nuevaCategoria As String = CategoriaComboBox.Text

        ' Verificar si se ingresó una nueva contraseña
        Dim nuevaContraseña As String = Contraseñatxt.Text
        Dim confirmarContraseña As String = Recontraseñatxt.Text

        ' Validar si la nueva contraseña está ingresada y si coincide con la confirmación
        If Not String.IsNullOrEmpty(nuevaContraseña) Then
            If nuevaContraseña <> confirmarContraseña Then
                MessageBox.Show("Las contraseñas no coinciden.")
                Exit Sub
            End If

            ' Hashear la nueva contraseña
            Dim hashedPassword As String = HashPassword(nuevaContraseña)

            ' Conectar a la base de datos para actualizar los datos del usuario
            Using conn As MySqlConnection = OpenConnection()
                If conn IsNot Nothing Then
                    ' Actualizar tanto los datos del usuario como la contraseña
                    Dim query As String = "UPDATE usuarios SET Username = @username, Email = @correo, Categoria = @categoria, Password = @password WHERE idUsuario = @id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@username", nuevoUsername)
                        cmd.Parameters.AddWithValue("@correo", nuevoCorreo)
                        cmd.Parameters.AddWithValue("@categoria", nuevaCategoria)
                        cmd.Parameters.AddWithValue("@password", hashedPassword)
                        cmd.Parameters.AddWithValue("@id", idUsuario)

                        ' Ejecutar la actualización
                        cmd.ExecuteNonQuery()
                        Correotxt.Clear()
                        CategoriaComboBox.ResetText()
                        Contraseñatxt.Clear()
                        Recontraseñatxt.Clear()
                        MessageBox.Show("Usuario modificado exitosamente.")
                        Dim usuario_admin As New Usuario_Administrar
                        usuario_admin.Show()
                        Me.Close()
                    End Using
                End If
            End Using
        Else
            ' Si no se ingresa una nueva contraseña, actualizar solo los otros datos
            Using conn As MySqlConnection = OpenConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "UPDATE usuarios SET Username = @username, Email = @correo, Categoria = @categoria WHERE idUsuario = @id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@username", nuevoUsername)
                        cmd.Parameters.AddWithValue("@correo", nuevoCorreo)
                        cmd.Parameters.AddWithValue("@categoria", nuevaCategoria)
                        cmd.Parameters.AddWithValue("@id", idUsuario)

                        ' Ejecutar la actualización
                        cmd.ExecuteNonQuery()
                        Correotxt.Clear()
                        CategoriaComboBox.ResetText()
                        Contraseñatxt.Clear()
                        Recontraseñatxt.Clear()
                        MessageBox.Show("Usuario modificado exitosamente.")
                        Dim usuario_admin As New Usuario_Administrar
                        usuario_admin.Show()
                        Me.Close()
                    End Using
                End If
            End Using
        End If
    End Sub

    ' Boton Volver
    Private Sub Volverbtn_Click(sender As Object, e As EventArgs) Handles Volverbtn.Click
        Dim usuario_admin As New Usuario_Administrar
        usuario_admin.Show()
        Me.Close()
    End Sub
End Class