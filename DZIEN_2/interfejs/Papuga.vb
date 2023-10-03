Public Class Papuga : Implements IZwierz

    Public Sub odglos() Implements IZwierz.odglos
        Console.WriteLine("Papuga gada...")
    End Sub

    Public Sub info() Implements IZwierz.info
        Console.WriteLine("Papuga jest ptakiem!")
    End Sub

    Public Function liczba_nog() As Integer Implements IZwierz.liczba_nog
        Return 2
    End Function

    Public Function kolor(kol As String) As String Implements IAbc.kolor
        Return "kolor papugi: " & kol
    End Function

    Public Function warunkibytu(info As String) As String Implements IWarunki.warunkibytu
        Return "Papuga przebywa w: " & info
    End Function
End Class
