Public Interface IFileQueryRepositroy
    Property IndexConditionBody As Integer
    Property QBody As String
    Property SeconedValueBody As String
    ReadOnly Property TableName As String
    ReadOnly Property WhereColumns As String
    Function Run() As List(Of IBusinessObjectRepositroy)
End Interface
