Public Class frmAnimal
    Private Sub frmAnimal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Boton_idioma(btnOpcion)
        btnBuscar.Text = buscar
        btnBuscarH.Text = buscar
        btnBuscarM.Text = buscar
        btnEtapa.Text = agregar
        btnEtapa_Mod.Text = modificar
        lblSexo.Text = sexo
        lblSexoH.Text = sexo
        lblSexoM.Text = sexo
        lblRecriavuelta.Text = fecha_vuelta
        lblRecriaIda.Text = fecha_ida
        lblRazaM.Text = raza
        lblRazaH.Text = raza
        lblRaza.Text = raza
        lblNumM.Text = numero
        lblNumH.Text = numero
        lblNumero.Text = numero
        lblNacimiento.Text = nacimiento
        lblLugar.Text = lugar
        lblFechaI.Text = fechaI
        lblFechaF.Text = fechaF
        lblEtapa.Text = etapa
        lblDivision.Text = division
        cbxSexoH.Text = hembra
        cbxSexoM.Text = macho

        cbxSexo.Items.Clear()
        cbxSexo.Items.Add(macho)
        cbxSexo.Items.Add(hembra)
        cbxLugar.Items.Clear()
        cbxLugar.Items.Add(tambo)
        cbxLugar.Items.Add(campo)
        cbxLugar.Items.Add(rodeo)
        cbxLugar.Items.Add(ninguno)
        cbxEtapa.Items.Clear()
        cbxEtapa.Items.Add(ninguno)
        cbxEtapa.Items.Add(servicio)
        cbxEtapa.Items.Add(anestro)
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then
            sql = "SELECT * from Animal where num=" & Val(tbxNum.Text)
            'If rs.RecordCount <> 0 Then
            tbxNum.Enabled = False
            btnOpcion.Enabled = True
            gbxBasico.Enabled = True
            gbxH.Enabled = True
            gbxM.Enabled = True
            gbxEtapa.Enabled = True
            'Else
            '   MsgBox("Error :" + numero + " " + animal, "ERROR")
            'End If
        Else
            MsgBox("Error :" + numero + " " + animal)
        End If
    End Sub

    Private Sub cbxSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSexo.SelectedIndexChanged
        cbxDivision.Items.Clear()
        If cbxSexo.Text() = hembra Then
            cbxDivision.Items.Add(vaca)
            cbxDivision.Items.Add(vaquillona)
            cbxDivision.Items.Add(ternera)
        ElseIf cbxSexo.Text() = macho Then
            cbxDivision.Items.Add(toro)
            cbxDivision.Items.Add(novillo)
            cbxDivision.Items.Add(ternero)
        End If
    End Sub


    Private Sub cbxEtapa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxEtapa.SelectedIndexChanged
        lblFechaF.Enabled = True
        lblFechaI.Enabled = True
        dtpFin.Enabled = True
        dtpInicio.Enabled = True
        btnEtapa.Enabled = True
        btnEtapa_Mod.Enabled = True
    End Sub

    Private Sub cbxLugar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxLugar.SelectedIndexChanged
        If cbxLugar.Text = campo Then
            gbxCria.Enabled = True
        Else
            gbxCria.Enabled = False
        End If
    End Sub

    Private Sub cbxDivision_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxDivision.SelectedIndexChanged
        If cbxDivision.Text = vaca Then
            cbxEtapa.Items.Add(preñada)
            cbxEtapa.Items.Add(lactancia)
            cbxEtapa.Items.Add(seca)
        Else
            Try
                cbxEtapa.Items.Remove(preñada)
                cbxEtapa.Items.Remove(lactancia)
                cbxEtapa.Items.Remove(seca)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnBuscarM_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarM.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then
            'SELECT RAZA ANIMAL NUMERO = AKJSDHKASD
        End If
    End Sub

    Private Sub btnBuscarH_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarH.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then
            'SELECT RAZA ANIMAL NUMERO = AKJSDHKASD
        End If
    End Sub

    Private Sub btnEtapa_Mod_Click(sender As System.Object, e As System.EventArgs) Handles btnEtapa_Mod.Click
        'insert into etapa e, tiene(creo) t where num_animal=num.text and e.id= t.td
    End Sub

    Private Sub btnEtapa_Click(sender As System.Object, e As System.EventArgs) Handles btnEtapa.Click
        'insert values into etapa num.text
        ' guardar el etapa id nuevo
        'insert into tiene num, id
    End Sub

    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
        Select Case opcion
            Case 0 'ingresar
            Case 1 'modificar
            Case 2 ' consultar
            Case 3 'eliminar
        End Select
    End Sub
End Class