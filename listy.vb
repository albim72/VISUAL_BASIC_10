Module Module1

    Sub Main()
        Dim kolory As New List(Of String)

        kolory.Add("czerwony")
        kolory.Add("zielony")
        kolory.Add("biały")
        kolory.Add("czarny")
        kolory.Add("żółty")

        For Each kol In kolory
            Console.Write(kol & "  ")

        Next

        Dim paleta As New List(Of String) From
            {"lemoniadowy", "cytrynowy", "guma do żucia", "coca-cola", "magiczny"}
        Console.WriteLine()
        Console.WriteLine("___________________________________")
        For Each nkol In paleta
            Console.Write(nkol & "  ")
        Next
        Console.WriteLine()
        Console.WriteLine("___________________________________")

        Console.WriteLine(paleta(3))

        Console.WriteLine("___________________________________")

        For index = 0 To paleta.Count - 1
            Console.Write(paleta(index) & "  ")
        Next

        Console.ReadKey()

    End Sub

End Module
