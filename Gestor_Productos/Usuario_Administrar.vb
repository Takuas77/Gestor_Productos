Imports MySql.Data.MySqlClient
Public Class Usuario_Administrar

    ' Recarga despues de un cambio lo que permite tenes la ventana en showdialog
    Private Sub CargarUsuarios()
        Using conn As MySqlConnection = OpenConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT * FROM usuarios WHERE Estado = 1"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End If

        End Using
    End Sub

    ' Habilita la edicion o eliminar si hay algo seleccionado
    Private Sub DataGridView1_Seleccionado(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Verificar si hay una fila seleccionada
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Habilitar el botón Modificar si hay una fila seleccionada
            Modificarbtn.Enabled = True
            Eliminarbtn.Enabled = True
        Else
            ' Deshabilitar el botón Modificar si no hay fila seleccionada
            Modificarbtn.Enabled = False
            Modificarbtn.Enabled = False
        End If
    End Sub

    ' Precarga los datos en la tabla usuario
    Private Sub Usuario_Administrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsuariosTableAdapter.Fill(Me.Usuario.usuarios)
    End Sub

    ' Boton Volver
    Private Sub Volverbtn_Click(sender As Object, e As EventArgs) Handles Volverbtn.Click
        Dim inicio As New Inicio
        inicio.Show()
        Me.Close()
    End Sub

    ' Boton Agregar
    Private Sub Agregatbtn_Click(sender As Object, e As EventArgs) Handles Agregatbtn.Click
        Dim agregar As New Usuarios_Agregar
        agregar.Show()
        Me.Close()
    End Sub

    ' Boton modificar, segun el usuario selccionado permite modificarlo 
    Private Sub Modificarbtn_Click(sender As Object, e As EventArgs) Handles Modificarbtn.Click
        ' Verificar si hay una fila seleccionada
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtener el ID del usuario de la fila seleccionada
            Dim idusuario As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IdUsuarioDataGridViewTextBoxColumn").Value)

            ' Abrir el formulario de modificación y pasarle el ID del usuario
            Dim usuario_modificar As New Usuarios_Modificar(idusuario)
            usuario_modificar.Show()
            Me.Hide() ' Ocultar el formulario actual si es necesario
        End If
    End Sub


    ' Boton eliminar, segun usuario seleccionado permite eliminar
    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click
        ' Verificar si hay una fila seleccionada
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtener el ID del usuario seleccionado
            Dim idUsuario As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IdUsuarioDataGridViewTextBoxColumn").Value)

            ' Confirmar la eliminación lógica
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                ' Conectar a la base de datos y realizar la eliminación lógica
                Using conn As MySqlConnection = OpenConnection()
                    If conn IsNot Nothing Then
                        Dim query As String = "UPDATE usuarios SET Estado = 0 WHERE idUsuario = @id"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@id", idUsuario)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Usuario eliminado.")

                            ' Refrescar el DataGridView para no mostrar más al usuario eliminado
                            CargarUsuarios()
                        End Using
                    End If
                End Using
            End If
        Else
            MessageBox.Show("Por favor, seleccione un usuario para eliminar.")
        End If
    End Sub
End Class