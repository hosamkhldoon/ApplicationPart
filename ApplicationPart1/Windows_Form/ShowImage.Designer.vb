<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowImage
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
        Me.imageMainPictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.imageMainPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageMainPictureBox1
        '
        Me.imageMainPictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.imageMainPictureBox1.Name = "imageMainPictureBox1"
        Me.imageMainPictureBox1.Size = New System.Drawing.Size(705, 363)
        Me.imageMainPictureBox1.TabIndex = 0
        Me.imageMainPictureBox1.TabStop = False
        '
        'Show_Image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 358)
        Me.Controls.Add(Me.imageMainPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Show_Image"
        Me.Text = "Show_Image"
        CType(Me.imageMainPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imageMainPictureBox1 As PictureBox
End Class
