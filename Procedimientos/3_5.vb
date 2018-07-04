Module _3_5
    Sub main()
        'El volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265)
        'por el cuadrado del radio de la base(r) por la altura(h) de lo que se da la 
        'siguiente fórmula: v = πr²h. 
        'Elaborar una función que lea el radio de la base y la altura de un cilindro,
        'que calcule y devuelva el volumen. 
        'Ingresar los valores por teclado y mostrar el resultado en consola. 
        'Utilizar un procedimiento para validar los valores ingresados sean positivos, 
        'si no cumple esta condición pedir el reingreso del dato.
        Dim base, altura As Decimal
        base = leer("Ingrese la Base: ")
        altura = leer("Ingrese la Altura: ")
        Console.WriteLine("El Volumen del cilindro es {0}", volumen(base, altura))
        Console.ReadKey()

    End Sub
    Private Function leer(mensaje As String) As Short
        Dim valor As Short
        Do
            Console.WriteLine(mensaje)
            valor = Console.ReadLine
        Loop Until validar(valor)
        Return valor
    End Function
    Private Function validar(valor As Decimal) As Boolean
        If valor > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function volumen(base As Decimal, altura As Decimal) As Decimal
        Dim pi As Decimal = 3.14159265
        Dim radio As Decimal = (base ^ 2)
        Return Math.Round((pi * radio * altura), 2)
    End Function
End Module
