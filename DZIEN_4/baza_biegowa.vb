Public Class Form1
    Dim context As zawodyEntities = New zawodyEntities
    Dim dane = "Spis wszystkich zawodów biegów..." & vbCrLf
    Dim biegi
    Dim query
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        query = From li In context.bieg
                Order By li.nazwa_biegu
                Select li

        Dim bg As bieg
        For Each bg In query
            biegi = "Bieg -> " & bg.nazwa_biegu &
                " -> odległość " & bg.odleglosc_km & " km" & vbCrLf
            dane = dane + biegi
            TextBox1.Text = dane


        Next
        Label3.Text = "wszystkie biegi zostały dodane!"

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim odl = granica.Value
        Dim zp = From b1 In context.bieg
                 Join b2 In context.rodzaje_biegow On b1.idrodzaju Equals b2.idrodzaju
                 Where b1.odleglosc_km > odl
                 Select b1.nazwa_biegu, b1.odleglosc_km, b2.nazwa_rodaju

        TextBox1.ResetText()
        Dim dd = ""
        Dim wynik
        For Each dn In zp
            wynik = "Big: " & dn.nazwa_biegu &
                ", odległość: " & dn.odleglosc_km & " km" &
                ", rodzaj biegu: " & dn.nazwa_rodaju & vbCrLf
            dd = dd + wynik
            TextBox1.Text = dd

        Next
        Label3.Text = "aktualizacja danych!"
    End Sub
End Class
