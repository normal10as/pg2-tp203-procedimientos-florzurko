Module _3_2
    Sub main()
        'Crear una función que reciba una fecha y un entero que representa
        'una cantidad de días a sumar a la fecha. Desde el módulo principal 
        'ingresar una fecha y la cantidad de días e invocar a esta función 
        'pasándole los parámetros: fecha actual y días, mostrar el valor obtenido.
        Dim fecha As Date
        Dim dias As Integer
        Console.WriteLine("Ingrese una fecha: ")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de dias que desea sumar a la fecha: ")
        dias = Console.ReadLine
        Console.WriteLine("La nueva fecha es: {0}", sumardias(fecha, dias))
        Console.ReadKey()
    End Sub
    'la funcion usa la fecha y dias 
    ' es as date para utilizar el adddays
    Private Function sumardias(fecha As Date, dias As Integer) As Date
        ' suma los dias a la fecha
        Return fecha.AddDays(dias)
    End Function
End Module
