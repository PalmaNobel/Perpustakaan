<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tb_petugas
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
        Dim Id_PetugasLabel As System.Windows.Forms.Label
        Dim Jadwal_tugasLabel As System.Windows.Forms.Label
        Dim Nama_petugasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tb_petugas))
        Me.PerpustakaanDataSet = New DataBase_Perpustakaan.perpustakaanDataSet()
        Me.Tb_petugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_petugasTableAdapter = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_petugasTableAdapter()
        Me.TableAdapterManager = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager()
        Me.Tb_petugasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_petugasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_petugasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_PetugasTextBox = New System.Windows.Forms.TextBox()
        Me.Jadwal_tugasDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Nama_petugasTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Id_PetugasLabel = New System.Windows.Forms.Label()
        Jadwal_tugasLabel = New System.Windows.Forms.Label()
        Nama_petugasLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_petugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_petugasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_petugasBindingNavigator.SuspendLayout()
        CType(Me.Tb_petugasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_PetugasLabel
        '
        Id_PetugasLabel.AutoSize = True
        Id_PetugasLabel.Location = New System.Drawing.Point(408, 89)
        Id_PetugasLabel.Name = "Id_PetugasLabel"
        Id_PetugasLabel.Size = New System.Drawing.Size(60, 13)
        Id_PetugasLabel.TabIndex = 2
        Id_PetugasLabel.Text = "id Petugas:"
        '
        'Jadwal_tugasLabel
        '
        Jadwal_tugasLabel.AutoSize = True
        Jadwal_tugasLabel.Location = New System.Drawing.Point(408, 116)
        Jadwal_tugasLabel.Name = "Jadwal_tugasLabel"
        Jadwal_tugasLabel.Size = New System.Drawing.Size(69, 13)
        Jadwal_tugasLabel.TabIndex = 4
        Jadwal_tugasLabel.Text = "jadwal tugas:"
        '
        'Nama_petugasLabel
        '
        Nama_petugasLabel.AutoSize = True
        Nama_petugasLabel.Location = New System.Drawing.Point(408, 141)
        Nama_petugasLabel.Name = "Nama_petugasLabel"
        Nama_petugasLabel.Size = New System.Drawing.Size(77, 13)
        Nama_petugasLabel.TabIndex = 6
        Nama_petugasLabel.Text = "nama petugas:"
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "perpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_petugasBindingSource
        '
        Me.Tb_petugasBindingSource.DataMember = "tb_petugas"
        Me.Tb_petugasBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'Tb_petugasTableAdapter
        '
        Me.Tb_petugasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_dataanggotaTableAdapter = Nothing
        Me.TableAdapterManager.tb_pengembalianTableAdapter = Nothing
        Me.TableAdapterManager.tb_petugasTableAdapter = Me.Tb_petugasTableAdapter
        Me.TableAdapterManager.tb_pinjam_has_tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjamTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_petugasBindingNavigator
        '
        Me.Tb_petugasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_petugasBindingNavigator.BindingSource = Me.Tb_petugasBindingSource
        Me.Tb_petugasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_petugasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_petugasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_petugasBindingNavigatorSaveItem})
        Me.Tb_petugasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_petugasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_petugasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_petugasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_petugasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_petugasBindingNavigator.Name = "Tb_petugasBindingNavigator"
        Me.Tb_petugasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_petugasBindingNavigator.Size = New System.Drawing.Size(912, 25)
        Me.Tb_petugasBindingNavigator.TabIndex = 0
        Me.Tb_petugasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tb_petugasBindingNavigatorSaveItem
        '
        Me.Tb_petugasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_petugasBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_petugasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_petugasBindingNavigatorSaveItem.Name = "Tb_petugasBindingNavigatorSaveItem"
        Me.Tb_petugasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_petugasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tb_petugasDataGridView
        '
        Me.Tb_petugasDataGridView.AutoGenerateColumns = False
        Me.Tb_petugasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_petugasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Tb_petugasDataGridView.DataSource = Me.Tb_petugasBindingSource
        Me.Tb_petugasDataGridView.Location = New System.Drawing.Point(34, 89)
        Me.Tb_petugasDataGridView.Name = "Tb_petugasDataGridView"
        Me.Tb_petugasDataGridView.Size = New System.Drawing.Size(345, 220)
        Me.Tb_petugasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_Petugas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_Petugas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "jadwal_tugas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "jadwal_tugas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nama_petugas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nama_petugas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Id_PetugasTextBox
        '
        Me.Id_PetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_petugasBindingSource, "id_Petugas", True))
        Me.Id_PetugasTextBox.Location = New System.Drawing.Point(491, 86)
        Me.Id_PetugasTextBox.Name = "Id_PetugasTextBox"
        Me.Id_PetugasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_PetugasTextBox.TabIndex = 3
        '
        'Jadwal_tugasDateTimePicker
        '
        Me.Jadwal_tugasDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_petugasBindingSource, "jadwal_tugas", True))
        Me.Jadwal_tugasDateTimePicker.Location = New System.Drawing.Point(491, 116)
        Me.Jadwal_tugasDateTimePicker.Name = "Jadwal_tugasDateTimePicker"
        Me.Jadwal_tugasDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Jadwal_tugasDateTimePicker.TabIndex = 5
        '
        'Nama_petugasTextBox
        '
        Me.Nama_petugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_petugasBindingSource, "nama_petugas", True))
        Me.Nama_petugasTextBox.Location = New System.Drawing.Point(491, 138)
        Me.Nama_petugasTextBox.Name = "Nama_petugasTextBox"
        Me.Nama_petugasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nama_petugasTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PETUGAS"
        '
        'tambahButton
        '
        Me.tambahButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahButton.Location = New System.Drawing.Point(400, 190)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(93, 29)
        Me.tambahButton.TabIndex = 9
        Me.tambahButton.Text = "TAMBAH"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(524, 190)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(93, 29)
        Me.editButton.TabIndex = 10
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusButton.Location = New System.Drawing.Point(657, 190)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(93, 29)
        Me.hapusButton.TabIndex = 11
        Me.hapusButton.Text = "HAPUS"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanButton.Location = New System.Drawing.Point(778, 190)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(93, 29)
        Me.simpanButton.TabIndex = 12
        Me.simpanButton.Text = "SIMPAN"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshButton.Location = New System.Drawing.Point(464, 244)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(93, 29)
        Me.refreshButton.TabIndex = 13
        Me.refreshButton.Text = "REFRESH"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batalButton.Location = New System.Drawing.Point(593, 244)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(93, 29)
        Me.batalButton.TabIndex = 14
        Me.batalButton.Text = "BATAL"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarButton.Location = New System.Drawing.Point(722, 244)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(93, 29)
        Me.keluarButton.TabIndex = 15
        Me.keluarButton.Text = "KELUAR"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'tb_petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 433)
        Me.Controls.Add(Me.keluarButton)
        Me.Controls.Add(Me.batalButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.simpanButton)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_PetugasLabel)
        Me.Controls.Add(Me.Id_PetugasTextBox)
        Me.Controls.Add(Jadwal_tugasLabel)
        Me.Controls.Add(Me.Jadwal_tugasDateTimePicker)
        Me.Controls.Add(Nama_petugasLabel)
        Me.Controls.Add(Me.Nama_petugasTextBox)
        Me.Controls.Add(Me.Tb_petugasDataGridView)
        Me.Controls.Add(Me.Tb_petugasBindingNavigator)
        Me.Name = "tb_petugas"
        Me.Text = "tb_petugas"
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_petugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_petugasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_petugasBindingNavigator.ResumeLayout(False)
        Me.Tb_petugasBindingNavigator.PerformLayout()
        CType(Me.Tb_petugasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDataSet As DataBase_Perpustakaan.perpustakaanDataSet
    Friend WithEvents Tb_petugasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_petugasTableAdapter As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_petugasTableAdapter
    Friend WithEvents TableAdapterManager As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_petugasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tb_petugasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tb_petugasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_PetugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jadwal_tugasDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Nama_petugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
End Class
