Imports MySql.Data.MySqlClient
Public Class Proveedores_Mod

    ' Funcion para limpiar campos
    Private Sub LimpiarCampos()
        IDtxt.Clear()
        Nombretxt.Clear()
        Direcciontxt.Clear()
        Telefonotxt.Clear()
        Correotxt.Clear()
        IDtxt.Focus()
        Modificarbtn.Enabled = False
    End Sub

    ' Boton buscar
    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim IdProveedor As Integer

        ' Verificar si el ID del proveedor es válido
        If Not Integer.TryParse(IDtxt.Text, IdProveedor) Then
            MessageBox.Show("Ingrese un ID de proveedor válido.")
            Exit Sub
        End If

        ' Conectar a la base de datos
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
                            Modificarbtn.Enabled = True
                            Nombretxt.Enabled = True
                            Direcciontxt.Enabled = True
                            Telefonotxt.Enabled = True
                            Correotxt.Enabled = True
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

    ' Boton modifcar
    Private Sub Modificartxt_Click(sender As Object, e As EventArgs) Handles Modificarbtn.Click
        Dim IdProveedor As Integer
        If Not Integer.TryParse(IDtxt.Text, IdProveedor) Then
            MessageBox.Show("ID de proveedor no válido.")
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
            Exit Sub
        End If

        ' Conectar a la base de datos y modificar el proveedor por ID
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "UPDATE Proveedores SET NombreProveedor = @nombre, Direccion = @direccion, Telefono = @telefono, Correo = @correo WHERE IdProveedor = @id"
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar los valores
                    cmd.Parameters.AddWithValue("@id", IdProveedor)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@direccion", direccion)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@correo", correo)

                    Try
                        ' actualización
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Proveedor modificado exitosamente.")
                        Else
                            MessageBox.Show("No se encontró el proveedor para modificar.")
                        End If

                        ' Limpiar los campos 
                        LimpiarCampos()

                    Catch ex As Exception
                        MessageBox.Show("Error al modificar proveedor: " & ex.Message)
                    End Try
                End Using
            End If
        End Using
    End Sub

    ' Boton Volver
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles Cancelarbtn.Click
        Dim proveedor As New Proveedores
        proveedor.Show()
        Me.Close()
    End Sub
End Class