'Alex Wheelock
'RCET0265
'Multiplication Table
'https://github.com/AlexWheelock/MultiplicationTable.git

Module MultiplicationTable

    Sub Main()
        Dim userInput$
        Dim userNumber As Integer
        Dim valid As Boolean = False

        Console.WriteLine("Please enter the max dimensions of the Multiplication Table you would like to create." & vbNewLine _
                          & "Press " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")

        Do

            valid = False

            Do
                'takes userInput, tries to convert it to integer. If userInput <> integer, then it
                'catches it, checks if q was entered to quit, else repeats loop asking for valid input.
                userInput = Console.ReadLine()
                Try
                    userNumber = CInt(userInput)
                    valid = True
                    Console.WriteLine("You entered " & Chr(34) & $"{userNumber}" & Chr(34))
                Catch ex As Exception
                    If userInput = "q" Then
                        Console.WriteLine("Have a good day!")
                        Console.Read()
                        Exit Sub
                    ElseIf userInput = "Q" Then
                        Console.WriteLine("Have a good day!")
                        Console.Read()
                        Exit Sub
                    Else
                        Console.WriteLine("You entered " & Chr(34) & $"{userInput}" & Chr(34) & ", please enter a valid number.")
                    End If
                End Try
            Loop Until valid

            Console.WriteLine($"Enjoy your {userNumber} x {userNumber} Multiplication Table:")

            'Goes to Sub MakeATable with user number as the dimensions for the table.
            MakeATable(userNumber)

            Console.WriteLine()
            Console.WriteLine("Please enter another number, or press " & Chr(34) & "Q" & Chr(34) & " to quit.")

        Loop
        Console.Read()
    End Sub

    Sub MakeATable(dimensions As Integer)
        Dim temp$

        'Writes out the numbers of each row to the length of the dimensions variable.
        'Does the same thing for columns, but multiplies the row value by the column value.
        'Writes it all as the temp string variable and then writes out that variable.
        For row = 1 To dimensions
            For columns = 1 To dimensions
                temp$ = (row * columns)
                Console.Write(temp$.PadLeft(5))
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
