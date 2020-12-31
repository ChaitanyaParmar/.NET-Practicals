Imports System.Console
Module Prac09
    Sub main()
        Dim n As Integer
        WriteLine("Enter your salary:")
        n = CInt(ReadLine())

        Select Case n
            Case 5000 To 15000
                n += n * 0.15
                WriteLine("Salary = {0}", n)
            Case 15001 To 25000
                n += n * 0.1
                WriteLine("Salary = {0}", n)
            Case 25001 To 35000
                n += n * 0.05
                WriteLine("Salary = {0}", n)
            Case 40000, 42000, 44000
                n += n * 0.07
                WriteLine("Salary = {0}", n)
            Case Is > 35000
                n += n * 0.03
                WriteLine("Salary = {0}", n)
            Case Else
                WriteLine("Wrong Salary Input...")
        End Select
    End Sub
End Module
