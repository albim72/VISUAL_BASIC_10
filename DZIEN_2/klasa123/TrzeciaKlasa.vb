Public Class TrzeciaKlasa : Inherits DrugaKlasa
    Public d As Integer
    Public Sub New(a As Integer, b As Integer, c As Integer, d As Integer)
        MyBase.New(a, b, c)
        Me.d = d
    End Sub

    Public Function printABCD() As String
        Console.WriteLine("a = {0}, b = {1}, c = {2}, d={3}.", a, b, c, d)
        Console.ReadKey()

    End Function

    Public Overrides Function Oblicz() As Integer
        Return a * (b + d) - c
    End Function

    Public Overrides Function policzSume() As Integer
        Return MyBase.policzSume() + d
        Console.WriteLine("a+b+c+d = {0}", policzSume)
        Console.ReadKey()
    End Function
End Class
