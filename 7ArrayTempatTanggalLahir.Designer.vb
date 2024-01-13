<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayTempatTanggalLahir
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
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txttempat = New System.Windows.Forms.TextBox
        Me.cmbtanggal = New System.Windows.Forms.ComboBox
        Me.cmbbulan = New System.Windows.Forms.ComboBox
        Me.cmbtahun = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tempat Tanggal Lahir"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(152, 17)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(165, 20)
        Me.txtnama.TabIndex = 2
        '
        'txttempat
        '
        Me.txttempat.Location = New System.Drawing.Point(152, 61)
        Me.txttempat.Name = "txttempat"
        Me.txttempat.Size = New System.Drawing.Size(165, 20)
        Me.txttempat.TabIndex = 3
        '
        'cmbtanggal
        '
        Me.cmbtanggal.FormattingEnabled = True
        Me.cmbtanggal.Location = New System.Drawing.Point(152, 87)
        Me.cmbtanggal.Name = "cmbtanggal"
        Me.cmbtanggal.Size = New System.Drawing.Size(51, 21)
        Me.cmbtanggal.TabIndex = 4
        '
        'cmbbulan
        '
        Me.cmbbulan.FormattingEnabled = True
        Me.cmbbulan.Location = New System.Drawing.Point(209, 87)
        Me.cmbbulan.Name = "cmbbulan"
        Me.cmbbulan.Size = New System.Drawing.Size(51, 21)
        Me.cmbbulan.TabIndex = 5
        '
        'cmbtahun
        '
        Me.cmbtahun.FormattingEnabled = True
        Me.cmbtahun.Location = New System.Drawing.Point(266, 87)
        Me.cmbtahun.Name = "cmbtahun"
        Me.cmbtahun.Size = New System.Drawing.Size(51, 21)
        Me.cmbtahun.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(26, 161)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(291, 108)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ArrayTempatTanggalLahir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 297)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbtahun)
        Me.Controls.Add(Me.cmbbulan)
        Me.Controls.Add(Me.cmbtanggal)
        Me.Controls.Add(Me.txttempat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ArrayTempatTanggalLahir"
        Me.Text = "ArrayTempatTanggalLahir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txttempat As System.Windows.Forms.TextBox
    Friend WithEvents cmbtanggal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtahun As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
