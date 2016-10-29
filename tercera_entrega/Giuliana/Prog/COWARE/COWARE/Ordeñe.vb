Public Class frmOrdenie
    Private Sub frmordenie_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
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

        sql = "select t.serie, t.capacidad from tanque t, almacena a, produce p, hay h, tambo o where t.serie=a.num_serie and a.tipo=p.tipo and p.num=h.num_animal and o.serie =" & Val(TSERIE)
        Open_sql()
        If rs.RecordCount <> 0 Then
            While Not rs.EOF()
                lbxEnlistarTanque.Items.Add(rs(0).Value)
                lbxEnlistarTanque.Items.Add("  " + rs(1).Value)
                rs.MoveNext()
            End While
        End If
        rs.Close()

        sql = "select l.num from lote l, hay h, animal a, tambo t where t.serie=h.serie_tambo and a.num=h.num_animal and l.num_hembra=a.num and t.serie =" & Val(TSERIE)
        Open_sql()
        If rs.RecordCount <> 0 Then
            While Not rs.EOF()
                lbxEnlistarlote.Items.Add(rs(0).Value)
                lbxEnlistarlote.Items.Add("  " + rs(1).Value)
                rs.MoveNext()
            End While
        End If
        rs.Close()

    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        frmLote.Show()
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs)
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
            sql = "insert into produce(tipo, fecha, num_lote, cantidad, urea, rec_bact, grasa, proteina, cel_som, num_hembra) values ('comerciable', '" & _
               dtpFecha.Text & "', " & Val(tbxNumLote.Text) & ", " & Val(tbxConsumoe.Text) & ", " & Val(tbxUrea.Text) & ", " & _
               Val(tbxRecuentobac.Text) & ", " & Val(tbxGrasa.Text) & ", " & Val(tbxProteina.Text) & ", " & Val(tbxRecuentocel.Text) & ", " & Val(rs(0).Value) & "')"
                    execute_sql()
            sql = "insert into produce(tipo, fecha, num_lote, cantidad, urea, rec_bact, grasa, proteina, cel_som, num_hembra) values ('NO_comerciable', '" & _
               dtpFecha.Text & "', " & Val(tbxNumLote.Text) & ", " & Val(tbxConsumoi.Text) & ", " & Val(tbxUrea.Text) & ", " & _
               Val(tbxRecuentobac.Text) & ", " & Val(tbxGrasa.Text) & ", " & Val(tbxProteina.Text) & ", " & Val(tbxRecuentocel.Text) & ", " & Val(rs(0).Value) & "')"
                    execute_sql()
            sql = "insert into almacena(tipo, fecha, num_serie cantidad,hora) values ('consumible', '" & dtpFecha.Text & "', " & Val(tbxNserie.Text) & _
                    ", " & Val(tbxConsumoe.Text) & ", " & dtphora.Text & ")"
            execute_sql()
        End If

    End Sub

    Private Sub btnTanque_Consultar_Click(sender As System.Object, e As System.EventArgs)
        sql = "select t.serie, t.capacidad from tanque t, almacena a, produce p, hay h, tambo o where t.serie=a.serie and a.tipo=p.tipo and p.num=h.num and o.serie =" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub pbxMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub

    Private Sub pbxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub
End Class