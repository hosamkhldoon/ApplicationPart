
Public Class BusinessQuery



    Public Property IndexConditionID As Integer
    Public Property IndexConditionName As Integer
    Public Property IndexConditionDescription As Integer
    Public Property IndexConditionCreationDate As Integer
    Public Property IndexConditionClassID As Integer

    Public Property SeconedValueID As String
    Public Property SeconedValueName As String
    Public Property SeconedValueDescription As String
    Public Property SeconedValueCreationDate As String
    Public Property SeconedValueClassID As String



    Public Property QID As String
    Public Property QClassID As String
    Public Property QName As String
    Public Property QCreationDate As String
    Public Property QDescription As String

    Public Property ValueCondition As String
    Public Property StringCondition As String
    Public Property SeconedValueCondition As String


    Public BusinessQueryAggregate As IBusinessQueryRepositroy = New BusinessQueryAggregate







    Public Sub New()
        Me.QID = ""
        Me.QName = ""
        Me.QDescription = ""
        Me.QCreationDate = ""
        Me.QClassID = ""


    End Sub

    Public Overridable Function Run() As List(Of BusinessObject)

        Return BusinessQueryAggregate.Run()
    End Function


End Class