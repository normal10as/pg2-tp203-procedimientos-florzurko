Module _3_8
    Enum operaciones
        suma = 1
        resta = 2
        multiplica = 3
        division = 4
    End Enum
    Sub main()
        mostrar()
    End Sub
    Private Sub mostrar()
        Console.WriteLine("5+7= " & calcular(5, 7))
        Console.WriteLine("--------- Suma de valores ---------")
        Console.WriteLine("5+7 = " & calcular(operaciones.suma, 5, 7))
        Console.WriteLine("5+7+5 = " & calcular(operaciones.suma, 5, 7, 5))
        Console.WriteLine("5+7+3+9 = " & calcular(operaciones.suma, 5, 7, 3, 9))
        Console.WriteLine("-------- Resta de valores ---------")
        Console.WriteLine("5-7 = " & calcular(operaciones.resta, 5, 7))
        Console.WriteLine("5-7-5 = " & calcular(operaciones.resta, 5, 7, 5))
        Console.WriteLine("5-7-3-9 = " & calcular(operaciones.resta, 5, 7, 3, 9))
        Console.WriteLine("---- Multiplicacion de valores ----")
        Console.WriteLine("5*7 = " & calcular(operaciones.multiplica, 5, 7))
        Console.WriteLine("5*7*5 = " & calcular(operaciones.multiplica, 5, 7, 5))
        Console.WriteLine("5*7*3*9 = " & calcular(operaciones.multiplica, 5, 7, 3, 9))
        Console.WriteLine("------- Division de valores -------")
        Console.WriteLine("5/7 = " & calcular(operaciones.division, 5, 7))
        Console.WriteLine("5/7/5 = " & calcular(operaciones.division, 5, 7, 5))
        Console.WriteLine("5/7/3/9 = " & calcular(operaciones.division, 5, 7, 3, 9))
        Console.ReadKey()
    End Sub
    Friend Function calcular(ByVal operacion As Byte,
                             ByVal num1 As Double,
                             ByVal num2 As Double,
                             ByVal num3 As Double) As Double
        Return calcular(operacion, calcular(operacion,
                                            num1, num2), num3)
    End Function
    Friend Function calcular(ByVal operacion As Byte,
                             ByVal num1 As Double,
                             ByVal num2 As Double,
                             ByVal num3 As Double,
                             ByVal num4 As Double) As Double
        Return calcular(operacion, calcular(operacion,
                                            num1, num2),
                        calcular(operacion, num3, num4))
    End Function
    Friend Function calcular(ByVal num1 As Double,
                             ByVal num2 As Double)
        Return calcular(1, num1, num2)
    End Function
    Friend Function calcular(ByVal operacion As Byte,
                             ByVal num1 As Double,
                             ByVal num2 As Double) As Double
        Dim x As Double
        Select Case operacion
            Case 1
                x = num1 + num2
            Case 2
                x = num1 - num2
            Case 3
                x = num1 * num2
            Case 4
                x = num1 / num2
        End Select
        Return x
    End Function

End Module


