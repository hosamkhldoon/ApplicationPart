Imports System.IO
Imports System.Data.SqlClient
Public Class NewsQuery
    Inherits FileQuery
    Private conditionnews As String
    Public CategoryNews As String
    Public ItemIndexNews As Integer

    'TODO: Remove
    Private condition As QueryConditionSql = New QueryConditionSql()

    Public Sub New()
        CategoryNews = ""
    End Sub
    ' Public Overrides function Run() As 
    ' Me.TableName = "T_NEWS"
    'Me.CheckData()

    'End Function
    Private Function CheckData() As String
        If Me.CategoryNews <> "" Then

            Me.condition.SelectItem = Me.ItemIndexNews
            Me.condition.ColumnName = "F.C_Category"
            Me.condition.Value = Me.CategoryNews
            Me.conditionnews = Me.condition.ConditionString()
        End If
        Return Nothing
    End Function
End Class