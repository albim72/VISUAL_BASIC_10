Module Module1

    Sub Main()
        Dim s As String
        Dim pensja_brutto, pensja_netto As Long

        s = InputBox("Podaj wyskość pensji brutto... ")
        If IsNumeric(s) Then
            pensja_brutto = s
            pensja_netto = 0.82 * pensja_brutto
            MsgBox(VarType(s))
            MsgBox(VarType(pensja_brutto))
            MsgBox(VarType(pensja_netto))
            MsgBox("Pensja netto: " & pensja_netto & ", pensja brutto: " & pensja_brutto)
        Else
            MsgBox("Pensja musi być liczbą!")

        End If

    End Sub

End Module
