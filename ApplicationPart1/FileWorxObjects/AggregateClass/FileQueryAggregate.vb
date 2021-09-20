Public Class FileQueryAggregate
    Inherits BusinessQueryAggregate
    Implements IFileQueryRepositroy

    Public Property IndexConditionBody As Integer Implements IFileQueryRepositroy.IndexConditionBody
    Public Property QBody As String Implements IFileQueryRepositroy.QBody
    Public Property SeconedValueBody As String Implements IFileQueryRepositroy.SeconedValueBody






    Public Overloads Function Run() As List(Of BusinessObject) Implements IFileQueryRepositroy.Run
        Throw New NotImplementedException()
    End Function
End Class
