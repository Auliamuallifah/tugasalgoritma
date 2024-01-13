Public Class operasibilangan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        If kali.Checked = True Then
            c = a * b
            MsgBox(c)
        ElseIf pangkat.Checked = True Then
            c = a ^ b
            MsgBox(c)
        ElseIf bagi.Checked = True Then
            c = a / b
            MsgBox(c)
        ElseIf tambah.Checked = True Then
            c = a + b
            MsgBox(c)
        ElseIf kurang.Checked = True Then
            c = a - b
            MsgBox(c)
        Else
            MsgBox("Wrong Input:")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class