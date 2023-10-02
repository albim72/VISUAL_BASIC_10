Module Module1

    Sub Prosta(x As Integer)
        Dim y As Integer = 2 * x + 3
        Console.WriteLine(y)

    End Sub

    Function wynik(x, y)
        wynik = x + 2 * y
        Console.WriteLine(wynik)

    End Function

    Function osoba(imie, nazwisko)
        Dim ucz = "Uczestnik konferencji: " & imie & " " & nazwisko
        Prosta(6)
        wynik(2, 3)
        Return ucz
    End Function

    Sub Informacja()
        Console.WriteLine("To jest ważna informacja!")
        Console.WriteLine("Konferencja AI - " & osoba("Jan", "Kowalski"))

    End Sub

    Sub Main()
        Informacja()
        Console.ReadKey()

    End Sub

End Module
