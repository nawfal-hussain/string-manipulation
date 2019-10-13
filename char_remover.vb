Module Module1

    Sub Main()
        Dim nextChar, str1, str2, char1 As String
        Dim counter As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        counter = 0
        nextChar = ""

        Console.Write("enter string = ")
        str1 = Console.ReadLine
        Console.Write("enter the character which need to be removed = ")
        char1 = Console.ReadLine

        For counter = 1 To Len(str1)
            nextChar = Mid(str1, counter, 1)
            If nextChar = char1 Then
                nextChar = ""
                str2 = str2 & nextChar
            Else
                str2 = str2 & nextChar
            End If
        Next counter
        Console.WriteLine("final string is = " & str2)
        Console.ReadKey()
    End Sub

End Module
