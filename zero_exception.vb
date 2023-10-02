Module Module1

    Sub Main()
        Dim x As Integer = 0
        Dim y As Double = 1 / x
        MsgBox(y)
        MsgBox(Math.Sqrt(y))
        'Try
        '    Dim x As Integer = 0
        '    Dim y As Double = 1 / x
        '    MsgBox(y)
        '    MsgBox(Math.Sqrt(y))
        'Catch dz As DivideByZeroException
        '    MsgBox("Dzielenie przez zero: " & dz.Message)
        'Catch ex As Exception
        '    MsgBox("jakiś inny błąd: " & ex.Message)
        'Finally
        '    MsgBox("Kod wykonany w każdym przypadku")
        'End Try


    End Sub

End Module
