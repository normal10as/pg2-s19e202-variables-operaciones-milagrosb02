Imports System

Module variables_tipos
    Sub Main(args As String())
        Dim nombre As String = "Milagros"

        Dim dni As UInteger = 42466325

        Dim lugarnacimiento As String = "Posadas"

        Dim fechanacimiento As Date = "02/03/2000"

        Dim altura As Byte = 1.67

        Dim argentino As Boolean = True

        Dim temp As Double = 28

        Dim calle As String = "Rivadavia"

        Dim distancia As UShort = 750.4

        Dim profundidad As UShort = 3.9

        Dim habitantes As Decimal = 1175000.0

        Dim peso As Decimal = 1.4

        Dim monto As Decimal = 14.99

        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("DNI: " & dni)
        Console.WriteLine("Lugar de nacimiento: " & lugarnacimiento)
        Console.WriteLine("Fecha de nacimiento: " & fechanacimiento)
        Console.WriteLine("Altura: " & altura)
        Console.WriteLine("Argentino: " & argentino)
        Console.WriteLine("Temperatura de ambiente: " & temp)
        Console.WriteLine("Nombre de calle: " & calle)
        Console.WriteLine("Distancia entre Florianopolis y Rio de Janeiro: " & distancia)
        Console.WriteLine("Profundidad del mar: " & profundidad)
        Console.WriteLine("Cantidad de habitantes en Misiones: " & habitantes)
        Console.WriteLine("Peso de una lata de de arvejas: " & peso)
        Console.WriteLine("Monto de cereales: " & monto)

        Console.ReadLine()
    End Sub
End Module
