Public Class Account
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveButton2_Click(sender As Object, e As EventArgs) Handles SaveButton2.Click
        MainForm.CurrentUser = NameTextBox1.Text
        MainForm.CurrentLoginName = LoginNameTextBox2.Text
        Dim account_user As User = New User()
        account_user.AccountUpdate()
        NameTextBox1.Text = MainForm.CurrentUser
        LoginNameTextBox2.Text = MainForm.CurrentLoginName
    End Sub

    Private Sub CancelButton1_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub EditButton1_Click(sender As Object, e As EventArgs) Handles EditButton1.Click
        SaveButton2.Visible = True
        EditButton1.Visible = False
        NameTextBox1.Enabled = True
        LoginNameTextBox2.Enabled = True
    End Sub
End Class