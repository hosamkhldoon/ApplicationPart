Imports Elasticsearch.Net
Imports Nest

Public Class ContactReportElastic
    Inherits BusinessReportsql
    Implements IContactRepsitroy

    Public Property Address As String Implements IContactRepsitroy.Address
    Public Property Password As String Implements IContactRepsitroy.Password
    Public Property TypeContact As String Implements IContactRepsitroy.TypeContact
    Public Property UserName As String Implements IContactRepsitroy.UserName
    Public Property IDContact As Integer Implements IContactRepsitroy.IDContact
    Public Property LastFileDate As DateTime Implements IContactRepsitroy.LastFileDate


    Public Sub New()
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("contact")
        client = New ElasticClient(settings)
    End Sub

    Private client As New ElasticClient()
    Public Overrides Sub Delete() Implements IContactRepsitroy.Delete
        Dim DeleteResponse = Me.client.Delete(Of BytesResponse)(Me.IDBusiness)
    End Sub

    Public Overrides Sub Read() Implements IContactRepsitroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IContactRepsitroy.Updata
        Me.Id = Me.IDBusiness
        Me.DateElastic = Me.CreationDateFileUser
        Me.CreationDateFileUser = ""
        Dim indexResponse = client.IndexDocument(Me)
    End Sub
End Class
