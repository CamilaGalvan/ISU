Public Class frmTambo
    Dim Modifi(3) As String
    Private Sub Tambo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Boton_idioma(btnOpcion)
        Me.Text = tambo + ", " + btnOpcion.Text
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
        tbxSerie.Text = TSERIE
        tbxSerie.Enabled = False
        Select Case opcion
            Case 0 'ingresar
                sql = "Select max(serie) from tambo"
                Open_sql()
                tbxSerie.Text = Val(Val(rs(0).Value) + 1)
                rs.Close()
            Case 1 'modificar
                Consultar_Tambo()
                Modifi(0) = tbxNombre.Text
                Modifi(1) = tbxHectareas.Text
                Modifi(2) = tbxGanado_max.Text
            Case 2 'consultar
                Consultar_Tambo()
            Case 3 'eliminar
                btnBuscar.Enabled = False
                tbxSerie.Enabled = True
                btnBuscar.Enabled = True
                gbxGeneral.Enabled = False
        End Select
    End Sub

    Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        Dim acum As Integer
        Dim Modifi_now(3) As String
        Dim i As Integer
        Dim change As Boolean = False
        acum = 0
        acum = Validacion_numerica(tbxGanado_max.Text, acum)
        acum = Validacion_numerica(tbxHectareas.Text, acum)
        If acum = 0 Then
            Select Case opcion
                Case 0
                    sql = "insert into tambo(establecimiento, hectareas, ganado_max) values ('" & tbxNombre.Text & "', " & Val(tbxHectareas.Text) & ", " & Val(tbxGanado_max.Text) & ")"
                Case 1
                    Modifi_now(0) = tbxNombre.Text
                    Modifi_now(1) = tbxHectareas.Text
                    Modifi_now(2) = tbxGanado_max.Text
                    i = 0
                    While i <= 3 And change = False
                        If Modifi(i) <> Modifi_now(i) Then
                            change = True
                            If change Then
                                sql = "update tambo set establecimiento='" & tbxNombre.Text & "', hectareas=" & Val(tbxHectareas.Text) & ", ganado_max=" & Val(tbxGanado_max.Text) & "  where serie=" & Val(TSERIE)
                                i = 4
                            End If
                        Else
                            i = i + 1
                        End If
                    End While
                Case 3
                    sql = "delete from tambo where serie=" & Val(tbxSerie.Text)
            End Select
            execute_sql()
        Else
            MsgBox("", MsgBoxStyle.OkOnly, "ERROR")
        End If

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        sql = "SELECT * from Tambo where serie=" & Val(tbxSerie.Text)
        Open_sql()
        If rs.RecordCount <> 0 Then
            tbxSerie.Enabled = False
            btnBuscar.Enabled = False
            gbxGeneral.Enabled = True
            btnOpcion.Enabled = True
            rs.Close()
            Consultar_Tambo()
        Else
            rs.Close()
            MsgBox("Error :" + serie + " " + tambo)
        End If
    End Sub

    Private Sub Consultar_Tambo()
        sql = "Select establecimiento, hectareas, ganado_max from tambo where serie=" & Val(tbxSerie.Text)
        Open_sql()
        tbxNombre.Text = rs(0).Value
        tbxHectareas.Text = rs(1).Value
        tbxGanado_max.Text = rs(2).Value
        rs.Close()
        sql = "select t.num_serie from tanque t, posee p, tambo ta where p.serie_tanque=t.num_serie and p.serie_tambo=ta.serie and ta.serie =" & Val(TSERIE)
        Open_sql()
        If rs.RecordCount <> 0 Then
            tbxNserie.Text = rs(0).Value
            rs.Close()
            sql = "select t.capacidad from tanque t, posee p, tambo ta where p.serie_tanque=t.num_serie and p.serie_tambo=ta.serie and ta.serie =" & Val(TSERIE)
            'E: AGARRA 50 DE 500.0000000
            Open_sql()
            tbxCapacidad.Text = rs(0).Value
            rs.Close()
        End If
    End Sub

    Private Sub btnTanque_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTanque_Agregar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxCapacidad.Text, acum)
        acum = Validacion_numerica(tbxNserie.Text, acum)
        If acum = 0 Then
            sql = "Select * from tanque where serie=" & Val(tbxNserie.Text)
            If rs.RecordCount = 0 Then
                rs.Close()
                sql = "insert into tanque(num_serie, capacidad) values (" & Val(tbxNserie.Text) & ", " & Val(tbxCapacidad.Text) & ")"
                execute_sql()
                sql = "insert into posee(serie_tambo, serie_tanque) values (" & Val(tbxSerie.Text) & ", " & Val(tbxNserie.Text) & ")"
                execute_sql()
            End If
        Else
            MsgBox("Error :" + serie + " " + tanque)
        End If
    End Sub

    Private Sub btnTanque_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTanque_Quitar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNserie.Text, acum)
        If acum = 0 Then
            sql = "Delete From posee Where serie_tanque = " & Val(tbxNserie.Text)
            execute_sql()
            sql = "Delete From tanque Where Num_serie = " & Val(tbxNserie.Text)
            execute_sql()
        End If
    End Sub

    Private Sub pbxMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub

    Private Sub pbxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub
End Class