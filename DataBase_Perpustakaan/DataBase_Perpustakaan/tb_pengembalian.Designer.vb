<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tb_pengembalian
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
        Dim Tgl_PinjamLabel As System.Windows.Forms.Label
        Dim Tgl_PengembalianLabel As System.Windows.Forms.Label
        Dim DendaLabel As System.Windows.Forms.Label
        Dim T_b_Petugas_id_PetugasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tb_pengembalian))
        Me.PerpustakaanDataSet = New DataBase_Perpustakaan.perpustakaanDataSet()
        Me.Tb_pengembalianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_pengembalianTableAdapter = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_pengembalianTableAdapter()
        Me.TableAdapterManager = New DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager()
        Me.Tb_pengembalianBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_pengembalianBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_pengembalianDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tgl_PinjamDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tgl_PengembalianDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DendaTextBox = New System.Windows.Forms.TextBox()
        Me.T_b_Petugas_id_PetugasTextBox = New System.Windows.Forms.TextBox()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Tgl_PinjamLabel = New System.Windows.Forms.Label()
        Tgl_PengembalianLabel = New System.Windows.Forms.Label()
        DendaLabel = New System.Windows.Forms.Label()
        T_b_Petugas_id_PetugasLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_pengembalianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_pengembalianBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_pengembalianBindingNavigator.SuspendLayout()
        CType(Me.Tb_pengembalianDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tgl_PinjamLabel
        '
        Tgl_PinjamLabel.AutoSize = True
        Tgl_PinjamLabel.Location = New System.Drawing.Point(485, 58)
        Tgl_PinjamLabel.Name = "Tgl_PinjamLabel"
        Tgl_PinjamLabel.Size = New System.Drawing.Size(59, 13)
        Tgl_PinjamLabel.TabIndex = 3
        Tgl_PinjamLabel.Text = "Tgl Pinjam:"
        '
        'Tgl_PengembalianLabel
        '
        Tgl_PengembalianLabel.AutoSize = True
        Tgl_PengembalianLabel.Location = New System.Drawing.Point(485, 84)
        Tgl_PengembalianLabel.Name = "Tgl_PengembalianLabel"
        Tgl_PengembalianLabel.Size = New System.Drawing.Size(95, 13)
        Tgl_PengembalianLabel.TabIndex = 5
        Tgl_PengembalianLabel.Text = "Tgl Pengembalian:"
        '
        'DendaLabel
        '
        DendaLabel.AutoSize = True
        DendaLabel.Location = New System.Drawing.Point(485, 109)
        DendaLabel.Name = "DendaLabel"
        DendaLabel.Size = New System.Drawing.Size(42, 13)
        DendaLabel.TabIndex = 7
        DendaLabel.Text = "Denda:"
        '
        'T_b_Petugas_id_PetugasLabel
        '
        T_b_Petugas_id_PetugasLabel.AutoSize = True
        T_b_Petugas_id_PetugasLabel.Location = New System.Drawing.Point(485, 135)
        T_b_Petugas_id_PetugasLabel.Name = "T_b_Petugas_id_PetugasLabel"
        T_b_Petugas_id_PetugasLabel.Size = New System.Drawing.Size(121, 13)
        T_b_Petugas_id_PetugasLabel.TabIndex = 9
        T_b_Petugas_id_PetugasLabel.Text = "T b Petugas id Petugas:"
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "perpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_pengembalianBindingSource
        '
        Me.Tb_pengembalianBindingSource.DataMember = "tb_pengembalian"
        Me.Tb_pengembalianBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'Tb_pengembalianTableAdapter
        '
        Me.Tb_pengembalianTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_dataanggotaTableAdapter = Nothing
        Me.TableAdapterManager.tb_pengembalianTableAdapter = Me.Tb_pengembalianTableAdapter
        Me.TableAdapterManager.tb_petugasTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjam_has_tb_bukuTableAdapter = Nothing
        Me.TableAdapterManager.tb_pinjamTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_pengembalianBindingNavigator
        '
        Me.Tb_pengembalianBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_pengembalianBindingNavigator.BindingSource = Me.Tb_pengembalianBindingSource
        Me.Tb_pengembalianBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_pengembalianBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_pengembalianBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_pengembalianBindingNavigatorSaveItem})
        Me.Tb_pengembalianBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_pengembalianBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_pengembalianBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_pengembalianBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_pengembalianBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_pengembalianBindingNavigator.Name = "Tb_pengembalianBindingNavigator"
        Me.Tb_pengembalianBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_pengembalianBindingNavigator.Size = New System.Drawing.Size(956, 25)
        Me.Tb_pengembalianBindingNavigator.TabIndex = 0
        Me.Tb_pengembalianBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_pengembalianBindingNavigatorSaveItem
        '
        Me.Tb_pengembalianBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_pengembalianBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_pengembalianBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_pengembalianBindingNavigatorSaveItem.Name = "Tb_pengembalianBindingNavigatorSaveItem"
        Me.Tb_pengembalianBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_pengembalianBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tb_pengembalianDataGridView
        '
        Me.Tb_pengembalianDataGridView.AutoGenerateColumns = False
        Me.Tb_pengembalianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_pengembalianDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Tb_pengembalianDataGridView.DataSource = Me.Tb_pengembalianBindingSource
        Me.Tb_pengembalianDataGridView.Location = New System.Drawing.Point(12, 58)
        Me.Tb_pengembalianDataGridView.Name = "Tb_pengembalianDataGridView"
        Me.Tb_pengembalianDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.Tb_pengembalianDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Tgl_Pinjam"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tgl_Pinjam"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tgl_Pengembalian"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tgl_Pengembalian"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Denda"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Denda"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "T b_Petugas_id_Petugas"
        Me.DataGridViewTextBoxColumn4.HeaderText = "T b_Petugas_id_Petugas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PENGEMBALIAN"
        '
        'Tgl_PinjamDateTimePicker
        '
        Me.Tgl_PinjamDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_pengembalianBindingSource, "Tgl_Pinjam", True))
        Me.Tgl_PinjamDateTimePicker.Location = New System.Drawing.Point(612, 54)
        Me.Tgl_PinjamDateTimePicker.Name = "Tgl_PinjamDateTimePicker"
        Me.Tgl_PinjamDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_PinjamDateTimePicker.TabIndex = 4
        '
        'Tgl_PengembalianDateTimePicker
        '
        Me.Tgl_PengembalianDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_pengembalianBindingSource, "Tgl_Pengembalian", True))
        Me.Tgl_PengembalianDateTimePicker.Location = New System.Drawing.Point(612, 80)
        Me.Tgl_PengembalianDateTimePicker.Name = "Tgl_PengembalianDateTimePicker"
        Me.Tgl_PengembalianDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_PengembalianDateTimePicker.TabIndex = 6
        '
        'DendaTextBox
        '
        Me.DendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_pengembalianBindingSource, "Denda", True))
        Me.DendaTextBox.Location = New System.Drawing.Point(612, 106)
        Me.DendaTextBox.Name = "DendaTextBox"
        Me.DendaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DendaTextBox.TabIndex = 8
        '
        'T_b_Petugas_id_PetugasTextBox
        '
        Me.T_b_Petugas_id_PetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_pengembalianBindingSource, "T b_Petugas_id_Petugas", True))
        Me.T_b_Petugas_id_PetugasTextBox.Location = New System.Drawing.Point(612, 132)
        Me.T_b_Petugas_id_PetugasTextBox.Name = "T_b_Petugas_id_PetugasTextBox"
        Me.T_b_Petugas_id_PetugasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.T_b_Petugas_id_PetugasTextBox.TabIndex = 10
        '
        'tambahButton
        '
        Me.tambahButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahButton.Location = New System.Drawing.Point(469, 182)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(98, 23)
        Me.tambahButton.TabIndex = 11
        Me.tambahButton.Text = "TAMBAH"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(573, 182)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 12
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusButton.Location = New System.Drawing.Point(677, 182)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 13
        Me.hapusButton.Text = "HAPUS"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanButton.Location = New System.Drawing.Point(773, 182)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(84, 23)
        Me.simpanButton.TabIndex = 14
        Me.simpanButton.Text = "SIMPAN"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshButton.Location = New System.Drawing.Point(508, 230)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(98, 23)
        Me.refreshButton.TabIndex = 15
        Me.refreshButton.Text = "REFRESH"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarButton.Location = New System.Drawing.Point(633, 230)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(84, 23)
        Me.keluarButton.TabIndex = 16
        Me.keluarButton.Text = "KELUAR"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batalButton.Location = New System.Drawing.Point(737, 230)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(75, 23)
        Me.batalButton.TabIndex = 17
        Me.batalButton.Text = "BATAL"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'tb_pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 476)
        Me.Controls.Add(Me.batalButton)
        Me.Controls.Add(Me.keluarButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.simpanButton)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Tgl_PinjamLabel)
        Me.Controls.Add(Me.Tgl_PinjamDateTimePicker)
        Me.Controls.Add(Tgl_PengembalianLabel)
        Me.Controls.Add(Me.Tgl_PengembalianDateTimePicker)
        Me.Controls.Add(DendaLabel)
        Me.Controls.Add(Me.DendaTextBox)
        Me.Controls.Add(T_b_Petugas_id_PetugasLabel)
        Me.Controls.Add(Me.T_b_Petugas_id_PetugasTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_pengembalianDataGridView)
        Me.Controls.Add(Me.Tb_pengembalianBindingNavigator)
        Me.Name = "tb_pengembalian"
        Me.Text = "tb_pengembalian"
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_pengembalianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_pengembalianBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_pengembalianBindingNavigator.ResumeLayout(False)
        Me.Tb_pengembalianBindingNavigator.PerformLayout()
        CType(Me.Tb_pengembalianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDataSet As DataBase_Perpustakaan.perpustakaanDataSet
    Friend WithEvents Tb_pengembalianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_pengembalianTableAdapter As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.tb_pengembalianTableAdapter
    Friend WithEvents TableAdapterManager As DataBase_Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_pengembalianBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_pengembalianBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tb_pengembalianDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tgl_PinjamDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tgl_PengembalianDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_b_Petugas_id_PetugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents batalButton As System.Windows.Forms.Button
End Class
