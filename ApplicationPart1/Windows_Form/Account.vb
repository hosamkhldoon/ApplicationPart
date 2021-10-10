Imports DTO
Public Class Account
    Private AccountUser As FileWorxObjects.User = New FileWorxObjects.User()
    Private Sub AccountLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveClick(sender As Object, e As EventArgs) Handles SaveButton2.Click
        Dim AccountUser As New UserUpdateService()
        MainForm.CurrentUser = NameTextBox1.Text
        MainForm.CurrentLoginName = LoginNameTextBox2.Text

        AccountUser.NameFileUser = MainForm.CurrentUser
        AccountUser.NameLogin = MainForm.CurrentLoginName
        Dim UserClient As New ApiClients.UserClient
        Dim Message = UserClient.UpdateUser(MainForm.CurrentID, AccountUser)
        If Not String.IsNullOrEmpty(Message) Then
            MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

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