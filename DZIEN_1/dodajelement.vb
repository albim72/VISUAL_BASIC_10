Module Module1

    Function AddElement(ParamArray arr As Integer())
        Dim suma As Integer = 0
        Dim i As Integer = 0

        For Each i In arr
            suma += i
        Next i
        Return suma
    End Function

    Sub Main()
        Dim s As Integer
        s = AddElement(566, 1, 24, 1001, 233, -400, 2, 6)
        Console.WriteLine("suma zadanych wartości: {0}", s)
        Dim imie = "Tomek"
        Dim wiek = 33
        Console.WriteLine("osoba {0}, wiek {1} lat", imie, wiek)
        Console.ReadLine()


    End Sub

End Module
