Module Module1

    Sub Main()
        Dim osoba1 As Osoba = New Osoba("Jan", "Kot", 34, "dyrektor", 189, 88)
        Dim osoba2 As Osoba = New Osoba("Anna", "Kowal", 22, "sekretarka", 165, 54)

        osoba1.printOsoba()
        osoba2.printOsoba()
        osoba1.koloroczu = "niebieskie"
        Console.WriteLine(osoba1.koloroczu)
        Console.WriteLine(osoba2.koloroczu)


        Dim stud As Student = New Student("Olga", "Nowak", 22, "praktykantka",
                                          168, 56, "HG345435345", "Ekonomia", True)

        stud.printOsoba()
        Console.WriteLine(stud.koloroczu)
        stud.printStudent()


        Console.ReadKey()



    End Sub

End Module
