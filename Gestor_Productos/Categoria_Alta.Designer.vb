<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria_Alta
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
        Me.Cancelarbtn = New System.Windows.Forms.Button()
        Me.Agregarbtn = New System.Windows.Forms.Button()
        Me.Categoriatxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la Nueva Categoria:"
        '
        'Cancelarbtn
        '
        Me.Cancelarbtn.Location = New System.Drawing.Point(51, 73)
        Me.Cancelarbtn.Name = "Cancelarbtn"
        Me.Cancelarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelarbtn.TabIndex = 1
        Me.Cancelarbtn.Text = "Cancelar"
        Me.Cancelarbtn.UseVisualStyleBackColor = True
        '
        'Agregarbtn
        '
        Me.Agregarbtn.Location = New System.Drawing.Point(193, 73)
        Me.Agregarbtn.Name = "Agregarbtn"
        Me.Agregarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Agregarbtn.TabIndex = 2
        Me.Agregarbtn.Text = "Agregar"
        Me.Agregarbtn.UseVisualStyleBackColor = True
        '
        'Categoriatxt
        '
        Me.Categoriatxt.Location = New System.Drawing.Point(193, 27)
        Me.Categoriatxt.Name = "Categoriatxt"
        Me.Categoriatxt.Size = New System.Drawing.Size(100, 20)
        Me.Categoriatxt.TabIndex = 3
        '
        'Categoria_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 118)
        Me.Controls.Add(Me.Categoriatxt)
        Me.Controls.Add(Me.Agregarbtn)
        Me.Controls.Add(Me.Cancelarbtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Categoria_Alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Categoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cancelarbtn As Button
    Friend WithEvents Agregarbtn As Button
    Friend WithEvents Categoriatxt As TextBox
End Class
