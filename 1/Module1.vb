Module Module1

    Sub Main()
        Dim x, y, temp As Integer

        Console.Write("Enter the first positive integer number: ")
        x = Integer.Parse(Console.ReadLine())
        While x < 0
            Console.WriteLine("You must enter a positive integer number!")
            Console.Write("Enter the first positive integer number: ")
            x = Console.ReadLine()
        End While
        Console.Write("Enter the second positive integer number: ")
        y = Integer.Parse(Console.ReadLine())
        While y < 0
            Console.WriteLine("You must enter a positive integer number!")
            Console.Write("Enter the second positive integer number: ")
            y = Console.ReadLine()
        End While
        temp = 0

        For n = 1 To y Step 1
            temp += x
        Next

        Console.WriteLine("{0} x {1} = {2}", x, y, temp)
        Console.ReadKey()
    End Sub

End Module
