Imports System.IO
Imports System.Data.SqlClient
Imports System.Net
Imports System.Data
Public Class News
    Inherits File
    'Create ADO.NET objects.



    Public Property CategoryNews() As String

    Public Property IDNews() As Integer

    Public Property FileIDNews() As Integer


    Private NewsRepositroy As INewsRepositroy = New NewsAggregate

    Private con As SqlConnection
    Public Sub New()
        Me.CategoryNews = ""
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overrides Sub Read()
        MyBase.Read()
        Me.IDNews = Me.IDBusiness
        Dim myReader As SqlDataReader


        Dim cmd As SqlCommand = New SqlCommand("SELECT  [C_Category]
  FROM [dbo].[T_NEWS]
WHERE [ID]='" & Me.IDNews & "' ", con)
        con.Open()
        myReader = cmd.ExecuteReader()


        Do While myReader.Read()
            Me.CategoryNews = myReader.GetString(0)
        Loop
        myReader.Close()
        con.Close()
    End Sub

    Public Overrides Sub Delete()
        NewsRepositroy.IDBusiness = Me.IDBusiness
        NewsRepositroy.Delete()
    End Sub
    Public Overrides Sub Updata()
        If Me.IDBusiness = -1 Then
            Me.CopyObject(NewsRepositroy)
            NewsRepositroy.Updata()
            Me.IDNews = NewsRepositroy.IDNews
        Else
            Me.CopyObject(NewsRepositroy)
            NewsRepositroy.Updata()
        End If

    End Sub

    Private Sub CopyObject(AggregateObject As INewsRepositroy)
        AggregateObject.IDNews = Me.IDBusiness
        AggregateObject.CategoryNews = Me.CategoryNews
        AggregateObject.BodyNewsPhoto = Me.BodyNewsPhoto
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser

    End Sub
End Class
