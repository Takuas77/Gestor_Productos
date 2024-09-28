<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores_Alta
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
        Me.Telefonotxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cancelarbtn = New System.Windows.Forms.Button()
        Me.Nombretxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.Direcciontxt = New System.Windows.Forms.TextBox()
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Telefonotxt
        '
        Me.Telefonotxt.Location = New System.Drawing.Point(146, 76)
        Me.Telefonotxt.Name = "Telefonotxt"
        Me.Telefonotxt.Size = New System.Drawing.Size(248, 20)
        Me.Telefonotxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Direccion:"
        '
        'Cancelarbtn
        '
        Me.Cancelarbtn.Location = New System.Drawing.Point(410, 104)
        Me.Cancelarbtn.Name = "Cancelarbtn"
        Me.Cancelarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelarbtn.TabIndex = 6
        Me.Cancelarbtn.Text = "Volver"
        Me.Cancelarbtn.UseVisualStyleBackColor = True
        '
        'Nombretxt
        '
        Me.Nombretxt.Location = New System.Drawing.Point(146, 6)
        Me.Nombretxt.Name = "Nombretxt"
        Me.Nombretxt.Size = New System.Drawing.Size(248, 20)
        Me.Nombretxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Nombre del Proveedor:"
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(410, 4)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 5
        Me.Buscarbtn.Text = "Agregar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'Direcciontxt
        '
        Me.Direcciontxt.Location = New System.Drawing.Point(146, 39)
        Me.Direcciontxt.Name = "Direcciontxt"
        Me.Direcciontxt.Size = New System.Drawing.Size(248, 20)
        Me.Direcciontxt.TabIndex = 2
        '
        'Correotxt
        '
        Me.Correotxt.Location = New System.Drawing.Point(146, 111)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(248, 20)
        Me.Correotxt.TabIndex = 4
        '
        'Proveedores_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 136)
        Me.Controls.Add(Me.Correotxt)
        Me.Controls.Add(Me.Direcciontxt)
        Me.Controls.Add(Me.Telefonotxt)
        Me.Controls.Add(Me.Nombretxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancelarbtn)
        Me.Controls.Add(Me.Buscarbtn)
        Me.Name = "Proveedores_Alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Telefonotxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cancelarbtn As Button
    Friend WithEvents Nombretxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Buscarbtn As Button
    Friend WithEvents Direcciontxt As TextBox
    Friend WithEvents Correotxt As TextBox
End Class
