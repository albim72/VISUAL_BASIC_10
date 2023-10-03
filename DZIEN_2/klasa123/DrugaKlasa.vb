Public Class DrugaKlasa : Inherits PierwszaKlasa
    Public c As Integer

    Public Sub New(a As Integer, b As Integer, c As Integer)
        MyBase.New(a, b)
        Me.c = c
    End Sub

    Public Function printABC() As String
        Console.WriteLine("a = {0}, b = {1}, c = {2}.", a, b, c)
        Console.ReadKey()

    End Function

    Public Overrides Function Oblicz() As Integer
        Return MyBase.Oblicz() + 3 * c
    End Function

    Public Overridable Function policzSume() As Int32
        policzSume = a + b + c
        Console.WriteLine("suma a+b+c = {0}", policzSume)
        Console.ReadKey()

    End Function

End Class
