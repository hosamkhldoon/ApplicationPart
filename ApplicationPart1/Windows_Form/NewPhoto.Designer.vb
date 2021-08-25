<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPhoto
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.FileDescriptionTabPage1 = New System.Windows.Forms.TabPage()
        Me.CancelButton2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SaveButton1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BodyTextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox2 = New System.Windows.Forms.TextBox()
        Me.TitleTextBox1 = New System.Windows.Forms.TextBox()
        Me.ImageTabPage2 = New System.Windows.Forms.TabPage()
        Me.PathLabel1 = New System.Windows.Forms.Label()
        Me.BrowseButton1 = New System.Windows.Forms.Button()
        Me.ImagePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.FileDescriptionTabPage1.SuspendLayout()
        Me.ImageTabPage2.SuspendLayout()
        CType(Me.ImagePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.FileDescriptionTabPage1)
        Me.TabControl1.Controls.Add(Me.ImageTabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(509, 499)
        Me.TabControl1.TabIndex = 0
        '
        'FileDescriptionTabPage1
        '
        Me.FileDescriptionTabPage1.Controls.Add(Me.CancelButton2)
        Me.FileDescriptionTabPage1.Controls.Add(Me.Label6)
        Me.FileDescriptionTabPage1.Controls.Add(Me.SaveButton1)
        Me.FileDescriptionTabPage1.Controls.Add(Me.Label5)
        Me.FileDescriptionTabPage1.Controls.Add(Me.BodyTextBox3)
        Me.FileDescriptionTabPage1.Controls.Add(Me.Label4)
        Me.FileDescriptionTabPage1.Controls.Add(Me.DescriptionTextBox2)
        Me.FileDescriptionTabPage1.Controls.Add(Me.TitleTextBox1)
        Me.FileDescriptionTabPage1.Location = New System.Drawing.Point(4, 22)
        Me.FileDescriptionTabPage1.Name = "FileDescriptionTabPage1"
        Me.FileDescriptionTabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.FileDescriptionTabPage1.Size = New System.Drawing.Size(501, 473)
        Me.FileDescriptionTabPage1.TabIndex = 0
        Me.FileDescriptionTabPage1.Text = "TabPage1"
        Me.FileDescriptionTabPage1.UseVisualStyleBackColor = True
        '
        'CancelButton2
        '
        Me.CancelButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton2.Location = New System.Drawing.Point(404, 312)
        Me.CancelButton2.Name = "CancelButton2"
        Me.CancelButton2.Size = New System.Drawing.Size(76, 26)
        Me.CancelButton2.TabIndex = 27
        Me.CancelButton2.Text = "Cancel"
        Me.CancelButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Title"
        '
        'SaveButton1
        '
        Me.SaveButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton1.Location = New System.Drawing.Point(323, 312)
        Me.SaveButton1.Name = "SaveButton1"
        Me.SaveButton1.Size = New System.Drawing.Size(76, 26)
        Me.SaveButton1.TabIndex = 26
        Me.SaveButton1.Text = "Save"
        Me.SaveButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Description"
        '
        'BodyTextBox3
        '
        Me.BodyTextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BodyTextBox3.Location = New System.Drawing.Point(96, 58)
        Me.BodyTextBox3.Multiline = True
        Me.BodyTextBox3.Name = "BodyTextBox3"
        Me.BodyTextBox3.Size = New System.Drawing.Size(387, 249)
        Me.BodyTextBox3.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Body"
        '
        'DescriptionTextBox2
        '
        Me.DescriptionTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionTextBox2.Location = New System.Drawing.Point(96, 32)
        Me.DescriptionTextBox2.Name = "DescriptionTextBox2"
        Me.DescriptionTextBox2.Size = New System.Drawing.Size(387, 20)
        Me.DescriptionTextBox2.TabIndex = 24
        '
        'TitleTextBox1
        '
        Me.TitleTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox1.Location = New System.Drawing.Point(96, 6)
        Me.TitleTextBox1.Name = "TitleTextBox1"
        Me.TitleTextBox1.Size = New System.Drawing.Size(387, 20)
        Me.TitleTextBox1.TabIndex = 23
        '
        'ImageTabPage2
        '
        Me.ImageTabPage2.Controls.Add(Me.PathLabel1)
        Me.ImageTabPage2.Controls.Add(Me.BrowseButton1)
        Me.ImageTabPage2.Controls.Add(Me.ImagePictureBox1)
        Me.ImageTabPage2.Location = New System.Drawing.Point(4, 22)
        Me.ImageTabPage2.Name = "ImageTabPage2"
        Me.ImageTabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.ImageTabPage2.Size = New System.Drawing.Size(501, 473)
        Me.ImageTabPage2.TabIndex = 1
        Me.ImageTabPage2.Text = "TabPage2"
        Me.ImageTabPage2.UseVisualStyleBackColor = True
        '
        'PathLabel1
        '
        Me.PathLabel1.AutoSize = True
        Me.PathLabel1.Location = New System.Drawing.Point(107, 6)
        Me.PathLabel1.Name = "PathLabel1"
        Me.PathLabel1.Size = New System.Drawing.Size(0, 13)
        Me.PathLabel1.TabIndex = 6
        '
        'BrowseButton1
        '
        Me.BrowseButton1.Location = New System.Drawing.Point(6, 6)
        Me.BrowseButton1.Name = "BrowseButton1"
        Me.BrowseButton1.Size = New System.Drawing.Size(79, 23)
        Me.BrowseButton1.TabIndex = 5
        Me.BrowseButton1.Text = "Browse"
        Me.BrowseButton1.UseVisualStyleBackColor = True
        '
        'ImagePictureBox1
        '
        Me.ImagePictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagePictureBox1.Location = New System.Drawing.Point(-4, 35)
        Me.ImagePictureBox1.Name = "ImagePictureBox1"
        Me.ImagePictureBox1.Size = New System.Drawing.Size(499, 305)
        Me.ImagePictureBox1.TabIndex = 4
        Me.ImagePictureBox1.TabStop = False
        '
        'NewPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 369)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "NewPhoto"
        Me.Text = "New_Photo"
        Me.TabControl1.ResumeLayout(False)
        Me.FileDescriptionTabPage1.ResumeLayout(False)
        Me.FileDescriptionTabPage1.PerformLayout()
        Me.ImageTabPage2.ResumeLayout(False)
        Me.ImageTabPage2.PerformLayout()
        CType(Me.ImagePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FileDescriptionTabPage1 As TabPage
    Friend WithEvents ImageTabPage2 As TabPage
    Friend WithEvents CancelButton2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SaveButton1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BodyTextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DescriptionTextBox2 As TextBox
    Friend WithEvents TitleTextBox1 As TextBox
    Friend WithEvents PathLabel1 As Label
    Friend WithEvents BrowseButton1 As Button
    Friend WithEvents ImagePictureBox1 As PictureBox
End Class
