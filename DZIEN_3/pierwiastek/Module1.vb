Module Module1

    Sub Main()
        Dim elements As Dictionary(Of String, Element) = BuildDictionary()

        For Each kvp As KeyValuePair(Of String, Element) In elements
            Dim theElement As Element = kvp.Value

            Console.WriteLine("klucz: {0}", kvp.Key)
            With theElement
                Console.WriteLine("wartości: {0}, nazwa: {1}, liczba atomowa: {2}",
                                    .Symbol, .ElementName, .AtomicNumber)
            End With
            Console.ReadKey()
        Next


    End Sub

    Private Sub AddToDictionary(ByVal elements As Dictionary(Of String, Element),
                                ByVal symbol As String,
                                ByVal name As String,
                                ByVal atomicNumber As Integer)
        Dim theElement As New Element
        theElement.Symbol = symbol
        theElement.ElementName = name
        theElement.AtomicNumber = atomicNumber

        elements.Add(key:=theElement.Symbol, value:=theElement)
    End Sub
    Private Function BuildDictionary() As Dictionary(Of String, Element)
        Dim elements As New Dictionary(Of String, Element)
        AddToDictionary(elements, "K", "Potas", 19)
        AddToDictionary(elements, "Ca", "Wapń", 20)
        AddToDictionary(elements, "Sc", "Skand", 21)
        AddToDictionary(elements, "Ti", "Tytan", 22)

        Return elements
    End Function


End Module
