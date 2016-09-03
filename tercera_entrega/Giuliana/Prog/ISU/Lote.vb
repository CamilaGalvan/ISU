Public Class frmLote

    Private Sub Lote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblAnimalnuma.Text = animal + ", " + numero
        lblAnimalnumC.Text = lblAnimalnuma.Text
        lblNumLotec.Text = num_lote
        lblNumLotef.Text = lblNumLotec.Text
        btnAgregar.Text = agregar
        btnConsultar.Text = consultar
    End Sub

    Public Sub Open_sql()
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error open", MsgBoxStyle.OkOnly, "ERROR")
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim aux As Integer
        sql = "SELECT * from hembra he, tambo t, hay h where num=" & Val(tbxNumA.Text) & " and t.serie=h.serie and he.num=h.num and t.serie= " & Val(TSERIE)
        If rs.RecordCount <> 0 Then
            lbxAgregar.Items.Add(tbxNumLote.Text)
            sql = "Select max(num_lote) from produce"
            Open_sql()
            aux = Val(rs(0).Value) + 1
            tbxNumLote.Text = aux
        Else
            MsgBox("Error :" + numero + "/" + animal, MsgBoxStyle.OkOnly, "ERROR")
        End If
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
        If rbnNumLoteC.Checked = True Then
            acum = Validacion_numerica(tbxNumLotec.Text, acum)
            If acum = 0 Then
                sql = "Select distinct num_animal from produce where num_lote=" & Val(tbxNumLotec.Text)
            End If
        Else
            acum = Validacion_numerica(tbxNumAnimC.Text, acum)
            If acum = 0 Then
                sql = "Select distinct num_serie from produce where num_animal=" & Val(tbxNumAnimC.Text)
            End If
        End If
    End Sub
End Class