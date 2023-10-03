Public Class Box
    Private length As Double
    Private height As Double
    Private breadth As Double

    Private Sub setLength(len As Double)
        length = len
    End Sub

    Private Sub setHeight(hei As Double)
        height = hei
    End Sub

    Private Sub setBreadth(bre As Double)
        breadth = bre
    End Sub

    Public Function getVolume() As Double
        Return length * height * breadth
    End Function

End Class
