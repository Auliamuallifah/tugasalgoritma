<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class operasibilangan
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.kurang = New System.Windows.Forms.RadioButton
        Me.tambah = New System.Windows.Forms.RadioButton
        Me.kali = New System.Windows.Forms.RadioButton
        Me.bagi = New System.Windows.Forms.RadioButton
        Me.pangkat = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kurang)
        Me.GroupBox1.Controls.Add(Me.tambah)
        Me.GroupBox1.Controls.Add(Me.kali)
        Me.GroupBox1.Controls.Add(Me.bagi)
        Me.GroupBox1.Controls.Add(Me.pangkat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'kurang
        '
        Me.kurang.AutoSize = True
        Me.kurang.Location = New System.Drawing.Point(162, 71)
        Me.kurang.Name = "kurang"
        Me.kurang.Size = New System.Drawing.Size(89, 17)
        Me.kurang.TabIndex = 4
        Me.kurang.TabStop = True
        Me.kurang.Text = "Pengurangan"
        Me.kurang.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.AutoSize = True
        Me.tambah.Location = New System.Drawing.Point(162, 34)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(86, 17)
        Me.tambah.TabIndex = 3
        Me.tambah.TabStop = True
        Me.tambah.Text = "Penjumlahan"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'kali
        '
        Me.kali.AutoSize = True
        Me.kali.Location = New System.Drawing.Point(10, 111)
        Me.kali.Name = "kali"
        Me.kali.Size = New System.Drawing.Size(69, 17)
        Me.kali.TabIndex = 2
        Me.kali.TabStop = True
        Me.kali.Text = "Perkalian"
        Me.kali.UseVisualStyleBackColor = True
        '
        'bagi
        '
        Me.bagi.AutoSize = True
        Me.bagi.Location = New System.Drawing.Point(10, 71)
        Me.bagi.Name = "bagi"
        Me.bagi.Size = New System.Drawing.Size(78, 17)
        Me.bagi.TabIndex = 1
        Me.bagi.TabStop = True
        Me.bagi.Text = "Pembagian"
        Me.bagi.UseVisualStyleBackColor = True
        '
        'pangkat
        '
        Me.pangkat.AutoSize = True
        Me.pangkat.Location = New System.Drawing.Point(10, 34)
        Me.pangkat.Name = "pangkat"
        Me.pangkat.Size = New System.Drawing.Size(65, 17)
        Me.pangkat.TabIndex = 0
        Me.pangkat.TabStop = True
        Me.pangkat.Text = "Pangkat"
        Me.pangkat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'operasibilangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 309)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "operasibilangan"
        Me.Text = "operasibilangan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents kurang As System.Windows.Forms.RadioButton
    Friend WithEvents tambah As System.Windows.Forms.RadioButton
    Friend WithEvents kali As System.Windows.Forms.RadioButton
    Friend WithEvents bagi As System.Windows.Forms.RadioButton
    Friend WithEvents pangkat As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
