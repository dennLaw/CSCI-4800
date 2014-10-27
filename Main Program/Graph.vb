Imports Microsoft.VisualBasic

Public Class Graph

    Dim studentList = New List(Of Student)

    Dim flaggedCount = studentList.getFlagged().getCount()
    Dim studentCount = studentList.getCount()

    Dim objRandom As New Random

    Public Function createChart()
        With Me.Chart1
            Me.ResetChart()

            'Create a new series
            With .Series.Add("Flagged vs Non-Flagged")
                'change the default type (column) to Pie
                .ChartType = DataVisualization.Charting.SeriesChartType.Pie


                For Each strX As String In New String() {"Flagged",
                                                         "Non-Flagged"
                                                         }
                    .Points.AddXY(strX, objRandom.Next(1000))
                Next

                .IsVisibleInLegend = False
                .Label = "#VALX\n#PERCENT"
            End With

            'force labels to appear outside the pie
            .Series("Students")("PieLabelStyle") = "Outside"

            'set the pie to be in 3D
            .ChartAreas(0).Area3DStyle.Enable3D = True
        End With
    End Function


End Class


