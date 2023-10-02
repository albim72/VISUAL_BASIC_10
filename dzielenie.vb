Module Module1

    Function funkcja_z_bledem(a, x)
        If x < 0 Then
            funkcja_z_bledem = "x musi być większe od 0"
            Exit Function
        End If
        If a = x Then
            funkcja_z_bledem = "Nieskończoność!"
        Else
            funkcja_z_bledem = (a * x + Math.Sqrt(x) / (a - x))
        End If
    End Function


    Sub Main()
        Dim x, a As Single
        Dim xss, ass As String
        Dim y As Object

        xss = InputBox("Podaj wartość x: ", "wartość x")
        ass = InputBox("Podaj wartość a: ", "wartość a")

        x = CSng(xss)
        a = CSng(ass)

        y = funkcja_z_bledem(a, x)

        MsgBox("wartość funkcji wynosi: " & y)


    End Sub

End Module
