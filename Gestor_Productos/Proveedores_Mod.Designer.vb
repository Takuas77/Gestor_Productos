<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores_Mod
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
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.Direcciontxt = New System.Windows.Forms.TextBox()
        Me.Telefonotxt = New System.Windows.Forms.TextBox()
        Me.Nombretxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancelarbtn = New System.Windows.Forms.Button()
        Me.Modificarbtn = New System.Windows.Forms.Button()
        Me.IDtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Correotxt
        '
        Me.Correotxt.Enabled = False
        Me.Correotxt.Location = New System.Drawing.Point(130, 143)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(248, 20)
        Me.Correotxt.TabIndex = 67
        '
        'Direcciontxt
        '
        Me.Direcciontxt.Enabled = False
        Me.Direcciontxt.Location = New System.Drawing.Point(130, 71)
        Me.Direcciontxt.Name = "Direcciontxt"
        Me.Direcciontxt.Size = New System.Drawing.Size(248, 20)
        Me.Direcciontxt.TabIndex = 65
        '
        'Telefonotxt
        '
        Me.Telefonotxt.Enabled = False
        Me.Telefonotxt.Location = New System.Drawing.Point(130, 108)
        Me.Telefonotxt.Name = "Telefonotxt"
        Me.Telefonotxt.Size = New System.Drawing.Size(248, 20)
        Me.Telefonotxt.TabIndex = 66
        '
        'Nombretxt
        '
        Me.Nombretxt.Enabled = False
        Me.Nombretxt.Location = New System.Drawing.Point(130, 38)
        Me.Nombretxt.Name = "Nombretxt"
        Me.Nombretxt.Size = New System.Drawing.Size(248, 20)
        Me.Nombretxt.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Nombre del Proveedor:"
        '
        'Cancelarbtn
        '
        Me.Cancelarbtn.Location = New System.Drawing.Point(394, 136)
        Me.Cancelarbtn.Name = "Cancelarbtn"
        Me.Cancelarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelarbtn.TabIndex = 69
        Me.Cancelarbtn.Text = "Volver"
        Me.Cancelarbtn.UseVisualStyleBackColor = True
        '
        'Modificarbtn
        '
        Me.Modificarbtn.Enabled = False
        Me.Modificarbtn.Location = New System.Drawing.Point(394, 36)
        Me.Modificarbtn.Name = "Modificarbtn"
        Me.Modificarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Modificarbtn.TabIndex = 68
        Me.Modificarbtn.Text = "Modificar"
        Me.Modificarbtn.UseVisualStyleBackColor = True
        '
        'IDtxt
        '
        Me.IDtxt.Location = New System.Drawing.Point(130, 6)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.Size = New System.Drawing.Size(248, 20)
        Me.IDtxt.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "ID del Proveedor:"
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(394, 7)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 76
        Me.Buscarbtn.Text = "Buscar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'Proveedores_Mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 174)
        Me.Controls.Add(Me.Buscarbtn)
        Me.Controls.Add(Me.IDtxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Correotxt)
        Me.Controls.Add(Me.Direcciontxt)
        Me.Controls.Add(Me.Telefonotxt)
        Me.Controls.Add(Me.Nombretxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancelarbtn)
        Me.Controls.Add(Me.Modificarbtn)
        Me.Name = "Proveedores_Mod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Correotxt As TextBox
    Friend WithEvents Direcciontxt As TextBox
    Friend WithEvents Telefonotxt As TextBox
    Friend WithEvents Nombretxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancelarbtn As Button
    Friend WithEvents Modificarbtn As Button
    Friend WithEvents IDtxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Buscarbtn As Button
End Class
