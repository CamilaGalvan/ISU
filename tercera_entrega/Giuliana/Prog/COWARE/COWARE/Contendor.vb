Public Class frmContendor


    Private Sub btnIngresar_Animal_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar_Animal.Click
        frmAnimal.MdiParent = Me
        frmAnimal.Show()
        pnlMain.Hide()
    End Sub

    Private Sub frmContendor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class