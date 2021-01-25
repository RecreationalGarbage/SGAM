<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quickpwreset
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
        Me.pwresetuserbox = New System.Windows.Forms.TextBox()
        Me.pwresetpwbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'pwresetuserbox
        '
        Me.pwresetuserbox.Location = New System.Drawing.Point(28, 37)
        Me.pwresetuserbox.Name = "pwresetuserbox"
        Me.pwresetuserbox.Size = New System.Drawing.Size(194, 20)
        Me.pwresetuserbox.TabIndex = 0
        '
        'pwresetpwbox
        '
        Me.pwresetpwbox.Location = New System.Drawing.Point(28, 101)
        Me.pwresetpwbox.Name = "pwresetpwbox"
        Me.pwresetpwbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(79)
        Me.pwresetpwbox.Size = New System.Drawing.Size(194, 20)
        Me.pwresetpwbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Password:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(184, 127)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Show?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'quickpwreset
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 177)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pwresetpwbox)
        Me.Controls.Add(Me.pwresetuserbox)
        Me.MaximumSize = New System.Drawing.Size(271, 216)
        Me.MinimumSize = New System.Drawing.Size(271, 216)
        Me.Name = "quickpwreset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SGAM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pwresetuserbox As TextBox
    Friend WithEvents pwresetpwbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
