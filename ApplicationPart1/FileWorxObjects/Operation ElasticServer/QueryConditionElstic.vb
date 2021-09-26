Imports Nest

Public Class QueryConditionElstic
    Public Property Condition As QueryContainer
    Public Property SelectItem As Integer
    Public Property Field As String
    Public Property Value As String
    Public Property SeconedValue As String
    Public Property DateValue As Date
    Public Property SeconedDate As Date

    Private querydescriptor As New QueryContainerDescriptor(Of Object)()
    Enum ConditionIndex
        Equal = 0
        GreaterThan = 1
        LessThan = 2
        LessOrEqual = 3
        GreaterOrequal = 4
        Between = 5
        NotEqual = 6
        StartWith = 7
        EndWith = 8
        Contain = 9
        Exists = 10
        NotContain = 11
        NotStartWith = 12
        NotEndWith = 13

    End Enum
    Public Function ConditionInteger() As QueryContainer
        Select Case Me.SelectItem
            Case ConditionIndex.Equal
                Me.Condition = querydescriptor.Term(Function(m) m.Field(Me.Field).Value(Me.Value))
            Case ConditionIndex.GreaterThan
                Me.Condition = querydescriptor.Range(Function(m) m.Field(Me.Field).GreaterThan(Me.Value))
            Case ConditionIndex.GreaterOrequal
                Me.Condition = querydescriptor.Range(Function(m) m.Field(Me.Field).GreaterThanOrEquals(Me.Value))
            Case ConditionIndex.LessThan
                Me.Condition = querydescriptor.Range(Function(m) m.Field(Me.Field).LessThan(Me.Value))
            Case ConditionIndex.LessOrEqual
                Me.Condition = querydescriptor.Range(Function(m) m.Field(Me.Field).LessThanOrEquals(Me.Value))
            Case ConditionIndex.NotEqual
                Me.Condition = querydescriptor.Bool(Function(qc) qc.MustNot(Function(c) c.Term(Function(m) m.Field(Me.Field).Value(Me.Value))))
            Case ConditionIndex.Between
                Me.Condition = querydescriptor.Range(Function(m) m.Field(Me.Field).GreaterThanOrEquals(Me.Value).LessThanOrEquals(Me.SeconedValue))
            Case Else


        End Select
        Return Me.Condition
    End Function
    Public Function Conditiondate() As QueryContainer
        Select Case Me.SelectItem
            Case ConditionIndex.Equal
                Me.Condition = querydescriptor.Term(Function(m) m.Field(Me.Field).Value(Format(Me.DateValue, "yyyy-MM-dd")))
            Case ConditionIndex.GreaterThan
                Me.Condition = querydescriptor.DateRange(Function(m) m.Field(Me.Field).GreaterThan(Format(Me.DateValue, "yyyy-MM-dd")))
            Case ConditionIndex.GreaterOrequal
                Me.Condition = querydescriptor.DateRange(Function(m) m.Field(Me.Field).GreaterThanOrEquals(Format(Me.DateValue, "yyyy-MM-dd")))
            Case ConditionIndex.LessThan
                Me.Condition = querydescriptor.DateRange(Function(m) m.Field(Me.Field).LessThan(Format(Me.DateValue, "yyyy-MM-dd")))
            Case ConditionIndex.LessOrEqual
                Me.Condition = querydescriptor.DateRange(Function(m) m.Field(Me.Field).LessThanOrEquals(Format(Me.DateValue, "yyyy-MM-dd")))
            Case ConditionIndex.NotEqual
                Me.Condition = querydescriptor.Bool(Function(qc) qc.MustNot(Function(c) c.Term(Function(m) m.Field(Me.Field).Value(Format(Me.DateValue, "yyyy-MM-dd")))))
            Case ConditionIndex.Between
                Me.Condition = querydescriptor.DateRange(Function(m) m.Field(Me.Field).GreaterThanOrEquals(Format(Me.DateValue, "yyyy-MM-dd")).LessThanOrEquals(Format(Me.SeconedDate, "yyyy-MM-dd")))
            Case Else


        End Select
        Return Me.Condition
    End Function
    Public Function ConditionString() As QueryContainer
        Select Case Me.SelectItem
            Case ConditionIndex.StartWith
                Me.Condition = querydescriptor.QueryString(Function(m) m.Query(Me.Value + "*").Fields(Me.Field))
            Case ConditionIndex.EndWith
                Me.Condition = querydescriptor.QueryString(Function(m) m.Query("*" + Me.Value).Fields(Me.Field))
            Case ConditionIndex.Contain
                Me.Condition = querydescriptor.QueryString(Function(m) m.Query("*" + Me.Value + "*").Fields(Me.Field))
            Case ConditionIndex.Between
                Me.Condition = querydescriptor.QueryString(Function(m) m.Query(Me.Value + "*" + Me.SeconedValue).Fields(Me.Field))
            Case ConditionIndex.Exists
                Me.Condition = querydescriptor.QueryString(Function(m) m.Query(Me.Value).Fields(Me.Field))
            Case ConditionIndex.NotStartWith
                Me.Condition = querydescriptor.Bool(Function(qc) qc.MustNot(Function(c) c.QueryString(Function(m) m.Query(Me.Value + "*").Fields(Me.Field))))
            Case ConditionIndex.NotEndWith
                Me.Condition = querydescriptor.Bool(Function(qc) qc.MustNot(Function(c) c.QueryString(Function(m) m.Query("*" + Me.Value).Fields(Me.Field))))
            Case ConditionIndex.NotContain
                Me.Condition = querydescriptor.Bool(Function(qc) qc.MustNot(Function(c) c.QueryString(Function(m) m.Query("*" + Me.Value + "*").Fields(Me.Field))))
            Case Else

        End Select
        Return Me.Condition
    End Function

End Class
