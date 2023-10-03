Public Class Trapez : Inherits Figury

    Public h As Double
    Public Sub New(a As Double, b As Double, h As Double)
        MyBase.New(a, b)
        Me.h = h
    End Sub

    Public Overrides Function policzPole() As String
        Dim pole As Double
        pole = (a + b) * h / 2
        Console.WriteLine("obliczanie pola trapezu...")
        Console.ReadKey()
        Return pole
    End Function
End Class
