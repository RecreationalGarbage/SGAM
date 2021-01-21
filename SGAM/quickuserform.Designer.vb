<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quickuserform
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.userbox = New System.Windows.Forms.TextBox()
        Me.passbox = New System.Windows.Forms.TextBox()
        Me.oubox = New System.Windows.Forms.TextBox()
        Me.quickuserbut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.firstnamebox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lastnamebox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(294, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'userbox
        '
        Me.userbox.Location = New System.Drawing.Point(37, 32)
        Me.userbox.Name = "userbox"
        Me.userbox.Size = New System.Drawing.Size(154, 20)
        Me.userbox.TabIndex = 1
        '
        'passbox
        '
        Me.passbox.Location = New System.Drawing.Point(37, 89)
        Me.passbox.Name = "passbox"
        Me.passbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(79)
        Me.passbox.Size = New System.Drawing.Size(154, 20)
        Me.passbox.TabIndex = 2
        '
        'oubox
        '
        Me.oubox.Location = New System.Drawing.Point(36, 146)
        Me.oubox.Name = "oubox"
        Me.oubox.Size = New System.Drawing.Size(154, 20)
        Me.oubox.TabIndex = 3
        '
        'quickuserbut
        '
        Me.quickuserbut.Location = New System.Drawing.Point(77, 277)
        Me.quickuserbut.Name = "quickuserbut"
        Me.quickuserbut.Size = New System.Drawing.Size(75, 23)
        Me.quickuserbut.TabIndex = 4
        Me.quickuserbut.Text = "Done"
        Me.quickuserbut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter one email address below"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter password below"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter OU below"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "EnterFirstname below"
        '
        'firstnamebox
        '
        Me.firstnamebox.Location = New System.Drawing.Point(37, 203)
        Me.firstnamebox.Name = "firstnamebox"
        Me.firstnamebox.Size = New System.Drawing.Size(154, 20)
        Me.firstnamebox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "EnterLastname below"
        '
        'lastnamebox
        '
        Me.lastnamebox.Location = New System.Drawing.Point(37, 245)
        Me.lastnamebox.Name = "lastnamebox"
        Me.lastnamebox.Size = New System.Drawing.Size(154, 20)
        Me.lastnamebox.TabIndex = 10
        '
        'quickuserform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 312)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lastnamebox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.firstnamebox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.quickuserbut)
        Me.Controls.Add(Me.oubox)
        Me.Controls.Add(Me.passbox)
        Me.Controls.Add(Me.userbox)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "quickuserform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SGAM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents userbox As TextBox
    Friend WithEvents passbox As TextBox
    Friend WithEvents oubox As TextBox
    Friend WithEvents quickuserbut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents firstnamebox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lastnamebox As TextBox
End Class
