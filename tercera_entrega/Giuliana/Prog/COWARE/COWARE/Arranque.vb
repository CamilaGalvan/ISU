Public Class frmArranque

    Private Sub Arranque_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Lblpass.BackColor = Color.FromArgb(86, 116, 185)
        lblUser.BackColor = Color.FromArgb(86, 116, 185)
        cbxIdioma.BackColor = Color.FromArgb(86, 116, 185)
        gbxLog.BackColor = Color.FromArgb(86, 116, 185)
    End Sub

    Private Sub pbxClose_Click(sender As System.Object, e As System.EventArgs) Handles pbxClose.Click
        Me.Close()
    End Sub

    Private Sub pbxMini_Click(sender As System.Object, e As System.EventArgs) Handles pbxMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Pbxlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxgspot.Click
        Try
            CN.Open("MIODBC", tbxUser.Text, tbxPass.Text)
            conexion = 1
        Catch ex As Exception
            MsgBox("Error :" + usuario + " / " + contrasenia)
            Exit Sub
        End Try
        CN.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        If conexion = 1 Then
            Me.Hide()
            frmComienzo.Show()
        End If
    End Sub

    Private Sub cbxIdioma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxIdioma.SelectedIndexChanged
        If cbxIdioma.Text = "English" Then
            idioma = 1
        ElseIf cbxIdioma.Text = "Português" Then
            idioma = 2
        Else
            idioma = 0
        End If
        Variables_asignacion()
        Lblpass.Text = contrasenia
        lblUser.Text = usuario
    End Sub
End Class
