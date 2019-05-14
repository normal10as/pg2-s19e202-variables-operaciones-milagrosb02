Imports System

Module resto_division
    Sub Main(args As String())
        Dim division As Integer
        Dim resto As Single

        Console.WriteLine("Ingresar un valor entero: ")
        division = Console.ReadLine()

        resto = division / 2

        Console.WriteLine("El resto de la division es: " & resto)


    End Sub
End Module
