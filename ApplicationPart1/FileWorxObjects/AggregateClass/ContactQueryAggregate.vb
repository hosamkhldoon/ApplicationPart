Imports FileWorxObjects.FileQueryAggregate

Public Class ContactQueryAggregate
    Inherits BusinessQueryAggregate
    Implements IContactQueryRepositroy

    Public Property QType As String Implements IContactQueryRepositroy.QType

    Private ContactQuerySql As New ContactQuerySql
    Private ContactQueryElstic As New ContactQueryElastic
    Private Overloads Function Run() As List(Of Contact) Implements IContactQueryRepositroy.Run
        If Me.IDSqlServerOrElasticSearch = SqlOrElastic.ElasticSearch Then
            Me.CopyObject(Me.ContactQueryElstic)
            Return ContactQueryElstic.Run()
        Else
            Me.CopyObject(Me.ContactQuerySql)
            Return ContactQuerySql.Run()
        End If
    End Function
    Public Overloads Sub CopyObject(ContactQuery As IContactQueryRepositroy)
        ContactQuery.QType = Me.QType
        ContactQuery.QName = Me.QName

        ContactQuery.IndexConditionName = Me.IndexConditionName

    End Sub
End Class
