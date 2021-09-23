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


    Public Sub New()
        Me.CategoryNews = ""

    End Sub
    Public Overrides Sub Read()
        NewsRepositroy.IDBusiness = Me.IDBusiness
        NewsRepositroy.Read()
        Me.CopyObjectFromAggregate(NewsRepositroy)
    End Sub

    Public Overrides Sub Delete()
        NewsRepositroy.IDBusiness = Me.IDBusiness
        NewsRepositroy.Delete()
    End Sub
    Public Overrides Sub Updata()
        If Me.IDBusiness = -1 Then
            Me.CopyObject(NewsRepositroy)
            NewsRepositroy.Updata()
            Me.IDNews = NewsRepositroy.IDBusiness
        Else
            Me.CopyObject(NewsRepositroy)
            NewsRepositroy.Updata()
        End If

    End Sub

    Private Sub CopyObject(AggregateObject As INewsRepositroy)
        AggregateObject.IDBusiness = Me.IDBusiness
        AggregateObject.CategoryNews = Me.CategoryNews
        AggregateObject.BodyNewsPhoto = Me.BodyNewsPhoto
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser

    End Sub
    Private Sub CopyObjectFromAggregate(AggregateObject As INewsRepositroy)
        Me.IDBusiness = AggregateObject.IDBusiness
        Me.CategoryNews = AggregateObject.CategoryNews
        Me.BodyNewsPhoto = AggregateObject.BodyNewsPhoto
        Me.DescriptionNewsPhoto = AggregateObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = AggregateObject.CreationDateFileUser
        Me.ClassIDFileOrUser = AggregateObject.ClassIDFileOrUser
        Me.NameFileUser = AggregateObject.NameFileUser

    End Sub
End Class
