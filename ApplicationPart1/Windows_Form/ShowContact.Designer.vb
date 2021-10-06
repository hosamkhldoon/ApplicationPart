<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowContact
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
        Me.components = New System.ComponentModel.Container()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.NameFiltercomboBox1 = New System.Windows.Forms.ComboBox()
        Me.NamecheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NamefiltertextBox1 = New System.Windows.Forms.TextBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.TypecheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TypeFiltercomboBox1 = New System.Windows.Forms.ComboBox()
        Me.sqlorelasticcomboBox1 = New System.Windows.Forms.ComboBox()
        Me.GetAllbutton2 = New System.Windows.Forms.Button()
        Me.SerarchButton = New System.Windows.Forms.Button()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FiletoolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewtoolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExittoolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colunm2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CancelButton2 = New System.Windows.Forms.Button()
        Me.ContactContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        CType(Me.ContactDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContactContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(12, 33)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(489, 134)
        Me.tabControl1.TabIndex = 1
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.NameFiltercomboBox1)
        Me.tabPage1.Controls.Add(Me.NamecheckBox1)
        Me.tabPage1.Controls.Add(Me.NamefiltertextBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 24)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(481, 106)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Name Filter"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'NameFiltercomboBox1
        '
        Me.NameFiltercomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NameFiltercomboBox1.Enabled = False
        Me.NameFiltercomboBox1.FormattingEnabled = True
        Me.NameFiltercomboBox1.Items.AddRange(New Object() {"start with", "end with", "Contain", "Not start with", "Not End with", "Exists", "Not contain"})
        Me.NameFiltercomboBox1.Location = New System.Drawing.Point(175, 20)
        Me.NameFiltercomboBox1.Name = "NameFiltercomboBox1"
        Me.NameFiltercomboBox1.Size = New System.Drawing.Size(121, 23)
        Me.NameFiltercomboBox1.TabIndex = 2
        '
        'NamecheckBox1
        '
        Me.NamecheckBox1.AutoSize = True
        Me.NamecheckBox1.Location = New System.Drawing.Point(26, 79)
        Me.NamecheckBox1.Name = "NamecheckBox1"
        Me.NamecheckBox1.Size = New System.Drawing.Size(90, 19)
        Me.NamecheckBox1.TabIndex = 1
        Me.NamecheckBox1.Text = "Enable Filter"
        Me.NamecheckBox1.UseVisualStyleBackColor = True
        '
        'NamefiltertextBox1
        '
        Me.NamefiltertextBox1.Enabled = False
        Me.NamefiltertextBox1.Location = New System.Drawing.Point(23, 20)
        Me.NamefiltertextBox1.Name = "NamefiltertextBox1"
        Me.NamefiltertextBox1.Size = New System.Drawing.Size(100, 23)
        Me.NamefiltertextBox1.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.TypecheckBox1)
        Me.tabPage2.Controls.Add(Me.TypeFiltercomboBox1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 24)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(481, 106)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Type Filter"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'TypecheckBox1
        '
        Me.TypecheckBox1.AutoSize = True
        Me.TypecheckBox1.Location = New System.Drawing.Point(40, 76)
        Me.TypecheckBox1.Name = "TypecheckBox1"
        Me.TypecheckBox1.Size = New System.Drawing.Size(90, 19)
        Me.TypecheckBox1.TabIndex = 1
        Me.TypecheckBox1.Text = "Enable Filter"
        Me.TypecheckBox1.UseVisualStyleBackColor = True
        '
        'TypeFiltercomboBox1
        '
        Me.TypeFiltercomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeFiltercomboBox1.Enabled = False
        Me.TypeFiltercomboBox1.FormattingEnabled = True
        Me.TypeFiltercomboBox1.Items.AddRange(New Object() {"Transmission", "Reception"})
        Me.TypeFiltercomboBox1.Location = New System.Drawing.Point(37, 23)
        Me.TypeFiltercomboBox1.Name = "TypeFiltercomboBox1"
        Me.TypeFiltercomboBox1.Size = New System.Drawing.Size(121, 23)
        Me.TypeFiltercomboBox1.TabIndex = 0
        '
        'sqlorelasticcomboBox1
        '
        Me.sqlorelasticcomboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sqlorelasticcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sqlorelasticcomboBox1.FormattingEnabled = True
        Me.sqlorelasticcomboBox1.Items.AddRange(New Object() {"SQL SERVER", "ELASTICSEARCH"})
        Me.sqlorelasticcomboBox1.Location = New System.Drawing.Point(507, 57)
        Me.sqlorelasticcomboBox1.Name = "sqlorelasticcomboBox1"
        Me.sqlorelasticcomboBox1.Size = New System.Drawing.Size(121, 23)
        Me.sqlorelasticcomboBox1.TabIndex = 6
        '
        'GetAllbutton2
        '
        Me.GetAllbutton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetAllbutton2.Location = New System.Drawing.Point(507, 140)
        Me.GetAllbutton2.Name = "GetAllbutton2"
        Me.GetAllbutton2.Size = New System.Drawing.Size(121, 23)
        Me.GetAllbutton2.TabIndex = 5
        Me.GetAllbutton2.Text = "GetAllContact"
        Me.GetAllbutton2.UseVisualStyleBackColor = True
        '
        'SerarchButton
        '
        Me.SerarchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SerarchButton.Location = New System.Drawing.Point(536, 99)
        Me.SerarchButton.Name = "SerarchButton"
        Me.SerarchButton.Size = New System.Drawing.Size(75, 23)
        Me.SerarchButton.TabIndex = 4
        Me.SerarchButton.Text = "Search"
        Me.SerarchButton.UseVisualStyleBackColor = True
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiletoolStripMenuItem1})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(640, 24)
        Me.menuStrip1.TabIndex = 7
        Me.menuStrip1.Text = "File"
        '
        'FiletoolStripMenuItem1
        '
        Me.FiletoolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewtoolStripMenuItem1, Me.ExittoolStripMenuItem2})
        Me.FiletoolStripMenuItem1.Name = "FiletoolStripMenuItem1"
        Me.FiletoolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FiletoolStripMenuItem1.Text = "File"
        '
        'NewtoolStripMenuItem1
        '
        Me.NewtoolStripMenuItem1.Name = "NewtoolStripMenuItem1"
        Me.NewtoolStripMenuItem1.Size = New System.Drawing.Size(98, 22)
        Me.NewtoolStripMenuItem1.Text = "New"
        '
        'ExittoolStripMenuItem2
        '
        Me.ExittoolStripMenuItem2.Name = "ExittoolStripMenuItem2"
        Me.ExittoolStripMenuItem2.Size = New System.Drawing.Size(98, 22)
        Me.ExittoolStripMenuItem2.Text = "Exit"
        '
        'ContactDataGridView
        '
        Me.ContactDataGridView.AllowUserToAddRows = False
        Me.ContactDataGridView.AllowUserToDeleteRows = False
        Me.ContactDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ContactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.colunm2, Me.Type})
        Me.ContactDataGridView.Location = New System.Drawing.Point(0, 201)
        Me.ContactDataGridView.Name = "ContactDataGridView"
        Me.ContactDataGridView.ReadOnly = True
        Me.ContactDataGridView.RowTemplate.Height = 25
        Me.ContactDataGridView.Size = New System.Drawing.Size(640, 188)
        Me.ContactDataGridView.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 43
        '
        'colunm2
        '
        Me.colunm2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colunm2.HeaderText = "Name"
        Me.colunm2.Name = "colunm2"
        Me.colunm2.ReadOnly = True
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'OkButton
        '
        Me.OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkButton.Location = New System.Drawing.Point(536, 411)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(92, 23)
        Me.OkButton.TabIndex = 9
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'CancelButton2
        '
        Me.CancelButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton2.Location = New System.Drawing.Point(438, 411)
        Me.CancelButton2.Name = "CancelButton2"
        Me.CancelButton2.Size = New System.Drawing.Size(82, 23)
        Me.CancelButton2.TabIndex = 10
        Me.CancelButton2.Text = "Cancel"
        Me.CancelButton2.UseVisualStyleBackColor = True
        '
        'ContactContextMenuStrip1
        '
        Me.ContactContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.ContactContextMenuStrip1.Name = "ContactContextMenuStrip1"
        Me.ContactContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'ShowContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.CancelButton2)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.ContactDataGridView)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.sqlorelasticcomboBox1)
        Me.Controls.Add(Me.GetAllbutton2)
        Me.Controls.Add(Me.SerarchButton)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "ShowContact"
        Me.Text = "ShowContact"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.ContactDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContactContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents NameFiltercomboBox1 As ComboBox
    Private WithEvents NamecheckBox1 As CheckBox
    Private WithEvents NamefiltertextBox1 As TextBox
    Private WithEvents tabPage2 As TabPage
    Private WithEvents TypecheckBox1 As CheckBox
    Private WithEvents TypeFiltercomboBox1 As ComboBox
    Private WithEvents sqlorelasticcomboBox1 As ComboBox
    Private WithEvents GetAllbutton2 As Button
    Private WithEvents SerarchButton As Button
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents FiletoolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents NewtoolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents ExittoolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ContactDataGridView As DataGridView
    Friend WithEvents OkButton As Button
    Friend WithEvents CancelButton2 As Button
    Friend WithEvents ContactContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colunm2 As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
End Class
