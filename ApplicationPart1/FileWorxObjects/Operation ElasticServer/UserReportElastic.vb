Imports Elasticsearch.Net

Public Class UserReportElastic
    Inherits BusinessReportsql
    Implements IUserRepositroy

    Public Property IDUser As Integer Implements IUserRepositroy.IDUser
    Public Property LastModifierUser As String Implements IUserRepositroy.LastModifierUser
    Public Property NameLogin As String Implements IUserRepositroy.NameLogin
    Public Property PasswordUser As String Implements IUserRepositroy.PasswordUser
    Public Property TypeUser As String Implements IUserRepositroy.TypeUser


    Private lowlevelClient As New ElasticLowLevelClient()


    Public Overrides Sub Delete() Implements IUserRepositroy.Delete
        Dim DeleteResponse = Me.lowlevelClient.Delete(Of BytesResponse)("file", Me.IDBusiness)
    End Sub

    Public Overrides Sub Read() Implements IUserRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IUserRepositroy.Updata

        Dim IndexResponse = Me.lowlevelClient.Index(Of BytesResponse)("user", Me.IDUser, PostData.Serializable(Me))

    End Sub

    Public Function CheckLoginUser() As Boolean Implements IUserRepositroy.CheckLoginUser
        Throw New NotImplementedException()
    End Function
End Class
