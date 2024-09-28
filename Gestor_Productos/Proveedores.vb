Public Class Proveedores

    ' Pre carga de tablas
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProveedoresTableAdapter.Fill(Me.Proveedor.proveedores)
    End Sub

    ' Boton Volver
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim inicio As New Inicio
        inicio.Show()
        Me.Close()
    End Sub

    ' Boton alta
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim alta As New Proveedores_Alta
        alta.Show()
        Me.Close()
    End Sub

    ' Boton Modifcar
    Private Sub ModificarUnProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUnProveedorToolStripMenuItem.Click
        Dim modif As New Proveedores_Mod
        modif.Show()
        Me.Close()
    End Sub

    ' Boton baja
    Private Sub BajaDeUnProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeUnProveedorToolStripMenuItem.Click
        Dim baja As New Proveedores_Baja
        baja.Show()
        Me.Close()
    End Sub
End Class