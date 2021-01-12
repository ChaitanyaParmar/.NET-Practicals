Module Practical_12_1
    Sub main()
        Dim i, j, n As Integer
        n = 5
        For i = 1 To n Step 1
            For j = 1 To i Step 1
                Console.Write("*")
            Next
            Console.Write(vbNewLine)
        Next
        Console.Read()
    End Sub
End Module
