Public Class Diesel : Inherits Auto

    Public Sub New(odleglosc As Double, cenaj As Double)
        MyBase.New(odleglosc, cenaj)
    End Sub
    Dim avg_jedn As Double = 26.6
    Dim avg_odl As Double = 300

    Dim spal100 = avg_jedn * 100 / avg_odl
    Public Overrides Function policzKosztPaliwa() As Double
        Return spal100 * odleglosc * cenaj / 100
    End Function
End Class
