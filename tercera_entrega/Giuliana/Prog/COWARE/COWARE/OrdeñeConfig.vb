Public Class frmOrdenieConfig
    Dim Modifi(5) As String
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
                rs.Close()
            End If
        End If
        Modifi(0) = dtpIniciop.Text
        Modifi(1) = dtpFinalp.Text
        Modifi(2) = dtpInicios.Text
        Modifi(3) = dtpFinals.Text
        Modifi(4) = dtpIniciot.Text
        Modifi(5) = dtpFinalt.Text
        Modifi(6) = cbxCantidad.Text
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
        btnGuardar.Enabled = True
    End Sub
    Private Sub insertar(numero As Integer, horainicio As String, horafinal As String)
        sql = "insert into ordenie values (numero_ordenie, hora_inicio, hora_fin) values (" & numero & ", '" & horainicio & "', '" & horafinal & "')"
        execute_sql()
    End Sub
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim acum As Integer
        Dim aux As Integer
        Dim Modifi_now(6) As String
        Dim i As Integer
        If dtpIniciop.Value > dtpFinalp.Value Or dtpInicios.Value > dtpFinals.Value Or dtpIniciot.Value > dtpFinalt.Value Then
            acum = acum + 1
        End If
        If dtpFinalp.Value > dtpInicios.Value Or dtpFinals.Value > dtpIniciot.Value Then
            acum = acum + 1
        End If
        If acum = 0 Then
            If opcion = 10 Then
                If cbxCantidad.Text = "1" Then
                    insertar(1, dtpIniciop.Text, dtpFinalp.Text)
                ElseIf cbxCantidad.Text = "2" Then
                    insertar(1, dtpIniciop.Text, dtpFinalp.Text)
                    insertar(2, dtpInicios.Text, dtpFinals.Text)
                ElseIf cbxCantidad.Text = "3" Then
                    insertar(1, dtpIniciop.Text, dtpFinalp.Text)
                    insertar(2, dtpInicios.Text, dtpFinals.Text)
                    insertar(3, dtpIniciot.Text, dtpFinalt.Text)
                End If
            Else

                Modifi_now(0) = dtpIniciop.Text
                Modifi_now(1) = dtpFinalp.Text
                Modifi_now(2) = dtpInicios.Text
                Modifi_now(3) = dtpFinals.Text
                Modifi_now(4) = dtpIniciot.Text
                Modifi_now(5) = dtpFinalt.Text
                Modifi_now(6) = cbxCantidad.Text
                i = 0
                While i <= 5
                    If Modifi(i) <> Modifi_now(i) Then
                        Select Case i
                            Case 0
                                sql = "update ordenie set hora_inicio where numero_ordenie= 1"
                            Case 1
                                sql = "update ordenie set hora_fin where numero_ordenie= 1"
                            Case 2
                                sql = "update ordenie set hora_inicio where numero_ordenie= 2"
                            Case 3
                                sql = "update ordenie set hora_fin where numero_ordenie= 2"
                            Case 4
                                sql = "update ordenie set hora_inicio where numero_ordenie= 3"
                            Case 5
                                sql = "update ordenie set hora_fin where numero_ordenie= 3"
                            Case 6
                                If Modifi(i) < Modifi_now(i) Then

                                    aux = Modifi_now(i) - Modifi(i)

                                    Select Case aux
                                        Case 1
                                            If Modifi(i) = 1 Then
                                                insertar(2, dtpInicios.Text, dtpFinals.Text)
                                            Else
                                                insertar(3, dtpIniciot.Text, dtpFinalt.Text)
                                            End If
                                        Case 2
                                            insertar(3, dtpIniciot.Text, dtpFinalt.Text)
                                            insertar(2, dtpInicios.Text, dtpFinals.Text)
                                    End Select
                                Else
                                    aux = Modifi(i) - Modifi_now(i)
                                    Select Case aux
                                        Case 1
                                            If Modifi(i) = 1 Then
                                                sql = "delete from ordenie where num=3"
                                            Else
                                                sql = "delete from ordenie where num=2"
                                            End If
                                        Case 2
                                            sql = "delete from ordenie where num=2"
                                            execute_sql()
                                            sql = "delete from ordenie where num=3"
                                    End Select
                                    execute_sql()
                                End If
                        End Select
                    End If
                End While
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