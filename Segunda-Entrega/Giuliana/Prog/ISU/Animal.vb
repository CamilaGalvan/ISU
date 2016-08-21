Public Class frmAnimal
    Private Sub frmAnimal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Boton_idioma(btnOpcion)
        Me.Text = animal + ", " + btnOpcion.Text
        btnBuscar.Text = buscar
        btnBuscarH.Text = buscar
        btnBuscarM.Text = buscar
        btnEtapa_add.Text = agregar
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
    Dim Modifi(8) As String
   
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then
            sql = "SELECT * from Animal where num=" & Val(tbxNum.Text)
            Try
                rs.Open(sql, CN)

                If rs.RecordCount <> 0 Then
                    tbxNum.Enabled = False
                    btnOpcion.Enabled = True
                    gbxBasico.Enabled = True
                    gbxH.Enabled = True
                    gbxM.Enabled = True
                    gbxEtapa.Enabled = True

                    Select Case btnOpcion.Text
                        Case ingresar

                        Case modificar
                            Consulta_Animal()
                            Modifi(0) = cbxSexo.Text
                            Modifi(1) = dtpNacimiento.Text
                            Modifi(2) = cbxLugar.Text
                            Modifi(3) = cbxRaza.Text
                            Modifi(4) = cbxDivision.Text
                            Modifi(5) = tbxNumM.Text
                            Modifi(6) = tbxNumH.Text
                            Modifi(7) = dtprecriaida.Text
                            Modifi(8) = dtprecriavuelta.Text
                        Case consultar
                            Consulta_Animal()
                        Case eliminar
                            Consulta_Animal()
                    End Select

                Else
                    MsgBox("Error :" + numero + " " + animal, "ERROR")
                End If

            Catch ex As Exception
                MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
            End Try
        Else
            MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")
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
        btnEtapa_add.Enabled = True
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
        acum = Validacion_numerica(tbxNumM.Text(), acum)
        acum = Validacion_largo(tbxNumM, acum)
        If acum = 0 Then
            sql = "Select num from macho where num=" & Val(tbxNum.Text)
            Try
                rs.Open(sql, CN)
            Catch ex As Exception
                MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
            End Try
            If rs.RecordCount <> 0 Then
                cbxSexoM.Text = macho
                sql = "SELECT raza from Animal where num=" & Val(tbxNumM.Text)
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
                cbxRazaH.Text = rs.value(0)
            Else
                MsgBox("Error :" + numero + " " + animal, "ERROR")
            End If
        Else
            MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnBuscarH_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarH.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then

            sql = "Select num from hembra where num=" & Val(tbxNum.Text)
            Try
                rs.Open(sql, CN)
            Catch ex As Exception
                MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
            End Try
            If rs.RecordCount <> 0 Then
                cbxSexoH.Text = hembra
                sql = "SELECT raza from Animal where num=" & Val(tbxNumM.Text)
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
                cbxRazaH.Text = rs.value(0)
            Else
                MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")
            End If
        Else
            MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")

        End If
    End Sub

    Private Sub btnEtapa_Mod_Click(sender As System.Object, e As System.EventArgs) Handles btnEtapa_Mod.Click
        'insert into etapa e, tiene(creo) t where num_animal=num.text and e.id= t.td
    End Sub

    Private Sub btnEtapa_Click(sender As System.Object, e As System.EventArgs) Handles btnEtapa_add.Click
        'insert values into etapa num.text
        ' guardar el etapa id nuevo
        'insert into tiene num, id
    End Sub

    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
        Select Case btnOpcion.Text
            Case ingresar
                sql = "INSERT into Animal(numero, nacimiento, lugar, raza, progenitor_macho, progenitor_hembra, activo) values (" & Val(tbxNum.Text) & ",'" & dtpNacimiento.Text & "', '" & cbxLugar.Text & "', '" & cbxRaza.Text & "', " & Val(tbxNumM.Text) & ", " & Val(tbxNumH.Text) & ", 'Activo')"
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
                If cbxSexo.Text = macho Then
                    If cbxDivision.Text = novillo Then
                        sql = "INSERT into Mancho(numero, castrado) values (" & Val(tbxNum.Text) & ", 'castrado')"
                    Else
                        sql = "INSERT into Mancho(numero, castrado) values (" & Val(tbxNum.Text) & ", 'no_castrado')"
                    End If
                Else
                    sql = "INSERT into Hembra(numero) values (" & Val(tbxNum.Text) & ")"
                End If
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
                If cbxDivision.Text = toro Then
                    sql = "INSERT into Mancho(numero) values (" & Val(tbxNum.Text) & ")"
                Else
                    sql = "INSERT into Hembra(numero) values (" & Val(tbxNum.Text) & ")"
                End If
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
            Case modificar
                Dim Modifi_Now(8) As String
                Modifi_Now(0) = cbxSexo.Text
                Modifi_Now(1) = dtpNacimiento.Text
                Modifi_Now(2) = cbxLugar.Text
                Modifi_Now(3) = cbxRaza.Text
                Modifi_Now(4) = cbxDivision.Text
                Modifi_Now(5) = tbxNumM.Text
                Modifi_Now(6) = tbxNumH.Text
                Modifi_Now(7) = dtprecriaida.Text
                Modifi_Now(8) = dtprecriavuelta.Text
                Dim i As Integer = 0
                Dim B As Boolean 'supongo son iguales
                While i <= 8
                    B = True
                    While B = True
                        If Modifi(i) <> Modifi_Now(i) Then
                            B = False
                        End If
                    End While
                    'VER COMO HACER SI UN CASE O QUE PARA 
                    ' update tabla set atributo = ajsdhas where clave=ahsdgaks
                    ' o delete from tabla where clave=akjsdhkashd
                End While

            Case eliminar

        End Select
    End Sub

    Private Sub Consulta_Animal()
        sql = "Select raza from animal where num=" & Val(tbxNum.Text)
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
        End Try
        cbxRaza.Text = rs(0).Value

        sql = "Select lugar from animal where num=" & Val(tbxNum.Text)
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
        End Try
        cbxLugar.Text = rs(0).Value

        sql = "Select nacimiento from animal where num=" & Val(tbxNum.Text)
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
        End Try
        dtpNacimiento.Text = rs(0).Value

        sql = "Select progenitor_macho from animal where num=" & Val(tbxNum.Text)
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
        End Try
        tbxNumM.Text = rs(0).Value

        sql = "Select progenitor_hembra from animal where num=" & Val(tbxNum.Text)
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
        End Try
        tbxNumH.Text = rs(0).Value

        sql = "Select num from cria where num=" & Val(tbxNum.Text)
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
        End Try
        If rs.RecordCount <> 0 Then
            'cbxDivision.Text = cria
        Else
            sql = "Select num from hembra where num=" & Val(tbxNum.Text)
            Try
                rs.Open(sql, CN)
            Catch ex As Exception
                MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
            End Try
            If rs.RecordCount <> 0 Then
                cbxSexo.Text = hembra
                sql = "Select nombre from estado E, pasa P where P.num_hembra=" & Val(tbxNum.Text) & "and fecha.fin > '" & Today & "'"
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
                cbxEtapa.Items.Clear()
                If rs.RecordCount <> 0 Then
                    While Not rs.EOF()
                        cbxEtapa.Items.Add(rs(0).Value)
                        rs.MoveNext()
                    End While
                End If
                sql = "Select nombre from estado E, pasa P where P.num_hembra=" & Val(tbxNum.Text) & "and nombre = '" & preñada & "'"
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
                If rs.RecordCount <> 0 Then
                    cbxDivision.Text = vaca
                Else
                    cbxDivision.Text = vaquillona
                End If
            Else
                sql = "Select num from macho where num=" & Val(tbxNum.Text)
                Try
                    rs.Open(sql, CN)
                Catch ex As Exception
                    MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                End Try
                If rs.RecordCount <> 0 Then
                    cbxSexo.Text = macho
                    sql = "Select num from macho where num=" & Val(tbxNum.Text) & "and castrado =" 'POENR COSO PUM
                    Try
                        rs.Open(sql, CN)
                    Catch ex As Exception
                        MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
                    End Try
                    If rs.RecordCount <> 0 Then
                        cbxDivision.Text = novillo
                    Else
                        cbxDivision.Text = toro
                    End If
                End If
            End If
        End If
    End Sub
End Class