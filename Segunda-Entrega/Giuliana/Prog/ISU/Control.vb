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
            sql = "SELECT * from Animal where num=" & Val(tbxNum.Text)
            Open_sql()
            If rs.RecordCount <> 0 Then
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
        'NECESITO ENTIDAD NUEVA SEEEEEEBAAAAAAA
    End Sub
End Class