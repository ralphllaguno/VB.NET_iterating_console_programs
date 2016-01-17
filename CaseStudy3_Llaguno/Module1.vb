Module Module1

    Sub Main()
        Dim opt As Integer

        Console.Write("Enter the number corresponding to the problem: ")
        opt = Integer.Parse(Console.ReadLine())

        Select Case opt
            Case 1
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
            Case 2
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

            Case 3
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

            Case 4
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
            Case 5
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
            Case 6
                Dim input, total As Integer
                total = 1

                Console.Write("Enter a positive integer number: ")
                input = Integer.Parse(Console.ReadLine())

                For start = 1 To input Step 1
                    total *= start
                Next
                Console.Write("{0}! = {1}", input, total)
                Console.ReadKey()
            Case 7
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
            Case 8
                Dim input, total As Integer

                Console.WriteLine("Enter a number: ")
                input = Integer.Parse(Console.ReadLine())

                For start = 1 To input Step 1
                    total += start
                    If start < input Then
                        Console.Write(" {0} + ", start)
                    Else
                        Console.Write(" {0} ", start)
                    End If
                Next

                Console.WriteLine(" = {0}", total)
            Case 9
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
            Case 10
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
            Case 11
            Case 12
            Case 13
            Case 14
            Case 15
            Case 16
            Case 17
            Case 18
            Case 19
            Case 20

        End Select
        Console.ReadKey()

    End Sub

End Module
