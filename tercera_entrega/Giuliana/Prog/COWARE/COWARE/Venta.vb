Public Class frmVenta

    Private Sub Venta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.Text = venta
        gbxDatos.Text = ""
        lblTipo.Text = litros
        btnGuardar.Text = guardar
        lblFecha.Text = fecha
        lblHora.Text = hora
        lblCantidad.Text = cantidad
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim acum, max As Integer
        acum = 0
        acum = Validacion_numerica(tbxCantidad.Text, acum)
        If acum = 0 Then
            rs.Close()
            sql = "Select max(serie) from coperativa"
            Open_sql()

            max = Val(rs(0).Value) + 1
            rs.Close()
            sql = "INSERT into retira(serie_tanque, serie_coop, fecha, cantidad) values (" & Val(TSERIE) & ", " & max & ", '" & dtpFecha.Text & "', " & tbxCantidad.Text & ")"
            execute_sql()
        Else
            MsgBox(cantidad, MsgBoxStyle.OkOnly, "ERROR")
        End If
        rs.Close()
    End Sub

    Private Sub pbxClose_Click(sender As System.Object, e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub

    Private Sub pbxMini_Click(sender As System.Object, e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub
End Class