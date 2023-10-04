Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvPracownik.View = View.Details

        lvPracownik.Columns.Add("Pracownik", 300, HorizontalAlignment.Right)
        lvPracownik.Columns.Add("ID", 40, HorizontalAlignment.Left)
        lvPracownik.Columns.Add("Stanowisko", 100, HorizontalAlignment.Left)

        Dim str(3) As String
        Dim lv As ListViewItem

        str(0) = "Jan Kowalski"
        str(1) = "1"
        str(2) = "Prezes"
        lv = New ListViewItem(str)
        lvPracownik.Items.Add(lv)

        str(0) = "Olga Kot"
        str(1) = "2"
        str(2) = "Sekretarka"
        lv = New ListViewItem(str)
        lvPracownik.Items.Add(lv)

        str(0) = "Adam Kos"
        str(1) = "3"
        str(2) = "Kierowca"
        lv = New ListViewItem(str)
        lvPracownik.Items.Add(lv)


    End Sub
End Class
