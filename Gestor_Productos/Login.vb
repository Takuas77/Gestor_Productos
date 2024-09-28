Imports MySql.Data.MySqlClient
Public Class Login

    ' Boton Ingresar (toma los datos de la tabla usuarios y almacena el rol del usuario)
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim username As String = Usuariotxt.Text
        Dim password As String = Passwordtxt.Text
        Dim hashedPassword As String = HashPassword(password)

        ' Verificar las credenciales en la base de datos
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                ' Cambiar 'Rol' por 'Categoria' y agregar verificación de Estado (activo)
                Dim query As String = "SELECT Categoria FROM usuarios WHERE Username=@username AND Password=@password AND Estado=1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)

                    ' Ejecutar el comando
                    Dim role As String = Convert.ToString(cmd.ExecuteScalar())

                    ' Verificar si se encontró el usuario
                    If String.IsNullOrEmpty(role) Then
                        MessageBox.Show("Usuario o contraseña incorrectos, o el usuario está inactivo.")
                        Exit Sub
                    End If

                    ' Almacenar el rol del usuario en la variable global
                    CurrentUserRole = role

                    ' Mostrar un mensaje según el rol del usuario
                    If CurrentUserRole = "Administrador" Then
                        MessageBox.Show("Bienvenido, " + username + ".")
                    Else
                        MessageBox.Show("Bienvenido, " + username + ".")
                    End If

                    ' Aquí podrías abrir el formulario principal de tu aplicación
                    Dim inicio As New Inicio()
                    inicio.Show()
                    Me.Hide() ' Ocultar el formulario de login
                End Using
            End If
        End Using
    End Sub

End Class
