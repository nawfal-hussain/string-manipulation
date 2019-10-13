Module Module1

    Sub Main()
        Dim counter, counter2, vowel_counter As Integer
        Dim str1, str2, char1, char2 As String

        str1 = ""
        str2 = "aeiou"
        counter = 0
        char1 = ""
        char2 = ""
        vowel_counter = 0
        counter2 = 0

        Console.Write("enter the sentence to be tested = ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        For counter = 1 To Len(str1)
            char1 = Mid(str1, counter, 1)
            For counter2 = 1 To Len(str2)
                char2 = Mid(str2, counter2, 1)
                If char1 = char2 Then
                    vowel_counter = vowel_counter + 1
                End If
            Next
        Next
        Console.Write("there were ")
        Console.Write(vowel_counter)
        Console.Write(" vowels in the sentence.")
        Console.ReadKey()

    End Sub

End Module
