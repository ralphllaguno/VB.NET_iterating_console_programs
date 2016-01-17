Module Module1

    Sub Main()
        Dim input, total As Integer
        total = 1

        Console.Write("Enter a positive integer number: ")
        input = Integer.Parse(Console.ReadLine())

        For start = 1 To input Step 1
            total *= start
        Next
        Console.Write("{0}! = {1}", input, total)
        Console.ReadKey()
    End Sub

End Module
