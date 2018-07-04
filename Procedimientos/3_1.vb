Module _3_1
    Sub main()
        'Crear un módulo que imprima la fecha y hora actual con sus 
        'respectivas leyendas según las siguientes condiciones: 
        'Utilizar una sub para imprimir la fecha actual.
        'Utilizar una function para obtener la hora actual.
        'Llamar a los métodos desde el método Main.
        fechactual()
        horactual()
        Console.ReadKey()
    End Sub

    Private Sub fechactual()
        Dim fecha As Date = Today
        Console.WriteLine("Fecha: " & fecha)
    End Sub

    Private Function horactual()
            Dim hora As Date = TimeString
            Console.WriteLine("Hora: " & hora)
            Return hora
        End Function
    End Module


