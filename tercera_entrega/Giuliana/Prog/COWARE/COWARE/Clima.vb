Imports System.Net
Public Class frmClima
    Private Sub frmClima_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.Text = clima
        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable Then
            If cbxInUMet.Checked = True Then
                WebBrowser1.Navigate("http://www.meteorologia.com.uy/")
            Else
                WebBrowser1.Navigate("https://www.wunderground.com/")
            End If
        Else
            MsgBox("Error, Internet")
        End If
    End Sub

    Private Sub cbxInUMet_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxInUMet.CheckedChanged
        frmClima_Load(sender, e)
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