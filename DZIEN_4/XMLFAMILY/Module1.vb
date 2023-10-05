Imports System.Xml

Module Module1

    Sub Main()
        Dim m_xmlr As XmlTextReader
        m_xmlr = New XmlTextReader("family.xml")

        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        m_xmlr.Read()
        m_xmlr.Read()

        While Not m_xmlr.EOF
            m_xmlr.Read()
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            Dim genderAttr = m_xmlr.GetAttribute("gender")
            m_xmlr.Read()
            Dim fnvalue = m_xmlr.ReadElementString("firstname")
            Dim lnvalue = m_xmlr.ReadElementString("lastname")
            Dim agevalue = m_xmlr.ReadElementString("age")

            Console.WriteLine("Płeć: {0}, Osoba: {1} {2}, wiek: {3}",
                            genderAttr, fnvalue, lnvalue, agevalue)
            Console.ReadKey()


        End While

        m_xmlr.Close()
    End Sub

End Module
