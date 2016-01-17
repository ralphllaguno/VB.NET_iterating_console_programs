Module Module1

    Sub Main()
        Dim input, past, present, future, temp As Integer

        Console.Write("Enter a positive integer number: ")
        input = Integer.Parse(Console.ReadLine())
        past = 1
        present = 1
        Console.Write("1 1 ")

        For temp = 1 To input - 2 Step 1
            future = past + present
            past = future
            present = past
            Console.Write("{0} ", future)
        Next
        Console.ReadKey()
    End Sub

End Module
