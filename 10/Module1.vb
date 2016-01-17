Module Module1

    Sub Main()
        Dim input, total As Integer

        Console.Write("Enter a number: ")
        input = Integer.Parse(Console.ReadLine())

        For start = 1 To input Step 1
            total += Math.Pow(start, start)
            If start < input Then
                Console.Write("{0}^{0} + ", start)
            Else
                Console.Write("{0}^{0} = ", start)
            End If
        Next

        Console.Write("{0}", total)

        Console.ReadKey()

    End Sub

End Module
