Public Interface IUserRepositroy
    Inherits IBusinessObjectRepositroy
    Property IDUser As Integer
    Property LastModifierUser As String
    Property NameLogin As String
    Property PasswordUser As String
    Property TypeUser As String

    Overloads Sub Delete()
    Overloads Sub Read()
    Overloads Sub Updata()
    Function CheckLoginUser() As Boolean
End Interface
