Public Class Form1
    Private Sub btnSkrypt_Click(sender As Object, e As EventArgs) Handles btnSkrypt.Click
        Dim proc As Process = Nothing
        Try
            Dim batDir As String = String.Format("C:\Temp")
            proc = New Process()
            proc.StartInfo.WorkingDirectory = batDir
            proc.StartInfo.FileName = "testbatch.bat"
            proc.StartInfo.CreateNoWindow = False
            proc.Start()
            proc.WaitForExit()
            MessageBox.Show("Proces został wykonany!")
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
        End Try
    End Sub
End Class
