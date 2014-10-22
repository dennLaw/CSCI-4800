﻿Public Class StudentList

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

    'Attempts to flag the first Student matching the passed in student.
    'If student has less than 30 hours, will not flag.
    Public Sub tryToFlag(ByVal student As Student)
        studentList.Find(Function(e) e.Equals(student)).tryToFlag()
    End Sub

    'Flags the first Student matching the passed in student.
    Public Sub flagStudent(ByVal student As Student)
        studentList.Find(Function(e) e.Equals(student)).forceFlag()
    End Sub

    'Unflags the first Student matching the passed in student.
    Public Sub unflagStudent(ByVal student As Student)
        studentList.Find(Function(e) e.Equals(student)).forceUnflag()
    End Sub

    'Flags the first Student matching the passed in student.
    Public Sub completeStudent(ByVal student As Student)
        studentList.Find(Function(e) e.Equals(student)).setComplete()
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
    '
    'On incorrect input, will return an empty list.
    Public Function sortBy(ByVal fieldNumber As Integer, ByVal upOrDown As Integer) As StudentList
        Dim returnList = New StudentList()

        If fieldNumber = 0 And upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFirst() & ", " & currentStudent.getLast()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 0 And upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFirst() & ", " & currentStudent.getLast()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 1 And upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 1 And upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 2 And upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getID()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 2 And upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getID()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 3 And upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getHours()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 3 And upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getHours()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 4 And upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getEmail()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 4 And upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getEmail()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 5 And upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getComplete()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 5 And upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getComplete()
                Order By search Descending
                Select currentStudent

        ElseIf fieldNumber = 6 And upOrDown = 0 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getFlagged()
                Order By search Ascending
                Select currentStudent

        ElseIf fieldNumber = 6 And upOrDown = 1 Then
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

    'Returns flagged.
    'Ordered Last-First
    Public Function getFlagged() As StudentList
        Dim returnList = New StudentList()

        returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Where currentStudent.getComplete()
                Order By search Ascending
                Select currentStudent

        Return New StudentList(returnList)
    End Function

    'Returns those without flags.
    'Ordered Last-First
    Public Function getNonFlagged() As StudentList
        Dim returnList = New StudentList()

        returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Where currentStudent.getComplete()
                Order By search Ascending
                Select currentStudent

        Return New StudentList(returnList)
    End Function

    'Returns those that completed the course
    'Ordered Last-First
    Public Function getComplete() As StudentList
        Dim returnList = New StudentList()

        returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Where currentStudent.getComplete()
                Order By search Ascending
                Select currentStudent

        Return New StudentList(returnList)
    End Function

    'Returns those that have not completed the course
    'Ordered Last-First
    Public Function getIncomplete() As StudentList
        Dim returnList = New StudentList()

        returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Where Not currentStudent.getComplete()
                Order By search Ascending
                Select currentStudent

        Return New StudentList(returnList)
    End Function

    'Returns those that have less than thirty hours.
    'Ordered Last-First
    Public Function getLessThanThirtyHours() As StudentList
        Dim returnList = New StudentList()

        returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Where currentStudent.getHours() < 30
                Order By search Ascending
                Select currentStudent

        Return New StudentList(returnList)
    End Function

    'Returns those that have more than or equal to than thirty hours.
    'Ordered Last-First
    Public Function getMoreThanThirtyHours() As StudentList
        Dim returnList = New StudentList()

        returnList =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Where currentStudent.getHours() >= 30
                Order By search Ascending
                Select currentStudent

        Return New StudentList(returnList)
    End Function

    'Returns the Student saved at index.
    'If index is invalid, returns dummy.
    Public Function getIndex(ByVal index As Integer) As Student
        If (index < studentList.Count And index > -1) Then
            Return studentList(index)
        Else
            Return New Student("", "", -1, -1, "", False)
        End If
    End Function

    'Returns size of the list.
    Public Function getCount() As Integer
        Return studentList.Count
    End Function

    'Gets the average time of the list.
    Public Function getAvgTime() As Double
        Dim sum As Double = 0

        For Each currentStudent In studentList
            If (currentStudent.getTime <> -1) Then
                sum += currentStudent.getTime()
            End If
        Next

        Return (sum / CDbl(studentList.Count))
    End Function

    'Takes in filePath as the CSV to read in.
    'Takes tryToFlag to pass into the new students.
    'Assumes the CSV is completely correct.
    Public Sub readCSV(ByVal filePath As String, ByVal tryToFlag As Boolean)

        Try
            Using MyReader As New Microsoft.VisualBasic.
                              FileIO.TextFieldParser(filePath)

                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")

                Dim fieldNumber As Integer = 0
                Dim currentField As String
                Dim currentRow As String()
                Dim lastName As String = ""
                Dim firstName As String = ""
                Dim UGAID As Integer = -1
                Dim hours As Integer = -1
                Dim email As String = ""

                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()

                        For Each currentField In currentRow
                            Select Case fieldNumber
                                Case 1
                                    lastName = currentField
                                Case 2
                                    firstName = currentField
                                Case 3
                                    UGAID = CInt(currentField)
                                Case 4
                                    hours = CInt(currentField)
                                Case 5
                                    email = currentField
                                Case Else
                                    MsgBox("The CSV file has incorrect input.")
                            End Select

                            fieldNumber += 1
                        Next
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try

                    If (fieldNumber > 5) Then
                        studentList.Add(New Student(lastName, firstName, UGAID, hours, email, tryToFlag))
                    Else
                        MsgBox("The CSV file has incorrect input")
                    End If

                    fieldNumber = 0
                End While
            End Using
        Catch ex As Exception
            MsgBox("Could not read from " & filePath & ".")
        End Try
    End Sub
End Class
