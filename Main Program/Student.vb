Public Class Student

    Private lastName As String
    Private firstName As String
    Private UGAID As Integer
    Private hours As Integer
    Private isComplete As Boolean
    Private isFlagged As Boolean
    Private email As String
    Private timeToComplete As Integer

    'Sets all the beginning variables.
    'If tryToFlag is true and hours is above 30, then the flag becomes true.
    Public Sub New(ByVal last As String, ByVal first As String, ByVal id As Integer, ByVal hhours As Integer, ByVal eemail As String, ByVal tryToFlag As Boolean)
        lastName = last
        firstName = first
        UGAID = id
        hours = hhours
        isComplete = False
        email = eemail
        timeToComplete = -1

        If (tryToFlag And hhours >= 30) Then
            isFlagged = True
        Else
            isFlagged = False
        End If
    End Sub

    'Returns last name.
    Public Function getLast() As String
        Return lastName
    End Function

    'Returns first name.
    Public Function getFirst() As String
        Return firstName
    End Function

    'Returns hours.
    Public Function getHours() As Integer
        Return hours
    End Function

    'Returns UGAID.
    Public Function getID() As Integer
        Return UGAID
    End Function

    'Returns completion.
    Public Function getComplete() As Boolean
        Return isComplete
    End Function

    'Returns flag.
    Public Function getFlagged() As Boolean
        Return isFlagged
    End Function

    'Returns email.
    Public Function getEmail() As String
        Return email
    End Function

    'Returns the completion time.
    'If -1 is returned, it means the student didn't complete yet, or flag forcibly set to complete.
    Public Function getTime() As Integer
        Return timeToComplete
    End Function

    'Sets the completion to True and flag to False.
    Public Sub setComplete()
        isComplete = True
        isFlagged = False
    End Sub

    'Sets the completion to false.
    Public Sub setIncomplete()
        isComplete = False
    End Sub
    Public Sub setID(ByVal id As Integer)
        UGAID = id
    End Sub
    Public Sub forceUnflag()
        isFlagged = False
    End Sub

    Public Sub forceFlag()
        isFlagged = True
    End Sub

    'Tries to flag the account
    'If the course isn't completed and hours are above 30, then flag is turns to true.
    Public Sub tryToFlag()
        If Not isComplete & hours >= 30 Then
            isFlagged = True
        End If
    End Sub

    'Changes email.
    Public Sub setEmail(ByVal eemail As String)
        email = eemail
    End Sub

    'Changes hours.
    Public Sub setHours(ByVal hhours As Integer)
        hours = hhours
    End Sub

    'Changes first name.
    Public Sub setFirstName(ByVal first As String)
        firstName = first
    End Sub

    'Changes last name.
    Public Sub setLastName(ByVal last As String)
        lastName = last
    End Sub

    'Sets the time to complete.
    Public Sub setTimeToComplete(ByVal time As Integer)
        timeToComplete = time
    End Sub
End Class
