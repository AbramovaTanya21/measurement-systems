Imports System

Module Program
    Sub Main(args As String())

        Console.Write("Хотите перевести число из см. в дц. или м.? Введите число в см: ")
        Dim cm As Integer = Console.ReadLine()

        'Console.WriteLine("{0}см => {1}м {2}см", cm, cm \ 100, cm Mod 100)
        'Console.WriteLine("{0}см => {1}дм {2}см ", cm, cm \ 10, cm Mod 10)
        'Console.WriteLine("{0}см => {1}м {2}дм {3}см", cm, cm \ 100, (cm Mod 100) \ 10, cm Mod 10)

        Console.WriteLine("{0}см => {1}м {4}см => {5}дм {3}см => {1}м {2}дм {3}см", cm, cm \ 100, (cm Mod 100) \ 10, cm Mod 10, cm Mod 100, cm \ 10)

    End Sub
End Module
