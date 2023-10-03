Public Class Trojkat : Inherits Figury

    Public Sub New(a As Double, b As Double)
        MyBase.New(a, b)
    End Sub

    Public Overrides Function policzPole() As String
        Dim pole As Double
        pole = a * b / 2
        Console.WriteLine("obliczanie pola trójkąta...")
        Console.ReadKey()
        Return pole
    End Function
End Class
