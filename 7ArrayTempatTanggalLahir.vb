Public Class ArrayTempatTanggalLahir

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Arr(5) As String
        Arr(0) = txtnama.Text
        Arr(1) = txttempat.Text
        Arr(2) = cmbtanggal.Text
        Arr(3) = cmbbulan.Text
        Arr(4) = cmbtahun.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        listitem.SubItems.Add(Arr(4))
        txtnama.Text = ""
        txttempat.Text = ""
        cmbtanggal.Text = ""
        cmbbulan.Text = ""
        cmbtahun.Text = ""
        txtnama.Focus()

    End Sub

    Private Sub Array_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Deklarasi Tampilan ComboBox
        Dim i As Integer
        For i = 1 To 31
            cmbtanggal.Items.Add(i)
        Next

        Dim j As Integer
        For j = 1 To 12
            cmbbulan.Items.Add(j)
        Next

        Dim k As Integer
        For k = 1970 To 2023
            cmbtahun.Items.Add(k)
        Next

        'Deklarasi ListView
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Nama Lengkap")
        ListView1.Columns.Add("Tempat Lahir")
        ListView1.Columns.Add("Tanggal Lahir")
        ListView1.Columns.Add("Bulan Lahir")
        ListView1.Columns.Add("Tahun Lahir")
        txtnama.Focus()

    End Sub
End Class