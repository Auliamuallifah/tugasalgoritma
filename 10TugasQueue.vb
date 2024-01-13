Public Class TugasQueue
    Dim q As Queue = New Queue()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As String
        n = TextBox1.Text
        Console.WriteLine("Masuk Antrian : " + n)
        q.Enqueue(n)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ch As String
        Dim jumAntrian As Integer
        jumAntrian = q.Count
        Console.WriteLine("Jumlah Antrian : " + jumAntrian.ToString)
        If jumAntrian = 0 Then
            Label2.Text = "Belum Ada Antrian"
            Console.WriteLine("Belum Ada Antrian")
        Else
            ch = q.Dequeue()
            Label2.Text = ch
            Console.WriteLine("Keluar Antrian:" + ch)
        End If
    End Sub
End Class