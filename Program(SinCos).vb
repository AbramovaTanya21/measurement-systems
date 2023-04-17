Imports System
Imports System.Data

Module Program
    Sub Main(args As String())

        Dim a As Single = 1.5
        Dim b As Single = 0.7
        Dim c As Integer = 2

        Dim x As Single = (Math.Exp(a) - Math.Cos(b)) / Math.Sqrt(a * b * c)
        Console.WriteLine(x)

        Dim y As Single = Math.Log(a) - b * c
        Console.WriteLine(y)

        Dim z As Single = Math.Sin(x * y) - 2
        Console.WriteLine(z)
    End Sub
End Module
