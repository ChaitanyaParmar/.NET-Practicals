Imports System.Console
Module Practical_14
    Sub Main()
        Dim a(2, 3) As Integer
        Dim i, j, val As Integer

        For i = 0 To UBound(a)
            For j = 0 To UBound(a, 1)
                Write("Enter value for a({0})({1}): ", i, j)
                a(i, j) = CInt(ReadLine())
            Next
        Next

        Write("Enter value for searching: ")
        val = CInt(ReadLine())

        For i = 0 To UBound(a)
            For j = 0 To 2
                If a(i, j) = val Then
                    WriteLine("The value found at a({0})({1})", i, j)
                End If
            Next
        Next
        Read()
    End Sub
End Module
