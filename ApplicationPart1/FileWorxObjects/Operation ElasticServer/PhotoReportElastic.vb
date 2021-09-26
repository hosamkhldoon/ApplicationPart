Imports Elasticsearch.Net
Imports Nest

Public Class PhotoReportElastic
    Inherits FileReportElstic
    Implements IPhotoRepositroy

    Public Property FileIDPhoto As Integer Implements IPhotoRepositroy.FileIDPhoto
    Public Property IDPhoto As Integer Implements IPhotoRepositroy.IDPhoto
    Public Property LocationPhoto As String Implements IPhotoRepositroy.LocationPhoto

    Public Sub New()
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("file")
        client = New ElasticClient(settings)
    End Sub

    Private client As New ElasticClient()
    Public Overrides Sub Delete() Implements IPhotoRepositroy.Delete
        Dim DeleteResponse = Me.client.Delete(Of BytesResponse)(Me.IDBusiness)
    End Sub

    Public Overrides Sub Read() Implements IPhotoRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IPhotoRepositroy.Updata
        Me.Id = Me.IDBusiness
        Me.DateElastic = Me.CreationDateFileUser
        Me.CreationDateFileUser = ""
        Dim indexResponse = client.IndexDocument(Me)

    End Sub

End Class
