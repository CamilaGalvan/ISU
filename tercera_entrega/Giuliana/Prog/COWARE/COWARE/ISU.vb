Public Class frmISU

    Private Sub frmISU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Permiso()
        pnlMain.Dock = DockStyle.Fill
    End Sub

    Sub Permiso()
        If CN.State <> 1 Then
            MsgBox(conexion)
        Else
            sql = "select cargo from persona where login ='" & frmArranque.tbxUser.Text & "'"
            Open_sql()

            If rs.RecordCount() = 0 Then
                MsgBox("Error :" + puesto)
            Else
                Select Case rs(0).Value
                    Case 0 'auxiliar
                        gbxAnimal.Enabled = True
                        cbxTambo.Enabled = False
                        btnEliminar_Animal.Enabled = False
                        gbxAlimento.Enabled = True
                        gbxOrdenie.Enabled = True
                        'tsEnlistar.Enabled = True
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
                        'tsEnlistar.Enabled = True
                        cbxTambo.Enabled = False
                    Case 2 'gerente
                        gbxTambo.Enabled = True
                        gbxPersonal.Enabled = True
                        btnEliminar_Personal.Enabled = False
                        btnIngresar_Personal.Enabled = False
                        gbxAnimal.Enabled = True
                        gbxAlimento.Enabled = True
                        gbxOrdenie.Enabled = True
                        'tsEnlistar.Enabled = True
                    Case 3 'adm_sistema
                        gbxTambo.Enabled = True
                        gbxPersonal.Enabled = True
                        gbxAnimal.Enabled = True
                        gbxAlimento.Enabled = True
                        gbxOrdenie.Enabled = True
                        'tsEnlistar.Enabled = True
                End Select
                rs.Close()
                sql = "select t.establecimiento from tambo t, personal p, tiene te where t.serie=te.serie and p.ci=te.ci and p.login='" & frmArranque.tbxUser.Text & "'"
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
    End Sub

    Private Sub Cerrar()
        If rs.State <> 0 Then
            rs.Close()
        End If
        If CN.State <> 0 Then
            CN.Close()
        End If
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs)
        Cerrar()
        Me.Close()
        rs = Nothing
        CN = Nothing
    End Sub

    Private Sub tsHolando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra from animal, hay h where raza= Holando and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsJersey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra from animal, hay h where raza= Jersey and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsPrimerShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal where raza= Primer Show and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsVaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & preniada & "' and e.num=estado.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsVaquillona_Click(sender As System.Object, e As System.EventArgs)
        opcion = 10
        frmEnlistar.Show()
    End Sub

    Private Sub tsToro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select  m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from macho m, animal a, hay h where castrado=0 and a.num=m.num and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsNovillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select  m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra  from macho m, animal, hay h a where castrado=1 and a.num=m.num and h.num=a.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub TsAnestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & anestro & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsTernero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select  c.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, cria c, hay y where c.num=a.num and sexo='" & macho _
            & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsTernera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select  c.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, cria c, hay y where c.num=a.num and sexo='" & hembra _
            & " and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsRodeo_Click(sender As System.Object, e As System.EventArgs)
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & rodeo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsCampo_Click(sender As System.Object, e As System.EventArgs)
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & campo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsTamboe_Click(sender As System.Object, e As System.EventArgs)
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & tambo & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno_Click(sender As System.Object, e As System.EventArgs)
        sql = "select a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where lugar = '" & ninguno & "' and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub TsServicio_Click(sender As System.Object, e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, animal, hay y a where" + _
        "h.num = p.animal_num And e.nombre = '" & servicio & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub Tsprenada_Click(sender As System.Object, e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & preniada & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsLactancia_Click(sender As System.Object, e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & lactancia & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsSeca_Click(sender As System.Object, e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & seca & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno2_Click(sender As System.Object, e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, estado e, pasa p, hay y, animal a where" + _
        "h.num = p.animal_num And e.nombre = '" & ninguno & "' and p.estado_num=e.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsHembra_Click(sender As System.Object, e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, hay y, animal a where h.num = a.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsMacho_Click(sender As System.Object, e As System.EventArgs)
        sql = "select m.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from macho m, hay y, animal a where m.num = a.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsGanadoAct_Click(sender As System.Object, e As System.EventArgs)
        sql = "Select  a.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from animal a, hay y where activo = 1 and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsAntibiotico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, animal a, hay y where" + _
        "h.num = a.num And e.nombre = '" & antibiotico & "' and e.num=estado.num and a.num=h.num and h.num=y.num and h.serie=" & Val(TSERIE)
        frmEnlistar.Show()
    End Sub

    Private Sub tsAlimento_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEnlistar.Show()
    End Sub

    Private Sub tsConfiguracio_Click(sender As System.Object, e As System.EventArgs)
        frmOrdenieConfig.Show()
    End Sub

    Private Sub tsPrimerordenie_Click(sender As System.Object, e As System.EventArgs)
        frmOrdenie.Show()
    End Sub

    Private Sub tsSegundoordenie_Click(sender As System.Object, e As System.EventArgs)
        frmOrdenie.Show()
    End Sub

    Private Sub tsTercerordenie_Click(sender As System.Object, e As System.EventArgs)
        frmOrdenie.Show()
    End Sub

    Private Sub tsPersonalIngresar_Click(sender As System.Object, e As System.EventArgs)
        opcion = 0
        frmPersonal.Show()
    End Sub

    Private Sub tsVenta_Click(sender As System.Object, e As System.EventArgs)
        opcion = 4
        frmAlimento.Show()
    End Sub

    Private Sub pbxSalir_Click(sender As System.Object, e As System.EventArgs) Handles pbxSalir.Click
        frmArranque.Show()
        rs = Nothing
        CN = Nothing
        Cerrar()
        Me.Close()
    End Sub

    Private Sub pbxClima_Click(sender As System.Object, e As System.EventArgs) Handles pbxClima.Click
        frmClima.Show()
    End Sub


    Private Sub btnIngresar_Animal_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar_Animal.Click
        opcion = 0
        frmAnimal.MdiParent = Me
        frmAnimal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Animal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Animal.Click
        opcion = 3
        frmAnimal.Show()
        frmAnimal.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Animal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Animal.Click
        opcion = 2
        frmAnimal.Show()
        frmAnimal.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnModificar_Animal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Animal.Click
        opcion = 1
        frmAnimal.Show()
        frmAnimal.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnIngresar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Tambo.Click
        opcion = 0
        frmTambo.Show()
        frmTambo.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Tambo.Click
        opcion = 3
        frmTambo.Show()
        frmTambo.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Tambo.Click
        opcion = 2
        frmTambo.Show()
        frmTambo.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnModificar_Tambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Tambo.Click
        opcion = 1
        frmTambo.Show()
        frmTambo.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnIngresar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Ordenie.Click
        opcion = 0
        frmOrdenie.Show()
        frmOrdenie.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Ordenie.Click
        opcion = 3
        frmOrdenie.Show()
        frmOrdenie.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Ordenie.Click
        opcion = 2
        frmOrdenie.Show()
        frmOrdenie.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnModifcar_Ordenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifcar_Ordenie.Click
        opcion = 1
        frmOrdenie.Show()
        frmOrdenie.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnIngresar_Alimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Alimento.Click
        opcion = 0
        frmAlimento.Show()
        frmAlimento.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Alimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Alimento.Click
        opcion = 3
        frmAlimento.Show()
        frmAlimento.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Alimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Alimento.Click
        opcion = 2
        frmAlimento.Show()
        frmAlimento.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnModificar_Alimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Alimento.Click
        opcion = 1
        frmAlimento.Show()
        frmAlimento.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnIngresar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Personal.Click
        opcion = 0
        frmPersonal.Show()
        frmPersonal.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnEliminar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Personal.Click
        opcion = 3
        frmPersonal.Show()
        frmPersonal.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnConsultar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_Personal.Click
        opcion = 2
        frmPersonal.Show()
        frmPersonal.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub btnModificar_Personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Personal.Click
        opcion = 1
        frmPersonal.Show()
        frmPersonal.MdiParent = Me
        pnlMain.Hide()
    End Sub

    Private Sub pbxVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxVenta.Click
        opcion = 4
        frmAlimento.Show()
        frmAlimento.MdiParent = Me
        pnlMain.Hide()
    End Sub
End Class
