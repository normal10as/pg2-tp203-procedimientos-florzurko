Module _3_6
    Sub main()
        '- Elaborar un algoritmo que lea un número N, que imprima la 
        'sumatoria de los cuadrados de los enteros entre 1 y N. 
        Dim numero As Single
        numero = leer("Ingrese un numero: ")
        Console.WriteLine("La sumatoria de los cuadrados de los enteros entre 1 a {0} es: {1}", numero, suma(numero))
        Console.ReadKey()
    End Sub
    '- Utilizar un método para el cálculo de la sumatoria vía 
    'parámetro por referencia.
    Private Function suma(ByRef numero As Single) As Single
        Dim sumatoria, num As Single
        For x = 1 To numero Step 1
            num = x ^ 2
            sumatoria = sumatoria + num
            Console.WriteLine("La potencia de {0} elevado a la 2 es : {1}", x, num)
        Next

        Return sumatoria
    End Function
    Private Function leer(mensaje As String) As Short
        Dim valor As Short
        Do
            Console.WriteLine(mensaje)
            valor = Console.ReadLine
        Loop Until validar(valor)
        Return valor
    End Function
    Private Function validar(valor As Integer) As Boolean
        If valor > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
