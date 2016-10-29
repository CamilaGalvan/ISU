Public Class frmAnimal
    Dim Modifi(2) As String
    Private Sub frmAnimal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Boton_idioma(btnOpcion)
        Me.Text = animal + ", " + btnOpcion.Text
        btnBuscar.Text = buscar
        btnBuscarH.Text = buscar
        btnBuscarM.Text = buscar
        lblDivision.Text = division
        lblSexo.Text = sexo
        lblRazaM.Text = raza
        lblRazaH.Text = raza
        lblRaza.Text = raza
        lblNumM.Text = numero
        lblNumH.Text = numero
        lblNumero.Text = numero
        lblNacimiento.Text = nacimiento
        lblLugar.Text = lugar
        cbxSexo.Items.Clear()
        cbxSexo.Items.Add(macho)
        cbxSexo.Items.Add(hembra)
        cbxLugar.Items.Clear()
        cbxLugar.Items.Add(tambo)
        cbxLugar.Items.Add(campo)
        cbxLugar.Items.Add(rodeo)
        cbxLugar.Items.Add(ninguno)

        sql = "Select a.num, a.raza from animal a, hay h, tambo t where a.num=h.num_animal and h.serie_tambo=t.serie and activo=1 and t.serie=" & Val(TSERIE)
        Open_sql()
        If rs.RecordCount <> 0 Then
            While Not rs.EOF()
                lbxEnlistar.Items.Add(rs(0).Value)
                lbxEnlistar.Items.Add("  " + rs(1).Value)
                rs.MoveNext()
            End While
        End If
        rs.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then
            sql = "SELECT * from Animal where num=" & Val(tbxNum.Text)
            Open_sql()
            Select Case opcion
                Case 0
                    If rs.RecordCount = 0 Then
                        rs.Close()
                        btnOpcion.Enabled = True
                        tbxNum.Enabled = False
                        gbxBasico.Enabled = True
                    Else
                        rs.Close()
                        MsgBox("Error 0:" + numero + " " + animal)
                    End If
                Case Else
                    If rs.RecordCount <> 0 Then
                        rs.Close()
                        btnOpcion.Enabled = True
                        tbxNum.Enabled = False
                        gbxBasico.Enabled = True
                        Select Case opcion
                            Case 1
                                Consulta_Animal()
                                Modifi(0) = cbxSexo.Text
                                Modifi(1) = cbxDivision.Text
                            Case 2
                                Consulta_Animal()
                            Case 3
                                Consulta_Animal()
                        End Select
                    Else
                        rs.Close()
                        MsgBox("Error 1:" + numero + " " + animal)
                    End If
            End Select
        Else
            MsgBox("Error 2:" + numero + " " + animal)
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



    Private Sub btnBuscarM_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarM.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNumM.Text(), acum)
        acum = Validacion_largo(tbxNumM, acum)
        If acum = 0 Then
            sql = "Select m.num_macho from macho m, tambo t, hay h where m.num_macho=" & Val(tbxNum.Text) & " and t.serie=h.serie_tambo and m.num_macho=h.num_animal and t.serie= " & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                rs.Close()
                sql = "SELECT raza from Animal where num=" & Val(tbxNumM.Text)
                Open_sql()
                cbxRazaH.Text = rs.value(0)
                rs.Close()
            Else
                rs.Close()
                MsgBox("Error :" + numero + " " + animal)
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

            sql = "Select he.num_hembra from hembra he, tambo t, hay h where h.num_animal=" & Val(tbxNum.Text) & " and t.serie=h.serie_tambo and he.num_hembra=h.num_animal and t.serie= " & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                rs.Close()
                sql = "SELECT raza from Animal a, tambo t, hay h where num=" & Val(tbxNumM.Text)
                Open_sql()
                cbxRazaH.Text = rs.value(0)
                rs.Close()
            Else
                rs.Close()
                MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")
            End If
        Else
            MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")

        End If
    End Sub

    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
        Dim Modifi_Now(2) As String
        Dim acum As Integer
        acum = 0
        Select Case opcion
            Case 0
                sql = "INSERT into Animal(num, nacimiento, lugar, raza, activo) values (" & Val(tbxNum.Text) & ",'" & dtpNacimiento.Text & _
                    "', '" & cbxLugar.Text & "', '" & cbxRaza.Text & "', 1)"
                execute_sql()
                acum = Validacion_numerica(tbxNumM.Text(), acum)
                acum = Validacion_largo(tbxNumM, acum)
                acum = Validacion_numerica(tbxNumH.Text(), acum)
                acum = Validacion_largo(tbxNumH, acum)
                If acum = 0 Then
                    sql = "Select m.num_macho from macho m, tambo t, hay h where h.num_animal=" & Val(tbxNum.Text) & " and t.serie=h.serie_tambo and m.num_macho=h.num_animal and t.serie= " & Val(TSERIE)
                    Open_sql()
                    If rs.RecordCount <> 0 Then
                        rs.Close()
                        sql = "update animal set progenitor_macho=" & Val(tbxNumH.Text)
                        execute_sql()
                        sql = "Select m.num_hembra from hembra m, tambo t, hay h where h.num_animal=" & Val(tbxNum.Text) & " and t.serie=h.serie_tambo and m.num=h.num_animal and t.serie= " & Val(TSERIE)
                        Open_sql()
                        If rs.RecordCount <> 0 Then
                            sql = "update animal set progenitor_hembra=" & Val(tbxNumH.Text)
                            execute_sql()
                            MsgBox(exito)
                        Else
                            MsgBox("Error:" + numero + "  progenitor " + hembra)
                        End If
                        rs.Close()
                    Else
                        rs.Close()
                        MsgBox("Error:" + numero + " progenitor " + macho)
                    End If
                Else
                    MsgBox("Error:" + numero + "  progenitor")
                End If

                If cbxDivision.Text = ternera Or cbxDivision.Text = ternero Then
                    sql = "INSERT into cria(num_cria, sexo) values (" & Val(tbxNum.Text) & ", '" & cbxSexo.Text & "')"
                Else
                    If cbxSexo.Text = macho Then
                        If cbxDivision.Text = novillo Then
                            sql = "INSERT into Macho(num_macho, castrado) values (" & Val(tbxNum.Text) & ", 1)"
                        ElseIf cbxDivision.Text = toro Then
                            sql = "INSERT into Macho(num_macho, castrado) values (" & Val(tbxNum.Text) & ", 0)"
                        End If
                    Else
                        sql = "INSERT into Hembra(num_hembra) values (" & Val(tbxNum.Text) & ")"
                    End If
                End If
                execute_sql()
                sql = "insert into hay(num_animal, serie_tambo) values (" & Val(tbxNum.Text) & ", " & Val(TSERIE) & ")"
                execute_sql()
            Case 1
                Modifi_Now(0) = cbxSexo.Text
                Modifi_Now(1) = cbxDivision.Text
                If Modifi(0) = hembra Then
                    sql = "delete from hembra where num_hembra=" & Val(tbxNum.Text)
                    execute_sql()
                    If cbxDivision.Text = novillo Then
                        sql = "insert into macho(num_macho, castrado) values (" & Val(tbxNum.Text) & ", 1)"
                    ElseIf cbxDivision.Text = toro Then
                        sql = "insert into macho(num_macho, castrado) values (" & Val(tbxNum.Text) & ", 0)"
                    Else
                        sql = "insert into cria(num_cria, sexo) values (" & Val(tbxNum.Text) & ", '" & cbxSexo.Text & "')"
                    End If
                    execute_sql()
                ElseIf Modifi(0) = macho Then
                    sql = " delete from macho where num_macho=" & Val(tbxNum.Text)
                    execute_sql()
                    If cbxDivision.Text = vaquillona Then
                        sql = "insert into hembra(num_hembra) values (" & tbxNum.Text & ")"
                    ElseIf cbxDivision.Text = vaca Then
                        sql = "insert into hembra(num_hembra) values (" & tbxNum.Text & ")"
                        execute_sql()
                        sql = "insert into pasa(num_hembra, fecha_inicio, fecha_fin, num_estado) values (" & Val(tbxNum.Text) & ", '" & Today & "','" & Today & "', 1)"
                    Else
                        sql = "insert into cria(num_cria, sexo) values (" & Val(tbxNum.Text) & ", '" & cbxSexo.Text & "')"
                    End If
                    execute_sql()
                End If
                If Modifi(1) <> Modifi_Now(1) Then
                    If cbxDivision.Text = novillo Then
                        sql = "update macho set castrado=1 where num_macho=" & Val(tbxNum.Text)
                    ElseIf cbxDivision.Text = toro Then
                        sql = "update macho set castrado=0 where num_macho=" & Val(tbxNum.Text)
                    ElseIf cbxDivision.Text = vaca Then
                        sql = "insert into pasa(num_hembra, fecha_inicio, fecha_fin, num_estado) values (" & Val(tbxNum.Text) & ", '" & Today & "','" & Today & "', 1)"
                    Else
                        sql = "insert into cria(num_cria, sexo) values (" & Val(tbxNum.Text) & ", '" & cbxSexo.Text & "')"
                    End If
                    execute_sql()
                End If
                sql = "update animal set progenitor_macho='" & Val(tbxNumM.Text) & "', progenitor_hembra='" & Val(tbxNumH.Text) & "', nacimiento='" & dtpNacimiento.Text & "', lugar='" & cbxLugar.Text & "', raza='" & cbxRaza.Text & "' where num=" & Val(tbxNum.Text)
                execute_sql()
            Case 3
                sql = "update animal set activo=0 where num=" & Val(tbxNum.Text)
        End Select
    End Sub

    Private Sub Consulta_Animal()
        sql = "Select raza, lugar, nacimiento, progenitor_macho, progenitor_hembra from animal where num=" & Val(tbxNum.Text)
        Open_sql()
        cbxRaza.Text = rs(0).Value
        cbxLugar.Text = rs(1).Value
        dtpNacimiento.Text = rs(2).Value
        Try
            tbxNumM.Text = rs(3).Value
            Try
                tbxNumH.Text = rs(4).Value
            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
        rs.Close()

        sql = "Select num_cria from cria where num_cria=" & Val(tbxNum.Text)
        Open_sql()
        If rs.RecordCount <> 0 Then
            rs.Close()
            sql = "Select sexo from cria where num_cria=" & Val(tbxNum.Text)
            Open_sql()
            If rs(0).Value = hembra Then
                cbxDivision.Text = ternera
                cbxSexo.Text = hembra
            ElseIf rs(0).Value = macho Then
                cbxDivision.Text = ternero
                cbxSexo.Text = macho
            End If
            rs.Close()
        Else
            rs.Close()
            sql = "Select num_hembra from hembra where num_hembra=" & Val(tbxNum.Text)
            Open_sql()
            If rs.RecordCount <> 0 Then
                rs.Close()
                cbxSexo.Text = hembra
                sql = "Select nombre from estado E, pasa P where P.num_hembra=" & Val(tbxNum.Text) & "and nombre = '" & preniada & "'"
                Open_sql()
                If rs.RecordCount <> 0 Then
                    cbxDivision.Text = vaca
                Else
                    cbxDivision.Text = vaquillona
                End If
                rs.Close()
            Else
                rs.Close()
                sql = "Select num_macho from macho where num_macho=" & Val(tbxNum.Text)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    rs.Close()
                    cbxSexo.Text = macho
                    sql = "Select num_macho from macho where num_macho=" & Val(tbxNum.Text) & "and castrado = 1"
                    Open_sql()
                    If rs.RecordCount <> 0 Then
                        cbxDivision.Text = novillo
                    Else
                        cbxDivision.Text = toro
                    End If
                End If
                rs.Close()
            End If
        End If
    End Sub

    Private Sub pbxMini_Click(sender As System.Object, e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub

    Private Sub pbxClose_Click(sender As System.Object, e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub

    Private Sub lbxEnlistar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxEnlistar.SelectedIndexChanged
        Dim selected As String
        selected = lbxEnlistar.SelectedItem.ToString()
        If IsNumeric(selected) And opcion <> 0 Then
            tbxNum.Text = selected
            Consulta_Animal()
            btnBuscar.Enabled = False
            btnOpcion.Enabled = True
            If opcion = 1 Then
                Modifi(0) = cbxSexo.Text
                Modifi(1) = cbxDivision.Text
            End If
            If opcion <> 0 Then
                gbxBasico.Enabled = True
            End If
        End If
    End Sub
End Class

