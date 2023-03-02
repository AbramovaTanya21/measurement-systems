Imports System

Module Program
    Sub Main(args As String())

        Dim cek As Integer

        Dim hour As Integer
        Dim min As Integer

        Dim cek1 As Integer
        Dim min1 As Integer

        Console.WriteLine("Привет, эты программа может перевести время из секуд в минуты и часы.Хочешь попробывать? Введите время в секундах: ")
        cek = Console.ReadLine()

        hour = cek / 3600
        min1 = cek / 60

        cek1 = cek Mod 60
        min = min1 Mod 60

        Console.WriteLine("{0} секунд = время - {1}:{2}:{3}", cek, hour, min, cek1)

    End Sub
End Module
