Imports MySql.Data.MySqlClient

Public Class Proveedores_Baja

    ' Función para limpiar los campos
    Private Sub LimpiarCampos()
        Idtxt.Clear()
        Nombretxt.Clear()
        Direcciontxt.Clear()
        Telefonotxt.Clear()
        Correotxt.Clear()
        Idtxt.Focus()
        Eliminarbtn.Enabled = False
    End Sub

    ' Botón Cancelar, cierra el formulario actual y muestra el formulario anterior
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles Cancelarbtn.Click
        Dim proveedor As New Proveedores()
        proveedor.Show()
        Me.Close()
    End Sub

    ' Botón Eliminar, se encarga de eliminar el proveedor
    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click
        Dim IdProveedor As Integer

        ' Verificar si el ID del proveedor es válido
        If Not Integer.TryParse(Idtxt.Text, IdProveedor) Then
            MessageBox.Show("Ingrese un ID de un Proveedor válido.")
            Exit Sub
        End If

        ' Confirmar la eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este Proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        End If

        ' Conectar a la base de datos y eliminar el proveedor por ID
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "DELETE FROM Proveedores WHERE IdProveedor = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", IdProveedor)

                    Try
                        ' Ejecutar el comando de eliminación
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Proveedor eliminado exitosamente.")
                        Else
                            MessageBox.Show("Proveedor no encontrado.")
                        End If

                        ' Limpiar los campos después de la eliminación
                        LimpiarCampos()

                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar proveedor: " & ex.Message)
                    End Try
                End Using
            End If
        End Using
    End Sub

    ' Botón Buscar, busca el proveedor por ID y llena los campos con la información
    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim IdProveedor As Integer

        ' Verificar si el ID del proveedor es válido
        If Not Integer.TryParse(Idtxt.Text, IdProveedor) Then
            MessageBox.Show("Ingrese un ID de proveedor válido.")
            Exit Sub
        End If

        ' Conectar a la base de datos y buscar el proveedor por ID
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT * FROM Proveedores WHERE IdProveedor = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", IdProveedor)

                    Try
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        ' Verificar si se encontró el proveedor
                        If reader.Read() Then
                            ' Llenar los TextBox con los datos del proveedor
                            Nombretxt.Text = reader("NombreProveedor").ToString()
                            Direcciontxt.Text = reader("Direccion").ToString()
                            Telefonotxt.Text = reader("Telefono").ToString()
                            Correotxt.Text = reader("Correo").ToString()
                            Eliminarbtn.Enabled = True
                        Else
                            MessageBox.Show("Proveedor no encontrado.")
                            LimpiarCampos()  ' Limpiar los campos si no se encuentra
                        End If
                        reader.Close()  ' Cerrar el lector para evitar errores

                    Catch ex As Exception
                        MessageBox.Show("Error al buscar proveedor: " & ex.Message)
                    End Try
                End Using
            End If
        End Using
    End Sub

End Class
