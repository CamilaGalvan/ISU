Public Class frmPersonal

    Private Sub Personal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblCI.Text() = CI
        lblPermiso.Text() = puesto
        lblNacimiento.Text = nacimiento
        lblNombre.Text = nombre

        lblNacimiento.Text = nacimiento
        lblSexo.Text = sexo
        Boton_idioma(btnOpcion)
        Me.Text = personal + ", " + btnOpcion.Text
        If opcion = 2 Then
            Me.Text = Me.Text + consultar
        End If
        btnBuscar.Text = buscar

        cbxSexo.Items.Clear()
        cbxSexo.Items.Add(hembra)
        cbxSexo.Items.Add(macho)

        cbxPuesto.Items.Clear()
        cbxPuesto.Items.Add(auxiliar)
        cbxPuesto.Items.Add(adm_establecimiento)
        cbxPuesto.Items.Add(gerente)
        cbxPuesto.Items.Add(adm_sistema)
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxCI.Text, acum)
        acum = Validacion_largo(tbxCI, acum)
        If acum = 0 Then
            sql = "SELECT * from Personal where num=" & Val(tbxCI.Text)
            Try
                rs.Open(sql, CN)
            Catch ex As Exception
                MsgBox("Error ", MsgBoxStyle.OkOnly, "ERROR")
            End Try
            'If rs.RecordCount <> 0 Then
            tbxCI.Enabled = False
            btnBuscar.Enabled = False
            btnOpcion.Enabled = True
            gbxDatos.Enabled = True
            'Else
            '   MsgBox("Error :" + numero + " " + animal, "ERROR")
            'End If
        Else
            MsgBox(CI, MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
        Select Case opcion
            Case 0 'ingresar
            Case 1 'modificar
            Case 2 ' consultar
            Case 3 'eliminar
        End Select
    End Sub
End Class