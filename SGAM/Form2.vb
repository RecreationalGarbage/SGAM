Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Collections
Public Class customGamCommand
    <DllImportAttribute("kernel32.dll", EntryPoint:="WritePrivateProfileStringW")>
    Private Shared Function WritePrivateProfileStringW(<InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpSecName As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpKeyName As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpString As String, <InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpFileName As String) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
        SGAMForm.Opacity = 100
        SGAMForm.ShowInTaskbar = True
        SGAMForm.BringToFront()
    End Sub

    Private Sub cmdBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdBox1.SelectedIndexChanged

        Dim box1Text As String = cmdBox1.SelectedItem

        Select Case box1Text
            Case " gam create"
                cmdBox2.Items.Clear()
                cmdBox2.Items.Add(" user ~user")
                cmdBox2.Items.Add(" group ~group")
            Case " gam update"
                cmdBox2.Items.Clear()
                cmdBox2.Items.Add(" user ~user")
                cmdBox2.Items.Add(" group ~group")
            Case " gam delete"
                cmdBox2.Items.Clear()
                cmdBox2.Items.Add(" user ~user")
                cmdBox2.Items.Add(" group ~group")
            Case " gam print"
                cmdBox2.Items.Clear()
                cmdBox2.Items.Add(" user ~user")
                cmdBox2.Items.Add(" group ~group")
                cmdBox2.Items.Add(" group-members")
            Case Else
        End Select
    End Sub

    Private Sub cmdBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdBox2.SelectedIndexChanged

        Dim box2Text As String = cmdBox2.SelectedItem

        Select Case box2Text
            Case (" user ~user")
                cmdBox3.Items.Clear()
                cmdBox3.Items.Add("NONE")
                cmdBox3.Items.Add("Test")
            Case (" group ~group")
                cmdBox3.Items.Clear()
                cmdBox3.Items.Add("NONE")
                cmdBox3.Items.Add("Test23")
                cmdBox3.Items.Add(" remove")
        End Select

    End Sub
    Private Sub cmdBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdBox3.SelectedIndexChanged
        Dim box3Text As String = cmdBox3.SelectedItem

        Select Case box3Text
            Case ("NONE")
                cmdBox4.Items.Clear()
                cmdBox4.Items.Add("NONE")
                cmdBox4.Items.Add("Test2")
            Case ("Test")
                cmdBox4.Items.Clear()
                cmdBox4.Items.Add("NONE")
                cmdBox4.Items.Add("Test2")
            Case (" remove")
                cmdBox4.Items.Add(" user ~user")
        End Select
    End Sub

    Private Sub execButton_Click(sender As Object, e As EventArgs) Handles execButton.Click

        Dim Box1String As String = cmdBox1.SelectedItem
        Dim Box2String As String = cmdBox2.SelectedItem
        Dim Box3String As String = ""
        Dim Box4String As String = ""

        'If Statment for box 3 to see if its null or NONE
        If cmdBox3.SelectedItem = ("NONE") Then
            Box3String = ""
        ElseIf cmdBox3.SelectedItem = ("") Then
            Box3String = ""
        Else
            Box3String = cmdBox3.SelectedItem.ToString
        End If

        If cmdBox4.SelectedItem = ("NONE") Then
            Box4String = ""
        ElseIf cmdBox4.SelectedItem = ("") Then
            Box4String = ""
        Else
            Box4String = cmdBox4.SelectedItem.ToString
        End If


        Dim customStringFinal As String = (Box1String + Box2String + Box3String + Box4String)

        'Dim uName As String = Environment.UserName
        Dim IniFileName As String = "C:\Program Files (x86)\SGAM\SGAM.ini"
        Dim SectionName As String = "GAM Path"
        Dim CString As String = "CustomString"

        WritePrivateProfileStringW(SectionName, CString, customStringFinal, IniFileName)

        Me.Close()
        SGAMForm.Opacity = 100
        SGAMForm.ShowInTaskbar = True
        SGAMForm.BringToFront()

        'MessageBox.Show(customStringFinal)

    End Sub

    Private Sub customGamCommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class