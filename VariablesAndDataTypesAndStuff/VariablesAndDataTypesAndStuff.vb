Option Explicit On
'Alexis Villagran 
'Spring 2025
'RCET 2265
'Variables, Data Types, & stuff
'https://github.com/alxsvxn/VariablesAndDataTypesAndStuff.git

Imports System.Security.Authentication


'Option Strict on
Module VariablesAndDataTypesAndStuff

    Sub Main()

        Dim jellyBeans As Integer
        Dim laffyTaffy As Integer
        Dim money As Decimal
        Dim studentName As String

        Console.WriteLine(jellyBeans) 'ConsoleWrite will display the value of "jellyBeans" which is 0

        jellyBeans = 120 'This will assign an integer value to our jellyBeans variable of 120
        Console.WriteLine(jellyBeans) 'Now will display the new value of jellybeans which is 120

        jellyBeans = jellyBeans + 10 'Will add current integer value jellybeans(120) + 10 then assign new value of the sum(130
        Console.WriteLine(jellyBeans) 'Will display the integer value of jellybeans(130)

        jellyBeans += 10 'This is the same action as line 20 but shorthand, new integer value will be 140
        Console.WriteLine(jellyBeans) 'Will display value of jellyBeans(140)

        laffyTaffy = 26 'If we don't assign laffyTaffy as an integer (Line 13) this line of code won't work
        Console.WriteLine(laffyTaffy)

        money = 9.1283726802986 'floating point number
        jellyBeans = CInt(1.56)
        studentName = "7" 'At first we had "jimmothy" in between the quotations but that crashed the program because 'jimmothy' cannot be converted

        'jellyBeans = CInt(studentName) 'If we remove the apostr. it will override our integer value of 1.56(2) to 7 because we are overriding it here

        Console.WriteLine()
    End Sub

End Module