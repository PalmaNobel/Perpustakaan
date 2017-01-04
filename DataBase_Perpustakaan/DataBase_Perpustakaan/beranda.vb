Public Class beranda

    Private Sub TbbukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbbukuToolStripMenuItem.Click
        tb_buku.ShowDialog()
    End Sub

    Private Sub TbanggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbanggotaToolStripMenuItem.Click
        tb_anggota.ShowDialog()
    End Sub

    Private Sub TbpengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbpengembalianToolStripMenuItem.Click
        tb_pengembalian.ShowDialog()
    End Sub

    Private Sub TbpetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbpetugasToolStripMenuItem.Click
        tb_petugas.ShowDialog()
    End Sub

    Private Sub TbpinjamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbpinjamToolStripMenuItem.Click
        tb_pinjam.ShowDialog()
    End Sub
End Class