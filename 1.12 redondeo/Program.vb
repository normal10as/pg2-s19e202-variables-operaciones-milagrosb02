Imports System
Imports System.Math

Module redondeo
    Sub Main(args As String())
        Dim N As Double

        Console.WriteLine("INGRESAR UN NUMERO REAL: ")
        N = Console.ReadLine()
        N = Math.Round(N)

        Console.WriteLine("El redondeo es de: " & N)



    End Sub
End Module
