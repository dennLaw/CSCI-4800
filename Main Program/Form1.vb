Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = ("Clicked")
    End Sub

    Private Sub ShowCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCompletedToolStripMenuItem.Click

    End Sub

    Private Sub ShowIncompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowIncompletedToolStripMenuItem.Click

    End Sub

    Private Sub ShowFlaggedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFlaggedToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim form2 = New Form2()
        form2.Show()

        ' Dim student = New Student(Form2.LastBx.Text, Form2.FirstBx.Text, CInt(Form2.IDBx.Text), CInt(Form2.HoursBx.Text), Form2.EmailBx.Text, False) 'implement tryToFlag Later
    End Sub




End Class
