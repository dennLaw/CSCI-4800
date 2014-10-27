Public Class Login

    Private ID As String
    Private password As String

    Public Function isValidID()
        If ID.Equals("brian") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function isValidPassword()
        If password.Equals("password") Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PassField.TextChanged
        password = PassField.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isValidID() And isValidPassword() Then
            Panel1.Visible = False
            Panel2.Visible = True
        Else
            MessageBox.Show("Invalid User ID or Password")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles idName.TextChanged
        ID = idName.Text
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel4.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel4.Visible = False
        Panel5.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel5.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel5.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel6.Visible = False
        Panel5.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel6.Visible = False
        Panel7.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel7.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel7.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel8.Visible = False
        Panel7.Visible = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Panel8.Visible = False
        Panel9.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Panel9.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Panel9.Visible = False
        Panel10.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Panel10.Visible = False
        Panel9.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Panel10.Visible = False
        Panel11.Visible = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Panel11.Visible = False
        Panel10.Visible = True
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Panel11.Visible = False
        Panel12.Visible = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Panel12.Visible = False
        Panel11.Visible = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Panel12.Visible = False
        Panel13.Visible = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Panel13.Visible = False
        Panel12.Visible = True
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Panel13.Visible = False
        Panel14.Visible = True
    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Panel14.Visible = False
        Panel13.Visible = True
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Panel14.Visible = False
        Panel15.Visible = True
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Panel15.Visible = False
        Panel14.Visible = True
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Panel15.Visible = False
        Panel16.Visible = True
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Panel16.Visible = False
        Panel15.Visible = True
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Panel16.Visible = False
        Panel17.Visible = True
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Panel17.Visible = False
        Panel16.Visible = True
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Panel17.Visible = False
        Panel18.Visible = True
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Panel18.Visible = False
        Panel17.Visible = True
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Panel18.Visible = False
        Panel19.Visible = True
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim QuizForm As New Quiz
        QuizForm.Show()
        Me.Finalize()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Panel19.Visible = False
        Panel18.Visible = True
    End Sub
End Class