Public Class Categoria
    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Categorias._categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.Categorias._categorias)

    End Sub

    ' Boton Volver
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim inicio As New Inicio
        inicio.Show()
        Me.Close()
    End Sub

    ' Boton Agregar
    Private Sub AgregarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCategoriaToolStripMenuItem.Click
        Dim agregar As New Categoria_Alta
        agregar.Show()
        Me.Hide()
    End Sub

    'Boton Eliminar
    Private Sub EliminarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarCategoriaToolStripMenuItem.Click
        Dim eliminar As New Categoria_Baja
        eliminar.Show()
        Me.Hide()
    End Sub
End Class