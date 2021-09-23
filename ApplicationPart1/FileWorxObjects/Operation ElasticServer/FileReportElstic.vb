Imports Elasticsearch.Net
Imports Nest

Public Class FileReportElstic
    Inherits BusinessReportElastic
    Implements IFileRepositroy

    Public Property BodyNewsPhoto As String Implements IFileRepositroy.BodyNewsPhoto
    Public Property IDFile As Integer Implements IFileRepositroy.IDFile




    Public Overrides Sub Delete() Implements IFileRepositroy.Delete


    End Sub

    Public Overrides Sub Read() Implements IFileRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IFileRepositroy.Updata
        Throw New NotImplementedException()
    End Sub


End Class
