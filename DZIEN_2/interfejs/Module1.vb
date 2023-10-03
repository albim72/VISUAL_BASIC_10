Module Module1

    Sub Main()
        Dim ara As IZwierz = New Papuga()
        ara.info()
        ara.odglos()
        Console.WriteLine("Liczba nóg papugi: {0}", ara.liczba_nog)
        Console.WriteLine("kolor papugi: {0}", ara.kolor("czerwony"))
        Console.WriteLine("paapuga żyje w: {0}", ara.warunkibytu("klatce"))

        Console.WriteLine("_____________________________________________")
        Dim buldog As IZwierz = New Pies()
        buldog.info()
        buldog.odglos()
        Console.WriteLine("Liczba nóg psa: {0}", buldog.liczba_nog)
        Console.WriteLine("kolor psa: {0}", buldog.kolor("biały"))
        Console.WriteLine("paapuga żyje w: {0}", buldog.warunkibytu("kojcu"))
        'Console.WriteLine(buldog.wystawa("Zoo Park"))

        Dim terrier As Pies = New Pies()
        Console.WriteLine("_____________________________________________")
        Console.WriteLine(terrier.wystawa("Zoo Park"))

        Console.ReadKey()

    End Sub

End Module
