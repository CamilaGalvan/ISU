Public Class frmControl

    Private Sub frmControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = animal + ", " + control
        lblFecha.Text = fecha
        lblNumero.Text = numero
        lblPeso.Text = peso
        chbVacuna.Text = vacuna
        btnBuscar.Text = buscar
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        gbxGeneral.Enabled = True
    End Sub

    Private Sub chbVacuna_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbVacuna.CheckedChanged
        cbxVacuna.Enabled = True
    End Sub
End Class