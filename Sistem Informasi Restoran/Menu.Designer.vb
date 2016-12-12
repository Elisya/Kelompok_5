<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim Id_MakananLabel As System.Windows.Forms.Label
        Dim Nama_MakananLabel As System.Windows.Forms.Label
        Dim Harga_MakananLabel As System.Windows.Forms.Label
        Dim Pelayan_Id_PelayanLabel As System.Windows.Forms.Label
        Me.Kel_5_si_restoDataSet = New Sistem_Informasi_Restoran.kel_5_si_restoDataSet()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter = New Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.menuTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.MenuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Pelayan_Id_PelayanTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Id_MakananLabel = New System.Windows.Forms.Label()
        Nama_MakananLabel = New System.Windows.Forms.Label()
        Harga_MakananLabel = New System.Windows.Forms.Label()
        Pelayan_Id_PelayanLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Kel_5_si_restoDataSet
        '
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "menu"
        Me.MenuBindingSource.DataSource = Me.Kel_5_si_restoDataSet
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.menuTableAdapter = Me.MenuTableAdapter
        Me.TableAdapterManager.pelayan_has_pemesananTableAdapter = Nothing
        Me.TableAdapterManager.pelayanTableAdapter = Nothing
        Me.TableAdapterManager.pemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuDataGridView
        '
        Me.MenuDataGridView.AutoGenerateColumns = False
        Me.MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MenuDataGridView.DataSource = Me.MenuBindingSource
        Me.MenuDataGridView.Location = New System.Drawing.Point(2, 3)
        Me.MenuDataGridView.Name = "MenuDataGridView"
        Me.MenuDataGridView.Size = New System.Drawing.Size(429, 226)
        Me.MenuDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id Makanan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Makanan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama Makanan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Makanan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Harga Makanan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Harga Makanan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Id_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Id_MakananTextBox)
        Me.GroupBox1.Controls.Add(Nama_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_MakananTextBox)
        Me.GroupBox1.Controls.Add(Harga_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Harga_MakananTextBox)
        Me.GroupBox1.Controls.Add(Pelayan_Id_PelayanLabel)
        Me.GroupBox1.Controls.Add(Me.Pelayan_Id_PelayanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 172)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Menu"
        '
        'Id_MakananLabel
        '
        Id_MakananLabel.AutoSize = True
        Id_MakananLabel.Location = New System.Drawing.Point(6, 20)
        Id_MakananLabel.Name = "Id_MakananLabel"
        Id_MakananLabel.Size = New System.Drawing.Size(67, 13)
        Id_MakananLabel.TabIndex = 0
        Id_MakananLabel.Text = "Id Makanan:"
        '
        'Id_MakananTextBox
        '
        Me.Id_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Id Makanan", True))
        Me.Id_MakananTextBox.Location = New System.Drawing.Point(113, 17)
        Me.Id_MakananTextBox.Name = "Id_MakananTextBox"
        Me.Id_MakananTextBox.Size = New System.Drawing.Size(286, 20)
        Me.Id_MakananTextBox.TabIndex = 1
        '
        'Nama_MakananLabel
        '
        Nama_MakananLabel.AutoSize = True
        Nama_MakananLabel.Location = New System.Drawing.Point(6, 46)
        Nama_MakananLabel.Name = "Nama_MakananLabel"
        Nama_MakananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_MakananLabel.TabIndex = 2
        Nama_MakananLabel.Text = "Nama Makanan:"
        '
        'Nama_MakananTextBox
        '
        Me.Nama_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Nama Makanan", True))
        Me.Nama_MakananTextBox.Location = New System.Drawing.Point(113, 43)
        Me.Nama_MakananTextBox.Name = "Nama_MakananTextBox"
        Me.Nama_MakananTextBox.Size = New System.Drawing.Size(286, 20)
        Me.Nama_MakananTextBox.TabIndex = 3
        '
        'Harga_MakananLabel
        '
        Harga_MakananLabel.AutoSize = True
        Harga_MakananLabel.Location = New System.Drawing.Point(6, 72)
        Harga_MakananLabel.Name = "Harga_MakananLabel"
        Harga_MakananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_MakananLabel.TabIndex = 4
        Harga_MakananLabel.Text = "Harga Makanan:"
        '
        'Harga_MakananTextBox
        '
        Me.Harga_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Harga Makanan", True))
        Me.Harga_MakananTextBox.Location = New System.Drawing.Point(113, 69)
        Me.Harga_MakananTextBox.Name = "Harga_MakananTextBox"
        Me.Harga_MakananTextBox.Size = New System.Drawing.Size(286, 20)
        Me.Harga_MakananTextBox.TabIndex = 5
        '
        'Pelayan_Id_PelayanLabel
        '
        Pelayan_Id_PelayanLabel.AutoSize = True
        Pelayan_Id_PelayanLabel.Location = New System.Drawing.Point(6, 98)
        Pelayan_Id_PelayanLabel.Name = "Pelayan_Id_PelayanLabel"
        Pelayan_Id_PelayanLabel.Size = New System.Drawing.Size(101, 13)
        Pelayan_Id_PelayanLabel.TabIndex = 6
        Pelayan_Id_PelayanLabel.Text = "Pelayan Id Pelayan:"
        '
        'Pelayan_Id_PelayanTextBox
        '
        Me.Pelayan_Id_PelayanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Pelayan_Id Pelayan", True))
        Me.Pelayan_Id_PelayanTextBox.Location = New System.Drawing.Point(113, 95)
        Me.Pelayan_Id_PelayanTextBox.Name = "Pelayan_Id_PelayanTextBox"
        Me.Pelayan_Id_PelayanTextBox.Size = New System.Drawing.Size(286, 20)
        Me.Pelayan_Id_PelayanTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(160, 138)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(324, 121)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 45)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Lihat Menu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 434)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuDataGridView)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Kel_5_si_restoDataSet As Sistem_Informasi_Restoran.kel_5_si_restoDataSet
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.menuTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Id_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harga_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pelayan_Id_PelayanTextBox As System.Windows.Forms.TextBox
End Class
