<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria_Baja
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
        Me.IdCategoriatxt = New System.Windows.Forms.TextBox()
        Me.Categoriatxt = New System.Windows.Forms.TextBox()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        Me.Cancelarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID de la Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Categoria:"
        '
        'IdCategoriatxt
        '
        Me.IdCategoriatxt.Location = New System.Drawing.Point(125, 24)
        Me.IdCategoriatxt.Name = "IdCategoriatxt"
        Me.IdCategoriatxt.Size = New System.Drawing.Size(100, 20)
        Me.IdCategoriatxt.TabIndex = 2
        '
        'Categoriatxt
        '
        Me.Categoriatxt.Enabled = False
        Me.Categoriatxt.Location = New System.Drawing.Point(125, 55)
        Me.Categoriatxt.Name = "Categoriatxt"
        Me.Categoriatxt.Size = New System.Drawing.Size(100, 20)
        Me.Categoriatxt.TabIndex = 3
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(274, 22)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 4
        Me.Buscarbtn.Text = "Buscar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Enabled = False
        Me.Eliminarbtn.Location = New System.Drawing.Point(274, 53)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Eliminarbtn.TabIndex = 5
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = True
        '
        'Cancelarbtn
        '
        Me.Cancelarbtn.Location = New System.Drawing.Point(274, 82)
        Me.Cancelarbtn.Name = "Cancelarbtn"
        Me.Cancelarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelarbtn.TabIndex = 6
        Me.Cancelarbtn.Text = "Cancelar"
        Me.Cancelarbtn.UseVisualStyleBackColor = True
        '
        'Categoria_Baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 123)
        Me.Controls.Add(Me.Cancelarbtn)
        Me.Controls.Add(Me.Eliminarbtn)
        Me.Controls.Add(Me.Buscarbtn)
        Me.Controls.Add(Me.Categoriatxt)
        Me.Controls.Add(Me.IdCategoriatxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Categoria_Baja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Categoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IdCategoriatxt As TextBox
    Friend WithEvents Categoriatxt As TextBox
    Friend WithEvents Buscarbtn As Button
    Friend WithEvents Eliminarbtn As Button
    Friend WithEvents Cancelarbtn As Button
End Class
