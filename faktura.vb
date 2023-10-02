Module Module1

    Sub Main()

        Dim dzis, datafaktury As Date
        Dim datafakturyS As String
        Dim pldni As Long 'pldni - dni przekroczenia faktury
        Dim wD As Long 'wD - liczba dni od wystawienia faktury
        Dim df As Double = 5.689634858394

        dzis = Now
        datafakturyS = InputBox("Podaj datę wystawienie faktury: ", "FAKTURA")

        If IsDate(datafakturyS) Then
            datafaktury = CDate(datafakturyS)
            wD = DateDiff("d", datafaktury, dzis)
            If wD > 30 Then
                pldni = wD - 30
                MsgBox("Liczba dni od wystawienia faktury: " & wD & Chr(13) &
                       "przkroczono termin płatności: " & pldni & " dni, wpłać niezwłocznie!")
                MsgBox(pldni)
                Console.WriteLine(df)
                Console.ReadKey()

            Else
                MsgBox("Liczba dni od wystawienia faktury: " & wD)
            End If
        Else
            MsgBox("to nie jest format daty!")



        End If



    End Sub

End Module
