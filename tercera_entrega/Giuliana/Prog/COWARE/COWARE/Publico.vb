Module Publico
    Public idioma, opcion, conexion As Integer
    Public adm_establecimiento, adm_sistema, agregar, alimento, anestro, auxiliar, animal, antibiotico, buscar, campo, cantidad, capacidad, CI, configuracion, consultar, contrasenia, control, division, eliminar, enlistar, etapa, _
        fecha, fecha_ida, fecha_vuelta, fechaF, fechaI, ganado_act, ganado_max, gerente, guardar, hectareas, hembra, hora, ingresar, iniciar, lactancia, litros, lugar, macho, modificar, nacimiento, ninguno, nombre, novillo, numero, _
        ordenie, peso, puesto, personal, preniada, primer, raza, rodeo, salir, seca, segundo, serie, servicio, sesion, sexo, tambo, ternera, toro, usuario, tanque, tercero, ternero, tipo, vaca, vacuna, vaquillona, venta, sql, _
        turno, grasa, proteina, urea, rec_bacteriano, rec_celulas, num_lote, lote, inicio, fin, consumoe, consumoi, otorgar, almacenar, telefono, TSERIE, clima As String
    Public CN As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Public Sub Boton_idioma(btnOpcion As Button)
        Select Case opcion
            Case 0
                btnOpcion.Text = ingresar
            Case 1
                btnOpcion.Text = modificar
            Case 2
                btnOpcion.Text = consultar
                btnOpcion.Hide()
            Case 3
                btnOpcion.Text = eliminar
        End Select
    End Sub

    Public Sub execute_sql()
        Try
            CN.Execute(sql)
        Catch ex As Exception
            MsgBox("Error Execute")
            Exit Sub
        End Try
    End Sub
    Public Sub Open_sql()
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error open", MsgBoxStyle.OkOnly, "ERROR")
        End Try
    End Sub

    Public Sub Variables_asignacion()
        anestro = "Anestro"
        tambo = "Tambo"
        Select Case idioma
            Case 0
                adm_establecimiento = "Adm. de establecimiento"
                adm_sistema = "Adm. de sistema"
                agregar = "Agregar"
                alimento = "Alimento"
                auxiliar = "Auxiliar"
                animal = "Animal"
                antibiotico = "Antibiótico"
                buscar = "Buscar"
                clima = "Clima"
                campo = "Campo de recria"
                cantidad = "Cantidad"
                capacidad = "Capacidad"
                CI = "Cedula de identidad"
                configuracion = "Configuracion"
                consultar = "Consultar"
                contrasenia = "Contraseña"
                control = "Control"
                division = "Division"
                eliminar = "Eliminar"
                enlistar = "Enlistar"
                etapa = "Etapa"
                fecha = "Fecha"
                fecha_ida = "Fecha (ida)"
                fecha_vuelta = "Fecha (vuelta)"
                fechaF = "Fecha fin"
                fechaI = "Fecha inicio"
                ganado_act = "Ganado activo"
                ganado_max = "Ganado máximo"
                gerente = "Gerente"
                guardar = "Guardar"
                hectareas = "Hectareas"
                hembra = "Hembra"
                hora = "Hora"
                ingresar = "Ingresar"
                iniciar = "Iniciar"
                lactancia = "Lactancia"
                litros = "Litros"
                lugar = "Lugar"
                macho = "Macho"
                modificar = "Modificar"
                nacimiento = "Nacimiento"
                ninguno = "Ninguno"
                nombre = "Nombre"
                novillo = "Novillo"
                numero = "Numero"
                ordenie = "Ordeñe"
                peso = "Peso"
                puesto = "Puesto"
                personal = "Personal"
                preniada = "Preñada"
                primer = "Primer"
                raza = "Raza"
                rodeo = "Rodeo"
                salir = "Salir"
                seca = "Seca"
                segundo = "Segundo"
                serie = "Serie"
                servicio = "Servicio"
                sesion = "Sesion"
                sexo = "Sexo"
                tambo = "Tambo"
                ternera = "Ternera"
                toro = "Toro"
                usuario = "Usuario"
                tanque = "Tanque"
                tercero = "Tercero"
                ternero = "Ternero"
                tipo = "Tipo"
                vaca = "Vaca"
                vacuna = "Vacuna"
                vaquillona = "Vaquillona"
                venta = "Venta"
                turno = "Turno"
                grasa = "Porcentaje de grasa"
                proteina = "Porcentaje de proteina"
                urea = "Percentaje de urea"
                rec_bacteriano = "Recuento bacteriano"
                rec_celulas = "Recuento de células somáticas"
                lote = "Lote"
                num_lote = "Num. de lote"
                fecha = "Fecha"
                inicio = "inicio"
                fin = "fin"
                consumoe = "Consumo externo"
                consumoi = "Consumo interno"
                otorgar = "Otorgar"
                almacenar = "Almacenar"
                telefono = "Telefono"
            Case 1
                adm_establecimiento = "Establishment manager"
                adm_sistema = "System Mananger"
                agregar = "Add"
                alimento = "Food"
                auxiliar = "Auxiliary"
                animal = "Animal"
                antibiotico = "Antibiotic"
                buscar = "Search"
                clima = "Weather"
                campo = "Field of breeding"
                cantidad = "Amount"
                capacidad = "Capacity"
                CI = "Identity Card"
                configuracion = "Settings"
                consultar = "Consult"
                contrasenia = "Password"
                control = "Control"
                division = "Division"
                eliminar = "Remove"
                enlistar = "Show"
                etapa = "Stage"
                fecha = "Date"
                fecha_ida = "Date (way)"
                fecha_vuelta = "Date (back)"
                fechaF = "End date"
                fechaI = "Starting date"
                ganado_act = "Active cattle"
                ganado_max = "Maximum livestock"
                gerente = "Manager"
                guardar = "Save"
                hectareas = "Hectares"
                hembra = "Female"
                hora = "Time"
                ingresar = "Insert"
                iniciar = "Login"
                lactancia = "Lactation"
                litros = "Liters"
                lugar = "Place"
                macho = "Male"
                modificar = "Modify"
                nacimiento = "Birth"
                ninguno = "None"
                nombre = "Name"
                novillo = "Steer"
                numero = "Number"
                ordenie = "Milking"
                peso = "Weight"
                puesto = "Permissions"
                personal = "Staff"
                preniada = "Pregnant"
                primer = "First"
                raza = "Race"
                rodeo = "Breeding herd"
                salir = "Exit"
                seca = "Dry"
                segundo = "Second"
                serie = "Serie"
                servicio = "Service"
                sesion = "Log out"
                sexo = "Gender"
                tanque = "Tank"
                ternera = "Veal"
                toro = "Bull"
                usuario = "User"
                tercero = "Third"
                ternero = "Calf"
                tipo = "Type"
                vaca = "Cow"
                vacuna = "Vaccine"
                vaquillona = "Heifer"
                venta = "Sells"
                turno = "Shift"
                grasa = "Percentage fat"
                proteina = "Percentage protein"
                urea = "Percentage urea"
                rec_bacteriano = "bacterial count"
                rec_celulas = "Somatic cell count"
                lote = "Allotment"
                num_lote = "Num. allotment"
                fecha = "Date"
                inicio = "Initiation"
                fin = "Final"
                consumoe = "External consumption"
                consumoi = "Internal consumption"
                otorgar = "Give"
                almacenar = "Save"
                telefono = "Telephone"
            Case 2
                adm_establecimiento = " Administrador de bens"
                adm_sistema = "Administrador do sistema"
                agregar = "Adicionar"
                alimento = "Comida"
                auxiliar = " Auxiliar"
                animal = "Animal"
                buscar = "Pesquisa"
                clima = "Tempo"
                campo = "Campo da criaçâgo"
                cantidad = " Quantidade"
                capacidad = "Capacidade"
                CI = "Carteira de identidade"
                configuracion = "Configuração"
                consultar = "Consultar"
                contrasenia = "Senha"
                control = "Controle"
                division = "Divisão"
                eliminar = "Remover"
                enlistar = "Alistar"
                etapa = "Etapa"
                fecha = "Data"
                fecha_ida = "Data (ida)"
                fecha_vuelta = "Data (retorno)"
                fechaF = "Data final"
                fechaI = "Data iniciação "
                ganado_act = " Gado ativo"
                ganado_max = "Máxima de gado"
                gerente = "Gerente"
                guardar = "Salvar"
                hectareas = "Hectares"
                hembra = "Feminino"
                hora = "Tempo"
                ingresar = "Depósito"
                iniciar = "Começo"
                lactancia = "Lactação"
                litros = "Litros"
                lugar = "Lugar"
                macho = "Masculino"
                modificar = "Mudança"
                nacimiento = "Nacimento"
                ninguno = "Nenhum"
                nombre = "Nome"
                novillo = "Dirigir"
                numero = "Numero"
                ordenie = "Ordenha"
                peso = "Peso"
                puesto = "Permissões"
                personal = "Funcionários"
                preniada = "Grávida"
                primer = "Primeiro"
                raza = "Raça"
                rodeo = "Rodeio"
                salir = "Saída"
                seca = "Seca"
                segundo = " Segundo"
                serie = "Serie"
                servicio = "Serviço"
                sesion = "Sessão"
                sexo = "Sexo"
                tambo = "Tambo"
                tercero = "Terceiro"
                ternera = "Vitela F"
                toro = "Touro"
                usuario = "Usuario"
                tanque = "Tanque"
                ternero = "Vitela M"
                tipo = "Tipo"
                vaca = "Vaca"
                vacuna = "Vacina"
                vaquillona = "Novilha"
                venta = "Venda"
                turno = "Vez"
                grasa = "Percentagem gordura"
                proteina = "Percentagem  proteina"
                urea = "Percentagem  uréia"
                rec_bacteriano = "Contagem bacteriana"
                rec_celulas = "Contagem de células somáticas"
                lote = "Lote"
                num_lote = "Num. Do Lote"
                fecha = "Data"
                inicio = "Iniciação"
                fin = "Final"
                consumoe = "Consumo fora"
                consumoi = "Consumo interno"
                otorgar = "Grant"
                almacenar = "Store"
                telefono = "Telefone"

        End Select
    End Sub
    Public Function Validacion_numerica(ByVal valor As String, acum As Integer) As Integer
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

