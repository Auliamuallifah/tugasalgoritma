Public Class MenghitungJarak

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim kecepatan As Double
        Dim waktutempuh As Double
        Dim jarak As Double
        kecepatan = txtkecepatan.Text
        waktutempuh = txtwaktu.Text
        jarak = kecepatan * waktutempuh
        txtjarak.Text = jarak
        ListBox1.Items.Add(jarak)
    End Sub
End Class