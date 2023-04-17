Imports System

Module Program
    Sub Main(args As String())

        Dim n As Decimal = 2.2
        Dim m As Decimal = -5.3

        Dim y As Decimal
        Dim z As Decimal

        Console.WriteLine("Task 1")

        If n > 2 Then
            y = n * Math.Log(n)
            Console.WriteLine(y)
        Else
            y = Math.Pow(n, 2)
            Console.WriteLine(y)
        End If
        z = 2 * Math.Pow(Math.Sin(Math.Pow(y, 3)), 2) - Math.Log(Math.Abs(y))
        Console.WriteLine(z)

        Console.WriteLine("Task 2")

        If m > 2 Then
            y = m * Math.Log(m)
            Console.WriteLine(y)
        Else
            y = Math.Pow(m, 2)
            Console.WriteLine(y)
        End If
        z = 2 * Math.Pow(Math.Sin(Math.Pow(y, 3)), 2) - Math.Log(Math.Abs(y))
        Console.WriteLine(z)

    End Sub
End Module
