Public Class frmControl
    Private Sub frmControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.Text = animal + ", " + control
        lblFecha.Text = fecha
        lblNumero.Text = numero
        lblPeso.Text = peso
        chbVacuna.Text = vacuna
        btnBuscar.Text = buscar
        btnGuardar.Text = guardar
        btnEtapa_add.Text = agregar
        lblRecriavuelta.Text = fecha_vuelta
        lblRecriaIda.Text = fecha_ida
        lblFechaI.Text = fechaI
        lblFechaF.Text = fechaF
        lblRecria.Text = campo
        lblEtapa.Text = etapa
        cbxEtapa.Items.Clear()
        cbxEtapa.Items.Add(ninguno)
        cbxEtapa.Items.Add(servicio)
        cbxEtapa.Items.Add(anestro)

        sql = "Select a.num, a.raza from animal a, hay h, tambo t where a.num=h.num_animal and h.serie_tambo=t.serie and t.serie=" & Val(TSERIE)
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
            sql = "Select he.num from hembra he, tambo t, hay h where hnum=" & Val(tbxNum.Text) & " and t.serie=h.serie and he.num=h.num and t.serie= " & Val(TSERIE)
            If rs.RecordCount <> 0 Then
                rs.Close()
                tbxNum.Enabled = False
                gbxGeneral.Enabled = True
            End If
        Else
            MsgBox("Error :" + numero + " " + animal, MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub chbVacuna_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbVacuna.CheckedChanged
        cbxVacuna.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        sql = "select ci from persona where login='" & frmArranque.tbxUser.Text & "'"
        Open_sql()
        If rs.RecordCount <> 0 Then
            sql = "Insert into control(vacuna, peso, fecha, ci, num) values('" & cbxVacuna.Text & "', " & Val(tbxPeso.Text) & ", '" & dtpNacimiento.Text & "', " & Val(rs(0).Value) & ", " & Val(tbxNum.Text) & ")"
            rs.Close()
            Open_sql()
        End If
        rs.Close()
    End Sub

    Private Sub pbxMini_Click(sender As System.Object, e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub

    Private Sub pbxClose_Click(sender As System.Object, e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub

    Private Sub btnEtapa_add_Click(sender As System.Object, e As System.EventArgs) Handles btnEtapa_add.Click
        sql = "select num from estado where nombre=" & cbxEtapa.Text
        Open_sql()
        If rs.RecordCount <> 0 Then
            sql = "insert into estado(nombre) values (" & cbxEtapa.Text & ")"
            execute_sql()
        End If
        sql = "insert into pasa(num_hembra, num_estado, fecha_inicio, fecha_fin) values (" & Val(tbxNum.Text) & ", " & Val(rs(0).Value) & ", " & dtpInicio.Text & ", " & dtpFin.Text & ")"
        execute_sql()
        rs.Close()
        Try
            CN.Execute(sql)
        Catch ex As Exception
            MsgBox("Error al eliminar telefonos")
            Exit Sub
        End Try
    End Sub

    Private Sub cbxEtapa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxEtapa.SelectedIndexChanged
        lblFechaF.Enabled = True
        lblFechaI.Enabled = True
        dtpFin.Enabled = True
        dtpInicio.Enabled = True
        btnEtapa_add.Enabled = True
    End Sub

    Private Sub lbxEnlistar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbxEnlistar.SelectedIndexChanged
        Dim selected As String
        selected = lbxEnlistar.SelectedItem.ToString()
        If IsNumeric(selected) Then
            tbxNum.Text = selected
            btnBuscar.Enabled = False
            gbxCria.Enabled = True
            gbxEtapa.Enabled = True
            gbxGeneral.Enabled = True
        End If
    End Sub

    Private Sub btnCampo_Click(sender As System.Object, e As System.EventArgs) Handles btnRecria_Add.Click
        sql = "select * from campo_de_recria where num=" & Val(cbxRecria.Text)
        Open_sql()
        If rs.RecordCount <> 0 Then
            rs.Close()
            sql = "select * va where num_cria=" & Val(cbxRecria.Text)
            Open_sql()
            If rs.RecordCount = 0 Then
                sql = "insert into va(num_cria, fecha, num_camp_re) values (" & Val(tbxNum.Text) & ", " & dtpInicio.Text & ", " & cbxRecria.Text & ")"
            Else
                sql = "update va set fecha=" & dtpInicio.Text & " where cria=" & Val(cbxRecria.Text)
            End If
            execute_sql()
            rs.Close()
            sql = "select * retorna where num_animal=" & Val(cbxRecria.Text)
            Open_sql()
            If rs.RecordCount = 0 Then
                sql = "select sexo from cria where num_cria=" & Val(tbxNum.Text)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    sql = "insert into retorna(num_animal, fecha_vuelta, num_camp_re) values (" & Val(tbxNum.Text) & ", " & dtpFin.Text & ", " & cbxRecria.Text & ")"
                Else
                    sql = "insert into vuelve(num_hembra, fecha_vuelta, num_camp_re) values (" & Val(tbxNum.Text) & ", " & dtpFin.Text & ", " & cbxRecria.Text & ")"
                End If
                execute_sql()
            Else
                rs.Close()
                sql = "select * from vuelve where num_hembra=" & Val(tbxNum.Text)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    sql = "update vuelve set fecha_vuelta=" & dtpFin.Text & " where num_hembra=" & Val(cbxRecria.Text)
                    execute_sql()
                Else
                    sql = "insert into vuelve(num_hmbra, fecha_vuelta, num_camp_re) values (" & Val(tbxNum.Text) & ", " & dtpFin.Text & ", " & cbxRecria.Text & ")"
                    execute_sql()
                End If
            End If
        Else
            MsgBox("Error: " + numero + " " + campo)
        End If
        rs.Close()
    End Sub

    Private Sub btnRecria_Click(sender As System.Object, e As System.EventArgs) Handles btnRecria.Click
        sql = "select * from campo_de_recria where num=" & Val(cbxRecria.Text)
        Open_sql()
        If rs.RecordCount = 0 Then
            sql = "insert into campo_de_recria(num) values (" & cbxRecria.Text & ")"
        Else
            MsgBox("Error: " + numero + " " + campo)
        End If
    End Sub
End Class