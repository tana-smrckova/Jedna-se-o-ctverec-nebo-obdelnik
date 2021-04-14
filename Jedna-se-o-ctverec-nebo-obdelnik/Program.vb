Imports System

Module Program
    Sub Main()
        Console.WriteLine("Podle délky strany program urèí, zda se jedná o ètverec nebo obdélník.")
        Console.Write("Zadej délku strany A: ")
        Dim a = Console.ReadLine()
        Console.Write("Zadej délku strany B: ")
        Dim b = Console.ReadLine()

        If a = b Then
            Console.WriteLine("Délky stran jsou shodné - " & a & " a " & b & ", jedná se o ètverec.")
        Else
            Console.WriteLine("Délky stran nejsou shodné - " & a & " a " & b & ", jedná se o obdélník.")
        End If

        Main()

    End Sub
End Module
