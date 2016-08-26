Public Class frmOrdeñeConfig
    'No sé hacer consultas para esta ventana porque en base de datos no exsite la tabla y/o atributos y no nos dieron solucion alguna
    'Supone sacarse de una consulta...
    Private Sub frmOrdeñeConfig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = ordeñe + ", " + configuracion
        lblFinalp.Text = hora + " " + fin
        lblIniciop.Text = hora + " " + inicio
        lblFinals.Text = hora + " " + fin
        lblInicios.Text = hora + " " + inicio
        lblFinalt.Text = hora + " " + fin
        lblIniciot.Text = hora + " " + inicio
        gbxPrimer.Text = primer
        gbxSegundo.Text = segundo
        gbxTercer.Text = tercero
        lblOrdeñecant.Text = cantidad + "/" + ordeñe
        btnGuardar.Text = guardar
    End Sub

    Private Sub cbxCantidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxCantidad.SelectedIndexChanged
        If cbxCantidad.Text = "1" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = False
            gbxTercer.Enabled = False
        ElseIf cbxCantidad.Text = "2" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
            gbxTercer.Enabled = False
        ElseIf cbxCantidad.Text = "3" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
            gbxTercer.Enabled = True
        End If
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim acum As Integer
        If dtpIniciop.Value > dtpFinalp.Value Or dtpInicios.Value > dtpFinals.Value Or dtpIniciot.Value > dtpFinalt.Value Then
            acum = acum + 1
        End If
    End Sub
End Class