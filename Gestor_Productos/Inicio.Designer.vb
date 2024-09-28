<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Clientesbtn = New System.Windows.Forms.Button()
        Me.Proveedoresbtn = New System.Windows.Forms.Button()
        Me.Ventasbtn = New System.Windows.Forms.Button()
        Me.Productosbtn = New System.Windows.Forms.Button()
        Me.Detallesbtn = New System.Windows.Forms.Button()
        Me.Categoriabtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Clientesbtn
        '
        Me.Clientesbtn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Clientesbtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientesbtn.Image = Global.Gestor_Productos.My.Resources.Resources.groups_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24
        Me.Clientesbtn.Location = New System.Drawing.Point(47, 46)
        Me.Clientesbtn.Name = "Clientesbtn"
        Me.Clientesbtn.Size = New System.Drawing.Size(186, 160)
        Me.Clientesbtn.TabIndex = 0
        Me.Clientesbtn.Text = "Clientes"
        Me.Clientesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Clientesbtn.UseVisualStyleBackColor = False
        '
        'Proveedoresbtn
        '
        Me.Proveedoresbtn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Proveedoresbtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedoresbtn.Image = Global.Gestor_Productos.My.Resources.Resources.conveyor_belt_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24
        Me.Proveedoresbtn.Location = New System.Drawing.Point(47, 245)
        Me.Proveedoresbtn.Name = "Proveedoresbtn"
        Me.Proveedoresbtn.Size = New System.Drawing.Size(186, 160)
        Me.Proveedoresbtn.TabIndex = 1
        Me.Proveedoresbtn.Text = "Proveedores"
        Me.Proveedoresbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Proveedoresbtn.UseVisualStyleBackColor = False
        '
        'Ventasbtn
        '
        Me.Ventasbtn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Ventasbtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventasbtn.Image = Global.Gestor_Productos.My.Resources.Resources.currency_exchange_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24
        Me.Ventasbtn.Location = New System.Drawing.Point(302, 245)
        Me.Ventasbtn.Name = "Ventasbtn"
        Me.Ventasbtn.Size = New System.Drawing.Size(186, 160)
        Me.Ventasbtn.TabIndex = 3
        Me.Ventasbtn.Text = "Ventas"
        Me.Ventasbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ventasbtn.UseVisualStyleBackColor = False
        '
        'Productosbtn
        '
        Me.Productosbtn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Productosbtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productosbtn.Image = Global.Gestor_Productos.My.Resources.Resources.inventory_2_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24
        Me.Productosbtn.Location = New System.Drawing.Point(302, 46)
        Me.Productosbtn.Name = "Productosbtn"
        Me.Productosbtn.Size = New System.Drawing.Size(186, 160)
        Me.Productosbtn.TabIndex = 2
        Me.Productosbtn.Text = "Productos"
        Me.Productosbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Productosbtn.UseVisualStyleBackColor = False
        '
        'Detallesbtn
        '
        Me.Detallesbtn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Detallesbtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detallesbtn.Image = Global.Gestor_Productos.My.Resources.Resources.info_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24
        Me.Detallesbtn.Location = New System.Drawing.Point(557, 245)
        Me.Detallesbtn.Name = "Detallesbtn"
        Me.Detallesbtn.Size = New System.Drawing.Size(186, 160)
        Me.Detallesbtn.TabIndex = 5
        Me.Detallesbtn.Text = "Detalles"
        Me.Detallesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Detallesbtn.UseVisualStyleBackColor = False
        '
        'Categoriabtn
        '
        Me.Categoriabtn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Categoriabtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categoriabtn.Image = Global.Gestor_Productos.My.Resources.Resources.category_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24
        Me.Categoriabtn.Location = New System.Drawing.Point(557, 46)
        Me.Categoriabtn.Name = "Categoriabtn"
        Me.Categoriabtn.Size = New System.Drawing.Size(186, 160)
        Me.Categoriabtn.TabIndex = 4
        Me.Categoriabtn.Text = "Categorias"
        Me.Categoriabtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Categoriabtn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarUsuariosToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AdministrarUsuariosToolStripMenuItem
        '
        Me.AdministrarUsuariosToolStripMenuItem.Name = "AdministrarUsuariosToolStripMenuItem"
        Me.AdministrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AdministrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem1, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Detallesbtn)
        Me.Controls.Add(Me.Categoriabtn)
        Me.Controls.Add(Me.Ventasbtn)
        Me.Controls.Add(Me.Productosbtn)
        Me.Controls.Add(Me.Proveedoresbtn)
        Me.Controls.Add(Me.Clientesbtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clientesbtn As Button
    Friend WithEvents Proveedoresbtn As Button
    Friend WithEvents Ventasbtn As Button
    Friend WithEvents Productosbtn As Button
    Friend WithEvents Detallesbtn As Button
    Friend WithEvents Categoriabtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
