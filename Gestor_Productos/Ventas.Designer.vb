<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CantidadesVendidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente = New Gestor_Productos.cliente()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpaquetadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Producto = New Gestor_Productos.producto()
        Me.CanastaDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buscartxt = New System.Windows.Forms.TextBox()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.Agregarbtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Quitarbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductosTableAdapter = New Gestor_Productos.productoTableAdapters.productosTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Finalizarbtn = New System.Windows.Forms.Button()
        Me.Ticketbtn = New System.Windows.Forms.Button()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New Gestor_Productos.clienteTableAdapters.clientesTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanastaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1138, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CantidadesVendidasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'CantidadesVendidasToolStripMenuItem
        '
        Me.CantidadesVendidasToolStripMenuItem.Name = "CantidadesVendidasToolStripMenuItem"
        Me.CantidadesVendidasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CantidadesVendidasToolStripMenuItem.Text = "Cantidades Vendidas"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraficosToolStripMenuItem})
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'GraficosToolStripMenuItem
        '
        Me.GraficosToolStripMenuItem.Name = "GraficosToolStripMenuItem"
        Me.GraficosToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.GraficosToolStripMenuItem.Text = "Graficos"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataSource = Me.ClientesBindingSource
        Me.ClienteComboBox.DisplayMember = "NombreCliente"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(54, 22)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(327, 21)
        Me.ClienteComboBox.TabIndex = 1
        Me.ClienteComboBox.ValueMember = "IdCliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.Cliente
        '
        'Cliente
        '
        Me.Cliente.DataSetName = "cliente"
        Me.Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.EmpaquetadoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(18, 72)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.Size = New System.Drawing.Size(843, 215)
        Me.ProductosDataGridView.TabIndex = 2
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        Me.NombreProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpaquetadoDataGridViewTextBoxColumn
        '
        Me.EmpaquetadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpaquetadoDataGridViewTextBoxColumn.DataPropertyName = "Empaquetado"
        Me.EmpaquetadoDataGridViewTextBoxColumn.HeaderText = "Empaquetado"
        Me.EmpaquetadoDataGridViewTextBoxColumn.Name = "EmpaquetadoDataGridViewTextBoxColumn"
        Me.EmpaquetadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.Producto
        '
        'Producto
        '
        Me.Producto.DataSetName = "producto"
        Me.Producto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CanastaDataGridView
        '
        Me.CanastaDataGridView.AllowUserToAddRows = False
        Me.CanastaDataGridView.AllowUserToDeleteRows = False
        Me.CanastaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CanastaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.NombreProducto, Me.Cantidad, Me.Precio, Me.Total})
        Me.CanastaDataGridView.Location = New System.Drawing.Point(6, 49)
        Me.CanastaDataGridView.Name = "CanastaDataGridView"
        Me.CanastaDataGridView.ReadOnly = True
        Me.CanastaDataGridView.Size = New System.Drawing.Size(1102, 156)
        Me.CanastaDataGridView.TabIndex = 3
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'NombreProducto
        '
        Me.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreProducto.HeaderText = "Producto"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buscartxt)
        Me.GroupBox1.Controls.Add(Me.Buscarbtn)
        Me.GroupBox1.Controls.Add(Me.Agregarbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 266)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tienda:"
        '
        'Buscartxt
        '
        Me.Buscartxt.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Buscartxt.Location = New System.Drawing.Point(9, 19)
        Me.Buscartxt.Name = "Buscartxt"
        Me.Buscartxt.Size = New System.Drawing.Size(169, 20)
        Me.Buscartxt.TabIndex = 4
        Me.Buscartxt.Text = "Producto a Buscar..."
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(184, 17)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 3
        Me.Buscarbtn.Text = "Buscar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'Agregarbtn
        '
        Me.Agregarbtn.Location = New System.Drawing.Point(692, 17)
        Me.Agregarbtn.Name = "Agregarbtn"
        Me.Agregarbtn.Size = New System.Drawing.Size(157, 23)
        Me.Agregarbtn.TabIndex = 2
        Me.Agregarbtn.Text = "Agregar a Canasta"
        Me.Agregarbtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Quitarbtn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CanastaDataGridView)
        Me.GroupBox2.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1114, 211)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Canasta:"
        '
        'Quitarbtn
        '
        Me.Quitarbtn.Location = New System.Drawing.Point(946, 16)
        Me.Quitarbtn.Name = "Quitarbtn"
        Me.Quitarbtn.Size = New System.Drawing.Size(162, 23)
        Me.Quitarbtn.TabIndex = 4
        Me.Quitarbtn.Text = "Quitar de la Canasta"
        Me.Quitarbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Finalizarbtn)
        Me.GroupBox3.Controls.Add(Me.Ticketbtn)
        Me.GroupBox3.Controls.Add(Me.MontoTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(875, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 266)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TOTAL"
        '
        'Finalizarbtn
        '
        Me.Finalizarbtn.Location = New System.Drawing.Point(6, 184)
        Me.Finalizarbtn.Name = "Finalizarbtn"
        Me.Finalizarbtn.Size = New System.Drawing.Size(239, 53)
        Me.Finalizarbtn.TabIndex = 2
        Me.Finalizarbtn.Text = "Finalizar Compra"
        Me.Finalizarbtn.UseVisualStyleBackColor = True
        '
        'Ticketbtn
        '
        Me.Ticketbtn.Location = New System.Drawing.Point(6, 107)
        Me.Ticketbtn.Name = "Ticketbtn"
        Me.Ticketbtn.Size = New System.Drawing.Size(239, 47)
        Me.Ticketbtn.TabIndex = 1
        Me.Ticketbtn.Text = "Generar Ticket"
        Me.Ticketbtn.UseVisualStyleBackColor = True
        '
        'MontoTextBox
        '
        Me.MontoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoTextBox.Location = New System.Drawing.Point(6, 19)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.ReadOnly = True
        Me.MontoTextBox.Size = New System.Drawing.Size(239, 62)
        Me.MontoTextBox.TabIndex = 0
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 522)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanastaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CantidadesVendidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraficosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteComboBox As ComboBox
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents CanastaDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Agregarbtn As Button
    Friend WithEvents Quitarbtn As Button
    Friend WithEvents Producto As producto
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As productoTableAdapters.productosTableAdapter
    Friend WithEvents Buscarbtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Buscartxt As TextBox
    Friend WithEvents Finalizarbtn As Button
    Friend WithEvents Ticketbtn As Button
    Friend WithEvents MontoTextBox As TextBox
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpaquetadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As cliente
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As clienteTableAdapters.clientesTableAdapter
End Class
