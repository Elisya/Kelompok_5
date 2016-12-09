<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Id_MejaLabel As System.Windows.Forms.Label
        Dim Nama_MakananLabel As System.Windows.Forms.Label
        Dim Jumlah_PesananLabel As System.Windows.Forms.Label
        Dim Menu_TambahanLabel As System.Windows.Forms.Label
        Dim Menu_Id_MakananLabel As System.Windows.Forms.Label
        Dim Kasir_Id_MejaLabel As System.Windows.Forms.Label
        Dim Pelayan_Id_PelayanLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_MejaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet = New Sistem_Informasi_Restoran.kel_5_si_restoDataSet()
        Me.Nama_MakananTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Jumlah_PesananSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Menu_TambahanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Menu_Id_MakananSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Kasir_Id_MejaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Pelayan_Id_PelayanSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PemesananTableAdapter = New Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.PemesananDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tambahbutton = New System.Windows.Forms.Button()
        Me.simpanbutton = New System.Windows.Forms.Button()
        Me.hapusbutton = New System.Windows.Forms.Button()
        Me.batalbutton = New System.Windows.Forms.Button()
        Me.keluarbutton = New System.Windows.Forms.Button()
        Id_MejaLabel = New System.Windows.Forms.Label()
        Nama_MakananLabel = New System.Windows.Forms.Label()
        Jumlah_PesananLabel = New System.Windows.Forms.Label()
        Menu_TambahanLabel = New System.Windows.Forms.Label()
        Menu_Id_MakananLabel = New System.Windows.Forms.Label()
        Kasir_Id_MejaLabel = New System.Windows.Forms.Label()
        Pelayan_Id_PelayanLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Id_MejaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nama_MakananTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumlah_PesananSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_TambahanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_Id_MakananSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kasir_Id_MejaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pelayan_Id_PelayanSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemesananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_MejaLabel
        '
        Id_MejaLabel.AutoSize = True
        Id_MejaLabel.Location = New System.Drawing.Point(0, 20)
        Id_MejaLabel.Name = "Id_MejaLabel"
        Id_MejaLabel.Size = New System.Drawing.Size(45, 13)
        Id_MejaLabel.TabIndex = 0
        Id_MejaLabel.Text = "Id Meja:"
        '
        'Nama_MakananLabel
        '
        Nama_MakananLabel.AutoSize = True
        Nama_MakananLabel.Location = New System.Drawing.Point(-3, 42)
        Nama_MakananLabel.Name = "Nama_MakananLabel"
        Nama_MakananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_MakananLabel.TabIndex = 2
        Nama_MakananLabel.Text = "Nama Makanan:"
        '
        'Jumlah_PesananLabel
        '
        Jumlah_PesananLabel.AutoSize = True
        Jumlah_PesananLabel.Location = New System.Drawing.Point(-3, 68)
        Jumlah_PesananLabel.Name = "Jumlah_PesananLabel"
        Jumlah_PesananLabel.Size = New System.Drawing.Size(88, 13)
        Jumlah_PesananLabel.TabIndex = 4
        Jumlah_PesananLabel.Text = "Jumlah Pesanan:"
        '
        'Menu_TambahanLabel
        '
        Menu_TambahanLabel.AutoSize = True
        Menu_TambahanLabel.Location = New System.Drawing.Point(-3, 94)
        Menu_TambahanLabel.Name = "Menu_TambahanLabel"
        Menu_TambahanLabel.Size = New System.Drawing.Size(91, 13)
        Menu_TambahanLabel.TabIndex = 6
        Menu_TambahanLabel.Text = "Menu Tambahan:"
        '
        'Menu_Id_MakananLabel
        '
        Menu_Id_MakananLabel.AutoSize = True
        Menu_Id_MakananLabel.Location = New System.Drawing.Point(-3, 120)
        Menu_Id_MakananLabel.Name = "Menu_Id_MakananLabel"
        Menu_Id_MakananLabel.Size = New System.Drawing.Size(97, 13)
        Menu_Id_MakananLabel.TabIndex = 8
        Menu_Id_MakananLabel.Text = "Menu Id Makanan:"
        '
        'Kasir_Id_MejaLabel
        '
        Kasir_Id_MejaLabel.AutoSize = True
        Kasir_Id_MejaLabel.Location = New System.Drawing.Point(-3, 146)
        Kasir_Id_MejaLabel.Name = "Kasir_Id_MejaLabel"
        Kasir_Id_MejaLabel.Size = New System.Drawing.Size(71, 13)
        Kasir_Id_MejaLabel.TabIndex = 10
        Kasir_Id_MejaLabel.Text = "Kasir Id Meja:"
        '
        'Pelayan_Id_PelayanLabel
        '
        Pelayan_Id_PelayanLabel.AutoSize = True
        Pelayan_Id_PelayanLabel.Location = New System.Drawing.Point(-3, 172)
        Pelayan_Id_PelayanLabel.Name = "Pelayan_Id_PelayanLabel"
        Pelayan_Id_PelayanLabel.Size = New System.Drawing.Size(101, 13)
        Pelayan_Id_PelayanLabel.TabIndex = 12
        Pelayan_Id_PelayanLabel.Text = "Pelayan Id Pelayan:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Id_MejaLabel)
        Me.GroupBox1.Controls.Add(Me.Id_MejaSpinEdit)
        Me.GroupBox1.Controls.Add(Me.hapusbutton)
        Me.GroupBox1.Controls.Add(Nama_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.simpanbutton)
        Me.GroupBox1.Controls.Add(Me.Nama_MakananTextEdit)
        Me.GroupBox1.Controls.Add(Me.tambahbutton)
        Me.GroupBox1.Controls.Add(Jumlah_PesananLabel)
        Me.GroupBox1.Controls.Add(Me.Jumlah_PesananSpinEdit)
        Me.GroupBox1.Controls.Add(Menu_TambahanLabel)
        Me.GroupBox1.Controls.Add(Me.Menu_TambahanTextEdit)
        Me.GroupBox1.Controls.Add(Menu_Id_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Menu_Id_MakananSpinEdit)
        Me.GroupBox1.Controls.Add(Kasir_Id_MejaLabel)
        Me.GroupBox1.Controls.Add(Me.Kasir_Id_MejaSpinEdit)
        Me.GroupBox1.Controls.Add(Pelayan_Id_PelayanLabel)
        Me.GroupBox1.Controls.Add(Me.Pelayan_Id_PelayanSpinEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pemesanan"
        '
        'Id_MejaSpinEdit
        '
        Me.Id_MejaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemesananBindingSource, "Id Meja", True))
        Me.Id_MejaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Id_MejaSpinEdit.Location = New System.Drawing.Point(104, 13)
        Me.Id_MejaSpinEdit.Name = "Id_MejaSpinEdit"
        Me.Id_MejaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Id_MejaSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Id_MejaSpinEdit.TabIndex = 1
        '
        'PemesananBindingSource
        '
        Me.PemesananBindingSource.DataMember = "pemesanan"
        Me.PemesananBindingSource.DataSource = Me.Kel_5_si_restoDataSet
        '
        'Kel_5_si_restoDataSet
        '
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_MakananTextEdit
        '
        Me.Nama_MakananTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemesananBindingSource, "Nama Makanan", True))
        Me.Nama_MakananTextEdit.Location = New System.Drawing.Point(104, 39)
        Me.Nama_MakananTextEdit.Name = "Nama_MakananTextEdit"
        Me.Nama_MakananTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Nama_MakananTextEdit.TabIndex = 3
        '
        'Jumlah_PesananSpinEdit
        '
        Me.Jumlah_PesananSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemesananBindingSource, "Jumlah Pesanan", True))
        Me.Jumlah_PesananSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Jumlah_PesananSpinEdit.Location = New System.Drawing.Point(104, 65)
        Me.Jumlah_PesananSpinEdit.Name = "Jumlah_PesananSpinEdit"
        Me.Jumlah_PesananSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Jumlah_PesananSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Jumlah_PesananSpinEdit.TabIndex = 5
        '
        'Menu_TambahanTextEdit
        '
        Me.Menu_TambahanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemesananBindingSource, "Menu Tambahan", True))
        Me.Menu_TambahanTextEdit.Location = New System.Drawing.Point(104, 91)
        Me.Menu_TambahanTextEdit.Name = "Menu_TambahanTextEdit"
        Me.Menu_TambahanTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Menu_TambahanTextEdit.TabIndex = 7
        '
        'Menu_Id_MakananSpinEdit
        '
        Me.Menu_Id_MakananSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemesananBindingSource, "Menu_Id Makanan", True))
        Me.Menu_Id_MakananSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Menu_Id_MakananSpinEdit.Location = New System.Drawing.Point(104, 117)
        Me.Menu_Id_MakananSpinEdit.Name = "Menu_Id_MakananSpinEdit"
        Me.Menu_Id_MakananSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Menu_Id_MakananSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Menu_Id_MakananSpinEdit.TabIndex = 9
        '
        'Kasir_Id_MejaSpinEdit
        '
        Me.Kasir_Id_MejaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemesananBindingSource, "Kasir_Id Meja", True))
        Me.Kasir_Id_MejaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Kasir_Id_MejaSpinEdit.Location = New System.Drawing.Point(104, 143)
        Me.Kasir_Id_MejaSpinEdit.Name = "Kasir_Id_MejaSpinEdit"
        Me.Kasir_Id_MejaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Kasir_Id_MejaSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Kasir_Id_MejaSpinEdit.TabIndex = 11
        '
        'Pelayan_Id_PelayanSpinEdit
        '
        Me.Pelayan_Id_PelayanSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemesananBindingSource, "Pelayan_Id Pelayan", True))
        Me.Pelayan_Id_PelayanSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Pelayan_Id_PelayanSpinEdit.Location = New System.Drawing.Point(104, 169)
        Me.Pelayan_Id_PelayanSpinEdit.Name = "Pelayan_Id_PelayanSpinEdit"
        Me.Pelayan_Id_PelayanSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Pelayan_Id_PelayanSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Pelayan_Id_PelayanSpinEdit.TabIndex = 13
        '
        'PemesananTableAdapter
        '
        Me.PemesananTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.pelayan_has_pemesananTableAdapter = Nothing
        Me.TableAdapterManager.pelayanTableAdapter = Nothing
        Me.TableAdapterManager.pemesananTableAdapter = Me.PemesananTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PemesananDataGridView
        '
        Me.PemesananDataGridView.AutoGenerateColumns = False
        Me.PemesananDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PemesananDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PemesananDataGridView.DataSource = Me.PemesananBindingSource
        Me.PemesananDataGridView.Location = New System.Drawing.Point(257, 28)
        Me.PemesananDataGridView.Name = "PemesananDataGridView"
        Me.PemesananDataGridView.Size = New System.Drawing.Size(743, 259)
        Me.PemesananDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id Meja"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Meja"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Jumlah Pesanan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jumlah Pesanan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Menu Tambahan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Menu Tambahan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Menu_Id Makanan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Menu_Id Makanan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Kasir_Id Meja"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kasir_Id Meja"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'tambahbutton
        '
        Me.tambahbutton.Location = New System.Drawing.Point(-7, 197)
        Me.tambahbutton.Name = "tambahbutton"
        Me.tambahbutton.Size = New System.Drawing.Size(75, 23)
        Me.tambahbutton.TabIndex = 2
        Me.tambahbutton.Text = "Tambah"
        Me.tambahbutton.UseVisualStyleBackColor = True
        '
        'simpanbutton
        '
        Me.simpanbutton.Location = New System.Drawing.Point(74, 197)
        Me.simpanbutton.Name = "simpanbutton"
        Me.simpanbutton.Size = New System.Drawing.Size(75, 23)
        Me.simpanbutton.TabIndex = 3
        Me.simpanbutton.Text = "Simpan"
        Me.simpanbutton.UseVisualStyleBackColor = True
        '
        'hapusbutton
        '
        Me.hapusbutton.Location = New System.Drawing.Point(158, 197)
        Me.hapusbutton.Name = "hapusbutton"
        Me.hapusbutton.Size = New System.Drawing.Size(75, 23)
        Me.hapusbutton.TabIndex = 4
        Me.hapusbutton.Text = "Hapus"
        Me.hapusbutton.UseVisualStyleBackColor = True
        '
        'batalbutton
        '
        Me.batalbutton.Location = New System.Drawing.Point(49, 254)
        Me.batalbutton.Name = "batalbutton"
        Me.batalbutton.Size = New System.Drawing.Size(75, 23)
        Me.batalbutton.TabIndex = 5
        Me.batalbutton.Text = "Batal"
        Me.batalbutton.UseVisualStyleBackColor = True
        '
        'keluarbutton
        '
        Me.keluarbutton.Location = New System.Drawing.Point(141, 254)
        Me.keluarbutton.Name = "keluarbutton"
        Me.keluarbutton.Size = New System.Drawing.Size(75, 23)
        Me.keluarbutton.TabIndex = 6
        Me.keluarbutton.Text = "Keluar"
        Me.keluarbutton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 299)
        Me.Controls.Add(Me.keluarbutton)
        Me.Controls.Add(Me.batalbutton)
        Me.Controls.Add(Me.PemesananDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Id_MejaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nama_MakananTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumlah_PesananSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_TambahanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_Id_MakananSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kasir_Id_MejaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pelayan_Id_PelayanSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemesananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet As Sistem_Informasi_Restoran.kel_5_si_restoDataSet
    Friend WithEvents PemesananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PemesananTableAdapter As Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Restoran.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_MejaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Nama_MakananTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Jumlah_PesananSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Menu_TambahanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Menu_Id_MakananSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Kasir_Id_MejaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Pelayan_Id_PelayanSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PemesananDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tambahbutton As System.Windows.Forms.Button
    Friend WithEvents simpanbutton As System.Windows.Forms.Button
    Friend WithEvents hapusbutton As System.Windows.Forms.Button
    Friend WithEvents batalbutton As System.Windows.Forms.Button
    Friend WithEvents keluarbutton As System.Windows.Forms.Button
End Class
