Public Class ProgramBelanjaSederhana

    Private Sub ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulang.Click
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        txtdiskon.Text = ""
        txtbayar.Text = ""
        txtbonus.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        End
    End Sub

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String

        'Deklarasi Input Harga dan Jumlah
        harga = txtharga.Text
        jumlah = txtjumlah.Text

        'Perhitungan Total Harga
        total = harga * jumlah

        'Penentuan Diskon dan Bonus
        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Pinggang"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Pena"
        Else
            diskon = 0
            bonus = "Tidak Ada"
        End If

        'Perhitungan Total Bayar
        bayar = total - diskon

        'Deklarasi keluaran total harga, diskon, total bayar, dan bonus
        txttotal.Text = total
        txtdiskon.Text = diskon
        txtbayar.Text = bayar
        txtbonus.Text = bonus
    End Sub
End Class