Imports System.Console
Module Prac07
    Sub Main()
        Dim OS, CPP, DBMS, DS, MALP, total As Integer
        Dim percentage As Decimal
        Dim Name, Enrol As String

        WriteLine("Enter your name:")
        Name = ReadLine()

        WriteLine("Enter your enrollment no:")
        Enrol = ReadLine()

        WriteLine("Enter marks for sub1:")
        OS = CInt(ReadLine())

        WriteLine("Enter marks for sub2:")
        CPP = CInt(ReadLine())

        WriteLine("Enter marks for sub3:")
        DBMS = CInt(ReadLine())

        WriteLine("Enter marks for sub4:")
        DS = CInt(ReadLine())

        WriteLine("Enter marks for sub5:")
        MALP = CInt(ReadLine())

        total = OS + CPP + DBMS + DS + MALP
        WriteLine(total)

        percentage = total / 5
        WriteLine(percentage)

        If percentage > 85 Then
            WriteLine("AA")
        ElseIf percentage >= 75 And percentage <= 85 Then
            WriteLine("AB")
        ElseIf percentage >= 65 And percentage <= 75 Then
            WriteLine("BB")
        ElseIf percentage >= 55 And percentage <= 65 Then
            WriteLine("BC")
        ElseIf percentage >= 45 And percentage <= 55 Then
            WriteLine("CC")
        ElseIf percentage >= 40 And percentage <= 45 Then
            WriteLine("CD")
        ElseIf percentage >= 35 And percentage <= 40 Then
            WriteLine("DD")
        Else
            WriteLine("FF")
        End If
        Read()
    End Sub
End Module
