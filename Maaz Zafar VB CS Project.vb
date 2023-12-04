
' 1. AllAlphabets
Public Function AllAlphabets(s As String) As Boolean
    Dim charCounts(255) As Integer

    For Each c As Char In s
        charCounts(Asc(Char.ToLower(c))) += 1
    Next

    For i As Integer = Asc("a") To Asc("z")
        If charCounts(i) = 0 Then
            Return False
        End If
    Next

    Return True
End Function

' 2. ReplaceChar
Public Function ReplaceChar(s As String, oldChar As Char, newChar As Char) As String
    Return s.Replace(oldChar, newChar)
End Function

' 3. CountChar
Public Function CountChar(s As String, c As Char) As Integer
    Return s.Count(Function(x) x = c)
End Function

Public Function CountCharCategories(s As String) As (Int, Int, Int)
    Dim charCounts(255) As Integer
    Dim alphabetCount As Integer = 0
    Dim digitCount As Integer = 0
    Dim otherCount As Integer = 0

    For Each c As Char In s
        charCounts(Asc(Char.ToLower(c))) += 1
    Next

    For i As Integer = Asc("a") To Asc("z")
        alphabetCount += charCounts(i)
    Next

    For i As Integer = Asc("0") To Asc("9")
        digitCount += charCounts(i)
    Next

    For i As Integer = 0 To 255
        If i < Asc("a") OrElse i > Asc("z") AndAlso i < Asc("0") OrElse i > Asc("9") Then
            otherCount += charCounts(i)
        End If
    Next

    Return (alphabetCount, digitCount, otherCount)
End Function

' 4. MostFrequentChar
Public Function MostFrequentChar(s As String) As Char
    Dim charCounts(255) As Integer
    Dim maxCount As Integer = 0
    Dim maxChar As Char = ""

    For Each c As Char In s
        charCounts(Asc(Char.ToLower(c))) += 1
    Next

    For i As Integer = 0 To 255
        If charCounts(i) > maxCount Then
            maxCount = charCounts(i)
            maxChar = Chr(i)
        End If
    Next

    Return maxChar
End Function

' 5. CountVowels
Public Function CountVowels(s As String) As Integer
    Dim vowels As String = "aeiou"
    Dim count As Integer = 0

    For Each c As Char In s
        If vowels.Contains(Char.ToLower(c)) Then
            count += 1
        End If
    Next

    Return count
End Function

' 6. Donuts
Public Function Donuts(count As Integer) As String
    If count < 10 Then
        Return $"Number of donuts: {count}"
    Else
        Return "Number of donuts: many"
    End If
End Function

' 7. BothEnds
Public Function BothEnds(s As String) As String
    If s.Length < 2 Then
        Return s
    End If

    Return s(1) & s(0) & s.Substring(2, s.Length - 3) & s(1) & s(0)
End Function

' 8. FixStart
Public Function FixStart(s As String) As String
    If s(0) = s(1) Then
        Return s
    End If

    Return s(0) & "*" & s.Substring(2)
End Function

' 9. MixUp
Public Function MixUp(a As String, b As String) As String
    Return a(1) & a(0) & b.Substring(2) & " " & a.Substring(2) & b(1) & b(0)
End Function

' 10. Verbing
Public Function Verbing(s As String) As String
    If s.Length < 3 Then
        Return s
    End If

    If s.EndsWith("ing") Then
        Return s & "ly"
    Else
        Return s & "ing"
    End If
End Function

' 11. NotBad
Public Function NotBad(s As String) As String
    Dim notIndex As Integer = s.IndexOf("not")
    Dim badIndex As Integer = s.IndexOf("bad")

    If notIndex >= 0 AndAlso badIndex > notIndex Then
        s = s.Remove(notIndex, 3).Insert(notIndex, "good")
    End If

    Return s
End Function

