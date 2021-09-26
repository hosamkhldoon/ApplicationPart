Public Class PhotoAggregate
    Inherits FileAggregateClass
    Implements IPhotoRepositroy

    Public Property FileIDPhoto As Integer Implements IPhotoRepositroy.FileIDPhoto
    Public Property IDPhoto As Integer Implements IPhotoRepositroy.IDPhoto
    Public Property LocationPhoto As String Implements IPhotoRepositroy.LocationPhoto



    Private PhotoElastic As New PhotoReportElastic
    Private PhotoSql As New PhotoReportSql
    Public Overrides Sub Delete() Implements IPhotoRepositroy.Delete
        PhotoElastic.IDBusiness = Me.IDBusiness
        PhotoSql.IDBusiness = Me.IDBusiness
        PhotoElastic.Delete()
        PhotoSql.Delete()
    End Sub

    Public Overrides Sub Read() Implements IPhotoRepositroy.Read
        Me.PhotoSql.IDBusiness = Me.IDBusiness
        Me.PhotoSql.Read()
        Me.CopyObjectFromSql(Me.PhotoSql)
    End Sub

    Public Overrides Sub Updata() Implements IPhotoRepositroy.Updata

        If Me.IDBusiness = -1 Then
            Me.CopyObject(Me.PhotoSql)

            Me.PhotoSql.Updata()
            Me.IDBusiness = Me.PhotoSql.IDBusiness
            Me.CopyObject(Me.PhotoElastic)
            Me.PhotoElastic.IDCreateOrUpdate = -1
            Me.PhotoElastic.Updata()
        Else
            Me.CopyObject(Me.PhotoSql)
            Me.CopyObject(Me.PhotoElastic)
            Me.PhotoSql.Updata()
            Me.PhotoElastic.Updata()
        End If
    End Sub
    Private Sub CopyObject(PhotoObject As IPhotoRepositroy)
        PhotoObject.IDBusiness = Me.IDBusiness
        PhotoObject.LocationPhoto = Me.LocationPhoto
        PhotoObject.BodyNewsPhoto = Me.BodyNewsPhoto
        PhotoObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        PhotoObject.CreationDateFileUser = Me.CreationDateFileUser
        PhotoObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        PhotoObject.NameFileUser = Me.NameFileUser
    End Sub
    Private Sub CopyObjectFromSql(PhotoObject As IPhotoRepositroy)
        Me.IDBusiness = PhotoObject.IDBusiness
        Me.LocationPhoto = PhotoObject.LocationPhoto
        Me.BodyNewsPhoto = PhotoObject.BodyNewsPhoto
        Me.DescriptionNewsPhoto = PhotoObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = PhotoObject.CreationDateFileUser
        Me.ClassIDFileOrUser = PhotoObject.ClassIDFileOrUser
        Me.NameFileUser = PhotoObject.NameFileUser
    End Sub
End Class
