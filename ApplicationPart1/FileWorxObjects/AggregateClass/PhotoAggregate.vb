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
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IPhotoRepositroy.Updata

        If Me.IDPhoto = -1 Then
            Me.CopyObject(PhotoSql)

            PhotoSql.Updata()
            Me.IDPhoto = PhotoSql.IDBusiness
            Me.CopyObject(PhotoElastic)
            PhotoElastic.Updata()
        Else
            Me.CopyObject(PhotoSql)
            Me.CopyObject(PhotoElastic)
            PhotoSql.Updata()
            PhotoElastic.Updata()
        End If
    End Sub
    Private Sub CopyObject(PhotoObject As IPhotoRepositroy)
        PhotoObject.IDPhoto = Me.IDPhoto
        PhotoObject.LocationPhoto = Me.LocationPhoto
        PhotoObject.BodyNewsPhoto = Me.BodyNewsPhoto
        PhotoObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        PhotoObject.CreationDateFileUser = Me.CreationDateFileUser
        PhotoObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        PhotoObject.NameFileUser = Me.NameFileUser
    End Sub
End Class
