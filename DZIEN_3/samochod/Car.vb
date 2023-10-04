Public Class Car : Implements IComparable(Of Car)
    Public Property Name As String
    Public Property Speed As Integer
    Public Property Color As String


    Public Function CompareTo(other As Car) As Integer Implements IComparable(Of Car).CompareTo
        Dim compare As Integer
        compare = String.Compare(Me.Color, other.Color, True)
        If compare = 0 Then
            compare = Me.Speed.CompareTo(other.Speed)
            compare = -compare
        End If
        Return compare
    End Function
End Class
