Public Class FileAggregateClass
    Inherits BusinessObjectAggregate
    Implements IFileRepositroy

    Public Property BodyNewsPhoto As String Implements IFileRepositroy.BodyNewsPhoto
    Public Property IDFile As Integer Implements IFileRepositroy.IDFile



    Private FileSql As New FileReportSql

    Public Overrides Sub Delete() Implements IFileRepositroy.Delete
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Read() Implements IFileRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IFileRepositroy.Updata


    End Sub
    Private Sub CopyObject(FileObject As IFileRepositroy)
        FileObject.IDFile = Me.IDFile
        FileObject.BodyNewsPhoto = Me.BodyNewsPhoto

    End Sub
End Class
