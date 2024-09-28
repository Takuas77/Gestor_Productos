Imports MySql.Data.MySqlClient

Public Class Proveedores_Alta

    ' Limpieza de campos
    Private Sub LimpiarCampos()
        Nombretxt.Clear()
        Direcciontxt.Clear()
        Telefonotxt.Clear()
        Correotxt.Clear()
        Nombretxt.Focus()
    End Sub

    ' Boton cancelar
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles Cancelarbtn.Click
        Dim Prov As New Proveedores()
        Prov.Show()
        Me.Close()
    End Sub

    ' Boton buscar
    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim nombre As String = Nombretxt.Text
        Dim direccion As String = Direcciontxt.Text
        Dim telefono As String = Telefonotxt.Text
        Dim correo As String = Correotxt.Text

        ' Validar que los campos de nombre y dirección no estén vacíos
        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(direccion) Then
            MessageBox.Show("El campo Nombre y Dirección son obligatorios.")
            Exit Sub
        End If

        ' Conectar a la base de datos y agregar el proveedor
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "INSERT INTO proveedores (NombreProveedor, Direccion, Telefono, Correo)" &
                                      " VALUES (@nombre, @direccion, @telefono, @correo)"
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar parámetros con los valores del formulario
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@direccion", direccion)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@correo", correo)

                    ' Ejecutar el comando
                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Proveedor agregado exitosamente.")
                        ' Limpiar los TextBox después de agregar el proveedor
                        LimpiarCampos()
                    Catch ex As Exception
                        MessageBox.Show("Error al agregar proveedor: " & ex.Message)
                    End Try
                End Using
            End If
        End Using
    End Sub

End Class
