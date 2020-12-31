Imports System.Console
Module Prac06
    Sub main()
        Dim a, b, choice As Integer

        WriteLine("1. Addition, 2. Subtraction, 3. Division, 4. Multiplication, 5. Square, 6.Cube")
        choice = CInt(ReadLine())

        If choice = 1 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a + b)

        ElseIf choice = 2 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a - b)

        ElseIf choice = 3 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a / b)

        ElseIf choice = 4 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a * b)

        ElseIf choice = 5 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Ans is {0}", a * a)

        Else choice = 6
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", b * b * b)
        End If
    End Sub
End Module
