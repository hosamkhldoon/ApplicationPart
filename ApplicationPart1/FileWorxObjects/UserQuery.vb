Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Text.Json.Serialization

Public Class UserQuery
    Inherits BusinessQuery

    Public Property QLoginName As String
    Public Property QLastModifier As String
    Public Property QPassword As String



    Public Property SeconedValueLoginName As String
    Public Property SeconedValueLastModifier As String



    Public Property IndexConditionLoginName As Integer
    Public Property IndexConditionLastModifier As Integer
    Public Property IndexConditionPassword As Integer

    Private UserQueryAggregate As IUserQueryRepositroy = New BusinessQueryAggregate

    'TODO: Remove


    Public Sub New()

        Me.QLoginName = ""
        Me.QLastModifier = ""
    End Sub
    Public Overloads Function Run() As List(Of User)

        Return UserQueryAggregate.Run()
    End Function


End Class