Public Class Form1
    Dim context As GARDENEntities = New GARDENEntities
    Dim dane
    Dim klient
    Dim zap
    Dim drugiedane
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Ten wiersz kodu wczytuje dane do tabeli 'GARDENDataSet.vMiato' . Możesz go przenieść lub usunąć.
        Me.VMiatoTableAdapter.Fill(Me.GARDENDataSet.vMiato)

        Dim query = From it In context.Klienci
                    Order By it.IDKlienta
                    Select it

        Dim comp As Klienci
        For Each comp In query
            klient = "Dane Klienta - imię: " & comp.Imię &
                ", nazwisko: " & comp.Nazwisko &
                ", miasto: " & comp.Miasto & vbCrLf
            dane = dane + klient
            tbWynik.Text = dane


        Next

    End Sub

    Private Sub btnZapytanie_Click(sender As Object, e As EventArgs) Handles btnZapytanie.Click
        Dim sItem = cbMiasto.SelectedValue
        Dim query = From p1 In context.Klienci
                    Join p2 In context.Zamówienia On p1.IDKlienta Equals p2.IDKlienta
                    Where p1.Miasto = sItem.ToString()
                    Select p1.Imię, p1.Nazwisko, p2.IDZamówienia, p2.DataWysyłki

        tbWynik.ResetText()
        drugiedane = ""
        For Each wyn In query
            zap = "Dane Klienta - imię: " & wyn.Imię &
                ", nazwisko: " & wyn.Nazwisko &
                ", ID Zamówienia: " & wyn.IDZamówienia &
                ", ID Zamówienia: " & wyn.DataWysyłki & vbCrLf
            drugiedane = drugiedane + zap
            tbWynik.Text = drugiedane
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbWynik.ResetText()
    End Sub
End Class
