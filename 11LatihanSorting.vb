Public Class LatihanSorting
    Dim data() As Integer = {95, 70, 75, 88, 90, 74, 83}
    Function BubbleSort(ByRef data As Integer())
        For i = 1 To (data.Length - 1)
            For j = 0 To ((data.Length - 1) - i)
                If data(j) > data(j + 1) Then
                    data(j) = data(j) Xor data(j + 1)
                    data(j + 1) = data(j + 1) Xor data(j)
                    data(j) = data(j) Xor data(j + 1)
                End If
            Next
        Next
        Return data
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dataUrut = BubbleSort(data)
        Console.WriteLine("Data Setelah Diurutkan")
        For i = 0 To (dataUrut.Lenght - 1)
            Console.WriteLine(dataUrut(i))
        Next
    End Sub

    Private Sub LatihanSorting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Console.WriteLine("Data sebelum diurutkan")
        For i = 0 To (data.Length - 1)
            Console.WriteLine(data(i))
        Next
        Console.WriteLine("==========================")
    End Sub
End Class