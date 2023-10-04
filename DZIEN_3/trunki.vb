Public Class Form1
    Private Sub btnZam_Click(sender As Object, e As EventArgs) Handles btnZam.Click
        Dim str As String

        str = " "
        If cbDrink.Checked = True Then
            str &= cbDrink.Text & vbCrLf
            str &= " "
        End If

        If cbPiwo.Checked = True Then
            str &= cbPiwo.Text & vbCrLf
            str &= " "
        End If

        If cbWino.Checked = True Then
            str &= cbWino.Text & vbCrLf
            str &= " "
        End If

        If cbWhisky.Checked = True Then
            str &= cbWhisky.Text & vbCrLf
            str &= " "
        End If

        If cbWoda.Checked = True Then
            str &= cbWoda.Text & vbCrLf
            str &= " "
        End If

        If cbWodka.Checked = True Then
            str &= cbWodka.Text & vbCrLf
            str &= " "
        End If

        If str <> Nothing Then
            tbWynik.Visible = True
            tbWynik.Text = str & vbLf & "Dziękujemy, zamówienie dotrze w ciągu 5 minut!"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbWynik.Visible = False
    End Sub
End Class
