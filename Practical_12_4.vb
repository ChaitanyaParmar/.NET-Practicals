Module Practical_12_4
    Sub Main()
        Dim i, j, n, a As Integer
        n = 4
        a = 1
        For i = 1 To n Step 1
            For j = 1 To n - i Step 1
                Console.Write(" ")
            Next
            For j = 1 To i Step 1
                Console.Write("{0}  ", a)
                a += 1
            Next
            Console.Write(vbNewLine)
        Next
        Console.Read()
    End Sub
End Module
