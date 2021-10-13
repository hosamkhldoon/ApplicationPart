Public Class HtmlFileAggregate
    Inherits FileAggregateClass
    Implements IHtmlFile

    Public Property LinkPage As String Implements IHtmlFile.LinkPage


    Public Property NameFile As String Implements IHtmlFile.NameFile

    Private HtmlElastic As New HtmlReportElastic
    Private HtmlSql As New HtmlReportSql
    Public Sub GETNameFile() Implements IHtmlFile.GETNameFile
        Me.HtmlSql.LinkPage = Me.LinkPage
        Me.HtmlSql.GETNameFile()
        Me.NameFile = HtmlSql.NameFile

    End Sub
    Public Overrides Sub Read() Implements IHtmlFile.Read
        Me.HtmlSql.IDBusiness = Me.IDBusiness
        Me.HtmlSql.Read()
        Me.NameFile = HtmlSql.NameFile
        Me.NameFileUser = HtmlSql.NameFileUser
        Me.CreationDateFileUser = HtmlSql.CreationDateFileUser
        Me.LinkPage = HtmlSql.LinkPage
    End Sub

    Public Sub CreateFile() Implements IHtmlFile.CreateFile
        Me.CopyObject(HtmlSql)
        Me.HtmlSql.CreateFile()
        Me.CopyObject(HtmlElastic)
        Me.IDBusiness = HtmlSql.IDBusiness
        HtmlElastic.IDBusiness = Me.IDBusiness
        HtmlElastic.CreateFile()
    End Sub

    Public Sub DeleteFile() Implements IHtmlFile.DeleteFile
        Me.HtmlSql.IDBusiness = Me.IDBusiness
        HtmlElastic.IDBusiness = Me.IDBusiness
        Me.HtmlSql.Delete()
        HtmlElastic.DeleteFile()
    End Sub
    Private Sub CopyObject(HtmlObject As IHtmlFile)
        HtmlObject.LinkPage = Me.LinkPage
        HtmlObject.NameFile = Me.NameFile
        HtmlObject.NameFileUser = Me.NameFileUser
        HtmlObject.CreationDateFileUser = Me.CreationDateFileUser
        HtmlObject.ClassIDFileOrUser = Me.ClassIDFileOrUser

    End Sub
End Class
