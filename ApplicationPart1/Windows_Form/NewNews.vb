Imports System.IO
Imports System.Text.RegularExpressions

Public Class NewNews
    Private NewNew As FileWorxObject.News = New FileWorxObject.News()
    Private PrevNew As FileWorxObject.News = New FileWorxObject.News()
    Private idfile As Integer
    Public Property FileID() As Integer
        Get
            Return idfile
        End Get
        Set(ByVal value As Integer)
            idfile = value
        End Set
    End Property
    Private idnews As Integer
    Public Property NewsID() As Integer
        Get
            Return idnews
        End Get
        Set(ByVal value As Integer)
            idnews = value
        End Set
    End Property
    Private idbusiness As Integer
    Public Property BusinessID() As Integer
        Get
            Return idbusiness
        End Get
        Set(ByVal value As Integer)
            idbusiness = value
        End Set
    End Property
    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub SaveClick(sender As Object, e As EventArgs) Handles SaveButton2.Click

        Dim Creation_date = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")







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
            NewNew.IDNews = -1

            NewNew.Updata()
            NewNew.Read()
            MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainForm.NewsPhotoDataGridView1.Rows.Add(NewNew.IDBusiness, NewNew.NameFileUser, NewNew.CreationDateFileUser, NewNew.DescriptionNewsPhoto)

        End If


    End Sub



    Private Sub NewNewsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PrevNew.NameFileUser = TitleTextBox1.Text
        PrevNew.DescriptionNewsPhoto = DescriptionTextBox2.Text
        PrevNew.BodyNewsPhoto = BodyTextBox3.Text
        PrevNew.CategoryNews = ComboBox1.Text
    End Sub

    Private Sub UpdateClick(sender As Object, e As EventArgs) Handles UpdateButton1.Click
        NewNew.IDNews = Me.NewsID
        NewNew.IDFile = Me.FileID
        NewNew.IDBusiness = Me.BusinessID
        NewNew.NameFileUser = TitleTextBox1.Text
        NewNew.DescriptionNewsPhoto = DescriptionTextBox2.Text
        NewNew.CategoryNews = ComboBox1.Text
        NewNew.BodyNewsPhoto = BodyTextBox3.Text
        If NewNew.NameFileUser = PrevNew.NameFileUser And NewNew.CategoryNews = PrevNew.CategoryNews And NewNew.DescriptionNewsPhoto = PrevNew.DescriptionNewsPhoto And NewNew.BodyNewsPhoto = PrevNew.BodyNewsPhoto Then
            MessageBox.Show("Please Changing any thing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            NewNew.Updata()
            MessageBox.Show("Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

