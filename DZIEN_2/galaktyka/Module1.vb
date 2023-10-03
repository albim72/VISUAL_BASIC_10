Imports System.Security.Cryptography.X509Certificates

Module Module1


    Sub showgala(gala)
        With gala
            Console.WriteLine("Nazwa galaktyki: {0}, odlgłość [mln lat swietlnych] = {1}",
                               .Name, .MegaLightYears)
            If .Name = "Andromeda" Then
                Console.WriteLine("Andromeda to galaktyka najbliższa Ziemi")
            End If
        End With
    End Sub

    Function funcgala(gala)
        With gala
            Console.WriteLine("Nazwa galaktyki: {0}, odlgłość [mln lat swietlnych] = {1}",
                               .Name, .MegaLightYears)
            If .Name = "Andromeda" Then
                Console.WriteLine("Andromeda to galaktyka najbliższa Ziemi")
            End If
        End With
    End Function
    Sub Main()
        Dim galaktyki As New List(Of Galaxy) From
            {
            New Galaxy With {.Name = "Kijanka", .MegaLightYears = 400},
            New Galaxy With {.Name = "Wiatraczek", .MegaLightYears = 25},
            New Galaxy With {.Name = "Droga Mleczna", .MegaLightYears = 0},
            New Galaxy With {.Name = "Andromeda", .MegaLightYears = 3}
        }

        For Each gala In galaktyki
            With gala
                Console.WriteLine("Nazwa galaktyki: {0}, odlgłość [mln lat swietlnych] = {1}",
                                   .Name, .MegaLightYears)
                If .Name = "Andromeda" Then
                    Console.WriteLine("Andromeda to galaktyka najbliższa Ziemi")
                End If
            End With
        Next

        Console.WriteLine("___________________________________")
        galaktyki.ForEach(Sub(gala) showgala(gala))

        Console.WriteLine("___________________________________")
        galaktyki.ForEach(Sub(gala) funcgala(gala))

        Console.ReadKey()


    End Sub

End Module
