Imports System.Console
Module Practical_06

    Sub Main()
        Dim a, b, choice As Integer
repeat:
        WriteLine("1. Addition, 2. Subtraction, 3. Division, 4. Multiplication, 5. Exponential, 6.Modulo, 7.Exit")
        choice = CInt(ReadLine())

        If choice = 1 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a + b)
            Write(vbNewLine)
            GoTo repeat
        ElseIf choice = 2 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a - b)
            Write(vbNewLine)
            GoTo repeat
        ElseIf choice = 3 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a / b)
            Write(vbNewLine)
            GoTo repeat
        ElseIf choice = 4 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a * b)
            Write(vbNewLine)
            GoTo repeat
        ElseIf choice = 5 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a ^ b)
            Write(vbNewLine)
            GoTo repeat
        ElseIf choice = 6 Then
            WriteLine("Enter number 1:")
            a = CInt(ReadLine())
            WriteLine("Enter number 2:")
            b = CInt(ReadLine())
            WriteLine("Ans is {0}", a Mod b)
            Write(vbNewLine)
            GoTo repeat
        ElseIf choice = 7 Then
            GoTo xx
        Else
            WriteLine("Wrong input!!")
            Write(vbNewLine)
        End If
        Read()
xx:
    End Sub
End Module
