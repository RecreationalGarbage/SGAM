<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ststBut = New System.Windows.Forms.Button()
        Me.ssGamExePath = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close2 Open 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ststBut
        '
        Me.ststBut.Location = New System.Drawing.Point(121, 180)
        Me.ststBut.Name = "ststBut"
        Me.ststBut.Size = New System.Drawing.Size(75, 23)
        Me.ststBut.TabIndex = 1
        Me.ststBut.Text = "TEST"
        Me.ststBut.UseVisualStyleBackColor = True
        '
        'ssGamExePath
        '
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ststBut)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SettingsForm"
        Me.Text = "SettingsForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ststBut As System.Windows.Forms.Button
    Friend WithEvents ssGamExePath As System.Windows.Forms.OpenFileDialog
End Class
