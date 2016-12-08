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
End Class