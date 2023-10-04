Public MustInherit Class Auto
    Public odleglosc As Double
    Public cenaj As Double

    Protected Sub New(odleglosc As Double, cenaj As Double)
        Me.odleglosc = odleglosc
        Me.cenaj = cenaj
    End Sub

    Public MustOverride Function policzKosztPaliwa() As Double

End Class
