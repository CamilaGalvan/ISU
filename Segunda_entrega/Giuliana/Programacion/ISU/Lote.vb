Public Class Lote

    Private Sub Lote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblAnimalnuma.Text = animal + ", " + numero
        lblAnimalnumC.Text = lblAnimalnuma.Text
        lblNumLotec.Text = numero + ", " '+ Lote
        lblNumLotef.Text = lblNumLotec.Text
        btnAgregar.Text = agregar
        btnConsultar.Text = consultar
        btnGuardar.Text = guardar
    End Sub

End Class