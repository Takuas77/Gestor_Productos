﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_Baja
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
        Me.Volverbtn = New System.Windows.Forms.Button()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dnitxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Nombretxt = New System.Windows.Forms.TextBox()
        Me.Direcciontxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Telefonotxt = New System.Windows.Forms.TextBox()
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Volverbtn
        '
        Me.Volverbtn.Location = New System.Drawing.Point(263, 147)
        Me.Volverbtn.Name = "Volverbtn"
        Me.Volverbtn.Size = New System.Drawing.Size(75, 23)
        Me.Volverbtn.TabIndex = 16
        Me.Volverbtn.Text = "Volver"
        Me.Volverbtn.UseVisualStyleBackColor = True
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(263, 27)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 14
        Me.Buscarbtn.Text = "Buscar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Dnitxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Nombretxt)
        Me.GroupBox1.Controls.Add(Me.Direcciontxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Telefonotxt)
        Me.GroupBox1.Controls.Add(Me.Correotxt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 180)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese el DNI del Cliente a Eliminar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "E-mail:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre y Apellido:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dnitxt
        '
        Me.Dnitxt.Location = New System.Drawing.Point(108, 22)
        Me.Dnitxt.Name = "Dnitxt"
        Me.Dnitxt.Size = New System.Drawing.Size(100, 20)
        Me.Dnitxt.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Direccion:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Nombretxt
        '
        Me.Nombretxt.Enabled = False
        Me.Nombretxt.Location = New System.Drawing.Point(108, 51)
        Me.Nombretxt.Name = "Nombretxt"
        Me.Nombretxt.Size = New System.Drawing.Size(100, 20)
        Me.Nombretxt.TabIndex = 1
        '
        'Direcciontxt
        '
        Me.Direcciontxt.Enabled = False
        Me.Direcciontxt.Location = New System.Drawing.Point(108, 80)
        Me.Direcciontxt.Name = "Direcciontxt"
        Me.Direcciontxt.Size = New System.Drawing.Size(100, 20)
        Me.Direcciontxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DNI:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Telefonotxt
        '
        Me.Telefonotxt.Enabled = False
        Me.Telefonotxt.Location = New System.Drawing.Point(108, 109)
        Me.Telefonotxt.Name = "Telefonotxt"
        Me.Telefonotxt.Size = New System.Drawing.Size(100, 20)
        Me.Telefonotxt.TabIndex = 3
        '
        'Correotxt
        '
        Me.Correotxt.Enabled = False
        Me.Correotxt.Location = New System.Drawing.Point(108, 138)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(100, 20)
        Me.Correotxt.TabIndex = 4
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Enabled = False
        Me.Eliminarbtn.Location = New System.Drawing.Point(263, 56)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Eliminarbtn.TabIndex = 15
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = True
        '
        'Clientes_Baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 198)
        Me.Controls.Add(Me.Eliminarbtn)
        Me.Controls.Add(Me.Volverbtn)
        Me.Controls.Add(Me.Buscarbtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Clientes_Baja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Volverbtn As Button
    Friend WithEvents Buscarbtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dnitxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Nombretxt As TextBox
    Friend WithEvents Direcciontxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Telefonotxt As TextBox
    Friend WithEvents Correotxt As TextBox
    Friend WithEvents Eliminarbtn As Button
End Class
