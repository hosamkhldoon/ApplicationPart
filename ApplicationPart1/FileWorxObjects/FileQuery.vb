Imports System.Data.SqlClient
Imports System.Text.Json.Serialization

Public Class FileQuery
    Inherits BusinessQuery
    Public Property QBody As String

    Public Sub New()

        Me.QBody = ""
    End Sub
    Public Property IndexConditionBody As Integer
    Public Property SeconedValueBody As String

    Private FileQueryAggregate As IFileQueryRepositroy = New FileQueryAggregate
    Public Overrides Function Run() As List(Of BusinessObject)

        Return FileQueryAggregate.Run()
    End Function

    Public Overloads Sub CopyObject(AggregateQuery As IFileQueryRepositroy)
        AggregateQuery.QCreationDate = Me.QCreationDate
        AggregateQuery.QClassID = Me.QClassID
        AggregateQuery.QDescription = Me.QDescription
        AggregateQuery.QID = Me.QID
        AggregateQuery.QName = Me.QName
        AggregateQuery.SeconedValueClassID = Me.SeconedValueClassID
        AggregateQuery.SeconedValueCreationDate = Me.SeconedValueCreationDate
        AggregateQuery.SeconedValueDescription = Me.SeconedValueDescription
        AggregateQuery.SeconedValueID = Me.SeconedValueID
        AggregateQuery.SeconedValueName = Me.SeconedValueName
        AggregateQuery.IndexConditionClassID = Me.IndexConditionClassID
        AggregateQuery.IndexConditionCreationDate = Me.IndexConditionCreationDate
        AggregateQuery.IndexConditionDescription = Me.IndexConditionDescription
        AggregateQuery.IndexConditionID = Me.IndexConditionID
        AggregateQuery.IndexConditionName = Me.IndexConditionName
        AggregateQuery.IndexConditionBody = Me.IndexConditionBody
        AggregateQuery.SeconedValueBody = Me.SeconedValueBody
        AggregateQuery.QBody = Me.QBody
    End Sub

End Class