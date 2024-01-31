'Alex Wheelock
'RCET0265
'Multiplication Table
'https://github.com/AlexWheelock/MultiplicationTable.git

Module MultiplicationTable

    Sub Main()
        Dim numbers(20, 20) As Integer
        Dim temp As String
        Dim userInput As String
        Dim userNumber As Integer
        Dim validInput As Boolean


        Console.WriteLine("Please enter the max value of the the table that you would like it to go to." & vbNewLine _
                          & "Press " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")
        Do
            validInput = False

            'takes userInput, and tries to convert it to an integer
            'Loops until there is a valid input containing an integer
            Do
                userInput = Console.ReadLine()
                Try
                    userNumber = CInt(userInput)
                    validInput = True
                    Console.WriteLine($"Enjoy your {userNumber} x {userNumber} Multiplication Table:")
                Catch ex As Exception
                    If userInput = "q" Then
                        Console.Write("Have a nice day!")
                        Console.Read()
                        Exit Sub
                    ElseIf userInput = "Q" Then
                        Console.Write("Have a nice day!")
                        Console.Read()
                        Exit Sub
                    Else Console.WriteLine("You entered " & Chr(34) & $"{userInput}" & Chr(34) & ", please enter an integer.")
                    End If
                End Try
            Loop Until validInput


            For row = 1 To userNumber
                For column = 1 To userNumber
                    numbers(row, column) = row * column
                Next
            Next

            For row = 1 To userNumber
                For column = 1 To userNumber
                    temp = CStr(numbers(row, column))
                    Console.Write(temp.PadLeft(6))
                Next
            Next

            Console.WriteLine()
            Console.WriteLine("Please enter another max value to create another table, or press " & Chr(34) & "Q" & Chr(34) & " to quit.")
        Loop
    End Sub

End Module
