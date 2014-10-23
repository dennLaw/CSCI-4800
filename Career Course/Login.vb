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
            Dim WelcomForm As New WelcomePage
            WelcomForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid User ID or Password")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles idName.TextChanged
        ID = idName.Text
    End Sub
End Class