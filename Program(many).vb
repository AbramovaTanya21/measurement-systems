Imports System
Imports System.Net.NetworkInformation

Module Program
    Sub Main(args As String())
        Dim dec As Decimal
        Dim dbl As Double
        Dim sng As Single
        Dim rub As Integer
        Dim kop As Integer
        Dim Input As Integer

        dec = 0.000000000023
        dbl = 0.000000000023
        sng = 0.000000000023

        'Console.WriteLine(dec)
        'Console.WriteLine(dbl)
        'Console.WriteLine(sng)

        Console.Write("Введиту сумму в копейках: ")
        Input = Console.ReadLine()
        sng = Input / 100
        rub = Input / 100
        kop = Input Mod 100

        Console.WriteLine("{0} копеек = {1} рублей", Input, sng)
        Console.WriteLine("{0} копеек = {1} рублей {2} копеек", Input, rub, kop)
    End Sub
End Module
