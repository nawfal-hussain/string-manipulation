Module Module1

    Sub Main()
        Dim max_count As Integer
        Dim char1 As String
        Dim str1 As String
        Dim counter As Integer
        Dim find As String
        Dim counter2 As Integer

        str1 = ""
        counter = 0
        Find = ""
        max_count = 0
        Console.Write("enter the sentence to be tested = ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        For counter2 = 97 To 122
            counter = 0
            For char_check = 1 To Len(str1)
                char1 = Mid(str1, char_check, 1)
                If char1 = Chr(counter2) Then
                    counter = counter + 1
                End If
            Next
            If max_count < counter Then
                max_count = counter
                find = counter2
            End If
        Next
        find = Chr(find)
        Console.Write("the letter repeated the most is = ")
        Console.Write(find)
        Console.ReadKey()
    End Sub

End Module
