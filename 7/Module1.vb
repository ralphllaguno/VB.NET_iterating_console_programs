Module Module1

    Sub Main()
        Dim input, count As Integer

        Console.Write("Enter a number: ")
        input = Integer.Parse(Console.ReadLine())

        For a = 1 To input - 1 Step 1
            If input Mod a = 0 Then
                count += a
            End If
        Next

        If count = input Or input = 1 Then
            Console.WriteLine("{0} is perfect", input)
        Else
            Console.WriteLine("{0} is not perfect", input)
        End If

        Console.ReadKey()
    End Sub

End Module
