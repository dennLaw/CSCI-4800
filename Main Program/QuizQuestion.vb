Public Class QuizQuestion

    Private question As String
    Private option1 As String
    Private option2 As String
    Private option3 As String
    Private option4 As String
    Private answer As Integer

    Public Sub New(ByVal q As String, ByVal o1 As String, ByVal o2 As String, ByVal o3 As String, ByVal o4 As String, a As Integer)
        question = q
        option1 = o1
        option2 = o2
        option3 = o3
        option4 = o4
        answer = a
    End Sub

    Public Function checkAnswer(ByVal a As Integer) As Boolean
        Return a = answer
    End Function

    Public Function getQuestion() As String
        Return question
    End Function

    Public Function getOptionOne() As String
        Return option1
    End Function

    Public Function getOptionTwo() As String
        Return option2
    End Function

    Public Function getOptionThree() As String
        Return option3
    End Function

    Public Function getOptionFour() As String
        Return option4
    End Function
End Class
