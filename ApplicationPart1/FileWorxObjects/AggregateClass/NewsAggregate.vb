Public Class NewsAggregate
    Inherits FileAggregateClass
    Implements INewsRepositroy

    Public Property CategoryNews As String Implements INewsRepositroy.CategoryNews
    Public Property IDNews As Integer Implements INewsRepositroy.IDNews


    Private NewsElastic As New NewsReportElastic
    Private NewsSql As New NewsReportSql

    Public Overrides Sub Delete() Implements INewsRepositroy.Delete
        Me.NewsElastic.IDBusiness = Me.IDBusiness
        Me.NewsSql.IDBusiness = Me.IDBusiness
        Me.NewsElastic.Delete()
        Me.NewsSql.Delete()
    End Sub

    Public Overrides Sub Read() Implements INewsRepositroy.Read
        Me.NewsSql.IDBusiness = Me.IDBusiness
        Me.NewsSql.Read()
        Me.CopyObjectFromSql(Me.NewsSql)
    End Sub

    Public Overrides Sub Updata() Implements INewsRepositroy.Updata

        If Me.IDBusiness = -1 Then
            Me.CopyObject(Me.NewsSql)
            Me.NewsSql.Updata()
            Me.IDBusiness = Me.NewsSql.IDBusiness
            Me.CopyObject(Me.NewsElastic)
            Me.NewsElastic.IDCreateOrUpdate = -1
            Me.NewsElastic.Updata()
        Else
            Me.CopyObject(Me.NewsSql)
            Me.NewsSql.Updata()
            Me.CopyObject(Me.NewsElastic)
            Me.NewsElastic.Updata()
        End If
    End Sub
    Private Sub CopyObject(NewsObject As INewsRepositroy)
        NewsObject.IDBusiness = Me.IDBusiness
        NewsObject.CategoryNews = Me.CategoryNews
        NewsObject.BodyNewsPhoto = Me.BodyNewsPhoto
        NewsObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        NewsObject.CreationDateFileUser = Me.CreationDateFileUser
        NewsObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        NewsObject.NameFileUser = Me.NameFileUser

    End Sub
    Private Sub CopyObjectFromSql(NewsObject As INewsRepositroy)
        Me.IDBusiness = NewsObject.IDBusiness
        Me.CategoryNews = NewsObject.CategoryNews
        Me.BodyNewsPhoto = NewsObject.BodyNewsPhoto
        Me.DescriptionNewsPhoto = NewsObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = NewsObject.CreationDateFileUser
        Me.ClassIDFileOrUser = NewsObject.ClassIDFileOrUser
        Me.NameFileUser = NewsObject.NameFileUser

    End Sub
End Class
