Module Module1

    Sub Main()
        'Dim miasto As String
        Dim miasta(5) As String

        miasta(0) = "Londyn"
        miasta(1) = "Warszawa"
        miasta(2) = "Paryż"
        miasta(3) = "Rzym"
        miasta(4) = "Oslo"
        miasta(5) = "Sofia"

        Console.WriteLine(miasta)


        For Each miasto In miasta
            Console.WriteLine(miasto)
        Next

        ReDim Preserve miasta(16)
        miasta(6) = "Toruń"
        miasta(7) = "Lublin"

        For j = 4 To 7
            Console.WriteLine(miasta(j))
        Next

        Console.WriteLine("__________________________________________")

        Dim citynumS As String
        Dim citynum As Long
        Dim cities() As String


        citynumS = InputBox("ile miast chcesz wpisać? ")
        citynum = citynumS

        ReDim cities(citynum)
        For i = 0 To citynum - 1
            cities(i) = InputBox("podaj nazwę miasta: ")
        Next
        Console.WriteLine("__________________________________________")
        For Each ct In cities
            Console.WriteLine(ct)
        Next



        Console.ReadKey()


    End Sub

End Module
