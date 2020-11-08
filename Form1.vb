Public Class Form1
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        List_Datos.Items.Add(TextBox1.Text)

        Select Case ComboBox1.SelectedIndex
            Case 0
                List_Datos.Items.Add("Femenino")
            Case 1
                List_Datos.Items.Add("Masculino")
        End Select

        If CheckBox1.Checked Then
            List_Datos.Items.Add("Grupo 1")
        End If

        If CheckBox2.Checked Then
            List_Datos.Items.Add("Grupo 2")
        End If

        If RadioButton1.Checked Then
            List_Datos.Items.Add("1ro")
        End If

        If RadioButton2.Checked Then
            List_Datos.Items.Add("2do")
        End If

        MsgBox("Datos Guardados Correctamente")

        Form2.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Hide()
        ComboBox1.Items.Add("Femenino")
        ComboBox1.Items.Add("Masculino")
    End Sub

    Private Sub List_Datos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_Datos.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
