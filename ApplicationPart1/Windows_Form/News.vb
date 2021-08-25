Imports System.IO
Public Class News
    Private title_news, description_news, category_news, body_news, Creation_date As String
    Private dict_news As New Dictionary(Of String, String)
    Private filename As String

    Public Sub SetValue(title As String, description As String, category As String, body As String)
        title_news = title
        description_news = description
        body_news = body
        category_news = category
        Creation_date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub


    Public Sub SaveNewNews()
        Dim file As StreamWriter
        Dim dic As Dictionary(Of String, String)
        dic = CheckUser(title_news)

        If MainForm.DictionaryMain.ContainsKey(title_news) Then
            MainForm.DictionaryMain.Item(title_news) = ReturnDictionary()
            Dim filewriter As FileStream = New FileStream("C:\Users\Hussam.Ibraheem\Desktop\First_Task\News\" & dic.Item("filename"), FileMode.Create, FileAccess.Write)

            file = New StreamWriter(filewriter)
            file.WriteLine(title_news & "%$%" & Creation_date & "%$%" & description_news & "%$%" & category_news & "%$%" & body_news & "%$%")

            file.Flush()
            file.Close()


            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MainForm.DictionaryMain.Add(title_news, ReturnDictionary())

            filename = "news_about_" & title_news & Guid.NewGuid().ToString() & ".txt"
            MainForm.NewsPhotoDataGridView1.Rows.Add(title_news, Creation_date, description_news)
            file = New StreamWriter("C:\Users\Hussam.Ibraheem\Desktop\First_Task\News\" & filename, True)
            file.WriteLine(title_news & "%$%" & Creation_date & "%$%" & description_news & "%$%" & category_news & "%$%" & body_news & "%$%")

            file.Flush()
            file.Close()
            MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub
    Public Function CheckUser(titlenews As String) As Dictionary(Of String, String)


        For Each key As String In MainForm.DictionaryMain.Keys
            If titlenews = key Then

                Return MainForm.DictionaryMain.Item(key)



            End If


        Next
        Return Nothing
    End Function
    Private Function ReturnDictionary() As Dictionary(Of String, String)
        Dim dic As New Dictionary(Of String, String)
        dic.Add("title", title_news)
        dic.Add("Creationdate", Creation_date)
        dic.Add("Category", category_news)
        dic.Add("description", description_news)
        dic.Add("Body", body_news)
        dic.Add("filename", filename)
        dic.Add("type", "News")
        Return dic
    End Function
    Public Sub EditNews(DictEdit As Dictionary(Of String, String))

        Dim news As NewNews = New NewNews()
        news.TitleTextBox1.Text = DictEdit.Item("title")
        news.DescriptionTextBox2.Text = DictEdit.Item("description")
        news.ComboBox1.Text = DictEdit.Item("Category")
        news.BodyTextBox3.Text = DictEdit.Item("Body")

        news.ShowDialog()


    End Sub
    Public Function CheackNumberOfCharcter255(text_input As String) As Boolean
        If text_input.Length > 255 Then

            Return True
        End If
        Return False
    End Function
    Public Function CheackNumberOfCharcter10000(text_input As String) As Boolean
        If text_input.Length > 10000 Then

            Return True
        End If
        Return False
    End Function

    Public Sub GetDictionaryFromFile()
        Dim file_News As String() = Directory.GetFiles("C:\Users\Hussam.Ibraheem\Desktop\First_Task\News", "*.txt")
        Dim txt_files As String

        For Each txt_files In file_News
            Dim dict_news As New Dictionary(Of String, String)


            Dim filelocation As String
            filelocation = txt_files




            'read from file'
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(filelocation)

            filename = Path.GetFileName(filelocation)
            Dim vArray() As String = Strings.Split(fileReader, "%$%")

            dict_news.Add("title", vArray(0))
            dict_news.Add("Creationdate", vArray(1))
            dict_news.Add("description", vArray(2))
            dict_news.Add("Category", vArray(3))
            dict_news.Add("Body", vArray(4))
            dict_news.Add("filename", filename)
            dict_news.Add("type", "News")
            'insert text to table'
            Try

                If Not MainForm.DictionaryMain.ContainsKey(vArray(0)) Then
                    MainForm.DictionaryMain.Add(vArray(0), dict_news)
                    MainForm.NewsPhotoDataGridView1.Rows.Add(vArray(0), vArray(1), vArray(2))
                End If






            Catch ex As ArgumentException
                MessageBox.Show("not new record", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Next
    End Sub

    Public Sub ShowDataNewsMainForm(dic As Dictionary(Of String, String))
        MainForm.categoryComboBox1.Visible = True
        MainForm.categoryLabel3.Visible = True
        MainForm.imagePictureBox1.Hide()

        MainForm.titleTextBox1.Text = dic.Item("title")
        MainForm.CreationdateTextBox3.Text = dic.Item("Creationdate")
        MainForm.categoryComboBox1.Text = dic.Item("Category")
        MainForm.previewTextBox1.Text = dic.Item("Body")
        MainForm.categoryComboBox1.Enabled = False

    End Sub
    Public Sub DeleteFile(dict As Dictionary(Of String, String))

        FileSystem.Kill("C:\Users\Hussam.Ibraheem\Desktop\First_Task\News\" & dict.Item("filename"))
        MainForm.DictionaryMain.Remove(dict.Item("title"))
    End Sub
End Class
