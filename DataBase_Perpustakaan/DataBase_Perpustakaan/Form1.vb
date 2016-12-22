Public Class Form1

    Private Sub Tb_bukuBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_bukuBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_bukuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.tb_buku' table. You can move, or remove it, as needed.
        Me.Tb_bukuTableAdapter.Fill(Me.PerpustakaanDataSet.tb_buku)

    End Sub

    Private Sub tambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        Id_BukuTextBox.Enabled = True
        Nama_BukuTextBox.Enabled = True
        Kondisi_BukuTextBox.Enabled = True


        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True

        Tb_bukuBindingSource.AddNew()
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Nama_BukuTextBox.Enabled = True
        Kondisi_BukuTextBox.Enabled = True


        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        refreshButton.Enabled = False
        simpanButton.Enabled = True
        batalButton.Enabled = True
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Tb_bukuBindingSource.RemoveCurrent()

            Me.Validate()
            Me.Tb_bukuBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

            MessageBox.Show("DATA TELAH TERHAPUS")
        End If
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.Tb_bukuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(PerpustakaanDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Id_BukuTextBox.Enabled = False
        Nama_BukuTextBox.Enabled = False
        Kondisi_BukuTextBox.Enabled = False


        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        simpanButton.Enabled = False
    End Sub

    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        Me.Tb_bukuTableAdapter.Fill(Me.PerpustakaanDataSet.tb_buku)
    End Sub

    Private Sub keuarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keuarButton.Click
        Me.Close()
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Tb_bukuBindingSource.CancelEdit()

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        refreshButton.Enabled = True
        simpanButton.Enabled = False
        batalButton.Enabled = False
    End Sub
End Class
