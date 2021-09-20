Public Class UserQueryAggregate
    Inherits BusinessQueryAggregate
    Implements IUserQueryRepositroy

    Public Property IndexConditionLastModifier As Integer Implements IUserQueryRepositroy.IndexConditionLastModifier
    Public Property IndexConditionLoginName As Integer Implements IUserQueryRepositroy.IndexConditionLoginName
    Public Property IndexConditionPassword As Integer Implements IUserQueryRepositroy.IndexConditionPassword

    Public Property QLastModifier As String Implements IUserQueryRepositroy.QLastModifier
    Public Property QLoginName As String Implements IUserQueryRepositroy.QLoginName
    Public Property QPassword As String Implements IUserQueryRepositroy.QPassword

    Public Property SeconedValueLastModifier As String Implements IUserQueryRepositroy.SeconedValueLastModifier
    Public Property SeconedValueLoginName As String Implements IUserQueryRepositroy.SeconedValueLoginName


    Public Overloads Function Run() As List(Of User) Implements IUserQueryRepositroy.Run
        Throw New NotImplementedException()
    End Function
End Class
