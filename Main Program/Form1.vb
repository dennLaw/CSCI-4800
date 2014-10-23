﻿Public Class Form1
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

    Public Sub createGraph()

        Dim studentList = New List(Of Student)

        Dim flaggedCount = studentList.getFlagged().getCount()
        Dim studentCount = studentList.getCount()
        Dim nonFlaggedCount = studentList.getNonFlagged().getCount()
        Dim completeCount = studentList.getComplete().getCount()
        Dim incompleteCount = studentList.getIncomplete().getCount()



        With Me.Chart1
            Me.ResetChart()

            'Create a new series
            With .Series.Add("Flagged vs Non-Flagged")
                'change the default type (column) to Pie
                .ChartType = DataVisualization.Charting.SeriesChartType.Pie

                Dim flagged As String
                Dim nonFlagged As String

                .Points.AddXY(flagged, flaggedCount)
                .Points.AddXY(nonFlagged, nonFlaggedCount)

                .IsVisibleInLegend = False
                .Label = "#VALX\n#PERCENT"
            End With

            'force labels to appear outside the pie
            .Series("Students")("PieLabelStyle") = "Outside"

            'set the pie to be in 3D
            .ChartAreas(0).Area3DStyle.Enable3D = True
        End With

        With Me.Chart2
            Me.ResetChart()

            'Create a new series
            With .Series.Add("Complete vs Incomplete")
                'change the default type (column) to Pie
                .ChartType = DataVisualization.Charting.SeriesChartType.Pie

                Dim complete As String
                Dim incomplete As String

                .Points.AddXY(complete, completeCount)
                .Points.AddXY(incomplete, incompleteCount)

                .IsVisibleInLegend = False
                .Label = "#VALX\n#PERCENT"
            End With

            'force labels to appear outside the pie
            .Series("Students")("PieLabelStyle") = "Outside"

            'set the pie to be in 3D
            .ChartAreas(0).Area3DStyle.Enable3D = True
        End With
    End Sub

    Public Sub ImportStudents()
        Dim completed As String
        Dim flagged As String

        For i As Integer = 0 To list.getCount() - 1

            If (list.getIndex(i).getComplete()) Then
                completed = "Complete"                  'Conditional to output if student is complete
            Else
                completed = "Incomplete"
            End If
            If (Not list.getIndex(i).getFlagged()) Then 'Conditional to output of student is flagged
                flagged = "No"
            Else
                flagged = "Yes"
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

    Private Sub DG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellContentClick
        For i As Integer = 0 To DG.Rows.Count() - 1
            If DG.Rows(i).Cells(0).Value = True Then
                'Selected = False
            Else
                'Selected = True
            End If
        Next
    End Sub
End Class
