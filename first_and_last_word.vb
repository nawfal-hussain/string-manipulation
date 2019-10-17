Module Module1

    Sub Main()
        Dim str1, str2, char1, char2, full_name, first_lastword As String
        Dim space_finder As Integer


        first_lastword = ""
        space_finder = 0
        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        full_name = ""


        Console.Write("enter first name ")
        str1 = Console.ReadLine
        Console.Write("enter second name ")
        str2 = Console.ReadLine
        full_name = str1 & " " & str2


        char1 = Mid(str1, 1, 1)
        char2 = Mid(str2, 1, 1)
        s()

        first_lastword = char1 & " " & char2
        Console.Write(first_lastword)
        Console.ReadKey()

    End Sub

End Module
