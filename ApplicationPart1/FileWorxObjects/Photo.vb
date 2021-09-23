Imports System.IO
Imports System.Data.SqlClient
Public Class Photo

    Inherits File

    'Create ADO.NET objects.


    Public Property IDPhoto() As Integer
    Public Property LocationPhoto() As String
    Public Property FileIDPhoto() As Integer


    Private PhotoRepositroy As IPhotoRepositroy = New PhotoAggregate()
    Private con As SqlConnection

    Public Sub New()
        Me.LocationPhoto = ""
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub


    Public Overrides Sub Read()
        PhotoRepositroy.IDBusiness = Me.IDBusiness
        PhotoRepositroy.Read()
        Me.CopyObjectFromAggregate(PhotoRepositroy)
    End Sub

    Public Overrides Sub Delete()
        PhotoRepositroy.IDBusiness = Me.IDBusiness
        PhotoRepositroy.Delete()

    End Sub
    Public Overrides Sub Updata()
        If Me.IDBusiness = -1 Then

            Me.CopyObject(PhotoRepositroy)
            PhotoRepositroy.Updata()
            Me.IDPhoto = PhotoRepositroy.IDBusiness
        Else

            Me.CopyObject(PhotoRepositroy)
            PhotoRepositroy.Updata()

        End If
    End Sub
    Private Sub CopyObject(AggregateObject As IPhotoRepositroy)
        AggregateObject.IDBusiness = Me.IDBusiness
        AggregateObject.LocationPhoto = Me.LocationPhoto
        AggregateObject.BodyNewsPhoto = Me.BodyNewsPhoto
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser
    End Sub

    Private Sub CopyObjectFromAggregate(AggregateObject As IPhotoRepositroy)
        Me.LocationPhoto = AggregateObject.LocationPhoto
        Me.IDBusiness = AggregateObject.IDBusiness
        Me.BodyNewsPhoto = AggregateObject.BodyNewsPhoto
        Me.DescriptionNewsPhoto = AggregateObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = AggregateObject.CreationDateFileUser
        Me.ClassIDFileOrUser = AggregateObject.ClassIDFileOrUser
        Me.NameFileUser = AggregateObject.NameFileUser
    End Sub


End Class
