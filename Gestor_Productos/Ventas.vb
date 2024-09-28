Imports MySql.Data.MySqlClient
Public Class Ventas

    ' Pre carga los registros de las tablas productos y clientes
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.Cliente.clientes)
        Me.ProductosTableAdapter.Fill(Me.Producto.productos)
    End Sub

    ' Funcio para actualizar el valor de la canasta
    Private Sub ActualizarTotalCanasta()
        Dim totalGeneral As Decimal = 0

        ' Recorrer todas las filas de la CanastaDataGridView para sumar el total
        For Each fila As DataGridViewRow In CanastaDataGridView.Rows
            totalGeneral += Convert.ToDecimal(fila.Cells("Total").Value)
        Next

        ' Mostrar el total en un TextBox o Label
        MontoTextBox.Text = totalGeneral.ToString("C") ' Mostrar como moneda
    End Sub

    ' Actualiza el stock de los productos
    Private Sub ActualizarProductos()
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                ' Consulta para obtener los productos
                Dim query As String = "SELECT * FROM productos"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()

                    ' Llenar el DataTable con los datos obtenidos
                    adapter.Fill(table)

                    ' Asignar el DataTable al DataGridView para mostrar los productos
                    ProductosDataGridView.DataSource = table
                End Using
            End If
        End Using
    End Sub

    ' Limpia los valores al finalizar una compra 
    Private Sub LimpiarCompra()
        ' Limpiar la Canasta
        CanastaDataGridView.Rows.Clear()

        ' Limpiar el TextBox del total de la compra
        MontoTextBox.Text = ""

        ' Restablecer el ComboBox de clientes
        ClienteComboBox.SelectedIndex = -1
    End Sub


    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Deshabilitar el botón Quitar al iniciar la ventana
        Quitarbtn.Enabled = False
    End Sub

    Private Sub CanastaDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles CanastaDataGridView.SelectionChanged
        ' Habilitar el botón Quitar solo si hay una fila seleccionada
        If CanastaDataGridView.SelectedRows.Count > 0 Then
            Quitarbtn.Enabled = True
        Else
            Quitarbtn.Enabled = False
        End If
    End Sub

    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim nombreProducto As String = Buscartxt.Text.Trim()

        ' Verificar si el campo de búsqueda no está vacío
        If String.IsNullOrEmpty(nombreProducto) Then
            MessageBox.Show("Por favor, ingrese el nombre de un producto para buscar.")
            Exit Sub
        End If

        ' Conectar a la base de datos y buscar los productos que coincidan con el nombre
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                ' Usar LIKE para buscar coincidencias parciales en el nombre
                Dim query As String = "SELECT * FROM productos WHERE NombreProducto LIKE @nombre"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", "%" & nombreProducto & "%")

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()

                    ' Llenar el DataTable con los productos filtrados
                    adapter.Fill(table)

                    ' Mostrar los productos filtrados
                    ProductosDataGridView.DataSource = table

                    ' Verificar si no se encontraron resultados
                    If table.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron productos que coincidan con el nombre ingresado.")
                        ActualizarProductos()
                    End If
                End Using
            End If
        End Using
    End Sub

    Private Sub Agregarbtn_Click(sender As Object, e As EventArgs) Handles Agregarbtn.Click
        ' Verificar si hay un producto seleccionado en el Productos
        If ProductosDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un producto para agregar a la canasta.")
            Exit Sub
        End If

        ' Obtener la fila seleccionada de productos
        Dim filaSeleccionada As DataGridViewRow = ProductosDataGridView.SelectedRows(0)

        ' Obtener la información del producto seleccionado
        Dim idProducto As Integer = Convert.ToInt32(filaSeleccionada.Cells("IdProductoDataGridViewTextBoxColumn").Value)
        Dim nombreProducto As String = filaSeleccionada.Cells("NombreProductoDataGridViewTextBoxColumn").Value.ToString()

        ' Convertir el precio a Decimal correctamente para evitar errores
        Dim precioProducto As Decimal = Convert.ToDecimal(filaSeleccionada.Cells("PrecioDataGridViewTextBoxColumn").Value)

        ' Preguntar al usuario la cantidad mediante un InputBox
        Dim inputCantidad As String = InputBox("Ingrese la cantidad para el producto " & nombreProducto, "Cantidad")
        Dim cantidad As Integer

        ' Validar que la cantidad ingresada sea un número válido
        If Not Integer.TryParse(inputCantidad, cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Por favor, ingrese una cantidad válida.")
            Exit Sub
        End If

        ' Calcular el total correctamente (cantidad * precio decimal)
        Dim totalProducto As Decimal = cantidad * precioProducto

        ' Agregar el producto a la CanastaDataGridView
        CanastaDataGridView.Rows.Add(idProducto, nombreProducto, cantidad, precioProducto.ToString("F2"), totalProducto.ToString("F2"))

        ' Actualizar el total general de la canasta
        ActualizarTotalCanasta()
    End Sub

    Private Sub Quitarbtn_Click(sender As Object, e As EventArgs) Handles Quitarbtn.Click
        ' Verificar si hay una fila seleccionada en CanastaDataGridView
        If CanastaDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un producto para quitar de la canasta.")
            Exit Sub
        End If

        ' Obtener la fila seleccionada en el CanastaDataGridView
        Dim filaSeleccionada As DataGridViewRow = CanastaDataGridView.SelectedRows(0)

        ' Confirmar que el usuario desea quitar el producto
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro que desea quitar este producto de la canasta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then
            ' Eliminar la fila seleccionada
            CanastaDataGridView.Rows.Remove(filaSeleccionada)

            ' Actualizar el total de la canasta
            ActualizarTotalCanasta()

            ' Si no hay filas en la canasta, deshabilitar el botón Quitar
            If CanastaDataGridView.Rows.Count = 0 Then
                Quitarbtn.Enabled = False
            End If
        End If
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim inicio As New Inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub Finalizarbtn_Click(sender As Object, e As EventArgs) Handles Finalizarbtn.Click
        ' Verificar si hay productos en la canasta
        If CanastaDataGridView.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la canasta. No se puede finalizar la compra.")
            Exit Sub
        End If

        ' Iniciar transacción de compra
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                ' Iniciar una transacción
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' Recorrer cada producto en la canasta para descontar las cantidades
                    For Each fila As DataGridViewRow In CanastaDataGridView.Rows
                        Dim idProducto As Integer = Convert.ToInt32(fila.Cells("IdProducto").Value)
                        Dim cantidadComprada As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)

                        ' Actualizar el stock del producto en la tabla productos
                        Dim queryActualizarStock As String = "UPDATE productos SET Cantidad = Cantidad - @cantidadComprada WHERE IdProducto = @idProducto AND Cantidad >= @cantidadComprada"
                        Using cmdActualizar As New MySqlCommand(queryActualizarStock, conn, transaction)
                            cmdActualizar.Parameters.AddWithValue("@cantidadComprada", cantidadComprada)
                            cmdActualizar.Parameters.AddWithValue("@idProducto", idProducto)

                            ' Ejecutar el comando de actualización
                            Dim filasActualizadas As Integer = cmdActualizar.ExecuteNonQuery()

                            ' Verificar que el stock haya sido actualizado correctamente
                            If filasActualizadas = 0 Then
                                ' Si no se pudo actualizar el stock, posiblemente no hay suficiente cantidad
                                MessageBox.Show("No hay suficiente stock para el producto con ID: " & idProducto)
                                transaction.Rollback() ' Revertir la transacción
                                Exit Sub
                            End If
                        End Using
                    Next

                    ' Confirmar la transacción (finalizar la compra)
                    transaction.Commit()
                    MessageBox.Show("Compra finalizada exitosamente.")
                    LimpiarCompra()
                    ActualizarProductos()

                Catch ex As Exception
                    ' En caso de error, revertir la transacción
                    transaction.Rollback()
                    MessageBox.Show("Error al finalizar la compra: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub Ticketbtn_Click(sender As Object, e As EventArgs) Handles Ticketbtn.Click
        ' Verificar que haya un cliente seleccionado
        If ClienteComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un cliente.")
            Exit Sub
        End If

        ' Obtener el IdCliente seleccionado
        Dim idCliente As Integer = Convert.ToInt32(ClienteComboBox.SelectedValue)

        ' Declarar variables para almacenar los datos del cliente
        Dim DniCliente As String = ""
        Dim nombreCliente As String = ""
        Dim direccionCliente As String = ""
        Dim telefonoCliente As String = ""
        Dim correoCliente As String = ""

        ' Conectar a la base de datos y obtener los datos del cliente
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT DNI, NombreCliente, Direccion, Telefono, Correo FROM clientes WHERE IdCliente = @idCliente"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idCliente", idCliente)

                    Try
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Asignar los datos del cliente
                                DniCliente = reader("DNI").ToString()
                                nombreCliente = reader("NombreCliente").ToString()
                                direccionCliente = reader("Direccion").ToString()
                                telefonoCliente = reader("Telefono").ToString()
                                correoCliente = reader("Correo").ToString()
                            Else
                                MessageBox.Show("Cliente no encontrado.")
                                Exit Sub
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error al obtener los datos del cliente: " & ex.Message)
                        Exit Sub
                    End Try
                End Using
            End If
        End Using

        ' Verificar que haya productos en la canasta
        If CanastaDataGridView.Rows.Count = 0 Then
            MessageBox.Show("La canasta está vacía. No se puede generar la factura.")
            Exit Sub
        End If

        ' Crear el archivo de factura
        Dim rutaArchivo As String = "C:\facturas\" & nombreCliente & "_factura_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".txt"

        ' Crear el contenido de la factura
        Using sw As New System.IO.StreamWriter(rutaArchivo)
            ' Escribir la cabecera de la factura
            sw.WriteLine("=========================================")
            sw.WriteLine("                 FACTURA                 ")
            sw.WriteLine("=========================================")
            sw.WriteLine("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
            sw.WriteLine("DNI: " & DniCliente)
            sw.WriteLine("Cliente: " & nombreCliente)
            sw.WriteLine("Dirección: " & direccionCliente)
            sw.WriteLine("Teléfono: " & telefonoCliente)
            sw.WriteLine("Correo: " & correoCliente)
            sw.WriteLine("-----------------------------------------")
            sw.WriteLine("Productos: ")
            sw.WriteLine("")

            ' Escribir los productos de la canasta
            For Each fila As DataGridViewRow In CanastaDataGridView.Rows
                Dim nombreProducto As String = fila.Cells("NombreProducto").Value.ToString()
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
                Dim precioUnitario As Decimal = Convert.ToDecimal(fila.Cells("Precio").Value)
                Dim totalProducto As Decimal = Convert.ToDecimal(fila.Cells("Total").Value)

                ' Escribir el producto
                sw.WriteLine(nombreProducto & vbTab & " Cantidad: " & cantidad & vbTab & " Precio: $" & precioUnitario & vbTab & " Total: $" & totalProducto)
            Next

            ' Escribir el total de la venta
            Dim totalVenta As Decimal = 0
            For Each fila As DataGridViewRow In CanastaDataGridView.Rows
                totalVenta += Convert.ToDecimal(fila.Cells("Total").Value)
            Next

            sw.WriteLine("-----------------------------------------")
            sw.WriteLine("Total de la venta: $" & totalVenta.ToString("F2"))
            sw.WriteLine("=========================================")

            ' Cerrar el archivo
            sw.Close()
        End Using

        ' Informar al usuario que la factura se ha generado
        MessageBox.Show("Factura generada correctamente: " & rutaArchivo)
    End Sub
End Class