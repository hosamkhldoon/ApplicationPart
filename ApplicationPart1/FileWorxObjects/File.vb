Imports System.Data.SqlClient
Public Class File
    Inherits BusinessObject


    Public Property IDFile() As Integer

    Public Property BodyNewsPhoto() As String

    Private AggregateClassFile As New FileAggregateClass

    Private con As SqlConnection

    Public Sub New()
        Me.BodyNewsPhoto = ""

    End Sub
    Public Overrides Sub Read()

    End Sub

    Public Overrides Sub Delete()

        MyBase.Delete()
    End Sub
    Public Overrides Sub Updata()

    End Sub
    Private Sub CopyObject(AggregateObject As FileAggregateClass)
        AggregateObject.IDFile = Me.IDFile
        AggregateObject.BodyNewsPhoto = Me.BodyNewsPhoto

    End Sub
End Class