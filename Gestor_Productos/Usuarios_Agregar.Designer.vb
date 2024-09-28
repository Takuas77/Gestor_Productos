<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios_Agregar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Usuariotxt = New System.Windows.Forms.TextBox()
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.Contraseñatxt = New System.Windows.Forms.TextBox()
        Me.Recontraseñatxt = New System.Windows.Forms.TextBox()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.Volverbtn = New System.Windows.Forms.Button()
        Me.Agregarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Correo Electronico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Repita Contraseña:"
        '
        'Usuariotxt
        '
        Me.Usuariotxt.Location = New System.Drawing.Point(129, 19)
        Me.Usuariotxt.Name = "Usuariotxt"
        Me.Usuariotxt.Size = New System.Drawing.Size(163, 20)
        Me.Usuariotxt.TabIndex = 10
        '
        'Correotxt
        '
        Me.Correotxt.Location = New System.Drawing.Point(129, 72)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(163, 20)
        Me.Correotxt.TabIndex = 11
        '
        'Contraseñatxt
        '
        Me.Contraseñatxt.Location = New System.Drawing.Point(129, 178)
        Me.Contraseñatxt.Name = "Contraseñatxt"
        Me.Contraseñatxt.Size = New System.Drawing.Size(163, 20)
        Me.Contraseñatxt.TabIndex = 13
        '
        'Recontraseñatxt
        '
        Me.Recontraseñatxt.Location = New System.Drawing.Point(129, 231)
        Me.Recontraseñatxt.Name = "Recontraseñatxt"
        Me.Recontraseñatxt.Size = New System.Drawing.Size(163, 20)
        Me.Recontraseñatxt.TabIndex = 14
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Items.AddRange(New Object() {"Administrador", "Usuario"})
        Me.CategoriaComboBox.Location = New System.Drawing.Point(129, 125)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(163, 21)
        Me.CategoriaComboBox.TabIndex = 12
        '
        'Volverbtn
        '
        Me.Volverbtn.Location = New System.Drawing.Point(48, 291)
        Me.Volverbtn.Name = "Volverbtn"
        Me.Volverbtn.Size = New System.Drawing.Size(75, 23)
        Me.Volverbtn.TabIndex = 16
        Me.Volverbtn.Text = "Volver"
        Me.Volverbtn.UseVisualStyleBackColor = True
        '
        'Agregarbtn
        '
        Me.Agregarbtn.Location = New System.Drawing.Point(217, 291)
        Me.Agregarbtn.Name = "Agregarbtn"
        Me.Agregarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Agregarbtn.TabIndex = 15
        Me.Agregarbtn.Text = "Agregar"
        Me.Agregarbtn.UseVisualStyleBackColor = True
        '
        'Usuarios_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 338)
        Me.Controls.Add(Me.Agregarbtn)
        Me.Controls.Add(Me.Volverbtn)
        Me.Controls.Add(Me.CategoriaComboBox)
        Me.Controls.Add(Me.Recontraseñatxt)
        Me.Controls.Add(Me.Contraseñatxt)
        Me.Controls.Add(Me.Correotxt)
        Me.Controls.Add(Me.Usuariotxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Usuarios_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Usuariotxt As TextBox
    Friend WithEvents Correotxt As TextBox
    Friend WithEvents Contraseñatxt As TextBox
    Friend WithEvents Recontraseñatxt As TextBox
    Friend WithEvents CategoriaComboBox As ComboBox
    Friend WithEvents Volverbtn As Button
    Friend WithEvents Agregarbtn As Button
End Class
