Public MustInherit Class Figury
    Public a As Double
    Public b As Double

    Protected Sub New(a As Double, b As Double)
        Me.a = a
        Me.b = b
    End Sub

    Public Sub Info(s)
        Console.WriteLine(s)
    End Sub

    Public MustOverride Function policzPole() As String

End Class
