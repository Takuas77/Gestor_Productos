Public Class Clientes

    ' Boton volver
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim inicio As New Inicio
        inicio.Show()
        Me.Close()
    End Sub

    ' Boton alta
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim alta As New Clientes_Alta
        alta.Show()
        Me.Close()
    End Sub

    ' Boton modificar
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionToolStripMenuItem.Click
        Dim modificacion As New Clientes_Mod
        modificacion.Show()
        Me.Close()
    End Sub

    ' Boton baja
    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        Dim baja As New Clientes_Baja
        baja.Show()
        Me.Close()
    End Sub

    ' Carga los clientes al comienzo 
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.Cliente.clientes)
    End Sub
End Class