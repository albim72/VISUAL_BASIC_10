Module Module1

    Sub Main()
        Dim pr As PierwszaKlasa = New PierwszaKlasa(5, 11)
        Dim dr As DrugaKlasa = New DrugaKlasa(7, 8, 11)
        Dim tr As TrzeciaKlasa = New TrzeciaKlasa(9, 13, 6, 22)

        Console.WriteLine("____ PierwszaKlasa______")
        pr.printAB()
        pr.Oblicz()

        Console.WriteLine("____ DrugaKlasa______")
        dr.printAB()
        dr.printABC()
        Console.WriteLine("wynik funkcji oblicz dla DrugaKlasa = {0}", dr.Oblicz)
        dr.policzSume()

        Console.WriteLine("____ TrzeciaKlasa______")
        tr.printAB()
        tr.printABC()
        tr.printABCD()
        tr.policzSume()
        Console.Write("wynik Oblicz() = {0}", tr.Oblicz)
        Console.ReadKey()


    End Sub

End Module
