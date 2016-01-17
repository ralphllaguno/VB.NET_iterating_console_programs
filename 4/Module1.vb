Module Module1

    Sub Main()
        Dim start, final, counter, a, b As Integer
        Dim primeChecker As Boolean

        Console.WriteLine("Enter the range of the numbers to process (start - end):")
        Console.Write("Enter the start number of the range: ")
        start = Integer.Parse(Console.ReadLine())
        Console.Write("Enter the end number of the range: ")
        final = Integer.Parse(Console.ReadLine())

        counter = 0
        primeChecker = True
        For a = start To final Step 1
            For b = start To final Step 1
                If a <> b And a Mod b = 0 Then
                    primeChecker = False
                End If
            Next
            If primeChecker Then
                Console.WriteLine(a)
            End If
            primeChecker = True
        Next
        Console.ReadKey()
    End Sub

End Module
