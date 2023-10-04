Imports System.Configuration

Module Module1

    Sub Main()
        Dim connectionString As String =
            ConfigurationManager.ConnectionStrings("connectToSQL.My.MySettings.GARDENConnectionString").ToString
        Dim db As New gardenDBDataContext(connectionString)

        Dim newProdukt As New Produkty()

        newProdukt.IDProduktu = 1312
        newProdukt.NazwaProduktu = "Szampon naturalny ABC"
        newProdukt.CenaJednostkowa = 43.2
        db.Produkty.InsertOnSubmit(newProdukt)
        db.SubmitChanges()

        Dim printProdukt As Produkty =
            db.Produkty.FirstOrDefault(Function(e) e.IDProduktu.Equals(1312))

        Console.WriteLine("Produkt {0}, nazwa proaduktu: {1}, cena jednostkowa: {2}",
                           printProdukt.IDProduktu, printProdukt.NazwaProduktu,
                           printProdukt.CenaJednostkowa)

        Console.ReadKey()



    End Sub

End Module
