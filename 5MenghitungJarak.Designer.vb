<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenghitungJarak
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
        Me.txtkecepatan = New System.Windows.Forms.TextBox
        Me.txtwaktu = New System.Windows.Forms.TextBox
        Me.txtjarak = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kecepatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Waktu Tempuh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jarak"
        '
        'txtkecepatan
        '
        Me.txtkecepatan.Location = New System.Drawing.Point(121, 22)
        Me.txtkecepatan.Name = "txtkecepatan"
        Me.txtkecepatan.Size = New System.Drawing.Size(100, 20)
        Me.txtkecepatan.TabIndex = 3
        '
        'txtwaktu
        '
        Me.txtwaktu.Location = New System.Drawing.Point(121, 60)
        Me.txtwaktu.Name = "txtwaktu"
        Me.txtwaktu.Size = New System.Drawing.Size(100, 20)
        Me.txtwaktu.TabIndex = 4
        '
        'txtjarak
        '
        Me.txtjarak.Location = New System.Drawing.Point(121, 154)
        Me.txtjarak.Name = "txtjarak"
        Me.txtjarak.Size = New System.Drawing.Size(100, 20)
        Me.txtjarak.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(25, 191)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 108)
        Me.ListBox1.TabIndex = 7
        '
        'MenghitungJarak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 317)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtjarak)
        Me.Controls.Add(Me.txtwaktu)
        Me.Controls.Add(Me.txtkecepatan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenghitungJarak"
        Me.Text = "MenghitungJarak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtkecepatan As System.Windows.Forms.TextBox
    Friend WithEvents txtwaktu As System.Windows.Forms.TextBox
    Friend WithEvents txtjarak As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
