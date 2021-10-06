Public Class ContactQuery
    Inherits BusinessQuery

    Public Property QType As String

    Private ContactQueryAggregate As IContactQueryRepositroy = New ContactQueryAggregate

    Public Overloads Function Run() As List(Of Contact)
        Me.CopyObject(ContactQueryAggregate)
        ContactQueryAggregate.IDSqlServerOrElasticSearch = Me.IDSqlServerOrElsticSearch
        Return ContactQueryAggregate.Run()
    End Function
    Public Overloads Sub CopyObject(AggregateQuery As IContactQueryRepositroy)
        AggregateQuery.QType = Me.QType
        AggregateQuery.QName = Me.QName


        AggregateQuery.IndexConditionName = Me.IndexConditionName

    End Sub
End Class
