Public Class frmPersonal
    Dim Modifi(6) As String
    Private Sub Personal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
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

        sql = "Select p.ci, p.apellido, p.Nombre from Persona p, tiene t where t.ci=p.ci and t.serie=" & Val(TSERIE)
        Open_sql()
        If rs.RecordCount <> 0 Then
            While Not rs.EOF()
                lbxEnlistar.Items.Add(rs(0).Value)
                lbxEnlistar.Items.Add("  " + rs(1).Value + " " + rs(2).Value)
                rs.MoveNext()
            End While
        End If
        rs.Close()

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
                If opcion <> 0 Then
                    tbxCI.Enabled = False
                    btnBuscar.Enabled = False
                    btnOpcion.Enabled = True
                    gbxDatos.Enabled = True
                    Select Case opcion
                        Case 1
                            Consultar_personal()
                            Modifi(0) = tbxNombre.Text
                            Modifi(1) = cbxSexo.Text
                            Modifi(2) = dtpNacimiento.Text
                            Modifi(3) = cbxPuesto.Text
                            Modifi(4) = tbxApellido.Text
                            Modifi(5) = tbxLogin.Text
                        Case 2
                            Consultar_personal()
                        Case 3
                            Consultar_personal()
                    End Select
                End If
            Else
                If rs.RecordCount = 0 And opcion = 0 Then
                    tbxCI.Enabled = False
                    btnBuscar.Enabled = False
                    btnOpcion.Enabled = True
                    gbxDatos.Enabled = True
                End If
            End If
        Else
            MsgBox(CI, MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
    Private Sub Consultar_personal()
        sql = "Select nombre, sexo, nacimiento, login, apellido from persona where ci=" & Val(tbxCI.Text)
        Open_sql()
        tbxNombre.Text = rs(0).Value
        cbxSexo.Text = rs(1).Value
        dtpNacimiento.Text = rs(2).Value
        tbxLogin.Text = rs(3).Value
        tbxApellido.Text = rs(4).Value
        rs.Close()

        sql = "Select c.nombre from persona p, cargo c, adquiere a where a.ci=p.ci and a.num_cargo=c.num  and p.ci=" & Val(tbxCI.Text)
        Open_sql()
        cbxPuesto.Text = rs(0).Value
        rs.Close()

        sql = "Select telefono from personatel where ci=" & Val(tbxCI.Text)
        Open_sql()
        cbxTelefono.Items.Clear()
        If rs.RecordCount <> 0 Then
            cbxTelefono.Text = rs(0).Value
            While Not rs.EOF()
                cbxTelefono.Items.Add(rs(0).Value)
                rs.MoveNext()
            End While
        End If
        rs.Close()
    End Sub

    Private Function Cargo_num(ByVal carg As String) As Integer
        Dim CAR As Integer
        If carg = auxiliar Then
            CAR = 0
        ElseIf carg = adm_establecimiento Then
            CAR = 1
        ElseIf carg = gerente Then
            CAR = 2
        ElseIf carg = adm_sistema Then
            CAR = 3
        Else
            MsgBox(puesto)
            Exit Function
        End If
        Return CAR
    End Function

    Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        Dim Modifi_Now(6) As String
        Dim CAR As Integer
        Dim change As Boolean = False
        Select Case opcion
            Case 0
                sql = "insert into persona(activo, ci, nombre, sexo, nacimiento, login) values ( 1," & Val(tbxCI.Text) & ", '" & tbxNombre.Text & "', '" & cbxSexo.Text & "', '" _
                    & dtpNacimiento.Text & "', '" & tbxLogin.Text & "')"
                execute_sql()
                sql = "insert into tiene(ci, serie) values (" & Val(tbxCI.Text) & ", " & Val(TSERIE) & ")"
                execute_sql()
                CAR = Cargo_num(cbxPuesto.Text)
                sql = "insert into adquiere(ci, num_cargo) values (" & Val(tbxCI) & ", " & CAR & ")"
                execute_sql()
            Case 1

                Modifi_Now(0) = tbxNombre.Text
                Modifi_Now(1) = cbxSexo.Text
                Modifi_Now(2) = dtpNacimiento.Text
                Modifi_Now(3) = cbxPuesto.Text
                Modifi_Now(4) = tbxApellido.Text
                Modifi_Now(5) = tbxLogin.Text
                Dim i As Integer = 0
                While i <= 6
                    If Modifi(i) <> Modifi_Now(i) Then
                        change = True
                        If change Then
                            sql = "update persona set nombre='" & tbxNombre.Text & "', sexo='" & cbxSexo.Text & "', nacimiento='" & dtpNacimiento.Text & "' where ci=" & Val(tbxCI.Text)
                            execute_sql()
                            sql = "update adquiere set num_cargo=" & cbxPuesto.Text & " where ci=" & Val(tbxCI.Text)
                            i = 8
                        End If
                    Else
                        i = i + 1
                    End If
                End While
            Case 3
                sql = "update persona set activo=0 where ci=" & Val(tbxCI.Text)
                execute_sql()
        End Select
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into personatel(ci, telefono) values (" & Val(tbxCI.Text) & ", '" & cbxTelefono.Text & "')"
        execute_sql()
        cbxTelefono.Items.Add(cbxTelefono.Text)
    End Sub

    Private Sub btnrem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrem.Click
        sql = "delete from personatel where ci= " & Val(tbxCI.Text) & " and telefono=" & Val(cbxTelefono.Text)
        execute_sql()
        cbxTelefono.Items.Remove(cbxTelefono.Text)
        Try
            cbxTelefono.Text = cbxTelefono.Items.Item(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pbxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub

    Private Sub pbxMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub

    Private Sub lbxEnlistar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxEnlistar.SelectedIndexChanged
        Dim selected As String
        selected = lbxEnlistar.SelectedItem.ToString()
        If IsNumeric(selected) And opcion <> 0 Then
            tbxCI.Text = selected
            Consultar_personal()
            btnBuscar.Enabled = False
            btnOpcion.Enabled = True
            If opcion <> 0 Then
                gbxDatos.Enabled = True
            End If

        End If
    End Sub
End Class