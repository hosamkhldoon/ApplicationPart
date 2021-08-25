<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Me.SaveButton2 = New System.Windows.Forms.Button()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.LoginNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SaveButton2
        '
        Me.SaveButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton2.Location = New System.Drawing.Point(162, 175)
        Me.SaveButton2.Name = "SaveButton2"
        Me.SaveButton2.Size = New System.Drawing.Size(76, 26)
        Me.SaveButton2.TabIndex = 13
        Me.SaveButton2.Text = "Save"
        Me.SaveButton2.UseVisualStyleBackColor = True
        '
        'CancelButton1
        '
        Me.CancelButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton1.Location = New System.Drawing.Point(243, 175)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(76, 26)
        Me.CancelButton1.TabIndex = 12
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
        '
        'LoginNameTextBox2
        '
        Me.LoginNameTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginNameTextBox2.Location = New System.Drawing.Point(132, 106)
        Me.LoginNameTextBox2.Name = "LoginNameTextBox2"
        Me.LoginNameTextBox2.Size = New System.Drawing.Size(193, 20)
        Me.LoginNameTextBox2.TabIndex = 11
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox1.Location = New System.Drawing.Point(132, 49)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(193, 20)
        Me.NameTextBox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Login Name"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'EditButton1
        '
        Me.EditButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditButton1.Location = New System.Drawing.Point(162, 175)
        Me.EditButton1.Name = "EditButton1"
        Me.EditButton1.Size = New System.Drawing.Size(75, 23)
        Me.EditButton1.TabIndex = 14
        Me.EditButton1.Text = "Edit"
        Me.EditButton1.UseVisualStyleBackColor = True
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 209)
        Me.Controls.Add(Me.EditButton1)
        Me.Controls.Add(Me.SaveButton2)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.LoginNameTextBox2)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Account"
        Me.Text = "Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveButton2 As Button
    Friend WithEvents CancelButton1 As Button
    Friend WithEvents LoginNameTextBox2 As TextBox
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EditButton1 As Button
End Class
