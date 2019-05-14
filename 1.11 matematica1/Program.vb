Imports System.Math

Module matematica1
    Sub Main(args As String())
        Dim A As Integer
        Dim B As Integer
        Dim P As Integer
        Dim R As Integer

        Console.WriteLine("Ingresar numero: ")
        A = Console.ReadLine()
        B = Math.Abs(A)
        Console.WriteLine("EL valor absoluto es: " & B)

        P = A ^ 10
        Console.WriteLine("La potencia del numero es: " & P)

        R = Math.Sqrt(A)
        Console.WriteLine("La raiz cuadrada es: " & R)

    End Sub
End Module
