Imports System.Console
Module Prac08
    Sub main()
        Dim month
        WriteLine("Enter no. of Month: ")
        month = CInt(ReadLine())

        Select Case month
            Case 1
                WriteLine("January")
            Case 2
                WriteLine("February")
            Case 3
                WriteLine("March")
            Case 4
                WriteLine("April")
            Case 5
                WriteLine("May")
            Case 6
                WriteLine("June")
            Case 7
                WriteLine("July")
            Case 8
                WriteLine("August")
            Case 9
                WriteLine("September")
            Case 10
                WriteLine("October")
            Case 11
                WriteLine("November")
            Case 12
                WriteLine("December")
            Case Else
                WriteLine("Wrong Input!!")
        End Select
    End Sub
End Module
