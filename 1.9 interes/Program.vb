Imports System

Module interes
    Sub Main(args As String())
        Dim m As Decimal
        Dim r As Decimal
        Dim t As Integer
        Dim I As Decimal

        Console.WriteLine("Ingrese un monto: ")
        m = Console.ReadLine()

        Console.WriteLine("Ingresar interes anual: ")
        r = Console.ReadLine()

        Console.WriteLine("Ingresar tiempo: ")
        t = Console.ReadLine()

        I = ((m * r * t)) / 360 * 100

        Console.WriteLine("El interes producido es de: " & I)



    End Sub
End Module
