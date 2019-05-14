Imports System

Module Program
    Sub Main(args As String())
        Dim V As Boolean = True
        Dim F As Boolean = False

        Console.WriteLine("TABLA AND")
        Console.WriteLine("Verdadero y verdadero: " & (V And V))
        Console.WriteLine("Verdadero y falso: " & (V And F))
        Console.WriteLine("Falso y verdadero: " & (F And V))
        Console.WriteLine("Falso y falso: " & (F And F))

        Console.WriteLine(vbCrLf)

        Console.WriteLine("TABLA NOT")
        Console.WriteLine("Verdadero : " & (Not V))
        Console.WriteLine("Falso: " & (Not F))

        Console.WriteLine(vbCrLf)

        Console.WriteLine("TABLA XOR")
        Console.WriteLine("Verdadero y verdadero: " & (V Xor V))
        Console.WriteLine("Verdadero y falso: " & (V Xor F))
        Console.WriteLine("Falso y verdadero: " & (F Xor V))
        Console.WriteLine("Falso y falso: " & (F Xor F))

        Console.WriteLine(vbCrLf)

        Console.WriteLine("TABLA OR")
        Console.WriteLine("Verdadero y verdadero: " & (V Or V))
        Console.WriteLine("Verdadero y falso: " & (V Or F))
        Console.WriteLine("Falso y verdadero:" & (F Or V))
        Console.WriteLine("Falso y falso: " & (F Or F))

    End Sub
End Module
