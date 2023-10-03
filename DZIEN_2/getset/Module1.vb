Module Module1

    Sub Main()
        Dim miasto As Miasto = New Miasto("Lublin", "lubelskie", True, 500000)

        Console.WriteLine(miasto.getLiczba)

        miasto.setLiczba(5300000)

        Console.WriteLine(miasto.getLiczba)
        Console.ReadKey()


    End Sub

End Module
