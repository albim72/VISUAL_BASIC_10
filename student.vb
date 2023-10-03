Public Class Student : Inherits Osoba

    Public nr_albumu As String 'zmienna, lewa strona przyrównanie
    Public kierunek As String
    Public zaliczona_sesja As Boolean

    Public Sub New(imie As String, nazwisko As String, wiek As Integer, stanowisko As String,
                   wzrost As Single, waga As Single,
                   nr_albumu As String, kierunek As String, zaliczona_sesja As Boolean)
        'atrybuty - prawa strona przyrównania
        MyBase.New(imie, nazwisko, wiek, stanowisko, wzrost, waga)
        Me.nr_albumu = nr_albumu
        Me.kierunek = kierunek
        Me.zaliczona_sesja = zaliczona_sesja
    End Sub

    Public Function printStudent() As String
        Console.WriteLine("Student {0}, kierunek: {1}, czy zaliczona sesja? ({2})",
                          nr_albumu, kierunek, zaliczona_sesja)
        Console.ReadKey()
    End Function
End Class
