Imports MySql.Data.MySqlClient
Public Class Productos_Mod

    ' Pre carga de tablas
    Private Sub Productos_Mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpaquetadoTableAdapter.Fill(Me.Empaquetado._empaquetado)
        Me.MarcaTableAdapter.Fill(Me.Marcas.marca)
        Me.CategoriasTableAdapter.Fill(Me.Categorias._categorias)

    End Sub

    ' Limpieza de campos
    Private Sub LimpiarCampos()
        Idtxt.Clear()
        CategoriaComboBox.ResetText()
        Nombretxt.Clear()
        MarcaComboBox.ResetText()
        EmpaquetadoComboBox.ResetText()
        Cantidadtxt.Clear()
        FechaVenMonthCalendar.ResetText()
        CategoriaComboBox.Enabled = False
        Nombretxt.Enabled = False
        MarcaComboBox.Enabled = False
        EmpaquetadoComboBox.Enabled = False
        Cantidadtxt.Enabled = False
        FechaVenMonthCalendar.Enabled = False
        Modificarbtn.Enabled = False
        Idtxt.Focus()
    End Sub

    ' Boton Buscar
    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim idProducto As Integer

        ' Verificar si el ID del producto es válido
        If Not Integer.TryParse(Idtxt.Text, idProducto) Then
            MessageBox.Show("Ingrese un ID de producto válido.")
            Exit Sub
        End If

        ' Conectar a la base de datos y buscar el producto por ID
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT * FROM Productos WHERE IdProducto = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idProducto)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    ' Verificar si se encontró el producto
                    If reader.Read() Then
                        ' Llenar los TextBox con los datos del producto
                        CategoriaComboBox.Text = reader("Categoria").ToString()
                        Nombretxt.Text = reader("NombreProducto").ToString()
                        MarcaComboBox.Text = reader("Marca").ToString()
                        EmpaquetadoComboBox.Text = reader("Empaquetado").ToString()
                        Cantidadtxt.Text = reader("Cantidad").ToString()
                        FechaVenMonthCalendar.Text = Convert.ToDateTime(reader("FechaVencimiento")).ToString("yyyy-MM-dd")
                        CategoriaComboBox.Enabled = True
                        Nombretxt.Enabled = True
                        MarcaComboBox.Enabled = True
                        EmpaquetadoComboBox.Enabled = True
                        Cantidadtxt.Enabled = True
                        FechaVenMonthCalendar.Enabled = True
                        Modificarbtn.Enabled = True
                    Else
                        MessageBox.Show("Producto no encontrado.")
                    End If
                End Using
            End If
        End Using
    End Sub

    ' Boton Modifcar
    Private Sub Modificarbtn_Click(sender As Object, e As EventArgs) Handles Modificarbtn.Click
        Dim idProducto As Integer
        Dim categoria As String = CategoriaComboBox.Text
        Dim nombre As String = Nombretxt.Text
        Dim marca As String = MarcaComboBox.Text
        Dim empaquetado As String = EmpaquetadoComboBox.Text
        Dim cantidad As Integer
        Dim fechaVencimiento As Date

        ' Validar el ID del producto
        If Not Integer.TryParse(Idtxt.Text, idProducto) Then
            MessageBox.Show("ID de producto inválido.")
            Exit Sub
        End If

        ' Validar los campos obligatorios
        If String.IsNullOrEmpty(nombre) OrElse Not Integer.TryParse(Cantidadtxt.Text, cantidad) Then
            MessageBox.Show("El campo Nombre y Cantidad son obligatorios.")
            Exit Sub
        End If

        ' Validar la fecha de vencimiento
        If Not Date.TryParse(FechaVenMonthCalendar.Text, fechaVencimiento) Then
            MessageBox.Show("Fecha de vencimiento inválida.")
            Exit Sub
        End If

        ' Conectar a la base de datos y actualizar el producto
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "UPDATE Productos SET Categoria = @categoria, NombreProducto = @nombre, Marca = @marca, " &
                                      "Empaquetado = @empaquetado, Cantidad = @cantidad, FechaVencimiento = @fechaVencimiento WHERE IdProducto = @id"
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar los parámetros con los valores del formulario
                    cmd.Parameters.AddWithValue("@categoria", categoria)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@marca", marca)
                    cmd.Parameters.AddWithValue("@empaquetado", empaquetado)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento)
                    cmd.Parameters.AddWithValue("@id", idProducto)

                    ' Ejecutar la consulta de actualización
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Producto modificado exitosamente.")
                    LimpiarCampos()
                End Using
            End If
        End Using
    End Sub

    ' Botono Volver
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles Cancelarbtn.Click
        Dim productos As New Productos()
        productos.Show()
        Me.Close()
    End Sub
End Class