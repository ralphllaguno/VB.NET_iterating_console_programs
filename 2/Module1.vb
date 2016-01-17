Module Module1

    Sub Main()
        Dim x, y, n, a, b, temp As Integer

        Console.Write("Enter the first integer number: ")
        x = Integer.Parse(Console.ReadLine())
        Console.Write("Enter the second integer number: ")
        y = Integer.Parse(Console.ReadLine())

        temp = 0
        a = x
        b = y
        If x < 0 And y > 0 Or x > 0 And y < 0 Then
            x = Math.Abs(x)
            y = Math.Abs(y)
            For n = 1 To y Step 1
                temp += x
            Next
            temp *= -1

        ElseIf x < 0 And y < 0
            x = Math.Abs(x)
            y = Math.Abs(y)
            For n = 1 To y Step 1
                temp += x
            Next
        Else
            For n = 1 To y Step 1
                temp += x
            Next
        End If
        Console.WriteLine("{0} x {1} = {2}", a, b, temp)
        Console.ReadKey()
    End Sub

End Module
