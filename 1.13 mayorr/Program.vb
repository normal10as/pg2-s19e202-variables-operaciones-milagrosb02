Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim N1 As Integer
        Dim N2 As Integer
        Dim N3 As Integer
        Dim M As Integer
        Dim MA As Integer

        Console.WriteLine("Ingresar numero 1: ")
        N1 = Console.ReadLine()

        Console.WriteLine("Ingresar numero 2: ")
        N2 = Console.ReadLine()

        Console.WriteLine("Ingresar numero 3: ")
        N3 = Console.ReadLine()

        M = Math.Max(N1, N2)
        MA = Math.Max(N2, N3)
        Console.WriteLine("El mayor de los numeros es: " & M)
        Console.WriteLine("El mayor de estos numeros es: " & MA)
    End Sub
End Module
