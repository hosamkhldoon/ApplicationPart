Imports System.IO
Imports System.Data.SqlClient
Public Class PhotoQuery
    Inherits FileQuery
    Private conditionphoto As String
    Public LocationImage As String
    Public ItemIndexPhoto As Integer

    'TODO: Remove
    Private condition As QueryCondition = New QueryCondition()

    Public Sub New()
        Me.LocationImage = ""
    End Sub
    '  Public Overrides Sub Run()

    ' Me.TableName = "T_PHOTO"
    'Me.CheckData()



    ' End Sub
    Private Function CheckData() As String
        If Me.LocationImage <> "" Then
            Me.condition.SelectItem = Me.ItemIndexPhoto
            Me.condition.ColumnName = "F.C_Location"
            Me.condition.Value = Me.LocationImage
            Me.conditionphoto = Me.condition.ConditionString()
        End If
        Return Nothing
    End Function
End Class