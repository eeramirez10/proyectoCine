Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Password.PasswordChar = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If buscaUsuario(userName.Text, Password.Text) Then
            Form1.Show()
        End If

    End Sub

    Private Sub userName_TextChanged(sender As Object, e As EventArgs) Handles userName.TextChanged
        Button1.Enabled = HabilitarBoton()
    End Sub



    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        Button1.Enabled = HabilitarBoton()
    End Sub


    Public Function Conexion(Server As String, UserId As String, Password As String, Database As String)

        Try
            Dim con As New MySqlConnectionStringBuilder()
            con.Server = Server
            con.UserID = UserId
            con.Password = Password
            con.Database = Database
            Dim conn As New MySqlConnection(con.ToString())
            conn.Open()
            'MsgBox("Conectado a la BD")
            Return conn

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
            Return ex
        End Try

    End Function

    Public Function buscaUsuario(usuario As String, password As String)
        Dim con As MySqlConnection = Conexion("localhost", "root", "", "cine")
        Try
            Dim query As String = "
            Select nombre, apellido from usuarios 
            where username ='" & usuario & "' and password='" & password & "'"
            Dim comando As New MySqlCommand(query, con)
            Dim resultado As MySqlDataReader = comando.ExecuteReader()


            If resultado.Read() Then

                MsgBox("Bienvenido " & resultado.GetString(0) & " " & resultado.GetString(1))


                Return True
            Else
                MsgBox("Password o usuario incorrecto")
                Return False
            End If
        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
            Return False
        End Try

        'Dim objs(4) As Object
        'Dim quant As Integer = resultado.GetValues(objs)
        'Dim i As Integer

        'For i = 0 To quant - 1
        'Console.WriteLine(objs(i))
        'Next i
        'resultado.Close()


        con.Close()
    End Function
    Public Function HabilitarBoton()
        If userName.Text = "" And Password.Text = "" Then
            Return False
        ElseIf userName.Text = "" And Not Password.Text = "" Then
            Return False
        ElseIf Not userName.Text = "" And Password.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
End Class