Module Publico
    Public idioma, opcion, conexion As Integer
    Public adm_establecimiento, adm_sistema, agregar, alimento, anestro, auxiliar, animal, buscar, campo, cantidad, capacidad, CI, consultar, contraseña, division, eliminar, enlistar, etapa, fecha_ida, fecha_vuelta, _
        fechaF, fechaI, ganado_max, gerente, guardar, hectareas, hembra, ingresar, iniciar, lactancia, lugar, macho, modificar, nacimiento, ninguno, nombre, novillo, numero, _
        ordeñe, puesto, personal, preñada, raza, rodeo, salir, seca, serie, servicio, sesion, sexo, tambo, ternera, toro, usuario, vaca, tanque, ternero, tipo, vaquillona, venta, sql As String

    Public CN As New adodb.connection
    Public rs As New adodb.recordset


    Public Sub Boton_idioma(btnOpcion As Button)
        Select Case opcion
            Case 0
                btnOpcion.Text = ingresar
            Case 1
                btnOpcion.Text = modificar
            Case 2
                btnOpcion.Hide()
            Case 3
                btnOpcion.Text = eliminar
        End Select
    End Sub
    Public Sub Variables_asignacion()
        anestro = "Anestro"
        tambo = "Tambo"
        Select Case idioma
            Case 0
                adm_establecimiento = "Adm. de establecimiento"
                adm_sistema = "Adm. de sistema"
                agregar = "Agregar"
                alimento = "Food"
                auxiliar = "Auxiliar"
                animal = "Animal"
                buscar = "Buscar"
                campo = "Campo de recria"
                cantidad = "Cantidad"
                capacidad = "Capacidad"
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
                gerente = "Gerente"
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
                tanque = "Tanque"
                ternero = "Ternero"
                tipo = "Tipo"
                vaquillona = "Vaquillona"
                venta = "Venta"
            Case 1
                adm_establecimiento = "Establishment manager"
                adm_sistema = "System Mananger"
                agregar = "Add"
                alimento = "Food"
                auxiliar = "Auxiliary"
                animal = "Animal"
                buscar = "Search"
                campo = "Field of breeding"
                cantidad = "Amount"
                capacidad = "Capacity"
                CI = "Identity Card"
                consultar = "Consult"
                contraseña = "Password"
                division = "Division"
                eliminar = "Remove"
                enlistar = "Show"
                etapa = "Stage"
                fecha_ida = "Date (way)"
                fecha_vuelta = "Date (back)"
                fechaF = "End date"
                fechaI = "Starting date"
                ganado_max = "Maximum livestock"
                gerente = "Manager"
                guardar = "Save"
                hectareas = "Hectares"
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
                novillo = "Steer"
                numero = "Number"
                ordeñe = "Milking"
                puesto = "Permissions"
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
                tanque = "Tank"
                ternera = "Veal"
                toro = "Bull"
                usuario = "User"
                vaca = "Cow"
                ternero = "Calf"
                tipo = "Tipo"
                vaquillona = "Heifer"
                venta = "Sells"
            Case 2
                adm_establecimiento = "Gerente de establecimiento"
                adm_sistema = "Administrador do sistema"
                agregar = "Adicionar"
                alimento = "Alimento"
                auxiliar = "Auxiliar"
                animal = "Comida"
                buscar = "Pesquisa"
                campo = "Campo"
                cantidad = "Cantidad"
                capacidad = "Capacidad"
                CI = "carteira de identidade"
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
                gerente = "Gerente"
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
                puesto = "Permissões"
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
                tanque = "Tanque"
                toro = "Toro"
                usuario = "Usuario"
                vaca = "Vaca"
                ternero = "Ternero"
                tipo = "Tipo"
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
