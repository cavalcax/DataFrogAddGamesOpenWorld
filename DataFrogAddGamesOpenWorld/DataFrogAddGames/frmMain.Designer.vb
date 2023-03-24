<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtDirDb = New System.Windows.Forms.TextBox
    Me.txtDirRoms = New System.Windows.Forms.TextBox
    Me.fbdRoms = New System.Windows.Forms.FolderBrowserDialog
    Me.sfdDB = New System.Windows.Forms.SaveFileDialog
    Me.pbAndamento = New System.Windows.Forms.ProgressBar
    Me.lblStatus = New System.Windows.Forms.Label
    Me.bwAddRoms = New System.ComponentModel.BackgroundWorker
    Me.lblRomAdd = New System.Windows.Forms.Label
    Me.grpEditRoms = New System.Windows.Forms.GroupBox
    Me.Label30 = New System.Windows.Forms.Label
    Me.Label29 = New System.Windows.Forms.Label
    Me.txtAdicionarPalavra = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.txtRemoverPalavra = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtNovaExtensao = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtExtensaoOriginal = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.grpSystemConfig = New System.Windows.Forms.GroupBox
    Me.Label13 = New System.Windows.Forms.Label
    Me.cboScummVM = New System.Windows.Forms.ComboBox
    Me.Label12 = New System.Windows.Forms.Label
    Me.cboDOS = New System.Windows.Forms.ComboBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.cboArcade = New System.Windows.Forms.ComboBox
    Me.txtCoreNumber = New System.Windows.Forms.TextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.btnClearList = New System.Windows.Forms.Button
    Me.btnLoadOpenWorldList = New System.Windows.Forms.Button
    Me.btnLoadOriginalList = New System.Windows.Forms.Button
    Me.dtgConsole = New System.Windows.Forms.DataGridView
    Me.btnRemoveConsole = New System.Windows.Forms.Button
    Me.btnAddConsole = New System.Windows.Forms.Button
    Me.txtConsoleName = New System.Windows.Forms.TextBox
    Me.Label10 = New System.Windows.Forms.Label
    Me.txtSearchFolder = New System.Windows.Forms.TextBox
    Me.Label9 = New System.Windows.Forms.Label
    Me.btnSave = New System.Windows.Forms.Button
    Me.Label8 = New System.Windows.Forms.Label
    Me.txtGameStickFolder = New System.Windows.Forms.TextBox
    Me.Label7 = New System.Windows.Forms.Label
    Me.grpMain = New System.Windows.Forms.GroupBox
    Me.btnFrmDeleteAllRoms = New System.Windows.Forms.Button
    Me.btnRunCommand = New System.Windows.Forms.Button
    Me.btnFrmAddRoms = New System.Windows.Forms.Button
    Me.btnConfig = New System.Windows.Forms.Button
    Me.btnStart = New System.Windows.Forms.Button
    Me.btnDonate = New System.Windows.Forms.Button
    Me.btnFrmEditRoms = New System.Windows.Forms.Button
    Me.btnDbFile = New System.Windows.Forms.Button
    Me.btnRomsFolder = New System.Windows.Forms.Button
    Me.btnCancel = New System.Windows.Forms.Button
    Me.grpAddRoms = New System.Windows.Forms.GroupBox
    Me.Label33 = New System.Windows.Forms.Label
    Me.Label32 = New System.Windows.Forms.Label
    Me.lstRomsSelected = New System.Windows.Forms.ListView
    Me.lstRomsAvailable = New System.Windows.Forms.ListView
    Me.btnRemoveAll = New System.Windows.Forms.Button
    Me.btnRemove = New System.Windows.Forms.Button
    Me.btnAdd = New System.Windows.Forms.Button
    Me.btnAddAll = New System.Windows.Forms.Button
    Me.btnFrmDeleteRoms = New System.Windows.Forms.Button
    Me.grpEditRoms.SuspendLayout()
    Me.grpSystemConfig.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.dtgConsole, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpMain.SuspendLayout()
    Me.grpAddRoms.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 107)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(102, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Select games.db file"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(6, 155)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(101, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Select ROMS folder"
    '
    'txtDirDb
    '
    Me.txtDirDb.Location = New System.Drawing.Point(6, 123)
    Me.txtDirDb.Name = "txtDirDb"
    Me.txtDirDb.ReadOnly = True
    Me.txtDirDb.Size = New System.Drawing.Size(369, 20)
    Me.txtDirDb.TabIndex = 5
    '
    'txtDirRoms
    '
    Me.txtDirRoms.Location = New System.Drawing.Point(6, 171)
    Me.txtDirRoms.Name = "txtDirRoms"
    Me.txtDirRoms.ReadOnly = True
    Me.txtDirRoms.Size = New System.Drawing.Size(369, 20)
    Me.txtDirRoms.TabIndex = 6
    '
    'pbAndamento
    '
    Me.pbAndamento.Location = New System.Drawing.Point(6, 213)
    Me.pbAndamento.Name = "pbAndamento"
    Me.pbAndamento.Size = New System.Drawing.Size(344, 23)
    Me.pbAndamento.Step = 1
    Me.pbAndamento.TabIndex = 8
    '
    'lblStatus
    '
    Me.lblStatus.AutoSize = True
    Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
    Me.lblStatus.Location = New System.Drawing.Point(171, 198)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(24, 13)
    Me.lblStatus.TabIndex = 9
    Me.lblStatus.Text = "0 %"
    '
    'bwAddRoms
    '
    Me.bwAddRoms.WorkerReportsProgress = True
    Me.bwAddRoms.WorkerSupportsCancellation = True
    '
    'lblRomAdd
    '
    Me.lblRomAdd.AutoSize = True
    Me.lblRomAdd.Location = New System.Drawing.Point(6, 244)
    Me.lblRomAdd.Name = "lblRomAdd"
    Me.lblRomAdd.Size = New System.Drawing.Size(112, 13)
    Me.lblRomAdd.TabIndex = 12
    Me.lblRomAdd.Text = "Caminho pasta ROMS"
    Me.lblRomAdd.Visible = False
    '
    'grpEditRoms
    '
    Me.grpEditRoms.Controls.Add(Me.Label30)
    Me.grpEditRoms.Controls.Add(Me.Label29)
    Me.grpEditRoms.Controls.Add(Me.txtAdicionarPalavra)
    Me.grpEditRoms.Controls.Add(Me.Label6)
    Me.grpEditRoms.Controls.Add(Me.txtRemoverPalavra)
    Me.grpEditRoms.Controls.Add(Me.Label5)
    Me.grpEditRoms.Controls.Add(Me.txtNovaExtensao)
    Me.grpEditRoms.Controls.Add(Me.Label4)
    Me.grpEditRoms.Controls.Add(Me.txtExtensaoOriginal)
    Me.grpEditRoms.Controls.Add(Me.Label3)
    Me.grpEditRoms.Location = New System.Drawing.Point(381, 11)
    Me.grpEditRoms.Name = "grpEditRoms"
    Me.grpEditRoms.Size = New System.Drawing.Size(395, 227)
    Me.grpEditRoms.TabIndex = 15
    Me.grpEditRoms.TabStop = False
    Me.grpEditRoms.Text = "Edit Roms files"
    Me.grpEditRoms.Visible = False
    '
    'Label30
    '
    Me.Label30.AutoSize = True
    Me.Label30.Location = New System.Drawing.Point(247, 64)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(77, 13)
    Me.Label30.TabIndex = 9
    Me.Label30.Text = "Ex. .md --> .bin"
    '
    'Label29
    '
    Me.Label29.AutoSize = True
    Me.Label29.Location = New System.Drawing.Point(115, 65)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(19, 13)
    Me.Label29.TabIndex = 8
    Me.Label29.Text = "-->"
    '
    'txtAdicionarPalavra
    '
    Me.txtAdicionarPalavra.Location = New System.Drawing.Point(10, 112)
    Me.txtAdicionarPalavra.Name = "txtAdicionarPalavra"
    Me.txtAdicionarPalavra.Size = New System.Drawing.Size(376, 20)
    Me.txtAdicionarPalavra.TabIndex = 7
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(10, 96)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(90, 13)
    Me.Label6.TabIndex = 6
    Me.Label6.Text = "Add String to End"
    '
    'txtRemoverPalavra
    '
    Me.txtRemoverPalavra.Location = New System.Drawing.Point(10, 160)
    Me.txtRemoverPalavra.Name = "txtRemoverPalavra"
    Me.txtRemoverPalavra.Size = New System.Drawing.Size(376, 20)
    Me.txtRemoverPalavra.TabIndex = 5
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(10, 144)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(77, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Remove String"
    '
    'txtNovaExtensao
    '
    Me.txtNovaExtensao.Location = New System.Drawing.Point(137, 61)
    Me.txtNovaExtensao.Name = "txtNovaExtensao"
    Me.txtNovaExtensao.Size = New System.Drawing.Size(99, 20)
    Me.txtNovaExtensao.TabIndex = 3
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(137, 45)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(78, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "New Extension"
    '
    'txtExtensaoOriginal
    '
    Me.txtExtensaoOriginal.Location = New System.Drawing.Point(10, 61)
    Me.txtExtensaoOriginal.Name = "txtExtensaoOriginal"
    Me.txtExtensaoOriginal.Size = New System.Drawing.Size(99, 20)
    Me.txtExtensaoOriginal.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(10, 45)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(91, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Original Extension"
    '
    'grpSystemConfig
    '
    Me.grpSystemConfig.Controls.Add(Me.Label13)
    Me.grpSystemConfig.Controls.Add(Me.cboScummVM)
    Me.grpSystemConfig.Controls.Add(Me.Label12)
    Me.grpSystemConfig.Controls.Add(Me.cboDOS)
    Me.grpSystemConfig.Controls.Add(Me.Label11)
    Me.grpSystemConfig.Controls.Add(Me.cboArcade)
    Me.grpSystemConfig.Controls.Add(Me.txtCoreNumber)
    Me.grpSystemConfig.Controls.Add(Me.GroupBox1)
    Me.grpSystemConfig.Controls.Add(Me.btnRemoveConsole)
    Me.grpSystemConfig.Controls.Add(Me.btnAddConsole)
    Me.grpSystemConfig.Controls.Add(Me.txtConsoleName)
    Me.grpSystemConfig.Controls.Add(Me.Label10)
    Me.grpSystemConfig.Controls.Add(Me.txtSearchFolder)
    Me.grpSystemConfig.Controls.Add(Me.Label9)
    Me.grpSystemConfig.Controls.Add(Me.btnSave)
    Me.grpSystemConfig.Controls.Add(Me.Label8)
    Me.grpSystemConfig.Controls.Add(Me.txtGameStickFolder)
    Me.grpSystemConfig.Controls.Add(Me.Label7)
    Me.grpSystemConfig.Location = New System.Drawing.Point(797, 3)
    Me.grpSystemConfig.Name = "grpSystemConfig"
    Me.grpSystemConfig.Size = New System.Drawing.Size(779, 276)
    Me.grpSystemConfig.TabIndex = 0
    Me.grpSystemConfig.TabStop = False
    Me.grpSystemConfig.Text = "System Config."
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(489, 23)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(61, 13)
    Me.Label13.TabIndex = 135
    Me.Label13.Text = "Scumm VM"
    '
    'cboScummVM
    '
    Me.cboScummVM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboScummVM.FormattingEnabled = True
    Me.cboScummVM.Items.AddRange(New Object() {"YES", "NO"})
    Me.cboScummVM.Location = New System.Drawing.Point(487, 38)
    Me.cboScummVM.Name = "cboScummVM"
    Me.cboScummVM.Size = New System.Drawing.Size(63, 21)
    Me.cboScummVM.TabIndex = 134
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(447, 23)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(30, 13)
    Me.Label12.TabIndex = 133
    Me.Label12.Text = "DOS"
    '
    'cboDOS
    '
    Me.cboDOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDOS.FormattingEnabled = True
    Me.cboDOS.Items.AddRange(New Object() {"YES", "NO"})
    Me.cboDOS.Location = New System.Drawing.Point(439, 38)
    Me.cboDOS.Name = "cboDOS"
    Me.cboDOS.Size = New System.Drawing.Size(45, 21)
    Me.cboDOS.TabIndex = 132
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(393, 23)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(41, 13)
    Me.Label11.TabIndex = 131
    Me.Label11.Text = "Arcade"
    '
    'cboArcade
    '
    Me.cboArcade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboArcade.FormattingEnabled = True
    Me.cboArcade.Items.AddRange(New Object() {"YES", "NO"})
    Me.cboArcade.Location = New System.Drawing.Point(391, 38)
    Me.cboArcade.Name = "cboArcade"
    Me.cboArcade.Size = New System.Drawing.Size(45, 21)
    Me.cboArcade.TabIndex = 4
    '
    'txtCoreNumber
    '
    Me.txtCoreNumber.Location = New System.Drawing.Point(322, 38)
    Me.txtCoreNumber.Name = "txtCoreNumber"
    Me.txtCoreNumber.Size = New System.Drawing.Size(66, 20)
    Me.txtCoreNumber.TabIndex = 3
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.btnClearList)
    Me.GroupBox1.Controls.Add(Me.btnLoadOpenWorldList)
    Me.GroupBox1.Controls.Add(Me.btnLoadOriginalList)
    Me.GroupBox1.Controls.Add(Me.dtgConsole)
    Me.GroupBox1.Location = New System.Drawing.Point(9, 68)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(761, 202)
    Me.GroupBox1.TabIndex = 8
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Console List"
    '
    'btnClearList
    '
    Me.btnClearList.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnLimpar
    Me.btnClearList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnClearList.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.btnClearList.Location = New System.Drawing.Point(206, 173)
    Me.btnClearList.Name = "btnClearList"
    Me.btnClearList.Size = New System.Drawing.Size(83, 25)
    Me.btnClearList.TabIndex = 130
    Me.btnClearList.Text = "Clear List"
    Me.btnClearList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnClearList.UseVisualStyleBackColor = True
    '
    'btnLoadOpenWorldList
    '
    Me.btnLoadOpenWorldList.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnToolBarMinimizar
    Me.btnLoadOpenWorldList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnLoadOpenWorldList.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.btnLoadOpenWorldList.Location = New System.Drawing.Point(418, 173)
    Me.btnLoadOpenWorldList.Name = "btnLoadOpenWorldList"
    Me.btnLoadOpenWorldList.Size = New System.Drawing.Size(137, 25)
    Me.btnLoadOpenWorldList.TabIndex = 129
    Me.btnLoadOpenWorldList.Text = "Load Open World List"
    Me.btnLoadOpenWorldList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnLoadOpenWorldList.UseVisualStyleBackColor = True
    '
    'btnLoadOriginalList
    '
    Me.btnLoadOriginalList.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnToolBarMinimizar
    Me.btnLoadOriginalList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnLoadOriginalList.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.btnLoadOriginalList.Location = New System.Drawing.Point(295, 173)
    Me.btnLoadOriginalList.Name = "btnLoadOriginalList"
    Me.btnLoadOriginalList.Size = New System.Drawing.Size(117, 25)
    Me.btnLoadOriginalList.TabIndex = 128
    Me.btnLoadOriginalList.Text = "Load Original List"
    Me.btnLoadOriginalList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnLoadOriginalList.UseVisualStyleBackColor = True
    '
    'dtgConsole
    '
    Me.dtgConsole.AllowUserToAddRows = False
    Me.dtgConsole.AllowUserToDeleteRows = False
    Me.dtgConsole.AllowUserToResizeRows = False
    Me.dtgConsole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dtgConsole.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
    Me.dtgConsole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dtgConsole.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dtgConsole.ColumnHeadersHeight = 21
    Me.dtgConsole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dtgConsole.DefaultCellStyle = DataGridViewCellStyle2
    Me.dtgConsole.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dtgConsole.Location = New System.Drawing.Point(6, 20)
    Me.dtgConsole.MultiSelect = False
    Me.dtgConsole.Name = "dtgConsole"
    Me.dtgConsole.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dtgConsole.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dtgConsole.RowHeadersVisible = False
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtgConsole.RowsDefaultCellStyle = DataGridViewCellStyle4
    Me.dtgConsole.RowTemplate.Height = 21
    Me.dtgConsole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dtgConsole.Size = New System.Drawing.Size(749, 149)
    Me.dtgConsole.TabIndex = 127
    Me.dtgConsole.TabStop = False
    '
    'btnRemoveConsole
    '
    Me.btnRemoveConsole.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnCancelar
    Me.btnRemoveConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRemoveConsole.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.btnRemoveConsole.Location = New System.Drawing.Point(621, 35)
    Me.btnRemoveConsole.Name = "btnRemoveConsole"
    Me.btnRemoveConsole.Size = New System.Drawing.Size(78, 25)
    Me.btnRemoveConsole.TabIndex = 6
    Me.btnRemoveConsole.Text = "Remove"
    Me.btnRemoveConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRemoveConsole.UseVisualStyleBackColor = True
    '
    'btnAddConsole
    '
    Me.btnAddConsole.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnConfirmar
    Me.btnAddConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAddConsole.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.btnAddConsole.Location = New System.Drawing.Point(555, 35)
    Me.btnAddConsole.Name = "btnAddConsole"
    Me.btnAddConsole.Size = New System.Drawing.Size(60, 25)
    Me.btnAddConsole.TabIndex = 5
    Me.btnAddConsole.Text = "Add"
    Me.btnAddConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAddConsole.UseVisualStyleBackColor = True
    '
    'txtConsoleName
    '
    Me.txtConsoleName.Location = New System.Drawing.Point(15, 38)
    Me.txtConsoleName.Name = "txtConsoleName"
    Me.txtConsoleName.Size = New System.Drawing.Size(73, 20)
    Me.txtConsoleName.TabIndex = 0
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(13, 22)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(76, 13)
    Me.Label10.TabIndex = 124
    Me.Label10.Text = "Console Name"
    '
    'txtSearchFolder
    '
    Me.txtSearchFolder.Location = New System.Drawing.Point(91, 38)
    Me.txtSearchFolder.Name = "txtSearchFolder"
    Me.txtSearchFolder.Size = New System.Drawing.Size(114, 20)
    Me.txtSearchFolder.TabIndex = 1
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(91, 22)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(115, 13)
    Me.Label9.TabIndex = 122
    Me.Label9.Text = "Folder to Search Roms"
    '
    'btnSave
    '
    Me.btnSave.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnToolBarSalvar
    Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSave.Location = New System.Drawing.Point(704, 35)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(60, 25)
    Me.btnSave.TabIndex = 7
    Me.btnSave.Text = "Save"
    Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(320, 23)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(69, 13)
    Me.Label8.TabIndex = 28
    Me.Label8.Text = "Core Number"
    '
    'txtGameStickFolder
    '
    Me.txtGameStickFolder.Location = New System.Drawing.Point(208, 38)
    Me.txtGameStickFolder.Name = "txtGameStickFolder"
    Me.txtGameStickFolder.Size = New System.Drawing.Size(111, 20)
    Me.txtGameStickFolder.TabIndex = 2
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(208, 22)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(111, 13)
    Me.Label7.TabIndex = 25
    Me.Label7.Text = "Folder into GameStick"
    '
    'grpMain
    '
    Me.grpMain.Controls.Add(Me.btnFrmDeleteRoms)
    Me.grpMain.Controls.Add(Me.btnFrmDeleteAllRoms)
    Me.grpMain.Controls.Add(Me.btnRunCommand)
    Me.grpMain.Controls.Add(Me.btnFrmAddRoms)
    Me.grpMain.Controls.Add(Me.btnConfig)
    Me.grpMain.Controls.Add(Me.btnStart)
    Me.grpMain.Controls.Add(Me.Label1)
    Me.grpMain.Controls.Add(Me.Label2)
    Me.grpMain.Controls.Add(Me.btnDonate)
    Me.grpMain.Controls.Add(Me.btnFrmEditRoms)
    Me.grpMain.Controls.Add(Me.txtDirDb)
    Me.grpMain.Controls.Add(Me.txtDirRoms)
    Me.grpMain.Controls.Add(Me.pbAndamento)
    Me.grpMain.Controls.Add(Me.lblRomAdd)
    Me.grpMain.Controls.Add(Me.lblStatus)
    Me.grpMain.Controls.Add(Me.btnDbFile)
    Me.grpMain.Controls.Add(Me.btnRomsFolder)
    Me.grpMain.Controls.Add(Me.btnCancel)
    Me.grpMain.Controls.Add(Me.grpAddRoms)
    Me.grpMain.Controls.Add(Me.grpEditRoms)
    Me.grpMain.Location = New System.Drawing.Point(12, 3)
    Me.grpMain.Name = "grpMain"
    Me.grpMain.Size = New System.Drawing.Size(779, 276)
    Me.grpMain.TabIndex = 26
    Me.grpMain.TabStop = False
    '
    'btnFrmDeleteAllRoms
    '
    Me.btnFrmDeleteAllRoms.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnToolBarExcluir
    Me.btnFrmDeleteAllRoms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnFrmDeleteAllRoms.Location = New System.Drawing.Point(188, 52)
    Me.btnFrmDeleteAllRoms.Name = "btnFrmDeleteAllRoms"
    Me.btnFrmDeleteAllRoms.Size = New System.Drawing.Size(111, 36)
    Me.btnFrmDeleteAllRoms.TabIndex = 26
    Me.btnFrmDeleteAllRoms.Text = "Delete All Roms"
    Me.btnFrmDeleteAllRoms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnFrmDeleteAllRoms.UseVisualStyleBackColor = True
    '
    'btnRunCommand
    '
    Me.btnRunCommand.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnSQL
    Me.btnRunCommand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRunCommand.Location = New System.Drawing.Point(188, 10)
    Me.btnRunCommand.Name = "btnRunCommand"
    Me.btnRunCommand.Size = New System.Drawing.Size(111, 36)
    Me.btnRunCommand.TabIndex = 25
    Me.btnRunCommand.Text = "Run Command"
    Me.btnRunCommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRunCommand.UseVisualStyleBackColor = True
    '
    'btnFrmAddRoms
    '
    Me.btnFrmAddRoms.Enabled = False
    Me.btnFrmAddRoms.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnIncluir
    Me.btnFrmAddRoms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnFrmAddRoms.Location = New System.Drawing.Point(6, 11)
    Me.btnFrmAddRoms.Name = "btnFrmAddRoms"
    Me.btnFrmAddRoms.Size = New System.Drawing.Size(83, 36)
    Me.btnFrmAddRoms.TabIndex = 13
    Me.btnFrmAddRoms.Text = "Add Roms"
    Me.btnFrmAddRoms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnFrmAddRoms.UseVisualStyleBackColor = True
    '
    'btnConfig
    '
    Me.btnConfig.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnDistribuir
    Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnConfig.Location = New System.Drawing.Point(95, 11)
    Me.btnConfig.Name = "btnConfig"
    Me.btnConfig.Size = New System.Drawing.Size(87, 36)
    Me.btnConfig.TabIndex = 23
    Me.btnConfig.Text = "Sys Config"
    Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnConfig.UseVisualStyleBackColor = True
    '
    'btnStart
    '
    Me.btnStart.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnIncluir
    Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnStart.Location = New System.Drawing.Point(350, 212)
    Me.btnStart.Name = "btnStart"
    Me.btnStart.Size = New System.Drawing.Size(25, 25)
    Me.btnStart.TabIndex = 5
    Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnStart.UseVisualStyleBackColor = True
    '
    'btnDonate
    '
    Me.btnDonate.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnDonate
    Me.btnDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnDonate.Location = New System.Drawing.Point(701, 244)
    Me.btnDonate.Name = "btnDonate"
    Me.btnDonate.Size = New System.Drawing.Size(69, 23)
    Me.btnDonate.TabIndex = 17
    Me.btnDonate.Text = "Donate"
    Me.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnDonate.UseVisualStyleBackColor = True
    '
    'btnFrmEditRoms
    '
    Me.btnFrmEditRoms.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnEditar
    Me.btnFrmEditRoms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnFrmEditRoms.Location = New System.Drawing.Point(6, 53)
    Me.btnFrmEditRoms.Name = "btnFrmEditRoms"
    Me.btnFrmEditRoms.Size = New System.Drawing.Size(83, 36)
    Me.btnFrmEditRoms.TabIndex = 14
    Me.btnFrmEditRoms.Text = "Edit Roms"
    Me.btnFrmEditRoms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnFrmEditRoms.UseVisualStyleBackColor = True
    '
    'btnDbFile
    '
    Me.btnDbFile.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnConsultar
    Me.btnDbFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnDbFile.Location = New System.Drawing.Point(115, 100)
    Me.btnDbFile.Name = "btnDbFile"
    Me.btnDbFile.Size = New System.Drawing.Size(25, 25)
    Me.btnDbFile.TabIndex = 1
    Me.btnDbFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnDbFile.UseVisualStyleBackColor = True
    '
    'btnRomsFolder
    '
    Me.btnRomsFolder.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnConsultar
    Me.btnRomsFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRomsFolder.Location = New System.Drawing.Point(115, 148)
    Me.btnRomsFolder.Name = "btnRomsFolder"
    Me.btnRomsFolder.Size = New System.Drawing.Size(25, 25)
    Me.btnRomsFolder.TabIndex = 3
    Me.btnRomsFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRomsFolder.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnToolBarCancelar
    Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancel.Location = New System.Drawing.Point(350, 212)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(25, 25)
    Me.btnCancel.TabIndex = 4
    Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancel.UseVisualStyleBackColor = True
    Me.btnCancel.Visible = False
    '
    'grpAddRoms
    '
    Me.grpAddRoms.Controls.Add(Me.Label33)
    Me.grpAddRoms.Controls.Add(Me.Label32)
    Me.grpAddRoms.Controls.Add(Me.lstRomsSelected)
    Me.grpAddRoms.Controls.Add(Me.lstRomsAvailable)
    Me.grpAddRoms.Controls.Add(Me.btnRemoveAll)
    Me.grpAddRoms.Controls.Add(Me.btnRemove)
    Me.grpAddRoms.Controls.Add(Me.btnAdd)
    Me.grpAddRoms.Controls.Add(Me.btnAddAll)
    Me.grpAddRoms.Location = New System.Drawing.Point(381, 11)
    Me.grpAddRoms.Name = "grpAddRoms"
    Me.grpAddRoms.Size = New System.Drawing.Size(395, 227)
    Me.grpAddRoms.TabIndex = 1
    Me.grpAddRoms.TabStop = False
    Me.grpAddRoms.Text = "Select to insert into games.db"
    '
    'Label33
    '
    Me.Label33.AutoSize = True
    Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label33.Location = New System.Drawing.Point(222, 25)
    Me.Label33.Name = "Label33"
    Me.Label33.Size = New System.Drawing.Size(57, 13)
    Me.Label33.TabIndex = 17
    Me.Label33.Text = "Selected"
    '
    'Label32
    '
    Me.Label32.AutoSize = True
    Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label32.Location = New System.Drawing.Point(10, 25)
    Me.Label32.Name = "Label32"
    Me.Label32.Size = New System.Drawing.Size(59, 13)
    Me.Label32.TabIndex = 16
    Me.Label32.Text = "Available"
    '
    'lstRomsSelected
    '
    Me.lstRomsSelected.Location = New System.Drawing.Point(220, 39)
    Me.lstRomsSelected.MultiSelect = False
    Me.lstRomsSelected.Name = "lstRomsSelected"
    Me.lstRomsSelected.Size = New System.Drawing.Size(169, 177)
    Me.lstRomsSelected.TabIndex = 15
    Me.lstRomsSelected.UseCompatibleStateImageBehavior = False
    Me.lstRomsSelected.View = System.Windows.Forms.View.List
    '
    'lstRomsAvailable
    '
    Me.lstRomsAvailable.Location = New System.Drawing.Point(10, 39)
    Me.lstRomsAvailable.MultiSelect = False
    Me.lstRomsAvailable.Name = "lstRomsAvailable"
    Me.lstRomsAvailable.Size = New System.Drawing.Size(169, 177)
    Me.lstRomsAvailable.TabIndex = 14
    Me.lstRomsAvailable.UseCompatibleStateImageBehavior = False
    Me.lstRomsAvailable.View = System.Windows.Forms.View.List
    '
    'btnRemoveAll
    '
    Me.btnRemoveAll.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnRemTodos
    Me.btnRemoveAll.Location = New System.Drawing.Point(188, 154)
    Me.btnRemoveAll.Name = "btnRemoveAll"
    Me.btnRemoveAll.Size = New System.Drawing.Size(25, 25)
    Me.btnRemoveAll.TabIndex = 13
    Me.btnRemoveAll.UseVisualStyleBackColor = True
    '
    'btnRemove
    '
    Me.btnRemove.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnRemSelecionar
    Me.btnRemove.Location = New System.Drawing.Point(188, 126)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(25, 25)
    Me.btnRemove.TabIndex = 12
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'btnAdd
    '
    Me.btnAdd.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnAddSelecionado
    Me.btnAdd.Location = New System.Drawing.Point(188, 98)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(25, 25)
    Me.btnAdd.TabIndex = 11
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'btnAddAll
    '
    Me.btnAddAll.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnAddTodos
    Me.btnAddAll.Location = New System.Drawing.Point(188, 70)
    Me.btnAddAll.Name = "btnAddAll"
    Me.btnAddAll.Size = New System.Drawing.Size(25, 25)
    Me.btnAddAll.TabIndex = 10
    Me.btnAddAll.UseVisualStyleBackColor = True
    '
    'btnFrmDeleteRoms
    '
    Me.btnFrmDeleteRoms.Image = Global.GameStickAddGames.My.Resources.Resources.imgBtnToolBarExcluir
    Me.btnFrmDeleteRoms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnFrmDeleteRoms.Location = New System.Drawing.Point(95, 53)
    Me.btnFrmDeleteRoms.Name = "btnFrmDeleteRoms"
    Me.btnFrmDeleteRoms.Size = New System.Drawing.Size(87, 36)
    Me.btnFrmDeleteRoms.TabIndex = 27
    Me.btnFrmDeleteRoms.Text = "Delete Rom"
    Me.btnFrmDeleteRoms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnFrmDeleteRoms.UseVisualStyleBackColor = True
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1582, 286)
    Me.Controls.Add(Me.grpSystemConfig)
    Me.Controls.Add(Me.grpMain)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmMain"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " ..:: Game Stick 4k Lite  (Open World) - Config ::.. "
    Me.grpEditRoms.ResumeLayout(False)
    Me.grpEditRoms.PerformLayout()
    Me.grpSystemConfig.ResumeLayout(False)
    Me.grpSystemConfig.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    CType(Me.dtgConsole, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpMain.ResumeLayout(False)
    Me.grpMain.PerformLayout()
    Me.grpAddRoms.ResumeLayout(False)
    Me.grpAddRoms.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnRomsFolder As System.Windows.Forms.Button
  Friend WithEvents btnStart As System.Windows.Forms.Button
  Friend WithEvents txtDirDb As System.Windows.Forms.TextBox
  Friend WithEvents txtDirRoms As System.Windows.Forms.TextBox
  Friend WithEvents btnDbFile As System.Windows.Forms.Button
  Friend WithEvents fbdRoms As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents sfdDB As System.Windows.Forms.SaveFileDialog
  Friend WithEvents pbAndamento As System.Windows.Forms.ProgressBar
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents bwAddRoms As System.ComponentModel.BackgroundWorker
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents lblRomAdd As System.Windows.Forms.Label
  Friend WithEvents btnFrmAddRoms As System.Windows.Forms.Button
  Friend WithEvents btnFrmEditRoms As System.Windows.Forms.Button
  Friend WithEvents grpEditRoms As System.Windows.Forms.GroupBox
  Friend WithEvents txtExtensaoOriginal As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtNovaExtensao As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtAdicionarPalavra As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtRemoverPalavra As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents btnDonate As System.Windows.Forms.Button
  Friend WithEvents grpSystemConfig As System.Windows.Forms.GroupBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtGameStickFolder As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents btnSave As System.Windows.Forms.Button
  Friend WithEvents btnConfig As System.Windows.Forms.Button
  Friend WithEvents btnRunCommand As System.Windows.Forms.Button
  Friend WithEvents grpMain As System.Windows.Forms.GroupBox
  Friend WithEvents grpAddRoms As System.Windows.Forms.GroupBox
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents Label30 As System.Windows.Forms.Label
  Friend WithEvents btnFrmDeleteAllRoms As System.Windows.Forms.Button
  Friend WithEvents Label33 As System.Windows.Forms.Label
  Friend WithEvents Label32 As System.Windows.Forms.Label
  Friend WithEvents lstRomsSelected As System.Windows.Forms.ListView
  Friend WithEvents lstRomsAvailable As System.Windows.Forms.ListView
  Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
  Friend WithEvents btnRemove As System.Windows.Forms.Button
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents btnAddAll As System.Windows.Forms.Button
  Friend WithEvents txtSearchFolder As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents btnRemoveConsole As System.Windows.Forms.Button
  Friend WithEvents btnAddConsole As System.Windows.Forms.Button
  Friend WithEvents txtConsoleName As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents dtgConsole As System.Windows.Forms.DataGridView
  Friend WithEvents txtCoreNumber As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents cboArcade As System.Windows.Forms.ComboBox
  Friend WithEvents btnLoadOpenWorldList As System.Windows.Forms.Button
  Friend WithEvents btnLoadOriginalList As System.Windows.Forms.Button
  Friend WithEvents btnClearList As System.Windows.Forms.Button
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents cboScummVM As System.Windows.Forms.ComboBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents cboDOS As System.Windows.Forms.ComboBox
  Friend WithEvents btnFrmDeleteRoms As System.Windows.Forms.Button

End Class
