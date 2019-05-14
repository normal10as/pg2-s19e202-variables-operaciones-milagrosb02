Imports System
Imports vb = Microsoft.VisualBasic
Module Module1

    Sub Main()
        Dim p1 As String
        Dim p2 As String
        Dim cadena As String = "Aunque la cadena sea de oro, no sirve para lo mismo. "
        Dim C As String

        Console.WriteLine("Ingresar primer palabra: ")
        p1 = Console.ReadLine()

        Console.WriteLine("Ingresar segunda palabra: ")
        p2 = Console.ReadLine()

        C = Mid(cadena, 29, 8)
        Console.WriteLine("La cadena es :" & C)
    End Sub

End Module
