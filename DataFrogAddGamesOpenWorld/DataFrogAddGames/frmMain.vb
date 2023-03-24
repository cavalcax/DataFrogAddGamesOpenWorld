Imports System.IO

Public Class frmMain

  Private intQtdRom As Integer = 0
  Private strSQL As String = String.Empty
  Private vetSelectedConsole(,) As String

  Delegate Sub setLabelTextDelegate(ByVal [label] As Label, ByVal [text] As String)

  Public Enum enumColGrid As Short
    ConsoleName = 0
    SearchFolder = 1
    GameStickFolder = 2
    CoreNumber = 3
    Arcade = 4
    Dos = 5
    ScummVM = 6
  End Enum

  Public Enum enumVetSelectedConsole As Short
    SearchFolder = 0
    GameStickFolder = 1
    CoreNumber = 2
    Arcade = 3
    Dos = 4
    ScummVM = 5
  End Enum

  Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Size = New Size(806, 315)
    Me.Location = New Point(Me.Location.X + 391, Me.Location.Y)

    grpSystemConfig.Location = New Point(12, 3)

    cboArcade.SelectedIndex = 1
    cboDOS.SelectedIndex = 1
    cboScummVM.SelectedIndex = 1
    formatGrid()
    formatList()
   
    ReadIniFile(String.Empty)
  End Sub

  Private Sub txtGotFocus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConsoleName.GotFocus, txtSearchFolder.GotFocus, txtGameStickFolder.GotFocus, txtCoreNumber.GotFocus, txtAdicionarPalavra.GotFocus, txtRemoverPalavra.GotFocus, txtExtensaoOriginal.GotFocus, txtNovaExtensao.GotFocus
    sender.SelectAll()
  End Sub

  Private Sub txtCoreNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCoreNumber.KeyPress
    If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
      e.Handled = True
    End If
  End Sub

  Private Sub btnDbFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbFile.Click
    Try
      Dim saveDialog = New SaveFileDialog
      saveDialog.RestoreDirectory = True
      saveDialog.InitialDirectory = Application.StartupPath
      If saveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        txtDirDb.Text = saveDialog.FileName
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message.ToString, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnRomsFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRomsFolder.Click
    Try
      Dim folderDialog = New FolderBrowserDialog
      folderDialog.SelectedPath = Application.StartupPath
      If folderDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        txtDirRoms.Text = folderDialog.SelectedPath
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message.ToString, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
    intQtdRom = 0

    Dim strSearchFolder, strConsoleName As String

    If btnFrmEditRoms.Enabled Then
      If txtDirDb.Text = String.Empty Then
        MessageBox.Show("File games.db not selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If
    End If

    If txtDirRoms.Text = String.Empty Then
      MessageBox.Show("ROMS folder not selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If

    If btnFrmEditRoms.Enabled Then
      If lstRomsSelected.Items.Count = 0 Then
        MessageBox.Show("No console selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      ReDim vetSelectedConsole(lstRomsSelected.Items.Count - 1, 6)

      For i As Integer = 0 To lstRomsSelected.Items.Count - 1

        strConsoleName = lstRomsSelected.Items(i).Text

        For j As Integer = 0 To dtgConsole.Rows.Count - 1
          If dtgConsole.Rows(j).Cells(enumColGrid.ConsoleName).Value.ToString = strConsoleName Then

            If dtgConsole.Rows(j).Cells(enumColGrid.Arcade).Value.ToString = "YES" Then
              If Not File.Exists(Application.StartupPath & "\arcade.txt") Then
                MessageBox.Show("arcade.txt file don't exists!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
              End If
            End If

            strSearchFolder = dtgConsole.Rows(j).Cells(enumColGrid.SearchFolder).Value.ToString
            If Directory.Exists(txtDirRoms.Text & "\" & strSearchFolder) Then

              If dtgConsole.Rows(j).Cells(enumColGrid.Dos).Value.ToString = "YES" Or dtgConsole.Rows(j).Cells(enumColGrid.ScummVM).Value.ToString = "YES" Then
                intQtdRom = intQtdRom + Directory.GetDirectories(txtDirRoms.Text & "\" & strSearchFolder).Length
              Else
                intQtdRom = intQtdRom + Directory.GetFiles(txtDirRoms.Text & "\" & strSearchFolder).Length
              End If

              vetSelectedConsole(i, enumVetSelectedConsole.SearchFolder) = strSearchFolder
              vetSelectedConsole(i, enumVetSelectedConsole.GameStickFolder) = dtgConsole.Rows(j).Cells(enumColGrid.GameStickFolder).Value.ToString
              vetSelectedConsole(i, enumVetSelectedConsole.CoreNumber) = dtgConsole.Rows(j).Cells(enumColGrid.CoreNumber).Value.ToString
              vetSelectedConsole(i, enumVetSelectedConsole.Arcade) = dtgConsole.Rows(j).Cells(enumColGrid.Arcade).Value.ToString
              vetSelectedConsole(i, enumVetSelectedConsole.Dos) = dtgConsole.Rows(j).Cells(enumColGrid.Dos).Value.ToString
              vetSelectedConsole(i, enumVetSelectedConsole.ScummVM) = dtgConsole.Rows(j).Cells(enumColGrid.ScummVM).Value.ToString
            Else
              MessageBox.Show(strSearchFolder & " folder don't exists!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
              Exit Sub
            End If
          End If
        Next
      Next
    Else
      If txtExtensaoOriginal.Text <> String.Empty And txtNovaExtensao.Text = String.Empty Then
        MessageBox.Show("New extension don't informed!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      If txtExtensaoOriginal.Text = String.Empty And txtNovaExtensao.Text <> String.Empty Then
        MessageBox.Show("Original extension don't informed!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      If txtExtensaoOriginal.Text = String.Empty And txtNovaExtensao.Text = String.Empty And txtRemoverPalavra.Text = String.Empty And txtAdicionarPalavra.Text = String.Empty Then
        MessageBox.Show("Nothing to do!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      intQtdRom = intQtdRom + Directory.GetFiles(txtDirRoms.Text).Length
    End If

    pbAndamento.Value = 0
    pbAndamento.Step = 1
    lblStatus.Text = "0 %"
    lblRomAdd.Text = String.Empty

    btnConfig.Enabled = False

    btnDbFile.Enabled = False
    btnRomsFolder.Enabled = False
    grpAddRoms.Enabled = False
    grpEditRoms.Enabled = False
    btnFrmAddRoms.Enabled = False
    btnFrmEditRoms.Enabled = False
    btnFrmDeleteAllRoms.Enabled = False
    btnRunCommand.Enabled = False
    btnStart.Visible = False
    btnCancel.Visible = True
    lblRomAdd.Visible = True

    bwAddRoms.RunWorkerAsync()
  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    If bwAddRoms.IsBusy Then
      If bwAddRoms.WorkerSupportsCancellation Then
        bwAddRoms.CancelAsync()
      End If
    End If
  End Sub

  Private Sub btnRunCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunCommand.Click
    If txtDirDb.Text = String.Empty Then
      MessageBox.Show("File games.db not selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If

    Dim strCommand As String = InputBox("Write a SQL Command", "Run Command", strSQL)

    If String.ReferenceEquals(strCommand, String.Empty) Then
      strSQL = String.Empty
    Else
      If strCommand = String.Empty Then
        btnRunCommand.PerformClick()
      End If

      Dim sConnectionString As String
      Try

        sConnectionString = "Data Source=" & txtDirDb.Text & ";Version=3;New=True;Compress=True;"

        'abre a conexão
        Dim oConn As New SQLite.SQLiteConnection(sConnectionString)
        oConn.Open()

        Using Comm As New System.Data.SQLite.SQLiteCommand(oConn)
          Comm.CommandText = strCommand
          Comm.ExecuteNonQuery()
        End Using

        oConn.Close()

        strSQL = String.Empty


        MessageBox.Show("Command run success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

      Catch ex As Exception
        MessageBox.Show(ex.Message.ToString, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        strSQL = strCommand
        btnRunCommand.PerformClick()
      End Try
    End If
  End Sub

  Private Sub btnFrmAddRoms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmAddRoms.Click
    grpAddRoms.Visible = True
    grpEditRoms.Visible = False
    btnFrmAddRoms.Enabled = False
    btnFrmEditRoms.Enabled = True

    Me.Text = " ..:: Game Stick 4k Lite (Open World) - Add Roms ::.. "
  End Sub

  Private Sub btnFrmEditRoms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmEditRoms.Click
    grpAddRoms.Visible = False
    grpEditRoms.Visible = True
    btnFrmAddRoms.Enabled = True
    btnFrmEditRoms.Enabled = False

    Me.Text = " ..:: Game Stick 4k Lite (Open World) - Edit Roms ::.. "
  End Sub

  Private Sub btnFrmDeleteAllRoms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmDeleteAllRoms.Click
    Dim sConnectionString As String
    Try

      If txtDirDb.Text = String.Empty Then
        MessageBox.Show("File games.db not selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      Me.Cursor = Cursors.WaitCursor

      sConnectionString = "Data Source=" & txtDirDb.Text & ";Version=3;New=True;Compress=True;"

      'abre a conexão
      Dim oConn As New SQLite.SQLiteConnection(sConnectionString)
      oConn.Open()

      '############################
      '###    DELETE ALL ROMS   ###
      '############################
      Using Comm As New System.Data.SQLite.SQLiteCommand(oConn)
        Comm.CommandText = "DELETE FROM tbl_en;" & _
                           "DELETE FROM tbl_ko;" & _
                           "DELETE FROM tbl_tw;" & _
                           "DELETE FROM tbl_zh;" & _
                           "DELETE FROM tbl_match;" & _
                           "DELETE FROM tbl_game;"
        Comm.ExecuteNonQuery()

      End Using

      oConn.Close()

      MessageBox.Show("All roms have been erased!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Catch ex As Exception
      MessageBox.Show(ex.Message.ToString, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub btnFrmDeleteRoms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmDeleteRoms.Click
    If txtDirDb.Text = String.Empty Then
      MessageBox.Show("File games.db not selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If

    Dim strCommand As String = InputBox("Write a position of a Game", "Delete Position", strSQL)

    If String.ReferenceEquals(strCommand, String.Empty) Then
      strSQL = String.Empty
    Else
      If strCommand = String.Empty Then
        btnRunCommand.PerformClick()
      End If

      Dim sConnectionString As String
      Try

        sConnectionString = "Data Source=" & txtDirDb.Text & ";Version=3;New=True;Compress=True;"

        'abre a conexão
        Dim oConn As New SQLite.SQLiteConnection(sConnectionString)
        oConn.Open()

        Using Comm As New System.Data.SQLite.SQLiteCommand(oConn)
          Comm.CommandText = "DELETE FROM tbl_en WHERE en_id IN (" & strCommand & ");" & _
                             "DELETE FROM tbl_ko WHERE ko_id IN (" & strCommand & ");" & _
                             "DELETE FROM tbl_tw WHERE en_id IN (" & strCommand & ");" & _
                             "DELETE FROM tbl_zh WHERE zh_id IN (" & strCommand & ");" & _
                             "DELETE FROM tbl_match WHERE ID IN (" & strCommand & ");" & _
                             "DELETE FROM tbl_game WHERE gameid IN (" & strCommand & ");"
          Comm.ExecuteNonQuery()
        End Using

        oConn.Close()

        strSQL = String.Empty

        MessageBox.Show("Game delete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

      Catch ex As Exception
        MessageBox.Show(ex.Message.ToString, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        strSQL = strCommand
        btnRunCommand.PerformClick()
      End Try
    End If
  End Sub

  Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
    grpSystemConfig.Visible = True
    Me.Text = " ..:: Game Stick 4k Lite (Open World) - Config ::.. "
  End Sub

  Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
    Try
      dtgConsole.Rows.Clear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnLoadOriginalList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOriginalList.Click
    Try
      dtgConsole.Rows.Clear()

      addRowGrid("FB Alpha 2012", "fbalpha", "cps", "0", "Y", "N", "N")
      addRowGrid("Nintendo", "fc", "fc", "1", "N", "N", "N")
      addRowGrid("Daphane", "daphane", "daphane", "2", "N", "N", "N")
      addRowGrid("FB Alpha 2012 OTHER", "fbalpha1", "cps", "3", "Y", "N", "N")
      addRowGrid("Mame 2003", "mame2003", "cps", "4", "Y", "N", "N")
      addRowGrid("Mega Drive", "md", "md", "5", "N", "N", "N")
      addRowGrid("Game Gear", "gamegear", "gamegear", "5", "N", "N", "N")
      addRowGrid("Super Nintendo", "sfc", "sfc", "6", "N", "N", "N")
      addRowGrid("Game Boy", "gb", "gb", "7", "N", "N", "N")
      addRowGrid("Game Boy Color", "gbc", "gbc", "7", "N", "N", "N")
      addRowGrid("Game Boy Advance", "gba", "gba", "7", "N", "N", "N")
      addRowGrid("Nintendo 64", "n64", "n64", "8", "N", "N", "N")
      addRowGrid("Playstation 1", "ps1", "ps1", "9", "N", "N", "N")
      addRowGrid("PC-Engine", "pcengine", "pcengine", "10", "N", "N", "N")
      addRowGrid("Wonderswan Color", "wsan", "wsan", "11", "N", "N", "N")
      addRowGrid("Nintendo DS", "nds", "nds", "12", "N", "N", "N")
      addRowGrid("Master System", "ms", "md", "13", "N", "N", "N")
      addRowGrid("Sega 32x", "sega32x", "md", "13", "N", "N", "N")
      addRowGrid("FB Alpha", "fbalpha2", "cps", "14", "Y", "N", "N")
      addRowGrid("Atari 2600", "atari", "atari", "15", "N", "N", "N")
      addRowGrid("Atari 800", "atari", "atari", "16", "N", "N", "N")
      addRowGrid("Atari 7800", "atari", "atari", "17", "N", "N", "N")
      addRowGrid("Mame 2016", "mame2016", "cps", "18", "Y", "N", "N")

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnLoadOpenWorldList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOpenWorldList.Click
    Try
      dtgConsole.Rows.Clear()

      addRowGrid("FB Alpha 2012", "fbalpha", "cps", "0", "Y", "N", "N")
      addRowGrid("FB Alpha 2012 (1)", "fbalpha1", "cps", "3", "Y", "N", "N")
      addRowGrid("FB Alpha", "fbalpha2", "cps", "14", "Y", "N", "N")
      addRowGrid("FB Alpha Other", "fbalpha3", "cps", "20", "Y", "N", "N")
      addRowGrid("Nintendo (nestopia)", "fc", "fc", "1", "N", "N", "N")
      addRowGrid("Nintendo (fceumm)", "fc", "fc", "30", "N", "N", "N")
      addRowGrid("Daphane", "daphane", "daphane", "2", "N", "N", "N")
      addRowGrid("Mame 2003", "mame2003", "cps", "4", "Y", "N", "N")
      addRowGrid("Mega Drive", "md", "md", "5", "N", "N", "N")
      addRowGrid("Game Gear", "gamegear", "md", "5", "N", "N", "N")
      addRowGrid("Sega CD", "segacd", "md", "5", "N", "N", "N")
      addRowGrid("Super Nintendo", "sfc", "sfc", "6", "N", "N", "N")
      addRowGrid("Super Nintendo 2005", "sfc2005", "sfc", "44", "N", "N", "N")
      addRowGrid("Super Nintendo Racing", "sfcr", "sfc", "19", "N", "N", "N")
      addRowGrid("Super Nintendo Other", "sfc1", "sfc", "25", "N", "N", "N")
      addRowGrid("Game Boy", "gb", "gb", "7", "N", "N", "N")
      addRowGrid("Game Boy Color", "gbc", "gbc", "7", "N", "N", "N")
      addRowGrid("Game Boy Advance", "gba", "gba", "32", "N", "N", "N")
      addRowGrid("Nintendo 64", "n64", "n64", "8", "N", "N", "N")
      addRowGrid("Playstation 1", "ps1", "ps1", "9", "N", "N", "N")
      addRowGrid("Playstation 1 V5", "ps1", "ps1", "28", "N", "N", "N")
      addRowGrid("PC-Engine", "pcengine", "pcengine", "10", "N", "N", "N")
      addRowGrid("PC-Engine CD", "pcenginecd", "pcenginecd", "42", "N", "N", "N")
      addRowGrid("SuperGrafX", "supergrafx", "supergrafx", "42", "N", "N", "N")
      addRowGrid("Wonderswan Color", "wswan", "wswan", "11", "N", "N", "N")
      addRowGrid("Nintendo DS", "nds", "nds", "12", "N", "N", "N")
      addRowGrid("Master System", "ms", "md", "29", "N", "N", "N")
      addRowGrid("Sega 32x", "sega32x", "md", "29", "N", "N", "N")
      addRowGrid("Atari 2600", "atari", "atari", "15", "N", "N", "N")
      addRowGrid("Atari 800", "atari", "atari", "16", "N", "N", "N")
      addRowGrid("Atari 7800", "atari", "atari", "17", "N", "N", "N")
      addRowGrid("Atari 2600 Other", "atari", "atari", "21", "N", "N", "N")
      addRowGrid("Atari 800 Other", "atari", "atari", "22", "N", "N", "N")
      addRowGrid("Atari 7800 Other", "atari", "atari", "23", "N", "N", "N")
      addRowGrid("Mame 2016", "mame2016", "cps", "18", "Y", "N", "N")
      addRowGrid("Mame 2016 Other", "mame2016", "cps", "24", "Y", "N", "N")
      addRowGrid("Mame 2010", "mame2010", "cps", "26", "Y", "N", "N")
      addRowGrid("ZX Spectrum", "spec", "spec", "27", "N", "N", "N")
      addRowGrid("Sega Saturno", "saturn", "saturn", "31", "N", "N", "N")
      addRowGrid("Sega Dreamcast", "dreamcast", "dreamcast", "33", "N", "N", "N")
      addRowGrid("Scumm VM", "scummvm", "scummvm", "34", "N", "N", "S")
      addRowGrid("DOS", "dos", "dos", "35", "N", "S", "N")
      addRowGrid("FB Neo", "fbneo", "cps", "37", "Y", "N", "N")
      addRowGrid("3DO", "3do", "3do", "39", "N", "N", "N")
      addRowGrid("Game & Watch", "gw", "gw", "40", "N", "N", "N")
      addRowGrid("Neo Geo Pocket Color", "ngpc", "ngpc", "41", "N", "N", "N")
      addRowGrid("Odyssey 2", "o2em", "o2em", "43", "N", "N", "N")

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnAddConsole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddConsole.Click
    Try
      If txtConsoleName.Text = String.Empty Then
        txtConsoleName.Focus()
        MessageBox.Show("Console name not informed!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      If txtSearchFolder.Text = String.Empty Then
        txtSearchFolder.Focus()
        MessageBox.Show("Folder to search roms not informed!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      If txtGameStickFolder.Text = String.Empty Then
        txtGameStickFolder.Focus()
        MessageBox.Show("Folder into GameStick not informed!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      If txtCoreNumber.Text = String.Empty Then
        txtCoreNumber.Focus()
        MessageBox.Show("Core number not informed!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      addRowGrid(txtConsoleName.Text, txtSearchFolder.Text, txtGameStickFolder.Text, txtCoreNumber.Text, IIf(cboArcade.SelectedIndex = 0, "Y", "N"), IIf(cboDOS.SelectedIndex = 0, "Y", "N"), IIf(cboScummVM.SelectedIndex = 0, "Y", "N"))

      txtConsoleName.Clear()
      txtSearchFolder.Clear()
      txtGameStickFolder.Clear()
      txtCoreNumber.Clear()

      txtConsoleName.Focus()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnRemoveConsole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveConsole.Click
    Try
      If dtgConsole.Rows.Count > 0 Then
        dtgConsole.Rows.RemoveAt(dtgConsole.CurrentRow.Index)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    Dim clsIni As New clsArquivoIni
    Dim strSection, strAuxSort As String
    Dim lstSection As ArrayList
    Dim vetConsole(dtgConsole.Rows.Count - 1) As String
    Try
      Me.Cursor = Cursors.WaitCursor

      clsIni.FileName = AppDomain.CurrentDomain.BaseDirectory & "config.ini"

      lstRomsAvailable.Items.Clear()
      lstRomsSelected.Items.Clear()

      lstSection = clsIni.GetSectionNames()

      For i As Integer = 0 To lstSection.Count - 1
        clsIni.DeleteSection(lstSection(i))
      Next

      For i As Integer = 0 To dtgConsole.Rows.Count - 1
        strSection = "console" & i.ToString

        clsIni.Write(strSection, "ConsoleName", dtgConsole.Rows(i).Cells(enumColGrid.ConsoleName).Value.ToString)
        clsIni.Write(strSection, "SearchFolder", dtgConsole.Rows(i).Cells(enumColGrid.SearchFolder).Value.ToString)
        clsIni.Write(strSection, "GameStickFolder", dtgConsole.Rows(i).Cells(enumColGrid.GameStickFolder).Value.ToString)
        clsIni.Write(strSection, "CoreNumber", dtgConsole.Rows(i).Cells(enumColGrid.CoreNumber).Value.ToString)
        clsIni.Write(strSection, "Arcade", dtgConsole.Rows(i).Cells(enumColGrid.Arcade).Value.ToString.Substring(0, 1))
        clsIni.Write(strSection, "Dos", dtgConsole.Rows(i).Cells(enumColGrid.Dos).Value.ToString.Substring(0, 1))
        clsIni.Write(strSection, "ScummVM", dtgConsole.Rows(i).Cells(enumColGrid.ScummVM).Value.ToString.Substring(0, 1))

        vetConsole(i) = dtgConsole.Rows(i).Cells(enumColGrid.ConsoleName).Value.ToString
      Next

      If btnFrmAddRoms.Enabled Then
        Me.Text = " ..:: Game Stick 4k Lite (Open World) - Edit Roms ::.. "
      Else
        Me.Text = " ..:: Game Stick 4k Lite (Open World) - Add Roms ::.. "
      End If

      For iPass As Integer = 1 To vetConsole.Length - 1
        For i As Integer = 0 To vetConsole.Length - 2
          If vetConsole(i) > vetConsole(i + 1) Then
            strAuxSort = vetConsole(i)
            vetConsole(i) = vetConsole(i + 1)
            vetConsole(i + 1) = strAuxSort
          End If
        Next
      Next

      For i As Integer = 0 To vetConsole.Length - 1
        lstRomsAvailable.Items.Add(vetConsole(i))
      Next

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Finally
      clsIni.Dispose()

      grpSystemConfig.Visible = False

      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub btnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAll.Click
    Try
      For i As Integer = 0 To lstRomsAvailable.Items.Count - 1
        lstRomsSelected.Items.Add(lstRomsAvailable.Items(i).Text)
      Next

      lstRomsAvailable.Items.Clear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Try
      If (lstRomsAvailable.SelectedItems.Count > 0) Then
        lstRomsSelected.Items.Add(lstRomsAvailable.SelectedItems.Item(0).Text)
        lstRomsAvailable.Items.RemoveAt(lstRomsAvailable.SelectedItems.Item(0).Index)
      Else
        MessageBox.Show("No item selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    Try
      If (lstRomsSelected.SelectedItems.Count > 0) Then
        lstRomsAvailable.Items.Add(lstRomsSelected.SelectedItems.Item(0).Text)
        lstRomsSelected.Items.RemoveAt(lstRomsSelected.SelectedItems.Item(0).Index)
      Else
        MessageBox.Show("No item selected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
    Try
      For i As Integer = 0 To lstRomsSelected.Items.Count - 1
        lstRomsAvailable.Items.Add(lstRomsSelected.Items(i).Text)
      Next

      lstRomsSelected.Items.Clear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub btnDonate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDonate.Click
    frmDonate.Show()
  End Sub

  Private Sub bwAddRoms_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwAddRoms.DoWork
    Dim sConnectionString As String
    Dim id As Integer = 0
    Dim strExtension, strFileName, strFileNameMatch As String
    Dim intReg As Integer = 0
    Dim intCount As Integer = 0
    Dim intProgress As Integer = 0
    Dim intMaxName As Integer = 150
    Dim intMaxMatch As Integer = 75
    Try

      If grpAddRoms.Visible Then
        sConnectionString = "Data Source=" & txtDirDb.Text & ";Version=3;New=True;Compress=True;"

        'abre a conexão
        Dim oConn As New SQLite.SQLiteConnection(sConnectionString)
        oConn.Open()

        If intQtdRom > 0 Then
          intReg = (intQtdRom / 100) + 0.4999

          Using Comm As New System.Data.SQLite.SQLiteCommand(oConn)
            Comm.CommandText = "Select MAX(gameid) from tbl_game"
            Dim GameId = Comm.ExecuteScalar()
            If (GameId IsNot Nothing And GameId IsNot DBNull.Value) Then
              id = GameId + 1
            Else
              id = 1
            End If
          End Using

          For i As Integer = 0 To lstRomsSelected.Items.Count - 1

            Select Case True
              Case vetSelectedConsole(i, enumVetSelectedConsole.Arcade) = "YES"
                If File.Exists(Application.StartupPath & "\arcade.txt") Then
                  Dim srFluxoTexto As StreamReader
                  Dim strLinhaTexto As String
                  Dim strRegistro As String()

                  srFluxoTexto = New StreamReader(Application.StartupPath & "\arcade.txt")
                  strLinhaTexto = srFluxoTexto.ReadLine

                  While strLinhaTexto <> Nothing
                    strRegistro = strLinhaTexto.Split("|")

                    For Each romFile In Directory.GetFiles(txtDirRoms.Text & "\" & vetSelectedConsole(i, enumVetSelectedConsole.SearchFolder), "*.zip")
                      If bwAddRoms.CancellationPending Then
                        oConn.Close()
                        e.Cancel = True
                        Exit For
                      End If

                      strExtension = Path.GetExtension(romFile)
                      strFileName = Path.GetFileNameWithoutExtension(romFile)

                      If strFileName = strRegistro(1).Trim() Then
                        UpdateLabel(Me.lblRomAdd, vetSelectedConsole(i, enumVetSelectedConsole.SearchFolder) & "\" & strFileName)
                        strFileName = strRegistro(2).Trim().Replace("'", "''")

                        strFileNameMatch = GetSearchName(strRegistro(2).Trim())

                        If strFileName.Length > intMaxName Then
                          strFileName = strFileName.Substring(0, intMaxName)
                        End If

                        If strFileNameMatch.Length > intMaxMatch Then
                          strFileNameMatch = strFileNameMatch.Substring(0, intMaxMatch)
                        End If

                        Using Comm As New System.Data.SQLite.SQLiteCommand(oConn)
                          Comm.CommandText = "INSERT INTO tbl_game (gameid,game,suffix,zh_id,en_id,ko_id,video_id,class_type,game_type,hard,timer) VALUES (" & id & ",'" & strRegistro(1).Trim() & "','" & strExtension & "'," & id & "," & id & "," & id & ",NULL,0," & vetSelectedConsole(i, enumVetSelectedConsole.CoreNumber) & ",0,'/sdcard/game/" & vetSelectedConsole(i, enumVetSelectedConsole.GameStickFolder) & "');" & _
                                             "INSERT INTO tbl_en (en_id,en_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                             "INSERT INTO tbl_ko (ko_id,ko_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                             "INSERT INTO tbl_tw (en_id,en_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                             "INSERT INTO tbl_zh (zh_id,zh_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                             "INSERT INTO tbl_match (ID,zh_match) VALUES (" & id & ",'" & strFileNameMatch & "');"
                          Comm.ExecuteNonQuery()
                        End Using

                        id = id + 1

                        intCount = intCount + 1

                        If intCount = intReg Then
                          intCount = 0
                          intProgress = intProgress + 1
                          bwAddRoms.ReportProgress(intProgress)
                          UpdateLabel(Me.lblStatus, intProgress.ToString & " %")
                        End If

                        Exit For
                      End If
                    Next

                    strLinhaTexto = srFluxoTexto.ReadLine
                  End While
                End If
              Case vetSelectedConsole(i, enumVetSelectedConsole.Dos) = "YES" Or vetSelectedConsole(i, enumVetSelectedConsole.ScummVM) = "YES"
                Dim strAuxExtension As String

                For Each romDir In Directory.GetDirectories(txtDirRoms.Text & "\" & vetSelectedConsole(i, enumVetSelectedConsole.SearchFolder))
                  If bwAddRoms.CancellationPending Then
                    oConn.Close()
                    e.Cancel = True
                    Exit For
                  End If

                  For Each romFile In Directory.GetFiles(romDir)
                    If bwAddRoms.CancellationPending Then
                      oConn.Close()
                      e.Cancel = True
                      Exit For
                    End If

                    strExtension = Path.GetExtension(romFile)

                    If vetSelectedConsole(i, enumVetSelectedConsole.Dos) = "YES" Then
                      strAuxExtension = ".exe"
                    Else
                      strAuxExtension = ".scummvm"
                    End If

                    If strExtension.ToLower = strAuxExtension Then
                      strFileName = Path.GetFileNameWithoutExtension(romFile)
                      UpdateLabel(Me.lblRomAdd, vetSelectedConsole(i, enumVetSelectedConsole.SearchFolder) & "\" & strFileName)
                      strFileName = strFileName.Replace("'", "''")

                      strFileNameMatch = GetSearchName(strFileName)

                      If strFileName.Length > intMaxName Then
                        strFileName = strFileName.Substring(0, intMaxName)
                      End If

                      If strFileNameMatch.Length > intMaxMatch Then
                        strFileNameMatch = strFileNameMatch.Substring(0, intMaxMatch)
                      End If

                      Using Comm As New System.Data.SQLite.SQLiteCommand(oConn)
                        Comm.CommandText = "INSERT INTO tbl_game (gameid,game,suffix,zh_id,en_id,ko_id,video_id,class_type,game_type,hard,timer) VALUES (" & id & ",'" & strFileName & "','" & strExtension & "'," & id & "," & id & "," & id & ",NULL,0," & vetSelectedConsole(i, enumVetSelectedConsole.CoreNumber) & ",0,'/sdcard/game/" & vetSelectedConsole(i, enumVetSelectedConsole.GameStickFolder) & "/" & Path.GetDirectoryName(romFile).Split("\").Last & "');" & _
                                           "INSERT INTO tbl_en (en_id,en_title) VALUES (" & id & ",'" & Path.GetDirectoryName(romFile).Split("\").Last & "');" & _
                                           "INSERT INTO tbl_ko (ko_id,ko_title) VALUES (" & id & ",'" & Path.GetDirectoryName(romFile).Split("\").Last & "');" & _
                                           "INSERT INTO tbl_tw (en_id,en_title) VALUES (" & id & ",'" & Path.GetDirectoryName(romFile).Split("\").Last & "');" & _
                                           "INSERT INTO tbl_zh (zh_id,zh_title) VALUES (" & id & ",'" & Path.GetDirectoryName(romFile).Split("\").Last & "');" & _
                                           "INSERT INTO tbl_match (ID,zh_match) VALUES (" & id & ",'" & strFileNameMatch & "');"
                        Comm.ExecuteNonQuery()
                      End Using

                      id = id + 1
                    End If

                    intCount = intCount + 1

                    If intCount = intReg Then
                      intCount = 0
                      intProgress = intProgress + 1
                      bwAddRoms.ReportProgress(intProgress)
                      UpdateLabel(Me.lblStatus, intProgress.ToString & " %")
                    End If
                  Next
                Next

              Case Else
                For Each romFile In Directory.GetFiles(txtDirRoms.Text & "\" & vetSelectedConsole(i, enumVetSelectedConsole.SearchFolder))
                  If bwAddRoms.CancellationPending Then
                    oConn.Close()
                    e.Cancel = True
                    Exit For
                  End If

                  strExtension = Path.GetExtension(romFile)

                  If strExtension.ToLower <> ".png" And strExtension.ToLower <> ".srm" And Not strExtension.ToLower.Contains(".state") Then
                    strFileName = Path.GetFileNameWithoutExtension(romFile)
                    UpdateLabel(Me.lblRomAdd, vetSelectedConsole(i, enumVetSelectedConsole.SearchFolder) & "\" & strFileName)
                    strFileName = strFileName.Replace("'", "''")

                    strFileNameMatch = GetSearchName(strFileName)

                    If strFileName.Length > intMaxName Then
                      strFileName = strFileName.Substring(0, intMaxName)
                    End If

                    If strFileNameMatch.Length > intMaxMatch Then
                      strFileNameMatch = strFileNameMatch.Substring(0, intMaxMatch)
                    End If

                    Using Comm As New System.Data.SQLite.SQLiteCommand(oConn)
                      Comm.CommandText = "INSERT INTO tbl_game (gameid,game,suffix,zh_id,en_id,ko_id,video_id,class_type,game_type,hard,timer) VALUES (" & id & ",'" & strFileName & "','" & strExtension & "'," & id & "," & id & "," & id & ",NULL,0," & vetSelectedConsole(i, enumVetSelectedConsole.CoreNumber) & ",0,'/sdcard/game/" & vetSelectedConsole(i, enumVetSelectedConsole.GameStickFolder) & "');" & _
                                         "INSERT INTO tbl_en (en_id,en_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                         "INSERT INTO tbl_ko (ko_id,ko_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                         "INSERT INTO tbl_tw (en_id,en_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                         "INSERT INTO tbl_zh (zh_id,zh_title) VALUES (" & id & ",'" & strFileName & "');" & _
                                         "INSERT INTO tbl_match (ID,zh_match) VALUES (" & id & ",'" & strFileNameMatch & "');"
                      Comm.ExecuteNonQuery()
                    End Using

                    id = id + 1
                  End If

                  intCount = intCount + 1

                  If intCount = intReg Then
                    intCount = 0
                    intProgress = intProgress + 1
                    bwAddRoms.ReportProgress(intProgress)
                    UpdateLabel(Me.lblStatus, intProgress.ToString & " %")
                  End If
                Next
            End Select
          Next
        Else
          bwAddRoms.ReportProgress(100)
          UpdateLabel(Me.lblStatus, "100 %")
        End If

        oConn.Close()
      Else
        Dim strArqOriginal, strArqRenomeado As String

        If intQtdRom > 0 Then
          intReg = intQtdRom

          For Each romFile In Directory.GetFiles(txtDirRoms.Text)
            If bwAddRoms.CancellationPending Then
              e.Cancel = True
              Exit For
            End If

            strExtension = Path.GetExtension(romFile)
            strFileName = Path.GetFileNameWithoutExtension(romFile)

            strArqOriginal = strFileName

            If txtRemoverPalavra.Text <> String.Empty Then
              strFileName = strFileName.Replace(txtRemoverPalavra.Text, String.Empty)
            End If

            If txtAdicionarPalavra.Text <> String.Empty Then
              strFileName = strFileName & txtAdicionarPalavra.Text
            End If

            If txtExtensaoOriginal.Text <> String.Empty And txtNovaExtensao.Text <> String.Empty Then
              If strExtension.ToLower = txtExtensaoOriginal.Text.ToLower Then
                strArqRenomeado = strFileName & txtNovaExtensao.Text
              Else
                strArqRenomeado = strFileName & strExtension
              End If
            Else
              strArqRenomeado = strFileName & strExtension
            End If

            strArqOriginal = txtDirRoms.Text & "\" & strArqOriginal & strExtension
            strArqRenomeado = txtDirRoms.Text & "\" & strArqRenomeado

            FileSystem.Rename(strArqOriginal, strArqRenomeado)

            intCount = intCount + 1

            If intCount = intReg Then
              intCount = 0
              intProgress = intProgress + 1
              bwAddRoms.ReportProgress(intProgress)
              UpdateLabel(Me.lblStatus, intProgress.ToString & " %")
            End If
          Next
        End If
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message.ToString, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
  End Sub

  Private Sub bwAddRoms_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwAddRoms.ProgressChanged
    pbAndamento.Value = e.ProgressPercentage
  End Sub

  Private Sub bwAddRoms_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwAddRoms.RunWorkerCompleted

    If e.Cancelled Then
      lblStatus.Text = " ** Canceled ** "
    Else
      pbAndamento.Value = 100
      lblStatus.Text = "100 %"

      If btnFrmAddRoms.Enabled Then
        If intQtdRom > 0 Then
          MessageBox.Show("Roms edited!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("No ROM to be edited! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
      Else
        If intQtdRom > 0 Then
          MessageBox.Show("Successfully added roms!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("No ROMs to be added! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
      End If
    End If

    btnConfig.Enabled = True
    btnDbFile.Enabled = True
    btnRomsFolder.Enabled = True
    grpAddRoms.Enabled = True
    grpEditRoms.Enabled = True
    btnRunCommand.Enabled = True
    btnFrmDeleteAllRoms.Enabled = True
    btnStart.Visible = True
    btnCancel.Visible = False
    lblRomAdd.Visible = False

    If grpAddRoms.Visible = True Then
      btnFrmEditRoms.Enabled = True
    Else
      btnFrmAddRoms.Enabled = True
    End If
  End Sub

  Function GetSearchName(ByVal strFile As String) As String
    Return strFile.ToLower.Replace("[-mastersystem]", String.Empty). _
                           Replace("[-gamegear]", String.Empty). _
                           Replace("[-sega32x]", String.Empty). _
                           Replace("[-segacd]", String.Empty). _
                           Replace("[-sg1000]", String.Empty). _
                           Replace("[!]", String.Empty). _
                           Replace("[T-Port]", String.Empty). _
                           Replace("[o1]", String.Empty). _
                           Replace("(rev a)", String.Empty). _
                           Replace("(rev b)", String.Empty). _
                           Replace("(rev 01)", String.Empty). _
                           Replace("(rev 1)", String.Empty). _
                           Replace("(rev 2)", String.Empty). _
                           Replace("(atari)", String.Empty). _
                           Replace("(atari)", String.Empty). _
                           Replace("(1987)", String.Empty). _
                           Replace("(1988)", String.Empty). _
                           Replace("(1990)", String.Empty). _
                           Replace("(proto)", String.Empty). _
                           Replace("(unl)", String.Empty). _
                           Replace("(disc 1)", String.Empty). _
                           Replace("(disc 2)", String.Empty). _
                           Replace("(usa, europe)", String.Empty). _
                           Replace("(japan, usa)", String.Empty). _
                           Replace("(japan, europe)", String.Empty). _
                           Replace("(japan)", String.Empty). _
                           Replace("(en,fr,de,es,it)", String.Empty). _
                           Replace("(en,fr,de,es)", String.Empty). _
                           Replace("(en,fr,de,es,it,sv)", String.Empty). _
                           Replace("(en,fr,de,es,it,nl,pt,sv)", String.Empty). _
                           Replace("(en,fr,de,es,it,pt,sv,no)", String.Empty). _
                           Replace("(en,fr,de)", String.Empty). _
                           Replace("(en,fr)", String.Empty). _
                           Replace("(en,es)", String.Empty). _
                           Replace("(en,ja)", String.Empty). _
                           Replace("(usa)", String.Empty). _
                           Replace("(us)", String.Empty). _
                           Replace("(europe)", String.Empty). _
                           Replace("(france)", String.Empty). _
                           Replace("(world)", String.Empty). _
                           Replace("(brazil)", String.Empty). _
                           Replace("(eu)", String.Empty). _
                           Replace("(ue)", String.Empty). _
                           Replace("(jp)", String.Empty). _
                           Replace("(jp)", String.Empty). _
                           Replace("(br)", String.Empty). _
                           Replace("(chinese version)", String.Empty). _
                           Replace("(othello multivision)", String.Empty). _
                           Replace("(v1.1)", String.Empty). _
                           Replace("(a)", String.Empty). _
                           Replace("(e)", String.Empty). _
                           Replace("(j)", String.Empty). _
                           Replace("(u)", String.Empty). _
                           Replace("-", String.Empty). _
                           Replace("&", String.Empty). _
                           Replace("'", String.Empty). _
                           Replace("!", String.Empty). _
                           Replace(",", String.Empty). _
                           Replace(" ", String.Empty)
  End Function

  Private Sub UpdateLabel(ByVal [label] As Label, ByVal [text] As String)
    If [label].InvokeRequired Then
      Dim myDelegate As New setLabelTextDelegate(AddressOf UpdateLabel)
      Me.Invoke(myDelegate, New Object() {label, [text]})
    Else
      label.Text = [text]
    End If
  End Sub

  Private Sub ReadIniFile(ByVal strTypeImagem As String)
    Dim clsIni As New clsArquivoIni
    Dim strSection, strConsoleName, strSearchFolder, strGameStickFolder, strCoreNumber, strArcade, strDos, strScummVM As String
    Dim lstSection As ArrayList
    Try

      ' Abre o .ini de conexão
      clsIni.FileName = AppDomain.CurrentDomain.BaseDirectory & "config.ini"
      lblStatus.BackColor = Color.Transparent

      lstSection = clsIni.GetSectionNames()

      For i As Integer = 0 To lstSection.Count - 1
        strSection = lstSection(i)

        strConsoleName = clsIni.ReadString(strSection, "ConsoleName", String.Empty)
        strSearchFolder = clsIni.ReadString(strSection, "SearchFolder", String.Empty)
        strGameStickFolder = clsIni.ReadString(strSection, "GameStickFolder", String.Empty)
        strCoreNumber = clsIni.ReadString(strSection, "CoreNumber", String.Empty)
        strArcade = clsIni.ReadString(strSection, "Arcade", "N")
        strDos = clsIni.ReadString(strSection, "Dos", "N")
        strScummVM = clsIni.ReadString(strSection, "ScummVM", "N")


        addRowGrid(strConsoleName, strSearchFolder, strGameStickFolder, strCoreNumber, strArcade, strDos, strScummVM)
      Next
    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
  End Sub

  Private Sub addColumnGrid(ByVal HeaderText As String, ByVal AutoSizeMode As DataGridViewAutoSizeColumnMode, ByVal Alignment As DataGridViewContentAlignment, ByVal Width As Integer, ByVal Editavel As Boolean, ByVal blnFrozen As Boolean, ByVal DisplayIndex As Integer)
    Try

      Dim Col As New DataGridViewTextBoxColumn
      Col.HeaderText = HeaderText
      Col.AutoSizeMode = AutoSizeMode
      Col.ReadOnly = Not Editavel
      Col.DefaultCellStyle.Alignment = Alignment
      Col.DisplayIndex = DisplayIndex
      Col.Width = Width
      Col.Visible = CType(IIf(Width = 0, False, True), Boolean)
      Col.Frozen = blnFrozen

      If Editavel Then
        Col.SortMode = DataGridViewColumnSortMode.NotSortable
      Else
        Col.SortMode = DataGridViewColumnSortMode.Automatic
      End If

      dtgConsole.Columns.Add(Col)

    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try

  End Sub

  Private Sub addRowGrid(ByVal strConsoleName As String, ByVal strSearchFolder As String, ByVal strGameStickFolder As String, ByVal strCoreNumber As String, ByVal strArcade As String, ByVal strDos As String, ByVal strScummVM As String)
    Dim dgrRegistro As DataGridViewRow

    Try

      dgrRegistro = New DataGridViewRow
      With dgrRegistro
        .Height = dtgConsole.RowTemplate.Height
        .CreateCells(dtgConsole)
        .Cells(enumColGrid.ConsoleName).Value = strConsoleName
        .Cells(enumColGrid.SearchFolder).Value = strSearchFolder
        .Cells(enumColGrid.GameStickFolder).Value = strGameStickFolder
        .Cells(enumColGrid.CoreNumber).Value = strCoreNumber
        .Cells(enumColGrid.Arcade).Value = IIf(strArcade = "Y", "YES", "NO")
        .Cells(enumColGrid.Dos).Value = IIf(strDos = "Y", "YES", "NO")
        .Cells(enumColGrid.ScummVM).Value = IIf(strScummVM = "Y", "YES", "NO")
      End With

      dtgConsole.Rows.Add(dgrRegistro)
    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
  End Sub

  Private Sub formatGrid()
    Try
      dtgConsole.ReadOnly = True
      dtgConsole.EditMode = DataGridViewEditMode.EditOnEnter 'a edição é iniciada qdo a celula receber o foco

      addColumnGrid("Console Name", DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleLeft, 152, False, False, enumColGrid.CoreNumber)
      addColumnGrid("Folder to Search Roms", DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleLeft, 140, False, False, enumColGrid.SearchFolder)
      addColumnGrid("Folder into GameStick", DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleLeft, 140, False, False, enumColGrid.GameStickFolder)
      addColumnGrid("Core Number", DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleRight, 95, False, False, enumColGrid.CoreNumber)
      addColumnGrid("Arcade", DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleCenter, 70, False, False, enumColGrid.Arcade)
      addColumnGrid("Dos", DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleCenter, 50, False, False, enumColGrid.Dos)
      addColumnGrid("Scumm VM", DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleCenter, 82, False, False, enumColGrid.ScummVM)

      dtgConsole.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
  End Sub

  Private Sub formatList()
    Dim header As ColumnHeader
    Try
      lstRomsAvailable.Scrollable = True
      lstRomsAvailable.View = View.Details

      lstRomsSelected.Scrollable = True
      lstRomsSelected.View = View.Details

      lstRomsAvailable.HeaderStyle = ColumnHeaderStyle.None
      lstRomsSelected.HeaderStyle = ColumnHeaderStyle.None

      header = New ColumnHeader()
      header.Text = String.Empty
      header.Name = "col1"
      header.Width = 120

      lstRomsAvailable.Columns.Add(header)

      header = New ColumnHeader()
      header.Text = String.Empty
      header.Name = "col1"
      header.Width = 120

      lstRomsSelected.Columns.Add(header)

    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
  End Sub

End Class
