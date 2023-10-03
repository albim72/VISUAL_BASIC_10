Public Class Box
    Private length As Double
    Private height As Double
    Private breadth As Double

    Public Sub setLength(len As Double)
        length = len
    End Sub

    Public Sub setHeight(hei As Double)
        height = hei
    End Sub

    Public Sub setBreadth(bre As Double)
        breadth = bre
    End Sub

    Public Function getVolume() As Double
        Return length * height * breadth
    End Function

End Class
