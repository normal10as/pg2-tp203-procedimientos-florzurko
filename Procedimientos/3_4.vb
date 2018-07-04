Module _3_4
    Sub main()
        'Dados los lados A y B de un triángulo rectángulo, según el teorema de 
        'Pitágoras, el cuadrado de la hipotenusa(C), es igual a la suma del cuadrado
        'de los catetos (lados) de lo que se da la siguiente fórmula: c² = a² + b². 
        'Elaborar una función que reciba el tamaño de los lados A y B, calcule y 
        'devuelva C(hipotenusa).
        'Ingresar los valores por teclado y mostrar el resultado en consola.
        'Utilizar una función para validar los valores 
        'ingresados sean enteros positivos, si no cumple esta condición pedir el
        'reingreso del dato.
        Dim ladoa, ladob As Integer
        ladoa = leer("Ingrese lado A:")
        ladob = leer("Ingrese lado B:")
        Console.WriteLine("El cuadrado a la hipotenusa es {0}", hipotenusa(ladoa, ladob))
        Console.ReadKey()
    End Sub
    Private Function leer(mensaje As String) As Short
        Dim valor As Short
        Do
            Console.WriteLine(mensaje)
            valor = Console.ReadLine
        Loop Until validar(Valor)
        Return valor
    End Function

    Private Function validar(valor As Integer) As Boolean
        If valor > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function hipotenusa(ladoa As Integer, ladob As Integer) As Integer
        Return Math.Sqrt((ladoa ^ 2) + (ladob ^ 2))
    End Function
End Module
