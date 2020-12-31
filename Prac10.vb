Imports System.Console
Module Prac10
    Sub main()
        Dim a, b, c, i, n As Integer
        WriteLine("Enter the no. of elements: ")
        n = Val(ReadLine())
        a = 1
        b = 1
        WriteLine(a)
        WriteLine(b)
        i = 1
        For i = 1 To n - 2 Step 1
            c = a + b
            WriteLine(c)
            a = b
            b = c
            'i += 1
        Next i
        Read()
    End Sub
End Module
