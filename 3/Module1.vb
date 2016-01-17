Module Module1

    Sub Main()
        Dim x, y, a, b, c, temp As Integer

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

        a = 0
        temp = y + 1
        c = x

        If y = 0 Then
            Console.WriteLine("{0} / {1} = undetermined ", c, y)
        ElseIf x = 0 Then
            Console.WriteLine("{0} / {1} = 0 r. 0 ", c, y)

        ElseIf y > x Then
            Console.WriteLine("{0} / {1} = 0 r. {2}", c, y, y)

        Else
            While temp >= y
                temp = x - y
                a += 1
                x = temp
                If temp = 0 Then
                    b = 0
                Else
                    b = temp
                End If
            End While
            Console.WriteLine("{0} / {1} = {2} r. {3}", c, y, a, b)

        End If

        Console.ReadKey()


    End Sub

End Module
