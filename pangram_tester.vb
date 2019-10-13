Module Module1

    Sub Main()
        Dim str1 As String
        Dim alphabet_to_be_checked As String
        Dim alphabet_being_checked As String
        Dim continue_loop As Boolean
        Dim counter As Integer
        Dim counter_2 As Integer
        Dim continue_2nd_loop As Boolean

        alphabet_being_checked = ""
        alphabet_to_be_checked = ""
        continue_loop = True
        str1 = ""
        continue_2nd_loop = True

        Console.Write("enter the sentence which is to be tested = ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        If Len(str1) < 26 Then
            Console.Write("the sentence cant be a pangram")
            Console.ReadKey()
            End
        End If
        For counter = 97 To 122
            alphabet_to_be_checked = Chr(counter)
            If continue_loop = True Then
                For counter_2 = 1 To Len(str1)
                    alphabet_being_checked = Mid(str1, counter_2, 1)
                    If alphabet_being_checked <> alphabet_to_be_checked And continue_2nd_loop = True Then
                        continue_2nd_loop = False
                    ElseIf alphabet_being_checked = alphabet_to_be_checked Then
                        continue_2nd_loop = True
                        Exit For
                    End If
                Next
                If continue_2nd_loop = False Then
                    continue_loop = False
                End If
            End If
        Next
        If continue_loop = False Then
            Console.Write("the sentence does not contain all the letters")
            Console.ReadKey()
            End
        End If
        Console.Write("the sentence is a pangram")
        Console.ReadKey()
    End Sub

End Module
