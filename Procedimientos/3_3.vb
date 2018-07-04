Module _3_3
    'Mostrar las 5 primeras potencias de un valor numérico ingresado 
    'por teclado del mismo. Implementar una función que retornará una 
    'potencia cada vez que se invoque, la primera vez el exponente será
    '2, la segunda vez 3 y así sucesivamente.
    Sub main()
        Dim valor As Integer
        Console.WriteLine("Ingrese un numero: ")
        valor = Console.ReadLine

        For x = 2 To 6 Step 1
            Console.WriteLine("La potencia de {0} elevado a la {1} es : {2}", valor, x, potencias(valor, x))
        Next
        Console.ReadKey()
    End Sub

    Private Function potencias(num As Integer, expo As Integer) As Integer
        Return num ^ expo
    End Function
End Module

