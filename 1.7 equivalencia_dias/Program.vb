Imports System

Module equivalencia_dias
    Sub Main(args As String())
        Const dias As Integer = 7
        Const horas As Integer = 24
        Const minutos As Integer = 60
        Dim x As Integer



        Console.WriteLine("Ingrese un numero cualquiera: ")
        x = Console.Read()
        x = (x / 7)
        x = (dias - (horas * minutos) / 24)

        Console.WriteLine("dias: ", x)
        Console.WriteLine("horas: ", x)






    End Sub
End Module
