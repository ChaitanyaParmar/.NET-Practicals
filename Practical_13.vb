Imports System.Console
Module Practical_13
    Sub main()
        Dim a(5), x, y, temp, i As Integer
        For i = 0 To 5
            Write("Enter array element on a({0}): ", i)
            a(i) = CInt(ReadLine())
        Next
        For i = 0 To 5 Step 1
            Write("Array element a({0}) is {1} ", i, a(i))
        Next
        For x = 0 To 5
            For y = x + 1 To 5
                If a(x) < a(y) Then
                    temp = a(x)
                    a(x) = a(y)
                    a(y) = temp
                End If
            Next
        Next
        Write("Ascending order: ")
        For x = 0 To 5
            WriteLine("{0}", a(x))
        Next

        For x = 0 To 5
            For y = x + 1 To 5
                If a(x) > a(y) Then
                    temp = a(x)
                    a(x) = a(y)
                    a(y) = temp
                End If
            Next
        Next
        Write("Descending order: ")
        For x = 0 To 5
            WriteLine("{0}", a(x))
        Next
        Read()
    End Sub
End Module
