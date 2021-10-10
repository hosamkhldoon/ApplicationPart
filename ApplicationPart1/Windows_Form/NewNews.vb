Imports System.IO
Imports System.Text.RegularExpressions
Imports DTO
Public Class NewNews
    Private NewNew As FileWorxObjects.News = New FileWorxObjects.News()
    Private PrevNew As FileWorxObjects.News = New FileWorxObjects.News()



    Public Property BusinessID As Integer

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub SaveClick(sender As Object, e As EventArgs) Handles SaveButton2.Click
        Dim NewNews As New NewsUpdateService()
        Dim CreationDate = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        Dim NewsClient As New ApiClients.NewsClient
        If NumberCharcter() Then
        ElseIf TitleTextBox1.Text.Length = 0 Then
            MessageBox.Show("Please Fill Title", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            NewNews.NameFileUser = TitleTextBox1.Text
            NewNews.DescriptionNewsPhoto = DescriptionTextBox2.Text
            NewNews.CategoryNews = ComboBox1.Text
            NewNews.BodyNewsPhoto = BodyTextBox3.Text
            NewNews.CreationDateFileUser = CreationDate



            Dim IDNews = NewsClient.CreateNews(NewNews)

            If Not String.IsNullOrEmpty(IDNews) Then
                MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainForm.NewsPhotoDataGridView1.Rows.Add(IDNews, NewNews.NameFileUser, NewNews.CreationDateFileUser, NewNews.DescriptionNewsPhoto)
            End If
        End If


    End Sub



    Private Sub NewNewsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PrevNew.NameFileUser = TitleTextBox1.Text
        PrevNew.DescriptionNewsPhoto = DescriptionTextBox2.Text
        PrevNew.BodyNewsPhoto = BodyTextBox3.Text
        PrevNew.CategoryNews = ComboBox1.Text
    End Sub

    Private Sub UpdateClick(sender As Object, e As EventArgs) Handles UpdateButton1.Click
        Dim UpdateNews As New NewsUpdateService()
        Dim NewsClient As New ApiClients.NewsClient
        UpdateNews.NameFileUser = TitleTextBox1.Text
        UpdateNews.DescriptionNewsPhoto = DescriptionTextBox2.Text
        UpdateNews.CategoryNews = ComboBox1.Text
        UpdateNews.BodyNewsPhoto = BodyTextBox3.Text


        If UpdateNews.NameFileUser = PrevNew.NameFileUser And UpdateNews.CategoryNews = UpdateNews.CategoryNews And UpdateNews.DescriptionNewsPhoto = PrevNew.DescriptionNewsPhoto And UpdateNews.BodyNewsPhoto = PrevNew.BodyNewsPhoto Then
            MessageBox.Show("Please Changing any thing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Message = NewsClient.UpdateNews(Me.BusinessID, UpdateNews)
            If Not String.IsNullOrEmpty(Message) Then
                MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Function NumberCharcter() As Boolean
        If TitleTextBox1.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + TitleTextBox1.Name + " less than 255 Charcter")
            Return True
        ElseIf DescriptionTextBox2.Text.Length > 255 Then
            MessageBox.Show("Please enter in box " + DescriptionTextBox2.Name + " less than 255 Charcter")
            Return True
        ElseIf BodyTextBox3.Text.Length > 10000 Then
            MessageBox.Show("Please enter in box " + BodyTextBox3.Name + " less than 10000 Charcter")
            Return True
        Else
            Return False
        End If
    End Function
End Class

