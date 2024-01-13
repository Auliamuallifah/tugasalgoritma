Public Class Perulangan

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = txtteks.Text
        jumlah = txtjumlah.Text
        For i = 1 To jumlah
            List1.Items.Add(teks)
        Next i
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtteks.Text = ""
        txtjumlah.Text = ""
        List1.Items.Clear()
    End Sub
End Class