Public Class FileQueryElastic
    Implements IFileQueryRepositroy

    Public Property IndexConditionBody As Integer Implements IFileQueryRepositroy.IndexConditionBody


    Public Property QBody As String Implements IFileQueryRepositroy.QBody


    Public Property SeconedValueBody As String Implements IFileQueryRepositroy.SeconedValueBody


    Public ReadOnly Property TableName As String Implements IFileQueryRepositroy.TableName


    Public ReadOnly Property WhereColumns As String Implements IFileQueryRepositroy.WhereColumns


    Public Function Run() As List(Of IBusinessObjectRepositroy) Implements IFileQueryRepositroy.Run
        Throw New NotImplementedException()
    End Function
End Class
