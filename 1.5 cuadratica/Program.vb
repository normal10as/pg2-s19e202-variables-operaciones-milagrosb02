Imports System

Module cuadratica
    Sub Main(args As String())
        Dim a As Integer = 1
        Dim b As Integer = 5
        Dim c As Integer = 2
        Dim x As Integer

        x = ((b * b) - (4 * a * c)) / (2 * a)

        Console.WriteLine("A: " & a)
        Console.WriteLine("B: " & b)
        Console.WriteLine("C: " & c)
        Console.WriteLine("El resultado de la ecuacion es: " & x)

    End Sub
End Module
