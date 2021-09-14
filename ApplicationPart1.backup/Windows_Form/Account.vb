Public Class Account
    Private AccountUser As FileWorxObject.User = New FileWorxObject.User()
    Private Sub AccountLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveClick(sender As Object, e As EventArgs) Handles SaveButton2.Click
        MainForm.CurrentUser = NameTextBox1.Text
        MainForm.CurrentLoginName = LoginNameTextBox2.Text

        AccountUser.NameFileUser = MainForm.CurrentUser
        AccountUser.NameLogin = MainForm.CurrentLoginName
        AccountUser.IDUser = MainForm.CurrentID
        AccountUser.Updata()
        MessageBox.Show("Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub EditButton1_Click(sender As Object, e As EventArgs) Handles EditButton1.Click
        SaveButton2.Visible = True
        EditButton1.Visible = False
        NameTextBox1.Enabled = True
        LoginNameTextBox2.Enabled = True


    End Sub
End Class