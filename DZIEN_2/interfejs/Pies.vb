Public Class Pies : Implements IZwierz

    Public Sub odglos() Implements IZwierz.odglos
        Console.WriteLine("Pies szczeka...")
    End Sub

    Public Sub info() Implements IZwierz.info
        Console.WriteLine("Pies jest ssakiem!")
    End Sub

    Public Function liczba_nog() As Integer Implements IZwierz.liczba_nog
        Return 4
    End Function

    Public Function kolor(kol As String) As String Implements IAbc.kolor
        Return "kolor psa: " & kol
    End Function

    Public Function warunkibytu(info As String) As String Implements IWarunki.warunkibytu
        Return "Pies przebywa w: " & info
    End Function

    Public Function wystawa(nazwa As String) As String
        Return "wystawa psów rasowych: " + nazwa
    End Function
End Class
