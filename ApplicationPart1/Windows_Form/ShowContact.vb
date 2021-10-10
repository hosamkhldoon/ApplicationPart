Imports FileWorxObjects.QueryConditionSql
Imports DTO
Public Class ShowContact
    Private ContactQuery As New ContactQueryService()
    Public ListNews As New List(Of FileWorxObjects.News)
    Public ListPhotos As New List(Of FileWorxObjects.Photo)
    Public ListID As New List(Of Integer)
    Public Contact As New FileWorxObjects.Contact()

    Private IDBusiness As Integer
    Private Sub CancelButtonClick(sender As Object, e As EventArgs) Handles CancelButton2.Click
        Me.Close()
    End Sub
    Private Sub NewToolStripMenuItemClick(sender As Object, e As EventArgs) Handles NewtoolStripMenuItem1.Click

        Dim contact As NewContact = New NewContact()
        contact.updateButton1.Visible = False
        contact.SaveButton1.Visible = True
        contact.ShowDialog()
    End Sub
    Private Sub ShowContactLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ContactQueryClient As New ApiClients.ContactQueryClient

        Dim ListContact As List(Of FileWorxObjects.Contact) = ContactQueryClient.GetContact(ContactQuery)
        If Not ListContact Is Nothing Then
            For Each item In ListContact

                If item.TypeContact = "Transmission" Then
                    Me.ContactDataGridView.Rows.Add(item.IDBusiness, item.NameFileUser, item.TypeContact)
                End If

            Next
        End If
    End Sub
    Private Function SelectedCondition(CondtionCombobox1 As ComboBox) As Integer

        If CondtionCombobox1.Text = "start with" Then

            Return ConditionIndex.StartWith
        ElseIf CondtionCombobox1.Text = "End With" Then

            Return ConditionIndex.EndWith
        ElseIf CondtionCombobox1.Text = "Contain" Then

            Return ConditionIndex.Contain
        ElseIf CondtionCombobox1.Text = "Not start with" Then

            Return ConditionIndex.NotStartWith
        ElseIf CondtionCombobox1.Text = "Not End with" Then

            Return ConditionIndex.NotEndWith

        ElseIf CondtionCombobox1.Text = "Exists" Then

            Return ConditionIndex.Exists
        ElseIf CondtionCombobox1.Text = "Not contain" Then

            Return ConditionIndex.NotContain



        End If
        Return -1
    End Function
    Private Sub NamenameSelectedIndexChanged(sender As Object, e As EventArgs) Handles NameFiltercomboBox1.SelectedIndexChanged
        Me.NamefiltertextBox1.Enabled = True
    End Sub
    Private Sub SerarchButtonClick(sender As Object, e As EventArgs) Handles SerarchButton.Click
        Dim contactfilter As New ContactQueryService()
        If NamefiltertextBox1.Text.Length <> 0 And NamecheckBox1.Checked Then
            contactfilter.IndexConditionName = Me.SelectedCondition(NameFiltercomboBox1)
            contactfilter.QName = NamefiltertextBox1.Text
        End If
        If TypeFiltercomboBox1.Text.Length <> 0 And TypecheckBox1.Checked Then
            contactfilter.QType = TypeFiltercomboBox1.Text
        End If
        Dim ContactQueryClient As New ApiClients.ContactQueryClient
        If sqlorelasticcomboBox1.Text = "ELASTICSEARCH" Then
            contactfilter.IDSqlServerOrElsticSearch = 1
        End If
        Dim FilterContact As List(Of FileWorxObjects.Contact) = ContactQueryClient.GetContact(contactfilter)


        ContactDataGridView.Rows.Clear()
        If Not FilterContact Is Nothing Then
            For Each item In FilterContact
                ContactDataGridView.Rows.Add(item.IDBusiness, item.NameFileUser, item.TypeContact)
            Next
        End If
    End Sub
    Private Sub NameCheckedChanged(sender As Object, e As EventArgs) Handles NamecheckBox1.CheckedChanged
        If NamecheckBox1.Checked Then
            NameFiltercomboBox1.Enabled = True
        Else

            NameFiltercomboBox1.Enabled = False
            NamefiltertextBox1.Enabled = False

        End If
    End Sub
    Private Sub TypeCheckedChanged(sender As Object, e As EventArgs) Handles TypecheckBox1.CheckedChanged
        If TypecheckBox1.Checked Then
            TypeFiltercomboBox1.Enabled = True
        Else

            TypeFiltercomboBox1.Enabled = False


        End If
    End Sub
    Private Sub UserDataGridViewCellContentDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContactDataGridView.CellMouseDoubleClick

        Dim ContactClient As New ApiClients.ContactClient

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = ContactDataGridView.Rows(e.RowIndex)

            Dim ContactDilog As NewContact = New NewContact()


            Dim ReadContact As New ContactReadService()
            Contact.IDBusiness = CInt(row.Cells(0).Value)
            Contact.IDContact = CInt(row.Cells(0).Value)
            ReadContact = ContactClient.ReadContact(CInt(row.Cells(0).Value))


            ContactDilog.NameTextBox1.Text = ReadContact.NameFileUser
            ContactDilog.usernameTextBox2.Text = ReadContact.UserName
            ContactDilog.AddressTextBox4.Text = ReadContact.Address
            ContactDilog.TypeComboBox1.Visible = False
            ContactDilog.PasswordTextBox3.Visible = False
            ContactDilog.Label3.Visible = False
            ContactDilog.Label5.Visible = False
            ContactDilog.BusinessID = CInt(row.Cells(0).Value)
            ContactDilog.updateButton1.Visible = True
            ContactDilog.SaveButton1.Visible = False
            ContactDilog.ShowDialog()
            ReadContact = ContactClient.ReadContact(CInt(row.Cells(0).Value))

            row.Cells(1).Value = ReadContact.NameFileUser





        End If


    End Sub
    Private Sub DataGridViewMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContactDataGridView.CellMouseClick

        If (e.Button = MouseButtons.Right) Then




            If (e.RowIndex >= 0) Then
                Dim row As DataGridViewRow = ContactDataGridView.Rows(e.RowIndex)
                IDBusiness = CInt(row.Cells(0).Value)
            End If

            ContactContextMenuStrip1.Show(ContactDataGridView, e.Location)
            ContactContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub
    Private Sub DeleteToolStripMenuItemClick(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click

        Dim ContactClient As New ApiClients.ContactClient
        If ContactDataGridView.SelectedRows.Count > 0 Then
            Dim formdelete As DeleteForm = New DeleteForm()

            formdelete.TypeRow = "Contact"

            formdelete.ShowDialog()
            If formdelete.DialogResult = DialogResult.Yes Then
                Dim row = ContactDataGridView.SelectedRows(0)
                Dim Message = ContactClient.DeleteContact(IDBusiness)
                If Not String.IsNullOrEmpty(Message) Then
                    MessageBox.Show(Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ContactDataGridView.Rows.Remove(row)
                End If

            End If
        End If

    End Sub
    Private Sub OkButtonClick(sender As Object, e As EventArgs) Handles OkButton.Click
        Dim FileOperationClient As New ApiClients.FileOperationClient()
        Dim FileOperation As New FileTransmissionService()
        Dim selectedRows = ContactDataGridView.SelectedRows.OfType(Of DataGridViewRow)().Where(Function(row) Not row.IsNewRow).ToArray()

        For Each id In Me.ListID
            FileOperation.ListNewsId.Add(id)
        Next
        For Each row In selectedRows
            Dim contact As New FileWorxObjects.Contact
            ' contact = ContactClient.ReadContact(CInt(row.Cells(0).Value))
            FileOperation.ListContactId.Add(CInt(row.Cells(0).Value))
        Next
        Dim message = FileOperationClient.UploadFile(FileOperation)
        If Not String.IsNullOrEmpty(message) Then
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub GetAllClick(sender As Object, e As EventArgs) Handles GetAllbutton2.Click
        Dim ALLContact As New ContactQueryService()
        Dim ContactQueryClient As New ApiClients.ContactQueryClient

        Dim FilterContact As List(Of FileWorxObjects.Contact) = ContactQueryClient.GetContact(ALLContact)
        ContactDataGridView.Rows.Clear()
        If Not FilterContact Is Nothing Then
            For Each item In FilterContact
                ContactDataGridView.Rows.Add(item.IDBusiness, item.NameFileUser, item.TypeContact)
            Next
        End If
    End Sub
End Class