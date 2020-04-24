<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customGamCommand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customGamCommand))
        Me.cmdBox1 = New System.Windows.Forms.ComboBox()
        Me.cmdBox2 = New System.Windows.Forms.ComboBox()
        Me.cmdBox4 = New System.Windows.Forms.ComboBox()
        Me.cmdBox3 = New System.Windows.Forms.ComboBox()
        Me.execButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBox1
        '
        Me.cmdBox1.FormattingEnabled = True
        Me.cmdBox1.Items.AddRange(New Object() {" gam create", " gam update", " gam delete", " gam print"})
        Me.cmdBox1.Location = New System.Drawing.Point(12, 12)
        Me.cmdBox1.Name = "cmdBox1"
        Me.cmdBox1.Size = New System.Drawing.Size(121, 21)
        Me.cmdBox1.TabIndex = 0
        Me.cmdBox1.Text = "SELECT"
        '
        'cmdBox2
        '
        Me.cmdBox2.FormattingEnabled = True
        Me.cmdBox2.Location = New System.Drawing.Point(12, 39)
        Me.cmdBox2.Name = "cmdBox2"
        Me.cmdBox2.Size = New System.Drawing.Size(121, 21)
        Me.cmdBox2.TabIndex = 1
        Me.cmdBox2.Text = "SELECT"
        '
        'cmdBox4
        '
        Me.cmdBox4.FormattingEnabled = True
        Me.cmdBox4.Location = New System.Drawing.Point(12, 93)
        Me.cmdBox4.Name = "cmdBox4"
        Me.cmdBox4.Size = New System.Drawing.Size(121, 21)
        Me.cmdBox4.TabIndex = 3
        Me.cmdBox4.Text = "NONE"
        '
        'cmdBox3
        '
        Me.cmdBox3.FormattingEnabled = True
        Me.cmdBox3.Location = New System.Drawing.Point(12, 66)
        Me.cmdBox3.Name = "cmdBox3"
        Me.cmdBox3.Size = New System.Drawing.Size(121, 21)
        Me.cmdBox3.TabIndex = 2
        Me.cmdBox3.Text = "NONE"
        '
        'execButton
        '
        Me.execButton.Location = New System.Drawing.Point(33, 120)
        Me.execButton.Name = "execButton"
        Me.execButton.Size = New System.Drawing.Size(75, 23)
        Me.execButton.TabIndex = 4
        Me.execButton.Text = "Confirm"
        Me.execButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(33, 149)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'customGamCommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(156, 192)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.execButton)
        Me.Controls.Add(Me.cmdBox4)
        Me.Controls.Add(Me.cmdBox3)
        Me.Controls.Add(Me.cmdBox2)
        Me.Controls.Add(Me.cmdBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(172, 231)
        Me.MinimumSize = New System.Drawing.Size(172, 231)
        Me.Name = "customGamCommand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdBox1 As ComboBox
    Friend WithEvents cmdBox2 As ComboBox
    Friend WithEvents cmdBox4 As ComboBox
    Friend WithEvents cmdBox3 As ComboBox
    Friend WithEvents execButton As Button
    Friend WithEvents exitButton As Button
End Class
