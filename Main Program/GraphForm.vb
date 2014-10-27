Public Class Form1

    Public Sub DrawPieChart(ByVal percents() As Integer, ByVal colors() As Color, ByVal surface As Graphics, ByVal location As Point, ByVal pieSize As Size)

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim percents() As Integer = {TextBox1.Text, TextBox2.Text}

        Dim colors() As Color = {Color.Blue, Color.Red}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(50, 10)
        Dim size As Size = New Size(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)

    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim percents() As Integer = {TextBox3.Text, TextBox4.Text}

        Dim colors() As Color = {Color.DarkSlateGray, Color.Orange}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(325, 10)
        Dim size As Size = New Size(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)
       

    End Sub
End Class
