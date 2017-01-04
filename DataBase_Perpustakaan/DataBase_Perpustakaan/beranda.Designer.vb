<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class beranda
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PERPUSTAKAANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbbukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbanggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbpengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbpetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbpinjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERPUSTAKAANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(416, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PERPUSTAKAANToolStripMenuItem
        '
        Me.PERPUSTAKAANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TbbukuToolStripMenuItem, Me.TbanggotaToolStripMenuItem, Me.TbpengembalianToolStripMenuItem, Me.TbpetugasToolStripMenuItem, Me.TbpinjamToolStripMenuItem})
        Me.PERPUSTAKAANToolStripMenuItem.Name = "PERPUSTAKAANToolStripMenuItem"
        Me.PERPUSTAKAANToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.PERPUSTAKAANToolStripMenuItem.Text = "PERPUSTAKAAN"
        '
        'TbbukuToolStripMenuItem
        '
        Me.TbbukuToolStripMenuItem.Name = "TbbukuToolStripMenuItem"
        Me.TbbukuToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TbbukuToolStripMenuItem.Text = "tb_buku"
        '
        'TbanggotaToolStripMenuItem
        '
        Me.TbanggotaToolStripMenuItem.Name = "TbanggotaToolStripMenuItem"
        Me.TbanggotaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TbanggotaToolStripMenuItem.Text = "tb_anggota"
        '
        'TbpengembalianToolStripMenuItem
        '
        Me.TbpengembalianToolStripMenuItem.Name = "TbpengembalianToolStripMenuItem"
        Me.TbpengembalianToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TbpengembalianToolStripMenuItem.Text = "tb_pengembalian"
        '
        'TbpetugasToolStripMenuItem
        '
        Me.TbpetugasToolStripMenuItem.Name = "TbpetugasToolStripMenuItem"
        Me.TbpetugasToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TbpetugasToolStripMenuItem.Text = "tb_petugas"
        '
        'TbpinjamToolStripMenuItem
        '
        Me.TbpinjamToolStripMenuItem.Name = "TbpinjamToolStripMenuItem"
        Me.TbpinjamToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TbpinjamToolStripMenuItem.Text = "tb_pinjam"
        '
        'beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 294)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "beranda"
        Me.Text = "beranda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PERPUSTAKAANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbbukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbanggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbpengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbpetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbpinjamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
