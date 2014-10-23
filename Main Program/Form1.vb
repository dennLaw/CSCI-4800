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
        form2.ShowDialog()



        'DG.Rows.Add(True, (form2.LastBx.Text), (form2.FirstBx.Text), CInt(form2.IDBx.Text), CInt(form2.HoursBx.Text), (form2.EmailBx.Text), "Incomplete", "Yes")


        'Dim student = New Student(form2.LastBx.Text, form2.FirstBx.Text, CInt(form2.IDBx.Text), CInt(form2.HoursBx.Text), form2.EmailBx.Text, False) 'implement tryToFlag Later
    End Sub

    'Dim student = New Student(Form2.LastBx.Text, Form2.FirstBx.Text, CInt(Form2.IDBx.Text), CInt(Form2.HoursBx.Text), Form2.EmailBx.Text, False) 'implement tryToFlag Later



    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        OpenFileDialog1.Title = "Please Select a File"


        OpenFileDialog1.InitialDirectory = "C:temp"


        OpenFileDialog1.ShowDialog()


    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk


        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()

        list.readCSV(OpenFileDialog1.FileName.ToString(), True)
        ImportStudents()

        If Not (strm Is Nothing) Then
            'insert code to read the file data

            strm.Close()

        End If

    End Sub

    Public Sub ImportStudents()
        For i As Integer = 0 To list.getCount() - 1
            DG.Rows.Add(True, list.getIndex(i).getLast(), list.getIndex(i).getFirst(), list.getIndex(i).getID(), list.getIndex(i).getHours(), list.getIndex(i).getEmail(), "Incomplete", "Yes")

        Next
    End Sub
    Dim list = New StudentList()

End Class
