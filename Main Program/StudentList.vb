Public Class StudentList

    Private studentList As List(Of Student)

    Public Sub New()
        studentList = New List(Of Student)
    End Sub

    'Adds a Student to the list of the parameters passed in.
    Public Sub addStudent(ByVal last As String, ByVal first As String, ByVal id As Integer, ByVal hours As Integer, ByVal email As String, ByVal tryToFlag As Boolean)
        studentList.Add(New Student(last, first, id, hours, email, tryToFlag))
    End Sub

    'Adds a Student to the list.
    Public Function addStudent(ByVal student As Student) As Student
        studentList.Add(student)

        Return student
    End Function

    'Removes the first occurence of an object matching the "Student" passed in exactly.
    Public Sub removeStudent(ByVal last As String, ByVal first As String, ByVal id As Integer, ByVal hours As Integer, ByVal email As String, ByVal tryToFlag As Boolean)
        studentList.Remove(New Student(last, first, id, hours, email, tryToFlag))
    End Sub

    'Removes the first occurence an object matching the "Student" passed in exactly.
    Public Sub removeStudent(ByVal student As Student)
        studentList.Remove(student)
    End Sub

    'Removes the first occurence of an object's ID matching the ID passed in.
    Public Sub removeStudentByID(ByVal ID As Integer)
        Dim temp As StudentList = New StudentList()
        Dim flag = False

        For Each currentStudent In studentList
            If CStr(currentStudent.getID()).IndexOf(CStr(ID)) <> -1 Then
                temp.addStudent(currentStudent)
                flag = True
            End If
        Next

        studentList.Remove(temp.getIndex(0))
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

    'Flags the first Student matching the passed in student.
    Public Sub incompleteStudent(ByVal student As Student)
        studentList.Find(Function(e) e.Equals(student)).setIncomplete()
    End Sub

    'Flags all students matching ID as complete.
    Public Sub completeStudent(ByVal ID As Integer)
        Dim flag = False

        For Each currentStudent In studentList
            If CStr(currentStudent.getID()).IndexOf(CStr(ID)) <> -1 Then
                currentStudent.setComplete()
                flag = True
            End If
        Next
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
        Dim temp

        If fieldNumber = 0 And upOrDown = 0 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getFirst() & ", " & currentStudent.getLast()
                Order By search Ascending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 0 And upOrDown = 1 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getFirst() & ", " & currentStudent.getLast()
                Order By search Descending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 1 And upOrDown = 0 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Order By search Ascending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 1 And upOrDown = 1 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getLast() & ", " & currentStudent.getFirst()
                Order By search Descending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 2 And upOrDown = 0 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getID()
                Order By search Ascending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 2 And upOrDown = 1 Then
            returnList =
                From currentStudent In studentList
                Let search = currentStudent.getID()
                Order By search Descending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 3 And upOrDown = 0 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getHours()
                Order By search Ascending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 3 And upOrDown = 1 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getHours()
                Order By search Descending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 4 And upOrDown = 0 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getEmail()
                Order By search Ascending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 4 And upOrDown = 1 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getEmail()
                Order By search Descending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 5 And upOrDown = 0 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getComplete()
                Order By search Ascending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 5 And upOrDown = 1 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getComplete()
                Order By search Descending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 6 And upOrDown = 0 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getFlagged()
                Order By search Ascending
                Select returnList.addStudent(currentStudent)

        ElseIf fieldNumber = 6 And upOrDown = 1 Then
            temp =
                From currentStudent In studentList
                Let search = currentStudent.getFlagged()
                Order By search Descending
                Select returnList.addStudent(currentStudent)
        End If

        Return returnList
    End Function

    'Returns any Students with any field matching searchFor.
    Public Function searchBy(ByVal searchFor As String) As StudentList
        Dim returnList As StudentList = New StudentList()
        Dim flag = False
        Dim dummyList = New StudentList()
        dummyList.addStudent("", "", -1, -1, "", False)

        For Each currentStudent In studentList
            If currentStudent.getFirst().IndexOf(searchFor) <> -1 Or _
                currentStudent.getLast().IndexOf(searchFor) <> -1 Or _
                CStr(currentStudent.getID()).IndexOf(searchFor) <> -1 Or _
                CStr(currentStudent.getHours()).IndexOf(searchFor) <> -1 Or _
                currentStudent.getEmail().IndexOf(searchFor) <> -1 Then

                returnList.addStudent(currentStudent)
                flag = True
            End If
        Next

        If flag Then
            Return returnList
        Else
            Return dummyList
        End If
    End Function

    'Returns flagged.
    'Ordered Last-First
    Public Function getFlagged() As StudentList
        Dim returnList As StudentList = New StudentList()
        Dim flag = False
        Dim dummyList = New StudentList()
        dummyList.addStudent("", "", -1, -1, "", False)

        For Each currentStudent In studentList
            If currentStudent.getFlagged() Then
                returnList.addStudent(currentStudent)
                flag = True
            End If
        Next

        If flag Then
            Return returnList
        Else
            Return dummyList
        End If

    End Function

    'Returns those without flags.
    'Ordered Last-First
    Public Function getNonFlagged() As StudentList
        Dim returnList As StudentList = New StudentList()
        Dim flag = False
        Dim dummyList = New StudentList()
        dummyList.addStudent("", "", -1, -1, "", False)

        For Each currentStudent In studentList
            If Not currentStudent.getFlagged() Then
                returnList.addStudent(currentStudent)
                flag = True
            End If
        Next

        If flag Then
            Return returnList
        Else
            Return dummyList
        End If

    End Function

    'Returns those that completed the course
    'Ordered Last-First
    Public Function getComplete() As StudentList
        Dim returnList As StudentList = New StudentList()
        Dim flag = False
        Dim dummyList = New StudentList()
        dummyList.addStudent("", "", -1, -1, "", False)

        For Each currentStudent In studentList
            If currentStudent.getComplete() Then
                returnList.addStudent(currentStudent)
                flag = True
            End If
        Next

        If flag Then
            Return returnList
        Else
            Return dummyList
        End If

    End Function

    'Returns those that have not completed the course
    'Ordered Last-First
    Public Function getIncomplete() As StudentList
        Dim returnList As StudentList = New StudentList()
        Dim flag = False
        Dim dummyList = New StudentList()
        dummyList.addStudent("", "", -1, -1, "", False)

        For Each currentStudent In studentList
            If Not currentStudent.getComplete() Then
                returnList.addStudent(currentStudent)
                flag = True
            End If
        Next

        If flag Then
            Return returnList
        Else
            Return dummyList
        End If
    End Function

    'Returns those that have less than thirty hours.
    'Ordered Last-First
    Public Function getLessThanThirtyHours() As StudentList
        Dim returnList As StudentList = New StudentList()
        Dim flag = False
        Dim dummyList = New StudentList()
        dummyList.addStudent("", "", -1, -1, "", False)

        For Each currentStudent In studentList
            If currentStudent.getHours() < 30 Then
                returnList.addStudent(currentStudent)
                flag = True
            End If
        Next

        If flag Then
            Return returnList
        Else
            Return dummyList
        End If

    End Function

    'Returns those that have more than or equal to than thirty hours.
    'Ordered Last-First
    Public Function getMoreThanThirtyHours() As StudentList
        Dim returnList As StudentList = New StudentList()
        Dim flag = False
        Dim dummyList = New StudentList()
        dummyList.addStudent("", "", -1, -1, "", False)

        For Each currentStudent In studentList
            If currentStudent.getHours() >= 30 Then
                returnList.addStudent(currentStudent)
                flag = True
            End If
        Next

        If flag Then
            Return returnList
        Else
            Return dummyList
        End If

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

    'Populates the list with random times.
    'Assigns each student with a time between 1 and 100
    Public Sub populateListRandomTime()

        For Each currentStudent In studentList
            currentStudent.setTimeToComplete(CInt(Math.Floor(100 * Rnd())) + 1)
        Next

    End Sub

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
    'Adds onto the existing list. Does NOT return a new StudentList.
    Public Sub readCSV(ByVal filePath As String, ByVal tryToFlag As Boolean)

        Try
            Using MyReader As New Microsoft.VisualBasic.
                              FileIO.TextFieldParser(filePath)

                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")

                Dim fieldNumber As Integer = 1
                Dim currentField As String
                Dim currentRow As String()
                Dim lastName As String = ""
                Dim firstName As String = ""
                Dim UGAID As Integer = -1
                Dim hours As Integer = -1
                Dim email As String = ""
                Dim flag As Boolean = False
                Dim complete As Boolean = False

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
                                Case 6
                                    flag = CBool(currentField)
                                Case 7
                                    complete = CBool(currentField)
                                Case Else
                                    MsgBox("The CSV file has incorrect input.")
                            End Select

                            fieldNumber += 1
                        Next
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try

                    If fieldNumber > 5 Then
                        studentList.Add(New Student(lastName, firstName, UGAID, hours, email, tryToFlag))

                        If (complete) Then
                            studentList(studentList.Count - 1).setComplete()
                        End If

                        If (flag) Then
                            studentList(studentList.Count - 1).forceFlag()
                        End If

                    Else
                        MsgBox("The CSV file has incorrect input")
                    End If

                    fieldNumber = 1
                End While
            End Using
        Catch ex As Exception
            MsgBox("Could not read from " & filePath & ".")
        End Try
    End Sub

    Public Sub writeCSV(ByVal fileName As String)

        If studentList.Count > 0 Then
            Try
                My.Computer.FileSystem.WriteAllText(fileName, studentList(0).getLast() & "," & studentList(0).getFirst() & "," & studentList(0).getID() & "," & studentList(0).getHours() & "," & studentList(0).getEmail() & studentList(0).getFlagged() & "," & studentList(0).getComplete() & vbCrLf, False)
            Catch ex As Exception

            End Try

            If studentList.Count > 1 Then
                For i As Integer = 1 To studentList.Count
                    Try
                        My.Computer.FileSystem.WriteAllText(fileName, studentList(i).getLast() & "," & studentList(i).getFirst() & "," & studentList(i).getID() & "," & studentList(i).getHours() & "," & studentList(i).getEmail() & studentList(i).getFlagged() & "," & studentList(i).getComplete() & vbCrLf, True)
                    Catch ex As Exception

                    End Try
                Next
            End If
        End If
    End Sub
End Class
