Module Module1

    Sub Main()
        Dim str1, str2, str3, char1, char3, char2 As String
        Dim validBinaryString, proceed As Boolean
        Dim counter2, count, counter, counter3, sum, a, b, c, d, e, f, g, h, l, mNext As Integer

        mNext = 0
        sum = 0
        proceed = True
        count = 0
        a = 1
        b = 2
        c = 4
        d = 8
        e = 16
        f = 32
        g = 64
        h = 128
        l = 0
        str3 = ""
        char3 = ""
        validBinaryString = True
        str1 = ""
        str2 = "10"

        Console.Write("please enter the binary number = ")
        str1 = Console.ReadLine

        If Len(str1) > 8 Or Len(str1) < 8 Then
            validBinaryString = False
        End If
        If validBinaryString = True Then
            For counter = 1 To Len(str1)
                char1 = Mid(str1, counter, 1)
                For counter2 = 1 To Len(str2)
                    char2 = Mid(str2, counter2, 1)
                    If char1 = char2 Then
                        validBinaryString = True
                        Exit For
                    End If
                    If char1 <> char2 Then
                        validBinaryString = False
                    End If
                Next
            Next
        End If
        If validBinaryString = False Then
            Console.WriteLine("the binary number is not valid")
        End If
        l = Len(str1)
        l = l + 1
        For counter3 = 1 To Len(str1)
            proceed = True
            l = l - 1
            char3 = Mid(str1, l, 1)
            If proceed = True And count = 0 Then
                sum = sum + (char3 * a)
                count = count + 1
                proceed = False
            End If
            If proceed = True And count = 1 Then
                sum = sum + (char3 * b)
                count = count + 1
                proceed = False
            End If
            If proceed = True And count = 2 Then
                sum = sum + (char3 * c)
                count = count + 1
                proceed = False
            End If
            If proceed = True And count = 3 Then
                sum = sum + (char3 * d)
                count = count + 1
                proceed = False
            End If
            If proceed = True And count = 4 Then
                sum = sum + (char3 * e)
                count = count + 1
                proceed = False
            End If
            If proceed = True And count = 5 Then
                sum = sum + (char3 * f)
                count = count + 1
                proceed = False
            End If
            If proceed = True And count = 6 Then
                sum = sum + (char3 * g)
                count = count + 1
                proceed = False
            End If
            If proceed = True And count = 7 Then
                sum = sum + (char3 * h)
                count = count + 1
                proceed = False
            End If
        Next
        Console.Write("the binary numbers denary value is = ")
        Console.Write(sum)
        Console.ReadKey()

    End Sub

End Module
