Imports System.Console

Module Prac05
    Sub Main()
        Dim a, b, c As Integer
        WriteLine("Enter number 1:")
        a = CInt(ReadLine())
        WriteLine("Enter number 2:")
        b = CInt(ReadLine())
        WriteLine("Enter number 3:")
        c = CInt(ReadLine())
        If a > b And a > c Then
            WriteLine("A is max")
        ElseIf b > c Then
            WriteLine("B is max")
        Else
            WriteLine("C is max")
            Read()
        End If
    End Sub
End Module
