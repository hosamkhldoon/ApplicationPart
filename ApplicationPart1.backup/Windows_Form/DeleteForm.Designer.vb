<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteForm
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
        Me.deleteLabel1 = New System.Windows.Forms.Label()
        Me.yesButton1 = New System.Windows.Forms.Button()
        Me.noButton2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'deleteLabel1
        '
        Me.deleteLabel1.AutoSize = True
        Me.deleteLabel1.Location = New System.Drawing.Point(113, 53)
        Me.deleteLabel1.Name = "deleteLabel1"
        Me.deleteLabel1.Size = New System.Drawing.Size(0, 13)
        Me.deleteLabel1.TabIndex = 0
        Me.deleteLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'yesButton1
        '
        Me.yesButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.yesButton1.Location = New System.Drawing.Point(170, 88)
        Me.yesButton1.Name = "yesButton1"
        Me.yesButton1.Size = New System.Drawing.Size(75, 23)
        Me.yesButton1.TabIndex = 1
        Me.yesButton1.Text = "Yes"
        Me.yesButton1.UseVisualStyleBackColor = True
        '
        'noButton2
        '
        Me.noButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noButton2.Location = New System.Drawing.Point(251, 88)
        Me.noButton2.Name = "noButton2"
        Me.noButton2.Size = New System.Drawing.Size(83, 23)
        Me.noButton2.TabIndex = 2
        Me.noButton2.Text = "No"
        Me.noButton2.UseVisualStyleBackColor = True
        '
        'DeleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 123)
        Me.Controls.Add(Me.noButton2)
        Me.Controls.Add(Me.yesButton1)
        Me.Controls.Add(Me.deleteLabel1)
        Me.Name = "DeleteForm"
        Me.Text = "DeleteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deleteLabel1 As Label
    Friend WithEvents yesButton1 As Button
    Friend WithEvents noButton2 As Button
End Class
