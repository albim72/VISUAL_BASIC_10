Public Class PierwszaKlasa
    Public a As Integer
    Public b As Integer

    Public Sub New(a As Integer, b As Integer)
        Me.a = a
        Me.b = b
    End Sub

    Public Function printAB() As String
        Console.WriteLine("a = {0}, b = {1}.", a, b)
        Console.ReadKey()

    End Function

    Public Overridable Function Oblicz() As Int32
        Oblicz = a * b
        Console.WriteLine("a*b = {0}", Oblicz)
        Console.ReadKey()

    End Function

End Class
