Public Class LoginForm

    Public NameUser As String
    Public LoginName As String
    Public IdUser As Integer
    Private User As FileWorxObject.User = New FileWorxObject.User()


    Private Sub LoginClick(sender As Object, e As EventArgs) Handles loginButton1.Click

        Dim Bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(passwordTextBox2.Text)
        Dim HashofBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(Bytes)
        Dim StrHash As String = Convert.ToBase64String(HashofBytes)



        User.PasswordUser = StrHash
        User.NameLogin = usernameTextBox1.Text


        If User.CheckLoginUser() Then
            Me.IdUser = User.IDBusiness
            Me.NameUser = User.NameFileUser
            Me.LoginName = User.NameLogin

            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("You don't have account", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Application.Exit()
    End Sub
End Class