'##### Uncomment lines 25 - 32 and line 149 for release builds, comment for testing #####
Imports System.Runtime.InteropServices
Imports System.IO
Imports Ini 'inimod.dll namespace, the only C#
Imports System.Security.Principal 'For use with checking admin privs
Public Class SGAMForm
    Dim uName As String = Environment.UserName 'Get the current logged on users name, is returned with Domain\ in front
    Dim iniPath As String = "C:\Program Files (x86)\SGAM\SGAM.ini" 'Defines the exact path to the .ini, used to be dynamic but I had issues with standard users using elevated permissions not returning the right path
    Dim SGAMINI As New IniFile("C:\Program Files (x86)\SGAM\SGAM.ini") 'Paath to the SGAM.ini file created on first startup
    Dim quote As String = """" 'wraps file paths in quotes in case they contain spaces
    Dim FinalGamString As String = ""
    Dim Box1Text As String = "" 'Declare the property box selection as a string
    Dim Box2Text As String = ""
    Dim OutputFile As String = ""
    Dim errorfile As String = quote + "C:\Program Files (x86)\SGAM\errorlog.txt" + quote
    Dim errorhandler As String = " redirect stderr " + errorfile + " multiprocess"

    <DllImportAttribute("kernel32.dll", EntryPoint:="WritePrivateProfileStringW")>
    Private Shared Function WritePrivateProfileStringW(<InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpSecName As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpKeyName As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpString As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpFileName As String) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False 'The argument box randomly broke and now needs this to work, 4/16/20, its worked fine for 2 weeks and nothing was changed
        Dim SectionName As String = "GAM Path"
        Dim NoAdminCheck As String = "Noadmincheck"
        Dim noadm As String = SGAMINI.IniReadValue(SectionName, NoAdminCheck)

        If noadm = "" Then
            '*********Uncomment this whole block to enable startup checks for admin privs, keep commented during testing***********
            Dim AdmUser = WindowsIdentity.GetCurrent()
            Dim AdmGroup = New WindowsPrincipal(AdmUser)
            Dim isElevated As Boolean = AdmGroup.IsInRole(WindowsBuiltInRole.Administrator)
            If isElevated Then
            Else
                MessageBox.Show("Please run this program with administrator privelages.")
                End
            End If
            '*********/Uncomment this whole block to enable startup checks for admin privs, keep commented during testing***********
        ElseIf noadm = "1" Then
        End If
        If File.Exists(iniPath) Then 'Is there a config file present? Continue doing nothing

        Else : Me.ShowInTaskbar = False 'otherwise, hide the main window and show the config creation one
            Me.Opacity = 0
            SettingsForm.ShowDialog()

        End If
    End Sub
    Private Sub argumentBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles argumentBox.SelectedIndexChanged
        argumentLabel.Clear()

        For Each Item As Object In argumentBox.SelectedItems 'Get selection of arguments from the box
            argumentLabel.AppendText(Item.ToString) 'adds selection to textbox for easy managment
        Next
    End Sub
    Private Sub CMDAutomate() 'Main area for processing the commands
        Dim SectionName As String = "GAM Path" 'Defines section of .ini file
        Dim GamIniKey As String = "Directory" 'Defines key in .ini file
        Dim CSVIniKey As String = "CSV" 'Defines key in .ini file
        Dim CString As String = "CustomString" 'Defines key in .ini file
        Dim GamPath As String = SGAMINI.IniReadValue(SectionName, GamIniKey) 'Save the inireadvalue output into a usable string
        Dim CsvPath As String = SGAMINI.IniReadValue(SectionName, CSVIniKey) 'Save the inireadvalue output into a usable string
        Dim customExist As String = SGAMINI.IniReadValue(SectionName, CString) 'take the output from the custom command window and make it a string
        Dim argumentLabelText As String = argumentLabel.Text 'Convert the string from the hidden textbox into text, save it as a variable
        Dim OtherArguments As String = argumentBox.SelectedItem 'Defines case statment to look at the selected item in argumentbox
        Dim NoDelCsvPath As String = "Keepcsv" 'The specific key in the ini file that has the value for admin priv check
        Dim valuedel As String = SGAMINI.IniReadValue(SectionName, NoDelCsvPath) 'Checks the valudel string, blank means delete path to .csv file after execute, 1 is dont
        Dim CStringValue As String = ""

        'This case statment can be expanded to convert specific custom strings of text into commands, add matching string to "other" case of FirstPropertyBox
        Select Case OtherArguments
            Case ("Remove specific user from all groups")
                Box1Text = ""
                argumentLabelText = (" gam user ~user delete groups") 'removes specified user from all groups
            Case ("Print Members of Specific Groups")
                Box1Text = (" gam print")
                argumentLabelText = (" group-members group ~groupemail" + OutputFile)
            Case ("Print Specific Users Group Membership")
                Box1Text = (" gam print")
                argumentLabelText = (" group-members member ~user" + OutputFile)
            Case ("Print Information for specific OUs")
                Box1Text = ("")
                argumentLabelText = (" gam info org ~ou" + OutputFile)
            Case Else
        End Select

        '********This code should be cleaned up***********
        If customExist = ("") Then 'Checks to see if there is a custom command
            FinalGamString = (quote + GamPath + quote + errorhandler + " csv " + quote + CsvPath + quote + Box1Text + argumentLabelText) 'Final complete string prepared to be executed by cmd
        Else
            FinalGamString = (quote + GamPath + quote + errorhandler + " csv " + quote + CsvPath + quote + " " + customExist) 'alternate command with custom command added
        End If
        If Box1Text = " print" Then 'This would probobly need to be changed if the custom button is re-enabled
            FinalGamString = (quote + GamPath + quote + Box1Text + " " + Box2Text + argumentLabelText + OutputFile) 'used for gam print because I dont know how to code
        End If
        '/********This code should be cleaned up***********

        Dim myprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd" 'starts cmd window
        'StartInfo.Arguments = ("/k") 'uncomment to force cmd window to stay open, used for some testing
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.CreateNoWindow = False '<---- if you want to not create a window
        StartInfo.UseShellExecute = False 'required to redirect
        myprocess.StartInfo = StartInfo
        myprocess.Start()

        Dim SR As System.IO.StreamReader = myprocess.StandardOutput
        Dim SW As System.IO.StreamWriter = myprocess.StandardInput
        SW.WriteLine(FinalGamString) 'Write the FinalString directly to the command window
        SW.WriteLine("exit") 'exits command prompt window
        FinalGamString = SR.ReadToEnd 'returns results of the command window
        SW.Close()
        SR.Close()

        If valuedel = "" Then
            '*****This code removes the path to the csv after completion, comment for testing*****
            WritePrivateProfileStringW(SectionName, CSVIniKey, CStringValue, iniPath)
            '*****/This code removes the path to the csv after completion, comment for testing*****
        ElseIf valuedel = "1" Then
        End If

        WritePrivateProfileStringW(SectionName, CString, CStringValue, iniPath) 'Sets custom string to nothing after execute

    End Sub
    Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click 'Mirror with the cmdautomate thread, minus processing functions
        Dim SectionName As String = "GAM Path" 'Defines section of .ini file
        Dim GamIniKey As String = "Directory" 'Defines key in .ini file
        Dim CSVIniKey As String = "CSV" 'Defines key in .ini file
        Dim CString As String = "CustomString"
        Dim GamPath As String = SGAMINI.IniReadValue(SectionName, GamIniKey) 'Save the inireadvalue output into a usable string
        Dim CsvPath As String = SGAMINI.IniReadValue(SectionName, CSVIniKey) 'Save the inireadvalue output into a usable string
        Dim customExist As String = SGAMINI.IniReadValue(SectionName, CString) 'take the output from the custom command window and make it a string
        Dim argumentLabelText As String = argumentLabel.Text 'Convert the string from the hidden textbox into text, save it as a variable
        Dim OtherArguments As String = argumentBox.SelectedItem
        Dim CsvValue As String = ""

        'This case statment can be expanded to convert specific custom strings into commands, uses standard final string
        Select Case OtherArguments
            Case ("Remove specific user from all groups")
                Box1Text = ""
                argumentLabelText = (" gam user ~user delete groups") 'removes specified user from all groups
            Case ("Print Members of Specific Groups")
                Box1Text = (" gam print")
                argumentLabelText = (" group-members group ~groupemail" + OutputFile)
            Case ("Print Specific Users Group Membership")
                Box1Text = (" gam print")
                argumentLabelText = (" group-members member ~user" + OutputFile)
            Case ("Print Information for specific OUs")
                Box1Text = ("")
                argumentLabelText = (" gam info org ~ou" + OutputFile)
        End Select

        If customExist = ("") Then
            FinalGamString = (quote + GamPath + quote + errorhandler + " csv " + quote + CsvPath + quote + Box1Text + argumentLabelText) 'Standard final string prepared to be executed by GAM
        Else
            FinalGamString = (quote + GamPath + quote + errorhandler + " csv " + quote + CsvPath + quote + " " + customExist) 'alternate command with custom command added
        End If

        If Box1Text = " print" Then 'This would probobly need to be changed if the custom button is re-enabled
            FinalGamString = (quote + GamPath + quote + Box1Text + Box2Text + argumentLabelText + OutputFile) 'used for gam print because I dont know how to code
        End If

        MessageBox.Show(FinalGamString, "Use File Menu to Copy")

    End Sub
    Private Sub ExecuteBut_Click(sender As Object, e As EventArgs) Handles ExecuteBut.Click 'This starts the process created by CMDAutomate

        Dim SectionName As String = "GAM Path" 'Defines section of .ini file
        Dim GamIniKey As String = "Directory" 'Defines key in .ini file
        Dim CSVIniKey As String = "CSV" 'Defines key in .ini file
        Dim CsvPath As String = SGAMINI.IniReadValue(SectionName, CSVIniKey) 'Save the inireadvalue output into a usable string
        Dim noupdatecheckstring As String = "Updatetxt" 'The specific key in the ini file that has the value for updatecheck
        Dim valuetxt As String = SGAMINI.IniReadValue(SectionName, noupdatecheckstring) 'Checks the noupdatecheckstring, blank is warn, 1 is disabled

        '*****Code below here is experimental, might not be needed*****
        If valuetxt = "" Then

            Dim GamPath As String = SGAMINI.IniReadValue(SectionName, GamIniKey)
            Dim updatecheck = GamPath.Substring(0, GamPath.Length - 7) & "noupdatecheck.txt"
            If File.Exists(updatecheck) Then
            Else
                Dim answer As DialogResult = MessageBox.Show("SGAM did not detect the presence of noupdatecheck.txt in the GAM folder, this may cause issues in certain conditions, create file now?", "Create missing file?", MessageBoxButtons.YesNo)
                If answer = DialogResult.No Then
                ElseIf answer = DialogResult.Yes Then
                    Dim updatefile As FileStream = File.Create(updatecheck)
                End If
            End If

        ElseIf valuetxt = "1" Then
        End If

        '*****/Code above here is experimental, might not be needed*****

        If CsvPath = "" Then
            MessageBox.Show("Please select a .csv file.")
        Else
            Dim GAMThread As New Threading.Thread(AddressOf CMDAutomate) 'Get info for process from the CMDAutomate private sub
            GAMThread.Start() 'Execute the gam process when button is clicked
        End If

    End Sub
    Private Sub csvButton_Click(sender As Object, e As EventArgs) Handles csvButton.Click
        Dim quote As String = """" 'wraps GamPath in quotes in case it contains spaces
        Dim SectionName As String = "GAM Path" 'Defines section of .ini file
        Dim CSV As String = "CSV" 'Defines key in .ini file

        CSvPathCmd.InitialDirectory = "C:\" 'Controls the dialog box that opens when selecting CSV file
        CSvPathCmd.Title = "Locate your CSV File"
        CSvPathCmd.Filter = "csv.csv|*.csv|All Files|*.*"
        CSvPathCmd.ShowDialog()

        Dim CsvValue As String = CSvPathCmd.FileName 'Write teh path to the csv as a string

        WritePrivateProfileStringW(SectionName, CSV, CsvValue, iniPath)

    End Sub
    Private Sub FirstPropertyBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FirstPropertyBox.SelectedIndexChanged
        PrintSecondPropertyBox.Visible = False
        SecondPropertyBox.Visible = True
        argumentLabel.Text = ""
        Box1Text = FirstPropertyBox.SelectedItem()
        requiredlabel.Visible = False
        argboxcontrollabel.Visible = True
        argumentBox.Items.Clear() 'Clears argument box if the first property box changes, not sure if I like it or not
        SecondPropertyBox.Text = "SELECT" 'clears second property box selection every time the first box changes
        PrintSecondPropertyBox.Text = "SELECT" 'clears print second property box selection every time the first box changes
        argumentBox.Visible = True
        SecondPropertyBox.Visible = True
        DevicePropertyBox.Visible = False
        deviceboxlabel.Visible = False
        DevicesLabel.Visible = False

        Select Case Box1Text
            Case "Create"
                csvCheckBox.Checked = False 'Uncheck the output file checkbox
                csvCheckBox.Visible = False 'Dont show the checkbox for output file selection
                SecondPropertyBox.Enabled = True 'Make sure the second property box is enabled in case other was selected
                Box1Text = " gam create"
            Case "Update"
                csvCheckBox.Checked = False
                csvCheckBox.Visible = False
                SecondPropertyBox.Enabled = True
                Box1Text = " gam update"
            Case "Delete"
                Dim SectionName As String = "GAM Path"
                Dim nodelwarnstring As String = "NoDelWarn"
                Dim valuedel As String = SGAMINI.IniReadValue(SectionName, nodelwarnstring)
                If valuedel = "" Then
                    MessageBox.Show("Make sure empty cells are populated with # in your .csv file!", "Warning, check readme")
                ElseIf valuedel = "1" Then
                End If
                csvCheckBox.Checked = False
                csvCheckBox.Visible = False
                SecondPropertyBox.Enabled = True
                Box1Text = " gam delete"
            Case "Print"
                csvCheckBox.Checked = False
                csvCheckBox.Visible = True
                SecondPropertyBox.Enabled = True
                argumentBox.Items.Clear()
                Box1Text = " print"
                SecondPropertyBox.Visible = False
                PrintSecondPropertyBox.Visible = True
            Case "Other"
                Box1Text = ""
                requiredlabel.Visible = True
                csvCheckBox.Checked = False
                csvCheckBox.Visible = True
                argboxcontrollabel.Visible = False
                SecondPropertyBox.Enabled = False
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.One
                argumentBox.Items.Add("Remove specific user from all groups") 'Removes all group membership for specified users
                argumentBox.Items.Add("Print Members of Specific Groups") 'Lists all members of a given group(s)
                argumentBox.Items.Add("Print Specific Users Group Membership") 'Lists every group a specified user is part of
                argumentBox.Items.Add("Print Information for specific OUs") 'Lists all information for specific OUs
            Case "Chrome Device"
                csvCheckBox.Checked = False
                csvCheckBox.Visible = False
                SecondPropertyBox.Enabled = True
                Box1Text = " gam update"
                SecondPropertyBox.Visible = False
                DevicePropertyBox.Visible = True
                argumentBox.Visible = False
                argboxcontrollabel.Visible = False
                deviceboxlabel.Visible = True
                DevicesLabel.Visible = True
                DevicePropertyBox.Text = "SELECT"
            Case Else
                csvCheckBox.Checked = False
                csvCheckBox.Visible = False
                SecondPropertyBox.Enabled = True
                Box1Text = "Box 1 Error"
        End Select
    End Sub
    Private Sub SecondPropertyBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SecondPropertyBox.SelectedIndexChanged

        Box2Text = SecondPropertyBox.SelectedItem()

        Select Case Box2Text
            Case "User"
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
                argumentBox.Items.Add(" user ~user") 'Email Address
                argumentBox.Items.Add(" password ~password") 'Password
                argumentBox.Items.Add(" firstname ~firstname") 'First Name
                argumentBox.Items.Add(" lastname ~lastname") 'Last Name
                argumentBox.Items.Add(" ou ~ou") 'OU
                argumentBox.Items.Add(" group ~groupemail") 'Group (email address)
                argumentBox.Items.Add(" changepassword ~changepw") 'change user password on next login, set to either on or off
                argumentBox.Items.Add(" gal ~usergal") 'Show in global address list, either on or off
                argumentBox.Items.Add(" suspended ~suspended") 'If user is suspended or not, on or off
            Case "Group"
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
                argumentBox.Items.Add(" group ~groupemail") 'Group (email address)
                argumentBox.Items.Add(" name ~groupname") 'Display name of group
                argumentBox.Items.Add(" description ~description")
                argumentBox.Items.Add(" show_in_group_directory ~showgroup") 'List in Gsuite group directory, true or false
                argumentBox.Items.Add(" include_in_global_address_list ~showglobal") 'List in global search catalog, true or false
                argumentBox.Items.Add(" add member user ~user") 'Add user to group by email address
                argumentBox.Items.Add(" email ~newgroupemail") 'Used with update, sets new group email
                argumentBox.Items.Add(" remove user ~user")
            Case "OU"
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
                argumentBox.Items.Add(" org ~ou") 'OU
                argumentBox.Items.Add(" description ~description") 'Description of the OU
                argumentBox.Items.Add(" add users ~user")
                argumentBox.Items.Add(" noinherit") 'Does not inherit defaults from parent OU
            Case Else
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
                Box2Text = "Box 2 Error"
        End Select
    End Sub
    Private Sub DevicePropertyBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DevicePropertyBox.SelectedIndexChanged
        Box2Text = DevicePropertyBox.SelectedItem()
        DevicesLabel.Items.Clear()
        argumentLabel.Clear()

        Select Case Box2Text
            Case "Move Devices to OU"
                DevicesLabel.Items.Add("serial")
                DevicesLabel.Items.Add("ou")
                argumentLabel.AppendText(" cros query " + quote + "id:~~serial~~" + quote + " ou ~ou")
            Case "Deprovision Devices"
                DevicesLabel.Items.Add("serial")
                argumentLabel.AppendText(" cros query:id:~~serial~~ action deprovision_same_model_replace acknowledge_device_touch_requirement")
            Case "Add Asset Tag"
                DevicesLabel.Items.Add("serial")
                DevicesLabel.Items.Add("assetid")
                argumentLabel.AppendText(" cros query " + quote + "id:~~serial~~" + quote + " assetid ~assetid")
            Case Else
                MessageBox.Show("Device property box error.")
        End Select

    End Sub
    Private Sub PrintSecondPropertyBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrintSecondPropertyBox.SelectedIndexChanged

        Box2Text = PrintSecondPropertyBox.SelectedItem()

        Select Case Box2Text
            Case "All Users"
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
                Box2Text = " users"
                argumentBox.Items.Add(" todrive") 'prints output directly to google drive of admin account, needs to be first
                argumentBox.Items.Add(" firstname")
                argumentBox.Items.Add(" lastname")
                argumentBox.Items.Add(" licenses")
                argumentBox.Items.Add(" domain")
                argumentBox.Items.Add(" fullname")
                argumentBox.Items.Add(" suspended")
                argumentBox.Items.Add(" ou")
                argumentBox.Items.Add(" changepassword")
                argumentBox.Items.Add(" admin")
                argumentBox.Items.Add(" gal")
                argumentBox.Items.Add(" creationtime")
                argumentBox.Items.Add(" lastlogintime")
                'argumentBox.Items.Add(" groups") 'This is disabled because groups are retrieved 1 at a time per user, it takes days for large domains
                argumentBox.Items.Add(" aliases")
                argumentBox.Items.Add(" deleted_only")
            Case "All Groups"
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
                Box2Text = " groups"
                argumentBox.Items.Add(" todrive") 'prints output directly to google drive of admin account, needs to be first
                argumentBox.Items.Add(" name")
                argumentBox.Items.Add(" description")
                argumentBox.Items.Add(" members")
                argumentBox.Items.Add(" owners")
                argumentBox.Items.Add(" managers")
                argumentBox.Items.Add(" aliases")
                argumentBox.Items.Add(" admincreated")
                argumentBox.Items.Add(" id")
                argumentBox.Items.Add(" settings")
            Case ("All OUs")
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
                Box2Text = " orgs"
                argumentBox.Items.Add(" todrive") 'prints output directly to google drive of admin account, needs to be first
                argumentBox.Items.Add(" name")
                argumentBox.Items.Add(" description")
                argumentBox.Items.Add(" parent")
                argumentBox.Items.Add(" inherit")
            Case Else
                Box2Text = "Print Box 2 Error"
                argumentBox.Items.Clear()
                argumentBox.SelectionMode = SelectionMode.MultiExtended
        End Select
    End Sub
    Private Sub customCmdButton_Click(sender As Object, e As EventArgs) Handles customCmdButton.Click
        'This button is only disabled because I dont want to put the effort in to get all the commands listed, all the code for the button is complete though
        Me.ShowInTaskbar = False 'otherwise, hide the main window and show the config creation one
        Me.Opacity = 0
        customGamCommand.ShowDialog()

    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub csvCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles csvCheckBox.CheckedChanged

        If csvCheckBox.Checked = True Then
            outPutToFileDialog.InitialDirectory = "C:\Users\" + uName + "\Desktop" 'Controls the dialog box that opens when selecting CSV file
            outPutToFileDialog.Title = "Select output file location, must be .csv (default)."
            outPutToFileDialog.Filter = "|*.csv|All Files|*.*"
            outPutToFileDialog.ShowDialog()
            OutputFile = " > " + quote + outPutToFileDialog.FileName + quote 'Write teh path to the csv as a string
        Else
            OutputFile = ""
        End If

    End Sub
    Private Sub DeleteConfigFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteConfigFileToolStripMenuItem.Click
        If File.Exists(iniPath) Then 'If there is a config file, delete it
            System.IO.File.Delete(iniPath)
            MessageBox.Show("Removed")
            Me.Close()
        Else 'Otherwise show this message below
            MessageBox.Show("No config found")
        End If
    End Sub
    Private Sub CopyCommandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCommandToolStripMenuItem.Click
        Clipboard.SetText(FinalGamString)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles argboxcontrollabel.Click
        '16777215 is the backcolor for transparency
    End Sub
    Private Sub DisableNoupdateCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableNoupdateCheckToolStripMenuItem.Click
        Dim SectionName As String = "GAM Path"
        Dim noupdatecheckstring As String = "Updatetxt"
        Dim valuetxt As String = SGAMINI.IniReadValue(SectionName, noupdatecheckstring)

        If valuetxt = "" Then
            valuetxt = "1"
        ElseIf valuetxt = "1" Then
            valuetxt = ""
        End If

        WritePrivateProfileStringW(SectionName, noupdatecheckstring, valuetxt, iniPath)

    End Sub
    Private Sub DisableWarnOnDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableWarnOnDeleteToolStripMenuItem.Click
        Dim SectionName As String = "GAM Path"
        Dim nodelwarnstring As String = "NoDelWarn"
        Dim valuedel As String = SGAMINI.IniReadValue(SectionName, nodelwarnstring)

        If valuedel = "" Then
            valuedel = "1"
        ElseIf valuedel = "1" Then
            valuedel = ""
        End If

        WritePrivateProfileStringW(SectionName, nodelwarnstring, valuedel, iniPath)

    End Sub
    Private Sub ToggleClearCsvPathAfterExecuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleClearCsvPathAfterExecuteToolStripMenuItem.Click
        Dim SectionName As String = "GAM Path"
        Dim NoDelCsvPath As String = "Keepcsv"
        Dim clearcsv As String = SGAMINI.IniReadValue(SectionName, NoDelCsvPath)

        If clearcsv = "" Then
            clearcsv = "1"
        ElseIf clearcsv = "1" Then
            clearcsv = ""
        End If

        WritePrivateProfileStringW(SectionName, NoDelCsvPath, clearcsv, iniPath)

    End Sub
    Private Sub ToggleStartupCheckForAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleStartupCheckForAdminToolStripMenuItem.Click
        Dim SectionName As String = "GAM Path"
        Dim NoAdminCheck As String = "Noadmincheck"
        Dim noadm As String = SGAMINI.IniReadValue(SectionName, NoAdminCheck)

        If noadm = "" Then
            noadm = "1"
        ElseIf noadm = "1" Then
            noadm = ""
        End If

        WritePrivateProfileStringW(SectionName, NoAdminCheck, noadm, iniPath)

    End Sub
    Private Sub AdvancedOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedOptionsToolStripMenuItem.Click
        Dim SectionName As String = "GAM Path"
        Dim advwarn As String = "AdvWarn"
        Dim noadm As String = SGAMINI.IniReadValue(SectionName, advwarn)
        Dim noupdatecheckstring As String = "Updatetxt"
        Dim nodelwarnstring As String = "NoDelWarn"
        Dim NoDelCsvPath As String = "Keepcsv"
        Dim clearcsv As String = SGAMINI.IniReadValue(SectionName, NoDelCsvPath)
        Dim NoAdminCheck As String = "Noadmincheck"
        Dim Advgam As String = "Advgam"
        Dim admchk As String = SGAMINI.IniReadValue(SectionName, NoAdminCheck)
        Dim valuedel As String = SGAMINI.IniReadValue(SectionName, nodelwarnstring)
        Dim valuetxt As String = SGAMINI.IniReadValue(SectionName, noupdatecheckstring)
        Dim advgamini As String = SGAMINI.IniReadValue(SectionName, Advgam)

        If noadm = "" Then
            AdvancedOptionsToolStripMenuItem.HideDropDown()
            WritePrivateProfileStringW(SectionName, advwarn, "1", iniPath)
            MessageBox.Show("These options are set as default for a reason, disable at your own risk.", "Warning")
        End If

        If valuetxt = "" Then
            DisableNoupdateCheckToolStripMenuItem.Checked = False
        ElseIf valuetxt = "1" Then
            DisableNoupdateCheckToolStripMenuItem.Checked = True
        End If

        If valuedel = "" Then
            DisableWarnOnDeleteToolStripMenuItem.Checked = False
        ElseIf valuedel = "1" Then
            DisableWarnOnDeleteToolStripMenuItem.Checked = True
        End If

        If clearcsv = "" Then
            ToggleClearCsvPathAfterExecuteToolStripMenuItem.Checked = False
        ElseIf clearcsv = "1" Then
            ToggleClearCsvPathAfterExecuteToolStripMenuItem.Checked = True
        End If

        If admchk = "" Then
            ToggleStartupCheckForAdminToolStripMenuItem.Checked = False
        ElseIf admchk = "1" Then
            ToggleStartupCheckForAdminToolStripMenuItem.Checked = True
        End If

    End Sub
End Class
