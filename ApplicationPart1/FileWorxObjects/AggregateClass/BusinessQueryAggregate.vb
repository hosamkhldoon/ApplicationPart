Public Class BusinessQueryAggregate
    Implements IBusinessQueryRepositroy

    Public Property IndexConditionID As Integer Implements IBusinessQueryRepositroy.IndexConditionID
    Public Property IndexConditionName As Integer Implements IBusinessQueryRepositroy.IndexConditionName
    Public Property IndexConditionDescription As Integer Implements IBusinessQueryRepositroy.IndexConditionDescription
    Public Property IndexConditionCreationDate As Integer Implements IBusinessQueryRepositroy.IndexConditionCreationDate
    Public Property IndexConditionClassID As Integer Implements IBusinessQueryRepositroy.IndexConditionClassID


    Public Property SeconedValueID As String Implements IBusinessQueryRepositroy.SeconedValueID
    Public Property SeconedValueName As String Implements IBusinessQueryRepositroy.SeconedValueName
    Public Property SeconedValueDescription As String Implements IBusinessQueryRepositroy.SeconedValueDescription
    Public Property SeconedValueCreationDate As String Implements IBusinessQueryRepositroy.SeconedValueCreationDate
    Public Property SeconedValueClassID As String Implements IBusinessQueryRepositroy.SeconedValueClassID



    Public Property QID As String Implements IBusinessQueryRepositroy.QID
    Public Property QClassID As String Implements IBusinessQueryRepositroy.QClassID
    Public Property QName As String Implements IBusinessQueryRepositroy.QName
    Public Property QCreationDate As String Implements IBusinessQueryRepositroy.QCreationDate
    Public Property QDescription As String Implements IBusinessQueryRepositroy.QDescription


    Private BusinessQuerySql As New BusinessQueryReportsql

    Public Function Run() As List(Of BusinessObject) Implements IBusinessQueryRepositroy.Run

        Return BusinessQuerySql.Run()
    End Function
End Class
