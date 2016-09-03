Public Class frmPersonal
    Dim Modifi(3) As String
    Private Sub Personal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblCI.Text() = CI
        lblPermiso.Text() = puesto
        lblNacimiento.Text = nacimiento
        lblNombre.Text = nombre
        lblTelefono.Text = telefono

        lblNacimiento.Text = nacimiento
        lblSexo.Text = sexo
        Boton_idioma(btnOpcion)
        Me.Text = personal + ", " + btnOpcion.Text
        btnBuscar.Text = buscar

        cbxSexo.Items.Clear()
        cbxSexo.Items.Add(hembra)
        cbxSexo.Items.Add(macho)

        cbxPuesto.Items.Clear()
        cbxPuesto.Items.Add(auxiliar)
        cbxPuesto.Items.Add(adm_establecimiento)
        cbxPuesto.Items.Add(gerente)
        cbxPuesto.Items.Add(adm_sistema)

        cbxTelefono.Items.Clear()
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
        acum = Validacion_numerica(tbxCI.Text, acum)
        acum = Validacion_largo(tbxCI, acum)
        If acum = 0 Then
            sql = "SELECT p.ci from Personal p, hay h where ci=" & Val(tbxCI.Text) & " and p.ci=h.ci and h.serie=" & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                tbxCI.Enabled = False
                btnBuscar.Enabled = False
                btnOpcion.Enabled = True
                gbxDatos.Enabled = True
                 Select btnOpcion.Text
                    Case ingresar

                    Case modificar
                        Consultar_personal()
                        Modifi(0) = tbxNombre.Text
                        Modifi(1) = cbxSexo.Text
                        Modifi(2) = dtpNacimiento.Text
                        Modifi(3) = cbxPuesto.Text
                    Case consultar
                        Consultar_personal()
                    Case eliminar
                        Consultar_personal()
                End Select

            Else
                MsgBox("Error :" + numero + " " + animal, "ERROR")
            End If
        Else
            MsgBox(CI, MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
    Private Sub Consultar_personal()
        sql = "Select nombre from persona where ci=" & Val(tbxCI.Text)
        Open_sql()
        tbxCI.Text = rs(0).Value

        sql = "Select sexo from persona where ci=" & Val(tbxCI.Text)
        Open_sql()
        cbxSexo.Text = rs(0).Value

        sql = "Select nacimiento from persona where ci=" & Val(tbxCI.Text)
        Open_sql()
        dtpNacimiento.Text = rs(0).Value

        sql = "Select puesto from persona where ci=" & Val(tbxCI.Text)
        Open_sql()
        cbxPuesto.Text = rs(0).Value

        sql = "Select telefono from personatel where ci=" & Val(tbxCI.Text)
        Open_sql()
        cbxTelefono.Items.Clear()
        If rs.RecordCount <> 0 Then
            While Not rs.EOF()
                cbxTelefono.Items.Add(rs(0).Value)
                rs.MoveNext()
            End While
        End If
    End Sub
    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
        Select Case btnOpcion.Text
            Case ingresar
                sql = "insert into persona(ci, nombre, sexo, nacimiento, puesto) values (" & Val(tbxCI.Text) & ", '" & tbxNombre.Text & "', '" & cbxSexo.Text & "', '" _
                    & dtpNacimiento.Text & "', '" & cbxPuesto.Text & "')"
                execute_sql()
                sql = "insert into tiene(ci, serie) values (" & Val(tbxCI.Text) & ", " & Val(TSERIE) & ")"
            Case modificar
                Dim Modifi_Now(8) As String
                Modifi_Now(0) = tbxNombre.Text
                Modifi_Now(1) = cbxSexo.Text
                Modifi_Now(2) = dtpNacimiento.Text
                Modifi_Now(3) = cbxPuesto.Text
                Dim i As Integer = 0
                While i <= 8
                    If Modifi(i) <> Modifi_Now(i) Then
                        Select Case i
                            Case 0
                                sql = "update persona set nombre=" & tbxNombre.Text & " where ci=" & Val(tbxCI.Text)
                            Case 1
                                sql = "update persona set sexo='" & cbxSexo.Text & "'  where ci=" & Val(tbxCI.Text)
                            Case 2
                                sql = "update persona set nacimiento='" & dtpNacimiento.Text & "'  where ci=" & Val(tbxCI.Text)
                            Case 3
                                sql = "update persona set puesto='" & cbxPuesto.Text & "'  where ci=" & Val(tbxCI.Text)
                        End Select
                        execute_sql()
                    End If
                    i = i + 1
                End While
            Case eliminar
                sql = "update persona set activo=0 where ci=" & Val(tbxCI.Text)
        End Select
    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        sql = "insert into personatel(ci, telefono) values (" & Val(tbxCI.Text) & ", '" & cbxTelefono.Text & "')"
        execute_sql()
        If rs.RecordCount <> 0 Then
            cbxTelefono.Items.Add(cbxTelefono.Text)
        End If
    End Sub

    Private Sub btnrem_Click(sender As System.Object, e As System.EventArgs) Handles btnrem.Click
        sql = "delete from personatel where num=" & Val(tbxCI.Text)
        execute_sql()
        If rs.RecordCount <> 0 Then
            cbxTelefono.Items.Remove(cbxTelefono.Text)
        End If
    End Sub
End Class