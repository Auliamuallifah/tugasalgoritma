Public Class HitungNilaiAkhir

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NilaiAbs As Byte
        Dim NilaiTugas As Byte
        Dim NilaiUTS As Byte
        Dim NilaiUAS As Byte
        Dim NilaiAkhir As Byte

        NilaiAbs = txtAbsensi.Text
        NilaiAbs = (NilaiAbs * 10) / 100
        txtHasilAbs.Text = NilaiAbs

        NilaiTugas = txtTugas.Text
        NilaiTugas = (NilaiTugas * 20) / 100
        txtHasilTugas.Text = NilaiTugas

        NilaiUTS = txtUTS.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        txtHasilUTS.Text = NilaiUTS

        NilaiUAS = txtUAS.Text
        NilaiUAS = (NilaiUAS * 40) / 100
        txtHasilUAS.Text = NilaiUAS

        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        txtNilaiAkhir.Text = NilaiAkhir



    End Sub

    Private Sub HitungNilaiAkhir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class