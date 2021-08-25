Imports System.IO
Imports System.Text.RegularExpressions

Public Class NewUser

    Dim user As User = New User()
    Private Sub SaveButton2Click(sender As Object, e As EventArgs) Handles SaveButton2.Click


        Dim dir_file = "C:\Users\Hussam.Ibraheem\Desktop\First_Task\Users"
        Dim new_user As User = New User()
        Dim emptyBoxes =
           From txt In Me.Controls.OfType(Of TextBox)()
           Where txt.Text.Length = 0
           Select txt

        If emptyBoxes.Any Then
            ' display popup box
            MessageBox.Show("Please fill in all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emptyBoxes.Last().Focus()
        ElseIf user.cheacknumberOfCharcter255(NameTextBox1.Text) Then
            MessageBox.Show("please enter in box" & NameTextBox1.Name & " less then 255 charcter")
        ElseIf user.cheacknumberOfCharcter255(LoginNameTextBox2.Text) Then
            MessageBox.Show("please enter in box" & LoginNameTextBox2.Name & " less then 255 charcter")
        ElseIf user.CheackNumberOfCharcter255(PasswordTextBox3.Text) Then
            MessageBox.Show("please enter in box" & PasswordTextBox3.Name & " less then 255 charcter")
        Else
            Select Case False
                Case new_user.ValidateInput(NameTextBox1.Text, "^[a-z]*$", "Invalid Name")
                    NameTextBox1.Focus()


                Case Else
                    Try
                        new_user.Set_Value(NameTextBox1.Text, LoginNameTextBox2.Text, PasswordTextBox3.Text)
                        new_user.SaveNewUser()
                    Catch ex As DirectoryNotFoundException
                        MessageBox.Show(dir_file & "not found.", "directory not found")
                    Catch ex As IOException
                        MessageBox.Show(ex.Message, "IO Exception")
                    End Try
            End Select
        End If

    End Sub

    Private Sub CancelButton1Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub updateButton1_Click(sender As Object, e As EventArgs) Handles updateButton1.Click

        User.Set_Value(NameTextBox1.Text, LoginNameTextBox2.Text, PasswordTextBox3.Text)
        user.UpdateOtherUser()
    End Sub
End Class
