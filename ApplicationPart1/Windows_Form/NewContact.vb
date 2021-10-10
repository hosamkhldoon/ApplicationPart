Imports DTO
Public Class NewContact

    Private NewContact As FileWorxObjects.Contact = New FileWorxObjects.Contact()

    Public Property BusinessID() As Integer
    Private Sub SaveButtonClick(sender As Object, e As EventArgs) Handles SaveButton1.Click
        Dim NewContact As New ContactUpdateService()
        Dim Creationdate = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        Dim ContactClient As New ApiClients.ContactClient
        Dim ContactQueryClient As New ApiClients.ContactQueryClient
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
            Dim ContactQuery As New ContactQueryService()

            Dim ListContact As List(Of FileWorxObjects.Contact) = ContactQueryClient.GetContact(ContactQuery)
            If Not ListContact Is Nothing Then
                For Each item In ListContact

                    If usernameTextBox2.Text = item.UserName Then
                        flag = True
                    End If

                Next
            End If
            If flag Then
                MessageBox.Show("this User Name already found write another User Name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Dim StrHash As String = Eramake.eCryptography.Encrypt(PasswordTextBox3.Text)
                NewContact.NameFileUser = NameTextBox1.Text
                NewContact.UserName = usernameTextBox2.Text
                NewContact.Password = StrHash
                NewContact.CreationDateFileUser = Creationdate
                NewContact.TypeContact = TypeComboBox1.Text
                NewContact.Address = AddressTextBox4.Text
                Dim IdContact = ContactClient.CreateContact(NewContact)
                If Not String.IsNullOrEmpty(IdContact) Then
                    MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowContact.ContactDataGridView.Rows.Add(IdContact, NewContact.NameFileUser, NewContact.TypeContact)
                End If

            End If
        End If
    End Sub

    Private Sub UpdateButtonClick(sender As Object, e As EventArgs) Handles updateButton1.Click
        Dim ContactClient As New ApiClients.ContactClient
        Dim UpdateContact As New ContactUpdateService()

        UpdateContact.NameFileUser = NameTextBox1.Text
        UpdateContact.UserName = usernameTextBox2.Text
        UpdateContact.Password = PasswordTextBox3.Text
        UpdateContact.Address = AddressTextBox4.Text


        Dim Message = ContactClient.UpdateContact(Me.BusinessID, UpdateContact)
        If Not String.IsNullOrEmpty(Message) Then
            MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CancelButtonClick(sender As Object, e As EventArgs) Handles CancelButton2.Click
        Me.Close()
    End Sub
    Private Function NumberCharcter() As Boolean
        If NameTextBox1.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + NameTextBox1.Name + " less than 255 Charcter")
            Return True
        ElseIf usernameTextBox2.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + usernameTextBox2.Name + " less than 255 Charcter")
            Return True
        ElseIf PasswordTextBox3.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + PasswordTextBox3.Name + " less than 255 Charcter")
            Return True
        ElseIf AddressTextBox4.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + PasswordTextBox3.Name + " less than 255 Charcter")
            Return True

        Else
            Return False
        End If
    End Function
End Class