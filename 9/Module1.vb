Module Module1

    Sub Main()
        Dim input, total As Integer

        Console.Write("Enter a number: ")
        input = Integer.Parse(Console.ReadLine())

        For start = 1 To input Step 1
            total += start * start
            If start < input Then
                Console.Write(" {0}^2 + ", start)
            Else
                Console.Write(" {0}^2 ", start)
            End If
        Next

        Console.Write(" = {0}", total)

        Console.ReadKey()

    End Sub

End Module
