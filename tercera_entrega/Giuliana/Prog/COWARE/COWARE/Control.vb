Public Class frmControl

    Private Sub frmControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = animal + ", " + control
        lblFecha.Text = fecha
        lblNumero.Text = numero
        lblPeso.Text = peso
        chbVacuna.Text = vacuna
        btnBuscar.Text = buscar
        btnGuardar.Text = guardar
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
            sql = "Insert into control(vacuna, peso, fecha, ci, num) values('" & cbxVacuna.Text & "', " & Val(tbxPeso.Text) & ", '" & dtpNacimiento.Text & "', " & Val(rs(0).Value) & ", " & tbxNum.Text & ")"
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
End Class