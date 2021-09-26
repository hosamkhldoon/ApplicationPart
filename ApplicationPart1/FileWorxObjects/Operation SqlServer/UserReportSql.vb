Imports System.Data.SqlClient

Public Class UserReportSql
    Inherits BusinessReportsql
    Implements IUserRepositroy




    Public Property IDUser As Integer Implements IUserRepositroy.IDUser
    Public Property LastModifierUser As String Implements IUserRepositroy.LastModifierUser
    Public Property NameLogin As String Implements IUserRepositroy.NameLogin
    Public Property PasswordUser As String Implements IUserRepositroy.PasswordUser
    Public Property TypeUser As String Implements IUserRepositroy.TypeUser


    Private con As SqlConnection
    Public Sub New()
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overrides Sub Delete() Implements IUserRepositroy.Delete
        MyBase.Delete()
    End Sub

    Public Overrides Sub Read() Implements IUserRepositroy.Read
        Dim myReader As SqlDataReader


        MyBase.Read()
        Me.IDUser = Me.IDBusiness
        Dim cmd As SqlCommand = New SqlCommand("SELECT [C_LoginName]
   
,[C_Password]
,[C_Type]
,[C_LastModifier]
  FROM [dbo].[T_USER]
WHERE [ID]='" & Me.IDUser & "'", con)
        con.Open()
        myReader = cmd.ExecuteReader()
        Do While myReader.Read()
            Me.NameLogin = myReader.GetString(0)

            Me.PasswordUser = myReader.GetString(1)
            Me.TypeUser = myReader.GetString(2)
            Me.LastModifierUser = myReader.GetString(3)
        Loop

        myReader.Close()
        con.Close()
    End Sub

    Public Overrides Sub Updata() Implements IUserRepositroy.Updata
        If Me.IDBusiness = -1 Then

            MyBase.Updata()
            Me.IDUser = Me.IDBusiness

            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_USER]
           ([ID]
,[C_LoginName]
           ,[C_Password]
,[C_Type]
,[C_LastModifier]
          )
     VALUES
           ('" & Me.IDUser & "',N'" + Me.NameLogin + "','" + Me.PasswordUser + "','" + Me.TypeUser + "',N'" + Me.LastModifierUser + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Else

            MyBase.Updata()
            Me.IDUser = Me.IDBusiness
            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_USER]
   SET [C_LoginName] = N'" + Me.NameLogin + "'
      ,[C_Password] = '" + Me.PasswordUser + "'
     
      ,[C_LastModifier] = N'" + Me.LastModifierUser + "'
      ,[C_Type]='" + Me.TypeUser + "'
 WHERE [ID]='" & Me.IDUser & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub

    Public Function CheckLoginUser() As Boolean Implements IUserRepositroy.CheckLoginUser
        Dim myReader As SqlDataReader
        Dim UserLogin As New User



        Dim cmd As SqlCommand = New SqlCommand("SELECT U.[C_LoginName]
  , B.[C_Name]

,B.[C_Description]

,U.[C_Type]
,U.[C_LastModifier]
,U.[ID]
  FROM [dbo].[T_USER] U, [dbo].[T_BUSINESSOBJECT] B
WHERE U.[C_LoginName] ='" + Me.NameLogin + "' AND U.[C_Password] = '" + Me.PasswordUser + "' AND U.[ID] = B.[ID]", con)
        con.Open()
        myReader = cmd.ExecuteReader()
        Do While myReader.Read()
            Me.NameLogin = myReader.GetString(0)
            Me.NameFileUser = myReader.GetString(1)
            Me.DescriptionNewsPhoto = myReader.GetString(2)
            Me.TypeUser = myReader.GetString(3)
            Me.LastModifierUser = myReader.GetString(4)
            Me.PasswordUser = ""
            Return True
        Loop

        myReader.Close()
        con.Close()
        Return False
    End Function
End Class
