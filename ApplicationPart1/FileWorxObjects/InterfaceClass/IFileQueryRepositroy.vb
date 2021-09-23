Public Interface IFileQueryRepositroy

    Inherits IBusinessQueryRepositroy
    Property IndexConditionBody As Integer
    Property QBody As String
    Property SeconedValueBody As String
    Property IDSqlServerOrElasticSearch As Integer

    Overloads Function Run() As List(Of BusinessObject)
End Interface
