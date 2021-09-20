Imports System.IO
Imports System.Text.RegularExpressions

Imports System.Data.SqlClient
Imports FileWorxObjects.BusinessQuery

Public Class User
    Inherits BusinessObject


    Public Property IDUser As Integer
    Public Property NameLogin As String
    Public Property BusinessIDUser As Integer
    Public Property LastModifierUser As String
    Public Property PasswordUser As String
    Public Property TypeUser As String

    Private UserRepositroy As IUserRepositroy = New UserAggregate
    Private con As SqlConnection
    Private AggregateClassUser As New UserAggregate
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
        If Me.IDBusiness = -1 Then
            Me.CopyObject(UserRepositroy)
            UserRepositroy.Updata()
            Me.IDUser = UserRepositroy.IDUser
        Else
            Me.CopyObject(UserRepositroy)
            UserRepositroy.Updata()
        End If
    End Sub
    Private Sub CopyObject(AggregateObject As IUserRepositroy)
        AggregateObject.IDUser = Me.IDBusiness
        AggregateObject.NameLogin = Me.NameLogin
        AggregateObject.LastModifierUser = Me.LastModifierUser
        AggregateObject.PasswordUser = Me.PasswordUser
        AggregateObject.TypeUser = Me.TypeUser
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser
    End Sub
End Class
