Public Interface IBusinessQueryRepositroy

    Property IndexConditionClassID As Integer
    Property IndexConditionCreationDate As Integer
    Property IndexConditionDescription As Integer
    Property IndexConditionID As Integer
    Property IndexConditionName As Integer
    Property QClassID As String
    Property QCreationDate As String
    Property QDescription As String
    Property QID As String
    Property QName As String
    Property SeconedValueClassID As String
    Property SeconedValueCreationDate As String
    Property SeconedValueDescription As String
    Property SeconedValueID As String
    Property SeconedValueName As String
    Property IDSqlServerOrElasticSearch As Integer

    Function Run() As List(Of BusinessObject)
End Interface
