Public Class ContactAggregate
    Inherits BusinessObjectAggregate
    Implements IContactRepsitroy

    Public Property Address As String Implements IContactRepsitroy.Address


    Public Property Password As String Implements IContactRepsitroy.Password


    Public Property TypeContact As String Implements IContactRepsitroy.TypeContact


    Public Property UserName As String Implements IContactRepsitroy.UserName

    Public Property IDContact As Integer Implements IContactRepsitroy.IDContact

    Public Property LastFileDate As DateTime Implements IContactRepsitroy.LastFileDate


    Private ContactSql As New ContactReportSql
    Private ContactElastic As New ContactReportElastic
    Public Overrides Sub Delete() Implements IContactRepsitroy.Delete
        Me.ContactElastic.IDBusiness = Me.IDBusiness
        Me.ContactSql.IDBusiness = Me.IDBusiness
        Me.ContactElastic.Delete()
        Me.ContactSql.Delete()
    End Sub

    Public Overrides Sub Read() Implements IContactRepsitroy.Read
        Me.ContactSql.IDBusiness = Me.IDBusiness
        Me.ContactSql.Read()
        Me.CopyObjectFromSql(Me.ContactSql)
    End Sub

    Public Overrides Sub Updata() Implements IContactRepsitroy.Updata
        If Me.IDBusiness = -1 Then
            Me.CopyObject(ContactSql)
            Me.ContactSql.Updata()
            Me.IDBusiness = Me.ContactSql.IDBusiness
            Me.CopyObject(Me.ContactElastic)
            Me.ContactElastic.Updata()
        Else
            Me.CopyObject(Me.ContactSql)
            Me.CopyObject(Me.ContactElastic)
            Me.ContactSql.Updata()
            Me.ContactSql.Read()
            Me.ContactElastic.CreationDateFileUser = Me.ContactSql.CreationDateFileUser
            Me.ContactElastic.Updata()
        End If
    End Sub
    Private Sub CopyObject(ContactObject As IContactRepsitroy)
        ContactObject.IDBusiness = Me.IDBusiness
        ContactObject.UserName = Me.UserName
        ContactObject.Address = Me.Address
        ContactObject.Password = Me.Password
        ContactObject.TypeContact = Me.TypeContact
        ContactObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        ContactObject.CreationDateFileUser = Me.CreationDateFileUser
        ContactObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        ContactObject.NameFileUser = Me.NameFileUser
        ContactObject.LastFileDate = Me.LastFileDate
    End Sub
    Private Sub CopyObjectFromSql(ContactObject As IContactRepsitroy)
        Me.IDBusiness = ContactObject.IDBusiness
        Me.UserName = ContactObject.UserName
        Me.Address = ContactObject.Address
        Me.Password = ContactObject.Password
        Me.TypeContact = ContactObject.TypeContact
        Me.DescriptionNewsPhoto = ContactObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = ContactObject.CreationDateFileUser
        Me.ClassIDFileOrUser = ContactObject.ClassIDFileOrUser
        Me.NameFileUser = ContactObject.NameFileUser
        Me.LastFileDate = ContactObject.LastFileDate
    End Sub
End Class
