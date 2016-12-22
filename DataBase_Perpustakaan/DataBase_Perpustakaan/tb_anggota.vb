Public Class tb_anggota

    Private Sub Tb_dataanggotaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_dataanggotaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_dataanggotaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDataSet)

    End Sub

    Private Sub tb_anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.tb_dataanggota' table. You can move, or remove it, as needed.
        Me.Tb_dataanggotaTableAdapter.Fill(Me.PerpustakaanDataSet.tb_dataanggota)

    End Sub

    Private Sub tambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        Id_AnggotaTextBox.Enabled = True
        Nama_anggotaTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        KontakTextBox.Enabled = True

        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Nama_anggotaTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        KontakTextBox.Enabled = True

        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Tb_dataanggotaBindingSource.RemoveCurrent()

            Me.Validate()
            Me.Tb_dataanggotaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

            MessageBox.Show("DATA TELAH TERHAPUS")
        End If
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.Tb_dataanggotaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Id_AnggotaTextBox.Enabled = False
        Nama_anggotaTextBox.Enabled = False
        AlamatTextBox.Enabled = False
        KontakTextBox.Enabled = False

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        simpanButton.Enabled = False
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Tb_dataanggotaBindingSource.CancelEdit()

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        refreshButton.Enabled = True
        simpanButton.Enabled = False
        batalButton.Enabled = False
    End Sub

    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        Me.Tb_dataanggotaTableAdapter.Fill(Me.PerpustakaanDataSet.tb_dataanggota)
    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click
        Me.Close()
    End Sub
End Class