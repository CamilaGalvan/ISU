Public Class frmAlimento

    Private Sub frmAlimento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gbxLote.Hide()
        Select Case opcion
            Case 0
                Me.Text = alimento + ", " + almacenar
            Case 1
                Me.Text = alimento + ", " + otorgar
                gbxLote.Show()
            Case 2
                Me.Text = alimento + ", " + ingresar
            Case 4
                Me.Text = venta
                gbxDatos.Text = ""
                lblTipo.Location = New Point(255, 133)
                lblTipo.Text = litros
                cbxTipo.Hide()
        End Select
        If opcion < 4 Then
            gbxDatos.Text = tipo + "/" + alimento
            lblTipo.Text = tipo
            cbxTipo.Items.Clear()
            sql = "select a.tipo from alimento a, proporciona p, tambo t where a.num=p.num and p.serie=t.serie and t.serie=" & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                While Not rs.EOF()
                    cbxTipo.Items.Add(rs(0).Value)
                    rs.MoveNext()
                End While
            End If
            rs.Close()
        End If
        btnGuardar.Text = guardar
        lblFecha.Text = fecha
        lblHora.Text = hora
        lblCantidad.Text = cantidad
    End Sub


    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim acum As Integer
        Dim num As String
        Dim acum2 As Integer
        Dim max As Integer
        acum = 0
        acum = Validacion_numerica(tbxCantidad.Text, acum)
        sql = "Select num from alimento where tipo='" & cbxTipo.Text & "'"
        Open_sql()
        num = rs(0).Value
        If acum = 0 And rs.RecordCount <> 0 Then
            rs.Close()
            Select Case opcion
                Case 0
                    sql = "Insert into proporciona (serie_tambo,num_alimento, cantidad, fecha, hora) values (" & Val(TSERIE) & ", " & Val(num) & ", '" & tbxCantidad.Text & _
                        "', '" & dtpFecha.Text & "', '" & dtpHora.Text & "')"
                Case 1

                    acum2 = 0
                    acum2 = Validacion_numerica(tbxNumLote.Text, acum2)
                    If acum2 = 0 Then
                        sql = "Select num_hembra from produce where num_lote=" & tbxNumLote.Text
                        Try
                            rs.Open(sql, CN)
                        Catch ex As Exception
                            MsgBox("Error open", MsgBoxStyle.OkOnly, "ERROR")
                        End Try
                        If rs.RecordCount <> 0 Then
                            While Not rs.EOF()
                                sql = "Insert into se_da(num_alimento, num_animal, cantidad, fecha, hora) values (" & num & ", " & rs(0).Value & ", " & Val(tbxCantidad.Text) & _
                                 ", " & dtpFecha.Text & ", " & dtpHora.Text & ")"
                                execute_sql()
                            End While
                        End If
                        rs.Close()
                    Else
                        MsgBox("Error : " + num_lote, MsgBoxStyle.OkOnly, "ERROR")
                    End If


                Case 2
                    sql = "INSERT into alimento(tipo) values ('" & cbxTipo.Text & "')"
                Case 4
                    sql = "Select max(serie) from coperativa"
                    Open_sql()

                    max = Val(rs(0).Value) + 1
                    rs.Close()
                    sql = "INSERT into retira(serie_tanque, serie_coop, fecha, cantidad) values (" & Val(TSERIE) & ", " & max & ", '" & dtpFecha.Text & "', " & tbxCantidad.Text & ")"
            End Select
            execute_sql()
        Else
            MsgBox(cantidad, MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
End Class