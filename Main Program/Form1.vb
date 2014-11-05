Public Class Form1


    ' Show only Students who have been checked as "Completed"
    Private Sub ShowCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCompletedToolStripMenuItem.Click
        Dim completedList = New StudentList()
        completedList = list.getComplete()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To completedList.getCount()
            If (completedList.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not completedList.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Cleared"
            End If
            If (completedList.getIndex(i).getLast() = "") Then

            ElseIf completedList.getIndex(i).getComplete() = True Then
                DG.Rows.Add(completedList.getIndex(i).getLast(), completedList.getIndex(i).getFirst(), completedList.getIndex(i).getID(), completedList.getIndex(i).getHours(), completedList.getIndex(i).getEmail(), completed, flagged)

                If completedList.getIndex(i).getFlagged() Then
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                End If

            End If

            flagged = "Flagged"
            completed = "Incomplete"
        Next

        Label33.Text = "Showing Completed"

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
                flagged = "Cleared"
            End If
            If (incompletedList.getIndex(i).getLast() = "") Then 'do nothing

            Else
                DG.Rows.Add(incompletedList.getIndex(i).getLast(), incompletedList.getIndex(i).getFirst(), incompletedList.getIndex(i).getID(), incompletedList.getIndex(i).getHours(), incompletedList.getIndex(i).getEmail(), completed, flagged)

                If incompletedList.getIndex(i).getFlagged() Then
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                End If
            End If

            flagged = "Flagged"
            completed = "Incomplete"
        Next

        Label33.Text = "Showing Incomplete"

    End Sub


    'Show only students that have been flagged
    Private Sub ShowFlaggedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFlaggedToolStripMenuItem.Click
        Dim flaggedList = New StudentList()
        flaggedList = list.getFlagged()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To flaggedList.getCount()
            If (flaggedList.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not flaggedList.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Cleared"
            End If
            If (flaggedList.getIndex(i).getLast() = "") Then


            ElseIf flaggedList.getIndex(i).getFlagged = True Then
                DG.Rows.Add(flaggedList.getIndex(i).getLast(), flaggedList.getIndex(i).getFirst(), flaggedList.getIndex(i).getID(), flaggedList.getIndex(i).getHours(), flaggedList.getIndex(i).getEmail(), completed, flagged)

                If flaggedList.getIndex(i).getFlagged() Then
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                End If
            End If
            flagged = "Flagged"
            completed = "Incomplete"
        Next

        Label33.Text = "Showing Flagged"

    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim form2 = New Form2()
        form2.ShowDialog()

        Dim student = New Student(form2.LastBx.Text, form2.FirstBx.Text, CInt(form2.IDBx.Text), CInt(form2.HoursBx.Text), form2.EmailBx.Text, True) 'implement tryToFlag Later
        student.forceFlag()
        student.setIncomplete()
        DG.Rows(DG.Rows.Count - 2).DefaultCellStyle.BackColor = Color.LightSalmon
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
                flagged = "Cleared"
            End If

            DG.Rows.Add(list.getIndex(i).getLast(), list.getIndex(i).getFirst(), list.getIndex(i).getID(), list.getIndex(i).getHours(), list.getIndex(i).getEmail(), completed, flagged)

            If list.getIndex(i).getFlagged() Then
                DG.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
            Else
                DG.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
            End If

            flagged = "Flagged"
            completed = "Incomplete"
        Next

    End Sub


    Dim list = New StudentList()


    'Need to implement
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim IDList = New List(Of Integer)
        If DG.SelectedRows.Count() > 0 Then
            For i As Integer = 0 To DG.SelectedRows.Count() - 1

                IDList.Add(DG.SelectedRows(i).Cells(2).Value())

            Next
        End If
        If IDList.Count > 0 Then
            Dim msg = "Are you sure you want to remove the selected students?"
            'MsgBox(msg)
            Dim title = "Remove Student"
            ' MsgBox(msg, , title)
            Dim style = MsgBoxStyle.OkCancel
            Dim response = MsgBox(msg, style, title)

            If response = MsgBoxResult.Ok Then

                For i As Integer = 0 To IDList.Count() - 1
                    list.removeStudentByID(IDList(i))

                Next
            End If
        End If
        DG.Rows.Clear()
        ImportStudents()

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

            If (lThirtyList.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not lThirtyList.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Cleared"
            End If

            If student.getHours < 30 And Not (student.getLast() = "") Then
                DG.Rows.Add(student.getLast(), student.getFirst(), student.getID(), student.getHours(), student.getEmail(), completed, flagged)

                If lThirtyList.getIndex(i).getFlagged() Then
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                End If
            End If
            flagged = "Flagged"
            completed = "Incomplete"
        Next
        Label33.Text = "Showing Under 30 Hours"
    End Sub

    Private Sub ShowUnflaggedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowUnflaggedToolStripMenuItem.Click
        Dim unFlaggedList = New StudentList()
        unFlaggedList = list.getNonFlagged()

        DG.Rows.Clear()

        Dim completed As String = "Incomplete"
        Dim flagged As String = "Flagged"

        For i As Integer = 0 To unFlaggedList.getCount()
            If (unFlaggedList.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            End If
            If (Not unFlaggedList.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "Cleared"
            End If
            If (unFlaggedList.getIndex(i).getLast() = "") Then

            ElseIf unFlaggedList.getIndex(i).getFlagged = False Then
                DG.Rows.Add(unFlaggedList.getIndex(i).getLast(), unFlaggedList.getIndex(i).getFirst(), unFlaggedList.getIndex(i).getID(), unFlaggedList.getIndex(i).getHours(), unFlaggedList.getIndex(i).getEmail(), completed, flagged)

                If unFlaggedList.getIndex(i).getFlagged() Then
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                End If
            End If
            flagged = "Flagged"
            completed = "Incomplete"
        Next
        Label33.Text = "Showing Unflagged"
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
                flagged = "Cleared"
            End If
            If (gThirtyList.getIndex(i).getLast() = "") Then

            Else
                DG.Rows.Add(gThirtyList.getIndex(i).getLast(), gThirtyList.getIndex(i).getFirst(), gThirtyList.getIndex(i).getID(), gThirtyList.getIndex(i).getHours(), gThirtyList.getIndex(i).getEmail(), completed, flagged)

                If gThirtyList.getIndex(i).getFlagged() Then
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    DG.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                End If
            End If
            flagged = "Flagged"
            completed = "Incomplete"
        Next
        Label33.Text = "Showing Over 30 Hours"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowAllBtn.Click
        DG.Rows.Clear()
        ImportStudents()
    End Sub

    Private Sub ClrCmpBtn_Click(sender As Object, e As EventArgs) Handles ClrCmpBtn.Click



        Dim msg = "Are you sure you want to remove the flags of all completed students?"
        Dim title = "Clear All Completed"
        ' MsgBox(msg, , title)
        Dim style = MsgBoxStyle.OkCancel
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Ok Then

            For i As Integer = 0 To list.getCount() - 1
                If list.getIndex(i).getComplete() And list.getIndex(i).getFlagged() Then
                    list.getIndex(i).forceUnflag()

                End If


            Next
        End If

        DG.Rows.Clear()
        ImportStudents()

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
    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Complete.Visible = False

        Flagged.Visible = False
    End Sub
    'Leaves Time panel to complete
    Private Sub Button10_Click(sender As Object, e As EventArgs)

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
                     , New Point(550, 175) _
                     , New Size(125, 125))
    End Sub
    'Leaves time panel to flagged
    Private Sub Button9_Click(sender As Object, e As EventArgs)

        Flagged.Visible = True
        Complete.Visible = False

        DrawPieChart({list.getMoreThanThirtyHours().getFlagged().getCount(), list.getMoreThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Flagged.CreateGraphics _
                     , New Point(130, 175) _
                     , New Size(125, 125))

        DrawPieChart({list.getLessThanThirtyHours().getFlagged().getCount(), list.getLessThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Flagged.CreateGraphics _
                     , New Point(550, 175) _
                     , New Size(125, 125))
    End Sub
    'Leaves complete panel to flag
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Complete.Visible = False
        Flagged.Visible = True


        DrawPieChart({list.getMoreThanThirtyHours().getFlagged().getCount(), list.getMoreThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Flagged.CreateGraphics _
                     , New Point(130, 175) _
                     , New Size(125, 125))

        DrawPieChart({list.getLessThanThirtyHours().getFlagged().getCount(), list.getLessThanThirtyHours().getNonFlagged().getCount()} _
                     , {Color.Blue, Color.Red} _
                     , Flagged.CreateGraphics _
                     , New Point(550, 175) _
                     , New Size(125, 125))
    End Sub
    'Leaves Flagged to Complete
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Flagged.Visible = False
        Complete.Visible = True


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
    'Leaves Flaged to time
    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Flagged.Visible = False

        Complete.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Flagged.Visible = False
        Complete.Visible = False

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

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Dim IDList = New List(Of Integer)
        If DG.SelectedRows.Count > 0 Then
            For i As Integer = 0 To DG.SelectedRows.Count() - 1

                IDList.Add(DG.SelectedRows(i).Cells(2).Value())

            Next
        End If
        If IDList.Count > 0 Then
            Dim msg = "Are you sure you want to clear the selected students?"
            Dim title = "Clear Selected Students"
            ' MsgBox(msg, , title)
            Dim style = MsgBoxStyle.OkCancel
            Dim response = MsgBox(msg, style, title)

            If response = MsgBoxResult.Ok Then

                For i As Integer = 0 To IDList.Count() - 1

                    list.completeStudent(IDList(i))

                Next
            End If

        End If

        DG.Rows.Clear()
        ImportStudents()
    End Sub

    Private Sub EmailBtn_Click(sender As Object, e As EventArgs) Handles EmailBtn.Click 'only to flagged
        Dim msg As String = "Do you want to send an email to the selected students?"
        Dim title As String = "Send Email Notification"
        Dim style = MsgBoxStyle.OkCancel
        Dim response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Ok Then
            Dim msg2 As String = "Emails have been sent"
            Dim title2 As String = "Emails Sent"
            Dim style2 = MsgBoxStyle.OkOnly
            MsgBox(msg2, style2, title2)
        End If
    End Sub


    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Search" Then
            TextBox1.Clear()
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not TextBox1.Text = "" Then

            Dim sl = New StudentList
            sl = list.searchBy(TextBox1.Text)

            Dim completed As String = "Incomplete"
            Dim flagged As String = "Flagged"

            DG.Rows.Clear()

            For i As Integer = 0 To sl.getCount()

                If (sl.getIndex(i).getComplete()) Then
                    completed = "Complete"                  'Conditional to output if student is complete
                End If
                If (Not sl.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                    flagged = "Cleared"
                End If

                If Not (sl.getIndex(i).getLast() = "") Then



                    DG.Rows.Add(sl.getIndex(i).getLast(), sl.getIndex(i).getFirst(), sl.getIndex(i).getID(), sl.getIndex(i).getHours(), sl.getIndex(i).getEmail(), completed, flagged)
                End If
                flagged = "Flagged"
                completed = "Incomplete"

            Next
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        SaveFileDialog1.Title = "Please Select a File"


        SaveFileDialog1.InitialDirectory = "C:temp"


        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        list.writeCSV(SaveFileDialog1.FileName.ToString())
        ' ImportStudents()
    End Sub
End Class

