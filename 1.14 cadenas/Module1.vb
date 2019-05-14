Imports System
Imports vb = Microsoft.VisualBasic

Module module1

    Sub Main(args As String())
        Dim cadena As String
        Dim c As String

        Console.WriteLine("Ingresar una frase: ")
        cadena = Console.ReadLine()
        c = InStr(cadena, "a")
        Console.WriteLine("La letra a aparece en la posicion: " & c)
        c = InStr(cadena, "o")
        Console.WriteLine("La letra o aparece en la posicion: " & c)
        c = StrReverse(cadena)
        Console.WriteLine("Palabra invertida: " & c)
    End Sub

End Module
