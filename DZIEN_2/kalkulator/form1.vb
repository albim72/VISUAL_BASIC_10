Public Class Form1

    Private wybor As Byte
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMilaL.Checked = True


    End Sub

    Private Sub btnZamknij_Click(sender As Object, e As EventArgs) Handles btnZamknij.Click
        Close()
    End Sub

    Private Sub btnOpis_Click(sender As Object, e As EventArgs) Handles btnOpis.Click
        Opis.ShowDialog()
    End Sub

    Private Sub rbMilaM_CheckedChanged(sender As Object, e As EventArgs) Handles rbMilaM.CheckedChanged
        wybor = 1
    End Sub

    Private Sub rbMilaL_CheckedChanged(sender As Object, e As EventArgs) Handles rbMilaL.CheckedChanged
        wybor = 2
    End Sub

    Private Sub rbJard_CheckedChanged(sender As Object, e As EventArgs) Handles rbJard.CheckedChanged
        wybor = 3
    End Sub

    Private Sub rbStopa_CheckedChanged(sender As Object, e As EventArgs) Handles rbStopa.CheckedChanged
        wybor = 4
    End Sub

    Private Sub rbCal_CheckedChanged(sender As Object, e As EventArgs) Handles rbCal.CheckedChanged
        wybor = 5
    End Sub

    Private Sub btnPolicz_Click(sender As Object, e As EventArgs) Handles btnPolicz.Click
        Dim odl As String
        Dim wynik As Double
        Dim metry As Double
        odl = tbOdleglosc.Text
        If IsNumeric(odl) Then
            metry = Double.Parse(tbOdleglosc.Text)
        Else
            MessageBox.Show("wpisuj tylko liczby")
        End If


        Dim licz As Obliczenie = New Obliczenie(wybor, metry)
        wynik = licz.policzMiare()

        tbWynik.Text = Convert.ToString(wynik)
    End Sub
End Class

