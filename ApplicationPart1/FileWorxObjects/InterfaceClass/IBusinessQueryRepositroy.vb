Public Interface IBusinessQueryRepositroy
    ReadOnly Property ColumnNames As String
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
    Property SeconedValueCondition As String
    Property SeconedValueCreationDate As String
    Property SeconedValueDescription As String
    Property SeconedValueID As String
    Property SeconedValueName As String
    Property StringCondition As String
    ReadOnly Property TableName As String
    Property ValueCondition As String
    ReadOnly Property WhereColumns As String
    Function Run() As List(Of IBusinessObjectRepositroy)
End Interface
