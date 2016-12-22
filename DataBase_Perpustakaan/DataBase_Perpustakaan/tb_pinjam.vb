Public Class tb_pinjam

    Private Sub Tb_pinjamBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_pinjamBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_pinjamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDataSet)

    End Sub

    Private Sub tb_pinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.tb_pinjam' table. You can move, or remove it, as needed.
        Me.Tb_pinjamTableAdapter.Fill(Me.PerpustakaanDataSet.tb_pinjam)

    End Sub

    Private Sub tambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        Id_PinjamTextBox.Enabled = True
        Tgl_PinjamDateTimePicker.Enabled = True
        Nama_AnggotaTextBox.Enabled = True

        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Tgl_PinjamDateTimePicker.Enabled = True
        Nama_AnggotaTextBox.Enabled = True

        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Tb_pinjamBindingSource.RemoveCurrent()

            Me.Validate()
            Me.Tb_pinjamBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

            MessageBox.Show("DATA TELAH TERHAPUS")
        End If
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.Tb_pinjamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Nama_AnggotaTextBox.Enabled = False
        Tgl_PinjamDateTimePicker.Enabled = False
        Id_PinjamTextBox.Enabled = False

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        simpanButton.Enabled = False
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Tb_pinjamBindingSource.CancelEdit()

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        refreshButton.Enabled = True
        simpanButton.Enabled = False
        batalButton.Enabled = False
    End Sub

    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        Me.Tb_pinjamTableAdapter.Fill(Me.PerpustakaanDataSet.tb_pinjam)
    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click
        Me.Close()
    End Sub
End Class