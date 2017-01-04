<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tb_buku
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
        Dim Id_BukuLabel As System.Windows.Forms.Label
        Dim Nama_BukuLabel As System.Windows.Forms.Label
        Dim Kondisi_BukuLabel As System.Windows.Forms.Label
        Dim Tb_DataAnggota_id_AnggotaLabel As System.Windows.Forms.Label
        Dim Tb_DataAnggota_Tb_Buku_id_BukuLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tb_buku))
        Me.PerpustakaanDataSet = New DataBase_Perpustakaan.perpustakaanDataSet()
        Me.Tb_bukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_bukuTableAdapter = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_bukuTableAdapter()
        Me.TableAdapterManager = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager()
        Me.Tb_bukuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_bukuBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Kondisi_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_DataAnggota_id_AnggotaTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_DataAnggota_Tb_Buku_id_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_bukuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Id_BukuLabel = New System.Windows.Forms.Label()
        Nama_BukuLabel = New System.Windows.Forms.Label()
        Kondisi_BukuLabel = New System.Windows.Forms.Label()
        Tb_DataAnggota_id_AnggotaLabel = New System.Windows.Forms.Label()
        Tb_DataAnggota_Tb_Buku_id_BukuLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_bukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_bukuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_bukuBindingNavigator.SuspendLayout()
        CType(Me.Tb_bukuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_BukuLabel
        '
        Id_BukuLabel.AutoSize = True
        Id_BukuLabel.Location = New System.Drawing.Point(19, 56)
        Id_BukuLabel.Name = "Id_BukuLabel"
        Id_BukuLabel.Size = New System.Drawing.Size(46, 13)
        Id_BukuLabel.TabIndex = 1
        Id_BukuLabel.Text = "id Buku:"
        '
        'Nama_BukuLabel
        '
        Nama_BukuLabel.AutoSize = True
        Nama_BukuLabel.Location = New System.Drawing.Point(19, 82)
        Nama_BukuLabel.Name = "Nama_BukuLabel"
        Nama_BukuLabel.Size = New System.Drawing.Size(66, 13)
        Nama_BukuLabel.TabIndex = 3
        Nama_BukuLabel.Text = "Nama Buku:"
        '
        'Kondisi_BukuLabel
        '
        Kondisi_BukuLabel.AutoSize = True
        Kondisi_BukuLabel.Location = New System.Drawing.Point(19, 108)
        Kondisi_BukuLabel.Name = "Kondisi_BukuLabel"
        Kondisi_BukuLabel.Size = New System.Drawing.Size(72, 13)
        Kondisi_BukuLabel.TabIndex = 5
        Kondisi_BukuLabel.Text = "Kondisi Buku:"
        '
        'Tb_DataAnggota_id_AnggotaLabel
        '
        Tb_DataAnggota_id_AnggotaLabel.AutoSize = True
        Tb_DataAnggota_id_AnggotaLabel.Location = New System.Drawing.Point(19, 134)
        Tb_DataAnggota_id_AnggotaLabel.Name = "Tb_DataAnggota_id_AnggotaLabel"
        Tb_DataAnggota_id_AnggotaLabel.Size = New System.Drawing.Size(146, 13)
        Tb_DataAnggota_id_AnggotaLabel.TabIndex = 7
        Tb_DataAnggota_id_AnggotaLabel.Text = "Tb Data Anggota id Anggota:"
        '
        'Tb_DataAnggota_Tb_Buku_id_BukuLabel
        '
        Tb_DataAnggota_Tb_Buku_id_BukuLabel.AutoSize = True
        Tb_DataAnggota_Tb_Buku_id_BukuLabel.Location = New System.Drawing.Point(19, 160)
        Tb_DataAnggota_Tb_Buku_id_BukuLabel.Name = "Tb_DataAnggota_Tb_Buku_id_BukuLabel"
        Tb_DataAnggota_Tb_Buku_id_BukuLabel.Size = New System.Drawing.Size(175, 13)
        Tb_DataAnggota_Tb_Buku_id_BukuLabel.TabIndex = 9
        Tb_DataAnggota_Tb_Buku_id_BukuLabel.Text = "Tb Data Anggota Tb Buku id Buku:"
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "perpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_bukuBindingSource
        '
        Me.Tb_bukuBindingSource.DataMember = "tb_buku"
        Me.Tb_bukuBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'Tb_bukuTableAdapter
        '
        Me.Tb_bukuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_bukuTableAdapter = Me.Tb_bukuTableAdapter
        Me.TableAdapterManager.tb_dataanggotaTableAdapter = Nothing
        Me.TableAdapterManager.tb_pengembalianTableAdapter = Nothing
        Me.TableAdapterManager.tb_petugasTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjam_has_tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjamTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_bukuBindingNavigator
        '
        Me.Tb_bukuBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_bukuBindingNavigator.BindingSource = Me.Tb_bukuBindingSource
        Me.Tb_bukuBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_bukuBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_bukuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_bukuBindingNavigatorSaveItem})
        Me.Tb_bukuBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_bukuBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_bukuBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_bukuBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_bukuBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_bukuBindingNavigator.Name = "Tb_bukuBindingNavigator"
        Me.Tb_bukuBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_bukuBindingNavigator.Size = New System.Drawing.Size(834, 25)
        Me.Tb_bukuBindingNavigator.TabIndex = 0
        Me.Tb_bukuBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_bukuBindingNavigatorSaveItem
        '
        Me.Tb_bukuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_bukuBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_bukuBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_bukuBindingNavigatorSaveItem.Name = "Tb_bukuBindingNavigatorSaveItem"
        Me.Tb_bukuBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_bukuBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_BukuTextBox
        '
        Me.Id_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_bukuBindingSource, "id_Buku", True))
        Me.Id_BukuTextBox.Location = New System.Drawing.Point(200, 53)
        Me.Id_BukuTextBox.Name = "Id_BukuTextBox"
        Me.Id_BukuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_BukuTextBox.TabIndex = 2
        '
        'Nama_BukuTextBox
        '
        Me.Nama_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_bukuBindingSource, "Nama_Buku", True))
        Me.Nama_BukuTextBox.Location = New System.Drawing.Point(200, 79)
        Me.Nama_BukuTextBox.Name = "Nama_BukuTextBox"
        Me.Nama_BukuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_BukuTextBox.TabIndex = 4
        '
        'Kondisi_BukuTextBox
        '
        Me.Kondisi_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_bukuBindingSource, "Kondisi_Buku", True))
        Me.Kondisi_BukuTextBox.Location = New System.Drawing.Point(200, 105)
        Me.Kondisi_BukuTextBox.Name = "Kondisi_BukuTextBox"
        Me.Kondisi_BukuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kondisi_BukuTextBox.TabIndex = 6
        '
        'Tb_DataAnggota_id_AnggotaTextBox
        '
        Me.Tb_DataAnggota_id_AnggotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_bukuBindingSource, "Tb_DataAnggota_id_Anggota", True))
        Me.Tb_DataAnggota_id_AnggotaTextBox.Location = New System.Drawing.Point(200, 131)
        Me.Tb_DataAnggota_id_AnggotaTextBox.Name = "Tb_DataAnggota_id_AnggotaTextBox"
        Me.Tb_DataAnggota_id_AnggotaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tb_DataAnggota_id_AnggotaTextBox.TabIndex = 8
        '
        'Tb_DataAnggota_Tb_Buku_id_BukuTextBox
        '
        Me.Tb_DataAnggota_Tb_Buku_id_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_bukuBindingSource, "Tb_DataAnggota_Tb_Buku_id_Buku", True))
        Me.Tb_DataAnggota_Tb_Buku_id_BukuTextBox.Location = New System.Drawing.Point(200, 157)
        Me.Tb_DataAnggota_Tb_Buku_id_BukuTextBox.Name = "Tb_DataAnggota_Tb_Buku_id_BukuTextBox"
        Me.Tb_DataAnggota_Tb_Buku_id_BukuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tb_DataAnggota_Tb_Buku_id_BukuTextBox.TabIndex = 10
        '
        'Tb_bukuDataGridView
        '
        Me.Tb_bukuDataGridView.AutoGenerateColumns = False
        Me.Tb_bukuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_bukuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Tb_bukuDataGridView.DataSource = Me.Tb_bukuBindingSource
        Me.Tb_bukuDataGridView.Location = New System.Drawing.Point(132, 183)
        Me.Tb_bukuDataGridView.Name = "Tb_bukuDataGridView"
        Me.Tb_bukuDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.Tb_bukuDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_Buku"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_Buku"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_Buku"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_Buku"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Kondisi_Buku"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kondisi_Buku"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tb_DataAnggota_id_Anggota"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tb_DataAnggota_id_Anggota"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tb_DataAnggota_Tb_Buku_id_Buku"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tb_DataAnggota_Tb_Buku_id_Buku"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "BUKU"
        '
        'tambahButton
        '
        Me.tambahButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahButton.Location = New System.Drawing.Point(319, 74)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(91, 28)
        Me.tambahButton.TabIndex = 13
        Me.tambahButton.Text = "TAMBAH"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(468, 74)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(70, 28)
        Me.editButton.TabIndex = 14
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusButton.Location = New System.Drawing.Point(606, 74)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(70, 28)
        Me.hapusButton.TabIndex = 15
        Me.hapusButton.Text = "HAPUS"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanButton.Location = New System.Drawing.Point(742, 74)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(80, 28)
        Me.simpanButton.TabIndex = 16
        Me.simpanButton.Text = "SIMPAN"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshButton.Location = New System.Drawing.Point(386, 134)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(93, 28)
        Me.refreshButton.TabIndex = 17
        Me.refreshButton.Text = "REFRESH"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarButton.Location = New System.Drawing.Point(539, 134)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(84, 28)
        Me.keluarButton.TabIndex = 18
        Me.keluarButton.Text = "KELUAR"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batalButton.Location = New System.Drawing.Point(685, 131)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(70, 28)
        Me.batalButton.TabIndex = 19
        Me.batalButton.Text = "BATAL"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'tb_buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 415)
        Me.Controls.Add(Me.batalButton)
        Me.Controls.Add(Me.keluarButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.simpanButton)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_bukuDataGridView)
        Me.Controls.Add(Id_BukuLabel)
        Me.Controls.Add(Me.Id_BukuTextBox)
        Me.Controls.Add(Nama_BukuLabel)
        Me.Controls.Add(Me.Nama_BukuTextBox)
        Me.Controls.Add(Kondisi_BukuLabel)
        Me.Controls.Add(Me.Kondisi_BukuTextBox)
        Me.Controls.Add(Tb_DataAnggota_id_AnggotaLabel)
        Me.Controls.Add(Me.Tb_DataAnggota_id_AnggotaTextBox)
        Me.Controls.Add(Tb_DataAnggota_Tb_Buku_id_BukuLabel)
        Me.Controls.Add(Me.Tb_DataAnggota_Tb_Buku_id_BukuTextBox)
        Me.Controls.Add(Me.Tb_bukuBindingNavigator)
        Me.Name = "tb_buku"
        Me.Text = "Form1"
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_bukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_bukuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_bukuBindingNavigator.ResumeLayout(False)
        Me.Tb_bukuBindingNavigator.PerformLayout()
        CType(Me.Tb_bukuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDataSet As DataBase_Perpustakaan.perpustakaanDataSet
    Friend WithEvents Tb_bukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_bukuTableAdapter As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_bukuTableAdapter
    Friend WithEvents TableAdapterManager As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_bukuBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_bukuBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kondisi_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tb_DataAnggota_id_AnggotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tb_DataAnggota_Tb_Buku_id_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tb_bukuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents batalButton As System.Windows.Forms.Button

End Class
