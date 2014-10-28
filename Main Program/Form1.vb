Public Class Form1


    ' Show only Students who have been checked as "Completed"
    Private Sub ShowCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCompletedToolStripMenuItem.Click
        Dim completedList = New StudentList()
        completedList = list.getComplete()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To completedList.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Not Flagged"
            End If
            If (completedList.getIndex(i).getLast() = "") Then

            ElseIf completedList.getIndex(i).getComplete() = True Then
                DG.Rows.Add(False, completedList.getIndex(i).getLast(), completedList.getIndex(i).getFirst(), completedList.getIndex(i).getID(), completedList.getIndex(i).getHours(), completedList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next


    End Sub

    'Show only students who are "incomplete"
    Private Sub ShowIncompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowIncompletedToolStripMenuItem.Click
        Dim incompletedList = New StudentList()
        incompletedList = list.getIncomplete()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To incompletedList.getCount()
            If (incompletedList.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not incompletedList.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Not Flagged"
            End If
            If (incompletedList.getIndex(i).getLast() = "") Then 'do nothing

            Else
                DG.Rows.Add(False, incompletedList.getIndex(i).getLast(), incompletedList.getIndex(i).getFirst(), incompletedList.getIndex(i).getID(), incompletedList.getIndex(i).getHours(), incompletedList.getIndex(i).getEmail(), completed, flagged)
                Console.WriteLine(incompletedList.getIndex(i).getLast())
            End If

        Next

    End Sub


    'Show only students that have been flagged
    Private Sub ShowFlaggedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFlaggedToolStripMenuItem.Click
        Dim flaggedList = New StudentList()
        flaggedList = list.getFlagged()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To flaggedList.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Not Flagged"
            End If
            If (flaggedList.getIndex(i).getLast() = "") Then


            ElseIf flaggedList.getIndex(i).getFlagged = True Then
                DG.Rows.Add(False, flaggedList.getIndex(i).getLast(), flaggedList.getIndex(i).getFirst(), flaggedList.getIndex(i).getID(), flaggedList.getIndex(i).getHours(), flaggedList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next

    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim form2 = New Form2()
        form2.ShowDialog()

        Dim student = New Student(form2.LastBx.Text, form2.FirstBx.Text, CInt(form2.IDBx.Text), CInt(form2.HoursBx.Text), form2.EmailBx.Text, False) 'implement tryToFlag Later
        student.forceFlag()
        student.setIncomplete()
        list.addStudent(student)

    End Sub




    'handles import features
    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        OpenFileDialog1.Title = "Please Select a File"


        OpenFileDialog1.InitialDirectory = "C:temp"


        OpenFileDialog1.ShowDialog()


    End Sub
    'Reads import file
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
        Dim flagged As String = "Flagged"

        DG.Rows.Clear()

        For i As Integer = 0 To list.getCount() - 1

            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Not Flagged"
            End If

            DG.Rows.Add(list.getIndex(i).getLast(), list.getIndex(i).getFirst(), list.getIndex(i).getID(), list.getIndex(i).getHours(), list.getIndex(i).getEmail(), completed, flagged)
            'DG.Rows.Add()
            'DG.Rows(i).Cells(1).Value = list.getIndex(i).getLast()
            'DG.Rows(i).Cells(2).Value = list.getIndex(i).getFirst()
            'DG.Rows(i).Cells(3).Value = list.getIndex(i).getID()
            'DG.Rows(i).Cells(4).Value = list.getIndex(i).getHours()
            'DG.Rows(i).Cells(5).Value = list.getIndex(i).getEmail()
            'DG.Rows(i).Cells(6).Value = completed
            'DG.Rows(i).Cells(1).Value = flagged
        Next
    End Sub


    Dim list = New StudentList()


    'Need to implement
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim IDList = New List(Of Integer)
        For i As Integer = 0 To DG.Rows.Count() - 1
            If DG.Rows(i).Cells(0).Value = True Then
                IDList.Add(DG.Rows(i).Cells(3).Value())
            End If
        Next
        If IDList.Count > 0 Then
            Dim msg = "Are you sure you want to remove the selected students?"
            'MsgBox(msg)
            Dim title = "Remove Student"
            ' MsgBox(msg, , title)
            Dim style = MsgBoxStyle.OkCancel
            Dim response = MsgBox(msg, style, title)

            If response = MsgBoxResult.Ok Then

                For i As Integer = 0 To DG.Rows.Count() - 1
                    list.removeStudentByID(DG.Rows(i).Cells(3).Value)
                    DG.Rows.Remove(DG.Rows(i))
                Next
            End If
        End If

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
        Dim flagged As String = "Flagged"


        For i As Integer = 0 To list.getCount()
            Dim student As Student = lThirtyList.getIndex(i)

            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Not Flagged"
            End If

            If student.getHours < 30 And Not (student.getLast() = "") Then
                DG.Rows.Add(False, student.getLast(), student.getFirst(), student.getID(), student.getHours(), student.getEmail(), completed, flagged)

            End If

        Next
    End Sub

    Private Sub ShowUnflaggedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowUnflaggedToolStripMenuItem.Click
        Dim unFlaggedList = New StudentList()
        unFlaggedList = list.getFlagged()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To unFlaggedList.getCount()
            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Not Flagged"
            End If
            If (unFlaggedList.getIndex(i).getLast() = "") Then

            ElseIf unFlaggedList.getIndex(i).getFlagged = False Then
                DG.Rows.Add(False, unFlaggedList.getIndex(i).getLast(), unFlaggedList.getIndex(i).getFirst(), unFlaggedList.getIndex(i).getID(), unFlaggedList.getIndex(i).getHours(), unFlaggedList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next
    End Sub

    Private Sub ShowMoreThan30HrsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMoreThan30HrsToolStripMenuItem.Click
        Dim gThirtyList = New StudentList()
        gThirtyList = list.getMoreThanThirtyHours()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To list.getCount()
            If (gThirtyList.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not gThirtyList.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Not Flagged"
            End If
            If (gThirtyList.getIndex(i).getLast() = "") Then

            Else
                DG.Rows.Add(False, gThirtyList.getIndex(i).getLast(), gThirtyList.getIndex(i).getFirst(), gThirtyList.getIndex(i).getID(), gThirtyList.getIndex(i).getHours(), gThirtyList.getIndex(i).getEmail(), completed, flagged)

            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowAllBtn.Click
        DG.Rows.Clear()
        ImportStudents()
    End Sub

    Private Sub ClrCmpBtn_Click(sender As Object, e As EventArgs) Handles ClrCmpBtn.Click
        Dim msg = "Are you sure you want to remove the flags for all completed?"
        'MsgBox(msg)
        Dim title = "Clear All Completed"
        'MsgBox(msg, , title)
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            For i As Integer = 0 To list.getCount()
                If list.getIndex(i).getComplete() Then
                    list.getIndex(i).forceUnflag()

                End If
            Next
            DG.Rows.Clear()
            ImportStudents()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Complete.Visible = True
        Panel4.Visible = True

        DrawPieChart({list.getMoreThanThirtyHours().getComplete().getCount(), list.getMoreThanThirtyHours().getIncomplete().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(130, 175) _
                     , New Size(125, 125))

        DrawPieChart({list.getLessThanThirtyHours().getComplete().getCount(), list.getLessThanThirtyHours().getIncomplete().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(550, 175) _
                     , New Size(125, 125))
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    'Leaves Complete panel to Time
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Complete.Visible = False
        Time.Visible = True
        Flagged.Visible = False
    End Sub
    'Leaves Time panel to complete
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Time.Visible = False
        Complete.Visible = True
        Flagged.Visible = False

        ' Graphics g = Complete.CreateGraphics

        DrawPieChart({list.getMoreThanThirtyHours().getComplete().getCount(), list.getMoreThanThirtyHours().getIncomplete().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(130, 175) _
                     , New Size(125, 125))

        DrawPieChart({list.getLessThanThirtyHours().getComplete().getCount(), list.getLessThanThirtyHours().getIncomplete().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(160, 200) _
                     , New Size(125, 125))
    End Sub
    'Leaves time panel to flagged
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Time.Visible = False
        Flagged.Visible = True
        Complete.Visible = False

        DrawPieChart({list.getMoreThanThirtyHours().getFlagged().getCount(), list.getMoreThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(130, 175) _
                     , New Size(125, 125))

        DrawPieChart({list.getLessThanThirtyHours().getFlagged().getCount(), list.getLessThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(550, 175) _
                     , New Size(125, 125))
    End Sub
    'Leaves complete panel to flag
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Complete.Visible = False
        Flagged.Visible = True
        Time.Visible = False

        DrawPieChart({list.getMoreThanThirtyHours().getFlagged().getCount(), list.getMoreThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(130, 175) _
                     , New Size(125, 125))

        DrawPieChart({list.getLessThanThirtyHours().getFlagged().getCount(), list.getLessThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(550, 175) _
                     , New Size(125, 125))
    End Sub
    'Leaves Flagged to Complete
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Flagged.Visible = False
        Complete.Visible = True
        Time.Visible = False

        DrawPieChart({list.getMoreThanThirtyHours().getComplete().getCount(), list.getMoreThanThirtyHours().getIncomplete().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(130, 175) _
                     , New Size(125, 125))

        DrawPieChart({list.getLessThanThirtyHours().getComplete().getCount(), list.getLessThanThirtyHours().getIncomplete().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Complete.CreateGraphics _
                     , New Point(160, 200) _
                     , New Size(125, 125))
    End Sub
    'Leaves Flaged to time
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Flagged.Visible = False
        Time.Visible = True
        Complete.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Flagged.Visible = False
        Complete.Visible = False
        Time.Visible = False
        Panel1.Visible = True
        Panel4.Visible = False
        Panel2.Visible = True
    End Sub

    Public Sub DrawPieChart(ByVal percents() As Integer, ByVal colors() As Color, ByVal surface As Graphics, ByVal location As Point, ByVal pieSize As Size)

        Dim temp As Integer = percents(0) + percents(1)

        percents(0) = percents(0) * 100 / temp
        percents(1) = percents(1) * 100 / temp

        Dim sum As Integer = 0
        For Each percent As Integer In percents
            sum += percent

        Next

        Dim percentTotal As Integer = 0
        For percent As Integer = 0 To percents.Length() - 1

            surface.FillPie(New SolidBrush(colors(percent)), New Rectangle(location, pieSize), CType(percentTotal * 360 / 100, Single),
                            CType(percents(percent) * 360 / 100, Single))
            percentTotal += percents(percent)

        Next
        Return
    End Sub

    Private Sub Complete_Paint(sender As Object, e As PaintEventArgs) Handles Complete.Paint

    End Sub
End Class

