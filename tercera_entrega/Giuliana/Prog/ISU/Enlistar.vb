﻿Public Class frmEnlistar
    
    Private Sub frmEnlistar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbxEnlistar.Items.Clear()
        Me.Text = animal + ", " + enlistar
        Open_sql()
        If rs.RecordCount <> 0 Then
            While Not rs.EOF()
                lbxEnlistar.Items.Add(rs(0).Value)
                rs.MoveNext()
            End While
        End If

        rs.Close()
    End Sub
End Class