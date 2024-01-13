<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramBelanjaSederhana
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txtbonus = New System.Windows.Forms.TextBox
        Me.txtharga = New System.Windows.Forms.TextBox
        Me.txtjumlah = New System.Windows.Forms.TextBox
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtdiskon = New System.Windows.Forms.TextBox
        Me.txtbayar = New System.Windows.Forms.TextBox
        Me.hitung = New System.Windows.Forms.Button
        Me.ulang = New System.Windows.Forms.Button
        Me.keluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bonus"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(112, 20)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(160, 20)
        Me.txtnama.TabIndex = 7
        '
        'txtbonus
        '
        Me.txtbonus.Location = New System.Drawing.Point(112, 276)
        Me.txtbonus.Name = "txtbonus"
        Me.txtbonus.Size = New System.Drawing.Size(160, 20)
        Me.txtbonus.TabIndex = 8
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(112, 55)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(97, 20)
        Me.txtharga.TabIndex = 9
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(112, 89)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(97, 20)
        Me.txtjumlah.TabIndex = 10
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(112, 173)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(97, 20)
        Me.txttotal.TabIndex = 11
        '
        'txtdiskon
        '
        Me.txtdiskon.Location = New System.Drawing.Point(112, 207)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(97, 20)
        Me.txtdiskon.TabIndex = 12
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(112, 241)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(97, 20)
        Me.txtbayar.TabIndex = 13
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(112, 128)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(75, 23)
        Me.hitung.TabIndex = 14
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'ulang
        '
        Me.ulang.Location = New System.Drawing.Point(193, 128)
        Me.ulang.Name = "ulang"
        Me.ulang.Size = New System.Drawing.Size(75, 23)
        Me.ulang.TabIndex = 15
        Me.ulang.Text = "Ulang"
        Me.ulang.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(112, 311)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 16
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'ProgramBelanjaSederhana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 337)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.ulang)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtbonus)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProgramBelanjaSederhana"
        Me.Text = "ProgramBelanjaSederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtbonus As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtdiskon As System.Windows.Forms.TextBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents ulang As System.Windows.Forms.Button
    Friend WithEvents keluar As System.Windows.Forms.Button
End Class
