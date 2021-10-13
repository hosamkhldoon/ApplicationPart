Public Class HtmlFile
    Inherits File

    Public Property NameFile As String
    Public Property LinkPage As String



    Private HtmlRepositroy As IHtmlFile = New HtmlFileAggregate
    Public Sub DeleteFile()
        HtmlRepositroy.IDBusiness = Me.IDBusiness
        HtmlRepositroy.DeleteFile()
    End Sub
    Public Sub GETNameFile()
        HtmlRepositroy.LinkPage = Me.LinkPage
        HtmlRepositroy.GETNameFile()
        Me.NameFile = HtmlRepositroy.NameFile

    End Sub
    Public Overrides Sub Read()
        HtmlRepositroy.IDBusiness = Me.IDBusiness
        HtmlRepositroy.Read()
        Me.NameFile = HtmlRepositroy.NameFile
        Me.NameFileUser = HtmlRepositroy.NameFileUser
        Me.CreationDateFileUser = HtmlRepositroy.CreationDateFileUser
        Me.LinkPage = HtmlRepositroy.LinkPage
    End Sub
    Public Sub CreateFile()
        HtmlRepositroy.NameFile = Me.NameFile
        HtmlRepositroy.LinkPage = Me.LinkPage
        HtmlRepositroy.NameFileUser = Me.NameFileUser
        HtmlRepositroy.CreationDateFileUser = Me.CreationDateFileUser
        HtmlRepositroy.ClassIDFileOrUser = Me.ClassIDFileOrUser
        HtmlRepositroy.CreateFile()
        Me.IDBusiness = HtmlRepositroy.IDBusiness
    End Sub
End Class
