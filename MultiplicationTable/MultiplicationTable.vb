'Alex Wheelock
'RCET0265
'Multiplication Table
'https://github.com/AlexWheelock/MultiplicationTable.git

Module MultiplicationTable

    Sub Main()
        Dim userInput$
        Dim userNumber As Integer
        Dim valid As Boolean = False

        Do
            Console.WriteLine("Please enter a number. Press Q at any time to quit.")
            valid = False
            Do
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
                        Console.WriteLine("You entered " & Chr(34) & $"{userNumber}" & Chr(34) & ", please enter a valid number.")
                    End If
                End Try
            Loop Until valid

            MakeATable(userNumber)

        Loop
        Console.Read()
    End Sub

    Sub MakeATable(dimensions As Integer)
        Dim temp$
        Console.Clear()

        For row = 1 To dimensions
            For columns = 1 To dimensions
                temp$ = (row * columns)
                Console.Write(temp$.PadLeft(5))
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
