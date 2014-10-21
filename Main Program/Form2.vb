Public Class Form2

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim last As String = LastBx.Text
        Dim first As String = FirstBx.Text
        Dim id As Integer
        Dim hours As Integer
        Dim email As String = EmailBx.Text
        Dim tryToFlag As Boolean


        id = CInt(IDBx.Text) ' Changes String to Int
        hours = CInt(HoursBx.Text)

        Dim student1 = New Student(last, first, id, hours, email, tryToFlag)

        Me.Close()


    End Sub


End Class