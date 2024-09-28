Imports MySql.Data.MySqlClient
Public Class Productos_Del

    ' Pre carga de tablas
    Private Sub Productos_Del_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpaquetadoTableAdapter.Fill(Me.Empaquetado._empaquetado)
        Me.MarcaTableAdapter.Fill(Me.Marcas.marca)
        Me.CategoriasTableAdapter.Fill(Me.Categorias._categorias)
    End Sub

    ' limpieza de campos
    Private Sub LimpiarCampos()
        Idtxt.Clear()
        CategoriaComboBox.ResetText()
        Nombretxt.Clear()
        MarcaComboBox.ResetText()
        EmpaquetadoComboBox.ResetText()
        Cantidadtxt.Clear()
        FechaVenMonthCalendar.ResetText()
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
                    Else
                        MessageBox.Show("Producto no encontrado.")
                    End If
                End Using
            End If
        End Using
    End Sub

    ' Boton eliminar
    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click
        Dim idProducto As Integer

        ' Verificar si el ID del producto es válido
        If Not Integer.TryParse(Idtxt.Text, idProducto) Then
            MessageBox.Show("Ingrese un ID de producto válido.")
            Exit Sub
        End If

        ' Confirmar la eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        End If

        ' Conectar a la base de datos y eliminar el producto por ID
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "DELETE FROM Productos WHERE IdProducto = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idProducto)

                    ' Ejecutar el comando de eliminación
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Producto eliminado exitosamente.")

                    ' Limpiar los campos del formulario
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