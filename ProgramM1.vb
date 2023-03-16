Imports System

Module ProgramM1
    Sub Main(args As String())

        Console.WriteLine("Введите 5 чисел:")
        Dim Inp(4) As Integer

        For i = 0 To 4
            Inp(i) = Console.ReadLine()
        Next


        Console.WriteLine("Какое число искать?")
        Dim num As Integer = Console.ReadLine()
        find(Inp, num)
        'Console.WriteLine(Inp(0))

        'Dim Str(4) As Integer
        'For i = 0 To 4
        '    Str(i) = Console.ReadLine()
        'Next
        'Console.WriteLine(Str(0))

        'Print(Inp)
        'Print(Str)

    End Sub
    Sub BackPrint(List As Integer())
        For i = List.Length - 1 To 0 Step -1
            Console.WriteLine(List(i))
        Next
    End Sub
    Sub BackPrint(List As String())
        For i = List.Length - 1 To 0 Step -1
            Console.WriteLine(List(i))
        Next
    End Sub

    Sub Print(List As Integer())
        For i = 0 To List.Length - 1
            Console.WriteLine(List(i))
        Next
    End Sub
    Sub Print(List As String())
        For i = 0 To List.Length - 1
            Console.WriteLine(List(i))
        Next
    End Sub
    Function find(List As Integer(), num As Integer) As Integer
        For i = 0 To List.Length - 1
            If List(i) = num Then
                find = 1
                'Console.WriteLine("{0} элемент = 21", i)
                Exit Function
            End If
        Next
        find = -1
    End Function




End Module
