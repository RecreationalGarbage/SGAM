<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SGAMForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SGAMForm))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ExecuteBut = New System.Windows.Forms.Button()
        Me.FirstPropertyBox = New System.Windows.Forms.ComboBox()
        Me.SecondPropertyBox = New System.Windows.Forms.ComboBox()
        Me.csvButton = New System.Windows.Forms.Button()
        Me.CSvPathCmd = New System.Windows.Forms.OpenFileDialog()
        Me.argumentBox = New System.Windows.Forms.ListBox()
        Me.argumentLabel = New System.Windows.Forms.TextBox()
        Me.viewButton = New System.Windows.Forms.Button()
        Me.customCmdButton = New System.Windows.Forms.Button()
        Me.argboxcontrollabel = New System.Windows.Forms.Label()
        Me.csvCheckBox = New System.Windows.Forms.CheckBox()
        Me.outPutToFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PrintSecondPropertyBox = New System.Windows.Forms.ComboBox()
        Me.requiredlabel = New System.Windows.Forms.Label()
        Me.versionlabel = New System.Windows.Forms.Label()
        Me.sgamMainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteConfigFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableNoupdateCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableWarnOnDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleClearCsvPathAfterExecuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleStartupCheckForAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeUsernameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HawkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HawkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.argBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DevicesLabel = New System.Windows.Forms.ListBox()
        Me.DevicePropertyBox = New System.Windows.Forms.ComboBox()
        Me.deviceboxlabel = New System.Windows.Forms.Label()
        Me.saveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.sgamMainMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(316, 191)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ExecuteBut
        '
        Me.ExecuteBut.Location = New System.Drawing.Point(27, 115)
        Me.ExecuteBut.Name = "ExecuteBut"
        Me.ExecuteBut.Size = New System.Drawing.Size(89, 23)
        Me.ExecuteBut.TabIndex = 2
        Me.ExecuteBut.Tag = ""
        Me.ExecuteBut.Text = "&EXECUTE!"
        Me.ExecuteBut.UseVisualStyleBackColor = True
        '
        'FirstPropertyBox
        '
        Me.FirstPropertyBox.FormattingEnabled = True
        Me.FirstPropertyBox.Items.AddRange(New Object() {"Create", "Update", "Delete", "Print", "Other", "Chrome Device"})
        Me.FirstPropertyBox.Location = New System.Drawing.Point(11, 61)
        Me.FirstPropertyBox.Name = "FirstPropertyBox"
        Me.FirstPropertyBox.Size = New System.Drawing.Size(121, 21)
        Me.FirstPropertyBox.TabIndex = 4
        Me.FirstPropertyBox.Text = "SELECT"
        '
        'SecondPropertyBox
        '
        Me.SecondPropertyBox.FormattingEnabled = True
        Me.SecondPropertyBox.Items.AddRange(New Object() {"User", "Group", "OU"})
        Me.SecondPropertyBox.Location = New System.Drawing.Point(11, 88)
        Me.SecondPropertyBox.Name = "SecondPropertyBox"
        Me.SecondPropertyBox.Size = New System.Drawing.Size(121, 21)
        Me.SecondPropertyBox.TabIndex = 6
        Me.SecondPropertyBox.Text = "SELECT"
        '
        'csvButton
        '
        Me.csvButton.Location = New System.Drawing.Point(27, 32)
        Me.csvButton.Name = "csvButton"
        Me.csvButton.Size = New System.Drawing.Size(95, 23)
        Me.csvButton.TabIndex = 8
        Me.csvButton.Text = "Browse for CSV"
        Me.csvButton.UseVisualStyleBackColor = True
        '
        'CSvPathCmd
        '
        Me.CSvPathCmd.FileName = "CSvPathCmd"
        '
        'argumentBox
        '
        Me.argumentBox.FormattingEnabled = True
        Me.argumentBox.Location = New System.Drawing.Point(155, 46)
        Me.argumentBox.Name = "argumentBox"
        Me.argumentBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.argumentBox.Size = New System.Drawing.Size(228, 108)
        Me.argumentBox.TabIndex = 10
        Me.argBoxToolTip.SetToolTip(Me.argumentBox, "Use ""todrive"" to send output to the GAM adminisrators google drive rather than a " &
        "local file.")
        '
        'argumentLabel
        '
        Me.argumentLabel.Location = New System.Drawing.Point(155, 200)
        Me.argumentLabel.Name = "argumentLabel"
        Me.argumentLabel.Size = New System.Drawing.Size(100, 20)
        Me.argumentLabel.TabIndex = 11
        Me.argumentLabel.Visible = False
        '
        'viewButton
        '
        Me.viewButton.Location = New System.Drawing.Point(27, 144)
        Me.viewButton.Name = "viewButton"
        Me.viewButton.Size = New System.Drawing.Size(89, 23)
        Me.viewButton.TabIndex = 12
        Me.viewButton.Text = "View Command"
        Me.viewButton.UseVisualStyleBackColor = True
        '
        'customCmdButton
        '
        Me.customCmdButton.Location = New System.Drawing.Point(11, 173)
        Me.customCmdButton.Name = "customCmdButton"
        Me.customCmdButton.Size = New System.Drawing.Size(121, 23)
        Me.customCmdButton.TabIndex = 13
        Me.customCmdButton.Text = "Custom Command"
        Me.customCmdButton.UseVisualStyleBackColor = True
        Me.customCmdButton.Visible = False
        '
        'argboxcontrollabel
        '
        Me.argboxcontrollabel.AutoSize = True
        Me.argboxcontrollabel.BackColor = System.Drawing.Color.Transparent
        Me.argboxcontrollabel.Location = New System.Drawing.Point(164, 30)
        Me.argboxcontrollabel.Name = "argboxcontrollabel"
        Me.argboxcontrollabel.Size = New System.Drawing.Size(203, 13)
        Me.argboxcontrollabel.TabIndex = 14
        Me.argboxcontrollabel.Text = "Hold ""control"" to make multiple selections"
        '
        'csvCheckBox
        '
        Me.csvCheckBox.AutoSize = True
        Me.csvCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.csvCheckBox.Location = New System.Drawing.Point(155, 161)
        Me.csvCheckBox.Name = "csvCheckBox"
        Me.csvCheckBox.Size = New System.Drawing.Size(141, 17)
        Me.csvCheckBox.TabIndex = 15
        Me.csvCheckBox.Text = "Output data to local file?"
        Me.csvCheckBox.UseVisualStyleBackColor = False
        Me.csvCheckBox.Visible = False
        '
        'outPutToFileDialog
        '
        Me.outPutToFileDialog.FileName = "sgamoutput.csv"
        '
        'PrintSecondPropertyBox
        '
        Me.PrintSecondPropertyBox.FormattingEnabled = True
        Me.PrintSecondPropertyBox.Items.AddRange(New Object() {"All Users", "All Groups", "All OUs"})
        Me.PrintSecondPropertyBox.Location = New System.Drawing.Point(11, 88)
        Me.PrintSecondPropertyBox.Name = "PrintSecondPropertyBox"
        Me.PrintSecondPropertyBox.Size = New System.Drawing.Size(121, 21)
        Me.PrintSecondPropertyBox.TabIndex = 16
        Me.PrintSecondPropertyBox.Text = "SELECT"
        Me.PrintSecondPropertyBox.Visible = False
        '
        'requiredlabel
        '
        Me.requiredlabel.AutoSize = True
        Me.requiredlabel.BackColor = System.Drawing.Color.Transparent
        Me.requiredlabel.Location = New System.Drawing.Point(292, 162)
        Me.requiredlabel.Name = "requiredlabel"
        Me.requiredlabel.Size = New System.Drawing.Size(111, 13)
        Me.requiredlabel.TabIndex = 17
        Me.requiredlabel.Text = "<--USE IF PRINTING!"
        Me.requiredlabel.Visible = False
        '
        'versionlabel
        '
        Me.versionlabel.AutoSize = True
        Me.versionlabel.BackColor = System.Drawing.Color.Transparent
        Me.versionlabel.Location = New System.Drawing.Point(0, 207)
        Me.versionlabel.Name = "versionlabel"
        Me.versionlabel.Size = New System.Drawing.Size(66, 13)
        Me.versionlabel.TabIndex = 18
        Me.versionlabel.Text = "Version 1.07"
        '
        'sgamMainMenuStrip
        '
        Me.sgamMainMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.sgamMainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.sgamMainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdvancedOptionsToolStripMenuItem, Me.UtilitiesToolStripMenuItem})
        Me.sgamMainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.sgamMainMenuStrip.Name = "sgamMainMenuStrip"
        Me.sgamMainMenuStrip.Size = New System.Drawing.Size(410, 24)
        Me.sgamMainMenuStrip.TabIndex = 19
        Me.sgamMainMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteConfigFileToolStripMenuItem, Me.CopyCommandToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.FileToolStripMenuItem.Text = "File Menu"
        '
        'DeleteConfigFileToolStripMenuItem
        '
        Me.DeleteConfigFileToolStripMenuItem.Name = "DeleteConfigFileToolStripMenuItem"
        Me.DeleteConfigFileToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DeleteConfigFileToolStripMenuItem.Text = "Delete Config File"
        '
        'CopyCommandToolStripMenuItem
        '
        Me.CopyCommandToolStripMenuItem.Name = "CopyCommandToolStripMenuItem"
        Me.CopyCommandToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CopyCommandToolStripMenuItem.Text = "Copy Command"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AdvancedOptionsToolStripMenuItem
        '
        Me.AdvancedOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisableNoupdateCheckToolStripMenuItem, Me.DisableWarnOnDeleteToolStripMenuItem, Me.ToggleClearCsvPathAfterExecuteToolStripMenuItem, Me.ToggleStartupCheckForAdminToolStripMenuItem})
        Me.AdvancedOptionsToolStripMenuItem.Name = "AdvancedOptionsToolStripMenuItem"
        Me.AdvancedOptionsToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.AdvancedOptionsToolStripMenuItem.Text = "Advanced Options"
        '
        'DisableNoupdateCheckToolStripMenuItem
        '
        Me.DisableNoupdateCheckToolStripMenuItem.Name = "DisableNoupdateCheckToolStripMenuItem"
        Me.DisableNoupdateCheckToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.DisableNoupdateCheckToolStripMenuItem.Text = "Disable noupdate check"
        '
        'DisableWarnOnDeleteToolStripMenuItem
        '
        Me.DisableWarnOnDeleteToolStripMenuItem.Enabled = False
        Me.DisableWarnOnDeleteToolStripMenuItem.Name = "DisableWarnOnDeleteToolStripMenuItem"
        Me.DisableWarnOnDeleteToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.DisableWarnOnDeleteToolStripMenuItem.Text = "Disable warn on delete"
        Me.DisableWarnOnDeleteToolStripMenuItem.Visible = False
        '
        'ToggleClearCsvPathAfterExecuteToolStripMenuItem
        '
        Me.ToggleClearCsvPathAfterExecuteToolStripMenuItem.Name = "ToggleClearCsvPathAfterExecuteToolStripMenuItem"
        Me.ToggleClearCsvPathAfterExecuteToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ToggleClearCsvPathAfterExecuteToolStripMenuItem.Text = "Disable clear csv path after execute"
        '
        'ToggleStartupCheckForAdminToolStripMenuItem
        '
        Me.ToggleStartupCheckForAdminToolStripMenuItem.Name = "ToggleStartupCheckForAdminToolStripMenuItem"
        Me.ToggleStartupCheckForAdminToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ToggleStartupCheckForAdminToolStripMenuItem.Text = "Disable startup check for admin"
        '
        'UtilitiesToolStripMenuItem
        '
        Me.UtilitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeUsernameToolStripMenuItem, Me.MakePasswordToolStripMenuItem})
        Me.UtilitiesToolStripMenuItem.Name = "UtilitiesToolStripMenuItem"
        Me.UtilitiesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.UtilitiesToolStripMenuItem.Text = "Utilities"
        '
        'MakeUsernameToolStripMenuItem
        '
        Me.MakeUsernameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HawkToolStripMenuItem})
        Me.MakeUsernameToolStripMenuItem.Name = "MakeUsernameToolStripMenuItem"
        Me.MakeUsernameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MakeUsernameToolStripMenuItem.Text = "Make Username"
        '
        'HawkToolStripMenuItem
        '
        Me.HawkToolStripMenuItem.Name = "HawkToolStripMenuItem"
        Me.HawkToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.HawkToolStripMenuItem.Text = "Hawk Style"
        '
        'MakePasswordToolStripMenuItem
        '
        Me.MakePasswordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HawkToolStripMenuItem1})
        Me.MakePasswordToolStripMenuItem.Name = "MakePasswordToolStripMenuItem"
        Me.MakePasswordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MakePasswordToolStripMenuItem.Text = "Make Password"
        '
        'HawkToolStripMenuItem1
        '
        Me.HawkToolStripMenuItem1.Name = "HawkToolStripMenuItem1"
        Me.HawkToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.HawkToolStripMenuItem1.Text = "Hawk Style"
        '
        'DevicesLabel
        '
        Me.DevicesLabel.FormattingEnabled = True
        Me.DevicesLabel.Location = New System.Drawing.Point(155, 46)
        Me.DevicesLabel.Name = "DevicesLabel"
        Me.DevicesLabel.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.DevicesLabel.Size = New System.Drawing.Size(228, 108)
        Me.DevicesLabel.TabIndex = 21
        Me.argBoxToolTip.SetToolTip(Me.DevicesLabel, "Use ""todrive"" to send output to the GAM adminisrators google drive rather than a " &
        "local file.")
        Me.DevicesLabel.Visible = False
        '
        'DevicePropertyBox
        '
        Me.DevicePropertyBox.FormattingEnabled = True
        Me.DevicePropertyBox.Items.AddRange(New Object() {"Move Devices to OU", "Deprovision Devices", "Add Asset Tag", "Remote Powerwash"})
        Me.DevicePropertyBox.Location = New System.Drawing.Point(11, 88)
        Me.DevicePropertyBox.Name = "DevicePropertyBox"
        Me.DevicePropertyBox.Size = New System.Drawing.Size(121, 21)
        Me.DevicePropertyBox.TabIndex = 20
        Me.DevicePropertyBox.Text = "SELECT"
        Me.DevicePropertyBox.Visible = False
        '
        'deviceboxlabel
        '
        Me.deviceboxlabel.AutoSize = True
        Me.deviceboxlabel.BackColor = System.Drawing.Color.Transparent
        Me.deviceboxlabel.Location = New System.Drawing.Point(134, 32)
        Me.deviceboxlabel.Name = "deviceboxlabel"
        Me.deviceboxlabel.Size = New System.Drawing.Size(269, 13)
        Me.deviceboxlabel.TabIndex = 22
        Me.deviceboxlabel.Text = "No selection needed, just enter these values into a .csv"
        Me.deviceboxlabel.Visible = False
        '
        'SGAMForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(410, 219)
        Me.Controls.Add(Me.deviceboxlabel)
        Me.Controls.Add(Me.DevicesLabel)
        Me.Controls.Add(Me.DevicePropertyBox)
        Me.Controls.Add(Me.versionlabel)
        Me.Controls.Add(Me.requiredlabel)
        Me.Controls.Add(Me.PrintSecondPropertyBox)
        Me.Controls.Add(Me.csvCheckBox)
        Me.Controls.Add(Me.argboxcontrollabel)
        Me.Controls.Add(Me.customCmdButton)
        Me.Controls.Add(Me.viewButton)
        Me.Controls.Add(Me.argumentLabel)
        Me.Controls.Add(Me.argumentBox)
        Me.Controls.Add(Me.csvButton)
        Me.Controls.Add(Me.SecondPropertyBox)
        Me.Controls.Add(Me.FirstPropertyBox)
        Me.Controls.Add(Me.ExecuteBut)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.sgamMainMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.sgamMainMenuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(426, 258)
        Me.MinimumSize = New System.Drawing.Size(426, 258)
        Me.Name = "SGAMForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SGAM Advanced"
        Me.sgamMainMenuStrip.ResumeLayout(False)
        Me.sgamMainMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ExecuteBut As System.Windows.Forms.Button
    Friend WithEvents FirstPropertyBox As ComboBox
    Friend WithEvents SecondPropertyBox As ComboBox
    Friend WithEvents csvButton As Button
    Friend WithEvents CSvPathCmd As OpenFileDialog
    Friend WithEvents argumentBox As ListBox
    Friend WithEvents argumentLabel As TextBox
    Friend WithEvents viewButton As Button
    Friend WithEvents customCmdButton As Button
    Friend WithEvents argboxcontrollabel As Label
    Friend WithEvents csvCheckBox As CheckBox
    Friend WithEvents outPutToFileDialog As SaveFileDialog
    Friend WithEvents PrintSecondPropertyBox As ComboBox
    Friend WithEvents requiredlabel As Label
    Friend WithEvents versionlabel As Label
    Friend WithEvents sgamMainMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteConfigFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCommandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents argBoxToolTip As ToolTip
    Friend WithEvents AdvancedOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableNoupdateCheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableWarnOnDeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleClearCsvPathAfterExecuteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleStartupCheckForAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicePropertyBox As ComboBox
    Friend WithEvents DevicesLabel As ListBox
    Friend WithEvents deviceboxlabel As Label
    Friend WithEvents UtilitiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeUsernameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HawkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HawkToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents saveDialog As SaveFileDialog
End Class
