Public Class ShowUser
    Public DictionaryUser As New Dictionary(Of String, Dictionary(Of String, String))
    Private user As User = New User()
    Public LoginNa As String
    Private Sub ShowUserLoad(sender As Object, e As EventArgs) Handles MyBase.Load






        user.GetDataUser(DictionaryUser)
        For Each key As String In DictionaryUser.Keys
            If DictionaryUser.Item(key).Item("LoginName") <> MainForm.CurrentLoginName Then
                Dim arrayuser As String() = {DictionaryUser.Item(key).Item("Name"), DictionaryUser.Item(key).Item("LoginName"), DictionaryUser.Item(key).Item("LastModifier")}



                UserDataGridView1.Rows.Add(arrayuser)

            End If
        Next
    End Sub
    Private Sub UserDataGridView1CellContentDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDataGridView1.CellMouseDoubleClick

        Dim dic_local As New Dictionary(Of String, String)

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = UserDataGridView1.Rows(e.RowIndex)


            For i As Integer = 0 To DictionaryUser.Count - 1
                Dim Key = DictionaryUser.ElementAt(i).Key
                If row.Cells(1).Value.ToString = Key Then


                    user.EditOtherUser(DictionaryUser.Item(Key))
                    dic_local = user.UserUpdate(Key)
                    row.Cells(0).Value = dic_local.Item("Name")

                    row.Cells(1).Value = dic_local.Item("LoginName")
                    row.Cells(2).Value = dic_local.Item("LastModifier")

                End If

            Next


        End If


    End Sub
    Private Sub dataGridView1MouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDataGridView1.CellMouseClick

        If (e.Button = MouseButtons.Right) Then




            If (e.RowIndex >= 0) Then
                Dim row As DataGridViewRow = UserDataGridView1.Rows(e.RowIndex)
                LoginNa = row.Cells(1).Value.ToString
            End If

            UserContextMenuStrip1.Show(UserDataGridView1, New Point(e.X, e.Y))

        End If
    End Sub
    Private Sub DeleteToolStripMenuItemClick(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If UserDataGridView1.SelectedRows.Count > 0 Then
            Dim row = UserDataGridView1.SelectedRows(0)
            If DictionaryUser.Count > 1 Then
                user.DeleteFile(DictionaryUser.Item(LoginNa))
                UserDataGridView1.Rows.Remove(row)
            End If
        End If

    End Sub
End Class