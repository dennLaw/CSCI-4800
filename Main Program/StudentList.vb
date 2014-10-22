Public Class StudentList

    Private studentList As List(Of Student)

    Public Sub New()
        studentList = New List(Of Student)
    End Sub

    Public Sub New(ByVal sstudentList As List(Of Student))
        studentList = sstudentList
    End Sub

    Public Sub New(ByVal sstudentList As StudentList)
        studentList = New List(Of Student)
    End Sub

    'Adds a Student to the list of the parameters passed in.
    Public Sub addStudent(ByVal last As String, ByVal first As String, ByVal id As Integer, ByVal hours As Integer, ByVal email As String, ByVal tryToFlag As Boolean)
        studentList.Add(New Student(last, first, id, hours, email, tryToFlag))
    End Sub

    'Adds a Student to the list.
    Public Sub addStudent(ByVal student As Student)
        studentList.Add(student)
    End Sub

    'Removes the first occurence of an object matching the "Student" passed in exactly.
    Public Sub removeStudent(ByVal student As Student)
        studentList.Remove(student)
    End Sub

    'Returns a new StudentList sorted as requested.
    'If the fieldNumber is  0: Sort by First Name
    '                       1: Sort by Last Name
    '                       2: Sort by ID
    '                       3: Sort by Hours
    '                       4: Sort by Email
    '                       5: Sort by Completion
    '                       6: Sort by Flag
    'The variable upOrDown should be    0: Increasing Order
    '                                   1: Decreasing Order
    Public Function sortBy(ByVal fieldNumber As Integer, ByVal upOrDown As Integer) As StudentList
        Dim returnList = New StudentList()

        If fieldNumber = 0 & upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFirst() & ", " & currentStudent.getLast()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 0 & upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFirst() & ", " & currentStudent.getLast()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 1 & upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 1 & upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 2 & upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getID()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 2 & upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getID()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 3 & upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getHours()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 3 & upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getHours()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 4 & upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getEmail()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 4 & upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getEmail()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 5 & upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getComplete()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 5 & upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getComplete()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 6 & upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFlagged()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 6 & upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFlagged()
                Order By search Descending
                Select currentStudent
        End If

        Return New StudentList(returnList)
    End Function

    'Returns any Students with any field matching searchFor.
    Public Function searchBy(ByVal searchFor As String) As StudentList
        Dim returnList = New StudentList()

        returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFlagged()
                Where currentStudent.getFirst().IndexOf(searchFor) <> -1 Or
                    currentStudent.getLast().IndexOf(searchFor) <> -1 Or
                    CStr(currentStudent.getID()).IndexOf(searchFor) <> -1 Or
                    CStr(currentStudent.getHours()).IndexOf(searchFor) <> -1 Or
                    currentStudent.getEmail().IndexOf(searchFor) <> -1 Or
                    CStr(currentStudent.getComplete()).IndexOf(searchFor) <> -1 Or
                    CStr(currentStudent.getFlagged()).IndexOf(searchFor) <> -1
                Order By search Ascending
                Select currentStudent

        Return New StudentList(returnList)
    End Function

    'Returns the Student saved at index.
    Public Function getIndex(ByVal index As Integer) As Student
        If (index < studentList.Count) Then
            Return studentList(index)
        Else
            Return New Student("", "", -1, -1, "", False)
        End If
    End Function

    'Returns size of the list.
    Public Function getCount() As Integer
        Return studentList.Count
    End Function
End Class
