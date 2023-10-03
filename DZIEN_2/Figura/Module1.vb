Module Module1

    Sub Main()
        'Dim fg As Figury = New Figury()
        'Nie Wolno tworzyć obiektu na podstawie klasy abstrakcyjnej!!!

        Dim pr As Prostokat = New Prostokat(5.5, 7.1)
        Dim s1 = "FIGURA PROSTOKĄT"
        pr.Info(s1)
        Console.WriteLine("pole wynosi = {0}", pr.policzPole)


        Dim tr As Trojkat = New Trojkat(6, 8.8)
        Dim s2 = "FIGURA TRÓJKĄT"
        pr.Info(s2)
        Console.WriteLine("pole wynosi = {0}", tr.policzPole)

        tr = New Trojkat(111, 333)
        Dim s44 = "FIGURA TRÓJKĄT"
        pr.Info(s44)
        Console.WriteLine("pole wynosi = {0}", tr.policzPole)

        Dim trp As Trapez = New Trapez(6.6, 7.2, 4.8)
        Dim s3 = "FIGURA TRAPEZ"
        pr.Info(s3)
        Console.WriteLine("pole wynosi = {0}", trp.policzPole)

        Console.ReadKey()




    End Sub

End Module
