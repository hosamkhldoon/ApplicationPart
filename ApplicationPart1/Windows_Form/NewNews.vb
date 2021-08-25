Imports System.IO
Imports System.Text.RegularExpressions

Public Class NewNews
    Private Sub CancelButton1_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub SaveButton2_Click(sender As Object, e As EventArgs) Handles SaveButton2.Click
        Dim new_news As News = New News()


        Dim dir_file = "C:\Users\Hussam.Ibraheem\Desktop\First_Task\News"
        Dim emptyBoxes =
           From txt In Me.Controls.OfType(Of TextBox)()
           Where txt.Text.Length = 0
           Select txt


        If emptyBoxes.Any Then
            ' display popup box
            MessageBox.Show("Please fill in all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emptyBoxes.Last().Focus()
        ElseIf new_news.cheacknumberOfCharcter255(TitleTextBox1.Text) Then
            MessageBox.Show("please enter in box" & TitleTextBox1.Name & " less then 255 charcter")
        ElseIf new_news.cheacknumberOfCharcter255(DescriptionTextBox2.Text) Then
            MessageBox.Show("please enter in box" & DescriptionTextBox2.Name & " less then 255 charcter")
        ElseIf new_news.cheacknumberOfCharcter10000(BodyTextBox3.Text) Then
            MessageBox.Show("please enter in box" & BodyTextBox3.Name & " less then 255 charcter")
        Else
            Try
                new_news.SetValue(TitleTextBox1.Text, DescriptionTextBox2.Text, ComboBox1.Text, BodyTextBox3.Text)
                new_news.SaveNewNews()
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(dir_file & "not found.", "directory not found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IO Exception")
            End Try
        End If


    End Sub



    Private Sub NewNewsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Text = Me.ComboBox1.Items(0).ToString()
    End Sub


End Class

