Imports DTO
Public Class LoginForm

    Public NameUser As String
    Public LoginName As String
    Public IdUser As Integer
    Private User As FileWorxObjects.User = New FileWorxObjects.User()


    Private Sub LoginClick(sender As Object, e As EventArgs) Handles loginButton1.Click

        Dim Bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(passwordTextBox2.Text)
        Dim HashofBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(Bytes)
        Dim StrHash As String = Convert.ToBase64String(HashofBytes)
        Dim UserClient As New ApiClients.UserClient()
        Dim UserLogin As New UserCeackLogin()
        UserLogin.PasswordUser = StrHash
        UserLogin.NameLogin = usernameTextBox1.Text
        UserLogin = UserClient.LoginUser(UserLogin)




        If Not UserLogin Is Nothing Then
            If UserLogin.TypeUser = "Admin" Then
                Me.IdUser = UserLogin.IDBusiness
                Me.NameUser = UserLogin.NameFileUser
                Me.LoginName = UserLogin.NameLogin

                Me.DialogResult = DialogResult.OK
            Else
                MessageBox.Show("You are Not Admin", "Not Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("You don't have account", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Application.Exit()
    End Sub
End Class