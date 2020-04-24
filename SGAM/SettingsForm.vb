Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Collections

Public Class SettingsForm
    <DllImportAttribute("kernel32.dll", EntryPoint:="WritePrivateProfileStringW")> _
    Private Shared Function WritePrivateProfileStringW(<InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpSecName As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpKeyName As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpString As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpFileName As String) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ssGamExePath.FileOk

    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim uName As String = Environment.UserName
        'Dim IniFileName As String = "C:\users\" & uName & "\AppData\Local\Temp\SGAM.ini"
        Dim IniFileName As String = "C:\Program Files (x86)\SGAM\SGAM.ini"
        Dim SectionName As String = "GAM Path"
        Dim sNullStr As String = "Directory"
        Dim GamSelectText As String = "Please choose the location of your GAM.exe"
        Dim CString As String = "CustomString"
        Dim noupdatecheckstring As String = "Updatetxt"
        Dim nodelwarnstring As String = "NoDelWarn"
        Dim NoDelCsvPath As String = "Keepcsv"
        Dim NoAdminCheck As String = "Noadmincheck"
        Dim advwarn As String = "AdvWarn"
        Dim blank As String = ""
        My.Computer.FileSystem.CreateDirectory("C:\Program Files (x86)\SGAM")

        MessageBox.Show(GamSelectText)

        'SGAMForm.Close()
        ssGamExePath.InitialDirectory = "C:\"
        ssGamExePath.Title = "Locate your GAM.exe"
        ssGamExePath.Filter = "gam.exe|*.exe|All Files|*.*"
        ssGamExePath.ShowDialog()

        Dim KeyName As String = ssGamExePath.FileName

        WritePrivateProfileStringW(SectionName, sNullStr, KeyName, IniFileName)
        WritePrivateProfileStringW(SectionName, CString, blank, IniFileName)
        WritePrivateProfileStringW(SectionName, noupdatecheckstring, blank, IniFileName)
        WritePrivateProfileStringW(SectionName, nodelwarnstring, blank, IniFileName)
        WritePrivateProfileStringW(SectionName, NoDelCsvPath, blank, IniFileName)
        WritePrivateProfileStringW(SectionName, NoAdminCheck, blank, IniFileName)
        WritePrivateProfileStringW(SectionName, advwarn, blank, IniFileName)

        Me.Close()
        SGAMForm.Opacity = 100
        SGAMForm.ShowInTaskbar = True

    End Sub
End Class