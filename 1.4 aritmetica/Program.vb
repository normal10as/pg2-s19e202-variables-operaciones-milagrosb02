Imports System

Module aritmetica
    Sub Main(args As String())
        Dim num1 As Integer = 10
        Dim num2 As Integer = 30
        Dim num3 As Double = 21.3
        Dim num4 As Double = 13.7
        Dim suma As Integer = num1 + num3
        Dim resta As Single = num2 - num4
        Dim mult As Single = num1 * num3
        Dim div As Single = num3 / num4



        Console.WriteLine("El numero 1 vale: " & num1)
        Console.WriteLine("El numero 2 vale: " & num2)
        Console.WriteLine("El numero 3 vale: " & num3)
        Console.WriteLine("El numero 2 vale: " & num4)
        Console.WriteLine("El resultado de esta suma entre enteros es: " & suma)
        Console.WriteLine("El resultado de esta resta entre punto flotante y entero es: " & resta)
        Console.WriteLine("El resultado de esta multiplicacion entre punto flotante y entero es: " & mult)
        Console.WriteLine("El resultado de esta division entre puntos flotantes es: " & div)
    End Sub
End Module
