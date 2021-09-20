Imports Elasticsearch.Net

Public Class PhotoReportElastic
    Inherits FileReportSql
    Implements IPhotoRepositroy

    Public Property FileIDPhoto As Integer Implements IPhotoRepositroy.FileIDPhoto
    Public Property IDPhoto As Integer Implements IPhotoRepositroy.IDPhoto
    Public Property LocationPhoto As String Implements IPhotoRepositroy.LocationPhoto



    Private lowlevelClient As New ElasticLowLevelClient()
    Public Overrides Sub Delete() Implements IPhotoRepositroy.Delete
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Read() Implements IPhotoRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IPhotoRepositroy.Updata

        Dim IndexResponse = Me.lowlevelClient.Index(Of BytesResponse)("file", Me.IDPhoto, PostData.Serializable(Me))

    End Sub
End Class
