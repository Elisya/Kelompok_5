<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menu_Button = New System.Windows.Forms.Button()
        Me.pemesanan_Button = New System.Windows.Forms.Button()
        Me.pembayaran_Button = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 217)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(616, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "  Ke5 Resto  ||   Jln. Samratulangi  ||   Samarinda   ||   Sistem Informasi Resto" & _
            "ran  ||  Manajemen Informatika"
        '
        'Timer1
        '
        '
        'menu_Button
        '
        Me.menu_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.menu_Button.Image = CType(resources.GetObject("menu_Button.Image"), System.Drawing.Image)
        Me.menu_Button.Location = New System.Drawing.Point(312, 49)
        Me.menu_Button.Name = "menu_Button"
        Me.menu_Button.Size = New System.Drawing.Size(243, 103)
        Me.menu_Button.TabIndex = 3
        Me.menu_Button.Text = "Menu"
        Me.menu_Button.UseVisualStyleBackColor = True
        '
        'pemesanan_Button
        '
        Me.pemesanan_Button.Image = CType(resources.GetObject("pemesanan_Button.Image"), System.Drawing.Image)
        Me.pemesanan_Button.Location = New System.Drawing.Point(312, 176)
        Me.pemesanan_Button.Name = "pemesanan_Button"
        Me.pemesanan_Button.Size = New System.Drawing.Size(243, 115)
        Me.pemesanan_Button.TabIndex = 4
        Me.pemesanan_Button.Text = "Pemesanan"
        Me.pemesanan_Button.UseVisualStyleBackColor = True
        '
        'pembayaran_Button
        '
        Me.pembayaran_Button.Image = CType(resources.GetObject("pembayaran_Button.Image"), System.Drawing.Image)
        Me.pembayaran_Button.Location = New System.Drawing.Point(593, 49)
        Me.pembayaran_Button.Name = "pembayaran_Button"
        Me.pembayaran_Button.Size = New System.Drawing.Size(205, 180)
        Me.pembayaran_Button.TabIndex = 5
        Me.pembayaran_Button.Text = "Pembayaran"
        Me.pembayaran_Button.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Cyan
        Me.Button4.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(573, 251)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 76)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "More Info"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(710, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 80)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.menu_Button)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.pemesanan_Button)
        Me.GroupBox1.Controls.Add(Me.pembayaran_Button)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 352)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aplikasi Restoran"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 416)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Sistem Pemesanan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents menu_Button As System.Windows.Forms.Button
    Friend WithEvents pemesanan_Button As System.Windows.Forms.Button
    Friend WithEvents pembayaran_Button As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
