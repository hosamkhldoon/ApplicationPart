Imports Nest
Imports Elasticsearch.Net

Public Class NewsReportElastic
    Inherits FileReportSql
    Implements INewsRepositroy

    Public Property CategoryNews As String Implements INewsRepositroy.CategoryNews
    Public Property IDNews As Integer Implements INewsRepositroy.IDNews


    Private lowlevelClient As New ElasticLowLevelClient()

    Public Overrides Sub Delete() Implements INewsRepositroy.Delete
        Dim DeleteResponse = Me.lowlevelClient.Delete(Of BytesResponse)("file", Me.IDBusiness)
    End Sub

    Public Overrides Sub Read() Implements INewsRepositroy.Read

    End Sub

    Public Overrides Sub Updata() Implements INewsRepositroy.Updata

        Dim IndexResponse = Me.lowlevelClient.Index(Of BytesResponse)("file", Me.IDNews, PostData.Serializable(Me))

    End Sub


End Class
