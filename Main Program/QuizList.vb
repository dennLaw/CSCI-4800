Public Class QuizList

    Private quizList As List(Of QuizQuestion)

    Public Sub New()
        quizList = New List(Of QuizQuestion)
    End Sub

    'Adds a QuizQuestion to the list of the parameters passed in.
    Public Sub addQuizQuestion(ByVal q As String, ByVal o1 As String, ByVal o2 As String, ByVal o3 As String, ByVal o4 As String, ByVal a As Integer)
        quizList.Add(New QuizQuestion(q, o1, o2, o3, o4, a))
    End Sub

    Public Sub addQuizQuestion(ByVal qQ As QuizQuestion)
        quizList.Add(qQ)
    End Sub

    'Removes the first instance of a QuizQuestion matching 
    Public Sub removeQuizQuestion(ByVal qQ As QuizQuestion)
        quizList.Remove(qQ)
    End Sub

    'Returns the QuizQuestion saved at index.
    'If index is invalid, returns dummy.
    Public Function getIndex(ByVal index As Integer) As QuizQuestion
        If (index < quizList.Count And index > -1) Then
            Return quizList(index)
        Else
            Return New QuizQuestion("", "", "", "", "", -1)
        End If
    End Function

    Public Function getCount() As Integer
        Return quizList.Count
    End Function
End Class
