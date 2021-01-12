Module Practical_12_3
    Sub Main()
        Dim i, j, n As Integer
        n = 4
        For i = 1 To n Step 1
            For j = 1 To n - i Step 1
                Console.Write(" ")
            Next
            For j = 1 To i Step 1
                Console.Write("* ")
            Next
            Console.Write(vbNewLine)
        Next
        Console.Read()
    End Sub
End Module
