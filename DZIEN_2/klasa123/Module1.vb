Module Module1

    Sub Main()
        Dim pr As PierwszaKlasa = New PierwszaKlasa(5, 11)
        Dim dr As DrugaKlasa = New DrugaKlasa(7, 8, 11)

        Console.WriteLine("____ PierwszaKlasa______")
        pr.printAB()
        pr.Oblicz()

        Console.WriteLine("____ DrugaKlasa______")
        dr.printAB()
        dr.printABC()
        Console.WriteLine("wynik funkcji oblicz dla DrugaKlasa = {0}", dr.Oblicz)
        dr.policzSume()
    End Sub

End Module
