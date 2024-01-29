'Alex Wheelock
'RCET0265
'Multiplication Table
'https://github.com/AlexWheelock/MultiplicationTable.git

Module MultiplicationTable

    Sub Main()
        Dim userInput As String
        Dim usernumber As Integer
        Dim boolean1 As Boolean = False

        Dim numbers(9, 9) As Integer
        Dim value As String

        Console.WriteLine("What would you like the dimensions of the table to be?")
        userInput = Console.ReadLine()

        Do
            Try
                usernumber = CInt(userInput)
                boolean1 = True
            Catch ex As Exception
                Console.WriteLine("Please enter an integer.")
            End Try
        Loop Until Boolean1 = True

        For row = 0 To usernumber
            For column = 0 To usernumber
                numbers(row, column) = row * column
            Next
        Next

        For row = 0 To usernumber
            For column = 0 To 9
                value = CStr(numbers(row, column)) & " |"
                Console.Write(value.PadLeft(6))
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub

End Module
