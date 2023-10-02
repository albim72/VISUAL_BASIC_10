Module Module1

    Sub Main()
        Dim osoba1 As Osoba = New Osoba("Jan", "Kot", 34, "dyrektor", 189, 88)
        Dim osoba2 As Osoba = New Osoba("Anna", "Kowal", 22, "sekretarka", 165, 54)

        osoba1.printOsoba()
        osoba2.printOsoba()
        osoba1.koloroczu = "niebieskie"
        Console.WriteLine(osoba1.koloroczu)
        Console.WriteLine(osoba2.koloroczu)

        Console.ReadKey()



    End Sub

End Module
