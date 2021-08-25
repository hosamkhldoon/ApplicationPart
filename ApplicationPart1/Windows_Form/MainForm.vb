Imports System.IO

Public Class MainForm
    Private Shared title As String
    Public DictionaryMain As New Dictionary(Of String, Dictionary(Of String, String))
    Private News As News = New News()
    Private Photos As photo = New photo()
    Public CurrentUser As String
    Public CurrentLoginName As String
    Public DictionaryLastModifier As New Dictionary(Of String, String)
    Private Shared description As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim loginscreen As LoginForm = New LoginForm()
        loginscreen.ShowDialog()

        If loginscreen.DialogResult = DialogResult.OK Then
            CurrentUser = loginscreen.Name
            CurrentLoginName = loginscreen.LoginName


        Else
            Application.Exit()
        End If

    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click

        Dim user As NewUser = New NewUser()
        user.updateButton1.Visible = False
        user.SaveButton2.Visible = True
        user.ShowDialog()
    End Sub

    Private Sub NewsToolStripMenuItemClick(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem.Click

        Dim news As NewNews = New NewNews()

        news.ShowDialog()
    End Sub

    Private Sub PhotoToolStripMenuItemClick(sender As Object, e As EventArgs) Handles PhotoToolStripMenuItem.Click

        Dim photo As NewPhoto = New NewPhoto()

        photo.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItemClick(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub NewsPhotoDataGridView1CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NewsPhotoDataGridView1.CellMouseClick




        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = NewsPhotoDataGridView1.Rows(e.RowIndex)

            VisibleControls()

            For Each key As String In DictionaryMain.Keys
                If row.Cells(0).Value.ToString = key Then
                    If DictionaryMain.Item(key).Item("type") = "News" Then
                        News.ShowDataNewsMainForm(DictionaryMain.Item(key))

                    Else

                        Photos.ShowDataNewsMainForm(DictionaryMain.Item(key))

                    End If
                End If

            Next




        End If

    End Sub
    Private Sub dataGridView1MouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NewsPhotoDataGridView1.CellMouseClick

        If (e.Button = MouseButtons.Right) Then




            If (e.RowIndex >= 0) Then
                Dim row As DataGridViewRow = NewsPhotoDataGridView1.Rows(e.RowIndex)
                title = row.Cells(0).Value.ToString
                description = row.Cells(2).Value.ToString
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

                VisibleControls()
            For i As Integer = 0 To DictionaryMain.Count - 1
                Dim Key = DictionaryMain.ElementAt(i).Key
                If row.Cells(0).Value.ToString = Key And row.Cells(2).Value.ToString = DictionaryMain.Item(Key).Item("decription") Then
                    If DictionaryMain.Item(Key).Item("type") = "News" Then

                        News.EditNews(DictionaryMain.Item(Key))
                        dic_local = News.CheckUser(Key)
                        row.Cells(0).Value = dic_local.Item("title")

                        row.Cells(1).Value = dic_local.Item("Creationdate")
                        row.Cells(2).Value = dic_local.Item("description")
                        row.Selected = True
                    Else

                        Photos.EditNews(DictionaryMain.Item(Key))
                        dic_local = Photos.CheckUser(Key)
                        row.Cells(0).Value = dic_local.Item("title")

                        row.Cells(1).Value = dic_local.Item("Creationdate")
                        row.Cells(2).Value = dic_local.Item("description")
                        row.Selected = True
                    End If
                End If

            Next


        End If


    End Sub

    Private Sub DeleteToolStripMenuItemClick(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If NewsPhotoDataGridView1.SelectedRows.Count > 0 Then
            Dim index As Integer

            Dim SelectRow As New DataGridViewRow
            index = NewsPhotoDataGridView1.SelectedRows.Item(0).Index
            SelectRow = NewsPhotoDataGridView1.Rows.Item(index)
            For i As Integer = 0 To DictionaryMain.Count - 1
                Dim Key = DictionaryMain.ElementAt(i).Key
                If title = Key And description = DictionaryMain.Item(Key).Item("decription") Then
                    If Not DictionaryMain Is Nothing Then
                        If DictionaryMain.Item(title).Item("type") = "News" Then
                            News.DeleteFile(DictionaryMain.Item(title))
                            NewsPhotoDataGridView1.Rows.Remove(SelectRow)
                        Else

                            Photos.DeleteFile(DictionaryMain.Item(title))
                            NewsPhotoDataGridView1.Rows.Remove(SelectRow)
                        End If
                    End If
                End If
            Next
        End If


    End Sub

    Private Sub UsersToolStripMenuItemClick(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim user As ShowUser = New ShowUser()

        user.ShowDialog()
    End Sub

    Private Sub MyAccountToolStripMenuItemClick(sender As Object, e As EventArgs) Handles MyAccountToolStripMenuItem.Click
        Dim user As User = New User()
        user.EditUser()
    End Sub



    Private Sub OpenToolStripMenuItemClick(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Photos.GetDictionaryFromFile()
        News.GetDictionaryFromFile()
    End Sub

    Private Sub MainFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Photos.GetDictionaryFromFile()
        News.GetDictionaryFromFile()
    End Sub

    Private Sub LogoutToolStripMenuItemClick(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        DictionaryMain.Clear()
        Me.Hide()
        LoginForm.Show()

    End Sub
End Class