Imports System.IO

Public Class photo
    Private description_photo, body_photo As String
    Private title_photo, path_photo, Creation_date As String
    Private filename As String
    Public Sub SetValue(title As String, description As String, body As String, path As String)
        title_photo = title
        description_photo = description
        body_photo = body
        path_photo = path
        Creation_date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub



    Public Sub SaveNewPhoto()

        Dim file As StreamWriter
        Dim dic As Dictionary(Of String, String)

        dic = CheckUser(title_photo)
        If MainForm.DictionaryMain.ContainsKey(title_photo) Then
            MainForm.DictionaryMain.Item(title_photo) = ReturnDictionary()
            Dim filewriter As FileStream = New FileStream("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Photos\" & dic.Item("filename"), FileMode.Create, FileAccess.Write)

            file = New StreamWriter(filewriter)
            file.WriteLine(title_photo & "%$%" & Creation_date & "%$%" & description_photo & "%$%" & body_photo & "%$%")

            file.Flush()
            file.Close()


            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MainForm.DictionaryMain.Add(title_photo, ReturnDictionary())

            filename = "news_about_" & title_photo & Guid.NewGuid().ToString() & ".txt"
            MainForm.NewsPhotoDataGridView1.Rows.Add(title_photo, Creation_date, description_photo)
            file = New StreamWriter("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Photos\" & filename, True)
            file.WriteLine(title_photo & "%$%" & Creation_date & "%$%" & description_photo & "%$%" & body_photo & "%$%" & path_photo & "%$%")

            file.Flush()
            file.Close()
            MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Public Function CheckUser(titlephoto As String) As Dictionary(Of String, String)


        For Each key As String In MainForm.DictionaryMain.Keys
            If titlephoto = key Then

                Return MainForm.DictionaryMain.Item(key)



            End If


        Next
        Return Nothing
    End Function
    Public Sub EditNews(DictEdit As Dictionary(Of String, String))


        Dim photo As NewPhoto = New NewPhoto()

        photo.ImagePictureBox1.Image = New Bitmap(DictEdit.Item("pathimage"))
        photo.ImagePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        photo.PathLabel1.Text = "Picture Location is " & DictEdit.Item("pathimage")
        photo.TitleTextBox1.Text = DictEdit.Item("title")
        photo.DescriptionTextBox2.Text = DictEdit.Item("description")

        photo.BodyTextBox3.Text = DictEdit.Item("Body")
        photo.ShowDialog()



    End Sub
    Private Function ReturnDictionary() As Dictionary(Of String, String)
        Dim dic As New Dictionary(Of String, String)
        dic.Add("title", title_photo)
        dic.Add("Creationdate", Creation_date)
        dic.Add("filename", filename)
        dic.Add("Body", body_photo)
        dic.Add("pathimage", path_photo)
        dic.Add("type", "Photo")
        Return dic
    End Function
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
        Dim file_News As String() = Directory.GetFiles("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Photos", "*.txt")
        Dim txt_files As String

        For Each txt_files In file_News



            Dim dict_photo As New Dictionary(Of String, String)
            Dim filelocation As String
            filelocation = txt_files




            'read from file'
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(filelocation)

            filename = Path.GetFileName(filelocation)
            Dim vArray() As String = Strings.Split(fileReader, "%$%")
            dict_photo.Add("title", vArray(0))
            dict_photo.Add("Creationdate", vArray(1))
            dict_photo.Add("description", vArray(2))
            dict_photo.Add("Body", vArray(3))
            dict_photo.Add("pathimage", vArray(4))
            dict_photo.Add("type", "Photo")
            dict_photo.Add("filename", filename)
            'insert text to table'
            Try
                If Not MainForm.DictionaryMain.ContainsKey(vArray(0)) Then
                    MainForm.DictionaryMain.Add(vArray(0), dict_photo)
                    MainForm.NewsPhotoDataGridView1.Rows.Add(vArray(0), vArray(1), vArray(2))
                End If





            Catch ex As ArgumentException
                MessageBox.Show("not new record", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Next

    End Sub

    Public Sub ShowDataNewsMainForm(dic As Dictionary(Of String, String))
        MainForm.categoryComboBox1.Visible = False
        MainForm.categoryLabel3.Visible = False
        MainForm.imagePictureBox1.Show()
        MainForm.titleTextBox1.Text = dic.Item("title")
        MainForm.CreationdateTextBox3.Text = dic.Item("Creationdate")
        MainForm.previewTextBox1.Text = dic.Item("Body")
        MainForm.imagePictureBox1.Image = New Bitmap(dic.Item("pathimage"))
        MainForm.imagePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Public Sub DeleteFile(dict As Dictionary(Of String, String))
        FileSystem.Kill("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Photos\" & dict.Item("filename"))
        MainForm.DictionaryMain.Remove(dict.Item("title"))
    End Sub
End Class
