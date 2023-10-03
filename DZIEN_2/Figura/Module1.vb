Module Module1

    Sub Main()
        'Dim fg As Figury = New Figury()
        'Nie Wolno tworzyć obiektu na podstawie klasy abstrakcyjnej!!!

        Dim pr As Prostokat = New Prostokat(5.5, 7.1)
        Dim s1 = "FIGURA PROSTOKĄT"
        pr.Info(s1)
        Console.WriteLine("pole wynosi = {0}", pr.policzPole)

        Console.ReadKey()


    End Sub

End Module
