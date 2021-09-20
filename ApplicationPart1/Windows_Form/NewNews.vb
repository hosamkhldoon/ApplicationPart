Imports System.IO
Imports System.Text.RegularExpressions

Public Class NewNews
    Private NewNew As FileWorxObjects.News = New FileWorxObjects.News()
    Private PrevNew As FileWorxObjects.News = New FileWorxObjects.News()



    Public Property BusinessID As Integer

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub SaveClick(sender As Object, e As EventArgs) Handles SaveButton2.Click

        Dim Creation_date = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        Dim NewsClient As New ApiClients.NewsClient
        If NumberCharcter() Then
        ElseIf TitleTextBox1.Text.Length = 0 Then
            MessageBox.Show("Please Fill Title", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            NewNew.NameFileUser = TitleTextBox1.Text
            NewNew.DescriptionNewsPhoto = DescriptionTextBox2.Text
            NewNew.CategoryNews = ComboBox1.Text
            NewNew.BodyNewsPhoto = BodyTextBox3.Text
            NewNew.CreationDateFileUser = Creation_date
            NewNew.ClassIDFileOrUser = 1
            NewNew.IDBusiness = -1
            Dim IDNews = NewsClient.CreateNews(NewNew)

            If Not String.IsNullOrEmpty(IDNews) Then
                MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainForm.NewsPhotoDataGridView1.Rows.Add(IDNews, NewNew.NameFileUser, NewNew.CreationDateFileUser, NewNew.DescriptionNewsPhoto)
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
        Dim NewsClient As New ApiClients.NewsClient
        Dim Creation_date = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        NewNew.NameFileUser = TitleTextBox1.Text
        NewNew.DescriptionNewsPhoto = DescriptionTextBox2.Text
        NewNew.CategoryNews = ComboBox1.Text
        NewNew.BodyNewsPhoto = BodyTextBox3.Text
        NewNew.ClassIDFileOrUser = 1
        NewNew.CreationDateFileUser = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        If NewNew.NameFileUser = PrevNew.NameFileUser And NewNew.CategoryNews = PrevNew.CategoryNews And NewNew.DescriptionNewsPhoto = PrevNew.DescriptionNewsPhoto And NewNew.BodyNewsPhoto = PrevNew.BodyNewsPhoto Then
            MessageBox.Show("Please Changing any thing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Message = NewsClient.UpdateNews(Me.BusinessID, NewNew)
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

