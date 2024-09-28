Imports MySql.Data.MySqlClient
Public Class Clientes_Baja

    ' Funcion para limpiar
    Private Sub comienzo()
        Dnitxt.Clear()
        Nombretxt.Clear()
        Direcciontxt.Clear()
        Telefonotxt.Clear()
        Correotxt.Clear()
        Eliminarbtn.Enabled = False
        Dnitxt.Focus()
    End Sub

    ' Boton volver
    Private Sub Volverbtn_Click(sender As Object, e As EventArgs) Handles Volverbtn.Click
        Dim cliente As New Clientes
        cliente.Show()
        Me.Close()
    End Sub

    ' Boton Eliminar
    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click
        Dim dni As Integer

        ' Verificar si el dni del cliente es válido
        If Not Integer.TryParse(Dnitxt.Text, dni) Then
            MessageBox.Show("Ingrese el DNI de un Cliente válido.")
            Dnitxt.Focus()
            Exit Sub
        End If

        ' Confirmar la eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este Cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        End If

        ' Conectar a la base de datos y eliminar el cliente por dni
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "DELETE FROM clientes WHERE dni = @DNI"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@dni", dni)

                    ' Ejecutar el comando de eliminación
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Cliente eliminado exitosamente.")
                    comienzo()
                End Using
            End If
        End Using
    End Sub

    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim dni As Integer

        ' Verificar si el dni del cliente es válido
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
                        Eliminarbtn.Enabled = True
                    Else
                        MessageBox.Show("Cliente no encontrado.")
                        Dnitxt.Focus()
                    End If
                End Using
            End If
        End Using
    End Sub
End Class