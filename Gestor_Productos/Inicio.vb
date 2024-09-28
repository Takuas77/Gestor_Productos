Public Class Inicio

    ' Validacion segun el ROL del usuario
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Verificar el rol del usuario al cargar el formulario
        If CurrentUserRole = "Administrador" Then
            ' Permitir acceso a funcionalidades avanzadas
            AdministrarUsuariosToolStripMenuItem.Enabled = True
            Categoriabtn.Enabled = True
        Else
            ' Restringir acceso si no es administrador
            AdministrarUsuariosToolStripMenuItem.Enabled = False
            Categoriabtn.Enabled = False
        End If
    End Sub

    ' Boton clientes
    Private Sub Clientesbtn_Click(sender As Object, e As EventArgs) Handles Clientesbtn.Click
        Dim clientes As New Clientes()
        clientes.Show()
        Me.Close()
    End Sub

    ' Boton Productos
    Private Sub Productosbtn_Click(sender As Object, e As EventArgs) Handles Productosbtn.Click
        Dim productos As New Productos()
        productos.Show()
        Me.Close()
    End Sub

    ' Boton Categorias
    Private Sub Categoriabtn_Click(sender As Object, e As EventArgs) Handles Categoriabtn.Click
        Dim categoria As New Categoria()
        categoria.Show()
        Me.Close()
    End Sub

    ' Boton Proveedores
    Private Sub Proveedoresbtn_Click(sender As Object, e As EventArgs) Handles Proveedoresbtn.Click
        Dim proveedores As New Proveedores()
        proveedores.Show()
        Me.Close()
    End Sub

    ' Booton Ventas
    Private Sub Ventasbtn_Click(sender As Object, e As EventArgs) Handles Ventasbtn.Click
        Dim ventas As New Ventas()
        ventas.Show()
        Me.Close()
    End Sub

    ' Boton Detalles
    Private Sub Detallesbtn_Click(sender As Object, e As EventArgs) Handles Detallesbtn.Click
        Dim detalles As New Detalles()
        detalles.Show()
        Me.Close()
    End Sub

    ' Boton administrar usuarios (solo para rol admin)
    Private Sub AdministrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarUsuariosToolStripMenuItem.Click
        Dim UsuariosAdmin As New Usuario_Administrar()
        UsuariosAdmin.Show()
        Me.Close()
    End Sub

    ' Boton Cerrar Sesion
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim login As New Login()
        login.Show()
        Me.Close()
    End Sub

End Class
