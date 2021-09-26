Imports Nest
Imports Elasticsearch.Net
Imports MessagePack.Formatters
Imports NodaTime

Public Class NewsReportElastic
    Inherits FileReportSql
    Implements INewsRepositroy

    Public Property CategoryNews As String Implements INewsRepositroy.CategoryNews
    Public Property IDNews As Integer Implements INewsRepositroy.IDNews



    Public Sub New()
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("file")
        client = New ElasticClient(settings)
    End Sub

    Private client As New ElasticClient()
    Public Overrides Sub Delete() Implements INewsRepositroy.Delete
        Dim DeleteResponse = Me.client.Delete(Of BytesResponse)(Me.IDBusiness)
    End Sub

    Public Overrides Sub Read() Implements INewsRepositroy.Read

    End Sub

    Public Overrides Sub Updata() Implements INewsRepositroy.Updata
        Me.Id = Me.IDBusiness
        Dim NewsElastic As New NewsReportElastic
        Me.DateElastic = Me.CreationDateFileUser
        Me.CreationDateFileUser = ""
        Dim indexResponse = client.IndexDocument(Me)

    End Sub


End Class
