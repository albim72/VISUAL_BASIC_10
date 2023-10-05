Imports System.Configuration

Public Class Form1
    Public connectionStr As String =
        ConfigurationManager.ConnectionStrings("produktOkno.My.MySettings.GARDENConnectionString").ToString
    Public db As New DataClasses1DataContext(connectionStr)

    Private Sub btnDodaj_Click(sender As Object, e As EventArgs) Handles btnDodaj.Click

    End Sub
End Class
