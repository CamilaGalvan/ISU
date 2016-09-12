Imports System.Net
Public Class frmClima
    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable Then
            If rbnPag.Checked = True Then
                WebBrowser1.Navigate("http://www.meteorologia.com.uy/")
            Else
                WebBrowser1.Navigate("https://www.eltiempo.es/el-mundo")
            End If
        Else
            MsgBox("Error, Internet")
        End If   
    End Sub
End Class