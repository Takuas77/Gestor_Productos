Public Class Productos

    ' Boton Alta de productos
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim AgregarProd As New Productos_Add()
        AgregarProd.Show()
        Me.Hide()
    End Sub

    ' Boton Baja de productos
    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        Dim ModificarProd As New Productos_Mod()
        ModificarProd.Show()
        Me.Hide()
    End Sub

    ' Boton Modificar Productos
    Private Sub ModificacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionToolStripMenuItem.Click
        Dim EliminarProd As New Productos_Del()
        EliminarProd.Show()
        Me.Hide()
    End Sub

    ' Pre Carga de datos de la tabla Priductos
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter.Fill(Me.Producto.productos)

    End Sub

    ' Boton Volver
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim Inicio As New Inicio()
        Inicio.Show()
        Me.Close()
    End Sub
End Class