Imports System.Security.Cryptography.X509Certificates

Module Module1

    Sub Liczby(nb)
        Console.Write(nb & "  ")
    End Sub

    Sub Main()
        Dim numbers As New List(Of Integer) From
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17}
        Console.WriteLine(numbers.Count)
        For index As Integer = numbers.Count - 1 To 0 Step -1
            If numbers(index) Mod 2 = 1 Then
                numbers.RemoveAt(index)

            End If
        Next

        numbers.ForEach(Sub(number) Console.Write(number & "  "))
        Console.WriteLine()
        Console.WriteLine(numbers.Count)

        For Each nb In numbers
            Liczby(nb)
        Next



        Console.ReadKey()

    End Sub

End Module
