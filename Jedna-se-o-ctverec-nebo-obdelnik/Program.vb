Imports System

Module Program
    Sub Main()
        Console.WriteLine("Podle d�lky strany program ur��, zda se jedn� o �tverec nebo obd�ln�k.")
        Console.Write("Zadej d�lku strany A: ")
        Dim a = Console.ReadLine()
        Console.Write("Zadej d�lku strany B: ")
        Dim b = Console.ReadLine()

        If a = b Then
            Console.WriteLine("D�lky stran jsou shodn� - " & a & " a " & b & ", jedn� se o �tverec.")
        Else
            Console.WriteLine("D�lky stran nejsou shodn� - " & a & " a " & b & ", jedn� se o obd�ln�k.")
        End If

        Main()

    End Sub
End Module
