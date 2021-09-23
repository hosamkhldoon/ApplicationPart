Imports System.IO

Public Class NewPhoto


    Private openFD As New OpenFileDialog()

    Private NewPhoto As FileWorxObjects.photo = New FileWorxObjects.photo()
    Private PrevPhoto As FileWorxObjects.photo = New FileWorxObjects.photo()


    Public Property BusinessID() As Integer

    Private folder As String = "C:\Users\Hussam.Ibraheem\Desktop\FileWorxProject\ApplicationPart\ApplicationPart1\Windows_Form\Images\"
    Private Sub NewPhotoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        FileDescriptionTabPage1.Text = "File Description"
        ImageTabPage2.Text = "Image"
        PrevPhoto.NameFileUser = TitleTextBox1.Text
        PrevPhoto.DescriptionNewsPhoto = DescriptionTextBox2.Text
        PrevPhoto.BodyNewsPhoto = BodyTextBox3.Text
        PrevPhoto.LocationPhoto = PathLabel1.Text
    End Sub

    Private Sub BrowseClick(sender As Object, e As EventArgs) Handles BrowseButton1.Click

        openFD.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|bmp Files (*.bmp)|*.bmp|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|JFIF Files (*.jfif)|*.jfif"

        If openFD.ShowDialog = DialogResult.OK Then
            Dim File As New FileInfo(openFD.FileName)
            If File.Length = 0 Then
                MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf File.Length > 2097152 Then
                MessageBox.Show("Image size cannot exceed 2MB.", TitleTextBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImagePictureBox1.Image?.Dispose()
                ImagePictureBox1.Image = New Bitmap(openFD.FileName)
                ImagePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PathLabel1.Text = "Picture Location is " & openFD.FileName
            End If
        End If


    End Sub
    Private Sub DisposePictureBox()
        If Not ImagePictureBox1.Image Is Nothing Then
            ImagePictureBox1.Image.Dispose()
        End If
    End Sub
    Private Sub SaveClick(sender As Object, e As EventArgs) Handles SaveButton1.Click

        Dim Creation_date = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        Dim PhotoClient As New ApiClients.PhotoClient

        If NumberCharcter() Then

        ElseIf TitleTextBox1.Text.Length = 0 Then
            MessageBox.Show("Please Fill Title", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim fileName As String = Path.GetFileName(openFD.FileName) + Guid.NewGuid.ToString
            NewPhoto.NameFileUser = TitleTextBox1.Text
            NewPhoto.DescriptionNewsPhoto = DescriptionTextBox2.Text
            NewPhoto.IDBusiness = -1
            NewPhoto.BodyNewsPhoto = BodyTextBox3.Text
            NewPhoto.CreationDateFileUser = Creation_date
            NewPhoto.ClassIDFileOrUser = 2

            If Not String.IsNullOrEmpty(openFD.FileName) Then
                NewPhoto.LocationPhoto = Path.Combine(folder, fileName)
                File.Copy(openFD.FileName, Path.Combine(folder, fileName), True)
            End If

            Dim IdPhoto = PhotoClient.CreatePhoto(NewPhoto)
            If Not String.IsNullOrEmpty(IdPhoto) Then
                MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainForm.NewsPhotoDataGridView1.Rows.Add(IdPhoto, NewPhoto.NameFileUser, NewPhoto.CreationDateFileUser, NewPhoto.DescriptionNewsPhoto)
            End If
        End If
    End Sub

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles CancelButton2.Click
        Me.Close()
    End Sub

    Private Sub UpdateClick(sender As Object, e As EventArgs) Handles UpdateButton1.Click
        Dim fileName As String = Path.GetFileName(openFD.FileName) + Guid.NewGuid.ToString
        Dim PhotoClient As New ApiClients.PhotoClient
        If Not String.IsNullOrEmpty(openFD.FileName) Then
            If File.Exists(PrevPhoto.LocationPhoto) Then
                File.Delete(PrevPhoto.LocationPhoto)
                File.Copy(openFD.FileName, Path.Combine(folder, fileName), True)

            End If
            NewPhoto.LocationPhoto = Path.Combine(folder, fileName)
        Else
            NewPhoto.LocationPhoto = PrevPhoto.LocationPhoto
        End If

        NewPhoto.NameFileUser = TitleTextBox1.Text
        NewPhoto.DescriptionNewsPhoto = DescriptionTextBox2.Text
        NewPhoto.BodyNewsPhoto = BodyTextBox3.Text
        NewPhoto.ClassIDFileOrUser = 2
        NewPhoto.CreationDateFileUser = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        If NewPhoto.NameFileUser = PrevPhoto.NameFileUser And String.IsNullOrEmpty(openFD.FileName) And NewPhoto.DescriptionNewsPhoto = PrevPhoto.DescriptionNewsPhoto And NewPhoto.BodyNewsPhoto = PrevPhoto.BodyNewsPhoto Then
            MessageBox.Show("Please Changing any thing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim Message = PhotoClient.UpdatePhoto(Me.BusinessID, NewPhoto)
            If Not String.IsNullOrEmpty(Message) Then
                MessageBox.Show("Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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