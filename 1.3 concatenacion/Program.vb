Imports System

Module concatenacion
    Sub Main(args As String())
        Dim empresa As String = "California"
        Dim calle As String = "Lavalle"
        Dim altura As Integer = 5400

        Console.WriteLine(empresa & calle & altura)
        Console.WriteLine(Convert.ToString({empresa}))
        Console.WriteLine(Convert.ToString({calle}))
        Console.WriteLine(Convert.ToString({altura}))
    End Sub
End Module
