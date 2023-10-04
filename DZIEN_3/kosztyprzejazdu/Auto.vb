Public MustInherit Class Auto
    Public odleglosc As Double
    Public jednostki As Double
    Public cenaj As Double

    Protected Sub New(odleglosc As Double, jednostki As Double, cenaj As Double)
        Me.odleglosc = odleglosc
        Me.jednostki = jednostki
        Me.cenaj = cenaj
    End Sub

    Public MustOverride Function policzKosztPaliwa() As Double

End Class
