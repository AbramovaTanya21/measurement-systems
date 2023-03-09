Imports System

Module Program
    Sub Main(args As String())

        Dim cek As Integer

        Console.WriteLine("Привет, эты программа может перевести время из секуд в минуты и часы.Хочешь попробывать? Введите время в секундах: ")
        cek = Console.ReadLine()

        Console.WriteLine("{0} секунд = время - {1}:{2}:{3}", cek, cek \ 3600, (cek Mod 3600) \ 60, cek Mod 60)

    End Sub
End Module
