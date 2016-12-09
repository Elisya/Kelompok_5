Public Class Form2

    Private Sub PemesananBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.pemesanan' table. You can move, or remove it, as needed.
        Me.PemesananTableAdapter.Fill(Me.Kel_5_si_restoDataSet.pemesanan)

    End Sub

    Private Sub tambahbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahbutton.Click
        PemesananBindingSource.AddNew()
    End Sub

    Private Sub simpanbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanbutton.Click
        Me.Validate()
        Me.PemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

        MessageBox.Show("Data Telah Tersimpan")
    End Sub

    Private Sub hapusbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusbutton.Click
        Me.Validate()
        Me.PemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

        MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub keluarbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarbutton.Click
        Me.Hide()
        Form1.Close()
    End Sub

    Private Sub batalbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalbutton.Click
        PemesananBindingSource.CancelEdit()
    End Sub
End Class