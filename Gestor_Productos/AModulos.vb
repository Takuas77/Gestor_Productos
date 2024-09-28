Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Module DatabaseConnection
    ' Abre la conexión
    Public Function OpenConnection() As MySqlConnection
        Dim connectionString As String = "Server=localhost;Database=inventariodb;Uid=root;Pwd=r3d153602;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open() ' Abrir la conexión
            Return connection
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Cierra la conexión a la base de datos
    Public Sub CloseConnection(connection As MySqlConnection)
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close() ' Cerrar la conexión si está abierta
        End If
    End Sub
End Module

' Módulo con utilidades generales
Module Utilidades
    ' Hashea una contraseña usando SHA-256, se podria mejorar usando otro modelo
    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
End Module

' Módulo global para el rol
Module GlobalVariables
    ' Almacena el rol del usuario actual
    Public CurrentUserRole As String = String.Empty
End Module
