Public Class frmOrdenieConfig
    Private Sub frmordenieConfig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = ordenie + ", " + configuracion
        lblFinalp.Text = hora + " " + fin
        lblIniciop.Text = hora + " " + inicio
        lblFinals.Text = hora + " " + fin
        lblInicios.Text = hora + " " + inicio
        lblFinalt.Text = hora + " " + fin
        lblIniciot.Text = hora + " " + inicio
        gbxPrimer.Text = primer
        gbxSegundo.Text = segundo
        gbxTercer.Text = tercero
        lblOrdeniecant.Text = cantidad + "/" + ordenie
        btnGuardar.Text = guardar
        sql = "select numero_ordenie from ordenie where numero_ordenie=3"
        Open_sql()
        If rs.RecordCount <> 0 Then
            cbxCantidad.Text = 3
            Horas(dtpIniciop, dtpFinalp, 1)
            Horas(dtpInicios, dtpFinals, 2)
            Horas(dtpIniciot, dtpFinalt, 3)
        Else
            rs.Close()
            sql = "select numero_ordenie from ordenie where numero_ordenie=2"
            Open_sql()
            If rs.RecordCount <> 0 Then
                cbxCantidad.Text = 2
                Horas(dtpIniciop, dtpFinalp, 1)
                Horas(dtpInicios, dtpFinals, 2)
            Else
                rs.Close()
                sql = "select numero_ordenie from ordenie where numero_ordenie=1"
                Open_sql()
                If rs.RecordCount <> 0 Then
                    cbxCantidad.Text = 1
                    Horas(dtpIniciop, dtpFinalp, 1)
                Else
                    opcion = 10
                End If
            End If
            rs.Close()
        End If
        cbxCantidad_SelectedIndexChanged(sender, e)
    End Sub


    Public Sub Horas(ByVal dtpI As DateTimePicker, ByVal dtpF As DateTimePicker, num As Integer)
        sql = "select hora_inicio from ordenie where numero_ordenie=" & num
        Open_sql()
        dtpI.Text = rs(0).Value
        rs.Close()
        sql = "select hora_fin from ordenie where numero_ordenie=" & num
        Open_sql()
        dtpI.Text = rs(0).Value
        rs.Close()
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
        If Val(cbxCantidad.Text) < 3 Then
            sql = "Select * from parametros where numero_ordenie=3 and serie_tambo=" & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                sql = "delete from parametros where numero_ordenie=3 and serie_tambo=" & Val(TSERIE)
            End If
            rs.Close()
        End If
        If Val(cbxCantidad.Text) < 2 Then
            sql = "Select * from parametros where numero_ordenie=2 and serie_tambo=" & Val(TSERIE)
            Open_sql()
            If rs.RecordCount <> 0 Then
                sql = "delete from parametros where numero_ordenie=2 and serie_tambo=" & Val(TSERIE)
            End If
            rs.Close()
        End If
        btnGuardar.Enabled = True
    End Sub
    Private Sub insertar(numero As Integer, horainicio As String, horafinal As String)
        sql = "insert into parametros values (numero_ordenie, hora_inicio, hora_fin, serie_tambo) values (" & numero & ", '" & horainicio & "', '" & horafinal & "', " & Val(TSERIE) & ")"
        execute_sql()
    End Sub
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim acum As Integer
        Dim Modifi_now(6) As String
        If dtpIniciop.Value > dtpFinalp.Value Or dtpInicios.Value > dtpFinals.Value Or dtpIniciot.Value > dtpFinalt.Value Then
            acum = acum + 1
        End If
        If dtpFinalp.Value > dtpInicios.Value Or dtpFinals.Value > dtpIniciot.Value Then
            acum = acum + 1
        End If
        If acum = 0 Then
            If Val(cbxCantidad.Text) >= 1 Then
                sql = "Select * from parametros where numero_ordenie=1 and serie_tambo=" & Val(TSERIE)
                Open_sql()
                If rs.RecordCount = 0 Then
                    insertar(1, dtpIniciop.Text, dtpFinalp.Text)
                Else
                    sql = "update ordenie set hora_inicio=" & dtpIniciop.Text & ", hora_fin=" & dtpFinalp.Text & " where numero_ordenie=1 and serie_tambo=" & Val(TSERIE)
                End If
                rs.Close()
            End If
            If Val(cbxCantidad.Text) >= 2 Then
                sql = "Select * from parametros where numero_ordenie=2 and serie_tambo=" & Val(TSERIE)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    rs.Close()
                    insertar(2, dtpIniciop.Text, dtpFinalp.Text)
                Else
                    sql = "update ordenie set hora_inicio=" & dtpIniciop.Text & ", hora_fin=" & dtpFinalp.Text & " where numero_ordenie=2 and serie_tambo=" & Val(TSERIE)
                End If
                rs.Close()
            End If
            If Val(cbxCantidad.Text) = 3 Then
                sql = "Select * from parametros where numero_ordenie=3 and serie_tambo=" & Val(TSERIE)
                Open_sql()
                If rs.RecordCount <> 0 Then
                    rs.Close()
                    insertar(2, dtpIniciop.Text, dtpFinalp.Text)
                Else
                    sql = "update ordenie set hora_inicio=" & dtpIniciop.Text & ", hora_fin=" & dtpFinalp.Text & " where numero_ordenie=3 and serie_tambo=" & Val(TSERIE)
                End If
                rs.Close()
            End If
        End If

    End Sub

    Private Sub pbxMini_Click(sender As System.Object, e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
        frmComienzo.pnlMain.Show()
    End Sub

    Private Sub pbxClose_Click(sender As System.Object, e As System.EventArgs) Handles pbxClose.Click
        frmComienzo.pnlMain.Show()
        Me.Close()
    End Sub
End Class