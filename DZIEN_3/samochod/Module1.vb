Module Module1

    Sub Main()

        Dim cars As New List(Of Car) From
            {
            New Car With {.Name = "Audi", .Color = "blue", .Speed = 230},
            New Car With {.Name = "Seat", .Color = "red", .Speed = 210},
            New Car With {.Name = "BMW", .Color = "green", .Speed = 250},
            New Car With {.Name = "Opel", .Color = "blue", .Speed = 210},
            New Car With {.Name = "Mercedes", .Color = "blue", .Speed = 280},
            New Car With {.Name = "Toyota", .Color = "red", .Speed = 230},
            New Car With {.Name = "KIA", .Color = "green", .Speed = 220}
        }

        cars.Sort()

        For Each thisCar As Car In cars
            Console.Write(thisCar.Color.PadRight(5) & "  ")
            Console.Write(thisCar.Speed.ToString & "  ")
            Console.Write(thisCar.Name)
            Console.WriteLine()

        Next

        Console.ReadKey()



    End Sub

End Module
