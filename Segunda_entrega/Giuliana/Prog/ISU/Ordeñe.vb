Public Class frmOrdeñe

    Private Sub frmOrdeñe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTurno.Text = turno
        lblLitros.Text = litros
        lblGrasa.Text = grasa
        lblProteina.Text = proteina
        lblUrea.Text = urea
        lblRecuentobac.Text = rec_bacteriano
        lblRecuentoCel.Text = rec_celulas
        lblNumLote.Text = num_lote
        lblFecha.Text = fecha
        chbConsumoe.Text = consumoe
        chbConsumoi.Text = consumoi

    End Sub

    Public Sub Open_sql()
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error open", MsgBoxStyle.OkOnly, "ERROR")
        End Try
    End Sub
    Public Sub execute_sql()
        Try
            CN.Execute(sql)
        Catch ex As Exception
            MsgBox("Error Execute")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        frmLote.Show()
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        frmLote.Show()
    End Sub

    Private Sub btnOrdeñado_Click(sender As System.Object, e As System.EventArgs) Handles btnOrdeñado.Click
        Dim acum As Integer
        acum = Validacion_numerica(tbxLitros.Text, acum)
        acum = Validacion_numerica(tbxGrasa.Text, acum)
        acum = Validacion_numerica(tbxProteina.Text, acum)
        acum = Validacion_numerica(tbxUrea.Text, acum)
        acum = Validacion_numerica(tbxRecuentobac.Text, acum)
        acum = Validacion_numerica(tbxRecuentocel.Text, acum)
        acum = Validacion_numerica(tbxConsumoi.Text, acum)
        acum = Validacion_numerica(tbxConsumoi.Text, acum)
        acum = Validacion_numerica(tbxNumLote.Text, acum)
        If Val(tbxLitros.Text) <> (Val(tbxConsumoe.Text) + Val(tbxConsumoi.Text)) Then
            acum = acum + 1
        End If
        If acum = 0 Then
            sql = "Select num_hembra from produce where num_lote=" & tbxNumLote.Text
            Open_sql()
            If rs.RecordCount <> 0 Then
                While Not rs.EOF()
                    sql = "insert into produce(tipo, fecha, num_lote, cantidad, urea, recuento_bac, grasa, proteina, celulas_somaticas, num_hembra) values ('comerciable', '" & _
               dtpFecha.Text & "', " & Val(tbxNumLote.Text) & ", " & Val(tbxConsumoe.Text) & ", " & Val(tbxUrea.Text) & ", " & _
               Val(tbxRecuentobac.Text) & ", " & Val(tbxGrasa.Text) & ", " & Val(tbxProteina.Text) & ", " & Val(tbxRecuentocel.Text) & ", " & Val(rs(0).Value) & "')"
                    execute_sql()
                    sql = "insert into produce(tipo, fecha, num_lote, cantidad, urea, recuento_bac, grasa, proteina, celulas_somaticas, num_hembra) values ('NOcomerciable', '" & _
               dtpFecha.Text & "', " & Val(tbxNumLote.Text) & ", " & Val(tbxConsumoi.Text) & ", " & Val(tbxUrea.Text) & ", " & _
               Val(tbxRecuentobac.Text) & ", " & Val(tbxGrasa.Text) & ", " & Val(tbxProteina.Text) & ", " & Val(tbxRecuentocel.Text) & ", " & Val(rs(0).Value) & "')"
                    execute_sql()
                End While
            Else
                Dim i As Integer
                For i = 0 To frmLote.lbxAgregar.Items.Count - 1
                    sql = "insert into produce(tipo, fecha, num_lote, cantidad, urea, recuento_bac, grasa, proteina, celulas_somaticas, num_hembra) values ('comerciable', '" & _
                            dtpFecha.Text & "', " & Val(tbxNumLote.Text) & ", " & Val(tbxConsumoe.Text) & ", " & Val(tbxUrea.Text) & ", " & _
                            Val(tbxRecuentobac.Text) & ", " & Val(tbxGrasa.Text) & ", " & Val(tbxProteina.Text) & ", " & Val(tbxRecuentocel.Text) & ", " & Val(frmLote.lbxAgregar.Items(i)) & "')"
                    execute_sql()
                    sql = "insert into produce(tipo, fecha, num_lote, cantidad, urea, recuento_bac, grasa, proteina, celulas_somaticas, num_hembra) values ('NOcomerciable', '" & _
               dtpFecha.Text & "', " & Val(tbxNumLote.Text) & ", " & Val(tbxConsumoi.Text) & ", " & Val(tbxUrea.Text) & ", " & _
               Val(tbxRecuentobac.Text) & ", " & Val(tbxGrasa.Text) & ", " & Val(tbxProteina.Text) & ", " & Val(tbxRecuentocel.Text) & ", " & Val(frmLote.lbxAgregar.Items(i)) & "')"
                    execute_sql()
                Next
                frmLote.Hide()
            End If
            rs.Close()
            sql = "insert into almacena(tipo, fecha, num_sertie cantidad) values ('consumible', '" & dtpFecha.Text & "', " & Val(tbxNserie.Text) & _
                    ", " & Val(tbxConsumoe.Text) & ")"
            execute_sql()
        End If

    End Sub

    Private Sub btnTanque_Consultar_Click(sender As System.Object, e As System.EventArgs) Handles btnTanque_Consultar.Click
        sql = "select t.serie, t.capacidad from tanque t, almacena a, produce p, hay h, tambo o where t.serie=a.serie and a.tipo=p.tipo and p.num=h.num and o.serie =" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub
End Class