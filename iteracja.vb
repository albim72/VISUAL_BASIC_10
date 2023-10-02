Module Module1

    Sub Main()
        'iteracja -> zastowsowanie insrukcji iteracyjnej(pętli)
        Dim x = 0, y

        Do Until x = 2
            x = x + 1
            y = 2 * x
            MsgBox("wartość y wynosi " & y)
        Loop

        Dim g = 4
        While g < 10
            g = 2 * g
            MsgBox("wartość g wynosi " & g)
        End While


        For n = 1 To 4
            For m = 1 To 5
                Console.WriteLine("para (n,m): (" & n & ", " & m & ")")

            Next
        Next


        Console.ReadKey()

    End Sub

End Module
