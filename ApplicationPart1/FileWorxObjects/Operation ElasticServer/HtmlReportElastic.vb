Imports Elasticsearch.Net
Imports Nest

Public Class HtmlReportElastic
    Inherits FileReportSql
    Implements IHtmlFile

    Public Property LinkPage As String Implements IHtmlFile.LinkPage


    Public Property NameFile As String Implements IHtmlFile.NameFile




    Public Sub New()
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("file")
        client = New ElasticClient(settings)
    End Sub

    Private client As New ElasticClient()
    Public Sub DeleteFile() Implements IHtmlFile.DeleteFile
        Dim DeleteResponse = Me.client.Delete(Of BytesResponse)(Me.IDBusiness)
    End Sub

    Public Sub CreateFile() Implements IHtmlFile.CreateFile
        Me.Id = Me.IDBusiness
        Dim NewsElastic As New NewsReportElastic
        Me.DateElastic = Me.CreationDateFileUser
        Me.CreationDateFileUser = ""
        Dim indexResponse = client.IndexDocument(Me)
    End Sub

    Public Sub GETNameFile() Implements IHtmlFile.GETNameFile
        Throw New NotImplementedException()
    End Sub

    Private Sub IHtmlFile_Read() Implements IHtmlFile.Read
        Throw New NotImplementedException()
    End Sub
End Class
