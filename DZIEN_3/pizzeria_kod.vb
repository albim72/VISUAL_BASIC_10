Public Class Form1
    Private Const V As Integer = 0
    Dim msRozm As String
    Dim mdCena As Decimal
    Dim mdKwota As Decimal
    Dim mdCiasto As String
    Dim mdDodatki As String
    Dim TotalCena As Decimal

    Public dodatki As List(Of CheckBox)

    Private Sub btnZamknij_Click(sender As Object, e As EventArgs) Handles btnZamknij.Click
        Close()
    End Sub

    Private Sub rbCienkie_CheckedChanged(sender As Object, e As EventArgs) Handles rbCienkie.CheckedChanged
        mdCiasto = "cienkie ciasto"
    End Sub

    Private Sub rbStandard_CheckedChanged(sender As Object, e As EventArgs) Handles rbStandard.CheckedChanged
        mdCiasto = "standardowe ciasto"
    End Sub

    Private Sub rbGrube_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrube.CheckedChanged
        mdCiasto = "grube ciasto"
    End Sub

    Private Sub rbMala_CheckedChanged(sender As Object, e As EventArgs) Handles rbMala.CheckedChanged
        msRozm = "mała pizza"
        mdCena = 22
    End Sub

    Private Sub rbSrednia_CheckedChanged(sender As Object, e As EventArgs) Handles rbSrednia.CheckedChanged
        msRozm = "średnia pizza"
        mdCena = 27
    End Sub

    Private Sub rbDuza_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuza.CheckedChanged
        msRozm = "duża pizza"
        mdCena = 34
    End Sub
End Class
