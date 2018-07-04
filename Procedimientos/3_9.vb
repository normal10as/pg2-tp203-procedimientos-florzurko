Module _3_9
    Sub main()
        'Crear un programa para calcular la superficie de una figura.
        'Los valores se ingresan por consola
        'Usar una función sobrecargada para resolver el área y 
        'según el número de parámetros será
        '1 = cuadrado  (Area = lado*lado)
        '2 = rectangulo (A = Base*Altura)
        '3 = Trapecio (A = ((B + b)/2)*h
        Dim opcion As Byte
        Dim lado, base, base2, altura As Integer
        Console.WriteLine("Elija la superficie a calcular: ")
        Console.WriteLine("1 = Cuadrado | 2 = Rectangulo | 3 = Trapecio")
        opcion = Console.ReadLine
        Select Case opcion
            Case 1
                Console.WriteLine("Ingrese el Lado: ")
                lado = Console.ReadLine
                calcular(lado)
            Case 2
                Console.WriteLine("Ingrese la Base: ")
                base = Console.ReadLine
                Console.WriteLine("Ingrese la Altura: ")
                altura = Console.ReadLine
                calcular(base, altura)
            Case 3
                Console.WriteLine("Ingrese la Primer Base: ")
                base = Console.ReadLine
                Console.WriteLine("Ingrese la Segunda Base: ")
                base2 = Console.ReadLine
                Console.WriteLine("Ingrese la Altura: ")
                altura = Console.ReadLine
                calcular(base, base2, altura)
            Case Else
                Console.WriteLine("Error. Opcion Invalida")
        End Select
        Console.ReadKey()
    End Sub
    Enum figuras
        cuadrado = 1
        rectangulo = 2
        trapecio = 3
    End Enum
    Private Function calcular(ByVal base As Integer, ByVal base2 As Integer, ByVal altura As Integer) As Integer
        Console.WriteLine("Area del Trapecio = " & ((base + base2) / 2) * altura)
        Return (0)
    End Function
    Private Function calcular(ByVal base As Integer, ByVal altura As Integer) As Integer
        Console.WriteLine("Area del Rectangulo = " & base * altura)
        Return (0)
    End Function
    Private Function calcular(ByVal lado As Integer) As Integer
        Console.WriteLine("Area del Cuadrado = " & lado * lado)
        Return (0)
    End Function

End Module
