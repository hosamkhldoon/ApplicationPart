Imports System.IO
Imports FileWorxObject.BusinessQuery
Imports FileWorxObject.QueryCondition

Public Class MainForm
    Private IDBusiness As Integer


    Public CurrentUser As String
    Public CurrentLoginName As String
    Public CurrentID As Integer

    Private FileFromNewsPhoto As FileWorxObject.File = New FileWorxObject.File()
    Private BusinessQuery As FileWorxObject.BusinessQuery = New FileWorxObject.BusinessQuery()
    Private fileQuery As FileWorxObject.FileQuery = New FileWorxObject.FileQuery()
    Private BusinessObject As FileWorxObject.BusinessObject = New FileWorxObject.BusinessObject()
    Private NewNew As FileWorxObject.News = New FileWorxObject.News()
    Private NewPhoto As FileWorxObject.photo = New FileWorxObject.photo()
    Private NewsQuery As FileWorxObject.NewsQuery = New FileWorxObject.NewsQuery()
    Private PhotoQuery As FileWorxObject.PhotoQuery = New FileWorxObject.PhotoQuery()
    Private services As FileWorxObject.QueryCondition = New FileWorxObject.QueryCondition()


    Private condition As String = ""

    Private Sub UserToolStripMenuItemClick(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click

        Dim user As NewUser = New NewUser()

        user.updateButton1.Visible = False
        user.SaveButton2.Visible = True
        user.ShowDialog()
    End Sub

    Private Sub NewsToolStripMenuItemClick(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem.Click

        Dim news As NewNews = New NewNews()
        news.UpdateButton1.Visible = False
        news.SaveButton2.Visible = True
        news.ShowDialog()
    End Sub

    Private Sub PhotoToolStripMenuItemClick(sender As Object, e As EventArgs) Handles PhotoToolStripMenuItem.Click

        Dim photo As NewPhoto = New NewPhoto()
        photo.UpdateButton1.Visible = False
        photo.SaveButton1.Visible = True
        photo.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItemClick(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub NewsPhotoDataGridView1CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NewsPhotoDataGridView1.CellMouseClick




        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = NewsPhotoDataGridView1.Rows(e.RowIndex)

            VisibleControls()
            BusinessObject.IDBusiness = CInt(row.Cells(0).Value)
            BusinessObject.Read()
            If BusinessObject.ClassIDFileOrUser = 1 Then 'news preview
                imagePictureBox1.Visible = False
                categoryLabel3.Visible = True
                categoryComboBox1.Visible = True
                NewNew.IDNews = CInt(row.Cells(0).Value)
                NewNew.IDFile = CInt(row.Cells(0).Value)
                NewNew.IDBusiness = CInt(row.Cells(0).Value)
                NewNew.Read()
                titleTextBox1.Text = NewNew.NameFileUser
                CreationdateTextBox3.Text = NewNew.CreationDateFileUser
                categoryComboBox1.Text = NewNew.CategoryNews
                previewTextBox1.Text = NewNew.BodyNewsPhoto
            ElseIf BusinessObject.ClassIDFileOrUser = 2 Then 'photo preview
                categoryLabel3.Visible = False
                categoryComboBox1.Visible = False
                imagePictureBox1.Visible = True
                NewPhoto.IDPhoto = CInt(row.Cells(0).Value)
                NewPhoto.IDFile = CInt(row.Cells(0).Value)
                NewPhoto.IDBusiness = CInt(row.Cells(0).Value)
                NewPhoto.Read()
                titleTextBox1.Text = NewPhoto.NameFileUser
                CreationdateTextBox3.Text = NewPhoto.CreationDateFileUser
                previewTextBox1.Text = NewPhoto.BodyNewsPhoto
                If NewPhoto.LocationPhoto <> "" Then
                    imagePictureBox1.Image?.Dispose()
                    imagePictureBox1.Image = New Bitmap(NewPhoto.LocationPhoto)
                    imagePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                End If
            End If



        End If

    End Sub
    Private Sub DataGridView1MouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NewsPhotoDataGridView1.CellMouseClick 'show list contain delete for this row

        If (e.Button = MouseButtons.Right) Then




            If (e.RowIndex >= 0) Then
                Dim row As DataGridViewRow = NewsPhotoDataGridView1.Rows(e.RowIndex)
                IDBusiness = CInt(row.Cells(0).Value)

            End If

            ContextMenuStrip1.Show(NewsPhotoDataGridView1, New Point(e.X, e.Y))

        End If
    End Sub
    Private Sub VisibleControls()
        titleLabel1.Visible = True
        dateLabel2.Visible = True
        titleTextBox1.Visible = True
        CreationdateTextBox3.Visible = True

        TabControl1.Visible = True
    End Sub
    Private Sub NewsPhotoDataGridView1CellContentDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NewsPhotoDataGridView1.CellMouseDoubleClick

        Dim dic_local As New Dictionary(Of String, String)

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = NewsPhotoDataGridView1.Rows(e.RowIndex)

            BusinessObject.IDBusiness = CInt(row.Cells(0).Value)
            BusinessObject.Read()

            If BusinessObject.ClassIDFileOrUser = 1 Then 'news update


                Dim NewsDilog As NewNews = New NewNews()
                NewsDilog.FileID = CInt(row.Cells(0).Value)
                NewsDilog.NewsID = CInt(row.Cells(0).Value)
                NewNew.IDNews = CInt(row.Cells(0).Value)
                NewNew.IDFile = CInt(row.Cells(0).Value)
                NewNew.IDBusiness = CInt(row.Cells(0).Value)
                NewNew.Read()

                NewsDilog.TitleTextBox1.Text = NewNew.NameFileUser
                NewsDilog.DescriptionTextBox2.Text = NewNew.DescriptionNewsPhoto
                NewsDilog.ComboBox1.Text = NewNew.CategoryNews
                NewsDilog.BodyTextBox3.Text = NewNew.BodyNewsPhoto
                NewsDilog.BusinessID = CInt(row.Cells(0).Value)
                NewsDilog.UpdateButton1.Visible = True
                NewsDilog.SaveButton2.Visible = False
                NewsDilog.ShowDialog()
                NewNew.Read()
                row.Cells(1).Value = NewNew.NameFileUser

                row.Cells(3).Value = NewNew.DescriptionNewsPhoto


            ElseIf BusinessObject.ClassIDFileOrUser = 2 Then 'photo update

                Dim PhotoDilog As NewPhoto = New NewPhoto()
                PhotoDilog.FileID = CInt(row.Cells(0).Value)
                PhotoDilog.PhotoID = CInt(row.Cells(0).Value)
                NewPhoto.IDPhoto = CInt(row.Cells(0).Value)
                NewPhoto.IDFile = CInt(row.Cells(0).Value)
                NewPhoto.IDBusiness = CInt(row.Cells(0).Value)
                NewPhoto.Read()
                If NewPhoto.LocationPhoto <> "" Then
                    imagePictureBox1.Image?.Dispose()
                    PhotoDilog.ImagePictureBox1.Image = New Bitmap(NewPhoto.LocationPhoto)
                    PhotoDilog.ImagePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                End If
                PhotoDilog.PathLabel1.Text = NewPhoto.LocationPhoto
                PhotoDilog.TitleTextBox1.Text = NewPhoto.NameFileUser
                PhotoDilog.DescriptionTextBox2.Text = NewPhoto.DescriptionNewsPhoto
                PhotoDilog.BodyTextBox3.Text = NewPhoto.BodyNewsPhoto
                PhotoDilog.BusinessID = CInt(row.Cells(0).Value)
                PhotoDilog.UpdateButton1.Visible = True
                PhotoDilog.SaveButton1.Visible = False
                Me.DisposePictureBox()
                PhotoDilog.ShowDialog()
                NewPhoto.Read()
                row.Cells(1).Value = NewPhoto.NameFileUser

                row.Cells(3).Value = NewPhoto.DescriptionNewsPhoto

            End If




        End If


    End Sub

    Private Sub DeleteToolStripMenuItemClick(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If NewsPhotoDataGridView1.SelectedRows.Count > 0 Then
            Dim index As Integer
            Dim formdelete As DeleteForm = New DeleteForm()
            BusinessObject.IDBusiness = IDBusiness
            BusinessObject.Read()
            If BusinessObject.ClassIDFileOrUser = 1 Then
                formdelete.TypeRow = "News"

            Else
                formdelete.TypeRow = "Photo"

            End If
            formdelete.ShowDialog()
            If formdelete.DialogResult = DialogResult.Yes Then 'delete news or photo
                Dim deletephoto As FileWorxObject.photo = New FileWorxObject.photo()
                deletephoto.IDPhoto = IDBusiness
                deletephoto.IDBusiness = IDBusiness
                deletephoto.IDFile = IDBusiness
                deletephoto.Read()

                If BusinessObject.ClassIDFileOrUser = 2 Then ' delete photo from folder
                    If deletephoto.LocationPhoto <> "" Then

                        If File.Exists(deletephoto.LocationPhoto) Then
                            Me.DisposePictureBox()
                            File.Delete(deletephoto.LocationPhoto)
                        End If
                    End If
                End If
                Dim SelectRow As New DataGridViewRow

                index = NewsPhotoDataGridView1.SelectedRows.Item(0).Index
                SelectRow = NewsPhotoDataGridView1.Rows.Item(index)

                BusinessObject.Delete()
                NewsPhotoDataGridView1.Rows.Remove(SelectRow)

            End If

        End If


    End Sub
    Private Sub DisposePictureBox()
        If Not imagePictureBox1.Image Is Nothing Then
            imagePictureBox1.Image.Dispose()
        End If
    End Sub


    Private Sub UsersToolStripMenuItemClick(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click 'show user in datagridview
        Dim user As ShowUser = New ShowUser()

        user.ShowDialog()
    End Sub

    Private Sub MyAccountToolStripMenuItemClick(sender As Object, e As EventArgs) Handles MyAccountToolStripMenuItem.Click 'show account current user and can update
        Dim MyAccount As Account = New Account()
        MyAccount.NameTextBox1.Text = CurrentUser
        MyAccount.LoginNameTextBox2.Text = CurrentLoginName
        MyAccount.NameTextBox1.Enabled = False
        MyAccount.LoginNameTextBox2.Enabled = False
        MyAccount.EditButton1.Visible = True
        MyAccount.SaveButton2.Visible = False
        MyAccount.ShowDialog()
    End Sub



    Private Sub OpenToolStripMenuItemClick(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim businessQuyrywhenopen As FileWorxObject.BusinessQuery = New FileWorxObject.BusinessQuery()
        businessQuyrywhenopen.Run()
        For Each item In businessQuyrywhenopen.ListNewsAndPhotos
            If Not BusinessQuery.ListNewsAndPhotos.Contains(item) Then
                NewsPhotoDataGridView1.Rows.Add(item.IDBusiness, item.NameFileUser, item.CreationDateFileUser, item.DescriptionNewsPhoto)
            End If
        Next

    End Sub

    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Add any initialization after the InitializeComponent() call.
        Dim loginscreen As LoginForm = New LoginForm()

        loginscreen.ShowDialog()

        If loginscreen.DialogResult = DialogResult.OK Then
            CurrentID = loginscreen.IdUser
            CurrentUser = loginscreen.NameUser
            CurrentLoginName = loginscreen.LoginName
            MessageBox.Show("Hello " + Me.CurrentUser)

            ''DONOT InitializeComponent()

            BusinessQuery.Run()
            If Not BusinessQuery.ListNewsAndPhotos Is Nothing Then
                For Each item In BusinessQuery.ListNewsAndPhotos
                    NewsPhotoDataGridView1.Rows.Add(item.IDBusiness, item.NameFileUser, item.CreationDateFileUser, item.DescriptionNewsPhoto)
                Next
            End If

        Else


            Me.Dispose()

        End If

    End Sub

    Private Sub LogoutToolStripMenuItemClick(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Me.Hide()
        LoginForm.Show()

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
        ElseIf CondtionCombobox1.Text = "Between" Then

            Return ConditionIndex.Between
        ElseIf CondtionCombobox1.Text = "Greater than" Then

            Return ConditionIndex.GreaterThan

        ElseIf CondtionCombobox1.Text = "Less Than" Then

            Return ConditionIndex.LessThan
        ElseIf CondtionCombobox1.Text = "Greater Or Equal" Then

            Return ConditionIndex.GreaterOrequal
        ElseIf CondtionCombobox1.Text = "Less Or equal" Then

            Return ConditionIndex.LessOrEqual
        ElseIf CondtionCombobox1.Text = "Not equal" Then


            Return ConditionIndex.NotEqual
        ElseIf CondtionCombobox1.Text = "Equal" Then

            Return ConditionIndex.Equal


        End If
        Return -1
    End Function


    Private Sub IntergerSelectedIndexChanged(sender As Object, e As EventArgs) Handles ClassComboBox1.SelectedIndexChanged
        ClassidTextBox6.Enabled = True
        If ClassComboBox1.Text = "Between" Then
            seconedclassTextBox3.Enabled = True
        End If
    End Sub

    Private Sub StringSelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox2.SelectedIndexChanged
        CategoryTextBox3.Enabled = True
        If categoryComboBox1.Text = "Between" Then
            seconedcategoryTextBox1.Enabled = True
        End If
    End Sub














    Private Sub DateSelectedIndexChanged(sender As Object, e As EventArgs) Handles DateComboBox4.SelectedIndexChanged
        DateTimePicker1.Enabled = True
        If DateComboBox4.Text = "Between" Then
            seconedDateTimePicker2.Enabled = True
        End If
    End Sub

    Private Sub DescriptionSelectedIndexChanged(sender As Object, e As EventArgs) Handles DescriptionComboBox1.SelectedIndexChanged
        DescriptionTextBox2.Enabled = True
        If DescriptionComboBox1.Text = "Between" Then
            seconeddesTextBox4.Enabled = True
        End If
    End Sub

    Private Sub TitleSelectedIndexChanged(sender As Object, e As EventArgs) Handles titleComboBox2.SelectedIndexChanged
        TitleTextBox5.Enabled = True
        If titleComboBox2.Text = "Between" Then
            seconedtextTextBox5.Enabled = True
        End If
    End Sub

    Private Sub IDSelectedIndexChanged(sender As Object, e As EventArgs) Handles IdComboBox3.SelectedIndexChanged
        IDfilterTextBox1.Enabled = True
        If IdComboBox3.Text = "Between" Then
            seconedIDTextBox6.Enabled = True
        End If
    End Sub

    Private Sub IDCheckedChanged(sender As Object, e As EventArgs) Handles IDCheckBox5.CheckedChanged
        If IDCheckBox5.Checked Then

            IdComboBox3.Enabled = True
        Else
            IDfilterTextBox1.Enabled = False
            IdComboBox3.Enabled = False
            seconedIDTextBox6.Enabled = False
        End If
    End Sub

    Private Sub TitleCheckedChanged(sender As Object, e As EventArgs) Handles TitleCheckBox4.CheckedChanged
        If TitleCheckBox4.Checked Then

            titleComboBox2.Enabled = True
        Else
            TitleTextBox5.Clear()
            TitleTextBox5.Enabled = False
            titleComboBox2.Enabled = False
            seconedtextTextBox5.Enabled = False
        End If
    End Sub

    Private Sub DescriptionCheckedChanged(sender As Object, e As EventArgs) Handles DescriptionCheckBox3.CheckedChanged
        If DescriptionCheckBox3.Checked Then

            DescriptionComboBox1.Enabled = True
        Else
            DescriptionTextBox2.Clear()
            DescriptionTextBox2.Enabled = False
            DescriptionComboBox1.Enabled = False
            seconeddesTextBox4.Enabled = False
        End If
    End Sub

    Private Sub ClassCheckedChanged(sender As Object, e As EventArgs) Handles ClassCheckBox2.CheckedChanged
        If ClassCheckBox2.Checked Then

            ClassComboBox1.Enabled = True
        Else
            ClassidTextBox6.Clear()
            ClassidTextBox6.Enabled = False
            ClassComboBox1.Enabled = False
            seconedclassTextBox3.Enabled = False
        End If
    End Sub

    Private Sub DateCheckedChanged(sender As Object, e As EventArgs) Handles DateCheckBox1.CheckedChanged
        If DateCheckBox1.Checked Then

            DateComboBox4.Enabled = True

        Else
            DateTimePicker1.ResetText()
            DateTimePicker1.Enabled = False
            DateComboBox4.Enabled = False
            seconedDateTimePicker2.Enabled = False
            seconedDateTimePicker2.ResetText()
        End If
    End Sub

    Private Sub CategoryCheckedChanged(sender As Object, e As EventArgs) Handles CategoryCheckBox1.CheckedChanged
        If CategoryCheckBox1.Checked Then

            categoryComboBox1.Enabled = True
        Else
            CategoryTextBox3.Clear()
            CategoryTextBox3.Enabled = False
            categoryComboBox1.Enabled = False
            seconedcategoryTextBox1.Enabled = False
        End If
    End Sub

    Private Sub SearchClick(sender As Object, e As EventArgs) Handles SearchButton1.Click
        Dim filefilter As FileWorxObject.FileQuery = New FileWorxObject.FileQuery()
        If IDfilterTextBox1.Text.Length <> 0 And IDCheckBox5.Checked Then
            filefilter.ListIndex(FilterIndex.ID) = Me.SelectedCondition(IdComboBox3)
            filefilter.ListSeconedValue(FilterIndex.ID) = Me.SeconedValue(seconedIDTextBox6, IdComboBox3)
            filefilter.QID = IDfilterTextBox1.Text



        End If

        If DescriptionTextBox2.Text.Length <> 0 And DescriptionCheckBox3.Checked Then
            filefilter.ListIndex(FilterIndex.Description) = Me.SelectedCondition(DescriptionComboBox1)
            filefilter.ListSeconedValue(FilterIndex.Description) = Me.SeconedValue(seconeddesTextBox4, IdComboBox3)

            filefilter.QDescription = DescriptionTextBox2.Text


        End If
        If DateCheckBox1.Checked Then
            filefilter.ListIndex(FilterIndex.CreationDate) = Me.SelectedCondition(DateComboBox4)
            filefilter.ListSeconedValue(FilterIndex.CreationDate) = Me.SeconedDate()

            filefilter.QCreationDate = Format(DateTimePicker1.Value, "yyyy-MM-dd")


        End If
        If TitleTextBox5.Text.Length <> 0 And TitleCheckBox4.Checked Then
            filefilter.ListIndex(FilterIndex.Name) = Me.SelectedCondition(titleComboBox2)
            filefilter.ListSeconedValue(FilterIndex.Name) = Me.SeconedValue(seconedtextTextBox5, titleComboBox2)

            filefilter.QName = TitleTextBox5.Text


        End If
        If ClassidTextBox6.Text.Length <> 0 And ClassCheckBox2.Checked Then
            filefilter.ListIndex(FilterIndex.ClassID) = Me.SelectedCondition(ClassComboBox1)
            filefilter.ListSeconedValue(FilterIndex.ClassID) = Me.SeconedValue(seconedclassTextBox3, ClassComboBox1)

            filefilter.QClassID = ClassidTextBox6.Text


        End If



        filefilter.Run()

        NewsPhotoDataGridView1.Rows.Clear()

        If Not filefilter.ListNewsAndPhotos Is Nothing Then
            For Each item In filefilter.ListNewsAndPhotos
                NewsPhotoDataGridView1.Rows.Add(item.IDBusiness, item.NameFileUser, item.CreationDateFileUser, item.DescriptionNewsPhoto)
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
        If DateComboBox4.Text = "Between" Then


            Return Format(seconedDateTimePicker2.Value, "yyyy-MM-dd")


        End If
        Return ""
    End Function
    Private Sub ResetClick(sender As Object, e As EventArgs) Handles ResetButton2.Click
        NewsPhotoDataGridView1.Rows.Clear()
        If Not BusinessQuery.ListNewsAndPhotos Is Nothing Then
            For Each item In BusinessQuery.ListNewsAndPhotos
                NewsPhotoDataGridView1.Rows.Add(item.IDBusiness, item.NameFileUser, item.CreationDateFileUser, item.DescriptionNewsPhoto)
            Next
        End If
    End Sub


End Class