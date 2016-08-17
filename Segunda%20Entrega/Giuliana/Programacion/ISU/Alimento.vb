Public Class frmAlimento

    Private Sub frmAlimento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If opcion = 4 Then
            Me.Text = venta
            gbxDatos.Text = ""
            lblTipo.Location = New Point(255, 133)
            lblTipo.Text = litros
            cbxTipo.Hide()
        Else
            Me.Text = animal + ", " + alimento
            gbxDatos.Text = tipo + "/" + alimento
            lblTipo.Text = tipo
        End If
        btnGuardar.Text = guardar
        lblFecha.Text = fecha
        lblHora.Text = hora
        lblCantidad.Text = cantidad
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxCantidad.Text, acum)
        If acum = 0 Then
            'guardar. INSERT INTO   
        Else
            MsgBox(cantidad, MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
End Class