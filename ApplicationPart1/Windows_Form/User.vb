Imports System.IO
Imports System.Text.RegularExpressions

Public Class User
    Private user_name, login_name, password As String
    Private filename As String
    Public Sub Set_Value(name As String, loginname As String, pass As String)
        user_name = name
        login_name = loginname
        password = pass
    End Sub


    Public Property UserName() As String
        Get
            Return user_name
        End Get
        Set(ByVal value As String)
            user_name = value
        End Set
    End Property

    Public Property LoginName() As String
        Get
            Return login_name
        End Get
        Set(ByVal value As String)
            login_name = value
        End Set
    End Property
    Public Sub SaveNewUser()
        Dim file As StreamWriter

        Dim dic As Dictionary(Of String, String)
        dic = UserUpdate(user_name)

        If CheckUser(login_name) Then

            MessageBox.Show("Please Change The Login Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            filename = "user_" & user_name & Guid.NewGuid().ToString() & ".txt"
            ShowUser.DictionaryUser.Add(user_name, ReturnDictionary())
            file = New StreamWriter("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Users\" & filename, True)
            file.WriteLine(user_name & "%$%" & login_name & "%$%" & password & "%$%")
            file.Flush()
            file.Close()

            ShowUser.UserDataGridView1.Rows.Add(user_name, login_name)
            MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub
    Public Sub EditOtherUser(DictEdit As Dictionary(Of String, String))

        Dim users As NewUser = New NewUser()
        users.NameTextBox1.Text = DictEdit.Item("Name")
        users.LoginNameTextBox2.Text = DictEdit.Item("LoginName")
        users.PasswordTextBox3.Text = DictEdit.Item("password")

        users.SaveButton2.Visible = False
        users.updateButton1.Visible = True
        users.ShowDialog()
    End Sub
    Private Function CheckUser(nameuser As String) As Boolean
        Dim dic_check As New Dictionary(Of String, Dictionary(Of String, String))
        GetDataUser(dic_check)
        If dic_check.ContainsKey(nameuser) Then
            Return True
        End If
        Return False
    End Function
    Public Sub AccountUpdate()
        Dim file As StreamWriter
        Dim dic As Dictionary(Of String, String)
        login_name = MainForm.CurrentLoginName

        dic = UserUpdate(login_name)
        ShowUser.DictionaryUser.Item(login_name) = ReturnDictionary()

        Dim filewriter As FileStream = New FileStream("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Users\" & dic.Item("filename"), FileMode.Create, FileAccess.Write)

        file = New StreamWriter(filewriter)
        file.WriteLine(MainForm.CurrentUser & "%$%" & MainForm.CurrentLoginName & "%$%" & dic.Item("password"))

        file.Flush()
        file.Close()
        MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Function UserUpdate(nameuser As String) As Dictionary(Of String, String)

        Dim dic_check As New Dictionary(Of String, Dictionary(Of String, String))
        GetDataUser(dic_check)
        For Each key As String In dic_check.Keys
            If nameuser = key Then

                Return dic_check.Item(key)



            End If


        Next
        Return Nothing
    End Function
    Public Function CheackNumberOfCharcter255(text_input As String) As Boolean
        If text_input.Length > 255 Then

            Return True
        End If
        Return False
    End Function
    Public Sub UpdateOtherUser()
        Dim file As StreamWriter
        Dim dic As Dictionary(Of String, String)
        dic = UserUpdate(login_name)


        ShowUser.DictionaryUser.Item(login_name) = ReturnDictionary()
            Dim filewriter As FileStream = New FileStream("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Users\" & dic.Item("filename"), FileMode.Create, FileAccess.Write)

            file = New StreamWriter(filewriter)
            file.WriteLine(user_name & "%$%" & login_name & "%$%" & password & "%$%" & MainForm.CurrentUser & "%$%")

            file.Flush()
            File.Close()


            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Public Sub EditUser()

        Dim user As Account = New Account()
        user.NameTextBox1.Text = MainForm.CurrentUser
        user.LoginNameTextBox2.Text = MainForm.CurrentLoginName
        user.SaveButton2.Visible = False
        user.EditButton1.Visible = True
        user.NameTextBox1.Enabled = False
        user.LoginNameTextBox2.Enabled = False
        user.ShowDialog()

    End Sub

    Private Function ReturnDictionary() As Dictionary(Of String, String)
        Dim dic As New Dictionary(Of String, String)
        dic.Add("Name", user_name)
        dic.Add("LoginName", login_name)
        dic.Add("password", password)
        dic.Add("filename", filename)
        Return dic
    End Function
    Public Function ValidateInput(input As String,
expression As String, message As String) As Boolean

        ' store whether the input is valid
        Dim valid As Boolean = Regex.Match(input, expression).Success

        ' if the input doesn't match the regular expression
        If Not valid Then
            MessageBox.Show(message, "Invalid Input",
 MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return valid
    End Function
    Public Sub GetDataUser(ByRef dic As Dictionary(Of String, Dictionary(Of String, String)))
        Dim file_user As String() = Directory.GetFiles("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Users", "*.txt")
        Dim txt_files As String

        For Each txt_files In file_user
            Dim dict_user As New Dictionary(Of String, String)


            Dim filelocation As String
            filelocation = txt_files


            filename = Path.GetFileName(filelocation)

            'read from file'
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(filelocation)


            Dim vArray() As String = Strings.Split(fileReader, "%$%")

            dict_user.Add("Name", vArray(0))
            dict_user.Add("LoginName", vArray(1))
            dict_user.Add("password", vArray(2))
            dict_user.Add("LastModifier", vArray(3))
            dict_user.Add("filename", filename)

            If Not dic.ContainsKey(vArray(1)) Then
                dic.Add(vArray(1), dict_user)

            End If
            'insert text to table'






        Next
    End Sub
    Public Sub DeleteFile(dict As Dictionary(Of String, String))

        FileSystem.Kill("C:\Users\Hussam.Ibraheem\Desktop\First_Task\Users\" & dict.Item("filename"))
        ShowUser.DictionaryUser.Remove(dict.Item("LoginName"))
    End Sub
End Class
