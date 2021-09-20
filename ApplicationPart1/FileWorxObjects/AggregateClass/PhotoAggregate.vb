Public Class PhotoAggregate
    Inherits FileAggregateClass
    Implements IPhotoRepositroy

    Public Property FileIDPhoto As Integer Implements IPhotoRepositroy.FileIDPhoto
    Public Property IDPhoto As Integer Implements IPhotoRepositroy.IDPhoto
    Public Property LocationPhoto As String Implements IPhotoRepositroy.LocationPhoto




    Public Overrides Sub Delete() Implements IPhotoRepositroy.Delete
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Read() Implements IPhotoRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IPhotoRepositroy.Updata
        Dim PhotoElastic As New PhotoReportElastic
        Dim PhotoSql As New PhotoReportSql
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
