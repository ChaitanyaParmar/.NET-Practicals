Imports System.Console
Module Prac11
    Sub main()
        Dim a, i, fact
        WriteLine("Enter no. :")
        a = CInt(ReadLine())
        fact = 1

        For i = 1 To a Step 1
            fact *= i
        Next i
        WriteLine("Ans is {0} ", fact)
        Read()
    End Sub
End Module
