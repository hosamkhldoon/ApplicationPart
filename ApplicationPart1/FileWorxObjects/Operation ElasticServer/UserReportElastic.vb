Imports Elasticsearch.Net
Imports Nest

Public Class UserReportElastic
    Inherits BusinessReportElastic
    Implements IUserRepositroy

    Public Property IDUser As Integer Implements IUserRepositroy.IDUser
    Public Property LastModifierUser As String Implements IUserRepositroy.LastModifierUser
    Public Property NameLogin As String Implements IUserRepositroy.NameLogin
    Public Property PasswordUser As String Implements IUserRepositroy.PasswordUser
    Public Property TypeUser As String Implements IUserRepositroy.TypeUser




    Public Sub New()
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("user")
        client = New ElasticClient(settings)
    End Sub

    Private client As New ElasticClient()
    Public Overrides Sub Delete() Implements IUserRepositroy.Delete
        Dim DeleteResponse = Me.client.Delete(Of BytesResponse)(Me.IDBusiness)
    End Sub

    Public Overrides Sub Read() Implements IUserRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IUserRepositroy.Updata
        Me.Id = Me.IDBusiness
        Me.DateElastic = Me.CreationDateFileUser
        Me.CreationDateFileUser = ""
        Dim indexResponse = client.IndexDocument(Me)

    End Sub

    Public Function CheckLoginUser() As Boolean Implements IUserRepositroy.CheckLoginUser

        Throw New NotImplementedException()
    End Function

End Class
