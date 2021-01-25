<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quickdevou
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
        Me.quickdevouserialbox = New System.Windows.Forms.TextBox()
        Me.enterseriallabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.quickoubox = New System.Windows.Forms.ListBox()
        Me.selectoulabel = New System.Windows.Forms.Label()
        Me.seriallabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'quickdevouserialbox
        '
        Me.quickdevouserialbox.Location = New System.Drawing.Point(15, 28)
        Me.quickdevouserialbox.Name = "quickdevouserialbox"
        Me.quickdevouserialbox.Size = New System.Drawing.Size(191, 20)
        Me.quickdevouserialbox.TabIndex = 0
        '
        'enterseriallabel
        '
        Me.enterseriallabel.AutoSize = True
        Me.enterseriallabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterseriallabel.Location = New System.Drawing.Point(9, 9)
        Me.enterseriallabel.Name = "enterseriallabel"
        Me.enterseriallabel.Size = New System.Drawing.Size(245, 16)
        Me.enterseriallabel.TabIndex = 1
        Me.enterseriallabel.Text = "Enter your devices serial number below:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'quickoubox
        '
        Me.quickoubox.FormattingEnabled = True
        Me.quickoubox.Location = New System.Drawing.Point(12, 62)
        Me.quickoubox.Name = "quickoubox"
        Me.quickoubox.Size = New System.Drawing.Size(291, 212)
        Me.quickoubox.TabIndex = 4
        Me.quickoubox.Visible = False
        '
        'selectoulabel
        '
        Me.selectoulabel.AutoSize = True
        Me.selectoulabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectoulabel.Location = New System.Drawing.Point(12, 43)
        Me.selectoulabel.Name = "selectoulabel"
        Me.selectoulabel.Size = New System.Drawing.Size(148, 16)
        Me.selectoulabel.TabIndex = 5
        Me.selectoulabel.Text = "Now select the new OU:"
        Me.selectoulabel.Visible = False
        '
        'seriallabel
        '
        Me.seriallabel.AutoSize = True
        Me.seriallabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seriallabel.Location = New System.Drawing.Point(12, 11)
        Me.seriallabel.Name = "seriallabel"
        Me.seriallabel.Size = New System.Drawing.Size(83, 24)
        Me.seriallabel.TabIndex = 6
        Me.seriallabel.Text = "SELECT"
        Me.seriallabel.Visible = False
        '
        'quickdevou
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 314)
        Me.Controls.Add(Me.seriallabel)
        Me.Controls.Add(Me.selectoulabel)
        Me.Controls.Add(Me.quickoubox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.enterseriallabel)
        Me.Controls.Add(Me.quickdevouserialbox)
        Me.Name = "quickdevou"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "quickdevou"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents quickdevouserialbox As TextBox
    Friend WithEvents enterseriallabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents quickoubox As ListBox
    Friend WithEvents selectoulabel As Label
    Friend WithEvents seriallabel As Label
End Class
