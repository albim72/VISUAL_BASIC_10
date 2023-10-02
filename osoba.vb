Public Class Osoba
    Public imie As String
    Public nazwisko As String
    Public wiek As Integer
    Public stanowisko As String
    Public wzrost As Single
    Public waga As Single
    Public koloroczu As String = "brązowy"

    Public Sub New(imie As String, nazwisko As String, wiek As Integer, stanowisko As String,
                   wzrost As Single, waga As Single)
        Me.imie = imie
        Me.nazwisko = nazwisko
        Me.wiek = wiek
        Me.stanowisko = stanowisko
        Me.wzrost = wzrost
        Me.waga = waga

    End Sub

    Public Function printOsoba()
        Console.WriteLine("osoba: {0} {1}, wiek: {2}, stanowisko pracy: {3}, wzrost {4} cm, waga: {5} kg.",
imie, nazwisko, wiek, stanowisko, wzrost, waga)
        Console.ReadKey()
    End Function

End Class
