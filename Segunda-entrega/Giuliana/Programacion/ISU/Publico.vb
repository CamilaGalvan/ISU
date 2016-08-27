Module Publico
    Public idioma, opcion As Integer
    Public alimento, anestro, auxiliar, animal, buscar, campo, cantidad, CI, consultar, contraseña, division, eliminar, enlistar, etapa, fecha_ida, fecha_vuelta As String
    Public fechaF, fechaI, ganado_max, guardar, hectareas, hembra, ingresar, iniciar, lactancia, lugar, macho, modificar, nacimiento, ninguno, nombre, novillo, numero As String
    Public ordeñe, puesto, personal, preñada, raza, rodeo, salir, seca, serie, servicio, sesion, sexo, tambo, ternera, toro, usuario, vaca, ternero, vaquillona, venta As String

    Public Sub Boton_idioma(btnOpcion As Button)
        Select Case opcion
            Case 0
                btnOpcion.Text = ingresar
            Case 1
                btnOpcion.Text = modificar
            Case 2
                btnOpcion.Text = consultar
            Case 3
                btnOpcion.Text = eliminar
            Case 4
                btnOpcion.Text = guardar
        End Select
    End Sub
    Public Sub Variables_asignacion()
        anestro = "Anestro"
        tambo = "Tambo"
        Select Case idioma
            Case 0
                alimento = "Food"
                auxiliar = "Auxiliar"
                animal = "Animal"
                buscar = "Search"
                campo = "Campo de recria"
                cantidad = "Cantidad"
                CI = "Cedula de identidad"
                consultar = "Consultar"
                contraseña = "Contraseña"
                division = "Division"
                eliminar = "Eliminar"
                enlistar = "Enlistar"
                etapa = "Etapa"
                fecha_ida = "Fecha (ida)"
                fecha_vuelta = "Fecha (vuelta)"
                fechaF = "Fecha fin"
                fechaI = "Fecha inicio"
                ganado_max = "Ganado máximo"
                guardar = "Guardar"
                hectareas = "Hectareas"
                hembra = "Hembra"
                ingresar = "Ingresar"
                iniciar = "Iniciar"
                lactancia = "Lactancia"
                lugar = "Lugar"
                macho = "Macho"
                modificar = "Modificar"
                nacimiento = "Nacimiento"
                ninguno = "Ninguno"
                nombre = "Nombre"
                novillo = "Novillo"
                numero = "Numero"
                ordeñe = "Ordeñe"
                puesto = "Puesto"
                personal = "Personal"
                preñada = "Preñada"
                raza = "Raza"
                rodeo = "Rodeo"
                salir = "Salir"
                seca = "Seca"
                serie = "Serie"
                servicio = "Servicio"
                sesion = "Sesion"
                sexo = "Sexo"
                tambo = "Tambo"
                ternera = "Ternera"
                toro = "Toro"
                usuario = "Usuario"
                vaca = "Vaca"
                ternero = "Ternero"
                vaquillona = "Vaquillona"
                venta = "Venta"
            Case 1
                alimento = "Alimento"
                auxiliar = "Auxiliar"
                animal = "Animal"
                buscar = "Buscar"
                campo = "Field of breeding"
                cantidad = "Amount"
                CI = "Identity Card"
                consultar = "Consult"
                contraseña = "Password"
                division = "Division"
                eliminar = "Remove"
                enlistar = "Show"
                etapa = "Stage"
                fecha_ida = "breeding field (going)"
                fecha_vuelta = "breeding field (coming)"
                fechaF = "Fecha fin"
                fechaI = "Fecha inicio"
                ganado_max = "Ganado máximo"
                guardar = "Save"
                hectareas = "Hectareas"
                hembra = "Female"
                ingresar = "Insert"
                iniciar = "Login"
                lactancia = "Lactation"
                lugar = "Place"
                macho = "Male"
                modificar = "Modify"
                nacimiento = "Birth"
                ninguno = "None"
                nombre = "Name"
                novillo = "steer"
                numero = "Number"
                ordeñe = "Ordeñe"
                puesto = "Puesto"
                personal = "Personal"
                preñada = "Pregnant"
                raza = "Race"
                rodeo = "breeding herd"
                salir = "Exit"
                seca = "Dry"
                serie = "Serie"
                servicio = "Service"
                sesion = "Log out"
                sexo = "Gender"
                ternera = "Veal"
                toro = "Bull"
                usuario = "User"
                vaca = "Cow"
                ternero = "Calf"
                vaquillona = "Heifer"
                venta = "Sells"
            Case 2
                alimento = "Alimento"
                auxiliar = "Auxiliar"
                animal = "Animal"
                buscar = "Buscar"
                campo = "Campo"
                cantidad = "Cantidad"
                CI = "Cedula de identidad"
                consultar = "Consultar"
                contraseña = "Contraseña"
                division = "Division"
                eliminar = "Eliminar"
                enlistar = "Enlistar"
                etapa = "Etapa"
                fecha_ida = "Fecha (ida)"
                fecha_vuelta = "Fecha (vuelta)"
                fechaF = "Fecha fin"
                fechaI = "Fecha inicio"
                ganado_max = "Ganado máximo"
                guardar = "Guardar"
                hectareas = "Hectareas"
                hembra = "Hembra"
                ingresar = "Ingresar"
                iniciar = "Iniciar"
                lactancia = "Lactancia"
                lugar = "Lugar"
                macho = "Macho"
                modificar = "Modificar"
                nacimiento = "Nacimiento"
                ninguno = "Ninguno"
                nombre = "Nombre"
                novillo = "Novillo"
                numero = "Numero"
                ordeñe = "Ordeñe"
                puesto = "Puesto"
                personal = "Personal"
                preñada = "Preñada"
                raza = "Raza"
                rodeo = "Rodeo"
                salir = "Salir"
                seca = "Seca"
                serie = "Serie"
                servicio = "Servicio"
                sesion = "Sesion"
                sexo = "Sexo"
                tambo = "Tambo"
                ternera = "Ternera"
                toro = "Toro"
                usuario = "Usuario"
                vaca = "Vaca"
                ternero = "Ternero"
                vaquillona = "Vaquillona"
                venta = "Venta"
        End Select
    End Sub
    Function Validacion_numerica(ByVal valor As String, acum As Integer) As Integer
        Dim retorno As Integer

        If IsNumeric(valor) Then
            If valor >= 0 Then
                retorno = acum
            Else
                retorno = acum + 1
            End If
        Else
            retorno = acum + 1
        End If
        Return retorno
    End Function
    Function Validacion_largo(ByVal tbxX As TextBox, acum As Integer) As Integer
        Dim retorno As Integer
        If IsNumeric(tbxX.Text()) Then
            If tbxX.MaxLength() = tbxX.TextLength() Then
                retorno = acum
            Else
                retorno = acum + 1
            End If
        Else
            retorno = acum + 1
        End If
        Return retorno
    End Function
End Module
