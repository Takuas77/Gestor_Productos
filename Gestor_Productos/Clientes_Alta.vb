Imports MySql.Data.MySqlClient
Public Class Clientes_Alta

    ' Lipiar los campos
    Private Sub LimpiarCampos()
        Dnitxt.Clear()
        Nombretxt.Clear()
        Direcciontxt.Clear()
        Telefonotxt.Clear()
        Correotxt.Clear()
    End Sub

    ' Boton volver
    Private Sub Volverbtn_Click(sender As Object, e As EventArgs) Handles Volverbtn.Click
        Dim volver As New Clientes
        volver.Show()
        Me.Close()
    End Sub

    ' Boton Agregar
    Private Sub Agregarbtn_Click(sender As Object, e As EventArgs) Handles Agregarbtn.Click
        Dim dnicliente As String = Dnitxt.Text
        Dim nombrecliente As String = Nombretxt.Text
        Dim direccionCliente As String = Direcciontxt.Text
        Dim telefonoCliente As String = Telefonotxt.Text
        Dim correoCliente As String = Correotxt.Text

        Dim vdni As New cliente
        ' Validar los campos obligatorios (nombre y cantidad)
        If String.IsNullOrEmpty(dnicliente) Then
            MessageBox.Show("El campo DNI es obligatoriO.")
            Exit Sub
        End If

        ' Conectar a la base de datos y agregar el cliente
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "INSERT INTO clientes (DNI, NombreCliente, Direccion, Telefono, Correo) " &
                                      "VALUES (@DNI, @NombreCliente, @Direccion, @Telefono, @Correo)"
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar parámetros con los valores del formulario
                    cmd.Parameters.AddWithValue("@DNI", dnicliente)
                    cmd.Parameters.AddWithValue("@NombreCliente", nombrecliente)
                    cmd.Parameters.AddWithValue("@Direccion", direccionCliente)
                    cmd.Parameters.AddWithValue("@Telefono", telefonoCliente)
                    cmd.Parameters.AddWithValue("@Correo", correoCliente)
                    ' Ejecutar el comando
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Cliente agregado exitosamente.")
                    LimpiarCampos()
                End Using
            End If
        End Using
    End Sub
End Class