Imports System.IO

Public Class NewPhoto


    Private openFD As New OpenFileDialog()
    Dim photo As photo = New photo()


    Private Sub NewPhotoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        FileDescriptionTabPage1.Text = "File Description"
        ImageTabPage2.Text = "Image"


    End Sub

    Private Sub BrowseButton1Click(sender As Object, e As EventArgs) Handles BrowseButton1.Click

        openFD.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|bmp Files (*.bmp)|*.bmp|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif"

        If openFD.ShowDialog = DialogResult.OK Then
            Dim File As New FileInfo(openFD.FileName)
            If File.Length = 0 Then
                MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf File.Length > 2097152 Then
                MessageBox.Show("Image size cannot exceed 2MB.", TitleTextBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImagePictureBox1.Image = New Bitmap(openFD.FileName)
                ImagePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PathLabel1.Text = "Picture Location is " & openFD.FileName
            End If
        End If


    End Sub
    Private Sub SaveButton1_Click(sender As Object, e As EventArgs) Handles SaveButton1.Click



        Dim dir_file = "C:\Users\Hussam.Ibraheem\Desktop\First_Task\Photos"
        Dim path As String = ""
        path = openFD.FileName
        Dim emptyBoxes =
           From txt In Me.Controls.OfType(Of TextBox)()
           Where txt.Text.Length = 0
           Select txt

        If emptyBoxes.Any Then
            ' display popup box
            MessageBox.Show("Please fill in all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emptyBoxes.Last().Focus()
        ElseIf photo.cheacknumberOfCharcter255(TitleTextBox1.Text) Then
            MessageBox.Show("please enter in box" & TitleTextBox1.Name & " less then 255 charcter")
        ElseIf photo.cheacknumberOfCharcter255(DescriptionTextBox2.Text) Then
            MessageBox.Show("please enter in box" & DescriptionTextBox2.Name & " less then 255 charcter")
        ElseIf photo.cheacknumberOfCharcter10000(BodyTextBox3.Text) Then
            MessageBox.Show("please enter in box" & BodyTextBox3.Name & " less then 255 charcter")
        ElseIf path = "" Then
            MessageBox.Show("Please select Image", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try
                photo.SetValue(TitleTextBox1.Text, DescriptionTextBox2.Text, BodyTextBox3.Text, path)
                photo.SaveNewPhoto()
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(dir_file & "not found.", "directory not found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IO Exception")
            End Try
        End If
    End Sub

    Private Sub CancelButton2_Click(sender As Object, e As EventArgs) Handles CancelButton2.Click
        Me.Close()
    End Sub


End Class