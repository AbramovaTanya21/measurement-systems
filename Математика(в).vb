Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Таблица значений для у")
        For x = 2 To 8 Step 0.5
            Console.WriteLine("y({0})={1}", x, y(z(x), x))
        Next
    End Sub
    Function z(x As Double) As Double
        z = Math.Cos(3 * Math.Pow(x, 2) - x + 1)
    End Function

    Function y(z As Double, x As Double) As Double
        If z > 0 Then
            y = Math.Sqrt(x) + z
        End If
        If z <= 0 Then
            y = Math.Exp(x) - Math.Log(x)
        End If
    End Function


End Module
