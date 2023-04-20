Imports System.Buffers

Module ProgramM1
    Enum SortTipe
        Ascending
        Descending
    End Enum
    Sub Main(args As String())

        'Console.WriteLine("Введите 5 чисел:")
        'Dim Inp(4) As Integer
        'For i = 0 To Inp.Length - 1
        '    Inp(i) = Console.ReadLine()
        'Next
        'Console.WriteLine("Какое число искать?")
        'Dim num As Integer = Console.ReadLine()
        'Console.WriteLine(find(Inp, num))

        Console.WriteLine("Введите 5 слов:")
        Dim Str(4) As String
        For i = 0 To Str.Length - 1
            Str(i) = Console.ReadLine()
        Next
        'Console.WriteLine("Какое слово искать?")
        'Dim word As String = Console.ReadLine()
        'Console.WriteLine(findStr(Str, word))

        'Print(Inp)
        'Print(Str)
        'Dim n As Integer = Max1(Inp)
        'Console.WriteLine("Max({0})={1}", n, Inp(n))

        'Dim m As Integer = Min1(Inp)
        'Console.WriteLine("Min({0})={1}", m, Inp(m))

        '    m = Min1(Str, 1)
        'If m > 1 Then

        '    Dim d As String = Str(1)
        '    Str(1) = Str(m)
        '    Str(m) = d
        'End If

        'Console.WriteLine("Min({0})={1}", m, Str(m))

        'Add(Inp, 999, 2)
        'Print(Inp)

        'Delete(Str, 0)
        'Delete(Str, 1)

        'Dessort(Str)
        Bubblesort(Str)
        Print(Str)

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
    End Function
    Function Min1(List As Integer(), Start As Integer) As Integer
        Min1 = 0
        For i = Start To List.Length - 1
            If List(i) < List(Min1) Then
                Min1 = i
            End If
        Next
    End Function
    Function Min1(List As String(), Optional Start As Integer = 0) As Integer
        Min1 = Start
        For i = Start + 1 To List.Length - 1
            If List(i) < List(Min1) Then
                Min1 = i
            End If
        Next
    End Function

    Sub Add(ByRef List As Integer(), value As Integer, index As Integer)
        If index < 0 Or index > List.Length Then Exit Sub
        ReDim Preserve List(List.Length)
        For i = List.Length - 1 To index + 1 Step -1
            List(i) = List(i - 1)
        Next
        List(index) = value
    End Sub

    Sub Delete(ByRef List As Integer(), index As Integer)
        If index < 0 Or index > List.Length Then Exit Sub
        For i = index To List.Length - 1
            List(index) = 0
            List(i) = List(index + i)
        Next
        ReDim Preserve List(List.Length - 2)
    End Sub

    Sub Delete(ByRef List As String(), index As Integer)
        If index < 0 Or index > List.Length - 1 Then Exit Sub
        For i = index To List.Length - 2
            List(i) = List(i + 1)
        Next
        ReDim Preserve List(List.Length - 2)
    End Sub

    Sub Dessort(List As String())
        For Start = 0 To List.Length - 2
            Dim m As Integer = Min1(List, Start)
            If m > Start Then
                Dim d As String = List(Start)
                List(Start) = List(m)
                List(m) = d
            End If
        Next
    End Sub

    Sub Bubblesort(List As String(), Optional Dir As SortTipe = SortTipe.Ascending)
        Dim Buf As String
        For j = 0 To List.Length - 2
            For i = 0 To List.Length - 2 - j
                If List(i) > List(i + 1) Then
                    Buf = List(i)
                    List(i) = List(i + 1)
                    List(i + 1) = Buf
                End If
            Next
        Next
    End Sub





End Module






