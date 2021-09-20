Public Class BusinessQueryElastic
    Implements IBusinessQueryRepositroy

    Public ReadOnly Property ColumnNames As String Implements IBusinessQueryRepositroy.ColumnNames


    Public Property IndexConditionClassID As Integer Implements IBusinessQueryRepositroy.IndexConditionClassID
    Public Property IndexConditionCreationDate As Integer Implements IBusinessQueryRepositroy.IndexConditionCreationDate
    Public Property IndexConditionDescription As Integer Implements IBusinessQueryRepositroy.IndexConditionDescription
    Public Property IndexConditionID As Integer Implements IBusinessQueryRepositroy.IndexConditionID
    Public Property IndexConditionName As Integer Implements IBusinessQueryRepositroy.IndexConditionName


    Public Property QClassID As String Implements IBusinessQueryRepositroy.QClassID
    Public Property QCreationDate As String Implements IBusinessQueryRepositroy.QCreationDate
    Public Property QDescription As String Implements IBusinessQueryRepositroy.QDescription
    Public Property QID As String Implements IBusinessQueryRepositroy.QID
    Public Property QName As String Implements IBusinessQueryRepositroy.QName

    Public Property SeconedValueClassID As String Implements IBusinessQueryRepositroy.SeconedValueClassID
    Public Property SeconedValueCondition As String Implements IBusinessQueryRepositroy.SeconedValueCondition
    Public Property SeconedValueCreationDate As String Implements IBusinessQueryRepositroy.SeconedValueCreationDate
    Public Property SeconedValueDescription As String Implements IBusinessQueryRepositroy.SeconedValueDescription
    Public Property SeconedValueID As String Implements IBusinessQueryRepositroy.SeconedValueID
    Public Property SeconedValueName As String Implements IBusinessQueryRepositroy.SeconedValueName


    Public Property StringCondition As String Implements IBusinessQueryRepositroy.StringCondition

    Private tablebusiness As String = "T_BUSINESSOBJECT"
    Public ReadOnly Property TableName As String Implements IBusinessQueryRepositroy.TableName


    Public Property ValueCondition As String Implements IBusinessQueryRepositroy.ValueCondition


    Public ReadOnly Property WhereColumns As String Implements IBusinessQueryRepositroy.WhereColumns


    Public ListUser As New List(Of User)

    Public ItemIndexBusiness As Integer
    Public Conditionbusiness As String
    Public Sub New()
        Me.QID = ""
        Me.QName = ""
        Me.QDescription = ""
        Me.QCreationDate = ""
        Me.QClassID = ""
        Me.Conditionbusiness = ""

    End Sub
    Public Function Run() As List(Of IBusinessObjectRepositroy) Implements IBusinessQueryRepositroy.Run
        Throw New NotImplementedException()
    End Function
End Class
