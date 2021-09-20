Public Class NewsAggregate
    Inherits FileAggregateClass
    Implements INewsRepositroy

    Public Property CategoryNews As String Implements INewsRepositroy.CategoryNews

    Public Property IDNews As Integer Implements INewsRepositroy.IDNews


    Public Overrides Sub Delete() Implements INewsRepositroy.Delete

    End Sub

    Public Overrides Sub Read() Implements INewsRepositroy.Read

    End Sub

    Public Overrides Sub Updata() Implements INewsRepositroy.Updata
        Dim NewsElastic As New NewsReportElastic
        Dim NewsSql As New NewsReportSql
        If Me.IDNews = -1 Then
            Me.CopyObject(NewsSql)
            NewsSql.Updata()
            Me.IDNews = NewsSql.IDBusiness
            Me.CopyObject(NewsElastic)
            NewsElastic.Updata()
        Else
            Me.CopyObject(NewsSql)
            NewsSql.Updata()
            Me.CopyObject(NewsElastic)
            NewsElastic.Updata()
        End If
    End Sub
    Private Sub CopyObject(NewsObject As INewsRepositroy)
        NewsObject.IDNews = Me.IDNews
        NewsObject.CategoryNews = Me.CategoryNews
        NewsObject.BodyNewsPhoto = Me.BodyNewsPhoto
        NewsObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        NewsObject.CreationDateFileUser = Me.CreationDateFileUser
        NewsObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        NewsObject.NameFileUser = Me.NameFileUser

    End Sub
End Class
