Imports System

Module Program
    Sub Main(args As String())
        Dim Avtor As String
        Dim name As String
        Dim namber As String
        Dim ves As String

        Console.WriteLine("Введите 5 книг:")
        For i = 0 To 5
            Avtor = Console.WriteLine()
            name = Console.WriteLine()
            namber = Console.WriteLine()
            ves = Console.WriteLine()

            Dim Inp(5) As String
            For i = 0 To Inp.Length - 1
                Inp(i) = Console.ReadLine(Avtor, name, namber, ves)
            Next
            Print(Inp)

            Console.WriteLine(""{0}"- {1}, {2}, {3}", Avtor, name, namber, ves)
        Next



    '    Dim Inp(5) As String
    '    For i = 0 To Inp.Length - 1
    '        Inp(i) = Console.ReadLine(Avtor, name, namber, ves)
    '    Next
    '    Print(Inp)

    'End Sub

    Sub Print(List As String())
        For i = 0 To List.Length - 1
            Console.WriteLine(List(i))
        Next
    End Sub

End Module
