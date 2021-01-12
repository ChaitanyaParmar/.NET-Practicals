Module Practical_12_2
    Sub main()
        Dim i, j, n As Integer
        n = 5
        For i = 1 To n Step 1
            For j = 1 To n - i Step 1
                Console.Write(" ")
            Next
            For j = 1 To i Step 1
                Console.Write("*")
            Next
            Console.Write(vbnewline)
        Next
        Console.Read()
    End Sub
End Module
