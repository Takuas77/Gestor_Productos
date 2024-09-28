Imports MySql.Data.MySqlClient
Public Class Clientes_Mod

    ' Desbloquea la mod de los datos del cliente
    Private Sub CargaDatosCliente()
        Nombretxt.Enabled = True
        Direcciontxt.Enabled = True
        Telefonotxt.Enabled = True
        Correotxt.Enabled = True
        Modifcarbtn.Enabled = True
    End Sub


    ' Reinicia los campos de mod del cliente
    Private Sub limpiarcampos()
        Dnitxt.Clear()
        Nombretxt.Clear()
        Direcciontxt.Clear()
        Telefonotxt.Clear()
        Correotxt.Clear()
        Modifcarbtn.Enabled = False
        Nombretxt.Enabled = False
        Direcciontxt.Enabled = False
        Telefonotxt.Enabled = False
        Correotxt.Enabled = False
        Modifcarbtn.Enabled = False
        Dnitxt.Focus()
    End Sub

    ' Boton Buscar
    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim dni As Integer

        ' Comprueba si es un dni valido
        If Not Integer.TryParse(Dnitxt.Text, dni) Then
            MessageBox.Show("Ingrese el DNI de un Cliente válido.")
            Exit Sub
        End If

        ' Conectar a la base de datos y buscar el cliente por dni
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT * FROM clientes WHERE DNI = @DNI"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DNI", dni)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    ' Verificar si se encontró el cliente
                    If reader.Read() Then
                        ' Llenar los TextBox con los datos del cliente
                        Nombretxt.Text = reader("NombreCliente").ToString()
                        Direcciontxt.Text = reader("Direccion").ToString()
                        Telefonotxt.Text = reader("Telefono").ToString()
                        Correotxt.Text = reader("Correo").ToString()
                        CargaDatosCliente()
                    Else
                        MessageBox.Show("Cliente no encontrado.")
                        Dnitxt.Focus()
                    End If
                End Using
            End If
        End Using
    End Sub

    ' Boton modificar
    Private Sub Modifcarbtn_Click(sender As Object, e As EventArgs) Handles Modifcarbtn.Click
        Dim dni As Integer
        If Not Integer.TryParse(Dnitxt.Text, dni) Then
            MessageBox.Show("DNI de cliente no válido.")
            limpiarcampos()
            Exit Sub
        End If

        ' Obtener los valores modificados de los TextBox
        Dim nombre As String = Nombretxt.Text
        Dim direccion As String = Direcciontxt.Text
        Dim telefono As String = Telefonotxt.Text
        Dim correo As String = Correotxt.Text

        ' Verificar que los campos obligatorios no estén vacíos
        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(direccion) Then
            MessageBox.Show("El campo Nombre y Dirección son obligatorios.")
            Nombretxt.Focus()
            Exit Sub
        End If

        ' Conectar a la base de datos y modificar el cliente por DNI
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "UPDATE clientes SET NombreCliente = @nombre, Direccion = @direccion, Telefono = @telefono, Correo = @correo WHERE DNI = @dni"
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar los valores a los parámetros
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@direccion", direccion)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@correo", correo)
                    cmd.Parameters.AddWithValue("@dni", dni)

                    Try
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Cliente modificado exitosamente.")
                        Else
                            MessageBox.Show("No se encontró el cliente para modificar.")
                        End If
                        limpiarcampos()

                    Catch ex As Exception
                        MessageBox.Show("Error al modificar cliente: " & ex.Message)
                    End Try
                End Using
            End If
        End Using
    End Sub

    ' Boton volver
    Private Sub Volverbtn_Click(sender As Object, e As EventArgs) Handles Volverbtn.Click
        Dim volver As New Clientes
        volver.Show()
        Me.Close()
    End Sub
End Class