<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos_Add
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Agregarbtn = New System.Windows.Forms.Button()
        Me.Cancelarbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Categorias = New Gestor_Productos.categorias()
        Me.EmpaquetadoComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpaquetadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empaquetado = New Gestor_Productos.empaquetado()
        Me.MarcaComboBox = New System.Windows.Forms.ComboBox()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Marcas = New Gestor_Productos.marcas()
        Me.Idtxt = New System.Windows.Forms.TextBox()
        Me.Cantidadtxt = New System.Windows.Forms.TextBox()
        Me.Nombretxt = New System.Windows.Forms.TextBox()
        Me.FechaVenMonthCalendar = New System.Windows.Forms.DateTimePicker()
        Me.CategoriasTableAdapter = New Gestor_Productos.categoriasTableAdapters.categoriasTableAdapter()
        Me.MarcaTableAdapter = New Gestor_Productos.marcasTableAdapters.marcaTableAdapter()
        Me.EmpaquetadoTableAdapter = New Gestor_Productos.empaquetadoTableAdapters.empaquetadoTableAdapter()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpaquetadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empaquetado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agregarbtn
        '
        Me.Agregarbtn.Location = New System.Drawing.Point(398, 44)
        Me.Agregarbtn.Name = "Agregarbtn"
        Me.Agregarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Agregarbtn.TabIndex = 20
        Me.Agregarbtn.Text = "Agregar"
        Me.Agregarbtn.UseVisualStyleBackColor = True
        '
        'Cancelarbtn
        '
        Me.Cancelarbtn.Location = New System.Drawing.Point(398, 215)
        Me.Cancelarbtn.Name = "Cancelarbtn"
        Me.Cancelarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelarbtn.TabIndex = 21
        Me.Cancelarbtn.Text = "Volver"
        Me.Cancelarbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categoria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Empaquetado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Fecha de Vencimiento:"
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataSource = Me.CategoriasBindingSource
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(134, 46)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(248, 21)
        Me.CategoriaComboBox.TabIndex = 14
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.Categorias
        '
        'Categorias
        '
        Me.Categorias.DataSetName = "categorias"
        Me.Categorias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpaquetadoComboBox
        '
        Me.EmpaquetadoComboBox.DataSource = Me.EmpaquetadoBindingSource
        Me.EmpaquetadoComboBox.DisplayMember = "Empaquetado"
        Me.EmpaquetadoComboBox.FormattingEnabled = True
        Me.EmpaquetadoComboBox.Location = New System.Drawing.Point(134, 151)
        Me.EmpaquetadoComboBox.Name = "EmpaquetadoComboBox"
        Me.EmpaquetadoComboBox.Size = New System.Drawing.Size(248, 21)
        Me.EmpaquetadoComboBox.TabIndex = 17
        '
        'EmpaquetadoBindingSource
        '
        Me.EmpaquetadoBindingSource.DataMember = "empaquetado"
        Me.EmpaquetadoBindingSource.DataSource = Me.Empaquetado
        '
        'Empaquetado
        '
        Me.Empaquetado.DataSetName = "empaquetado"
        Me.Empaquetado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcaComboBox
        '
        Me.MarcaComboBox.DataSource = Me.MarcaBindingSource
        Me.MarcaComboBox.DisplayMember = "Marca"
        Me.MarcaComboBox.FormattingEnabled = True
        Me.MarcaComboBox.Location = New System.Drawing.Point(134, 116)
        Me.MarcaComboBox.Name = "MarcaComboBox"
        Me.MarcaComboBox.Size = New System.Drawing.Size(248, 21)
        Me.MarcaComboBox.TabIndex = 16
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "marca"
        Me.MarcaBindingSource.DataSource = Me.Marcas
        '
        'Marcas
        '
        Me.Marcas.DataSetName = "marcas"
        Me.Marcas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Idtxt
        '
        Me.Idtxt.Enabled = False
        Me.Idtxt.Location = New System.Drawing.Point(134, 11)
        Me.Idtxt.Name = "Idtxt"
        Me.Idtxt.Size = New System.Drawing.Size(248, 20)
        Me.Idtxt.TabIndex = 13
        '
        'Cantidadtxt
        '
        Me.Cantidadtxt.Location = New System.Drawing.Point(134, 186)
        Me.Cantidadtxt.Name = "Cantidadtxt"
        Me.Cantidadtxt.Size = New System.Drawing.Size(248, 20)
        Me.Cantidadtxt.TabIndex = 18
        '
        'Nombretxt
        '
        Me.Nombretxt.Location = New System.Drawing.Point(134, 81)
        Me.Nombretxt.Name = "Nombretxt"
        Me.Nombretxt.Size = New System.Drawing.Size(248, 20)
        Me.Nombretxt.TabIndex = 15
        '
        'FechaVenMonthCalendar
        '
        Me.FechaVenMonthCalendar.Location = New System.Drawing.Point(134, 218)
        Me.FechaVenMonthCalendar.Name = "FechaVenMonthCalendar"
        Me.FechaVenMonthCalendar.Size = New System.Drawing.Size(248, 20)
        Me.FechaVenMonthCalendar.TabIndex = 19
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'EmpaquetadoTableAdapter
        '
        Me.EmpaquetadoTableAdapter.ClearBeforeFill = True
        '
        'Productos_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 246)
        Me.Controls.Add(Me.FechaVenMonthCalendar)
        Me.Controls.Add(Me.Nombretxt)
        Me.Controls.Add(Me.Cantidadtxt)
        Me.Controls.Add(Me.Idtxt)
        Me.Controls.Add(Me.MarcaComboBox)
        Me.Controls.Add(Me.EmpaquetadoComboBox)
        Me.Controls.Add(Me.CategoriaComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancelarbtn)
        Me.Controls.Add(Me.Agregarbtn)
        Me.Name = "Productos_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar"
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpaquetadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empaquetado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Marcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Agregarbtn As Button
    Friend WithEvents Cancelarbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CategoriaComboBox As ComboBox
    Friend WithEvents EmpaquetadoComboBox As ComboBox
    Friend WithEvents MarcaComboBox As ComboBox
    Friend WithEvents Idtxt As TextBox
    Friend WithEvents Cantidadtxt As TextBox
    Friend WithEvents Nombretxt As TextBox
    Friend WithEvents FechaVenMonthCalendar As DateTimePicker
    Friend WithEvents Categorias As categorias
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasTableAdapter As categoriasTableAdapters.categoriasTableAdapter
    Friend WithEvents Marcas As marcas
    Friend WithEvents MarcaBindingSource As BindingSource
    Friend WithEvents MarcaTableAdapter As marcasTableAdapters.marcaTableAdapter
    Friend WithEvents Empaquetado As empaquetado
    Friend WithEvents EmpaquetadoBindingSource As BindingSource
    Friend WithEvents EmpaquetadoTableAdapter As empaquetadoTableAdapters.empaquetadoTableAdapter
End Class
