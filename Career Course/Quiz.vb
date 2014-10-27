Public Class Quiz

    Private score As Integer

    Private Function CheckScore()
        score = 0
        If RadioButton3.Checked = True Then
            score += 1
        End If
        If RadioButton7.Checked = True Then
            score += 1
        End If
        If RadioButton12.Checked = True Then
            score += 1
        End If
        If RadioButton13.Checked = True Then
            score += 1
        End If
        If RadioButton20.Checked = True Then
            score += 1
        End If
        If RadioButton21.Checked = True Then
            score += 1
        End If
        If RadioButton27.Checked = True Then
            score += 1
        End If
        If RadioButton32.Checked = True Then
            score += 1
        End If
        If RadioButton33.Checked = True Then
            score += 1
        End If
        If RadioButton38.Checked = True Then
            score += 1
        End If
        Return score
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel4.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel4.Visible = False
        Panel5.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel5.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel5.Visible = False
        Panel6.Visible = True
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel6.Visible = False
        Panel5.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel6.Visible = False
        Panel7.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel7.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel7.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Panel8.Visible = False
        Panel7.Visible = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Panel8.Visible = False
        Panel9.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Panel9.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Panel9.Visible = False
        Panel10.Visible = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Panel10.Visible = False
        Panel9.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        If MsgBox("Are you sure you want to submit your answers?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If CheckScore() >= 9 Then
                Panel10.Visible = False
                Panel11.Visible = True
            Else
                Panel10.Visible = False
                Panel11.Visible = False
                Panel12.Visible = True
            End If
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Finalize()
        End
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim NewQuiz As New Quiz
        NewQuiz.Show()
        Me.Finalize()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim NewSlides As New Login
        NewSlides.Show()
        NewSlides.Panel1.Visible = False
        NewSlides.Panel2.Visible = True
        Me.Finalize()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Me.Finalize()
        End
    End Sub
End Class