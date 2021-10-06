Public Interface IUserQueryRepositroy
    Inherits IBusinessQueryRepositroy

    Property IndexConditionLastModifier As Integer
    Property IndexConditionLoginName As Integer
    Property IndexConditionPassword As Integer
    Property QLastModifier As String
    Property QLoginName As String
    Property QPassword As String
    Property SeconedValueLastModifier As String
    Property SeconedValueLoginName As String

    Overloads Function Run() As List(Of User)
End Interface
