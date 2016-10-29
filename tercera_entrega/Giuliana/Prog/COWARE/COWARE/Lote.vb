Public Class frmLote
    Private Sub Lote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        lblAnimalnuma.Text = animal + ", " + numero
        lblAnimalnumC.Text = lblAnimalnuma.Text
        lblNumLotec.Text = num_lote
        lblNumLotef.Text = lblNumLotec.Text
        btnAgregar.Text = agregar
        btnConsultar.Text = consultar
        btnModificar.Text = modificar
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim aux As Integer
        sql = "SELECT * from hembra he, tambo t, hay h where num_hembra=" & Val(tbxNumA.Text) & " and t.serie=h.serie_tambo and he.num_hembra=h.num_animal and t.serie= " & Val(TSERIE)
        Open_sql()
        If rs.RecordCount <> 0 Then
            rs.Close()
            If lbxAgregar.Items.Count = 0 Then
                sql = "Select max(num_lote) from lote"
                Open_sql()
                aux = Val(rs(0).Value) + 1
                sql = "insert into lote(num_lote) values (" & rs(0).Value & ")"
                If execute_sql() Then
                    tbxNumLote.Text = aux
                End If
            End If
            sql = "insert into forma(num_lote, num hembra) values (" & Val(tbxNumLote.Text) & ", " & Val(tbxNumA.Text) & ")"
            If execute_sql() Then
                lbxAgregar.Items.Add(tbxNumA.Text)
            End If
        Else
            MsgBox("Error :" + numero + "/" + animal, MsgBoxStyle.OkOnly, "ERROR")
        End If
        rs.Close()
    End Sub

    Private Sub tbxNumAnimC_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbxNumAnimC.TextChanged
        If rbnNumAnimalC.Checked = True Then
            tbxNumAnimC.Enabled = True
        Else
            tbxNumAnimC.Enabled = False
        End If
    End Sub

    Private Sub rbnNumLoteC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbnNumLoteC.CheckedChanged
        If rbnNumLoteC.Checked = True Then
            tbxNumLotec.Enabled = True
        Else
            tbxNumLotec.Enabled = False
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        Dim acum As Integer
        acum = 0
        sql = ""
        If rbnNumLoteC.Checked Then
            acum = Validacion_numerica(tbxNumLotec.Text, acum)
            If acum = 0 Then
                sql = "select a.num from lote l, hay h, animal a, tambo t where t.serie=h.serie_tambo and a.num=h.num_animal and l.num_hembra=a.num and l.num=" & _
                    tbxNumLotec.Text & " and t.serie =" & Val(TSERIE)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    While Not rs.EOF()
                        lbxConsultar.Items.Add(rs(0).Value)
                        lbxConsultar.Items.Add("  " + rs(1).Value)
                        rs.MoveNext()
                    End While
                    sql = "Select distinct num_animal from produce where num_lote=" & Val(tbxNumLotec.Text)
                End If
            End If
        ElseIf rbnNumAnimalC.Checked Then
            acum = Validacion_numerica(tbxNumAnimC.Text, acum)
            If acum = 0 Then
                sql = "select distinct l.num from lote l, hay h, animal a, tambo t where t.serie=h.serie_tambo and a.num=h.num_animal and l.num_hembra=a.num and a.num=" & _
                    tbxNumAnimC.Text & " and t.serie =" & Val(TSERIE)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    While Not rs.EOF()
                        lbxConsultar.Items.Add(rs(0).Value)
                        lbxConsultar.Items.Add("  " + rs(1).Value)
                        rs.MoveNext()
                    End While
                End If
                rs.Close()
            End If
        End If
        If sql <> "" Then
            Open_sql()
            If rs.RecordCount <> 0 Then
                While Not rs.EOF()
                    lbxConsultar.Items.Add(rs(0).Value)
                    rs.MoveNext()
                End While
            End If
            rs.Close()
        End If
    End Sub

    Private Sub pbxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub

    Private Sub pbxMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub
End Class