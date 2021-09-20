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
        Dim myReader As SqlDataReader
        MyBase.Read()
        Me.IDPhoto = Me.IDBusiness
        Dim cmd As SqlCommand = New SqlCommand("SELECT [C_Location]
  FROM [dbo].[T_PHOTO]
WHERE [ID]='" & Me.IDPhoto & "'", con)
        con.Open()
        myReader = cmd.ExecuteReader()

        Do While myReader.Read()
            Me.LocationPhoto = myReader.GetString(0)
        Loop

        myReader.Close()
        con.Close()
    End Sub

    Public Overrides Sub Delete()
        MyBase.Delete()

    End Sub
    Public Overrides Sub Updata()
        If Me.IDBusiness = -1 Then

            Me.CopyObject(PhotoRepositroy)
            PhotoRepositroy.Updata()
            Me.IDPhoto = PhotoRepositroy.IDPhoto
        Else

            Me.CopyObject(PhotoRepositroy)
            PhotoRepositroy.Updata()

        End If
    End Sub
    Private Sub CopyObject(AggregateObject As IPhotoRepositroy)
        AggregateObject.IDPhoto = Me.IDBusiness
        AggregateObject.LocationPhoto = Me.LocationPhoto
        AggregateObject.BodyNewsPhoto = Me.BodyNewsPhoto
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser
    End Sub




End Class
