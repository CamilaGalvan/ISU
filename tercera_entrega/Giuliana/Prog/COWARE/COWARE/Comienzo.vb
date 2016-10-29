Public Class frmComienzo

    Private Sub frmISU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Permiso()
        pnlMain.Dock = DockStyle.Fill
        btnConfiguracion_ordenie.Text = configuracion
        btnLote_animal.Text = lote
        btnControl_animal.Text = control
        cbxEnlistar.Items.Clear()
        cbxEnlistar.Items.Add("Holando")
        cbxEnlistar.Items.Add("Jersey")
        cbxEnlistar.Items.Add("Primer show")
        cbxEnlistar.Items.Add(vaca)
        cbxEnlistar.Items.Add(vaquillona)
        cbxEnlistar.Items.Add(ternera)
        cbxEnlistar.Items.Add(toro)
        cbxEnlistar.Items.Add(novillo)
        cbxEnlistar.Items.Add(anestro)
        cbxEnlistar.Items.Add(ternero)
        cbxEnlistar.Items.Add(ternera)
        cbxEnlistar.Items.Add(rodeo)
        cbxEnlistar.Items.Add(campo)
        cbxEnlistar.Items.Add(tambo)
        cbxEnlistar.Items.Add(servicio)
        cbxEnlistar.Items.Add(preniada)
        cbxEnlistar.Items.Add(lactancia)
        cbxEnlistar.Items.Add(hembra)
        cbxEnlistar.Items.Add(macho)
        cbxEnlistar.Items.Add(antibiotico)
        cbxEnlistar.Items.Add(ganado_act)
    End Sub

    Sub Permiso()
        If CN.State <> 1 Then
            MsgBox(conexion)
        Else
            sql = "select a.num_cargo from adquiere a, persona p where a.ci=p.ci and p.login ='" & frmArranque.tbxUser.Text & "'"
            If Open_sql() Then
                If rs.RecordCount() = 0 Then
                    MsgBox("Error : " + puesto)
                Else
                    Select Case rs(0).Value
                        Case 0 'auxiliar
                            gbxAnimal.Enabled = True
                            cbxTambo.Enabled = False
                            btnEliminar_Animal.Enabled = False
                            gbxAlimento.Enabled = True
                            gbxOrdenie.Enabled = True
                            btnEnlistar.Enabled = True
                            cbxTambo.Enabled = False
                            pbxVenta.Enabled = False
                        Case 1 'adm_establecimiento
                            gbxTambo.Enabled = True
                            gbxPersonal.Enabled = True
                            gbxAnimal.Enabled = True
                            gbxAlimento.Enabled = True
                            gbxOrdenie.Enabled = True
                            btnEliminar_Personal.Enabled = False
                            btnIngresar_Personal.Enabled = False
                            btnEnlistar.Enabled = True
                            cbxTambo.Enabled = False
                            btnLote_animal.Enabled = True
                            btnControl_animal.Enabled = True
                            btnConfiguracion_ordenie.Enabled = True
                        Case 2 'gerente
                            gbxTambo.Enabled = True
                            gbxPersonal.Enabled = True
                            btnEliminar_Personal.Enabled = False
                            btnIngresar_Personal.Enabled = False
                            btnModificar_Personal.Enabled = False
                            btnLote_animal.Enabled = True
                            btnControl_animal.Enabled = True
                            btnConfiguracion_ordenie.Enabled = True
                            gbxAnimal.Enabled = True
                            gbxAlimento.Enabled = True
                            gbxOrdenie.Enabled = True
                            btnEnlistar.Enabled = True
                        Case 3 'adm_sistema
                            gbxTambo.Enabled = True
                            gbxPersonal.Enabled = True
                            gbxAnimal.Enabled = True
                            gbxAlimento.Enabled = True
                            gbxOrdenie.Enabled = True
                            btnEnlistar.Enabled = True
                            btnLote_animal.Enabled = True
                            btnControl_animal.Enabled = True
                            btnConfiguracion_ordenie.Enabled = True
                    End Select
                    rs.Close()
                    sql = "select t.establecimiento from tambo t, persona p, tiene te where t.serie=te.serie and p.ci=te.ci and p.login='" & frmArranque.tbxUser.Text & "'"
                    Open_sql()
                    If rs.RecordCount <> 0 Then
                        cbxTambo.Text = rs(0).Value
                        rs.Close()
                        sql = "Select t.serie from tambo t, tiene e, persona p where establecimiento='" & cbxTambo.Text & "' and e.serie=t.serie and p.ci=e.ci and p.login='" & frmArranque.tbxUser.Text & "'"
                        Open_sql()
                        TSERIE = rs(0).Value
                        rs.Close()
                        sql = "select establecimiento from tambo"
                        Open_sql()
                        While Not rs.EOF()
                            cbxTambo.Items.Add(rs(0).Value)
                            rs.MoveNext()
                        End While
                        rs.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Cerrar()
        If rs.State <> 0 Then
            rs.Close()
        End If
        If CN.State <> 0 Then
            CN.Close()
        End If
    End Sub

    Private Sub pbxSalir_Click(sender As System.Object, e As System.EventArgs) Handles pbxSalir.Click
        frmArranque.Show()
        rs = Nothing
        CN = Nothing
        Cerrar()
        Me.Close()
    End Sub

    Private Sub pbxClima_Click(sender As System.Object, e As System.EventArgs) Handles pbxClima.Click
        frmClima.MdiParent = Me
        frmClima.Show()
        pnlMain.Hide()
    End Sub


    Private Sub btnIngresar_Animal_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar_Animal.Click
        opcion = 0
        frmAnimal.MdiParent = Me
        frmAnimal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Animal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Animal.Click
        opcion = 3
        frmAnimal.MdiParent = Me
        frmAnimal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Animal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Animal.Click
        opcion = 2
        frmAnimal.MdiParent = Me
        frmAnimal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnModificar_Animal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Animal.Click
        opcion = 1
        frmAnimal.MdiParent = Me
        frmAnimal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnIngresar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Tambo.Click
        opcion = 0
        frmTambo.MdiParent = Me
        frmTambo.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Tambo.Click
        opcion = 3
        frmTambo.MdiParent = Me
        frmTambo.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Tambo.Click
        opcion = 2
        frmTambo.MdiParent = Me
        frmTambo.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnModificar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Tambo.Click
        opcion = 1
        frmTambo.MdiParent = Me
        frmTambo.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnIngresar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        opcion = 0
        frmOrdenie.MdiParent = Me
        frmOrdenie.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        opcion = 3
        frmOrdenie.MdiParent = Me
        frmOrdenie.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Ordenie.Click
        opcion = 2
        frmOrdenie.MdiParent = Me
        frmOrdenie.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnModifcar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        opcion = 1
        frmOrdenie.MdiParent = Me
        frmOrdenie.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnOtorgar_Alimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtrogar_Alimento.Click
        opcion = 3
        frmAlimento.MdiParent = Me
        frmAlimento.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnAlmacenar_Alimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlmacenar_Alimento.Click
        opcion = 1
        frmAlimento.MdiParent = Me
        frmAlimento.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnIngresar_Alimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Alimento.Click
        opcion = 0
        frmAlimento.MdiParent = Me
        frmAlimento.Show()
        pnlMain.Hide()
    End Sub


    Private Sub btnIngresar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Personal.Click
        opcion = 0
        frmPersonal.MdiParent = Me
        frmPersonal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Personal.Click
        opcion = 3
        frmPersonal.MdiParent = Me
        frmPersonal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Personal.Click
        opcion = 2
        frmPersonal.MdiParent = Me
        frmPersonal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnModificar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Personal.Click
        opcion = 1
        frmPersonal.MdiParent = Me
        frmPersonal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub pbxVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxVenta.Click
        frmventa.MdiParent = Me
        frmventa.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnControl_animal_Click(sender As System.Object, e As System.EventArgs) Handles btnControl_animal.Click
        frmControl.MdiParent = Me
        frmControl.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnConfiguracion_ordenie_Click(sender As System.Object, e As System.EventArgs) Handles btnConfiguracion_ordenie.Click
        frmOrdenieConfig.MdiParent = Me
        frmOrdenieConfig.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnLote_Click(sender As System.Object, e As System.EventArgs) Handles btnLote_animal.Click
        frmLote.MdiParent = Me
        frmLote.Show()
        pnlMain.Hide()
    End Sub

    Private Sub cbxTambo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTambo.SelectedIndexChanged
        sql = "Select t.serie from tambo t where establecimiento='" & cbxTambo.Text & "'"
        Open_sql()
        TSERIE = rs(0).Value
        rs.Close()
    End Sub

    Private Sub pbxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxClose.Click
        frmArranque.Close()
    End Sub

    Private Sub pbxMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnEnlistar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnlistar.Click
        If cbxEnlistar.Text = "Holando" Then
            sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra from animal, hay h where raza= Holando and h.num=a.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = "Jersey" Then
            sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra from animal, hay h where raza= Jersey and h.num=a.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = "Primer Show" Then
            sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal where raza= Primer Show and h.num=a.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = vaca Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
                    "h.num = p.animal_num And e.nombre = '" & preniada & "' and e.num=estado.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = vaquillona Then
            opcion = 10
        ElseIf cbxEnlistar.Text = toro Then
            sql = "select  m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from macho m, animal a, hay h where castrado=0 and a.num=m.num and h.num=a.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = novillo Then
            sql = "select  m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra  from macho m, animal, hay h a where castrado=1 and a.num=m.num and h.num=a.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = anestro Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
                   "h.num = p.animal_num And e.nombre = '" & anestro & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = ternero Then
            sql = "select  c.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, cria c, hay y where c.num=a.num and sexo='" & macho _
                        & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = ternera Then
            sql = "select  c.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, cria c, hay y where c.num=a.num and sexo='" & hembra _
                        & " and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = rodeo Then
            sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & rodeo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = campo Then
            sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & campo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = tambo Then
            sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & tambo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = servicio Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, animal, hay y a where" + _
                   "h.num = p.animal_num And e.nombre = '" & servicio & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = preniada Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
                    "h.num = p.animal_num And e.nombre = '" & preniada & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = lactancia Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
                    "h.num = p.animal_num And e.nombre = '" & lactancia & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = seca Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
                    "h.num = p.animal_num And e.nombre = '" & seca & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = hembra Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, hay y, animal a where h.num = a.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = macho Then
            sql = "select m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from macho m, hay y, animal a where m.num = a.num and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = ganado_act Then
            sql = "Select  a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where activo = 1 and h.num=y.num and h.serie=" & Val(TSERIE)
        ElseIf cbxEnlistar.Text = antibiotico Then
            sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, animal a, hay y where" + _
                   "h.num = a.num And e.nombre = '" & antibiotico & "' and e.num=estado.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        End If
        frmEnlistar.Show()
    End Sub
End Class
