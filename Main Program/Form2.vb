Imports System.ComponentModel

Public Class Form2

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If CInt(HoursBx.Text) < 30 Then
            Form1.DG.Rows.Add((LastBx.Text), (FirstBx.Text), CInt(IDBx.Text), CInt(HoursBx.Text), (EmailBx.Text), "Incomplete", "Unflagged")
        Else
            Form1.DG.Rows.Add((LastBx.Text), (FirstBx.Text), CInt(IDBx.Text), CInt(HoursBx.Text), (EmailBx.Text), "Incomplete", "Flagged")
        End If



        Me.Close()


    End Sub

End Class