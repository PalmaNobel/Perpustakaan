Public Class tb_pengembalian

    Private Sub Tb_pengembalianBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_pengembalianBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_pengembalianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDataSet)

    End Sub

    Private Sub tb_pengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.tb_pengembalian' table. You can move, or remove it, as needed.
        Me.Tb_pengembalianTableAdapter.Fill(Me.PerpustakaanDataSet.tb_pengembalian)

    End Sub

    Private Sub tambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        Tgl_PengembalianDateTimePicker.Enabled = True
        Tgl_PinjamDateTimePicker.Enabled = True
        DendaTextBox.Enabled = True


        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True

        Tb_pengembalianBindingSource.AddNew()
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Tgl_PengembalianDateTimePicker.Enabled = True
        Tgl_PinjamDateTimePicker.Enabled = True


        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Tb_pengembalianBindingSource.RemoveCurrent()

            Me.Validate()
            Me.Tb_pengembalianBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

            MessageBox.Show("DATA TELAH TERHAPUS")
        End If
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.Tb_pengembalianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Tgl_PengembalianDateTimePicker.Enabled = False
        Tgl_PinjamDateTimePicker.Enabled = False
        DendaTextBox.Enabled = False


        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        simpanButton.Enabled = False
    End Sub

    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        Me.Tb_pengembalianTableAdapter.Fill(Me.PerpustakaanDataSet.tb_pengembalian)
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Tb_pengembalianBindingSource.CancelEdit()

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        refreshButton.Enabled = True
        simpanButton.Enabled = False
        batalButton.Enabled = False
    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click
        Me.Close()
    End Sub
End Class