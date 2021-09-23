Imports System.Data.SqlClient
Public Class QueryConditionSql
    Public Property Condition As String
    Public Property SelectItem As Integer
    Public Property ColumnName As String
    Public Property Value As String
    Public Property SeconedValue As String
    Public Property DateValue As DateTime
    Public Property SeconedDate As DateTime
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
    Public Function ConditionInteger() As String
        Select Case Me.SelectItem
            Case ConditionIndex.Equal
                Me.Condition = "" + Me.ColumnName + " = " + Me.Value + ""

            Case ConditionIndex.GreaterThan
                Me.Condition = "" + Me.ColumnName + " > " + Me.Value + ""
            Case ConditionIndex.GreaterOrequal
                Me.Condition = "" + Me.ColumnName + " >= " + Me.Value + ""
            Case ConditionIndex.LessThan
                Me.Condition = "" + Me.ColumnName + " < " + Me.Value + ""
            Case ConditionIndex.LessOrEqual
                Me.Condition = "" + Me.ColumnName + " <= " + Me.Value + ""
            Case ConditionIndex.NotEqual
                Me.Condition = "" + Me.ColumnName + " <> " + Me.Value + ""
            Case ConditionIndex.Between
                Me.Condition = "" + Me.ColumnName + " BETWEEN " + Me.Value + " AND " + Me.SeconedDate + ""
            Case Else


        End Select
        Return Me.Condition
    End Function
    Public Function Conditiondate() As String
        Select Case Me.SelectItem
            Case ConditionIndex.Equal
                Me.Condition = "convert(date, " + Me.ColumnName + ") = '" + Format(Me.DateValue, "yyyy-MM-dd") + "'"

            Case ConditionIndex.GreaterThan
                Me.Condition = "convert(date, " + Me.ColumnName + ") > '" + Format(Me.DateValue, "yyyy-MM-dd") + "'"
            Case ConditionIndex.GreaterOrequal
                Me.Condition = "convert(date, " + Me.ColumnName + ") >= '" + Format(Me.DateValue, "yyyy-MM-dd") + "'"
            Case ConditionIndex.LessThan
                Me.Condition = "convert(date, " + Me.ColumnName + ") < '" + Format(Me.DateValue, "yyyy-MM-dd") + "'"
            Case ConditionIndex.LessOrEqual
                Me.Condition = "convert(date, " + Me.ColumnName + ") <= '" + Format(Me.DateValue, "yyyy-MM-dd") + "'"
            Case ConditionIndex.NotEqual
                Me.Condition = "convert(date, " + Me.ColumnName + ") <> '" + Format(Me.DateValue, "yyyy-MM-dd") + "'"
            Case ConditionIndex.Between
                Me.Condition = "convert(date, " + Me.ColumnName + ") BETWEEN '" + Format(Me.DateValue, "yyyy-MM-dd") + "' AND '" + Format(Me.SeconedDate, "yyyy-MM-dd") + "'"
            Case Else


        End Select
        Return Me.Condition
    End Function
    Public Function ConditionString() As String
        Select Case Me.SelectItem
            Case ConditionIndex.StartWith
                Me.Condition = "" + Me.ColumnName + " like'" + Me.Value + "%'"

            Case ConditionIndex.EndWith
                Me.Condition = "" + Me.ColumnName + " like '%" + Me.Value + "'"
            Case ConditionIndex.Contain
                Me.Condition = "" + Me.ColumnName + " like '%" + Me.Value + "%'"
            Case ConditionIndex.Between
                Me.Condition = "" + Me.ColumnName + " BETWEEN " + Me.Value + " AND " + Me.SeconedValue + ""
            Case ConditionIndex.Exists
                Me.Condition = "" + Me.ColumnName + " EXISTS " + Me.Value + ""
            Case ConditionIndex.NotStartWith
                Me.Condition = "" + Me.ColumnName + " NOT like '" + Me.Value + "%'"
            Case ConditionIndex.NotEndWith
                Me.Condition = "" + Me.ColumnName + " NOT like'%" + Me.Value + "'"
            Case ConditionIndex.NotContain
                Me.Condition = "" + Me.ColumnName + "NOT like '%" + Me.Value + "%'"
            Case Else

        End Select
        Return Me.Condition
    End Function
End Class
