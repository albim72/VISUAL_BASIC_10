Public Class Obliczenie
    Public wyb As Byte
    Public metr As Double

    Dim wynik As Double

    Public Sub New(wyb As Byte, metr As Double)
        Me.wyb = wyb
        Me.metr = metr
    End Sub

    Public Function policzMiare() As Double
        Select Case (wyb)
            Case 1
                wynik = metr / 1850
            Case 2
                wynik = metr / 1609.344
            Case 3
                wynik = metr / 0.9144
            Case 4
                wynik = metr / 0.30477
            Case 5
                wynik = metr / 0.0254
        End Select
        Return wynik
    End Function
End Class
