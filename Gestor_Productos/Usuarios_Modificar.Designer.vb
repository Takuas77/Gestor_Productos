<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios_Modificar
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
        Me.Modificarbtn = New System.Windows.Forms.Button()
        Me.Volverbtn = New System.Windows.Forms.Button()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.Recontraseñatxt = New System.Windows.Forms.TextBox()
        Me.Contraseñatxt = New System.Windows.Forms.TextBox()
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.Usuariotxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Modificarbtn
        '
        Me.Modificarbtn.Location = New System.Drawing.Point(217, 290)
        Me.Modificarbtn.Name = "Modificarbtn"
        Me.Modificarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Modificarbtn.TabIndex = 23
        Me.Modificarbtn.Text = "Modificar"
        Me.Modificarbtn.UseVisualStyleBackColor = True
        '
        'Volverbtn
        '
        Me.Volverbtn.Location = New System.Drawing.Point(48, 290)
        Me.Volverbtn.Name = "Volverbtn"
        Me.Volverbtn.Size = New System.Drawing.Size(75, 23)
        Me.Volverbtn.TabIndex = 24
        Me.Volverbtn.Text = "Volver"
        Me.Volverbtn.UseVisualStyleBackColor = True
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Items.AddRange(New Object() {"Admin", "User"})
        Me.CategoriaComboBox.Location = New System.Drawing.Point(129, 124)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(163, 21)
        Me.CategoriaComboBox.TabIndex = 20
        '
        'Recontraseñatxt
        '
        Me.Recontraseñatxt.Location = New System.Drawing.Point(129, 230)
        Me.Recontraseñatxt.Name = "Recontraseñatxt"
        Me.Recontraseñatxt.Size = New System.Drawing.Size(163, 20)
        Me.Recontraseñatxt.TabIndex = 22
        '
        'Contraseñatxt
        '
        Me.Contraseñatxt.Location = New System.Drawing.Point(129, 177)
        Me.Contraseñatxt.Name = "Contraseñatxt"
        Me.Contraseñatxt.Size = New System.Drawing.Size(163, 20)
        Me.Contraseñatxt.TabIndex = 21
        '
        'Correotxt
        '
        Me.Correotxt.Location = New System.Drawing.Point(129, 71)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(163, 20)
        Me.Correotxt.TabIndex = 19
        '
        'Usuariotxt
        '
        Me.Usuariotxt.Enabled = False
        Me.Usuariotxt.Location = New System.Drawing.Point(129, 18)
        Me.Usuariotxt.Name = "Usuariotxt"
        Me.Usuariotxt.Size = New System.Drawing.Size(163, 20)
        Me.Usuariotxt.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Repita Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Correo Electronico:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Usuario:"
        '
        'Usuarios_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 331)
        Me.Controls.Add(Me.Modificarbtn)
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
        Me.Name = "Usuarios_Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Modificarbtn As Button
    Friend WithEvents Volverbtn As Button
    Friend WithEvents CategoriaComboBox As ComboBox
    Friend WithEvents Recontraseñatxt As TextBox
    Friend WithEvents Contraseñatxt As TextBox
    Friend WithEvents Correotxt As TextBox
    Friend WithEvents Usuariotxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
