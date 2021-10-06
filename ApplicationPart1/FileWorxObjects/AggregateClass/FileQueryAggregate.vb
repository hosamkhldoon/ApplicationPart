
Public Class FileQueryAggregate
    Inherits BusinessQueryAggregate
    Implements IFileQueryRepositroy
    Enum SqlOrElastic
        SqlServer = 2
        ElasticSearch = 1
    End Enum
    Public Property IndexConditionBody As Integer Implements IFileQueryRepositroy.IndexConditionBody
    Public Property QBody As String Implements IFileQueryRepositroy.QBody
    Public Property SeconedValueBody As String Implements IFileQueryRepositroy.SeconedValueBody




    Private FileQuerySql As New FileQueryReportSql
    Private FileQueryElstic As New FileQueryElastic

    Public Overloads Function Run() As List(Of BusinessObject) Implements IFileQueryRepositroy.Run
        If Me.IDSqlServerOrElasticSearch = SqlOrElastic.ElasticSearch Then
            Me.CopyObject(Me.FileQueryElstic)
            Return Me.FileQueryElstic.Run()
        Else
            Me.CopyObject(Me.FileQuerySql)
            Return FileQuerySql.Run()
        End If

    End Function
    Public Overloads Sub CopyObject(FileQuery As IFileQueryRepositroy)
        FileQuery.QCreationDate = Me.QCreationDate
        FileQuery.QClassID = Me.QClassID
        FileQuery.QDescription = Me.QDescription
        FileQuery.QID = Me.QID
        FileQuery.QName = Me.QName
        FileQuery.QBody = Me.QBody

        FileQuery.SeconedValueClassID = Me.SeconedValueClassID
        FileQuery.SeconedValueCreationDate = Me.SeconedValueCreationDate
        FileQuery.SeconedValueDescription = Me.SeconedValueDescription
        FileQuery.SeconedValueID = Me.SeconedValueID
        FileQuery.SeconedValueName = Me.SeconedValueName
        FileQuery.SeconedValueBody = Me.SeconedValueBody

        FileQuery.IndexConditionClassID = Me.IndexConditionClassID
        FileQuery.IndexConditionCreationDate = Me.IndexConditionCreationDate
        FileQuery.IndexConditionDescription = Me.IndexConditionDescription
        FileQuery.IndexConditionID = Me.IndexConditionID
        FileQuery.IndexConditionName = Me.IndexConditionName
        FileQuery.IndexConditionBody = Me.IndexConditionBody


    End Sub
End Class
