Imports System.ComponentModel

Public Class Form2

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ' Dim last As String = LastBx.Text
        ' Dim first As String = FirstBx.Text
        'Dim id As Integer
        'Dim hours As Integer
        'Dim email As String = EmailBx.Text
        'Dim tryToFlag As Boolean = False

        '        id = CInt(IDBx.Text) ' Changes String to Int
        '       hours = CInt(HoursBx.Text)

        ' Dim student1 = New Student(last, first, id, hours, email, tryToFlag)
        'Dim student = CreateStudent(LastBx.Text, FirstBx.Text, CInt(IDBx.Text), CInt(HoursBx.Text), EmailBx.Text, False)
        Form1.DG.Rows.Add(False, (LastBx.Text), (FirstBx.Text), CInt(IDBx.Text), CInt(HoursBx.Text), (EmailBx.Text), "Incomplete", "Flagged")



        Me.Close()


    End Sub

    'Public Function CreateStudent(ByVal last As String, ByVal first As String, ByVal id As Integer, ByVal hours As Integer, ByVal email As String, ByVal trytoflag As Boolean) As Student

    'Dim student = New Student(last, first, id, hours, email, trytoflag)
    ' Return student
    ' End Function

    ' Public Function ImportList()
    '    Form1.OpenFileDialog1.Title = "Please Select a File"
    '   Form1.OpenFileDialog1.InitialDirectory = "C:temp"
    '  Form1.OpenFileDialog1.ShowDialog()

    'Dim sender As System.Object
    'Dim e As CancelEventArgs



    ' Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Form1.OpenFileDialog1.FileOk)
    ' Dim list = New StudentList
    ' Dim strm As System.IO.Stream
    'strm = Form1.OpenFileDialog1.OpenFile()
    'TextBox1.Text = OpenFileDialog1.FileName.ToString()
    'list.readCSV(Form1.OpenFileDialog1.FileName.ToString(), True)

    ' If Not (strm Is Nothing) Then
    'insert code to read the file data
    'strm.Close()
    ' MessageBox.Show("file closed")
    'End If




    '    End Function


    ' End Function


End Class