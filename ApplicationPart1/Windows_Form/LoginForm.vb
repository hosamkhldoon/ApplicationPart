Public Class LoginForm
    Public ArrayCurrentUser As New Dictionary(Of String, String)
    Public Name As String
    Public LoginName As String
    Private Sub loginButton1_Click(sender As Object, e As EventArgs) Handles loginButton1.Click
        Dim Dictionarylogin As New Dictionary(Of String, Dictionary(Of String, String))
        Dim user As User = New User()

        Dim flag As Boolean = False
        user.GetDataUser(Dictionarylogin)
        For Each key As String In Dictionarylogin.Keys
            Dim password = Dictionarylogin.Item(key).Item("password")
            If usernameTextBox1.Text = key And passwordTextBox2.Text = password Then
                Name = Dictionarylogin.Item(key).Item("Name")
                LoginName = Dictionarylogin.Item(key).Item("LoginName")
                flag = True
                Me.DialogResult = DialogResult.OK

            End If


        Next
        If Not flag Then
            MessageBox.Show("You don't have account", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CancelButton1_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Application.Exit()
    End Sub
End Class