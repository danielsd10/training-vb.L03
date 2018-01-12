Module MainModule

    '------
    'Clases
    '------
    Public Contactos As List(Of Contacto)

    Sub Main()
        Dim Tecla As ConsoleKeyInfo
        Contactos = New List(Of Contacto)

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
                    ListarContactos()
                Case ConsoleKey.F2
                    AgregarContacto()
                Case ConsoleKey.F3
                    'ModificarContacto()
                Case ConsoleKey.F5
                    'EliminarContacto()
                Case ConsoleKey.F6
                    EliminarTodosContactos()
                Case ConsoleKey.F12
                    Salir()
                Case Else
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine("Opción incorrecta.")
            End Select
        Loop

    End Sub

    Sub ListarContactos()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("." & Strings.StrDup(74, "-"c) & ".")
        Console.WriteLine(" |{0,-10}|{1,-10}|{2,-8}|{3,-10}|{4,-10}|{5,-10}|{6,-10}|", "Nombre", "Apellido", "DNI", "Fecha Nac.", "Dirección", "Telefono", "Correo")

        'iterar colección Contacto
        For Each c As Contacto In Contactos
            Console.WriteLine(" |" & Strings.StrDup(74, "-"c) & "|")

            Console.WriteLine(" |" &
            String.Format("{0,-10}|{1,-10}|{2,-8}|{3,-10}|{4,-10}|{5,-10}|{6,-10}",
                            c.Nombre,
                            c.Apellido,
                            c.DNI,
                            c.FechaNacimiento.ToString("dd/MM/yyyy"),
                            c.Direccion,
                            c.Telefono,
                            c.Correo) &
            "|")
        Next

        Console.WriteLine(" `" & Strings.StrDup(74, "-"c) & "´")
    End Sub

    Sub AgregarContacto()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Ingresar nuevo contacto")
        Console.ForegroundColor = ConsoleColor.Gray

        'crear un nuevo objeto Contacto
        Dim NuevoContacto As New Contacto()
        Console.Write("Nombre    :")
        NuevoContacto.Nombre = Console.ReadLine()
        Console.Write("Apellido  :")
        NuevoContacto.Apellido = Console.ReadLine()
        Console.Write("DNI       :")
        NuevoContacto.DNI = Console.ReadLine()
        Console.Write("Fecha Nac.:")
        NuevoContacto.FechaNacimiento = DateTime.Parse(Console.ReadLine())
        Console.Write("Dirección :")
        NuevoContacto.Direccion = Console.ReadLine()
        Console.Write("Telefono  :")
        NuevoContacto.Telefono = Console.ReadLine()
        Console.Write("Correo    :")
        NuevoContacto.Correo = Console.ReadLine()

        'agregar nuevo objeto a colección
        Contactos.Add(NuevoContacto)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Se agregó un nuevo contacto. Tiene {0} contacto(s)", Contactos.Count)
    End Sub

    Sub SolicitarIndice()

    End Sub

    Sub ModificarContacto(Indice As Integer)

    End Sub

    Sub EliminarContacto(Indice As Integer)

    End Sub

    Sub EliminarTodosContactos()
        Dim Tecla As ConsoleKeyInfo
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("¿Está seguro que desea eliminar todos los contactos?")
        Console.WriteLine("Presione Enter para confirmar.")
        Tecla = Console.ReadKey()
        If Tecla.Key = ConsoleKey.Enter Then
            Contactos.Clear()
            Console.WriteLine("Contactos eliminados.")
        End If
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
