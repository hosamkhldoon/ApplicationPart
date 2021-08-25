<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.LoginNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTextBox3 = New System.Windows.Forms.TextBox()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.SaveButton2 = New System.Windows.Forms.Button()
        Me.updateButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login Name"
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox1.Location = New System.Drawing.Point(124, 20)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(139, 20)
        Me.NameTextBox1.TabIndex = 2
        '
        'LoginNameTextBox2
        '
        Me.LoginNameTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginNameTextBox2.Location = New System.Drawing.Point(124, 60)
        Me.LoginNameTextBox2.Name = "LoginNameTextBox2"
        Me.LoginNameTextBox2.Size = New System.Drawing.Size(139, 20)
        Me.LoginNameTextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'PasswordTextBox3
        '
        Me.PasswordTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTextBox3.Location = New System.Drawing.Point(124, 95)
        Me.PasswordTextBox3.Name = "PasswordTextBox3"
        Me.PasswordTextBox3.Size = New System.Drawing.Size(139, 20)
        Me.PasswordTextBox3.TabIndex = 5
        '
        'CancelButton1
        '
        Me.CancelButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton1.Location = New System.Drawing.Point(205, 152)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton1.TabIndex = 6
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
        '
        'SaveButton2
        '
        Me.SaveButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton2.Location = New System.Drawing.Point(124, 152)
        Me.SaveButton2.Name = "SaveButton2"
        Me.SaveButton2.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton2.TabIndex = 7
        Me.SaveButton2.Text = "Save"
        Me.SaveButton2.UseVisualStyleBackColor = True
        '
        'updateButton1
        '
        Me.updateButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateButton1.Location = New System.Drawing.Point(124, 150)
        Me.updateButton1.Name = "updateButton1"
        Me.updateButton1.Size = New System.Drawing.Size(75, 23)
        Me.updateButton1.TabIndex = 8
        Me.updateButton1.Text = "Update"
        Me.updateButton1.UseVisualStyleBackColor = True
        Me.updateButton1.Visible = False
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 185)
        Me.Controls.Add(Me.updateButton1)
        Me.Controls.Add(Me.SaveButton2)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.PasswordTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LoginNameTextBox2)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewUser"
        Me.Text = "New_User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents LoginNameTextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordTextBox3 As TextBox
    Friend WithEvents CancelButton1 As Button
    Friend WithEvents SaveButton2 As Button
    Friend WithEvents updateButton1 As Button
End Class
