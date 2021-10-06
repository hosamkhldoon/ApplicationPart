Public Class Contact
    Inherits BusinessObject

    Public Property IDContact As Integer
    Public Property UserName As String
    Public Property Password As String
    Public Property Address As String
    Public Property TypeContact As String

    Public Property LastFileDate As DateTime

    Private ContactRepositroy As IContactRepsitroy = New ContactAggregate



    Public Sub New()


    End Sub
    Public Overrides Sub Read()
        ContactRepositroy.IDBusiness = Me.IDBusiness
        ContactRepositroy.Read()
        Me.CopyObjectFromAggregate(ContactRepositroy)
    End Sub

    Public Overrides Sub Delete()
        ContactRepositroy.IDBusiness = Me.IDBusiness
        ContactRepositroy.Delete()
    End Sub
    Public Overrides Sub Updata()
        If Me.IDBusiness = -1 Then
            Me.CopyObject(ContactRepositroy)
            ContactRepositroy.Updata()
            Me.IDContact = ContactRepositroy.IDBusiness
        Else
            Me.CopyObject(ContactRepositroy)
            ContactRepositroy.Updata()
        End If
    End Sub
    Private Sub CopyObject(AggregateObject As IContactRepsitroy)
        AggregateObject.IDBusiness = Me.IDBusiness
        AggregateObject.Address = Me.Address
        AggregateObject.UserName = Me.UserName
        AggregateObject.Password = Me.Password
        AggregateObject.TypeContact = Me.TypeContact
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser
        AggregateObject.LastFileDate = Me.LastFileDate
    End Sub
    Private Sub CopyObjectFromAggregate(AggregateObject As IContactRepsitroy)
        Me.UserName = AggregateObject.UserName
        Me.Address = AggregateObject.Address
        Me.Password = AggregateObject.Password
        Me.TypeContact = AggregateObject.TypeContact
        Me.IDBusiness = AggregateObject.IDBusiness
        Me.DescriptionNewsPhoto = AggregateObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = AggregateObject.CreationDateFileUser
        Me.ClassIDFileOrUser = AggregateObject.ClassIDFileOrUser
        Me.NameFileUser = AggregateObject.NameFileUser
        Me.LastFileDate = AggregateObject.LastFileDate
    End Sub
End Class
