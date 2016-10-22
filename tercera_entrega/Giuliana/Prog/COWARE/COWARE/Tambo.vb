Public Class frmTambo
    Dim Modifi(3) As String
    Private Sub Tambo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        btnTanque_Consultar.Text = consultar
        tbxSerie.Text = TSERIE
        tbxSerie.Enabled = False
        If opcion = 0 Then

        Else
            tbxSerie.Enabled = False
            btnBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub btnOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcion.Click
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
                    sql = "insert into tambo(serie, nombre, hectareas, ganado_max) values (" & Val(tbxSerie.Text) & ", '" & tbxNombre.Text & "', " & Val(tbxHectareas.Text) & ", " & Val(tbxGanado_max.Text)
                Case 1
                    Modifi_now(0) = tbxNombre.Text
                    Modifi_now(1) = tbxHectareas.Text
                    Modifi_now(2) = tbxGanado_max.Text
                    i = 0
                    While i <= 3 And change = False
                        If Modifi(i) <> Modifi_now(i) Then
                            change = True
                            If change Then
                                sql = "update tambo set establecimiento='" & tbxNombre.Text & "' and hectareas=" & Val(tbxHectareas.Text) & " and ganado_max=" & Val(tbxGanado_max.Text) & "  where serie=" & Val(TSERIE)
                                execute_sql()
                                i = 4
                            End If
                        Else
                            i = i + 1
                        End If
                    End While
                Case 3
                    sql = "update tambo set activo=0 where serie=" & Val(TSERIE)
            End Select
        Else
            MsgBox("", MsgBoxStyle.OkOnly, "ERROR")
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        sql = "SELECT * from Tambo where serie=" & Val(tbxSerie.Text)
        Open_sql()
        If rs.RecordCount <> 0 Then
            tbxSerie.Enabled = False
            btnBuscar.Enabled = False
            gbxGeneral.Enabled = True
            btnOpcion.Enabled = True
            rs.Close()
            Select Case btnOpcion.Text
                Case ingresar
                    sql = "Select max(serie) from tambo"
                    Open_sql()
                    tbxSerie.Text = Val(Val(rs(0).Value) + 1)
                    rs.Close()
                Case modificar
                    Consultar_Tambo()
                    Modifi(0) = tbxNombre.Text
                    Modifi(1) = tbxHectareas.Text
                    Modifi(2) = tbxGanado_max.Text
                Case consultar
                    Consultar_Tambo()
                Case eliminar
                    Consultar_Tambo()
            End Select
        Else
            rs.Close()
            MsgBox("Error :" + numero + " " + animal, "ERROR")
        End If
    End Sub

    Private Sub Consultar_Tambo()
        sql = "Select establecimiento from tambo where serie=" & Val(tbxSerie.Text)
        Open_sql()
        tbxNombre.Text = rs(0).Value
        rs.Close()
        sql = "Select hectareas from tambo where serie=" & Val(tbxSerie.Text)
        Open_sql()
        tbxHectareas.Text = rs(0).Value
        rs.Close()
        sql = "Select ganado_max from tambo where serie=" & Val(tbxSerie.Text)
        Open_sql()
        tbxGanado_max.Text = rs(0).Value
        rs.Close()
        sql = "select t.num_serie from tanque t, posee p, tambo ta where p.serie_tanque=t.num_serie and p.serie_tambo=ta.serie and ta.serie =" & Val(TSERIE)
        Open_sql()
        tbxNserie.Text = rs(0).Value
        rs.Close()
        sql = "select t.capacidad from tanque t, posee p, tambo ta where p.serie_tanque=t.num_serie and p.serie_tambo=ta.serie and ta.serie =" & Val(TSERIE)
        'AGARRA 50 DE 500.0000000
        Open_sql()
        tbxCapacidad.Text = rs(0).Value
        rs.Close()
    End Sub

    Private Sub btnTanque_Consultar_Click(sender As System.Object, e As System.EventArgs) Handles btnTanque_Consultar.Click
        sql = "select t.serie, t.capacidad from tanque t, almacena a, produce p, hay h, tambo o where t.serie=a.serie and a.tipo=p.tipo and p.num=h.num and o.serie =" & Val(TSERIE)
        Open_sql()
        frmEnlistar.Show()
    End Sub

    Private Sub btnTanque_Agregar_Click(sender As System.Object, e As System.EventArgs) Handles btnTanque_Agregar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxCapacidad.Text, acum)
        acum = Validacion_numerica(tbxNserie.Text, acum)
        If acum = 0 Then
            sql = "insert into tanque(num_serie, capacidad) values (" & Val(tbxNserie.Text) & ", " & Val(tbxCapacidad.Text) & ")"
            execute_sql()
        End If
    End Sub

    Private Sub btnTanque_Quitar_Click(sender As System.Object, e As System.EventArgs) Handles btnTanque_Quitar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNserie.Text, acum)
        If acum = 0 Then
            sql = "Delete From tanque Where Num_serie = " & tbxNserie.Text
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