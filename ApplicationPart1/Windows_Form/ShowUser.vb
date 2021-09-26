

Imports FileWorxObjects.BusinessQuery
Imports FileWorxObjects.QueryConditionSql

Public Class ShowUser
    Public DictionaryUser As New Dictionary(Of String, Dictionary(Of String, String))

    Private IDBusiness As Integer
    Private BusinessObject As FileWorxObjects.BusinessObject = New FileWorxObjects.BusinessObject()
    Private Users As FileWorxObjects.User = New FileWorxObjects.User()
    Private UserQuery As FileWorxObjects.UserQuery = New FileWorxObjects.UserQuery()

    Private Sub ShowUserLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserQueryClient As New ApiClients.UserQueryClient

        Dim ListUser As List(Of FileWorxObjects.User) = UserQueryClient.GetUsers(UserQuery)

        If Not ListUser Is Nothing Then
            For Each item In ListUser

                If MainForm.CurrentID <> item.IDBusiness Then
                    UserDataGridView1.Rows.Add(item.IDBusiness, item.NameFileUser, item.CreationDateFileUser, item.NameLogin, item.LastModifierUser)
                End If

            Next
        End If




    End Sub
    Private Sub UserDataGridViewCellContentDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDataGridView1.CellMouseDoubleClick

        Dim UserClient As New ApiClients.UserClient

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = UserDataGridView1.Rows(e.RowIndex)







            Dim UserDilog As NewUser = New NewUser()



            Users.IDBusiness = CInt(row.Cells(0).Value)
            Users.IDUser = CInt(row.Cells(0).Value)
            Users = UserClient.ReadUser(CInt(row.Cells(0).Value))


            UserDilog.NameTextBox1.Text = Users.NameFileUser
            UserDilog.LoginNameTextBox2.Text = Users.NameLogin
            UserDilog.TypeComboBox1.Text = Users.TypeUser
            UserDilog.PasswordTextBox3.Visible = False
            UserDilog.Label3.Visible = False
            UserDilog.BusinessID = CInt(row.Cells(0).Value)
            UserDilog.updateButton1.Visible = True
            UserDilog.SaveButton2.Visible = False
            UserDilog.ShowDialog()
            Users = UserClient.ReadUser(CInt(row.Cells(0).Value))

            row.Cells(1).Value = Users.NameFileUser

            row.Cells(3).Value = Users.NameLogin
            row.Cells(4).Value = Users.LastModifierUser


        End If


    End Sub
    Private Sub DataGridViewMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDataGridView1.CellMouseClick

        If (e.Button = MouseButtons.Right) Then




            If (e.RowIndex >= 0) Then
                Dim row As DataGridViewRow = UserDataGridView1.Rows(e.RowIndex)
                IDBusiness = CInt(row.Cells(0).Value)
            End If

            UserContextMenuStrip1.Show(UserDataGridView1, New Point(e.X, e.Y))

        End If
    End Sub
    Private Sub DeleteToolStripMenuItemClick(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        Dim UserClient As New ApiClients.UserClient
        If UserDataGridView1.SelectedRows.Count > 0 Then
            Dim formdelete As DeleteForm = New DeleteForm()

            formdelete.TypeRow = "User"

            formdelete.ShowDialog()
            If formdelete.DialogResult = DialogResult.Yes Then
                Dim row = UserDataGridView1.SelectedRows(0)
                UserClient.DeleteUser(IDBusiness)

                UserDataGridView1.Rows.Remove(row)
            End If
        End If

    End Sub








    Private Function SelectedCondition(ConditionCombobox1 As ComboBox) As Integer
        If ConditionCombobox1.Text = "start with" Then

            Return ConditionIndex.StartWith
        ElseIf ConditionCombobox1.Text = "End With" Then

            Return ConditionIndex.EndWith
        ElseIf ConditionCombobox1.Text = "Contain" Then

            Return ConditionIndex.Contain
        ElseIf ConditionCombobox1.Text = "Not start with" Then

            Return ConditionIndex.NotStartWith
        ElseIf ConditionCombobox1.Text = "Not End with" Then

            Return ConditionIndex.NotEndWith

        ElseIf ConditionCombobox1.Text = "Exists" Then

            Return ConditionIndex.Exists
        ElseIf ConditionCombobox1.Text = "Not contain" Then

            Return ConditionIndex.NotContain
        ElseIf ConditionCombobox1.Text = "Between" Then

            Return ConditionIndex.Between
        ElseIf ConditionCombobox1.Text = "Greater than" Then

            Return ConditionIndex.GreaterThan

        ElseIf ConditionCombobox1.Text = "Less Than" Then

            Return ConditionIndex.LessThan
        ElseIf ConditionCombobox1.Text = "Greater or Equal" Then

            Return ConditionIndex.GreaterOrequal
        ElseIf ConditionCombobox1.Text = "Less or equal" Then

            Return ConditionIndex.LessOrEqual
        ElseIf ConditionCombobox1.Text = "Not equal" Then


            Return ConditionIndex.NotEqual
        ElseIf ConditionCombobox1.Text = "Equal" Then

            Return ConditionIndex.Equal



        End If
        Return -1
    End Function



    Private Sub IntegerSelectedIndexChanged(sender As Object, e As EventArgs) Handles IDComboBox1.SelectedIndexChanged
        Me.IDTextBox1.Enabled = True
        If IDComboBox1.Text = "Between" Then
            Me.seconedidTextBox1.Enabled = True
        End If
    End Sub


    Private Sub StringSelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox2.SelectedIndexChanged
        Me.NameTextBox2.Enabled = True
        If NameComboBox2.Text = "Between" Then
            Me.seconednameTextBox1.Enabled = True
        End If
    End Sub


    Private Sub LoginnameSelectedIndexChanged(sender As Object, e As EventArgs) Handles loginnameComboBox1.SelectedIndexChanged
        Me.LoginnameTextBox3.Enabled = True
        If loginnameComboBox1.Text = "Between" Then
            Me.seconedloginTextBox1.Enabled = True
        End If
    End Sub

    Private Sub LastModifierSelectedIndexChanged(sender As Object, e As EventArgs) Handles lastmodifierComboBox1.SelectedIndexChanged
        Me.LastmodifierTextBox4.Enabled = True
        If lastmodifierComboBox1.Text = "Between" Then
            Me.seconedmodiferTextBox1.Enabled = True
        End If
    End Sub

    Private Sub SearchClick(sender As Object, e As EventArgs) Handles searchButton1.Click
        Dim userfilter As FileWorxObjects.UserQuery = New FileWorxObjects.UserQuery()
        If IDTextBox1.Text.Length <> 0 And IDCheckBox1.Checked Then
            userfilter.SeconedValueID = Me.SeconedValue(seconedidTextBox1, IDComboBox1)
            userfilter.IndexConditionID = Me.SelectedCondition(IDComboBox1)
            userfilter.QID = IDTextBox1.Text


        End If
        If NameTextBox2.Text.Length <> 0 And nameCheckBox1.Checked Then
            userfilter.SeconedValueName = Me.SeconedValue(seconednameTextBox1, NameComboBox2)
            userfilter.IndexConditionName = Me.SelectedCondition(NameComboBox2)

            userfilter.QName = NameTextBox2.Text


        End If
        If LastmodifierTextBox4.Text.Length <> 0 And lastmodifierCheckBox1.Checked Then
            userfilter.SeconedValueLastModifier = Me.SeconedValue(seconedmodiferTextBox1, lastmodifierComboBox1)
            userfilter.IndexConditionLastModifier = Me.SelectedCondition(lastmodifierComboBox1)

            userfilter.QLastModifier = LastmodifierTextBox4.Text


        End If
        If dateCheckBox1.Checked Then
            userfilter.SeconedValueCreationDate = Me.SeconedDate()
            userfilter.QCreationDate = Format(userDateTimePicker1.Value, "yyyy-MM-dd")
            userfilter.IndexConditionCreationDate = Me.SelectedCondition(dateComboBox1)

        End If
        If LoginnameTextBox3.Text.Length <> 0 And loginnameCheckBox1.Checked Then
            userfilter.SeconedValueLoginName = Me.SeconedValue(seconedloginTextBox1, loginnameComboBox1)
            userfilter.IndexConditionLoginName = Me.SelectedCondition(loginnameComboBox1)

            userfilter.QLoginName = LoginnameTextBox3.Text


        End If
        Dim UserQueryClient As New ApiClients.UserQueryClient
        If SqlOrElasticComboBox.Text = "ELASTICSEARCH" Then
            userfilter.IDSqlServerOrElsticSearch = 1
        End If
        Dim FilterUsers As List(Of FileWorxObjects.User) = UserQueryClient.GetUsers(userfilter)


        UserDataGridView1.Rows.Clear()
        If Not FilterUsers Is Nothing Then
            For Each item In FilterUsers
                UserDataGridView1.Rows.Add(item.IDBusiness, item.NameFileUser, item.CreationDateFileUser, item.NameLogin, item.LastModifierUser)
            Next
        End If

    End Sub
    Private Function SeconedValue(textbox1 As TextBox, betweencombobox As ComboBox) As String
        If betweencombobox.Text = "Between" Then

            If textbox1.Text.Length <> 0 Then
                Return textbox1.Text
            Else
                MessageBox.Show("Please fill Seconed Box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        Return ""
    End Function
    Private Function SeconedDate() As String
        If dateComboBox1.Text = "Between" Then


            Return Format(seconedDateTimePicker1.Value, "yyyy-MM-dd")


        End If
        Return ""
    End Function

    Private Sub LastModifierCheckedChanged(sender As Object, e As EventArgs) Handles lastmodifierCheckBox1.CheckedChanged
        If lastmodifierCheckBox1.Checked Then
            lastmodifierComboBox1.Enabled = True
        Else

            lastmodifierComboBox1.Enabled = False
            LastmodifierTextBox4.Enabled = False
            seconedmodiferTextBox1.Enabled = False
        End If
    End Sub

    Private Sub LoginnameCheckedChanged(sender As Object, e As EventArgs) Handles loginnameCheckBox1.CheckedChanged
        If loginnameCheckBox1.Checked Then
            loginnameComboBox1.Enabled = True
        Else

            loginnameComboBox1.Enabled = False
            LoginnameTextBox3.Enabled = False
            seconedloginTextBox1.Enabled = False
        End If
    End Sub

    Private Sub NameCheckedChanged(sender As Object, e As EventArgs) Handles nameCheckBox1.CheckedChanged
        If nameCheckBox1.Checked Then
            NameComboBox2.Enabled = True
        Else

            NameComboBox2.Enabled = False
            NameTextBox2.Enabled = False
            seconednameTextBox1.Enabled = False
        End If
    End Sub

    Private Sub IDCheckedChanged(sender As Object, e As EventArgs) Handles IDCheckBox1.CheckedChanged
        If IDCheckBox1.Checked Then
            IDComboBox1.Enabled = True
        Else

            IDComboBox1.Enabled = False
            IDTextBox1.Enabled = False
            seconedidTextBox1.Enabled = False
        End If
    End Sub

    Private Sub DateSelectedIndexChanged(sender As Object, e As EventArgs) Handles dateComboBox1.SelectedIndexChanged
        userDateTimePicker1.Enabled = True

        If dateComboBox1.Text = "Between" Then
            Me.seconedDateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub DateCheckedChanged(sender As Object, e As EventArgs) Handles dateCheckBox1.CheckedChanged
        If dateCheckBox1.Checked Then
            dateComboBox1.Enabled = True
        Else

            userDateTimePicker1.Enabled = False
            dateComboBox1.Enabled = False
            seconedDateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub ResetClick(sender As Object, e As EventArgs) Handles ResetButton2.Click
        UserDataGridView1.Rows.Clear()
        Dim UserQueryClient As New ApiClients.UserQueryClient

        Dim ListUser As List(Of FileWorxObjects.User) = UserQueryClient.GetUsers(UserQuery)
        If Not ListUser Is Nothing Then
            For Each item In ListUser

                If MainForm.CurrentID <> item.IDBusiness Then
                    UserDataGridView1.Rows.Add(item.IDBusiness, item.NameFileUser, item.CreationDateFileUser, item.NameLogin, item.LastModifierUser)
                End If

            Next
        End If
    End Sub
End Class