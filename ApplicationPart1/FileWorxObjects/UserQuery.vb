Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Text.Json.Serialization

Public Class UserQuery
    Inherits BusinessQuery

    Public Property QLoginName As String
    Public Property QLastModifier As String
    Public Property QPassword As String



    Public Property SeconedValueLoginName As String
    Public Property SeconedValueLastModifier As String



    Public Property IndexConditionLoginName As Integer
    Public Property IndexConditionLastModifier As Integer
    Public Property IndexConditionPassword As Integer

    Private UserQueryAggregate As IUserQueryRepositroy = New UserQueryAggregate

    'TODO: Remove


    Public Sub New()

        Me.QLoginName = ""
        Me.QLastModifier = ""
    End Sub
    Public Overloads Function Run() As List(Of User)
        Me.CopyObject(UserQueryAggregate)
        UserQueryAggregate.IDSqlServerOrElasticSearch = Me.IDSqlServerOrElsticSearch
        Return UserQueryAggregate.Run()
    End Function
    Public Overloads Sub CopyObject(AggregateQuery As IUserQueryRepositroy)
        AggregateQuery.QCreationDate = Me.QCreationDate
        AggregateQuery.QClassID = Me.QClassID
        AggregateQuery.QDescription = Me.QDescription
        AggregateQuery.QID = Me.QID
        AggregateQuery.QName = Me.QName
        AggregateQuery.QLastModifier = Me.QLastModifier
        AggregateQuery.QLoginName = Me.QLoginName

        AggregateQuery.SeconedValueClassID = Me.SeconedValueClassID
        AggregateQuery.SeconedValueCreationDate = Me.SeconedValueCreationDate
        AggregateQuery.SeconedValueDescription = Me.SeconedValueDescription
        AggregateQuery.SeconedValueID = Me.SeconedValueID
        AggregateQuery.SeconedValueName = Me.SeconedValueName
        AggregateQuery.SeconedValueLoginName = Me.SeconedValueLoginName
        AggregateQuery.SeconedValueLastModifier = Me.SeconedValueLastModifier

        AggregateQuery.IndexConditionClassID = Me.IndexConditionClassID
        AggregateQuery.IndexConditionCreationDate = Me.IndexConditionCreationDate
        AggregateQuery.IndexConditionDescription = Me.IndexConditionDescription
        AggregateQuery.IndexConditionID = Me.IndexConditionID
        AggregateQuery.IndexConditionName = Me.IndexConditionName
        AggregateQuery.IndexConditionLastModifier = Me.IndexConditionLastModifier
        AggregateQuery.IndexConditionLoginName = Me.IndexConditionLoginName
    End Sub

End Class