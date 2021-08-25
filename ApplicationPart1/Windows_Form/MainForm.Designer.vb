<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Me.NewsPhotoDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.titleLabel1 = New System.Windows.Forms.Label()
        Me.dateLabel2 = New System.Windows.Forms.Label()
        Me.categoryLabel3 = New System.Windows.Forms.Label()
        Me.titleTextBox1 = New System.Windows.Forms.TextBox()
        Me.CreationdateTextBox3 = New System.Windows.Forms.TextBox()
        Me.categoryComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.prviewTabPage1 = New System.Windows.Forms.TabPage()
        Me.previewTextBox1 = New System.Windows.Forms.TextBox()
        Me.ImageTabPage2 = New System.Windows.Forms.TabPage()
        Me.imagePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.NewsPhotoDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.prviewTabPage1.SuspendLayout()
        Me.ImageTabPage2.SuspendLayout()
        CType(Me.imagePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewsPhotoDataGridView1
        '
        Me.NewsPhotoDataGridView1.AllowUserToAddRows = False
        Me.NewsPhotoDataGridView1.AllowUserToDeleteRows = False
        Me.NewsPhotoDataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewsPhotoDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.NewsPhotoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewsPhotoDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.NewsPhotoDataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.NewsPhotoDataGridView1.Name = "NewsPhotoDataGridView1"
        Me.NewsPhotoDataGridView1.ReadOnly = True
        Me.NewsPhotoDataGridView1.Size = New System.Drawing.Size(561, 212)
        Me.NewsPhotoDataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Titl"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Creation Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShowToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.NewsToolStripMenuItem, Me.PhotoToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'PhotoToolStripMenuItem
        '
        Me.PhotoToolStripMenuItem.Name = "PhotoToolStripMenuItem"
        Me.PhotoToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.PhotoToolStripMenuItem.Text = "Photo"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem})
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyAccountToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'MyAccountToolStripMenuItem
        '
        Me.MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem"
        Me.MyAccountToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MyAccountToolStripMenuItem.Text = "My Account"
        '
        'titleLabel1
        '
        Me.titleLabel1.AutoSize = True
        Me.titleLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel1.Location = New System.Drawing.Point(12, 262)
        Me.titleLabel1.Name = "titleLabel1"
        Me.titleLabel1.Size = New System.Drawing.Size(39, 16)
        Me.titleLabel1.TabIndex = 2
        Me.titleLabel1.Text = "Title"
        Me.titleLabel1.Visible = False
        '
        'dateLabel2
        '
        Me.dateLabel2.AutoSize = True
        Me.dateLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel2.Location = New System.Drawing.Point(12, 289)
        Me.dateLabel2.Name = "dateLabel2"
        Me.dateLabel2.Size = New System.Drawing.Size(101, 16)
        Me.dateLabel2.TabIndex = 3
        Me.dateLabel2.Text = "Creation date"
        Me.dateLabel2.Visible = False
        '
        'categoryLabel3
        '
        Me.categoryLabel3.AutoSize = True
        Me.categoryLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryLabel3.Location = New System.Drawing.Point(12, 319)
        Me.categoryLabel3.Name = "categoryLabel3"
        Me.categoryLabel3.Size = New System.Drawing.Size(71, 16)
        Me.categoryLabel3.TabIndex = 4
        Me.categoryLabel3.Text = "Category"
        Me.categoryLabel3.Visible = False
        '
        'titleTextBox1
        '
        Me.titleTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleTextBox1.Location = New System.Drawing.Point(119, 263)
        Me.titleTextBox1.Name = "titleTextBox1"
        Me.titleTextBox1.Size = New System.Drawing.Size(457, 20)
        Me.titleTextBox1.TabIndex = 6
        Me.titleTextBox1.Visible = False
        '
        'CreationdateTextBox3
        '
        Me.CreationdateTextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreationdateTextBox3.Location = New System.Drawing.Point(119, 289)
        Me.CreationdateTextBox3.Name = "CreationdateTextBox3"
        Me.CreationdateTextBox3.Size = New System.Drawing.Size(457, 20)
        Me.CreationdateTextBox3.TabIndex = 8
        Me.CreationdateTextBox3.Visible = False
        '
        'categoryComboBox1
        '
        Me.categoryComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categoryComboBox1.FormattingEnabled = True
        Me.categoryComboBox1.Location = New System.Drawing.Point(119, 315)
        Me.categoryComboBox1.Name = "categoryComboBox1"
        Me.categoryComboBox1.Size = New System.Drawing.Size(457, 21)
        Me.categoryComboBox1.TabIndex = 9
        Me.categoryComboBox1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.prviewTabPage1)
        Me.TabControl1.Controls.Add(Me.ImageTabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 342)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(568, 220)
        Me.TabControl1.TabIndex = 10
        Me.TabControl1.Visible = False
        '
        'prviewTabPage1
        '
        Me.prviewTabPage1.Controls.Add(Me.previewTextBox1)
        Me.prviewTabPage1.Location = New System.Drawing.Point(4, 22)
        Me.prviewTabPage1.Name = "prviewTabPage1"
        Me.prviewTabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.prviewTabPage1.Size = New System.Drawing.Size(560, 194)
        Me.prviewTabPage1.TabIndex = 0
        Me.prviewTabPage1.Text = "Preview"
        Me.prviewTabPage1.UseVisualStyleBackColor = True
        '
        'previewTextBox1
        '
        Me.previewTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.previewTextBox1.Location = New System.Drawing.Point(6, 6)
        Me.previewTextBox1.Multiline = True
        Me.previewTextBox1.Name = "previewTextBox1"
        Me.previewTextBox1.Size = New System.Drawing.Size(546, 182)
        Me.previewTextBox1.TabIndex = 0
        '
        'ImageTabPage2
        '
        Me.ImageTabPage2.Controls.Add(Me.imagePictureBox1)
        Me.ImageTabPage2.Location = New System.Drawing.Point(4, 22)
        Me.ImageTabPage2.Name = "ImageTabPage2"
        Me.ImageTabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.ImageTabPage2.Size = New System.Drawing.Size(560, 194)
        Me.ImageTabPage2.TabIndex = 1
        Me.ImageTabPage2.Text = "Image"
        Me.ImageTabPage2.UseVisualStyleBackColor = True
        '
        'imagePictureBox1
        '
        Me.imagePictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.imagePictureBox1.Name = "imagePictureBox1"
        Me.imagePictureBox1.Size = New System.Drawing.Size(546, 182)
        Me.imagePictureBox1.TabIndex = 0
        Me.imagePictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 574)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.categoryComboBox1)
        Me.Controls.Add(Me.CreationdateTextBox3)
        Me.Controls.Add(Me.titleTextBox1)
        Me.Controls.Add(Me.categoryLabel3)
        Me.Controls.Add(Me.dateLabel2)
        Me.Controls.Add(Me.titleLabel1)
        Me.Controls.Add(Me.NewsPhotoDataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Main_Form"
        CType(Me.NewsPhotoDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.prviewTabPage1.ResumeLayout(False)
        Me.prviewTabPage1.PerformLayout()
        Me.ImageTabPage2.ResumeLayout(False)
        CType(Me.imagePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewsPhotoDataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents titleLabel1 As Label
    Friend WithEvents dateLabel2 As Label
    Friend WithEvents categoryLabel3 As Label
    Friend WithEvents titleTextBox1 As TextBox
    Friend WithEvents CreationdateTextBox3 As TextBox
    Friend WithEvents categoryComboBox1 As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents prviewTabPage1 As TabPage
    Friend WithEvents ImageTabPage2 As TabPage
    Friend WithEvents imagePictureBox1 As PictureBox
    Friend WithEvents previewTextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
