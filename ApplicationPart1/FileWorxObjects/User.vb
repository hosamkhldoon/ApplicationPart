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
    Public Sub New()
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub

    Public Overloads Sub Read()
        UserRepositroy.IDBusiness = Me.IDBusiness
        UserRepositroy.Read()
        Me.CopyObjectFromAggregate(UserRepositroy)
    End Sub
    Public Function CheckLoginUser() As Boolean
        UserRepositroy.PasswordUser = Me.PasswordUser
        UserRepositroy.NameLogin = Me.NameLogin
        Dim CheackUser As Boolean = UserRepositroy.CheckLoginUser()
        Me.CopyObjectFromAggregate(UserRepositroy)
        Return CheackUser
    End Function
    Public Overloads Sub Delete()
        UserRepositroy.IDBusiness = Me.IDBusiness
        UserRepositroy.Delete()
    End Sub
    Public Overloads Sub Updata()
        If Me.IDBusiness = -1 Then
            Me.CopyObject(UserRepositroy)
            UserRepositroy.Updata()
            Me.IDUser = UserRepositroy.IDBusiness
        Else
            Me.CopyObject(UserRepositroy)
            UserRepositroy.Updata()
        End If
    End Sub
    Private Sub CopyObject(AggregateObject As IUserRepositroy)
        AggregateObject.IDBusiness = Me.IDBusiness
        AggregateObject.NameLogin = Me.NameLogin
        AggregateObject.LastModifierUser = Me.LastModifierUser
        AggregateObject.PasswordUser = Me.PasswordUser
        AggregateObject.TypeUser = Me.TypeUser
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser
    End Sub
    Private Sub CopyObjectFromAggregate(AggregateObject As IUserRepositroy)
        Me.NameLogin = AggregateObject.NameLogin
        Me.LastModifierUser = AggregateObject.LastModifierUser
        Me.PasswordUser = AggregateObject.PasswordUser
        Me.TypeUser = AggregateObject.TypeUser
        Me.IDBusiness = AggregateObject.IDBusiness
        Me.DescriptionNewsPhoto = AggregateObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = AggregateObject.CreationDateFileUser
        Me.ClassIDFileOrUser = AggregateObject.ClassIDFileOrUser
        Me.NameFileUser = AggregateObject.NameFileUser
    End Sub
End Class
