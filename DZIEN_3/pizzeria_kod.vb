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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbGodzina.SelectedItem() = "18:00"
        dodatki = New List(Of CheckBox) From
            {cbPep, cbCeb, cbSer, cbSzy, cbPie, cbPom, cbTun, cbCzo}
        rbMala.Checked = True
        rbCienkie.Checked = True
        lbOdbior.SelectedItem = "dowóz"

    End Sub

    Private Sub btnZam_Click(sender As Object, e As EventArgs) Handles btnZam.Click
        rtbZam.AppendText("Zamówienie pizzy: " & ControlChars.Tab &
                          "rozmiar pizzy: " & msRozm.PadRight(12) & vbNewLine)
        rtbZam.AppendText("Cena pizzy: " & mdCena & vbNewLine)
        rtbZam.AppendText("Grubość ciasta: " & mdCiasto & vbNewLine)

        TotalCena += mdCena

        Dim str = ""
        For Each dod As CheckBox In dodatki
            If dod.Checked = True Then
                str &= dod.Text & ", "
            End If
        Next

        If str <> Nothing Then
            rtbZam.AppendText("Dodatki: " & str & vbNewLine)
        End If

        rtbZam.AppendText("Godzina dostawy: " & lbGodzina.Text & vbNewLine)
        rtbZam.AppendText("Odbiór zamówienia: " & lbOdbior.Text & vbNewLine)


    End Sub

    Private Sub btnKwota_Click(sender As Object, e As EventArgs) Handles btnKwota.Click
        rtbZam.AppendText("Wartość całkowita zamówienia: " & TotalCena & " zł" & vbNewLine)
        rtbZam.AppendText("Dziękujemy za zamówienie!")
        rtbZam.Enabled = True
        btnKwota.Enabled = False
        btnZam.Enabled = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each dod As CheckBox In dodatki
            dod.Checked = False
        Next
        lbGodzina.SelectedItem() = "18:00"
        dodatki = New List(Of CheckBox) From
            {cbPep, cbCeb, cbSer, cbSzy, cbPie, cbPom, cbTun, cbCzo}
        rbMala.Checked = True
        rbCienkie.Checked = True
        lbOdbior.SelectedItem = "dowóz"

        rtbZam.ResetText()
        btnKwota.Enabled = True
        btnZam.Enabled = True

    End Sub
End Class
