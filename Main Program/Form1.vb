Public Class Form1


    ' Show only Students who have been checked as "Completed"
    Private Sub ShowCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCompletedToolStripMenuItem.Click
        Dim completedList = New StudentList()
        completedList = list.getComplete()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Yes"

        For i As Integer = 0 To completedList.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            End If
            If (completedList.getIndex(i).getLast() = "") Then

            ElseIf completedList.getIndex(i).getComplete = True Then
                DG.Rows.Add(False, completedList.getIndex(i).getLast(), completedList.getIndex(i).getFirst(), completedList.getIndex(i).getID(), completedList.getIndex(i).getHours(), completedList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next


    End Sub

    Private Sub ShowIncompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowIncompletedToolStripMenuItem.Click
        Dim incompletedList = New StudentList()
        incompletedList = list.getIncomplete()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Yes"

        For i As Integer = 0 To incompletedList.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            End If
            If (incompletedList.getIndex(i).getLast() = "") Then

            ElseIf incompletedList.getIndex(i).getComplete = False Then
                DG.Rows.Add(False, incompletedList.getIndex(i).getLast(), incompletedList.getIndex(i).getFirst(), incompletedList.getIndex(i).getID(), incompletedList.getIndex(i).getHours(), incompletedList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next

    End Sub

    Private Sub ShowFlaggedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFlaggedToolStripMenuItem.Click
        Dim flaggedList = New StudentList()
        flaggedList = list.getFlagged()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Yes"

        For i As Integer = 0 To flaggedList.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            End If
            If (flaggedList.getIndex(i).getLast() = "") Then


            ElseIf flaggedList.getIndex(i).getFlagged = True Then
                DG.Rows.Add(False, flaggedList.getIndex(i).getLast(), flaggedList.getIndex(i).getFirst(), flaggedList.getIndex(i).getID(), flaggedList.getIndex(i).getHours(), flaggedList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next

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

        Dim student = New Student(form2.LastBx.Text, form2.FirstBx.Text, CInt(form2.IDBx.Text), CInt(form2.HoursBx.Text), form2.EmailBx.Text, False) 'implement tryToFlag Later
        list.addStudent(student)

    End Sub





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
        Dim completed As String = "Incomplete"
        Dim flagged As String = "Yes"

        DG.Rows.Clear()

        For i As Integer = 0 To list.getCount() - 1

            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            End If

            DG.Rows.Add(False, list.getIndex(i).getLast(), list.getIndex(i).getFirst(), list.getIndex(i).getID(), list.getIndex(i).getHours(), list.getIndex(i).getEmail(), completed, flagged)

        Next
    End Sub


    Dim list = New StudentList()



    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        For i As Integer = 0 To DG.Rows.Count() - 1
            If DG.Rows(i).Cells(0).Value = True Then

            End If
        Next
    End Sub

    Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem.Click
        DG.Rows.Clear()
        ImportStudents()
    End Sub

    Private Sub ShowLessThan30HrsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowLessThan30HrsToolStripMenuItem.Click
        Dim lThirtyList = New StudentList()
        lThirtyList = list.getLessThanThirtyHours()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Yes"

        For i As Integer = 0 To list.getCount()
            Dim student As Student = lThirtyList.getIndex(i)

            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            End If

            If student.getHours < 30 And Not (student.getLast() = "") Then
                DG.Rows.Add(False, student.getLast(), student.getFirst(), student.getID(), student.getHours(), student.getEmail(), completed, flagged)

            End If

        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowUnflaggedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowUnflaggedToolStripMenuItem.Click
        Dim unFlaggedList = New StudentList()
        unFlaggedList = list.getFlagged()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Yes"

        For i As Integer = 0 To unFlaggedList.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            End If
            If (unFlaggedList.getIndex(i).getLast() = "") Then

            ElseIf unFlaggedList.getIndex(i).getFlagged = False Then
                DG.Rows.Add(False, unFlaggedList.getIndex(i).getLast(), unFlaggedList.getIndex(i).getFirst(), unFlaggedList.getIndex(i).getID(), unFlaggedList.getIndex(i).getHours(), unFlaggedList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next
    End Sub

    Private Sub ShowMoreThan30HrsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMoreThan30HrsToolStripMenuItem.Click
        Dim gThirtyList = New StudentList()
        gThirtyList = list.getLessThanThirtyHours()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Yes"

        For i As Integer = 0 To list.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            End If
            If (gThirtyList.getIndex(i).getLast() = "") Then

            ElseIf gThirtyList.getIndex(i).getHours > 29 Then
                DG.Rows.Add(False, gThirtyList.getIndex(i).getLast(), gThirtyList.getIndex(i).getFirst(), gThirtyList.getIndex(i).getID(), gThirtyList.getIndex(i).getHours(), gThirtyList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next
    End Sub
End Class
