
Imports System.Data.SqlClient



Public Class BusinessObject



    Public Property IDBusiness() As Integer
    Public Property CreationDateFileUser As String

    Public Property NameFileUser As String

    Public Property ClassIDFileOrUser As Integer

    Public Property DescriptionNewsPhoto As String

    Public Property DateElastic As Date

    Private BusinessRepositroy As IBusinessObjectRepositroy = New BusinessObjectAggregate

    Public Sub New()
        Me.DescriptionNewsPhoto = ""
        Me.CreationDateFileUser = ""
        Me.NameFileUser = ""
        Me.IDBusiness = 0
        Me.ClassIDFileOrUser = 0
    End Sub
    Public Overridable Sub Read()
        BusinessRepositroy.IDBusiness = Me.IDBusiness
        BusinessRepositroy.Read()
        Me.ClassIDFileOrUser = BusinessRepositroy.ClassIDFileOrUser


    End Sub

    Public Overridable Sub Delete()

        BusinessRepositroy.IDBusiness = Me.IDBusiness
        BusinessRepositroy.Delete()
    End Sub
    Public Overridable Sub Updata()

    End Sub
    Private Sub CopyObject(AggregateObject As BusinessObjectAggregate)
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser
        AggregateObject.IDBusiness = Me.IDBusiness

    End Sub
End Class