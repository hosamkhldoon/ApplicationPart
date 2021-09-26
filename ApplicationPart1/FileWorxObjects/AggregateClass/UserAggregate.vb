Public Class UserAggregate
    Inherits BusinessObjectAggregate
    Implements IUserRepositroy

    Public Property IDUser As Integer Implements IUserRepositroy.IDUser
    Public Property LastModifierUser As String Implements IUserRepositroy.LastModifierUser
    Public Property NameLogin As String Implements IUserRepositroy.NameLogin
    Public Property PasswordUser As String Implements IUserRepositroy.PasswordUser
    Public Property TypeUser As String Implements IUserRepositroy.TypeUser


    Private UserSql As New UserReportSql
    Private UserElastic As New UserReportElastic

    Public Overrides Sub Delete() Implements IUserRepositroy.Delete
        Me.UserElastic.IDBusiness = Me.IDBusiness
        Me.UserSql.IDBusiness = Me.IDBusiness
        Me.UserElastic.Delete()
        Me.UserSql.Delete()
    End Sub

    Public Overrides Sub Read() Implements IUserRepositroy.Read
        Me.UserSql.IDBusiness = Me.IDBusiness
        Me.UserSql.Read()
        Me.CopyObjectFromSql(Me.UserSql)
    End Sub

    Public Overrides Sub Updata() Implements IUserRepositroy.Updata
        If Me.IDBusiness = -1 Then
            Me.CopyObject(UserSql)
            Me.UserSql.Updata()
            Me.IDBusiness = Me.UserSql.IDBusiness
            Me.CopyObject(Me.UserElastic)
            Me.UserElastic.IDCreateOrUpdate = -1
            Me.UserElastic.Updata()
        Else
            Me.CopyObject(Me.UserSql)
            Me.CopyObject(Me.UserElastic)
            Me.UserSql.Updata()
            Me.UserElastic.Updata()
        End If
    End Sub

    Public Function CheckLoginUser() As Boolean Implements IUserRepositroy.CheckLoginUser
        Me.UserSql.PasswordUser = Me.PasswordUser
        Me.UserSql.NameLogin = Me.NameLogin
        Dim Cheak As Boolean = Me.UserSql.CheckLoginUser()
        Me.CopyObjectFromSql(Me.UserSql)
        Return Cheak
    End Function
    Private Sub CopyObject(UserObject As IUserRepositroy)
        UserObject.IDBusiness = Me.IDBusiness
        UserObject.NameLogin = Me.NameLogin
        UserObject.LastModifierUser = Me.LastModifierUser
        UserObject.PasswordUser = Me.PasswordUser
        UserObject.TypeUser = Me.TypeUser
        UserObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        UserObject.CreationDateFileUser = Me.CreationDateFileUser
        UserObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        UserObject.NameFileUser = Me.NameFileUser
    End Sub
    Private Sub CopyObjectFromSql(UserObject As IUserRepositroy)
        Me.IDBusiness = UserObject.IDBusiness
        Me.NameLogin = UserObject.NameLogin
        Me.LastModifierUser = UserObject.LastModifierUser
        Me.PasswordUser = UserObject.PasswordUser
        Me.TypeUser = UserObject.TypeUser
        Me.DescriptionNewsPhoto = UserObject.DescriptionNewsPhoto
        Me.CreationDateFileUser = UserObject.CreationDateFileUser
        Me.ClassIDFileOrUser = UserObject.ClassIDFileOrUser
        Me.NameFileUser = UserObject.NameFileUser
    End Sub
End Class
