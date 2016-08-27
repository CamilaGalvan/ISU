Public Class frmEnlistar
    Public Sub Open_sql(rs As ADODB.Recordset)
        Try
            rs.Open(sql, CN)
        Catch ex As Exception
            MsgBox("Error open", MsgBoxStyle.OkOnly, "ERROR")
        End Try
    End Sub
    Private Sub frmEnlistar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbxEnlistar.Items.Clear()
        Me.Text = animal + ", " + enlistar

        If opcion = 10 Then
            Dim rs2 As New ADODB.Recordset
            Open_sql(rs2)
            If rs.RecordCount <> 0 Then
                While Not rs2.EOF()
                    Dim i As Integer
                    Dim aux As Boolean
                    aux = False
                    sql = "select h.num, raza, nacimiento, lugar, progenitor_macho, progenitor_hembra from hembra h, hay y where h.num=y.num and h.num <>" & _
                     rs2(0).Value & " h.serie=" & Val(TSERIE)
                    Open_sql(rs)
                    If rs.RecordCount <> 0 Then
                        For i = 0 To lbxEnlistar.Items.Count - 1
                            If rs(0).Value = lbxEnlistar.Items(i) Then
                                aux = True
                            End If
                        Next
                        If aux = False Then
                            lbxEnlistar.Items.Add(rs(0).Value)
                        End If
                    End If
                End While
                rs2.Close()
            End If
        Else
            Open_sql(rs)
            If rs.RecordCount <> 0 Then
                While Not rs.EOF()
                    lbxEnlistar.Items.Add(rs(0).Value)
                    rs.MoveNext()
                End While
            End If
        End If
        rs.Close()
    End Sub
End Class