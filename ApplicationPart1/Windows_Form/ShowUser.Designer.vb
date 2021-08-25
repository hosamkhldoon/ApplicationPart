<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowUser
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
        Me.UserDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Nameuser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loginname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UserDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserContextMenuStrip1.SuspendLayout()
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
        Me.UserDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nameuser, Me.loginname, Me.Column1})
        Me.UserDataGridView1.Location = New System.Drawing.Point(2, 1)
        Me.UserDataGridView1.Name = "UserDataGridView1"
        Me.UserDataGridView1.ReadOnly = True
        Me.UserDataGridView1.Size = New System.Drawing.Size(312, 230)
        Me.UserDataGridView1.TabIndex = 0
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
        'Nameuser
        '
        Me.Nameuser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nameuser.HeaderText = "Name User"
        Me.Nameuser.Name = "Nameuser"
        Me.Nameuser.ReadOnly = True
        Me.Nameuser.Width = 85
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
        'ShowUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 231)
        Me.Controls.Add(Me.UserDataGridView1)
        Me.name = "ShowUser"
        Me.Text = "ShowUser"
        CType(Me.UserDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserDataGridView1 As DataGridView
    Friend WithEvents UserContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Nameuser As DataGridViewTextBoxColumn
    Friend WithEvents loginname As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
