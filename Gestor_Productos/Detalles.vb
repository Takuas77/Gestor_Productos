Public Class Detalles
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim inicio As New Inicio
        inicio.Show()
        Me.Close()
    End Sub
End Class