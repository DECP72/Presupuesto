Imports MySql.Data.MySqlClient
Module Conecion
    Public Conexion As New MySqlConnection
    Public Comando As New MySqlCommand
    Public Clave As String

    Public Sub Conectar()
        If Conexion.State = ConnectionState.Open Then
        Else
            Try
                'Conexion.ConnectionString = "server=sql5.freesqldatabase.com;user id=sql5477151;password=2uKrnFQFLY;database=sql5477151;port=3306;"
                'Conexion.ConnectionString = "server=www.db4free.net;user id=decpworking;password=Midb2022;database=pruebaworking;port=3306;"
                'Conexion.ConnectionString = "server=localhost;user id=root;password=root;database=working"
                Conexion.ConnectionString = "server=localhost;user id=Presupuesto;password=ariel;database=presupuesto"
                Conexion.Open()
                'MsgBox("Conexion por modulo exitosa")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Comando.Connection = Conexion
        End If
    End Sub
End Module
