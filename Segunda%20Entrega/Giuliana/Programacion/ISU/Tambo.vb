Public Class frmTambo

    Private Sub Tambo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Boton_idioma(btnOpcion)
        Me.Text = tambo + ", " + btnOpcion.Text
        If opcion = 2 Then
            Me.Text = Me.Text + consultar
        End If
        lblganado_max.Text = ganado_max
        lblHectareas.Text = hectareas
        lblNombre.Text = nombre
        lblSerie.Text = serie
        btnBuscar.Text = buscar
        gbxTanque.Text = tanque
        lblNSerie.Text = numero + " " + serie
        lblCapacidad.Text = capacidad
        btnTanque_Agregar.Text = agregar
        btnTanque_Quitar.Text = eliminar
        btnTanque_Consultar.Text = consultar

    End Sub


    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
        Select Case opcion
            Case 0
                Dim acum As Integer
                acum = 0

                acum = Validacion_numerica(tbxCapacidad.Text, acum)
                acum = Validacion_numerica(tbxGanado_max.Text, acum)
                acum = Validacion_numerica(tbxHectareas.Text, acum)
                If acum = 0 Then
                    'ingresar, verifivar qe los kmps no estem vacios
                Else
                    MsgBox("", MsgBoxStyle.OkOnly, "ERROR")
                End If
            Case 1 'modificar, conultar y guardar
            Case 2 ' consultar
            Case 3 'eliminar, consultar
                'consultar si o sii funcion o procedimiento
        End Select
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        sql = "SELECT * from Tambo where num=" & Val(tbxSerie.Text)
        Sentencia("select", sql)
        'If rs.RecordCount <> 0 Then
        tbxSerie.Enabled = False
        btnBuscar.Enabled = False
        gbxGeneral.Enabled = True
        btnOpcion.Enabled = True
        'Else
        '   MsgBox("Error :" + numero + " " + animal, "ERROR")
        'End If 
    End Sub


End Class