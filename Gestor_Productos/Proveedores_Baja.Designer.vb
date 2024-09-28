<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores_Baja
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
        Me.Direcciontxt = New System.Windows.Forms.TextBox()
        Me.Idtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancelarbtn = New System.Windows.Forms.Button()
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.Telefonotxt = New System.Windows.Forms.TextBox()
        Me.Nombretxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Direcciontxt
        '
        Me.Direcciontxt.Enabled = False
        Me.Direcciontxt.Location = New System.Drawing.Point(70, 76)
        Me.Direcciontxt.Name = "Direcciontxt"
        Me.Direcciontxt.Size = New System.Drawing.Size(248, 20)
        Me.Direcciontxt.TabIndex = 3
        '
        'Idtxt
        '
        Me.Idtxt.Location = New System.Drawing.Point(70, 6)
        Me.Idtxt.Name = "Idtxt"
        Me.Idtxt.Size = New System.Drawing.Size(248, 20)
        Me.Idtxt.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Id:"
        '
        'Cancelarbtn
        '
        Me.Cancelarbtn.Location = New System.Drawing.Point(334, 139)
        Me.Cancelarbtn.Name = "Cancelarbtn"
        Me.Cancelarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelarbtn.TabIndex = 8
        Me.Cancelarbtn.Text = "Volver"
        Me.Cancelarbtn.UseVisualStyleBackColor = True
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Enabled = False
        Me.Eliminarbtn.Location = New System.Drawing.Point(334, 39)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Eliminarbtn.TabIndex = 7
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = True
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(334, 4)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 6
        Me.Buscarbtn.Text = "Buscar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'Correotxt
        '
        Me.Correotxt.Enabled = False
        Me.Correotxt.Location = New System.Drawing.Point(70, 146)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(248, 20)
        Me.Correotxt.TabIndex = 5
        '
        'Telefonotxt
        '
        Me.Telefonotxt.Enabled = False
        Me.Telefonotxt.Location = New System.Drawing.Point(70, 111)
        Me.Telefonotxt.Name = "Telefonotxt"
        Me.Telefonotxt.Size = New System.Drawing.Size(248, 20)
        Me.Telefonotxt.TabIndex = 4
        '
        'Nombretxt
        '
        Me.Nombretxt.Enabled = False
        Me.Nombretxt.Location = New System.Drawing.Point(70, 39)
        Me.Nombretxt.Name = "Nombretxt"
        Me.Nombretxt.Size = New System.Drawing.Size(248, 20)
        Me.Nombretxt.TabIndex = 2
        '
        'Proveedores_Baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 178)
        Me.Controls.Add(Me.Nombretxt)
        Me.Controls.Add(Me.Telefonotxt)
        Me.Controls.Add(Me.Correotxt)
        Me.Controls.Add(Me.Direcciontxt)
        Me.Controls.Add(Me.Idtxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancelarbtn)
        Me.Controls.Add(Me.Eliminarbtn)
        Me.Controls.Add(Me.Buscarbtn)
        Me.Name = "Proveedores_Baja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Direcciontxt As TextBox
    Friend WithEvents Idtxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancelarbtn As Button
    Friend WithEvents Eliminarbtn As Button
    Friend WithEvents Buscarbtn As Button
    Friend WithEvents Correotxt As TextBox
    Friend WithEvents Telefonotxt As TextBox
    Friend WithEvents Nombretxt As TextBox
End Class
