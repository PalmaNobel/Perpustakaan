<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tb_anggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tb_anggota))
        Dim Id_AnggotaLabel As System.Windows.Forms.Label
        Dim Nama_anggotaLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim KontakLabel As System.Windows.Forms.Label
        Dim Tb_Buku_id_BukuLabel As System.Windows.Forms.Label
        Dim T_b_Petugas_id_PetugasLabel As System.Windows.Forms.Label
        Me.PerpustakaanDataSet = New DataBase_Perpustakaan.perpustakaanDataSet()
        Me.Tb_dataanggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_dataanggotaTableAdapter = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_dataanggotaTableAdapter()
        Me.TableAdapterManager = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager()
        Me.Tb_dataanggotaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_dataanggotaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_AnggotaTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_anggotaTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.KontakTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_Buku_id_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.T_b_Petugas_id_PetugasTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_dataanggotaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Id_AnggotaLabel = New System.Windows.Forms.Label()
        Nama_anggotaLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        KontakLabel = New System.Windows.Forms.Label()
        Tb_Buku_id_BukuLabel = New System.Windows.Forms.Label()
        T_b_Petugas_id_PetugasLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_dataanggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_dataanggotaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_dataanggotaBindingNavigator.SuspendLayout()
        CType(Me.Tb_dataanggotaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "perpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_dataanggotaBindingSource
        '
        Me.Tb_dataanggotaBindingSource.DataMember = "tb_dataanggota"
        Me.Tb_dataanggotaBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'Tb_dataanggotaTableAdapter
        '
        Me.Tb_dataanggotaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_dataanggotaTableAdapter = Me.Tb_dataanggotaTableAdapter
        Me.TableAdapterManager.tb_pengembalianTableAdapter = Nothing
        Me.TableAdapterManager.tb_petugasTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjam_has_tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjamTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_dataanggotaBindingNavigator
        '
        Me.Tb_dataanggotaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_dataanggotaBindingNavigator.BindingSource = Me.Tb_dataanggotaBindingSource
        Me.Tb_dataanggotaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_dataanggotaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_dataanggotaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_dataanggotaBindingNavigatorSaveItem})
        Me.Tb_dataanggotaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_dataanggotaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_dataanggotaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_dataanggotaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_dataanggotaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_dataanggotaBindingNavigator.Name = "Tb_dataanggotaBindingNavigator"
        Me.Tb_dataanggotaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_dataanggotaBindingNavigator.Size = New System.Drawing.Size(728, 25)
        Me.Tb_dataanggotaBindingNavigator.TabIndex = 0
        Me.Tb_dataanggotaBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_dataanggotaBindingNavigatorSaveItem
        '
        Me.Tb_dataanggotaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_dataanggotaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_dataanggotaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_dataanggotaBindingNavigatorSaveItem.Name = "Tb_dataanggotaBindingNavigatorSaveItem"
        Me.Tb_dataanggotaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_dataanggotaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_AnggotaLabel
        '
        Id_AnggotaLabel.AutoSize = True
        Id_AnggotaLabel.Location = New System.Drawing.Point(5, 31)
        Id_AnggotaLabel.Name = "Id_AnggotaLabel"
        Id_AnggotaLabel.Size = New System.Drawing.Size(61, 13)
        Id_AnggotaLabel.TabIndex = 1
        Id_AnggotaLabel.Text = "id Anggota:"
        '
        'Id_AnggotaTextBox
        '
        Me.Id_AnggotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_dataanggotaBindingSource, "id_Anggota", True))
        Me.Id_AnggotaTextBox.Location = New System.Drawing.Point(132, 28)
        Me.Id_AnggotaTextBox.Name = "Id_AnggotaTextBox"
        Me.Id_AnggotaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_AnggotaTextBox.TabIndex = 2
        '
        'Nama_anggotaLabel
        '
        Nama_anggotaLabel.AutoSize = True
        Nama_anggotaLabel.Location = New System.Drawing.Point(5, 57)
        Nama_anggotaLabel.Name = "Nama_anggotaLabel"
        Nama_anggotaLabel.Size = New System.Drawing.Size(80, 13)
        Nama_anggotaLabel.TabIndex = 3
        Nama_anggotaLabel.Text = "Nama anggota:"
        '
        'Nama_anggotaTextBox
        '
        Me.Nama_anggotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_dataanggotaBindingSource, "Nama_anggota", True))
        Me.Nama_anggotaTextBox.Location = New System.Drawing.Point(132, 54)
        Me.Nama_anggotaTextBox.Name = "Nama_anggotaTextBox"
        Me.Nama_anggotaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_anggotaTextBox.TabIndex = 4
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(5, 83)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 5
        AlamatLabel.Text = "Alamat:"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_dataanggotaBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(132, 80)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlamatTextBox.TabIndex = 6
        '
        'KontakLabel
        '
        KontakLabel.AutoSize = True
        KontakLabel.Location = New System.Drawing.Point(5, 109)
        KontakLabel.Name = "KontakLabel"
        KontakLabel.Size = New System.Drawing.Size(44, 13)
        KontakLabel.TabIndex = 7
        KontakLabel.Text = "Kontak:"
        '
        'KontakTextBox
        '
        Me.KontakTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_dataanggotaBindingSource, "Kontak", True))
        Me.KontakTextBox.Location = New System.Drawing.Point(132, 106)
        Me.KontakTextBox.Name = "KontakTextBox"
        Me.KontakTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KontakTextBox.TabIndex = 8
        '
        'Tb_Buku_id_BukuLabel
        '
        Tb_Buku_id_BukuLabel.AutoSize = True
        Tb_Buku_id_BukuLabel.Location = New System.Drawing.Point(5, 135)
        Tb_Buku_id_BukuLabel.Name = "Tb_Buku_id_BukuLabel"
        Tb_Buku_id_BukuLabel.Size = New System.Drawing.Size(90, 13)
        Tb_Buku_id_BukuLabel.TabIndex = 9
        Tb_Buku_id_BukuLabel.Text = "Tb Buku id Buku:"
        '
        'Tb_Buku_id_BukuTextBox
        '
        Me.Tb_Buku_id_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_dataanggotaBindingSource, "Tb_Buku_id_Buku", True))
        Me.Tb_Buku_id_BukuTextBox.Location = New System.Drawing.Point(132, 132)
        Me.Tb_Buku_id_BukuTextBox.Name = "Tb_Buku_id_BukuTextBox"
        Me.Tb_Buku_id_BukuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tb_Buku_id_BukuTextBox.TabIndex = 10
        '
        'T_b_Petugas_id_PetugasLabel
        '
        T_b_Petugas_id_PetugasLabel.AutoSize = True
        T_b_Petugas_id_PetugasLabel.Location = New System.Drawing.Point(5, 161)
        T_b_Petugas_id_PetugasLabel.Name = "T_b_Petugas_id_PetugasLabel"
        T_b_Petugas_id_PetugasLabel.Size = New System.Drawing.Size(121, 13)
        T_b_Petugas_id_PetugasLabel.TabIndex = 11
        T_b_Petugas_id_PetugasLabel.Text = "T b Petugas id Petugas:"
        '
        'T_b_Petugas_id_PetugasTextBox
        '
        Me.T_b_Petugas_id_PetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_dataanggotaBindingSource, "T b_Petugas_id_Petugas", True))
        Me.T_b_Petugas_id_PetugasTextBox.Location = New System.Drawing.Point(132, 158)
        Me.T_b_Petugas_id_PetugasTextBox.Name = "T_b_Petugas_id_PetugasTextBox"
        Me.T_b_Petugas_id_PetugasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_b_Petugas_id_PetugasTextBox.TabIndex = 12
        '
        'Tb_dataanggotaDataGridView
        '
        Me.Tb_dataanggotaDataGridView.AutoGenerateColumns = False
        Me.Tb_dataanggotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_dataanggotaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tb_dataanggotaDataGridView.DataSource = Me.Tb_dataanggotaBindingSource
        Me.Tb_dataanggotaDataGridView.Location = New System.Drawing.Point(12, 184)
        Me.Tb_dataanggotaDataGridView.Name = "Tb_dataanggotaDataGridView"
        Me.Tb_dataanggotaDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.Tb_dataanggotaDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_Anggota"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_Anggota"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_anggota"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_anggota"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Alamat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Kontak"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kontak"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tb_Buku_id_Buku"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tb_Buku_id_Buku"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "T b_Petugas_id_Petugas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "T b_Petugas_id_Petugas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'tambahButton
        '
        Me.tambahButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahButton.Location = New System.Drawing.Point(441, 96)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(75, 23)
        Me.tambahButton.TabIndex = 14
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(335, 125)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 15
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusButton.Location = New System.Drawing.Point(441, 125)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 16
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanButton.Location = New System.Drawing.Point(555, 125)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(75, 23)
        Me.simpanButton.TabIndex = 17
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batalButton.Location = New System.Drawing.Point(335, 158)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(75, 23)
        Me.batalButton.TabIndex = 18
        Me.batalButton.Text = "Batal"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshButton.Location = New System.Drawing.Point(441, 158)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(75, 23)
        Me.refreshButton.TabIndex = 19
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarButton.Location = New System.Drawing.Point(555, 158)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(75, 23)
        Me.keluarButton.TabIndex = 20
        Me.keluarButton.Text = "Keluar"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'tb_anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 414)
        Me.Controls.Add(Me.keluarButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.batalButton)
        Me.Controls.Add(Me.simpanButton)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Me.Tb_dataanggotaDataGridView)
        Me.Controls.Add(Id_AnggotaLabel)
        Me.Controls.Add(Me.Id_AnggotaTextBox)
        Me.Controls.Add(Nama_anggotaLabel)
        Me.Controls.Add(Me.Nama_anggotaTextBox)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(KontakLabel)
        Me.Controls.Add(Me.KontakTextBox)
        Me.Controls.Add(Tb_Buku_id_BukuLabel)
        Me.Controls.Add(Me.Tb_Buku_id_BukuTextBox)
        Me.Controls.Add(T_b_Petugas_id_PetugasLabel)
        Me.Controls.Add(Me.T_b_Petugas_id_PetugasTextBox)
        Me.Controls.Add(Me.Tb_dataanggotaBindingNavigator)
        Me.Name = "tb_anggota"
        Me.Text = "tb_anggota"
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_dataanggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_dataanggotaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_dataanggotaBindingNavigator.ResumeLayout(False)
        Me.Tb_dataanggotaBindingNavigator.PerformLayout()
        CType(Me.Tb_dataanggotaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDataSet As DataBase_Perpustakaan.perpustakaanDataSet
    Friend WithEvents Tb_dataanggotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_dataanggotaTableAdapter As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_dataanggotaTableAdapter
    Friend WithEvents TableAdapterManager As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_dataanggotaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_dataanggotaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_AnggotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_anggotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KontakTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Buku_id_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_b_Petugas_id_PetugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tb_dataanggotaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
End Class
