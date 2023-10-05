Imports System.Configuration

Public Class Form1
    Public connectionStr As String =
        ConfigurationManager.ConnectionStrings("produktOkno.My.MySettings.GARDENConnectionString").ToString
    Public db As New DataClasses1DataContext(connectionStr)

    Private Sub btnDodaj_Click(sender As Object, e As EventArgs) Handles btnDodaj.Click
        Dim idd, name
        Dim price As Double

        idd = tbID.Text
        name = tbNazwa.Text
        price = Double.Parse(tbCena.Text)

        Dim nowyProd As New Produkty()

        nowyProd.IDProduktu = idd
        nowyProd.NazwaProduktu = name
        nowyProd.CenaJednostkowa = price

        db.Produkty.InsertOnSubmit(nowyProd)
        db.SubmitChanges()

        Dim opis = "Rekord został dodany id = " & nowyProd.IDProduktu

        MessageBox.Show(opis, "informacja")

        tbID.Clear()
        tbNazwa.Clear()
        tbCena.Clear()

    End Sub
End Class
