Imports System.IO
Imports System.Text.RegularExpressions
Imports FileWorxObjects.BusinessQuery

Public Class NewUser


    Private NewUser As FileWorxObjects.User = New FileWorxObjects.User()



    Private idbusiness As Integer
    Public Property BusinessID() As Integer
        Get
            Return idbusiness
        End Get
        Set(ByVal value As Integer)
            idbusiness = value
        End Set
    End Property
    Private Sub SaveClick(sender As Object, e As EventArgs) Handles SaveButton2.Click


        Dim Creation_date = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        Dim UserClient As New ApiClients.UserClient
        Dim UserQueryClient As New ApiClients.UserQueryClient
        Dim emptyBoxes =
           From txt In Me.Controls.OfType(Of TextBox)()
           Where txt.Text.Length = 0
           Select txt

        If emptyBoxes.Any Then
            ' display popup box
            MessageBox.Show("Please fill in all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emptyBoxes.Last().Focus()
        ElseIf NumberCharcter() Then

        Else
            Dim flag As Boolean = False
            Dim UserQuery As FileWorxObjects.UserQuery = New FileWorxObjects.UserQuery()



            Dim ListUser As List(Of FileWorxObjects.User) = UserQueryClient.GetAllUser(UserQuery)
            If Not ListUser Is Nothing Then
                For Each item In ListUser

                    If LoginNameTextBox2.Text = item.NameLogin Then
                        flag = True
                    End If

                Next
            End If
            If flag Then
                MessageBox.Show("this login name already found write another login name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim Bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(PasswordTextBox3.Text)
                Dim HashofBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(Bytes)
                Dim StrHash As String = Convert.ToBase64String(HashofBytes)

                NewUser.NameFileUser = NameTextBox1.Text
                NewUser.NameLogin = LoginNameTextBox2.Text
                NewUser.IDUser = -1
                NewUser.ClassIDFileOrUser = 3
                NewUser.PasswordUser = StrHash
                NewUser.CreationDateFileUser = Creation_date
                NewUser.TypeUser = TypeComboBox1.Text
                NewUser.LastModifierUser = ""
                UserClient.CreateUser(NewUser)
                MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub UpdateClick(sender As Object, e As EventArgs) Handles updateButton1.Click


        Dim UserClient As New ApiClients.UserClient


        NewUser.NameFileUser = NameTextBox1.Text
        NewUser.NameLogin = LoginNameTextBox2.Text

        NewUser.PasswordUser = PasswordTextBox3.Text
        NewUser.LastModifierUser = MainForm.CurrentUser
        UserClient.UpdateUser(Me.BusinessID, NewUser)

        MessageBox.Show("Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function NumberCharcter() As Boolean
        If NameTextBox1.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + NameTextBox1.Name + " less than 255 Charcter")
            Return True
        ElseIf LoginNameTextBox2.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + LoginNameTextBox2.Name + " less than 255 Charcter")
            Return True
        ElseIf PasswordTextBox3.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + PasswordTextBox3.Name + " less than 255 Charcter")
            Return True
        Else
            Return False
        End If
    End Function
End Class
