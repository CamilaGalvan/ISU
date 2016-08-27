Public Class frmISU

    Private Sub frmISU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbxPass.Text() = ""
        tbxUser.Text() = ""
        Publico.idioma = 0
        gbxLog.Hide()
        cbxTambo.Hide()
    End Sub

    Sub Permiso(ByVal Usuario As String)
        If CN.State <> 1 Then
            MsgBox(conexion)
        Else
            sql = "select cargo from persona where login ='" & tbxUser.Text & "'"
            Open_sql()

            If rs.RecordCount() = 0 Then
                MsgBox("Error :" + Usuario)
            Else
                cbxTambo.Show()
                pnlInicio.Hide()
                pnlBlue.Show()
                tsConsultar.Text = consultar
                tsModificar.Text = modificar
                tsIngresar.Text = ingresar
                tsEnlistar.Text = enlistar
                tsEliminar.Text = eliminar
                tsAlimento.Text = alimento
                tsOtorgar.Text = otorgar
                tsProporcionar.Text = almacenar
                tsControl.Text = control
                tsTamboIngresar.Text = ingresar
                tsTamboModificar.Text = modificar
                tsTamboConsultar.Text = consultar
                tsTamboEiminar.Text = eliminar
                tsPersonalIngresar.Text = ingresar
                tsPersonalModificar.Text = modificar
                tsPersonalConsultar.Text = consultar
                tsPersonalEliminar.Text = eliminar
                tsVaca.Text = vaca
                tsVaquillona.Text = vaquillona
                tsToro.Text = toro
                tsNovillo.Text = novillo
                TsAnestro.Text = anestro
                tsTernero.Text = ternero
                tsTernera.Text = ternera
                tsRodeo.Text = rodeo
                tsCampo.Text = campo
                tsNinguno.Text = ninguno
                TsServicio.Text = servicio
                tsNinguno2.Text = ninguno
                Tsprenada.Text = preñada
                tsLactancia.Text = lactancia
                tsSeca.Text = seca
                tsHembra.Text = hembra
                tsMacho.Text = macho
                tsRaza.Text = raza
                tsDivision.Text = division
                tsLugar.Text = lugar
                tsEtapa.Text = etapa
                tsSexo.Text = sexo
                tsGanadoAct.Text = ganado_act
                tsAntibiotico.Text = antibiotico
                tsConfiguración.Text = configuracion
                tsPrimerOrdeñe.Text = primer + " " + ordeñe
                tsSegundoOrdeñe.Text = primer + " " + ordeñe
                tsTercerOrdeñe.Text = primer + " " + ordeñe

                Select Case rs(0).Value
                    Case auxiliar
                        tsAnimal.Enabled = True
                        tsEliminar.Enabled = False
                        tsAlimento.Enabled = True
                        tsSesion.Enabled = True
                        tsOrdeñe.Enabled = True
                        tsEnlistar.Enabled = True
                        cbxTambo.Enabled = False
                    Case adm_establecimiento
                        tsTambo.Enabled = True
                        tsPersonal.Enabled = True
                        tsPersonalEliminar.Enabled = False
                        tsPersonalIngresar.Enabled = False
                        tsAnimal.Enabled = True
                        tsAlimento.Enabled = True
                        tsSesion.Enabled = True
                        tsOrdeñe.Enabled = True
                        tsEnlistar.Enabled = True
                        tsVenta.Enabled = True
                        cbxTambo.Enabled = False
                    Case gerente
                        tsTambo.Enabled = True
                        tsPersonal.Enabled = True
                        tsPersonalEliminar.Enabled = False
                        tsPersonalIngresar.Enabled = False
                        tsAnimal.Enabled = True
                        tsAlimento.Enabled = True
                        tsSesion.Enabled = True
                        tsOrdeñe.Enabled = True
                        tsEnlistar.Enabled = True
                        tsVenta.Enabled = True
                    Case adm_sistema
                        tsTambo.Enabled = True
                        tsPersonal.Enabled = True
                        tsAnimal.Enabled = True
                        tsAlimento.Enabled = True
                        tsSesion.Enabled = True
                        tsOrdeñe.Enabled = True
                        tsEnlistar.Enabled = True
                        tsVenta.Enabled = True
                End Select
                rs.Close()
                sql = "select t.nombre from tambo t, personal p, tiene te where t.serie=te.serie and p.ci=te.ci and p.login='" & tbxUser.Text & "'"

            End If
            Open_sql()
            If rs.RecordCount <> 0 Then
                cbxTambo.Text = rs(0).Value
                rs.Close()
                sql = "Select t.serie from tambo t, tiene e, persona p where hestablecimiento='" & cbxTambo.Text & "' and e.serie=t.serie and p.ci=e.ci and p.login='" & tbxUser.Text & "'"
                Open_sql()
                TSERIE = rs(0).Value
                rs.Close()
                sql = "select hestablecimiento from tambo"
                Open_sql()
                While Not rs.EOF()
                    cbxTambo.Items.Add(rs(0).Value)
                    rs.MoveNext()
                End While
                rs.Close()
            End If
        End If
    End Sub

    Public Sub Open_sql()
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error open", MsgBoxStyle.OkOnly, "ERROR")
        End Try
    End Sub

    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
        Try
            CN.Open("MIODBC", tbxUser.Text, tbxPass.Text)
            conexion = 1
        Catch ex As Exception
            MsgBox("Error :" + usuario + " / " + contraseña)
            Exit Sub
        End Try
        CN.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        conexion = 1
        If conexion = 1 Then
            Permiso(tbxUser.Text)
        End If
    End Sub

    Private Sub tsSesion_Click(sender As System.Object, e As System.EventArgs) Handles tsSesion.Click
        pnlInicio.Show()
        pnlBlue.Hide()
        frmISU_Load(sender, e)
    End Sub

    Private Sub cbxIdioma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxIdioma.SelectedIndexChanged
        If cbxIdioma.Text = "English" Then
            idioma = 1
        ElseIf cbxIdioma.Text = "Português" Then
            idioma = 2
        Else
            idioma = 0
        End If
        gbxLog.Show()
        btnInicio.Enabled = True
        Variables_asignacion()

        Lblpass.Text = contraseña
        lblUser.Text = usuario
        btnInicio.Text = iniciar
        tsSalir.Text = salir
        tsSesion.Text = sesion
        tsTambo.Text = tambo
        tsPersonal.Text = personal
        tsAnimal.Text = animal
        tsAlimento.Text = alimento
        tsSesion.Text = sesion
        tsOrdeñe.Text = ordeñe
        tsEnlistar.Text = enlistar
        tsVenta.Text = venta
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub

    Private Sub tsTamboEiminar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboEiminar.Click
        opcion = 3
        frmTambo.Show()
    End Sub

    Private Sub tsTamboModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboModificar.Click
        opcion = 1
        frmTambo.Show()
    End Sub

    Private Sub tsTamboConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboConsultar.Click
        opcion = 2
        frmTambo.Show()
    End Sub

    Private Sub tsTamboIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboIngresar.Click
        opcion = 0
        frmTambo.Show()
    End Sub

    Private Sub tsPersonalModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalModificar.Click
        opcion = 1
        frmPersonal.Show()
    End Sub

    Private Sub tsPersonalConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalConsultar.Click
        opcion = 2
        frmPersonal.Show()
    End Sub

    Private Sub tsPersonalEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalEliminar.Click
        opcion = 3
        frmPersonal.Show()
    End Sub

    Private Sub tsIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsIngresar.Click
        opcion = 0
        frmAnimal.Show()
    End Sub
    Private Sub tsConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsConsultar.Click
        opcion = 2
        frmAnimal.Show()
    End Sub

    Private Sub tsModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsModificar.Click
        opcion = 1
        frmAnimal.Show()
    End Sub

    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        opcion = 3
        frmAnimal.Show()
    End Sub

    Private Sub tsControl_Click(sender As System.Object, e As System.EventArgs) Handles tsControl.Click
        frmControl.Show()
    End Sub
    Private Sub tsAlimento_Click(sender As System.Object, e As System.EventArgs)
        opcion = 0
        frmAlimento.Show()
    End Sub

    Private Sub tsHolando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHolando.Click
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra from animal, hay h where raza= Holando and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsJersey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsJersey.Click
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra from animal, hay h where raza= Jersey and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsPrimerShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrimerShow.Click
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal where raza= Primer Show and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsVaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsVaca.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & preñada & "' and e.num=estado.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsVaquillona_Click(sender As System.Object, e As System.EventArgs) Handles tsVaquillona.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & preñada & "' and e.num=estado.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        opcion = 10
        frmEnlistar.Show()
    End Sub

    Private Sub tsToro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsToro.Click
        sql = "select  m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from macho m, animal a, hay h where castrado=0 and a.num=m.num and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsNovillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNovillo.Click
        sql = "select  m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra  from macho m, animal, hay h a where castrado=1 and a.num=m.num and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub TsAnestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsAnestro.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & anestro & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsTernero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTernero.Click
        sql = "select  c.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, cria c, hay y where c.num=a.num and sexo='" & macho _
            & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsTernera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTernera.Click
        sql = "select  c.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, cria c, hay y where c.num=a.num and sexo='" & hembra _
            & " and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsRodeo_Click(sender As System.Object, e As System.EventArgs) Handles tsRodeo.Click
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & rodeo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsCampo_Click(sender As System.Object, e As System.EventArgs) Handles tsCampo.Click
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & campo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsTamboe_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboe.Click
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & tambo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno.Click
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & ninguno & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub TsServicio_Click(sender As System.Object, e As System.EventArgs) Handles TsServicio.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, animal, hay y a where" + _
        "h.num = p.animal_num And e.nombre = '" & servicio & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub Tsprenada_Click(sender As System.Object, e As System.EventArgs) Handles Tsprenada.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & preñada & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsLactancia_Click(sender As System.Object, e As System.EventArgs) Handles tsLactancia.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & lactancia & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsSeca_Click(sender As System.Object, e As System.EventArgs) Handles tsSeca.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & seca & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno2_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno2.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & ninguno & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsHembra_Click(sender As System.Object, e As System.EventArgs) Handles tsHembra.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, hay y, animal a where h.num = a.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsMacho_Click(sender As System.Object, e As System.EventArgs) Handles tsMacho.Click
        sql = "select m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from macho m, hay y, animal a where m.num = a.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsGanadoAct_Click(sender As System.Object, e As System.EventArgs) Handles tsGanadoAct.Click
        sql = "Select  a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where activo = 1 and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsAntibiotico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAntibiotico.Click
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, animal a, hay y where" + _
        "h.num = a.num And e.nombre = '" & antibiotico & "' and e.num=estado.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsAlimento_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAlimento_Consultar.Click
        frmEnlistar.Show()
    End Sub

    Private Sub tsConfiguracio_Click(sender As System.Object, e As System.EventArgs) Handles tsConfiguración.Click
        frmOrdeñeConfig.Show()
    End Sub

    Private Sub tsPrimerOrdeñe_Click(sender As System.Object, e As System.EventArgs) Handles tsPrimerOrdeñe.Click
        frmOrdeñe.Show()
    End Sub

    Private Sub tsSegundoOrdeñe_Click(sender As System.Object, e As System.EventArgs) Handles tsSegundoOrdeñe.Click
        frmOrdeñe.Show()
    End Sub

    Private Sub tsTercerOrdeñe_Click(sender As System.Object, e As System.EventArgs) Handles tsTercerOrdeñe.Click
        frmOrdeñe.Show()
    End Sub

    Private Sub tsPersonalIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalIngresar.Click
        opcion = 0
        frmPersonal.Show()
    End Sub

    Private Sub tsVenta_Click(sender As System.Object, e As System.EventArgs) Handles tsVenta.Click
        opcion = 4
        frmAlimento.Show()
    End Sub

    Private Sub tsProporcionar_Click(sender As System.Object, e As System.EventArgs) Handles tsProporcionar.Click
        opcion = 0
        frmAlimento.Show()
    End Sub

    Private Sub tsOtorgar_Click(sender As System.Object, e As System.EventArgs) Handles tsOtorgar.Click
        opcion = 1
        frmAlimento.Show()
    End Sub

    Private Sub tsAlimentoIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsAlimentoIngresar.Click
        opcion = 2
        frmAlimento.Show()
    End Sub
End Class
