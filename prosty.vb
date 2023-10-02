Module Module1

    Sub Main()
        Console.WriteLine("To jest pierwsza aplikacja")
        Console.WriteLine("Druga linia...")


        Dim imie = "Ryszard"
        Dim nazwisko As String = "Kot"
        Dim wiek = 45
        Dim latapracy As Integer = 5

        'MsgBox(VarType(imie))
        'MsgBox(VarType(nazwisko))
        'MsgBox(VarType(wiek))
        'MsgBox(VarType(latapracy))

        'komentowanie linii - bloku CTRL+K, CTRL+C
        'odkomentowanie CTRL+K, CTRL+U

        'wiek = 55.5
        'MsgBox(VarType(wiek))
        'MsgBox(3 * wiek)

        Dim cena = 12.99

        'MsgBox(VarType(cena))
        'MsgBox(3 * cena)

        'MsgBox(IsNumeric(wiek))
        'MsgBox(IsNumeric(cena))

        If wiek = 45 Then
            Console.WriteLine("Osoba w wieku 45 lat")
        Else
            Console.WriteLine("Osoba w wieku innym niż 45 lat!")

        End If

        Console.WriteLine("_____________________________")
        If imie = "Jan" Then
            Console.WriteLine("Cześć Jan")
        End If

        If imie = "Ryszard" Then
            Console.WriteLine("Cześć Ryszard")
        End If

        If imie = "Ryszard" Then
            If wiek = 56 Then
                Console.WriteLine("Cześć Ryszard, niedłlugo 56 urodziny!")
            Else
                Console.WriteLine("Cześć Ryszard, nie masz teraz urodzin!")
            End If
        End If




        Console.ReadKey()






    End Sub

End Module
