﻿Public Class frmISU

    Private Sub frmISU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbxPass.Text() = ""
        tbxUser.Text() = ""
        Publico.idioma = 0
        gbxLog.Hide()
    End Sub

    Sub Permisos(ByVal Usuario As String)
        If CN.State <> 1 Then
            MsgBox("La conexión con la base de datos esta abierta", "ERROR")
        Else
            sql = "Select cargo from persona where usuario ='" & Usuario & "'"
            Try
                rs.Open(sql, CN)
            Catch ex As Exception
                MsgBox("Error :" + puesto, "ERROR")
                Exit Sub
            End Try
            If rs.RecordCount() = 0 Then
                MsgBox("Error :" + Usuario + " / " + puesto, "ERROR")
            Else
                       Select rs(0).Value
                    Case "Auxiiar"
                    Case ""
                    Case ""
                End Select
            End If
        End If
    End Sub
    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
        'Try
        'CN.Open("MIODBC", tbxUser.Text, tbxPass.Text)
        'conexion = 1
        'Catch ex As Exception
        'MsgBox("Error :" + usuario + " / " + contraseña)
        'Exit Sub
        'End Try
        CN.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        conexion = 1
        If conexion = 1 Then
            pnlInicio.Hide()
            pnlBlue.Show()
            tsTambo.Enabled = True
            tsPersonal.Enabled = True
            tsAnimal.Enabled = True
            tsAlimento.Enabled = True
            tsSesion.Enabled = True
            tsOrdeñe.Enabled = True
            tsEnlistar.Enabled = True
            tsVenta.Enabled = True
            tsConsultar.Text = consultar
            tsModificar.Text = modificar
            tsIngresar.Text = ingresar
            tsEnlistar.Text = enlistar
            tsEliminar.Text = eliminar
            tsAlimento.Text = alimento
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

    Private Sub tsHolando_Click(sender As System.Object, e As System.EventArgs) Handles tsHolando.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsJersey_Click(sender As System.Object, e As System.EventArgs) Handles tsJersey.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsPrimerShow_Click(sender As System.Object, e As System.EventArgs) Handles tsPrimerShow.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsVaca_Click(sender As System.Object, e As System.EventArgs) Handles tsVaca.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsVaquillona_Click(sender As System.Object, e As System.EventArgs) Handles tsVaquillona.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsToro_Click(sender As System.Object, e As System.EventArgs) Handles tsToro.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsNovillo_Click(sender As System.Object, e As System.EventArgs) Handles tsNovillo.Click

        frmEnlistar.Show()
    End Sub

    Private Sub TsAnestro_Click(sender As System.Object, e As System.EventArgs) Handles TsAnestro.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsTernero_Click(sender As System.Object, e As System.EventArgs) Handles tsTernero.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsTernera_Click(sender As System.Object, e As System.EventArgs) Handles tsTernera.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsRodeo_Click(sender As System.Object, e As System.EventArgs) Handles tsRodeo.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsCampo_Click(sender As System.Object, e As System.EventArgs) Handles tsCampo.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsTamboe_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboe.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno.Click

        frmEnlistar.Show()
    End Sub

    Private Sub TsServicio_Click(sender As System.Object, e As System.EventArgs) Handles TsServicio.Click

        frmEnlistar.Show()
    End Sub

    Private Sub Tsprenada_Click(sender As System.Object, e As System.EventArgs) Handles Tsprenada.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsLactancia_Click(sender As System.Object, e As System.EventArgs) Handles tsLactancia.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsSeca_Click(sender As System.Object, e As System.EventArgs) Handles tsSeca.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno2_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno2.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsHembraa_Click(sender As System.Object, e As System.EventArgs)

        frmEnlistar.Show()
    End Sub

    Private Sub tsHembra_Click(sender As System.Object, e As System.EventArgs) Handles tsHembra.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsMacho_Click(sender As System.Object, e As System.EventArgs) Handles tsMacho.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsGanadoAct_Click(sender As System.Object, e As System.EventArgs) Handles tsGanadoAct.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsAntibiotico_Click(sender As System.Object, e As System.EventArgs) Handles tsAntibiotico.Click

        frmEnlistar.Show()
    End Sub

    Private Sub tsConfiguracio_Click(sender As System.Object, e As System.EventArgs) Handles tsConfiguración.Click
        frmOrdeñeConfig.Show()
    End Sub

    Private Sub tsPrimerOrdeñe_Click(sender As System.Object, e As System.EventArgs) Handles tsPrimerOrdeñe.Click
        frmOrdeñe.Show()
        opcion = 1
    End Sub

    Private Sub tsSegundoOrdeñe_Click(sender As System.Object, e As System.EventArgs) Handles tsSegundoOrdeñe.Click
        frmOrdeñe.Show()
        opcion = 2
    End Sub

    Private Sub tsTercerOrdeñe_Click(sender As System.Object, e As System.EventArgs) Handles tsTercerOrdeñe.Click
        frmOrdeñe.Show()
        opcion = 3
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
        opcion = 5
        frmAlimento.Show()
    End Sub

    Private Sub tsAlimento_Consultar_Click(sender As System.Object, e As System.EventArgs) Handles tsAlimento_Consultar.Click
        frmEnlistar.Show()
    End Sub

End Class

'53krinder