Imports MySql.Data.MySqlClient
Public Class Productos_Add

    ' Pre carga de tablas 
    Private Sub Productos_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpaquetadoTableAdapter.Fill(Me.Empaquetado._empaquetado)
        Me.MarcaTableAdapter.Fill(Me.Marcas.marca)
        Me.CategoriasTableAdapter.Fill(Me.Categorias._categorias)
    End Sub

    ' Limpia los campos
    Private Sub LimpiarCampos()
        CategoriaComboBox.ResetText()
        Nombretxt.Clear()
        MarcaComboBox.ResetText()
        EmpaquetadoComboBox.ResetText()
        Cantidadtxt.Clear()
        FechaVenMonthCalendar.ResetText()
    End Sub


    ' Boton Agregar
    Private Sub Agregarbtn_Click(sender As Object, e As EventArgs) Handles Agregarbtn.Click
        Dim categoria As String = CategoriaComboBox.Text
        Dim nombre As String = Nombretxt.Text
        Dim marca As String = MarcaComboBox.Text
        Dim empaquetado As String = EmpaquetadoComboBox.Text
        Dim cantidad As Integer
        Dim fechaVencimiento As Date

        ' Validar los campos obligatorios (nombre y cantidad)
        If String.IsNullOrEmpty(nombre) OrElse Not Integer.TryParse(Cantidadtxt.Text, cantidad) Then
            MessageBox.Show("El campo Nombre y Cantidad son obligatorios y deben ser válidos.")
            Exit Sub
        End If

        ' Validar la fecha de vencimiento
        If Not Date.TryParse(FechaVenMonthCalendar.Text, fechaVencimiento) Then
            MessageBox.Show("Fecha de vencimiento inválida.")
            Exit Sub
        End If

        ' Conectar a la base de datos y agregar el producto
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "INSERT INTO Productos (Categoria, NombreProducto, Marca, Empaquetado, Cantidad, FechaVencimiento) " &
                                      "VALUES (@categoria, @nombre, @marca, @empaquetado, @cantidad, @fechaVencimiento)"
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar parámetros con los valores del formulario
                    cmd.Parameters.AddWithValue("@categoria", categoria)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@marca", marca)
                    cmd.Parameters.AddWithValue("@empaquetado", empaquetado)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento)

                    ' Ejecutar el comando
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Producto agregado exitosamente.")

                    ' Limpiar los TextBox después de agregar el producto
                    LimpiarCampos()
                End Using
            End If
        End Using
    End Sub

    ' Boton Volver
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles Cancelarbtn.Click
        Dim productos As New Productos()
        productos.Show()
        Me.Hide()
    End Sub
End Class