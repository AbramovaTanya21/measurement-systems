﻿Imports System

Module ProgramM1
    Sub Main(args As String())

        Console.WriteLine("Введите 5 чисел:")
        Dim Inp(4) As Integer
        For i = 0 To 4
            Inp(i) = Console.ReadLine()
        Next
        Console.WriteLine("Какое число искать?")
        Dim num As Integer = Console.ReadLine()
        Console.WriteLine(find(Inp, num))

        'Console.WriteLine("Введите 5 слов:")
        'Dim Str(4) As String
        'For i = 0 To 4
        '    Str(i) = Console.ReadLine()
        'Next
        'Console.WriteLine("Какое слово искать?")
        'Dim word As String = Console.ReadLine()
        'Console.WriteLine(findStr(Str, word))

        'Print(Inp)
        'Print(Str)
        Dim n As Integer = Max1(Inp)
        Console.WriteLine("inp({0})={1}", n, Inp(n))

        Dim Min1 As Integer = Inp(0)
        For i = 0 To Inp.Length - 1
            If Inp(i) < Min1 Then
                Min1 = Inp(i)
            End If
        Next
        Console.WriteLine("{0}-минимальное значение", Min1)
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
                find = i
                Exit Function
            End If
        Next
        find = -1
    End Function
    Function findStr(List As String(), num As String) As String
        For i = 0 To List.Length - 1
            If List(i) = num Then
                findStr = i + 1
                Exit Function
            End If
        Next
        findStr = -1
    End Function
    Function Max1(List As Integer()) As Integer

        Max1 = 0
        For i = 0 To List.Length - 1
            If List(i) > List(Max1) Then
                Max1 = i
            End If
        Next
        Console.WriteLine("{0}-максимальное значение", Max1)
    End Function
End Module
