Imports System.Console
Module Practical_15
    Sub main()
        Dim a As Integer()() = New Integer(4)() {}
        a(0) = New Integer() {1, 5, 7}
        a(1) = New Integer() {12, 0, 4, 6, 9}
        a(2) = New Integer() {2}
        a(3) = New Integer() {1, 1, 4}
        a(4) = New Integer() {44, 5, 77, 69}
        Dim b, c As Integer

        For b = 0 To UBound(a)
            For c = 0 To UBound(a(b))
                WriteLine("The value on index a({0})({1}) is {2}", b, c, a(b)(c))
            Next
        Next
        Read()
    End Sub
End Module
