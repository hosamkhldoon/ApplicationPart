Imports System.IO
Imports System.Text.RegularExpressions

Imports System.Data.SqlClient
Imports FileWorxObjects.BusinessQuery

Public Class User
    Inherits BusinessObject

    Private id As Integer
    Public Property IDUser() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Private loginname As String
    Public Property NameLogin() As String
        Get
            Return loginname
        End Get
        Set(ByVal value As String)
            loginname = value
        End Set
    End Property
    Private idbusinessuser As Integer
    Public Property BusinessIDUser() As Integer
        Get
            Return idbusinessuser
        End Get
        Set(ByVal value As Integer)
            idbusinessuser = value
        End Set
    End Property
    Private lastmodifier As String
    Public Property LastModifierUser() As String
        Get
            Return lastmodifier
        End Get
        Set(ByVal value As String)
            lastmodifier = value
        End Set
    End Property
    Private password As String
    Public Property PasswordUser() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property
    Private type As String
    Public Property TypeUser() As String
        Get
            Return type
        End Get
        Set(ByVal value As String)
            type = value
        End Set
    End Property
    Private con As SqlConnection
    Public Sub New()
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub

    Public Overloads Sub Read()
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
    Public Function CheckLoginUser() As Boolean
        Dim myReader As SqlDataReader
        Dim UserLogin As New User

        MyBase.Read()

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
    Public Overloads Sub Delete()

        MyBase.Delete()
    End Sub
    Public Overloads Sub Updata()
        If Me.IDUser = -1 Then
            Me.IDBusiness = -1
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

End Class
