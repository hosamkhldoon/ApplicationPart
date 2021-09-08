<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowUser
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
        Me.UserDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nameuser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loginname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTextBox2 = New System.Windows.Forms.TextBox()
        Me.LoginnameTextBox3 = New System.Windows.Forms.TextBox()
        Me.LastmodifierTextBox4 = New System.Windows.Forms.TextBox()
        Me.IDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NameComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.seconedidTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.seconednameTextBox1 = New System.Windows.Forms.TextBox()
        Me.nameCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.seconedloginTextBox1 = New System.Windows.Forms.TextBox()
        Me.loginnameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.loginnameCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.seconedmodiferTextBox1 = New System.Windows.Forms.TextBox()
        Me.lastmodifierCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lastmodifierComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.seconedDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dateComboBox1 = New System.Windows.Forms.ComboBox()
        Me.userDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dateCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.searchButton1 = New System.Windows.Forms.Button()
        Me.ResetButton2 = New System.Windows.Forms.Button()
        CType(Me.UserDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserDataGridView1
        '
        Me.UserDataGridView1.AllowUserToAddRows = False
        Me.UserDataGridView1.AllowUserToDeleteRows = False
        Me.UserDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Nameuser, Me.Column3, Me.loginname, Me.Column1})
        Me.UserDataGridView1.Location = New System.Drawing.Point(2, 122)
        Me.UserDataGridView1.Name = "UserDataGridView1"
        Me.UserDataGridView1.ReadOnly = True
        Me.UserDataGridView1.Size = New System.Drawing.Size(674, 183)
        Me.UserDataGridView1.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 43
        '
        'Nameuser
        '
        Me.Nameuser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nameuser.HeaderText = "Name User"
        Me.Nameuser.Name = "Nameuser"
        Me.Nameuser.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Creation Date User "
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'loginname
        '
        Me.loginname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.loginname.HeaderText = "Login Name User"
        Me.loginname.Name = "loginname"
        Me.loginname.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Last Modifier"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'UserContextMenuStrip1
        '
        Me.UserContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.UserContextMenuStrip1.Name = "UserContextMenuStrip1"
        Me.UserContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'IDTextBox1
        '
        Me.IDTextBox1.Enabled = False
        Me.IDTextBox1.Location = New System.Drawing.Point(6, 6)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox1.TabIndex = 6
        '
        'NameTextBox2
        '
        Me.NameTextBox2.Enabled = False
        Me.NameTextBox2.Location = New System.Drawing.Point(6, 6)
        Me.NameTextBox2.Name = "NameTextBox2"
        Me.NameTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox2.TabIndex = 7
        '
        'LoginnameTextBox3
        '
        Me.LoginnameTextBox3.Enabled = False
        Me.LoginnameTextBox3.Location = New System.Drawing.Point(3, 6)
        Me.LoginnameTextBox3.Name = "LoginnameTextBox3"
        Me.LoginnameTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.LoginnameTextBox3.TabIndex = 8
        '
        'LastmodifierTextBox4
        '
        Me.LastmodifierTextBox4.Enabled = False
        Me.LastmodifierTextBox4.Location = New System.Drawing.Point(6, 6)
        Me.LastmodifierTextBox4.Name = "LastmodifierTextBox4"
        Me.LastmodifierTextBox4.Size = New System.Drawing.Size(100, 20)
        Me.LastmodifierTextBox4.TabIndex = 10
        '
        'IDComboBox1
        '
        Me.IDComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IDComboBox1.Enabled = False
        Me.IDComboBox1.FormattingEnabled = True
        Me.IDComboBox1.Items.AddRange(New Object() {"Greater than", "Less Than", "Greater or Equal", "Less or equal", "Not equal ", "Equal", "Between"})
        Me.IDComboBox1.Location = New System.Drawing.Point(126, 6)
        Me.IDComboBox1.Name = "IDComboBox1"
        Me.IDComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.IDComboBox1.TabIndex = 11
        '
        'NameComboBox2
        '
        Me.NameComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NameComboBox2.Enabled = False
        Me.NameComboBox2.FormattingEnabled = True
        Me.NameComboBox2.Items.AddRange(New Object() {"start with", "end with", "Contain", "Not start with", "Not End with", "Exists", "Not contain", "Between"})
        Me.NameComboBox2.Location = New System.Drawing.Point(128, 6)
        Me.NameComboBox2.Name = "NameComboBox2"
        Me.NameComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.NameComboBox2.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(2, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(578, 111)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.seconedidTextBox1)
        Me.TabPage1.Controls.Add(Me.IDCheckBox1)
        Me.TabPage1.Controls.Add(Me.IDTextBox1)
        Me.TabPage1.Controls.Add(Me.IDComboBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(570, 85)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ID Filter"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'seconedidTextBox1
        '
        Me.seconedidTextBox1.Enabled = False
        Me.seconedidTextBox1.Location = New System.Drawing.Point(267, 7)
        Me.seconedidTextBox1.Name = "seconedidTextBox1"
        Me.seconedidTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.seconedidTextBox1.TabIndex = 13
        '
        'IDCheckBox1
        '
        Me.IDCheckBox1.AutoSize = True
        Me.IDCheckBox1.Location = New System.Drawing.Point(7, 47)
        Me.IDCheckBox1.Name = "IDCheckBox1"
        Me.IDCheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.IDCheckBox1.TabIndex = 12
        Me.IDCheckBox1.Text = "Enable Filter"
        Me.IDCheckBox1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.seconednameTextBox1)
        Me.TabPage2.Controls.Add(Me.nameCheckBox1)
        Me.TabPage2.Controls.Add(Me.NameTextBox2)
        Me.TabPage2.Controls.Add(Me.NameComboBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(570, 85)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Name Filter"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'seconednameTextBox1
        '
        Me.seconednameTextBox1.Enabled = False
        Me.seconednameTextBox1.Location = New System.Drawing.Point(269, 7)
        Me.seconednameTextBox1.Name = "seconednameTextBox1"
        Me.seconednameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.seconednameTextBox1.TabIndex = 14
        '
        'nameCheckBox1
        '
        Me.nameCheckBox1.AutoSize = True
        Me.nameCheckBox1.Location = New System.Drawing.Point(6, 50)
        Me.nameCheckBox1.Name = "nameCheckBox1"
        Me.nameCheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.nameCheckBox1.TabIndex = 13
        Me.nameCheckBox1.Text = "Enable Filter"
        Me.nameCheckBox1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.seconedloginTextBox1)
        Me.TabPage3.Controls.Add(Me.loginnameComboBox1)
        Me.TabPage3.Controls.Add(Me.loginnameCheckBox1)
        Me.TabPage3.Controls.Add(Me.LoginnameTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(570, 85)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Login Name Filter"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'seconedloginTextBox1
        '
        Me.seconedloginTextBox1.Enabled = False
        Me.seconedloginTextBox1.Location = New System.Drawing.Point(271, 7)
        Me.seconedloginTextBox1.Name = "seconedloginTextBox1"
        Me.seconedloginTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.seconedloginTextBox1.TabIndex = 14
        '
        'loginnameComboBox1
        '
        Me.loginnameComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.loginnameComboBox1.Enabled = False
        Me.loginnameComboBox1.FormattingEnabled = True
        Me.loginnameComboBox1.Items.AddRange(New Object() {"start with", "end with", "Contain", "Not start with", "Not End with", "Exists", "Not contain", "Between"})
        Me.loginnameComboBox1.Location = New System.Drawing.Point(125, 6)
        Me.loginnameComboBox1.Name = "loginnameComboBox1"
        Me.loginnameComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.loginnameComboBox1.TabIndex = 13
        '
        'loginnameCheckBox1
        '
        Me.loginnameCheckBox1.AutoSize = True
        Me.loginnameCheckBox1.Location = New System.Drawing.Point(7, 49)
        Me.loginnameCheckBox1.Name = "loginnameCheckBox1"
        Me.loginnameCheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.loginnameCheckBox1.TabIndex = 9
        Me.loginnameCheckBox1.Text = "Enable Filter"
        Me.loginnameCheckBox1.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.seconedmodiferTextBox1)
        Me.TabPage4.Controls.Add(Me.lastmodifierCheckBox1)
        Me.TabPage4.Controls.Add(Me.lastmodifierComboBox1)
        Me.TabPage4.Controls.Add(Me.LastmodifierTextBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(570, 85)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "LastModifier Filter"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'seconedmodiferTextBox1
        '
        Me.seconedmodiferTextBox1.Enabled = False
        Me.seconedmodiferTextBox1.Location = New System.Drawing.Point(267, 7)
        Me.seconedmodiferTextBox1.Name = "seconedmodiferTextBox1"
        Me.seconedmodiferTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.seconedmodiferTextBox1.TabIndex = 15
        '
        'lastmodifierCheckBox1
        '
        Me.lastmodifierCheckBox1.AutoSize = True
        Me.lastmodifierCheckBox1.Location = New System.Drawing.Point(7, 49)
        Me.lastmodifierCheckBox1.Name = "lastmodifierCheckBox1"
        Me.lastmodifierCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lastmodifierCheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.lastmodifierCheckBox1.TabIndex = 14
        Me.lastmodifierCheckBox1.Text = "Enable filter"
        Me.lastmodifierCheckBox1.UseVisualStyleBackColor = True
        '
        'lastmodifierComboBox1
        '
        Me.lastmodifierComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lastmodifierComboBox1.Enabled = False
        Me.lastmodifierComboBox1.FormattingEnabled = True
        Me.lastmodifierComboBox1.Items.AddRange(New Object() {"start with", "end with", "Contain", "Not start with", "Not End with", "Exists", "Not contain", "Between"})
        Me.lastmodifierComboBox1.Location = New System.Drawing.Point(123, 6)
        Me.lastmodifierComboBox1.Name = "lastmodifierComboBox1"
        Me.lastmodifierComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.lastmodifierComboBox1.TabIndex = 13
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.seconedDateTimePicker1)
        Me.TabPage5.Controls.Add(Me.dateComboBox1)
        Me.TabPage5.Controls.Add(Me.userDateTimePicker1)
        Me.TabPage5.Controls.Add(Me.dateCheckBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(570, 85)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Creation Date filter"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'seconedDateTimePicker1
        '
        Me.seconedDateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.seconedDateTimePicker1.Enabled = False
        Me.seconedDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.seconedDateTimePicker1.Location = New System.Drawing.Point(350, 7)
        Me.seconedDateTimePicker1.Name = "seconedDateTimePicker1"
        Me.seconedDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.seconedDateTimePicker1.TabIndex = 13
        '
        'dateComboBox1
        '
        Me.dateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dateComboBox1.Enabled = False
        Me.dateComboBox1.FormattingEnabled = True
        Me.dateComboBox1.Items.AddRange(New Object() {"Greater than", "Less Than", "Greater or Equal", "Less or equal", "Not equal ", "Equal", "Between"})
        Me.dateComboBox1.Location = New System.Drawing.Point(223, 7)
        Me.dateComboBox1.Name = "dateComboBox1"
        Me.dateComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.dateComboBox1.TabIndex = 12
        '
        'userDateTimePicker1
        '
        Me.userDateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.userDateTimePicker1.Enabled = False
        Me.userDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.userDateTimePicker1.Location = New System.Drawing.Point(7, 7)
        Me.userDateTimePicker1.Name = "userDateTimePicker1"
        Me.userDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.userDateTimePicker1.TabIndex = 2
        '
        'dateCheckBox1
        '
        Me.dateCheckBox1.AutoSize = True
        Me.dateCheckBox1.Location = New System.Drawing.Point(7, 49)
        Me.dateCheckBox1.Name = "dateCheckBox1"
        Me.dateCheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.dateCheckBox1.TabIndex = 1
        Me.dateCheckBox1.Text = "Enable Filter"
        Me.dateCheckBox1.UseVisualStyleBackColor = True
        '
        'searchButton1
        '
        Me.searchButton1.Location = New System.Drawing.Point(586, 31)
        Me.searchButton1.Name = "searchButton1"
        Me.searchButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.searchButton1.Size = New System.Drawing.Size(75, 23)
        Me.searchButton1.TabIndex = 14
        Me.searchButton1.Text = "Search"
        Me.searchButton1.UseVisualStyleBackColor = True
        '
        'ResetButton2
        '
        Me.ResetButton2.Location = New System.Drawing.Point(586, 80)
        Me.ResetButton2.Name = "ResetButton2"
        Me.ResetButton2.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton2.TabIndex = 15
        Me.ResetButton2.Text = "Get All User"
        Me.ResetButton2.UseVisualStyleBackColor = True
        '
        'ShowUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 303)
        Me.Controls.Add(Me.ResetButton2)
        Me.Controls.Add(Me.searchButton1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.UserDataGridView1)
        Me.Name = "ShowUser"
        Me.Text = "ShowUser"
        CType(Me.UserDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserDataGridView1 As DataGridView
    Friend WithEvents UserContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Nameuser As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents loginname As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents NameTextBox2 As TextBox
    Friend WithEvents LoginnameTextBox3 As TextBox
    Friend WithEvents LastmodifierTextBox4 As TextBox
    Friend WithEvents IDComboBox1 As ComboBox
    Friend WithEvents NameComboBox2 As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents nameCheckBox1 As CheckBox
    Friend WithEvents loginnameComboBox1 As ComboBox
    Friend WithEvents loginnameCheckBox1 As CheckBox
    Friend WithEvents lastmodifierCheckBox1 As CheckBox
    Friend WithEvents lastmodifierComboBox1 As ComboBox
    Friend WithEvents IDCheckBox1 As CheckBox
    Friend WithEvents searchButton1 As Button
    Friend WithEvents ResetButton2 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents dateComboBox1 As ComboBox
    Friend WithEvents userDateTimePicker1 As DateTimePicker
    Friend WithEvents dateCheckBox1 As CheckBox
    Friend WithEvents seconedidTextBox1 As TextBox
    Friend WithEvents seconednameTextBox1 As TextBox
    Friend WithEvents seconedloginTextBox1 As TextBox
    Friend WithEvents seconedmodiferTextBox1 As TextBox
    Friend WithEvents seconedDateTimePicker1 As DateTimePicker
End Class
