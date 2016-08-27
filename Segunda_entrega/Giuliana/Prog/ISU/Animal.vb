Public Class frmAnimal
    Dim Modifi(8) As String

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

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then
            sql = "SELECT * from Animal, tambo t, hay h where num=" & Val(tbxNum.Text) & " and t.serie=h.serie and a.num=h.num and t.serie " & Val(TSERIE)
            Open_sql()

            If rs.RecordCount <> 0 Then
                rs.Close()
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
            sql = "Select m.num from macho m, tambo t, hay h where hnum=" & Val(tbxNum.Text) & " and t.serie=h.serie and m.num=h.num and t.serie= " & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                rs.Close()
                cbxSexoM.Text = macho
                sql = "SELECT raza from Animal where num=" & Val(tbxNumM.Text)
                Open_sql()
                cbxRazaH.Text = rs.value(0)
                rs.Close()
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

            sql = "Select he.num from hembra he, tambo t, hay h where hnum=" & Val(tbxNum.Text) & " and t.serie=h.serie and he.num=h.num and t.serie= " & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                rs.Close()
                cbxSexoH.Text = hembra
                sql = "SELECT raza from Animal a, tambo t, hay h where num=" & Val(tbxNumM.Text)
                Open_sql()
                cbxRazaH.Text = rs.value(0)
                rs.Close()
            Else
                MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")
            End If
        Else
            MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")

        End If
    End Sub
    Private Sub btnEtapa_Mod_Click(sender As System.Object, e As System.EventArgs) Handles btnEtapa_Mod.Click
        sql = "update estado set fecha_inicio='" & dtpInicio.Text & "'  where num=" & tbxNum.Text
        execute_sql()
        sql = "update estado set fecha_fin='" & dtpFin.Text & "'  where num=" & tbxNum.Text
        execute_sql()
    End Sub

    Private Sub btnEtapa_Click(sender As System.Object, e As System.EventArgs) Handles btnEtapa_add.Click
        sql = "insert into estado e, pasa p where num_animal='" & tbxNum.Text & "' and e.num= t.num"
        Try
            CN.Execute(sql)
        Catch ex As Exception
            MsgBox("Error al eliminar telefonos")
            Exit Sub
        End Try
    End Sub

    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
        Select Case btnOpcion.Text
            Case ingresar
                sql = "INSERT into Animal(numero, nacimiento, lugar, raza, progenitor_macho, progenitor_hembra, activo) values (" & Val(tbxNum.Text) & ",'" & dtpNacimiento.Text & _
                    "', '" & cbxLugar.Text & "', '" & cbxRaza.Text & "', " & Val(tbxNumM.Text) & ", " & Val(tbxNumH.Text) & ", 'Activo')"
                execute_sql()
                If cbxDivision.Text = ternera Or cbxDivision.Text = ternero Then
                    sql = "INSERT into cria(numero) values (" & Val(tbxNum.Text) & ")"
                Else
                    If cbxSexo.Text = macho Then
                        If cbxDivision.Text = novillo Then
                            sql = "INSERT into Mancho(numero, castrado) values (" & Val(tbxNum.Text) & ", 1)"
                        ElseIf cbxDivision.Text = toro Then
                            sql = "INSERT into Mancho(numero, castrado) values (" & Val(tbxNum.Text) & ", 0)"
                        End If
                    Else
                        sql = "INSERT into Hembra(numero) values (" & Val(tbxNum.Text) & ")"
                    End If
                End If
                execute_sql()
                sql = "insert into hay(num_animal, serie) values (" & Val(tbxNum.Text) & ", " & Val(TSERIE) & ""
                execute_sql()

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
                    While i <= 8
                        If Modifi(i) <> Modifi_Now(i) Then
                            Select Case i
                                Case 0
                                If Modifi(i) = hembra Then
                                    sql = "delete from hembra where num=" & Val(tbxNum.Text)
                                    execute_sql()
                                    If cbxDivision.Text = novillo Then
                                        sql = "insert into macho(numero, castrado) values (" & tbxNum.Text & ", 1)"
                                    ElseIf cbxDivision.Text = toro Then
                                        sql = "insert into macho(numero, castrado) values (" & tbxNum.Text & ", 0)"
                                    Else
                                        sql = "insert into cria(numero) values (" & tbxNum.Text & ")"
                                    End If
                                    execute_sql()
                                Else
                                    sql = " delete from macho where num=" & Val(tbxNum.Text)
                                    execute_sql()
                                    If cbxDivision.Text = vaquillona Then
                                        sql = "insert into hembra(numero values (" & tbxNum.Text & ")"
                                    ElseIf cbxDivision.Text = vaca Then
                                        sql = "insert into hembra(numero) values (" & tbxNum.Text & ")"
                                        execute_sql()
                                        cbxEtapa.Text = preñada
                                        sql = "insert into pasa(numero_animal, fecha_inicial, fecha_final) values (" & tbxNum.Text & ", '" & Today & "','" & Today & "')"
                                    Else
                                        sql = "insert into cria(numero) values (" & tbxNum.Text & ")"
                                    End If
                                    execute_sql()
                                End If
                            Case 1
                                sql = "update animal set nacimiento='" & dtpNacimiento.Text & "'  where num=" & tbxNum.Text
                            Case 2
                                sql = "update animal set lugar='" & cbxLugar.Text & "'  where num=" & tbxNum.Text
                            Case 3
                                sql = "update animal set raza='" & cbxRaza.Text & "'  where num=" & tbxNum.Text
                            Case 4
                                If cbxDivision.Text = novillo Then
                                    sql = "insert into macho(numero, castrado) values (" & tbxNum.Text & ", 1)"
                                ElseIf cbxDivision.Text = toro Then
                                    sql = "insert into macho(numero, castrado) values (" & tbxNum.Text & ", 0)"
                                ElseIf cbxDivision.Text = vaquillona Then
                                    sql = "insert into hembra(numero values (" & tbxNum.Text & ")"
                                ElseIf cbxDivision.Text = vaca Then
                                    sql = "insert into hembra(numero) values (" & tbxNum.Text & ")"
                                    execute_sql()
                                    cbxEtapa.Text = preñada
                                    sql = "insert into pasa(numero_animal, fecha_inicial, fecha_final) values (" & tbxNum.Text & ", '" & Today & "','" & Today & "')"
                                Else
                                    sql = "insert into cria(numero) values (" & tbxNum.Text & ")"
                                End If
                                execute_sql()
                            Case 5
                                sql = "update animal set progenitor_macho='" & tbxNumM.Text & "'  where num=" & tbxNum.Text
                            Case 6
                                sql = "update animal set progenitor_hembra='" & tbxNumH.Text & "'  where num=" & tbxNum.Text
                            Case 7
                                sql = "update va set fecha_ida='" & dtprecriaida.Text & "'  where num=" & tbxNum.Text
                            Case 8
                                If cbxSexo.Text = macho Then
                                    sql = "update retorna set fecha_vuelta='" & dtprecriavuelta.Text & "'  where num=" & tbxNum.Text
                                Else
                                    sql = "update vuelve set fecha_vuelta='" & dtprecriavuelta.Text & "'  where num=" & tbxNum.Text
                                End If
                        End Select
                            execute_sql()
                        End If
                        i = i + 1
                    End While

            Case eliminar
                sql = "update animal set activo=0 where num=" & tbxNum.Text
        End Select
    End Sub

    Private Sub Consulta_Animal()
        sql = "Select raza from animal where num=" & Val(tbxNum.Text)
        Open_sql()
        cbxRaza.Text = rs(0).Value
        rs.Close()
        sql = "Select lugar from animal where num=" & Val(tbxNum.Text)
        Open_sql()
        cbxLugar.Text = rs(0).Value
        rs.Close()
        sql = "Select nacimiento from animal where num=" & Val(tbxNum.Text)
        Open_sql()
        dtpNacimiento.Text = rs(0).Value
        rs.Close()
        sql = "Select progenitor_macho from animal where num=" & Val(tbxNum.Text)
        Open_sql()
        tbxNumM.Text = rs(0).Value
        rs.Close()
        sql = "Select progenitor_hembra from animal where num=" & Val(tbxNum.Text)
        Open_sql()
        tbxNumH.Text = rs(0).Value
        rs.Close()
        sql = "Select num from cria where num=" & Val(tbxNum.Text)
        Open_sql()
        If rs.RecordCount <> 0 Then
            rs.Close()
            sql = "Select sexo from cria where num=" & Val(tbxNum.Text)
            Open_sql()
            If rs(0).Value = hembra Then
                cbxDivision.Text = ternera
            Else
                cbxDivision.Text = ternero
            End If
            rs.Close()
        Else
            sql = "Select num from hembra where num=" & Val(tbxNum.Text)
            Open_sql()
            If rs.RecordCount <> 0 Then
                rs.Close()
                cbxSexo.Text = hembra
                sql = "Select nombre from estado E, pasa P where P.num_hembra=" & Val(tbxNum.Text) & "and fecha.fin > '" & Today & "'"
                Open_sql()
                cbxEtapa.Items.Clear()
                If rs.RecordCount <> 0 Then
                    While Not rs.EOF()
                        cbxEtapa.Items.Add(rs(0).Value)
                        rs.MoveNext()
                    End While
                End If
                rs.Close()
                sql = "Select nombre from estado E, pasa P where P.num_hembra=" & Val(tbxNum.Text) & "and nombre = '" & preñada & "'"
                Open_sql()
                If rs.RecordCount <> 0 Then
                    cbxDivision.Text = vaca
                Else
                    cbxDivision.Text = vaquillona
                End If
                rs.Close()
            Else
                sql = "Select num from macho where num=" & Val(tbxNum.Text)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    rs.Close()
                    cbxSexo.Text = macho
                    sql = "Select num from macho where num=" & Val(tbxNum.Text) & "and castrado = 1"
                    Open_sql()
                    If rs.RecordCount <> 0 Then
                        cbxDivision.Text = novillo
                    Else
                        cbxDivision.Text = toro
                    End If
                    rs.Close()
                End If
            End If
        End If
    End Sub
End Class