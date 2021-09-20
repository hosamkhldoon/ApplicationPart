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
        UserElastic.IDBusiness = Me.IDBusiness
        UserSql.IDBusiness = Me.IDBusiness
        UserElastic.Delete()
        UserSql.Delete()
    End Sub

    Public Overrides Sub Read() Implements IUserRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IUserRepositroy.Updata
        If Me.IDUser = -1 Then
            Me.CopyObject(UserSql)
            Me.UserSql.Updata()
            Me.IDUser = UserSql.IDBusiness
            Me.CopyObject(UserElastic)
            Me.UserElastic.Updata()
        Else
            Me.CopyObject(UserSql)
            Me.CopyObject(UserElastic)
            Me.UserSql.Updata()
            Me.UserElastic.Updata()
        End If
    End Sub

    Public Function CheckLoginUser() As Boolean Implements IUserRepositroy.CheckLoginUser
        Throw New NotImplementedException()
    End Function
    Private Sub CopyObject(UserObject As IUserRepositroy)
        UserObject.IDUser = Me.IDUser
        UserObject.NameLogin = Me.NameLogin
        UserObject.LastModifierUser = Me.LastModifierUser
        UserObject.PasswordUser = Me.PasswordUser
        UserObject.TypeUser = Me.TypeUser
        UserObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        UserObject.CreationDateFileUser = Me.CreationDateFileUser
        UserObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        UserObject.NameFileUser = Me.NameFileUser
    End Sub
End Class
