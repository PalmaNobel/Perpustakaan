<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tb_pinjam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tb_pinjam))
        Dim Id_PinjamLabel As System.Windows.Forms.Label
        Dim Tgl_PinjamLabel As System.Windows.Forms.Label
        Dim Nama_AnggotaLabel As System.Windows.Forms.Label
        Dim Tb_Pengembalian_T_b_Petugas_id_PetugasLabel As System.Windows.Forms.Label
        Me.PerpustakaanDataSet = New DataBase_Perpustakaan.perpustakaanDataSet()
        Me.Tb_pinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_pinjamTableAdapter = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_pinjamTableAdapter()
        Me.TableAdapterManager = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager()
        Me.Tb_pinjamBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_pinjamBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_pinjamDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id_PinjamTextBox = New System.Windows.Forms.TextBox()
        Me.Tgl_PinjamDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Nama_AnggotaTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox = New System.Windows.Forms.TextBox()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Id_PinjamLabel = New System.Windows.Forms.Label()
        Tgl_PinjamLabel = New System.Windows.Forms.Label()
        Nama_AnggotaLabel = New System.Windows.Forms.Label()
        Tb_Pengembalian_T_b_Petugas_id_PetugasLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_pinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_pinjamBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_pinjamBindingNavigator.SuspendLayout()
        CType(Me.Tb_pinjamDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "perpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_pinjamBindingSource
        '
        Me.Tb_pinjamBindingSource.DataMember = "tb_pinjam"
        Me.Tb_pinjamBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'Tb_pinjamTableAdapter
        '
        Me.Tb_pinjamTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_dataanggotaTableAdapter = Nothing
        Me.TableAdapterManager.tb_pengembalianTableAdapter = Nothing
        Me.TableAdapterManager.tb_petugasTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjam_has_tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjamTableAdapter = Me.Tb_pinjamTableAdapter
        Me.TableAdapterManager.UpdateOrder = DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_pinjamBindingNavigator
        '
        Me.Tb_pinjamBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_pinjamBindingNavigator.BindingSource = Me.Tb_pinjamBindingSource
        Me.Tb_pinjamBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_pinjamBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_pinjamBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_pinjamBindingNavigatorSaveItem})
        Me.Tb_pinjamBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_pinjamBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_pinjamBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_pinjamBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_pinjamBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_pinjamBindingNavigator.Name = "Tb_pinjamBindingNavigator"
        Me.Tb_pinjamBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_pinjamBindingNavigator.Size = New System.Drawing.Size(742, 25)
        Me.Tb_pinjamBindingNavigator.TabIndex = 0
        Me.Tb_pinjamBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tb_pinjamBindingNavigatorSaveItem
        '
        Me.Tb_pinjamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_pinjamBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_pinjamBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_pinjamBindingNavigatorSaveItem.Name = "Tb_pinjamBindingNavigatorSaveItem"
        Me.Tb_pinjamBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_pinjamBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tb_pinjamDataGridView
        '
        Me.Tb_pinjamDataGridView.AutoGenerateColumns = False
        Me.Tb_pinjamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_pinjamDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Tb_pinjamDataGridView.DataSource = Me.Tb_pinjamBindingSource
        Me.Tb_pinjamDataGridView.Location = New System.Drawing.Point(12, 223)
        Me.Tb_pinjamDataGridView.Name = "Tb_pinjamDataGridView"
        Me.Tb_pinjamDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.Tb_pinjamDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_Pinjam"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_Pinjam"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tgl_Pinjam"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tgl_Pinjam"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nama_Anggota"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama_Anggota"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tb_Pengembalian_T b_Petugas_id_Petugas"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tb_Pengembalian_T b_Petugas_id_Petugas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PINJAM"
        '
        'Id_PinjamLabel
        '
        Id_PinjamLabel.AutoSize = True
        Id_PinjamLabel.Location = New System.Drawing.Point(7, 42)
        Id_PinjamLabel.Name = "Id_PinjamLabel"
        Id_PinjamLabel.Size = New System.Drawing.Size(52, 13)
        Id_PinjamLabel.TabIndex = 3
        Id_PinjamLabel.Text = "id Pinjam:"
        '
        'Id_PinjamTextBox
        '
        Me.Id_PinjamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_pinjamBindingSource, "id_Pinjam", True))
        Me.Id_PinjamTextBox.Location = New System.Drawing.Point(220, 39)
        Me.Id_PinjamTextBox.Name = "Id_PinjamTextBox"
        Me.Id_PinjamTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_PinjamTextBox.TabIndex = 4
        '
        'Tgl_PinjamLabel
        '
        Tgl_PinjamLabel.AutoSize = True
        Tgl_PinjamLabel.Location = New System.Drawing.Point(7, 69)
        Tgl_PinjamLabel.Name = "Tgl_PinjamLabel"
        Tgl_PinjamLabel.Size = New System.Drawing.Size(59, 13)
        Tgl_PinjamLabel.TabIndex = 5
        Tgl_PinjamLabel.Text = "Tgl Pinjam:"
        '
        'Tgl_PinjamDateTimePicker
        '
        Me.Tgl_PinjamDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_pinjamBindingSource, "Tgl_Pinjam", True))
        Me.Tgl_PinjamDateTimePicker.Location = New System.Drawing.Point(220, 65)
        Me.Tgl_PinjamDateTimePicker.Name = "Tgl_PinjamDateTimePicker"
        Me.Tgl_PinjamDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_PinjamDateTimePicker.TabIndex = 6
        '
        'Nama_AnggotaLabel
        '
        Nama_AnggotaLabel.AutoSize = True
        Nama_AnggotaLabel.Location = New System.Drawing.Point(7, 94)
        Nama_AnggotaLabel.Name = "Nama_AnggotaLabel"
        Nama_AnggotaLabel.Size = New System.Drawing.Size(81, 13)
        Nama_AnggotaLabel.TabIndex = 7
        Nama_AnggotaLabel.Text = "Nama Anggota:"
        '
        'Nama_AnggotaTextBox
        '
        Me.Nama_AnggotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_pinjamBindingSource, "Nama_Anggota", True))
        Me.Nama_AnggotaTextBox.Location = New System.Drawing.Point(220, 91)
        Me.Nama_AnggotaTextBox.Name = "Nama_AnggotaTextBox"
        Me.Nama_AnggotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nama_AnggotaTextBox.TabIndex = 8
        '
        'Tb_Pengembalian_T_b_Petugas_id_PetugasLabel
        '
        Tb_Pengembalian_T_b_Petugas_id_PetugasLabel.AutoSize = True
        Tb_Pengembalian_T_b_Petugas_id_PetugasLabel.Location = New System.Drawing.Point(7, 120)
        Tb_Pengembalian_T_b_Petugas_id_PetugasLabel.Name = "Tb_Pengembalian_T_b_Petugas_id_PetugasLabel"
        Tb_Pengembalian_T_b_Petugas_id_PetugasLabel.Size = New System.Drawing.Size(207, 13)
        Tb_Pengembalian_T_b_Petugas_id_PetugasLabel.TabIndex = 9
        Tb_Pengembalian_T_b_Petugas_id_PetugasLabel.Text = "Tb Pengembalian T b Petugas id Petugas:"
        '
        'Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox
        '
        Me.Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_pinjamBindingSource, "Tb_Pengembalian_T b_Petugas_id_Petugas", True))
        Me.Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox.Location = New System.Drawing.Point(220, 117)
        Me.Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox.Name = "Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox"
        Me.Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox.TabIndex = 10
        '
        'tambahButton
        '
        Me.tambahButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahButton.Location = New System.Drawing.Point(478, 282)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(75, 23)
        Me.tambahButton.TabIndex = 11
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(655, 282)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 12
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusButton.Location = New System.Drawing.Point(478, 334)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 13
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanButton.Location = New System.Drawing.Point(655, 334)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(75, 23)
        Me.simpanButton.TabIndex = 14
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batalButton.Location = New System.Drawing.Point(573, 370)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(75, 23)
        Me.batalButton.TabIndex = 15
        Me.batalButton.Text = "Batal"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshButton.Location = New System.Drawing.Point(478, 406)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(75, 23)
        Me.refreshButton.TabIndex = 16
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarButton.Location = New System.Drawing.Point(655, 406)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(75, 23)
        Me.keluarButton.TabIndex = 17
        Me.keluarButton.Text = "Keluar"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'tb_pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 455)
        Me.Controls.Add(Me.keluarButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.batalButton)
        Me.Controls.Add(Me.simpanButton)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Id_PinjamLabel)
        Me.Controls.Add(Me.Id_PinjamTextBox)
        Me.Controls.Add(Tgl_PinjamLabel)
        Me.Controls.Add(Me.Tgl_PinjamDateTimePicker)
        Me.Controls.Add(Nama_AnggotaLabel)
        Me.Controls.Add(Me.Nama_AnggotaTextBox)
        Me.Controls.Add(Tb_Pengembalian_T_b_Petugas_id_PetugasLabel)
        Me.Controls.Add(Me.Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_pinjamDataGridView)
        Me.Controls.Add(Me.Tb_pinjamBindingNavigator)
        Me.Name = "tb_pinjam"
        Me.Text = "tb_pinjam"
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_pinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_pinjamBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_pinjamBindingNavigator.ResumeLayout(False)
        Me.Tb_pinjamBindingNavigator.PerformLayout()
        CType(Me.Tb_pinjamDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDataSet As DataBase_Perpustakaan.perpustakaanDataSet
    Friend WithEvents Tb_pinjamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_pinjamTableAdapter As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_pinjamTableAdapter
    Friend WithEvents TableAdapterManager As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_pinjamBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_pinjamBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tb_pinjamDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id_PinjamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tgl_PinjamDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Nama_AnggotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Pengembalian_T_b_Petugas_id_PetugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
End Class
