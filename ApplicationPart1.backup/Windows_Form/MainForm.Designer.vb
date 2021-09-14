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
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.IDfilterTextBox1 = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox2 = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleTextBox5 = New System.Windows.Forms.TextBox()
        Me.ClassidTextBox6 = New System.Windows.Forms.TextBox()
        Me.ClassComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CategoryComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.seconedIDTextBox6 = New System.Windows.Forms.TextBox()
        Me.IDCheckBox5 = New System.Windows.Forms.CheckBox()
        Me.IdComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.seconedtextTextBox5 = New System.Windows.Forms.TextBox()
        Me.TitleCheckBox4 = New System.Windows.Forms.CheckBox()
        Me.titleComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.seconeddesTextBox4 = New System.Windows.Forms.TextBox()
        Me.DescriptionCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.DescriptionComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.seconedclassTextBox3 = New System.Windows.Forms.TextBox()
        Me.ClassCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.seconedDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DateComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.seconedcategoryTextBox1 = New System.Windows.Forms.TextBox()
        Me.CategoryCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SearchButton1 = New System.Windows.Forms.Button()
        Me.ResetButton2 = New System.Windows.Forms.Button()
        CType(Me.NewsPhotoDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.prviewTabPage1.SuspendLayout()
        Me.ImageTabPage2.SuspendLayout()
        CType(Me.imagePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
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
        Me.NewsPhotoDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3})
        Me.NewsPhotoDataGridView1.Location = New System.Drawing.Point(12, 147)
        Me.NewsPhotoDataGridView1.Name = "NewsPhotoDataGridView1"
        Me.NewsPhotoDataGridView1.ReadOnly = True
        Me.NewsPhotoDataGridView1.Size = New System.Drawing.Size(714, 149)
        Me.NewsPhotoDataGridView1.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column4.Width = 43
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Titl"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Creation Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShowToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
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
        Me.MyAccountToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.MyAccountToolStripMenuItem.Text = "My Account"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'titleLabel1
        '
        Me.titleLabel1.AutoSize = True
        Me.titleLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel1.Location = New System.Drawing.Point(16, 302)
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
        Me.dateLabel2.Location = New System.Drawing.Point(9, 328)
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
        Me.categoryLabel3.Location = New System.Drawing.Point(12, 359)
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
        Me.titleTextBox1.Location = New System.Drawing.Point(119, 302)
        Me.titleTextBox1.Name = "titleTextBox1"
        Me.titleTextBox1.Size = New System.Drawing.Size(610, 20)
        Me.titleTextBox1.TabIndex = 6
        Me.titleTextBox1.Visible = False
        '
        'CreationdateTextBox3
        '
        Me.CreationdateTextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreationdateTextBox3.Location = New System.Drawing.Point(119, 328)
        Me.CreationdateTextBox3.Name = "CreationdateTextBox3"
        Me.CreationdateTextBox3.Size = New System.Drawing.Size(610, 20)
        Me.CreationdateTextBox3.TabIndex = 8
        Me.CreationdateTextBox3.Visible = False
        '
        'categoryComboBox1
        '
        Me.categoryComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categoryComboBox1.FormattingEnabled = True
        Me.categoryComboBox1.Location = New System.Drawing.Point(119, 358)
        Me.categoryComboBox1.Name = "categoryComboBox1"
        Me.categoryComboBox1.Size = New System.Drawing.Size(610, 21)
        Me.categoryComboBox1.TabIndex = 9
        Me.categoryComboBox1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.prviewTabPage1)
        Me.TabControl1.Controls.Add(Me.ImageTabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 385)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 195)
        Me.TabControl1.TabIndex = 10
        Me.TabControl1.Visible = False
        '
        'prviewTabPage1
        '
        Me.prviewTabPage1.Controls.Add(Me.previewTextBox1)
        Me.prviewTabPage1.Location = New System.Drawing.Point(4, 22)
        Me.prviewTabPage1.Name = "prviewTabPage1"
        Me.prviewTabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.prviewTabPage1.Size = New System.Drawing.Size(715, 169)
        Me.prviewTabPage1.TabIndex = 0
        Me.prviewTabPage1.Text = "Preview"
        Me.prviewTabPage1.UseVisualStyleBackColor = True
        '
        'previewTextBox1
        '
        Me.previewTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.previewTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.previewTextBox1.Location = New System.Drawing.Point(6, 6)
        Me.previewTextBox1.Multiline = True
        Me.previewTextBox1.Name = "previewTextBox1"
        Me.previewTextBox1.Size = New System.Drawing.Size(771, 141)
        Me.previewTextBox1.TabIndex = 0
        '
        'ImageTabPage2
        '
        Me.ImageTabPage2.Controls.Add(Me.imagePictureBox1)
        Me.ImageTabPage2.Location = New System.Drawing.Point(4, 22)
        Me.ImageTabPage2.Name = "ImageTabPage2"
        Me.ImageTabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.ImageTabPage2.Size = New System.Drawing.Size(661, 169)
        Me.ImageTabPage2.TabIndex = 1
        Me.ImageTabPage2.Text = "Image"
        Me.ImageTabPage2.UseVisualStyleBackColor = True
        '
        'imagePictureBox1
        '
        Me.imagePictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imagePictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.imagePictureBox1.Name = "imagePictureBox1"
        Me.imagePictureBox1.Size = New System.Drawing.Size(650, 163)
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
        'IDfilterTextBox1
        '
        Me.IDfilterTextBox1.Enabled = False
        Me.IDfilterTextBox1.Location = New System.Drawing.Point(6, 6)
        Me.IDfilterTextBox1.Name = "IDfilterTextBox1"
        Me.IDfilterTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDfilterTextBox1.TabIndex = 11
        '
        'DescriptionTextBox2
        '
        Me.DescriptionTextBox2.Enabled = False
        Me.DescriptionTextBox2.Location = New System.Drawing.Point(6, 6)
        Me.DescriptionTextBox2.Name = "DescriptionTextBox2"
        Me.DescriptionTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.DescriptionTextBox2.TabIndex = 12
        '
        'CategoryTextBox3
        '
        Me.CategoryTextBox3.Enabled = False
        Me.CategoryTextBox3.Location = New System.Drawing.Point(6, 6)
        Me.CategoryTextBox3.Name = "CategoryTextBox3"
        Me.CategoryTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.CategoryTextBox3.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 15
        '
        'TitleTextBox5
        '
        Me.TitleTextBox5.Enabled = False
        Me.TitleTextBox5.Location = New System.Drawing.Point(6, 6)
        Me.TitleTextBox5.Name = "TitleTextBox5"
        Me.TitleTextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox5.TabIndex = 19
        '
        'ClassidTextBox6
        '
        Me.ClassidTextBox6.Enabled = False
        Me.ClassidTextBox6.Location = New System.Drawing.Point(6, 6)
        Me.ClassidTextBox6.Name = "ClassidTextBox6"
        Me.ClassidTextBox6.Size = New System.Drawing.Size(100, 20)
        Me.ClassidTextBox6.TabIndex = 21
        '
        'ClassComboBox1
        '
        Me.ClassComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassComboBox1.Enabled = False
        Me.ClassComboBox1.FormattingEnabled = True
        Me.ClassComboBox1.Items.AddRange(New Object() {"Greater than", "Less Than", "Greater or Equal", "Less or equal", "Not equal ", "Equal", "Between"})
        Me.ClassComboBox1.Location = New System.Drawing.Point(130, 6)
        Me.ClassComboBox1.Name = "ClassComboBox1"
        Me.ClassComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ClassComboBox1.TabIndex = 22
        '
        'CategoryComboBox2
        '
        Me.CategoryComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox2.FormattingEnabled = True
        Me.CategoryComboBox2.Items.AddRange(New Object() {"start with", "end with", "Contain", "Not start with", "Not End with", "Exists", "Not contain", "Between"})
        Me.CategoryComboBox2.Location = New System.Drawing.Point(158, 6)
        Me.CategoryComboBox2.Name = "CategoryComboBox2"
        Me.CategoryComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox2.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker1.TabIndex = 25
        Me.DateTimePicker1.Value = New Date(2021, 9, 6, 9, 44, 0, 0)
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(11, 22)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(571, 126)
        Me.TabControl2.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.seconedIDTextBox6)
        Me.TabPage1.Controls.Add(Me.IDCheckBox5)
        Me.TabPage1.Controls.Add(Me.IdComboBox3)
        Me.TabPage1.Controls.Add(Me.IDfilterTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(509, 100)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ID filter"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'seconedIDTextBox6
        '
        Me.seconedIDTextBox6.Enabled = False
        Me.seconedIDTextBox6.Location = New System.Drawing.Point(288, 9)
        Me.seconedIDTextBox6.Name = "seconedIDTextBox6"
        Me.seconedIDTextBox6.Size = New System.Drawing.Size(100, 20)
        Me.seconedIDTextBox6.TabIndex = 26
        '
        'IDCheckBox5
        '
        Me.IDCheckBox5.AutoSize = True
        Me.IDCheckBox5.Location = New System.Drawing.Point(22, 52)
        Me.IDCheckBox5.Name = "IDCheckBox5"
        Me.IDCheckBox5.Size = New System.Drawing.Size(84, 17)
        Me.IDCheckBox5.TabIndex = 25
        Me.IDCheckBox5.Text = "Enable Filter"
        Me.IDCheckBox5.UseVisualStyleBackColor = True
        '
        'IdComboBox3
        '
        Me.IdComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdComboBox3.Enabled = False
        Me.IdComboBox3.FormattingEnabled = True
        Me.IdComboBox3.Items.AddRange(New Object() {"Greater than", "Less Than", "Greater or Equal", "Less or equal", "Not equal ", "Equal", "Between"})
        Me.IdComboBox3.Location = New System.Drawing.Point(138, 6)
        Me.IdComboBox3.Name = "IdComboBox3"
        Me.IdComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.IdComboBox3.TabIndex = 23
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.seconedtextTextBox5)
        Me.TabPage2.Controls.Add(Me.TitleCheckBox4)
        Me.TabPage2.Controls.Add(Me.titleComboBox2)
        Me.TabPage2.Controls.Add(Me.TitleTextBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(509, 100)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Title filter"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'seconedtextTextBox5
        '
        Me.seconedtextTextBox5.Enabled = False
        Me.seconedtextTextBox5.Location = New System.Drawing.Point(292, 12)
        Me.seconedtextTextBox5.Name = "seconedtextTextBox5"
        Me.seconedtextTextBox5.Size = New System.Drawing.Size(100, 20)
        Me.seconedtextTextBox5.TabIndex = 26
        '
        'TitleCheckBox4
        '
        Me.TitleCheckBox4.AutoSize = True
        Me.TitleCheckBox4.Location = New System.Drawing.Point(22, 52)
        Me.TitleCheckBox4.Name = "TitleCheckBox4"
        Me.TitleCheckBox4.Size = New System.Drawing.Size(84, 17)
        Me.TitleCheckBox4.TabIndex = 25
        Me.TitleCheckBox4.Text = "Enable Filter"
        Me.TitleCheckBox4.UseVisualStyleBackColor = True
        '
        'titleComboBox2
        '
        Me.titleComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.titleComboBox2.Enabled = False
        Me.titleComboBox2.FormattingEnabled = True
        Me.titleComboBox2.Items.AddRange(New Object() {"start with", "end with", "Contain", "Not start with", "Not End with", "Exists", "Not contain", "Between"})
        Me.titleComboBox2.Location = New System.Drawing.Point(149, 6)
        Me.titleComboBox2.Name = "titleComboBox2"
        Me.titleComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.titleComboBox2.TabIndex = 24
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.seconeddesTextBox4)
        Me.TabPage3.Controls.Add(Me.DescriptionCheckBox3)
        Me.TabPage3.Controls.Add(Me.DescriptionComboBox1)
        Me.TabPage3.Controls.Add(Me.DescriptionTextBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(509, 100)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Description filter"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'seconeddesTextBox4
        '
        Me.seconeddesTextBox4.Enabled = False
        Me.seconeddesTextBox4.Location = New System.Drawing.Point(276, 6)
        Me.seconeddesTextBox4.Name = "seconeddesTextBox4"
        Me.seconeddesTextBox4.Size = New System.Drawing.Size(100, 20)
        Me.seconeddesTextBox4.TabIndex = 26
        '
        'DescriptionCheckBox3
        '
        Me.DescriptionCheckBox3.AutoSize = True
        Me.DescriptionCheckBox3.Location = New System.Drawing.Point(22, 53)
        Me.DescriptionCheckBox3.Name = "DescriptionCheckBox3"
        Me.DescriptionCheckBox3.Size = New System.Drawing.Size(84, 17)
        Me.DescriptionCheckBox3.TabIndex = 25
        Me.DescriptionCheckBox3.Text = "Enable Filter"
        Me.DescriptionCheckBox3.UseVisualStyleBackColor = True
        '
        'DescriptionComboBox1
        '
        Me.DescriptionComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DescriptionComboBox1.Enabled = False
        Me.DescriptionComboBox1.FormattingEnabled = True
        Me.DescriptionComboBox1.Items.AddRange(New Object() {"start with", "end with", "Contain", "Not start with", "Not End with", "Exists", "Not contain", "Between"})
        Me.DescriptionComboBox1.Location = New System.Drawing.Point(131, 6)
        Me.DescriptionComboBox1.Name = "DescriptionComboBox1"
        Me.DescriptionComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.DescriptionComboBox1.TabIndex = 24
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.seconedclassTextBox3)
        Me.TabPage4.Controls.Add(Me.ClassCheckBox2)
        Me.TabPage4.Controls.Add(Me.ClassidTextBox6)
        Me.TabPage4.Controls.Add(Me.ClassComboBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(563, 100)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ClassID Filter"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'seconedclassTextBox3
        '
        Me.seconedclassTextBox3.Enabled = False
        Me.seconedclassTextBox3.Location = New System.Drawing.Point(280, 11)
        Me.seconedclassTextBox3.Name = "seconedclassTextBox3"
        Me.seconedclassTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.seconedclassTextBox3.TabIndex = 26
        '
        'ClassCheckBox2
        '
        Me.ClassCheckBox2.AutoSize = True
        Me.ClassCheckBox2.Location = New System.Drawing.Point(22, 48)
        Me.ClassCheckBox2.Name = "ClassCheckBox2"
        Me.ClassCheckBox2.Size = New System.Drawing.Size(84, 17)
        Me.ClassCheckBox2.TabIndex = 25
        Me.ClassCheckBox2.Text = "Enable Filter"
        Me.ClassCheckBox2.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.seconedDateTimePicker2)
        Me.TabPage5.Controls.Add(Me.DateCheckBox1)
        Me.TabPage5.Controls.Add(Me.DateComboBox4)
        Me.TabPage5.Controls.Add(Me.DateTimePicker1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(563, 100)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "CreationDate filter"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'seconedDateTimePicker2
        '
        Me.seconedDateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.seconedDateTimePicker2.Enabled = False
        Me.seconedDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.seconedDateTimePicker2.Location = New System.Drawing.Point(321, 9)
        Me.seconedDateTimePicker2.Name = "seconedDateTimePicker2"
        Me.seconedDateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.seconedDateTimePicker2.TabIndex = 29
        '
        'DateCheckBox1
        '
        Me.DateCheckBox1.AutoSize = True
        Me.DateCheckBox1.Location = New System.Drawing.Point(6, 53)
        Me.DateCheckBox1.Name = "DateCheckBox1"
        Me.DateCheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.DateCheckBox1.TabIndex = 28
        Me.DateCheckBox1.Text = "Enable Filter"
        Me.DateCheckBox1.UseVisualStyleBackColor = True
        '
        'DateComboBox4
        '
        Me.DateComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateComboBox4.Enabled = False
        Me.DateComboBox4.FormattingEnabled = True
        Me.DateComboBox4.Items.AddRange(New Object() {"Greater than", "Less Than", "Greater or Equal", "Less or equal", "Not equal ", "Equal", "Between"})
        Me.DateComboBox4.Location = New System.Drawing.Point(173, 9)
        Me.DateComboBox4.Name = "DateComboBox4"
        Me.DateComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.DateComboBox4.TabIndex = 27
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.seconedcategoryTextBox1)
        Me.TabPage6.Controls.Add(Me.CategoryCheckBox1)
        Me.TabPage6.Controls.Add(Me.CategoryTextBox3)
        Me.TabPage6.Controls.Add(Me.CategoryComboBox2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(509, 100)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Category Filter"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'seconedcategoryTextBox1
        '
        Me.seconedcategoryTextBox1.Enabled = False
        Me.seconedcategoryTextBox1.Location = New System.Drawing.Point(313, 6)
        Me.seconedcategoryTextBox1.Name = "seconedcategoryTextBox1"
        Me.seconedcategoryTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.seconedcategoryTextBox1.TabIndex = 25
        '
        'CategoryCheckBox1
        '
        Me.CategoryCheckBox1.AutoSize = True
        Me.CategoryCheckBox1.Location = New System.Drawing.Point(6, 50)
        Me.CategoryCheckBox1.Name = "CategoryCheckBox1"
        Me.CategoryCheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CategoryCheckBox1.TabIndex = 24
        Me.CategoryCheckBox1.Text = "Enable Filter"
        Me.CategoryCheckBox1.UseVisualStyleBackColor = True
        '
        'SearchButton1
        '
        Me.SearchButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton1.Location = New System.Drawing.Point(636, 53)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton1.TabIndex = 28
        Me.SearchButton1.Text = "Search"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'ResetButton2
        '
        Me.ResetButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetButton2.Location = New System.Drawing.Point(588, 97)
        Me.ResetButton2.Name = "ResetButton2"
        Me.ResetButton2.Size = New System.Drawing.Size(138, 23)
        Me.ResetButton2.TabIndex = 29
        Me.ResetButton2.Text = "Get All News And Photo"
        Me.ResetButton2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 578)
        Me.Controls.Add(Me.ResetButton2)
        Me.Controls.Add(Me.SearchButton1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Label1)
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
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
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
    Friend WithEvents IDfilterTextBox1 As TextBox
    Friend WithEvents DescriptionTextBox2 As TextBox
    Friend WithEvents CategoryTextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleTextBox5 As TextBox
    Friend WithEvents ClassidTextBox6 As TextBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ClassComboBox1 As ComboBox
    Friend WithEvents CategoryComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents IdComboBox3 As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents titleComboBox2 As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DescriptionComboBox1 As ComboBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DateComboBox4 As ComboBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents IDCheckBox5 As CheckBox
    Friend WithEvents TitleCheckBox4 As CheckBox
    Friend WithEvents DescriptionCheckBox3 As CheckBox
    Friend WithEvents ClassCheckBox2 As CheckBox
    Friend WithEvents DateCheckBox1 As CheckBox
    Friend WithEvents CategoryCheckBox1 As CheckBox
    Friend WithEvents SearchButton1 As Button
    Friend WithEvents ResetButton2 As Button
    Friend WithEvents seconedIDTextBox6 As TextBox
    Friend WithEvents seconedtextTextBox5 As TextBox
    Friend WithEvents seconeddesTextBox4 As TextBox
    Friend WithEvents seconedclassTextBox3 As TextBox
    Friend WithEvents seconedcategoryTextBox1 As TextBox
    Friend WithEvents seconedDateTimePicker2 As DateTimePicker
End Class