Module MainModule

    '------
    'Clases
    '------
    Public Contactos As List(Of Contacto)

    Sub Main()
        Dim Tecla As ConsoleKeyInfo

        ' colocar en un bucle hasta que el usuario decida salir.
        Do
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("Elija una opción:")
            Console.WriteLine("F1. Ver contactos")
            Console.WriteLine("F2. Agregar contacto")
            Console.WriteLine("F3. Editar contacto")
            Console.WriteLine("F5. Eliminar contacto")
            Console.WriteLine("F6. Eliminar todos los contactos")
            Console.WriteLine("F12. Salir")
            Tecla = Console.ReadKey()
            Select Case Tecla.Key
                Case ConsoleKey.F1
                Case ConsoleKey.F2
                Case ConsoleKey.F3
                Case ConsoleKey.F5
                Case ConsoleKey.F6
                Case ConsoleKey.F12
                    Salir()
                Case Else
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine("Opción incorrecta.")
            End Select
        Loop

    End Sub

    Sub Salir()
        Dim Tecla As ConsoleKeyInfo
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("¿Está seguro que desea salir?")
        Console.WriteLine("Presione Enter para confirmar.")
        Tecla = Console.ReadKey()
        If Tecla.Key = ConsoleKey.Enter Then
            End
        End If
    End Sub

End Module
