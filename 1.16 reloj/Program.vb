Imports System

Module reloj
    Sub Main(args As String())
        Dim fecha As Date
        Dim tiempo As Date
        fecha = Date.Now.ToString("dd-MM-yyyy")
        tiempo = Date.Now.ToString("hh:mm:ss")
        Console.WriteLine("La fecha es: " & fecha)
        Console.WriteLine("El tiempo actual es: " & tiempo)
    End Sub
End Module
