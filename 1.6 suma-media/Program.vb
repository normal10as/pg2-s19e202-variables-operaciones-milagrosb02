Imports System

Module suma_promedio

    Sub Main(args As String())
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim num4 As Integer
        Dim suma As Integer
        Dim media As Integer

        Console.WriteLine("Ingrese primer numero: ")
        num1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese segundo numero: ")
        num2 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese tercer numero: ")
        num3 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese cuarto numero: ")
        num4 = Convert.ToInt32(Console.ReadLine())

        suma = num1 + num2 + num3 + num4
        media = suma / 4

        Console.WriteLine("La sumatoria de los numeros ingresados es: " & suma)
        Console.WriteLine("La media de los numeros ingresados es: " & media)

    End Sub
End Module
