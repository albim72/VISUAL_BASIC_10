Public Class Kolo : Inherits Figury

    Public Sub New(a As Double)
        MyBase.New(a)
    End Sub

    Public Overrides Function policzPole() As String
        Dim pole As Double
        pole = Math.PI * Math.Pow(a, 2)
        Console.WriteLine("obliczanie pola koła...")
        Console.ReadKey()
        Return pole
    End Function
End Class
