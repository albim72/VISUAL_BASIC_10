Module Module1

    Function mnozenie(a, b, c)
        mnozenie = a * b * c

    End Function

    Function dodawanie(a, b, c)
        Dim d = a + b + c
        Return d

    End Function

    Function info()
        Dim informacja = "to jest wynik działania funkcji info()"
        Console.WriteLine(informacja)
    End Function

    Sub Main()
        Dim x As Integer
        x = mnozenie(2, 67, 5)
        Dim i As String
        i = info()

        MsgBox("wynik działania funkcji mnozenie: " & x)
        MsgBox("wynik działania funkcji mnozenie: " & mnozenie(3, 3, 3))

        Console.WriteLine(i)
        Console.WriteLine(info())
        info()

        Console.WriteLine("Wynik dodawanie = " & dodawanie(1, 3, 5))

        Console.ReadKey()



    End Sub

End Module
